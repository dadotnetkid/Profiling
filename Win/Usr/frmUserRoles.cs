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

namespace Win.Usr
{
    public partial class frmUserRoles : DevExpress.XtraEditors.XtraForm
    {
        public frmUserRoles()
        {
            InitializeComponent();
        }

        private void frmUserRoles_Load(object sender, EventArgs e)
        {
            this.UserRoleBindingSource.DataSource = new UnitOfWork().UserRolesRepo.Get();
            this.ActionsBindingSource.DataSource = new UnitOfWork().ActionsRepo.Get();
        }

        private void UserRoleGrid_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            if (e.Row is UserRoles item)
            {
                using (UnitOfWork unitOfWork = new UnitOfWork())
                {
                    var list = new List<UserRolesInActions>();

                    if (item.Id == null)
                    {
                        item.Id = Guid.NewGuid().ToString();
                        list.AddRange(item.Actions.Split(',').Select(x => new UserRolesInActions() { Action = x.Trim(), RoleId = item.Id }));
                        item.UserRolesInActions = list;
                        unitOfWork.UserRolesRepo.Insert(item);
                        unitOfWork.Save();
                    }
                    else
                    {

                        var userRole = unitOfWork.UserRolesRepo.Find(m => m.Id == item.Id, includeProperties: "UserRolesInActions");

                        userRole.UserRolesInActions.Clear();
                        list.AddRange(item.Actions.Split(',').Select(x => new UserRolesInActions() { Action = x.Trim(), RoleId = item.Id }));
                        userRole.UserRolesInActions = list;
                        userRole.Name = item.Name;
                        unitOfWork.Save();
                        unitOfWork.UserRolesInActionsRepo.DeleteRange(m => m.RoleId == null);
                        unitOfWork.Save();
                    }
                }
                this.UserRoleBindingSource.DataSource = new UnitOfWork().UserRolesRepo.Get();
                this.ActionsBindingSource.DataSource = new UnitOfWork().ActionsRepo.Get();
                UserRoleGrid.RefreshData();
            }
        }
    }
}