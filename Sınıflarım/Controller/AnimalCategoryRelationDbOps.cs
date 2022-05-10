using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    class AnimalCategoryRelationDbOps
    {
        private static AnimalCategoryRelationDbOps instance;
        public static AnimalCategoryRelationDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new AnimalCategoryRelationDbOps();
            }
            return instance;
        }
        public AnimalCategoryRelation AddNewAnimalCategoryRelation(AnimalCategoryRelation _AnimalCategoryRelation)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.AnimalCategoryRelation.Add(_AnimalCategoryRelation);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _AnimalCategoryRelation;
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

        public AnimalCategoryRelation GetAnimalCategoryRelationById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var AnimalCategoryRelation = context.AnimalCategoryRelation.FirstOrDefault(a => a.Id == _id);
                    return AnimalCategoryRelation != null ? AnimalCategoryRelation : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public AnimalCategoryRelation UpdateAnimalCategoryRelationInfo(AnimalCategoryRelation _AnimalCategoryRelation, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedAnimalCategoryRelation = context.AnimalCategoryRelation.FirstOrDefault(u => u.Id == _id);

                    findedAnimalCategoryRelation.AnimalCategoryId = _AnimalCategoryRelation.AnimalCategoryId;
                    findedAnimalCategoryRelation.AnimalId = _AnimalCategoryRelation.AnimalId;

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _AnimalCategoryRelation;
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

        public bool DeleteAnimalCategoryRelation(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var AnimalCategoryRelation = context.AnimalCategoryRelation.FirstOrDefault(a => a.Id == _id);
                    if (AnimalCategoryRelation != null)
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
