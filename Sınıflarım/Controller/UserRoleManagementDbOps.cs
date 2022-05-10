using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    public class UserRoleManagementDbOps
    {
        private static UserRoleManagementDbOps instance;
        public static UserRoleManagementDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new UserRoleManagementDbOps();
            }
            return instance;
        }
        public UserRoleManagement AddNewUserRoleManagement(UserRoleManagement _UserRoleManagement)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.UserRoleManagement.Add(_UserRoleManagement);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _UserRoleManagement;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public UserRoleManagement GetUserRoleManagementById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var UserRoleManagement = context.UserRoleManagement.FirstOrDefault(a => a.Id == _id);
                    return UserRoleManagement != null ? UserRoleManagement : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public UserRoleManagement UpdateUserRoleManagementInfo(UserRoleManagement _UserRoleManagement, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedUserRoleManagement = context.UserRoleManagement.FirstOrDefault(u => u.Id == _id);

                    findedUserRoleManagement.UserId = _UserRoleManagement.UserId;
                    findedUserRoleManagement.RoleId = _UserRoleManagement.RoleId;

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _UserRoleManagement;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public bool DeleteUserRoleManagement(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var UserRoleManagement = context.UserRoleManagement.FirstOrDefault(a => a.Id == _id);
                    if (UserRoleManagement != null)
                    {

                        int numOfDeleted = context.SaveChanges();
                        if (numOfDeleted > 0)
                        {
                            return true;
                        }
                    }
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
