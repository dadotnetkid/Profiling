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
using Models;
using Models.Repository;

namespace Win.Ofc
{
    public partial class frmAddEditOffices : DevExpress.XtraEditors.XtraForm
    {
        private MethodType methodType;
        private Offices oldValue;
        private Offices _offices;


        public frmAddEditOffices(Offices oldValue, MethodType methodType)
        {
            InitializeComponent();
            this.methodType = methodType;
            this.oldValue = oldValue;
            Details();
        }

        void Details()
        {
            if (oldValue == null)
                return;


            txtOffcAcr.Text = oldValue.OffcAcr;
            txtChief.Text = oldValue.OfficeName;
            txtPosition.Text = oldValue.Position;
            txtChief.Text = oldValue.Chief;
            txtBoxNo.Text = oldValue.BoxNo.ToString();
            txtTelNumber.Text = oldValue.TelNo;
            txtOfficeName.Text = oldValue.OfficeName;
        }

        Offices Offices
        {
            get
            {
                if (_offices == null)
                    _offices = new Offices()
                    {
                        OffcAcr = txtOffcAcr.Text,
                        OfficeName = txtOfficeName.Text,
                        Position = txtPosition.Text,
                        Chief = txtChief.Text,
                        BoxNo = txtBoxNo.EditValue?.ToInt(),
                        TelNo = txtTelNumber.Text,
                    };
                return _offices;
            }
            set => _offices = value;
        }


        void Add()
        {

            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Offices.DateCreated = DateTime.Now;
                unitOfWork.OfficesRepo.Insert(Offices);
                unitOfWork.Save();
            }
        }

        void Edit()
        {
            using (UnitOfWork unitOfWork = new UnitOfWork())
            {
                Offices.DateCreated = oldValue.DateCreated;
                Offices.Id = oldValue.Id;
                unitOfWork.OfficesRepo.Update(Offices);
                unitOfWork.Save();
            }
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (methodType == MethodType.Add)
                Add();
            else
                Edit();
            this.Close();
        }

        private void frmAddEditOffices_Load(object sender, EventArgs e)
        {
            EmployeeBindingSource.DataSource = new UnitOfWork().EmployeesRepo.Get().Select(x => new Employees { EmployeeName = x.FirstName + " " + x.MiddleName + " " + x.LastName });
        }

        private void txtChief_EditValueChanged(object sender, EventArgs e)
        {
            if (txtChief.GetSelectedDataRow() is Employees item)
            {
                txtPosition.Text = item.Position;
            }
        }
    }
}