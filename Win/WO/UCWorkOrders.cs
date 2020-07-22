using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.Linq;
using DevExpress.XtraEditors;
using Helpers;
using Models;
using Models.Interfaces;
using Models.Repository;
using Models.ViewModels;
using Win.DocAct;
using Win.TS;
using Win.Xcanner;

namespace Win.WO
{
    public partial class UCWorkOrders : DevExpress.XtraEditors.XtraUserControl, ILoad<WorkOrders>
    {
        private int rowHandle;
        private int oldSelectedRow;

        public UCWorkOrders()
        {
            InitializeComponent();
            Init();
        }

        public void Search(string search)
        {
            throw new NotImplementedException();
        }

        public void Init()
        {
            var workOrders = new UnitOfWork().WorkOrdersRepo.Fetch(x => x.PPEId != null);
            WorkOrderGrid.SelectRow(this.rowHandle);
            WorkOrderGridControl.DataSource = new EntityServerModeSource()
            {
                QueryableSource = workOrders,
                DefaultSorting = "Id DESC",

            };
            workOrdersBindingSource.DataSource = workOrders.ToList();

            Details(workOrders.FirstOrDefault());
        }

        public void Details()
        {
            throw new NotImplementedException();
        }

        public void Details(WorkOrders item)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            item = unitOfWork.WorkOrdersRepo.Find(x => x.Id == item.Id);
            cboEmployeeId.EditValue = item.Employees?.EmployeeName;
            txtPosition.Text = item.Employees?.Position;
            txtOffice.Text = item.Employees?.Offices?.OfficeName;
            txtPropNo.EditValue = item.PPEs?.PropertyNo;
            dtRequestedDate.EditValue = item.RequestedDate;
            cboEquipmentType.EditValue = item.PPEs?.EquipmentTypes?.EquipmentType;
            txtDescription.Text = item.PPEs?.Description;
            lblPODescription.Text = item.WorkOrderId + " - " + item.PPEs?.PPEId + " - " + item.PPEs?.EquipmentTypes?.EquipmentType;
            txtFindings.Text = item.Findings;
            txtProblems.Text = item.Problem;
            txtRecommendation.Text = item.Recommendation;
            lblBox.Text = item.Box?.ToString();
            lblFolderNo.Text = item.FolderNo;
            txtDeliveredDescription.Text = item.DeliveredDescription;
            cboDeliveredBy.EditValue = item.DeliveredBy;
            ActionGridControl.DataSource = unitOfWork.DocActionsRepo.Get(m => m.RefId == item.Id && m.TableName == "WorkOrders");
            DocumentGridControl.DataSource = unitOfWork.DocumentsRepo.Get(m => m.RefId == item.Id && m.TableName == "WorkOrders");
            TechnicalEvaluationSheetGridControl.DataSource =
                unitOfWork.TechnicalEvaluationSheetRepo.Get(m => m.WorkOrderId == item.Id);

        }

        private void WorkOrderGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                this.rowHandle = e.FocusedRowHandle;
                if (WorkOrderGrid.GetFocusedRow() is WorkOrders item)
                {
                    Details(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("New Work Order"))
                return;
            frmAddEditWorkOrder frm = new frmAddEditWorkOrder(null, MethodType.Add);
            frmAddEditWorkOrder res = frm.ShowDialogResult() as frmAddEditWorkOrder;
            Init();
            var rowHandle = this.WorkOrderGrid.LocateByValue("Id", res.workOrders.Id);
            WorkOrderGrid.FocusedRowHandle = rowHandle;
            WorkOrderGrid.MakeRowVisible(rowHandle);


        }
        /*
         *if (UcTechSpecGrid.GridView.GetFocusedRow() is TechSpecs item)
            {
                this.oldData = item;
                this.oldSelectedRow = UcTechSpecGrid.GridView.FocusedRowHandle;
                frmAddEditTechSpecs frm = new frmAddEditTechSpecs()
                {
                    frmTechSpecs = this,
                    TechSpecsId = Convert.ToInt32((UcTechSpecGrid.GridView.GetFocusedRow() as TechSpecs)?.Id),
                    MethodType = MethodType.Edit
                };
                frm.ShowDialog();
                UcTechSpecGrid.CreateUcControl();

                TechSpecDetails.Details(item);
                lblPODescription.Text = item.TechSpecsId;
                ucTSEquipmentProfiles1.Details(item.Id, "TechSpecs");
                UcTechSpecGrid.GridView.SelectRow(this.oldSelectedRow);
                UcTechSpecGrid.GridView.FocusedRowHandle = this.oldSelectedRow;
                UcTechSpecGrid.GridView.MakeRowVisible(oldSelectedRow);
            }
         *
         */
        private void btnEditPo_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Edit Work Order"))
                return;
            if (WorkOrderGrid.GetFocusedRow() is WorkOrders item)
            {

                this.rowHandle = WorkOrderGrid.FocusedRowHandle;
                frmAddEditWorkOrder frm = new frmAddEditWorkOrder(item, MethodType.Edit);
                frm.ShowDialog();

                Details(item);
                Init();
                WorkOrderGrid.FocusedRowHandle = rowHandle;
                WorkOrderGrid.SelectRow(rowHandle);
                WorkOrderGrid.MakeRowVisible(rowHandle);
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Work Order Action"))
                return;
            if (WorkOrderGrid.GetFocusedRow() is WorkOrders item)
            {
                frmDocActions frm = new frmDocActions(tableName: "WorkOrders", refId: item.Id,
                label: item?.Employees?.EmployeeName + " - " + item?.PPEs?.EquipmentTypes?.EquipmentType);
                frm.ShowDialog();
                Details(item);
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (WorkOrderGrid.GetFocusedRow() is WorkOrders item)
            {
                frmScanner frmScanPO = new frmScanner(scanner =>
                {
                    scanner.RefId = item.Id;
                    scanner.TableName = "WorkOrders";
                });
            }
        }

        private void btnEvalSheet_Click(object sender, EventArgs e)
        {
            if (WorkOrderGrid.GetFocusedRow() is WorkOrders item)
            {
                frmTechnicalEvalSheet frmTechnicalEvalSheet = new frmTechnicalEvalSheet()
                {
                    WorkOrderId = item.Id
                };
                frmTechnicalEvalSheet.ShowDialog();
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

        private void btnEditRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ActionGrid.GetFocusedRow() is DocActions item)
            {
                frmDocActions frm = new frmDocActions(tableName: "WorkOrders", refId: item.WorkOrders.Id, label: item.WorkOrders?.Employees?.EmployeeName + " - " + item.WorkOrders?.PPEs?.EquipmentTypes?.EquipmentType)
                {
                    DocActions = item,
                    MethodType = MethodType.Edit,
                };
                frm.ShowDialog();
                Init();
            }
        }

        private void btnDelRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (ActionGrid.GetFocusedRow() is DocActions item)
            {

                if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
                try
                {
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.DocActionsRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Details(unitOfWork.WorkOrdersRepo.Find(x => x.Id == item.RefId));
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (WorkOrderGrid.GetFocusedRow() is WorkOrders item)
            {
                try
                {

                    if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                    UnitOfWork unitOfWork = new UnitOfWork();
                    unitOfWork.WorkOrdersRepo.Delete(x => x.Id == item.Id);
                    unitOfWork.Save();
                    Init();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnFileDownload_ButtonClick(object sender,
            DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        private void btnTS_Click(object sender, EventArgs e)
        {
            if (WorkOrderGrid.GetFocusedRow() is WorkOrders workOrders)
            {
                if (Application.OpenForms["FrmMain"] is FrmMain frmMain)
                {
                    frmMain.pnlDashoard.Controls.Clear();
                    var ts = new frmTechSpecs() { Dock = DockStyle.Fill };
                    frmMain.pnlDashoard.Controls.Add(ts);
                    ts.NewTS(workOrders);
                }


            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_EditValueChanged(object sender, EventArgs e)
        {
            Search();
        }

        void Search()
        {
            if (txtSearch.GetSelectedDataRow() is WorkOrders wo)
            {
                var workOrders= new UnitOfWork().WorkOrdersRepo.Get(x => x.Id == wo.Id);
                WorkOrderGridControl.DataSource = workOrders;
                this.Details(workOrders.FirstOrDefault());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
