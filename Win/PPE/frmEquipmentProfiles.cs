using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Helpers;
using Models;
using Models.Repository;
using Win.DocAct;
using Win.EquipProfile;
using Win.Properties;

namespace Win
{
    public partial class frmEquipmentProfiles : DevExpress.XtraEditors.XtraForm
    {
        private PPEs PPEs;
        public int PropertyId { get; set; }


        public frmEquipmentProfiles()
        {
            InitializeComponent();
            this.Icon = Resources.computer.ToIcon();
        }

        private void frmEquipmentProfiles_Load(object sender, EventArgs e)
        {
            LoadEquipmentProfiles();
        }
        void LoadPPEDetails(PPEs item)
        {

            try
            {
                this.EquipmentProfileBindingSource.DataSource =
                    new UnitOfWork().EquipmentProfilesRepo.Get(m => m.RefId == item.Id && m.TableName == "EquipmentProfiles");
                this.ActionGridControl.DataSource =
                    new UnitOfWork().DocActionsRepo.Get(m => m.RefId == item.Id && m.TableName == "PPEs");
                var unitOfWork = new UnitOfWork();
                lblPODescription.Text = item.PropertyNo + " - " + item.EquipmentTypes?.EquipmentType;

                txtPropNo.Text = item.PropertyNo;

                cboOffice.EditValue = item?.OfficeId;
                txtChief.Text = item.Offices?.Chief;
                txtTel.Text = item.Offices?.TelNo;
                cboEmployeeId.EditValue = item.EmployeeId;
                txtPosition.Text = item.Employees?.Position;
                cboOffice.EditValue = item.Employees?.Offices?.Id;
                txtDescription.Text = item.Description;
                cboEquipmentType.EditValue = item.EquipmentTypeId;
                dtDeliveredDate.EditValue = item.DateDelivered?.ToDate();
                txtBarcode.Text = item.Barcode;
                txtSerial.Text = item.Serial;
                txtBoxNo.Text = item.BoxNumber?.ToString();
                txtTel.Text = item.Employees?.Offices?.TelNo;
                txtChief.Text = item.Employees?.Offices?.Chief;
                dtPurchaseDate.EditValue = item.PurchaseDate;
                this.EquipmentProfileBindingSource.DataSource = unitOfWork.EquipmentProfilesRepo.Get(m => m.RefId == item.Id && m.TableName == "EquipmentProfiles");
                this.PropertyId = item.Id;


                this.ActionGridControl.DataSource =
                    unitOfWork.DocActionsRepo.Get(m => m.RefId == item.Id && m.TableName == "PPEs");
                this.PPEs = item;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load PPE Details", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        public void LoadEquipmentProfiles()
        {
            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();
                this.PPEBindingSource.DataSource = unitOfWork.PPEsRepo.Paginate(m => m.OrderBy(x => x.Id), 20, 0);
                this.OfficeBindingSource.DataSource = unitOfWork.OfficesRepo.Get();
                this.EmployeeBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();
                this.EquipmentTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();
                this.UnitTypeBindingSource.DataSource = unitOfWork.UnitTypesRepo.Get();
                this.ProgramLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Programs");
                this.MainActLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Projects");
                this.ActivityLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "Activity");
                this.SubActLookUpRepo.DataSource = unitOfWork.DropdownsRepo.Get(m => m.Category == "SubActivity");
                search(txtSearch.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load Equipment Profiles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }




        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("New Equipment Profile"))
                return;
            frmAddEditEquipmentProfiles frm = new frmAddEditEquipmentProfiles()
            {
                frmEquipmentProfiles = this,
                MethodType = MethodType.Add,

            };
            frm.ShowDialog();
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Edit Equipment Profile"))
                return;
            frmAddEditEquipmentProfiles frm = new frmAddEditEquipmentProfiles()
            {
                PropertyId = PropertyId,
                MethodType = MethodType.Edit,
                frmEquipmentProfiles = this
            };
            frm.ShowDialog();
        }

        private void PPEGrid_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                if (sender is GridView grid)
                {
                    if (grid.GetFocusedRow() is PPEs item)
                    {
                        LoadPPEDetails(item);
                    }
                }

            }

        }


        private void repositoryItemButtonEdit2_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("Delete Equipment Profile"))
                return;

            if (MessageBox.Show("Do you want to delete this", "Deleting", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.No)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                unitOfWork.PPEsRepo.Delete(PropertyId);
                unitOfWork.Save();
            }

            this.LoadEquipmentProfiles();
            PPEGrid.RefreshData();
        }



        private void btnScan_Click(object sender, EventArgs e)
        {
            var relationCount = EquipmentGrid.GetRelationCount(0);
            var childView = EquipmentGrid.GetDetailView(0, 0) as GridView;
            //        EquipmentGrid.ExpandMasterRow(0, 0);
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            if (!User.UserInAction("New Equipment Profile Action"))
                return;

            frmDocActions frm = new frmDocActions( tableName: "PPEs",
               label: PPEs?.Employees?.EmployeeName + " - " + PPEs?.EquipmentTypes?.EquipmentType, refId: this.PropertyId);

            var res = frm.ShowDialogResult();
            if (!res.HasAction)
                return;

            try
            {
                using (var unitOfWork = new UnitOfWork())
                {
                    unitOfWork.DocActionsRepo.Insert(res.DocActions);
                    unitOfWork.Save();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "New Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            LoadEquipmentProfiles();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        public void search(string search = "")
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.PPEBindingSource.DataSource = unitOfWork.PPEsRepo.Paginate(m => m.OrderBy(x => x.Id), 20, 0, m => m.PPEId.StartsWith(search) || m.Description.StartsWith(search) || m.Employees.FirstName.StartsWith(search) || m.Employees.LastName.StartsWith(search));

            if (PPEGrid.GetRow(0) is PPEs item)
            {
                LoadPPEDetails(item);
            }
        }

        private void PPEGrid_RowLoaded(object sender, DevExpress.XtraGrid.Views.Base.RowEventArgs e)
        {

        }




        private void searchControl1_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        //  private Timer searchTimer => new Timer() { Interval = 3000 };
        bool isSearching = false;
        private Random random = new Random();
        private void searchControl1_TextChanged(object sender, EventArgs e)
        {
            //if (isSearching)
            //    return;

            //isSearching = true;
            //searchTimer.Start();
        }

        private void PPEGrid_Click(object sender, EventArgs e)
        {
            if (sender is GridView grid)
            {
                if (grid.GetFocusedRow() is PPEs item)
                {
                    LoadPPEDetails(item);
                }
            }
        }

        private void searchTimer_Tick(object sender, EventArgs e)
        {
            isSearching = false;




            searchTimer.Interval = random.Next(150, 1500);
            searchTimer.Stop();
        }

        private void txtSearch_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            search(txtSearch.Text);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                search(txtSearch.Text);
        }
    }
}
;