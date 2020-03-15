using Models;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Emp;
using Win.Maintenance;
using Win.Offices;
using Win.Profiles;
using Win.Sup;
using Win.UserLevel;

namespace Win
{
    public partial class Main : RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin(this);
            frmLogin.ShowDialog();
        }

        private void btnEquipments_Click(object sender, EventArgs e)
        {
            _frmMachines frmMachines = new _frmMachines();
            frmMachines.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmEmployees frmEmployees = new frmEmployees();
            frmEmployees.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmOffices frmOffices = new frmOffices();
            frmOffices.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.ShowDialog();
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            frmUserRoles frmUserRoles = new frmUserRoles();
            frmUserRoles.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            frmSuppliers frmSuppliers = new frmSuppliers();
            frmSuppliers.ShowDialog();
        }
    }
}
