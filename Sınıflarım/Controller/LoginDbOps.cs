using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sınıflarım.Controller
{
    public class LoginDbOps
    {
        private static LoginDbOps instance;
        public static LoginDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new LoginDbOps();
            }
            return instance;
        }
        public UserRoleManagement LoginCheck(int _userId)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedUserRole = context.UserRoleManagement.FirstOrDefault(r => r.RoleId == _userId);

                    if (findedUserRole.RoleId == 1)
                    {
                        
                    }
                    else if(findedUserRole.RoleId == 2)
                    {
                        
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
