using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    public class AnimalDetailsDbOps
    {
        private static AnimalDetailsDbOps instance;
        public static AnimalDetailsDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new AnimalDetailsDbOps();
            }
            return instance;
        }
        public AnimalDetails AddNewAnimalDetails(AnimalDetails _AnimalDetails)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.AnimalDetails.Add(_AnimalDetails);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _AnimalDetails;
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

        public AnimalDetails GetAnimalDetailsById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var AnimalDetails = context.AnimalDetails.FirstOrDefault(a => a.Id == _id);
                    return AnimalDetails != null ? AnimalDetails : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public AnimalDetails UpdateAnimalDetailsInfo(AnimalDetails _AnimalDetails, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedAnimalDetails = context.AnimalDetails.FirstOrDefault(u => u.Id == _id);

                    findedAnimalDetails.AnimalId = _AnimalDetails.AnimalId;
                    findedAnimalDetails.Breed = _AnimalDetails.Breed;
                    findedAnimalDetails.Details = _AnimalDetails.Details;
                    findedAnimalDetails.IsAnimalHomeless = _AnimalDetails.IsAnimalHomeless;
                    findedAnimalDetails.IsVaccinated = _AnimalDetails.IsVaccinated;


                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _AnimalDetails;
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

        public bool DeleteAnimalDetails(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var AnimalDetails = context.AnimalDetails.FirstOrDefault(a => a.Id == _id);
                    if (AnimalDetails != null)
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
