using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models.Repository;

namespace Win
{
    public static class User
    {
        public static string UserId { get; set; }

        public static string GetFullName() => new UnitOfWork().UsersRepo.Fetch(m => m.Id == UserId)
            .Select(x => new { FullName = x.FirstName + " " + x.LastName })?.FirstOrDefault()?.FullName;
        public static string GetUserName() => new UnitOfWork().UsersRepo.Fetch(m => m.Id == UserId)
            .Select(x => new { x.UserName })?.FirstOrDefault()?.UserName;


        public static bool IsInRoles(params string[] roles)
        {
            Models.Repository.UnitOfWork unitOfWork = new Models.Repository.UnitOfWork();
            var user = unitOfWork.UsersRepo.Find(m => m.Id == UserId);

            if (user == null)
                return false;
            if (string.IsNullOrEmpty(UserId))
                return false;
            return user.UserRoles.Any(m => roles.Contains(m.Name));
        }
        public static bool UserInAction(string action)
        {
            using (var unitOfWork = new UnitOfWork())
            {
                var user = unitOfWork.UsersRepo.Fetch(m => m.Id == UserId).Select(x => new { x.UserRoles }).FirstOrDefault();
                if (!unitOfWork.ActionsRepo.Fetch(m => m.Action == action).Any())
                {
                    unitOfWork.ActionsRepo.Insert(new Models.Actions() { Action = action });
                    unitOfWork.Save();
                }
                var role = unitOfWork.UserRolesRepo.Find(m => m.Name == "Administrator");
                if (role != null)
                    if (role.UserRolesInActions.All(m => m.Action != action))
                    {
                        role.UserRolesInActions.Add(new Models.UserRolesInActions() { Action = action });
                        unitOfWork.Save();
                    }

                if (user.UserRoles.Any(c => c.UserRolesInActions.Any(n => n.Action == action)))
                    return true;

                MessageBox.Show(@"Access Denied
Contact System Administrator", action, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return false;
        }
    }



}
