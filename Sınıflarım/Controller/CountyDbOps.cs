using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    public class CountyDbOps
    {
        private static CountyDbOps instance;
        public static CountyDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new CountyDbOps();
            }
            return instance;
        }
        public County AddNewCounty(County _County)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.County.Add(_County);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _County;
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

        public County GetCountyById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var County = context.County.FirstOrDefault(a => a.Id == _id);
                    return County != null ? County : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public County UpdateCountyInfo(County _County, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedCounty = context.County.FirstOrDefault(u => u.Id == _id);

                    findedCounty.Name = _County.Name;
                    findedCounty.CityId = _County.CityId;

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _County;
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

        public bool DeleteCounty(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var County = context.County.FirstOrDefault(a => a.Id == _id);
                    if (County != null)
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
