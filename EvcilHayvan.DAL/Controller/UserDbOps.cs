using EvcilHayvan.DAL.Entities;

namespace EvcilHayvan.DAL.Controller
{
    public class UserDbOps
    {
        public User AddNewUser(User _User)
        {
            using (var context = new EvcilHayvanContext())
            {
                context.Users.Add(_User);
                var numberOfAdded = context.SaveChanges();

                if (numberOfAdded > 0)
                {
                    return _User;
                }
                else
                {
                    return null;
                }
            }
        }

        public int GetUserById(int _id)
        {
            using (var context = new EvcilHayvanContext())
            {
                context.Users.Find(_id);
                var numberOfFinded = context.SaveChanges();

                if (numberOfFinded > 0)
                {
                    return _id;
                }
                else
                {
                    return 0;
                }
            }
        }

        public User UpdateUserInfo(User _User)
        {
            using (var context = new EvcilHayvanContext())
            {
                context.Users.Find(_User);
                var numberOfFinded = context.SaveChanges();

                if (numberOfFinded > 0)
                {
                    context.Users.Update(_User);
                    var numberOfUptaded = context.SaveChanges();

                    return _User;
                }
                else
                {
                    return null;
                }
            }
        }

        public User RemoveUser(User _User)
        {
            using (var context = new EvcilHayvanContext())
            {
                context.Users.Find(_User);
                var numberOfFinded = context.SaveChanges();

                if (numberOfFinded > 0)
                {
                    context.Users.Remove(_User);
                    var numberOfDeleted = context.SaveChanges();

                    return _User;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
