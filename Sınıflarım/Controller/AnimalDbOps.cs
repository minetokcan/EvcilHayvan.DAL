using System;
using System.Linq;

namespace Sınıflarım.Controller
{
    public class AnimalDbOps
    {
        private static AnimalDbOps instance;
        public static AnimalDbOps GetInstance()
        {
            if (instance == null)
            {
                instance = new AnimalDbOps();
            }
            return instance;
        }
        public Animal AddNewAnimal(Animal _Animal)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    context.Animal.Add(_Animal);
                    var numberOfAdded = context.SaveChanges();

                    if (numberOfAdded > 0)
                    {
                        return _Animal;
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

        public Animal GetAnimalById(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var Animal = context.Animal.FirstOrDefault(a => a.Id == _id);
                    return Animal != null ? Animal : null;

                }
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public Animal UpdateAnimalInfo(Animal _Animal, int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var findedAnimal = context.Animal.FirstOrDefault(u => u.Id == _id);

                    findedAnimal.Name = _Animal.Name;
                    findedAnimal.Gender = _Animal.Gender;

                    var numberOfFinded = context.SaveChanges();

                    if (numberOfFinded > 0)
                    {
                        return _Animal;
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

        public bool DeleteAnimal(int _id)
        {
            try
            {
                using (var context = new EvcilHayvanEntities())
                {
                    var Animal = context.Animal.FirstOrDefault(a => a.Id == _id);
                    if (Animal != null)
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
