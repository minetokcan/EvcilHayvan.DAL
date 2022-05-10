using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    public class AddressDbOps
    {
        private static AddressDbOps instance;
        public static AddressDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new AddressDbOps();
            }
            return instance;
        }
        public Address AddNewAddress(Address _Address)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.Address.Add(_Address);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _Address;
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

        public Address GetAddressById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var Address = context.Address.FirstOrDefault(a => a.Id == _id);
                    return Address != null ? Address : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Address UpdateAddressInfo(Address _Address, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedAddress = context.Address.FirstOrDefault(u => u.Id == _id);

                    findedAddress.CountyId = _Address.CountyId;
                    findedAddress.Title = _Address.Title;

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _Address;
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

        public bool DeleteAddress(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var address = context.Address.FirstOrDefault(a => a.Id == _id);
                    if (address != null)
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
