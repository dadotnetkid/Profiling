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
using Models.Repository;

namespace Win.Dshbrd
{
    public partial class ucDashboard : DevExpress.XtraEditors.XtraUserControl
    {
        public ucDashboard()
        {
            InitializeComponent();
            LoadWorkOrders();
        }
        public void LoadWorkOrders()
        {
            UnitOfWork unitOfWork = new UnitOfWork();
            this.EmployeeBindingSource.DataSource = unitOfWork.EmployeesRepo.Get();
            this.WorkOrderBindingSource.DataSource = unitOfWork.WorkOrdersRepo.Get(m => m.DocActions.Any(x => x.EndorsedTo == User.UserId));
            this.EquipmentTypeBindingSource.DataSource = unitOfWork.EquipmentTypesRepo.Get();

            WorkOrderGrid.RefreshData();
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            LoadWorkOrders();
        }
    }
}
