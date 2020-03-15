using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Win.Properties;
using Helpers;
using Microsoft.Data.ConnectionUI;
using Win.Dlvry;
using Win.Dshbrd;
using Win.PO;
using Win.Sup;
using Win.Emp;
using Win.Rpt;
using Win.TS;
using Win.Usr;
using Win.WO;

namespace Win
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bool IsConnected { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            this.Icon = Resources.favicon.ToIcon();


        }

        private void btnEquipments_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barOffices_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("Offices"))
                return;
            Ofc.frmOffices frm = new Ofc.frmOffices();
            frm.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {



            frmLogin frmLogin = new frmLogin(this);
            frmLogin.ShowDialog();
          //  ucTechSpecGrid1.LoadDashboard();
            if (pnlDashoard.Controls.Count <= 0)
            {
                // var dashboard = new ucDashboard();
                //   this.pnlDashoard.Controls.Add(new ucDashboard() { Dock = DockStyle.Fill });
                this.lblUser.Caption = $"User: {User.GetFullName()}";
            //    ucTechSpecGrid1.LoadDashboard();
            }

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("Users"))
                return;
            frmUsers frmUsers = new frmUsers();
            frmUsers.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("User Roles"))
                return;
            frmUserRoles frm = new frmUserRoles();
            frm.ShowDialog();
        }

        private void backstageViewTabItem1_ItemPressed(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

            backstageViewControl1.Close();
            frmLogin frmLogin = new frmLogin(this) { };
            frmLogin.ShowDialog();
            //ucTechSpecGrid1.LoadDashboard();
            //var th = new Thread(() =>
            //{
            //    Invoke(new Action(() =>
            //    {

            //    }));

            //});

            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("Deliveries"))
                return;
            frmDeliveries frm = new frmDeliveries();
            frm.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("Suppliers"))
                return;
            frmSuppliers frm = new frmSuppliers();
            frm.ShowDialog();
        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("Employees"))
                return;
            frmEmployees frm = new frmEmployees();

            frm.ShowDialog();
        }

        private void barButtonItem8_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("Equipment Profiles"))
                return;
            frmEquipmentProfiles frm = new frmEquipmentProfiles();
            frm.ShowDialog();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("Work Orders"))
                return;

            frmWorkOrders frm = new frmWorkOrders();
            frm.ShowDialog();
        }

        private void backstageViewTabItem1_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAccomplishmentReport frm = new frmAccomplishmentReport();
            frm.ShowDialog();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTechSpecs frmTechSpecs = new frmTechSpecs();
            frmTechSpecs.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            MESAF.frmMES frm = new MESAF.frmMES();
            frm.ShowDialog();
        }
    }
}