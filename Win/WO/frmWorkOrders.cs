using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Helpers;
using Models;
using Models.Repository;
using Models.ViewModels;
using Win.DocAct;
using Win.PO;
using Win.Properties;
using Win.Xcanner;

namespace Win.WO
{
    public partial class frmWorkOrders : DevExpress.XtraEditors.XtraForm
    {
        private int WOId;
        private WorkOrders WorkOrders;
        public frmWorkOrders()
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
        }

        private void frmWorkOrders_Load(object sender, EventArgs e)
        {
            LoadWorkOrders();
        }

        private void Search(string search = "")
        {

            UnitOfWork unitOfWork = new UnitOfWork();

            this.WorkOrderBindingSource.DataSource = unitOfWork.WorkOrdersRepo.Paginate(m => m.OrderByDescending(x => x.Id).ThenBy(x => x.Id),
                filter: x => (x.WorkOrderId.Contains(search) || x.PPEs.PropertyNo.StartsWith(search) || x.PPEs.Employees.FirstName.StartsWith(search) || x.PPEs.Offices.OfficeName.StartsWith(search)) && x.DocActions.Any(m => m.Status != "Completed"));
            LoadWorkOrderDetails(0);
        }
        public void LoadWorkOrders()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            Search();
            this.EmployeeBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();

            this.EquipmentTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();
            this.ProgramLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Programs");
            this.MainActLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Projects");
            this.ActivityLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Activity");
            this.SubActLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "SubActivity");

            WorkOrderGrid.RefreshData();
            LoadWorkOrderDetails(0);
        }

        public void LoadWorkOrderDetails(int row)
        {
            if (WorkOrderGrid.GetRow(row) is WorkOrders item)
            {
                cboEmployeeId.EditValue = item.Employees?.Id;
                txtPosition.Text = item.Employees?.Position;
                txtOffice.Text = item.Employees?.Offices?.OfficeName;
                txtPropNo.EditValue = item.PPEs?.PropertyNo;
                dtRequestedDate.EditValue = item.RequestedDate;
                cboEquipmentType.EditValue = item.PPEs?.EquipmentTypeId;
                txtDescription.Text = item.PPEs?.Description;
                lblPODescription.Text = item.WorkOrderId + " - " + item.PPEs?.PPEId + " - " + item.PPEs?.EquipmentTypes?.EquipmentType;
                txtFindings.Text = item.Findings;
                txtProblems.Text = item.Problem;
                txtRecommendation.Text = item.Recommendation;
                lblBox.Text = item.Box?.ToString();
                this.WOId = item.Id;
                this.WorkOrders = item;
                lblFolderNo.Text = item.FolderNo;
                txtDeliveredDescription.Text = item.DeliveredDescription;
                cboDeliveredBy.EditValue = item.DeliveredBy;
                this.DocumentBindingSource.DataSource =
                    new UnitOfWork().DocumentsRepo.Get(m => m.RefId == item.Id && m.TableName == "WorkOrders");
                LoadActions();
                LoadTechEvalSheet();

            }
        }

        void LoadTechEvalSheet()
        {

            EvaluationLookUpRepo.DataSource = new UnitOfWork().EvaluationSheetsRepo.Get();
            this.gridControl1.DataSource = new UnitOfWork().TechnicalEvaluationSheetRepo.Get(m => m.WorkOrderId == WOId);
        }

        public void LoadActions()
        {
            ActionBindingSource.DataSource = new UnitOfWork().DocActionsRepo.Get(m => m.RefId == WOId && m.TableName == "WorkOrders");
            ActionGrid.RefreshData();
        }
        private void WorkOrderGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            LoadWorkOrderDetails(e.FocusedRowHandle);
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("New Work Order"))
                return;
            frmAddEditWorkOrder frm = new frmAddEditWorkOrder()
            {
                frmWorkOrders = this,
                MethodType = MethodType.Add
            };
            frm.ShowDialog();
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Edit Work Order"))
                return;
            frmAddEditWorkOrder frm = new frmAddEditWorkOrder()
            {
                frmWorkOrders = this,
                WOId = this.WOId,
                MethodType = MethodType.Edit
            };
            frm.ShowDialog();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Work Order Action"))
                return;
            frmDocActions frm = new frmDocActions(tableName: "WorkOrders", refId: WOId,
                label: WorkOrders?.Employees?.EmployeeName + " - " + WorkOrders?.PPEs?.EquipmentTypes?.EquipmentType);

            var res = frm.ShowDialogResult();

            LoadActions();
        }

        private void WorkOrderGrid_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            if (e.Column.Name == "WorkOrderId")
            {
                if (WorkOrderGrid.GetRow(e.RowHandle) is WorkOrders item)
                {
                    //     if (item.WOActions.OrderByDescending(m => m.Id)?.FirstOrDefault()?.Status == "")
                    var status = item.DocActions.OrderByDescending(m => m.Id)?.FirstOrDefault()?.Status;
                    var customValue = new UnitOfWork().StatusesRepo.Find(m => m.Value == status && m.TableName == "Status")?.CustomValue;
                    var color = System.Drawing.ColorTranslator.FromHtml(customValue);
                    e.Appearance.BackColor = color;
                }
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Work Order Scan Document"))
                return;
            frmScanner frmScanPO = new frmScanner(scanner =>
                {
                    scanner.RefId = Convert.ToInt32((WorkOrderGrid.GetFocusedRow() as WorkOrders)?.Id);
                    scanner.TableName = "WorkOrders";
                });

            var res = frmScanPO.ShowDialogResult();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmTechnicalEvalSheet frmTechnicalEvalSheet = new frmTechnicalEvalSheet()
            {
                WorkOrderId = this.WOId
            };
            frmTechnicalEvalSheet.ShowDialog();
        }

        private void btnEditRepo_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ActionGrid.GetFocusedRow() is DocActions item)
            {
                frmDocActions frm = new frmDocActions(tableName: "WorkOrders", refId: WOId, label: WorkOrders?.Employees?.EmployeeName + " - " + WorkOrders?.PPEs?.EquipmentTypes?.EquipmentType)
                {
                    DocActions = item,
                    MethodType = MethodType.Edit,
                };
                frm.ShowDialog();
            }
        }




        private void searchControl1_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }



        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {

                if (WorkOrderGrid.GetFocusedRow() is WorkOrders item)
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.WorkOrdersRepo.Delete(m => m.Id == item.Id);
                    unitOfWork.Save();
                    LoadWorkOrders();
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search(searchControl1.Text);
            }
        }

        private void WorkOrderGrid_DoubleClick(object sender, EventArgs e)
        {
            if (!User.UserInAction("Edit Work Order"))
                return;

            frmAddEditWorkOrder frm = new frmAddEditWorkOrder()
            {
                frmWorkOrders = this,
                WOId = Convert.ToInt32(((sender as GridView)?.GetFocusedRow() as WorkOrders)?.Id),
                MethodType = MethodType.Edit
            };
            frm.ShowDialog();
        }

        private void btnDelRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    if (ActionGrid.GetFocusedRow() is DocActions item)
                    {
                        unitOfWork.DocActionsRepo.Delete(m => m.Id == item.Id);
                        unitOfWork.Save();
                    }
                    ActionBindingSource.DataSource = unitOfWork.DocActionsRepo.Get(m => m.RefId == WOId && m.TableName == "WorkOrders");
                    ActionGrid.RefreshData();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (WorkOrderGrid.GetFocusedRow() is WorkOrders item)
            {
                DocumentLedgerViewModel vm = new DocumentLedgerViewModel();
                vm.WorkOrders = item;
                vm.DocActions = vm.GetDocActions(item.Id);
                vm.PrintedBy = User.GetUserName();
                Rpt.rptDocumentLedger rpt = new Rpt.rptDocumentLedger()
                {
                    DataSource = new List<DocumentLedgerViewModel>() { vm }

                };
                rpt.CreateDocument();
                Rpt.frmReportViewer frm = new Rpt.frmReportViewer(rpt);
                frm.ShowDialog();
            }

        }

        private void btnPrintTR_Click(object sender, EventArgs e)
        {
            if (WorkOrderGrid.GetFocusedRow() is WorkOrders item)
            {
                item.PrintedBy = User.GetUserName();
                Rpt.rptTechnicalReport rpt = new Rpt.rptTechnicalReport()
                {
                    DataSource = new List<WorkOrders>() { item }

                };
                rpt.CreateDocument();
                Rpt.frmReportViewer frm = new Rpt.frmReportViewer(rpt);
                frm.ShowDialog();
            }
        }

        private void tabNavigationPage3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnFileDownload_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DocumentGrid.GetFocusedRow() is Documents documents)
            {
                SaveFileDialog dialog = new SaveFileDialog()
                {
                    OverwritePrompt = true,
                    AddExtension = true,
                    DefaultExt = documents.ExtName.Replace(".", "")
                };
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (NetworkShareAccesser.Access("PLGUNV_ADSERVER", @"PLGUNV", "administrator", "itpower@123"))
                    {
                        try
                        {
                            File.Copy(Path.Combine(documents.RootDirectory, documents.FileId + documents.ExtName),
                                dialog.FileName);
                        }
                        catch (Exception exception)
                        {
                            MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                        }

                    }
                }
            }

        }

        private void btnFileView_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (DocumentGrid.GetFocusedRow() is Documents documents)
            {
                using (NetworkShareAccesser.Access("PLGUNV_ADSERVER", @"PLGUNV", "administrator", "itpower@123"))
                {
                    try
                    {
                        XtraForm xtraForm = new XtraForm() { StartPosition = FormStartPosition.CenterScreen };
                        var pct = new PictureEdit()
                        {
                            Dock = DockStyle.Fill,
                            Image = Image.FromFile(Path.Combine(documents.RootDirectory,
                                documents.FileId + documents.ExtName)),
                        };
                        pct.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
                        xtraForm.Controls.Add(pct);
                        xtraForm.ShowDialog();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                    }

                }
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}