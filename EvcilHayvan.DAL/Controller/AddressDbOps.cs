using EvcilHayvan.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvcilHayvan.DAL.Controller
{
    public class AddressDbOps
    {
        public Address AddNewAddress(Address _address)
        {
            using (var context = new EvcilHayvanContext())
            {
                context.Addresses.Add(_address);
                var numberOfAdded = context.SaveChanges();

                if (numberOfAdded > 0)
                {
                    return _address;
                }
                else
                {
                    return null;
                }
            }
        }

        public int GetAddressById(int _id)
        {
            using (var context = new EvcilHayvanContext())
            {
                context.Addresses.Find(_id);
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

        public Address UpdateAddressInfo(Address _address)
        {
            using (var context = new EvcilHayvanContext())
            {
                context.Addresses.Find(_address);
                var numberOfFinded = context.SaveChanges();

                if (numberOfFinded > 0)
                {
                    context.Addresses.Update(_address);
                    var numberOfUptaded = context.SaveChanges();

                    return _address;
                }
                else
                {
                    return null;
                }
            }
        }

        public Address RemoveAddress(Address _address)
        {
            using (var context = new EvcilHayvanContext())
            {
                context.Addresses.Find(_address);
                var numberOfFinded = context.SaveChanges();

                if (numberOfFinded > 0)
                {
                    context.Addresses.Remove(_address);
                    var numberOfDeleted = context.SaveChanges();

                    return _address;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
