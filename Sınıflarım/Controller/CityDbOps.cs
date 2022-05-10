using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    public class CityDbOps
    {
        private static CityDbOps instance;
        public static CityDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new CityDbOps();
            }
            return instance;
        }
        public City AddNewCity(City _City)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.City.Add(_City);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _City;
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

        public City GetCityById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var City = context.City.FirstOrDefault(a => a.Id == _id);
                    return City != null ? City : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public City UpdateCityInfo(City _City, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedCity = context.City.FirstOrDefault(u => u.Id == _id);

                    findedCity.Name = _City.Name;
                    

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _City;
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

        public bool DeleteCity(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var City = context.City.FirstOrDefault(a => a.Id == _id);
                    if (City != null)
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
