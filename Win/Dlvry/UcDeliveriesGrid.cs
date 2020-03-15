using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Models;
using Models.Repository;

namespace Win.Dlvry
{
    public partial class UcDeliveryGrid : DevExpress.XtraEditors.XtraUserControl
    {
        public GridView GridView => this.TechSpecGrid;


        public UcDeliveryGrid()
        {
            InitializeComponent();
        }

        private void TechSpecGrid_DoubleClick(object sender, EventArgs e)
        {

        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (!User.UserInAction("Delete Tech Spec"))
                return;

            if (MessageBox.Show("Do you want to delete this", "Deleting", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                var techSpecs = GridView.GetFocusedRow() as TechSpecs;
                if (techSpecs == null)
                    return;
                unitOfWork.TechSpecsRepo.Delete(techSpecs.Id);
                unitOfWork.Save();
            }
            CreateUcControl();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search(txtSearch.Text);
        }
        public void Search(string search = "")
        {
            UnitOfWork unitOfWork = new UnitOfWork();
       //     this.TechSpecBindingSource.DataSource = unitOfWork.TechSpecsRepo.Paginate(m => m.OrderBy(x => x.Id), 20, 0, m => m.Requestedby == 0 || m.Employees.FirstName.StartsWith(search) || m.Employees.LastName.StartsWith(search));


        }
        public void CreateUcControl()
        {

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();

              //  this.TechSpecBindingSource.DataSource = unitOfWork.TechSpecsRepo.Paginate(m => m.OrderBy(x => x.Id), 20, 0);
                //this.OfficeBindingSource.DataSource = unitOfWork.OfficesRepo.Get();
                //this.EmployeeBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();
                //this.EquipmentTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();
                //this.UnitTypeBindingSource.DataSource = unitOfWork.UnitTypesRepo.Get();
                //this.AssignedToBindingSource.DataSource = unitOfWork.UsersRepo.Get();
                Search(txtSearch.Text);
                TechSpecGrid.RefreshData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load Tech Specs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        public void LoadDashboard()
        {

            try
            {
                PPEDel.Visible = false;
                UnitOfWork unitOfWork = new UnitOfWork();

              //  this.TechSpecBindingSource.DataSource = unitOfWork.TechSpecsRepo.Paginate(m => m.OrderBy(x => x.Id), 20, 0, m => m.DocActions.Any(x => x.TableName == "TechSpec" && x.EndorsedTo == User.UserId));
                //this.OfficeBindingSource.DataSource = unitOfWork.OfficesRepo.Get();
                //this.EmployeeBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();
                //this.EquipmentTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();
                //this.UnitTypeBindingSource.DataSource = unitOfWork.UnitTypesRepo.Get();
                //this.AssignedToBindingSource.DataSource = unitOfWork.UsersRepo.Get();
                Search(txtSearch.Text);
                TechSpecGrid.RefreshData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Load Tech Specs", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtSearch_Properties_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
