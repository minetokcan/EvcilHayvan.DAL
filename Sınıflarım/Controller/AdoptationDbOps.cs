using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    public class AdoptationDbOps
    {
        private static AdoptationDbOps instance;
        public static AdoptationDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new AdoptationDbOps();
            }
            return instance;
        }
        public Adoptation AddNewAdoptation(Adoptation _Adoptation)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.Adoptation.Add(_Adoptation);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _Adoptation;
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

        public Adoptation GetAdoptationById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var Adoptation = context.Adoptation.FirstOrDefault(a => a.Id == _id);
                    return Adoptation != null ? Adoptation : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Adoptation UpdateAdoptationInfo(Adoptation _Adoptation, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedAdoptation = context.Adoptation.FirstOrDefault(u => u.Id == _id);

                    findedAdoptation.UserId = _Adoptation.UserId;
                    findedAdoptation.AnimalId = _Adoptation.AnimalId;

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _Adoptation;
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

        public bool DeleteAdoptation(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var Adoptation = context.Adoptation.FirstOrDefault(a => a.Id == _id);
                    if (Adoptation != null)
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
