using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    public class UserAddressDbOps
    {
        private static UserAddressDbOps instance;
        public static UserAddressDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new UserAddressDbOps();
            }
            return instance;
        }
        public UserAddress AddNewUserAddress(UserAddress _UserAddress)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.UserAddress.Add(_UserAddress);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _UserAddress;
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

        public UserAddress GetUserAddressById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var UserAddress = context.UserAddress.FirstOrDefault(a => a.Id == _id);
                    return UserAddress != null ? UserAddress : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public UserAddress UpdateUserAddressInfo(UserAddress _UserAddress, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedUserAddress = context.UserAddress.FirstOrDefault(u => u.Id == _id);

                    findedUserAddress.UserId = _UserAddress.UserId;
                    findedUserAddress.AddressId = _UserAddress.AddressId;

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _UserAddress;
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

        public bool DeleteUserAddress(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var UserAddress = context.UserAddress.FirstOrDefault(a => a.Id == _id);
                    if (UserAddress != null)
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
