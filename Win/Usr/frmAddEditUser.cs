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
using Models;
using Models.Repository;
using Models.Startups;

namespace Win.Usr
{
    public partial class frmAddEditUser : DevExpress.XtraEditors.XtraForm
    {
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager;
            }
            set => _userManager = value;
        }
        public frmAddEditUser()
        {
            UserManager = new ApplicationUserManager(new UserStores(ModelDb.Create(DataSource.ConnectionString)));
            InitializeComponent();
        }

        public MethodType MethodType { get; set; }
        public Users Users { get; set; }

        private void checkedComboBoxEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private async void btnNewPO_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to submit this user", "Saving", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            if (MethodType == MethodType.Add)
                New();
            else
                Update();
            this.Close();
        }

        async void AddToRoles(string userId)
        {
            if (cboUserLevel.EditValue is string item)
            {
                await UserManager.RemoveFromRolesAsync(userId, (await UserManager.GetRolesAsync(userId)).ToArray());
                var res = await UserManager.AddToRolesAsync(userId, item.Split(',').ToArray());

            }
        }


        async void ResetPassword()
        {
            //var token = await UserManager.GeneratePasswordResetTokenAsync(userId: Users.Id);
            //await UserManager.ResetPasswordAsync(Users.Id, token, txtPassword.Text);
            var password = UserManager.PasswordHasher.HashPassword(txtPassword.Text);
        }

        async void New()
        {
            Users = new Users()
            {
                FirstName = txtFirstName.Text,
                MiddleName = txtMI.Text,
                LastName = txtLastName.Text,
                Position = txtPosition.Text,
                UserName = txtUsername.Text,
                Email = $"{txtUsername.Text}@nuevavizcaya.gov.ph"
            };
            var res = await UserManager.CreateAsync(Users, txtPassword.Text);
            if (res.Succeeded)
                AddToRoles(Users.Id);
        }
        async void Update()
        {
            var unitOfWork = new UnitOfWork();
            // Users = unitOfWork.UsersRepo.Find(m => m.Id == Users.Id);
            Users.FirstName = txtFirstName.Text;
            Users.MiddleName = txtMI.Text;
            Users.LastName = txtLastName.Text;
            Users.Position = txtPosition.Text;
            Users.UserName = txtUsername.Text;
            Users.Email = Users.UserName + "@nuevavizcaya.gov.ph";
            if (!string.IsNullOrEmpty(txtPassword.Text))
                Users.PasswordHash = UserManager.PasswordHasher.HashPassword(txtPassword.Text);
            unitOfWork.UsersRepo.Update(Users);
            unitOfWork.Save();

            AddToRoles(Users.Id);
        }

        void LoadUserDetails()
        {
            cboUserLevel.EditValue = Users?.UserRole;
            txtUsername.Text = Users?.UserName;
            txtFirstName.Text = Users?.FirstName;
            txtMI.Text = Users?.MiddleName;
            txtLastName.Text = Users?.LastName;
            txtPosition.Text = Users?.Position;
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            UserRoleBindingSource.DataSource = new UnitOfWork().UserRolesRepo.Get();
            LoadUserDetails();

        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}