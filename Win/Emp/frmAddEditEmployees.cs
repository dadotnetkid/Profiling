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
using Helpers;
using Models.Repository;

namespace Win.Emp
{
    public partial class frmAddEditEmployees : DevExpress.XtraEditors.XtraForm
    {
        public frmAddEditEmployees()
        {
            InitializeComponent();
        }

        void LoadEmployeeDetails()
        {

        }
        private void frmAddEditEmployees_Load(object sender, EventArgs e)
        {
            this.cboOffice.Properties.DataSource = new UnitOfWork().OfficesRepo.Get();
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                return;
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.EmployeesRepo.Insert(new Models.Employees()
                    {
                        FirstName = txtFirstname.Text,
                        MiddleName = txtMiddleName.Text,
                        LastName = txtLastName.Text,
                        OfficeId = cboOffice.EditValue.ToInt(),
                        Position = txtPosition.Text

                    });
                    unitOfWork.Save();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}