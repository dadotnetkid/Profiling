using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Dashboard;
using Win.Emp;
using Win.Maintenance;
using Win.Profiles;

namespace Win
{
    public partial class _frmMain : Form
    {
        public _frmMain()
        {
            InitializeComponent();
            this.Icon = Icon.FromHandle(new Bitmap(imageList1.Images["computer_64.png"]).GetHicon());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           // new frmLogin(this).ShowDialog();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            showMdi(new frmUsers());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            showMdi(new frmDashboard());
        }

        void showMdi(Form child)
        {


            if ((Application.OpenForms[child.Name]) == null)
            {
                child.MdiParent = this;
                child.Show();
            }
            else
            {

                (Application.OpenForms[child.Name]).WindowState = FormWindowState.Maximized;
                (Application.OpenForms[child.Name]).BringToFront();

            }



        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            showMdi(new _frmMachines());
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            showMdi(new frmEmployees() { WindowState = FormWindowState.Maximized });
        }
    }
}
