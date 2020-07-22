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

namespace Win.TS
{
    public partial class UcTechSpecGrid : DevExpress.XtraEditors.XtraUserControl
    {
        public GridView GridView => this.TechSpecGrid;


        public UcTechSpecGrid()
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

        }
        public List<TechSpecs> Search(string search = "")
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            IQueryable<TechSpecs> techSpecs = unitOfWork.TechSpecsRepo.Fetch(x => x.DateRequested != null);
            if (search == "")
            {
                this.TechSpecBindingSource.DataSource = techSpecs.ToList();
                return techSpecs.ToList();
            }
               
            if (techSpecs.Any(x => (x.Employees.FirstName + " " + x.Employees.MiddleName + " " + x.Employees.LastName).Contains(search)))
            {
                techSpecs = techSpecs.Where(x =>
                    (x.Employees.FirstName + " " + x.Employees.MiddleName + " " + x.Employees.LastName)
                    .Contains(search));
            }



            if (techSpecs.Any(m => m.Employees.Offices.OfficeName.Contains(search)))
            {
                techSpecs = techSpecs.Where(m => m.Employees.Offices.OfficeName.Contains(search));
            }
            if (techSpecs.Any(m => m.Employees.Offices.OffcAcr.Contains(search)))
            {
                techSpecs = techSpecs.Where(m => m.Employees.Offices.OffcAcr.Contains(search));
            }
            if (techSpecs.ToList().Any(m => m.TechSpecsId.Contains(search)))
            {
                techSpecs = techSpecs.ToList().Where(m => m.TechSpecsId.Contains(search)).AsQueryable();
            }
            this.TechSpecBindingSource.DataSource = techSpecs.ToList();
            return techSpecs.ToList();
            /*  this.TechSpecBindingSource.DataSource = unitOfWork.TechSpecsRepo.Paginate(m => m.OrderBy(x => x.Id), 1000, 0, 
                  m => m.Requestedby == 0 || 
                       m.TechSpecsId.Contains(search) ||
                       m.Employees.Offices.OfficeName.Contains(search)||
                       m.Employees.FirstName.StartsWith(search) || m.Employees.LastName.StartsWith(search) || m.Employees.FirstName=="");
                       */

        }
        public void CreateUcControl()
        {

            try
            {
                UnitOfWork unitOfWork = new UnitOfWork();

                this.TechSpecBindingSource.DataSource = unitOfWork.TechSpecsRepo.Paginate(m => m.OrderBy(x => x.Id), 20, 0);
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

                this.TechSpecBindingSource.DataSource = unitOfWork.TechSpecsRepo.Paginate(m => m.OrderBy(x => x.Id), 20, 0, m => m.DocActions.Any(x => x.TableName == "TechSpec" && x.EndorsedTo == User.UserId));
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
