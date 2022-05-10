using System.Linq;

namespace Sınıflarım.Controller
{
    public class UserDbOps
    {
        private static UserDbOps instance;
        public static UserDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new UserDbOps();
            }
            return instance;
        }
        public User AddNewUser(User _user)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.User.Add(_user);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _user;
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

        public User GetUserById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var User = context.User.FirstOrDefault(a => a.Id == _id);
                    return User != null ? User : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public User UpdateUserInfo(User _user , int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedUser = context.User.FirstOrDefault(u => u.Id == _id);

                    findedUser.Name = _user.Name;
                    findedUser.Surname = _user.Surname;
                    findedUser.Email = _user.Email;
                    findedUser.Password = _user.Password;

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _user;
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

        public User DeleteUser(User _user , int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedUser = context.User.FirstOrDefault(u => u.Id == _id);

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _user;
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
    }
}
