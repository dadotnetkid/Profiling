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

namespace Win.MESAF
{
    public partial class frmAddEditMES : DevExpress.XtraEditors.XtraForm
    {
        private MES oldItem;
        private MethodType methodType;
        private int mESId;

        public frmAddEditMES()
        {
            InitializeComponent();

            dtDate.DateTime = DateTime.Now;


        }

        public frmAddEditMES(MES oldItem, MethodType methodType)
        {

            InitializeComponent();

            dtDate.DateTime = DateTime.Now;
            this.oldItem = oldItem;
            this.methodType = methodType;



            Details(oldItem);
        }

        private void frmAddEditMES_Load(object sender, EventArgs e)
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            OfficeBindingSource.QueryableSource = unitOfWork.OfficesRepo.Fetch();
            EmployeeBindingSource.DataSource = unitOfWork.EmployeesRepo.Fetch().ToList();
            ItemSpecBindingSource.DataSource = unitOfWork.MESRepo.Fetch().GroupBy(x => x.ItemSpec)
                .Select(x => new { ItemSpec = x.Key }).ToList();
            if (methodType == MethodType.Add)
            {
                this.mESId = (unitOfWork.MESRepo.Fetch().OrderByDescending(x => x.Id).Select(x => new { x.Id }).FirstOrDefault()?.Id ?? 0) + 1;
                unitOfWork.MESRepo.InsertIdentity($"MES", $"insert into mes(id,MESId) values({mESId},'{mESId.ToString("EPiS-0000")}')");
                this.lblMESNo.Text = mESId.ToString("EPiS-0000");
            }

        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to submit this?", "Submit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (methodType == MethodType.Add)
                Add(getMes());
            else
                Edit(getMes());
            this.Close();

        }

        void Details(MES mes)
        {
            txtEmployee.EditValue = mes.EmployeeId;
            txtOffice.EditValue = mes.OfficeId;
            txtRequest.Text = mes.Request;
            txtItemSpec.Text = mes.ItemSpec;
            lblMESNo.Text = mes.MESId;
            txtPosition.Text = mes.Position;
        }
        void Edit(MES mes)
        {
            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    mes.Id = oldItem.Id;
                    mes.DateCreated = oldItem.DateCreated;
                    mes.ReceivedBy = oldItem.ReceivedBy;
   
                    mes.MESId = oldItem.Id.ToString("EPiS-0000");
                    unitOfWork.MESRepo.Update(mes);
                    unitOfWork.Save();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void Add(MES mes)
        {

            try
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    mes.Id = this.mESId;
                    mes.MESId = this.mESId.ToString("EPiS-0000");
                    mes.DateCreated = DateTime.Now;
                    unitOfWork.MESRepo.Update(mes);
                    unitOfWork.Save();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, e.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        MES getMes() => new MES()
        {
            DateCreated = dtDate.EditValue.ToDate(),
            EmployeeId = txtEmployee.EditValue.ToInt(),
            OfficeId = txtOffice.EditValue.ToInt(),
            Position = txtPosition.Text,
            ItemSpec = txtItemSpec.Text,
            Request = txtRequest.Text,
            ReceivedBy = User.UserId,
           
        };

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            Emp.frmAddEditEmployees frm = new Emp.frmAddEditEmployees();
            frm.ShowDialog();
            EmployeeBindingSource.DataSource =new UnitOfWork().EmployeesRepo.Fetch().ToList();
        }

        private void txtEmployee_EditValueChanged(object sender, EventArgs e)
        {
            if (txtEmployee.GetSelectedDataRow() is Employees item)
            {
                txtPosition.Text = item.Position;
            }
        }
    }
}