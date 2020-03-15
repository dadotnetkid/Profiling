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
using Models.Startups;

namespace Win.Usr
{
    public partial class frmUsers : DevExpress.XtraEditors.XtraForm
    {
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                if (_userManager == null)
                    _userManager = new ApplicationUserManager(new UserStores(ModelDb.Create(DataSource.ConnectionString)));
                return _userManager;
            }
            set => _userManager = value;
        }

        public frmUsers()
        {
            InitializeComponent();

        }



        private async void UserGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is Users item)
            {
                if (item.Id == null)
                {
                    item.Email = item.UserName + "@nuevavizcaya.gov.ph";

                    var res = await UserManager.CreateAsync(item, item.Password);
                    if (res.Succeeded)
                    {

                    }
                }
                else
                {

                }

                await UserManager.RemoveFromRolesAsync(item.Id, (await UserManager.GetRolesAsync(item.Id)).ToArray());
                await UserManager.AddToRolesAsync(item.Id, item.UserRole.Split(','));

            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();

        }

        void LoadUsers()
        {
            this.UserBindingControl.DataSource = new UnitOfWork().UsersRepo.Get();
            this.UserRoleBindingSource.DataSource = new UnitOfWork().UserRolesRepo.Get();
            UserGrid.RefreshData();
        }

        private void repositoryItemButtonEdit1_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (UserGrid.GetFocusedRow() is Users user)
            {
                if (MessageBox.Show("Do you want to delete this user", "User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    unitOfWork.UsersRepo.Delete(user);
                    unitOfWork.Save();
                    this.UserBindingControl.DataSource = unitOfWork.UsersRepo.Get();
                    this.UserRoleBindingSource.DataSource = unitOfWork.UserRolesRepo.Get();
                }

                LoadUsers();
            }
        }

        private void btnNewPO_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
        }

        private void btnEditPo_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser()
            {
                MethodType = MethodType.Edit,
                Users = UserGrid.GetFocusedRow() as Users
            };
            frm.ShowDialogResult();
            this.LoadUsers();
        }
    }
}