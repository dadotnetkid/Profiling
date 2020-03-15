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
using Models.Repository;
using Models;

namespace Win.Emp
{
    public partial class frmEmployees : DevExpress.XtraEditors.XtraForm
    {
        public frmEmployees()
        {
            InitializeComponent();
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            this.EmployeeBindingSource.DataSource = new UnitOfWork().EmployeesRepo.Get();
            this.OfficeBindingSource.DataSource = new UnitOfWork().OfficesRepo.Get();
        }

        private void EmployeeGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                if (e.Row is Employees item)
                {
                    if (item.Id == 0)
                        unitOfWork.EmployeesRepo.Insert(item);
                    else
                        unitOfWork.EmployeesRepo.Update(item);
                }
                unitOfWork.Save();
            }



        }

        private void repositoryItemButtonDEL_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            if (MessageBox.Show("Do you want to delete this?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                if (EmployeeGrid.GetFocusedRow() is Employees item)
                {
                    using (UnitOfWork unitOfWork = new UnitOfWork())
                    {
                        unitOfWork.EmployeesRepo.Delete(item);
                        unitOfWork.Save();
                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}