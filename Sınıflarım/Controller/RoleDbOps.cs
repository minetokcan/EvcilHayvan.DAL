using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    public class RoleDbOps
    {
        private static RoleDbOps instance;
        public static RoleDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new RoleDbOps();
            }
            return instance;
        }
        public Role AddNewRole(Role _Role)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.Role.Add(_Role);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _Role;
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

        public Role GetRoleById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var Role = context.Role.FirstOrDefault(a => a.Id == _id);
                    return Role != null ? Role : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Role UpdateRoleInfo(Role _Role, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedRole = context.Role.FirstOrDefault(u => u.Id == _id);

                    findedRole.Name = _Role.Name;
                    findedRole.Status = _Role.Status;

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _Role;
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

        public bool DeleteRole(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var Role = context.Role.FirstOrDefault(a => a.Id == _id);
                    if (Role != null)
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
