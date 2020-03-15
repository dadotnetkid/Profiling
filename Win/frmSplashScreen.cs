using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Microsoft.Data.ConnectionUI;
using Models.Repository;
using Win.Properties;

namespace Win
{
    public partial class frmSplashScreen : SplashScreen
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            this.labelControl1.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
            BackgroundWorker bg = new BackgroundWorker();
            bg.DoWork += Bg_DoWork;
            bg.RunWorkerCompleted += Bg_RunWorkerCompleted;
            bg.RunWorkerAsync();
        }

        private void Bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!IsConnected)
            {
                DataConnectionDialog dcd = new DataConnectionDialog();

                DataSource.AddStandardDataSources(dcd);
                dcd.SelectedDataSource = DataSource.SqlDataSource;
                dcd.ConnectionString = Settings.Default.ConnectionString;
                dcd.SelectedDataProvider = DataProvider.SqlDataProvider;
                var res = DataConnectionDialog.Show(dcd);
                Settings.Default.ConnectionString = dcd.ConnectionString;
                Settings.Default.Save();
                Models.DataSource.ConnectionString = Settings.Default.ConnectionString;
            }

            this.Close();
            var th = new Thread(() =>
              {
                  Application.Run(new FrmMain());

              });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();



        }

        private void Bg_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Models.DataSource.ConnectionString = Settings.Default.ConnectionString;
                this.IsConnected = new UnitOfWork().StartConnection();

            }
            catch (Exception exception)
            {

            }

        }

        public bool IsConnected { get; set; }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}