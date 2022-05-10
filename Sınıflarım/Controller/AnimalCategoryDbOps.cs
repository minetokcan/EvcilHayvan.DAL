using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    public class AnimalCategoryDbOps
    {
        private static AnimalCategoryDbOps instance;
        public static AnimalCategoryDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new AnimalCategoryDbOps();
            }
            return instance;
        }
        public AnimalCategory AddNewAnimalCategory(AnimalCategory _AnimalCategory)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.AnimalCategory.Add(_AnimalCategory);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _AnimalCategory;
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

        public AnimalCategory GetAnimalCategoryById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var AnimalCategory = context.AnimalCategory.FirstOrDefault(a => a.Id == _id);
                    return AnimalCategory != null ? AnimalCategory : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public AnimalCategory UpdateAnimalCategoryInfo(AnimalCategory _AnimalCategory, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedAnimalCategory = context.AnimalCategory.FirstOrDefault(u => u.Id == _id);

                    findedAnimalCategory.CategotyName = _AnimalCategory.CategotyName;
                    findedAnimalCategory.Status = _AnimalCategory.Status;

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _AnimalCategory;
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

        public bool DeleteAnimalCategory(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var AnimalCategory = context.AnimalCategory.FirstOrDefault(a => a.Id == _id);
                    if (AnimalCategory != null)
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
