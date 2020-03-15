using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Helpers;
using Models;
using Models.Repository;
using Models.ViewModels;
using Win.DocAct;
using Win.Properties;
using Win.Rpt;
using Win.Xcanner;

namespace Win.TS
{
    public partial class frmTechSpecs : DevExpress.XtraEditors.XtraForm
    {
        public frmTechSpecs()
        {
            InitializeComponent();
            this.Icon = Resources.maintenance.ToIcon();
        }

        private void frmTechSpecs_Load(object sender, EventArgs e)
        {
            UcTechSpecGrid.CreateUcControl();
            UcTechSpecGrid.GridView.FocusedRowChanged += GridView_FocusedRowChanged;
        }

        private void GridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (sender is GridView gridView)
            {
                if (gridView.GetFocusedRow() is TechSpecs item)
                {
                    TechSpecDetails.Details(item);
                    lblPODescription.Text = item.TechSpecsId;
                    ucTSEquipmentProfiles1.Details(item.Id, "TechSpecs");
                }
            }


        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Add Tech Spec"))
                return;
            frmAddEditTechSpecs frm = new frmAddEditTechSpecs()
            {
                MethodType = MethodType.Add,
                frmTechSpecs = this

            };
            frm.ShowDialog();
            UcTechSpecGrid.CreateUcControl();
            if (UcTechSpecGrid.GridView.GetFocusedRow() is TechSpecs item)
            {
                TechSpecDetails.Details(item);
                lblPODescription.Text = item.TechSpecsId;
                ucTSEquipmentProfiles1.Details(item.Id, "TechSpecs");
            }
        }




        private void btnEditPo_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Edit Tech Spec"))
                return;
            frmAddEditTechSpecs frm = new frmAddEditTechSpecs()
            {
                frmTechSpecs = this,
                TechSpecsId = Convert.ToInt32((UcTechSpecGrid.GridView.GetFocusedRow() as TechSpecs)?.Id),
                MethodType = MethodType.Edit
            };
            frm.ShowDialog();
            UcTechSpecGrid.CreateUcControl();
            if (UcTechSpecGrid.GridView.GetFocusedRow() is TechSpecs item)
            {
                TechSpecDetails.Details(item);
                lblPODescription.Text = item.TechSpecsId;
                ucTSEquipmentProfiles1.Details(item.Id, "TechSpecs");
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Work Order Action"))
                return;
            try
            {
                if (UcTechSpecGrid.GridView.GetFocusedRow() is TechSpecs item)
                {
                    frmDocActions frm = new frmDocActions(tableName: "TechSpecs",
                        label: item?.Employees?.EmployeeName + " - " + item?.EquipmentTypes?.EquipmentType,
                        refId: item.Id);

                    var res = frm.ShowDialogResult();
                    if (!res.HasAction)
                        return;
                    var unitOfWork = new UnitOfWork();
                    unitOfWork.DocActionsRepo.Insert(res.DocActions);
                    unitOfWork.Save();
                }



            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Load Tech Specs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            LoadActions();
        }
        public void LoadActions()
        {
            try
            {
                if (UcTechSpecGrid.GridView.GetFocusedRow() is TechSpecs item)
                {
                    UcActionGrid.LoadActions(item.Id, "TechSpecs");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load Tech Specs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }




        private void simpleButton1_Click(object sender, EventArgs e)
        {
           

        }


        private void btnScan_Click(object sender, EventArgs e)
        {
            var techSpecs = UcTechSpecGrid.GridView.GetFocusedRow() as TechSpecs;
            if (techSpecs == null)
                return;

            frmScanner frm = new frmScanner(scanners =>
            {
                scanners.RefId = techSpecs.Id;
                scanners.TableName = "TechSpecs";
            });
            frm.ShowDialog();
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            TechSpecRequestDetailViewModel vm = new TechSpecRequestDetailViewModel();
            var techSpecs = UcTechSpecGrid.GridView.GetFocusedRow() as TechSpecs;
            var res = vm.GenerateReport(techSpecs.Id);
            techSpecs.TechSpecRequests.Clear();
            techSpecs.TechSpecRequests = res;
            techSpecs.PrintedBy = User.GetUserName();
            frmReportViewer frm = new frmReportViewer()
            {
                xtraReport = new rptTechSpecs()
                {
                    DataSource = new List<TechSpecs>() { techSpecs }
                }
            };
            frm.ShowDialog();
        }
    }
}