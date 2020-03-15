using Microsoft.AspNet.Identity;
using Models;
using Models.Startups;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Models.Repository;
using Microsoft.Data.ConnectionUI;
using Win.Properties;
using DataSource = Microsoft.Data.ConnectionUI.DataSource;

namespace Win
{
    public partial class frmLogin : XtraForm
    {
        private FrmMain frmMain;
        private bool isLogged;
        private UnitOfWork unitOfWork;
        private ApplicationUserManager userManager;
        public frmLogin(FrmMain frmMain)
        {
            InitializeComponent();
            UserStores userStores = new UserStores(new ModelDb());
            userManager = new ApplicationUserManager(userStores);
            unitOfWork = new UnitOfWork();
            this.frmMain = frmMain;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtToday.Text = DateTime.Now.ToShortDateString();
            txtPassword.Text = Properties.Settings.Default.Password;
            txtUserName.Text = Properties.Settings.Default.UserName;
            chkRemember.Checked = Properties.Settings.Default.RemembeMe;
        }

        private async void BtnLogin_Click(object sender, EventArgs e)
        {
            //ApplicationSignInManager signInManager=new ApplicationSignInManager(,)

            var user = unitOfWork.UsersRepo.Fetch(m => m.UserName == txtUserName.Text)
                .Select(x => new { UserId = x.Id, PasswordHash = x.PasswordHash, FullName = x.FirstName + " - " + x.LastName, UserRoles = x.UserRoles }).FirstOrDefault();
            if (user == null)
            {
                // lblStatus.Text = "Username is invalid";
                txtPassword.Text = "";
                txtUserName.Text = "";
                return;
            }


            PasswordVerificationResult ret =
                userManager.PasswordHasher.VerifyHashedPassword(user.PasswordHash, txtPassword.Text);
            if (ret != PasswordVerificationResult.Success)
            {
                //   lblStatus.Text = "Password is invalid";
                txtPassword.Text = "";
                txtUserName.Text = "";
                return;
            }

            if (chkRemember.Checked)
            {
                Properties.Settings.Default.UserName = txtUserName.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.RemembeMe = chkRemember.Checked;
                Properties.Settings.Default.Save();
            }

            User.UserId = user.UserId;
            //frmMain.lblUser.Text = user.FullName;
            //frmMain.lblUserLevel.Text = string.Join(",", user.UserRoles.Select(x => x.Name));
            this.isLogged = true;
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isLogged != true)
                Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnServerSetup_Click(object sender, EventArgs e)
        {
            DataConnectionDialog dataConnectionDialog = new DataConnectionDialog();
            dataConnectionDialog.ShowDialog();
        }

        private void btnServerSetup_Click_1(object sender, EventArgs e)
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
    }
}
