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
using Win.DocAct;
using Win.Dshbrd;
using Win.PO;
using Win.Sup;
using Win.Emp;
using Win.MESAF;
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

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();
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
            frmEquipmentProfiles frm = new frmEquipmentProfiles()
            {
                Dock = DockStyle.Fill
            };
            pnlDashoard.Controls.Clear();

            pnlDashoard.Controls.Add(frm);
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {

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
            var frmTechSpecs = new frmTechSpecs()
            {
                Dock = DockStyle.Fill
            };
            pnlDashoard.Controls.Clear();
            pnlDashoard.Controls.Add(frmTechSpecs);
            // frmTechSpecs.ShowDialog();
        }

        private void barButtonItem12_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("MES"))
                return;
            pnlDashoard.Controls.Clear();
            pnlDashoard.Controls.Add(new frmMES()
            {
                Dock = DockStyle.Fill
            });
            // frm.ShowDialog();
        }

        private void btnDocActionTreeList_ItemClick(object sender, ItemClickEventArgs e)
        {
            DocAct.frmDocActionTreeList frm = new DocAct.frmDocActionTreeList();
            frm.ShowDialog();
        }

        private void btnStatus_ItemClick(object sender, ItemClickEventArgs e)
        {
            sts.frmStatus frm = new sts.frmStatus();
            frm.ShowDialog();
        }

        private void btnDeliveries_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("Deliveries"))
                return;
            pnlDashoard.Controls.Clear();
            pnlDashoard.Controls.Add(new UCDeliveries()
            {
                Dock = DockStyle.Fill
            });
        }

        private void btnWO_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("Work Orders"))
                return;

            pnlDashoard.Controls.Clear();
            pnlDashoard.Controls.Add(new UCWorkOrders()
            {
                Dock = DockStyle.Fill
            });
        }

        private void btnActions_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!User.UserInAction("Work Orders"))
                return;

            frmActionList frm = new frmActionList();
            frm.ShowDialog();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            bool updateNow = true;
            while (updateNow)
            {
                Thread.Sleep(1000);
                if (UpdateHelpers.InstallUpdateSyncWithInfo())
                {
                    this.Invoke(new Action(() =>
                    {
                        updateNow = false;
                        lblTime.Caption = @"OFMIS: Update available(the system is updating)";
                        UpdateHelpers.applicationDeployment.UpdateCompleted += (se, ev) =>
                        {
                            new frmUpdateNotification().ShowDialog(this);
                        };
                        UpdateHelpers.applicationDeployment.UpdateProgressChanged += (se, ev) =>
                        {
                            lblTime.Caption = $@"OFMIS: Update available(the system is updating) {ev.ProgressPercentage}%";
                        };
                        UpdateHelpers.applicationDeployment.UpdateAsync();


                    }));

                }
            }
        }
    }
}