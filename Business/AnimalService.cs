using System;
using System.Collections.Generic;
using System.Linq;
using WildLifeRehabilitationCenter.Data;

namespace WildLifeRehabilitationCenter.Business
{
	public class AnimalService
	{
		private readonly AnimalRepository _repository = new AnimalRepository();

		public void UpdateAnimal(Animal updatedAnimal)
		{
			var animals = _repository.GetAllAnimals();
			var existingAnimal = animals.FirstOrDefault(a => a.AnimalID == updatedAnimal.AnimalID);

			if (existingAnimal != null)
			{
                //Update editable properties.
				existingAnimal.Name = updatedAnimal.Name;
				existingAnimal.Species = updatedAnimal.Species;
				existingAnimal.Age = updatedAnimal.Age;
				existingAnimal.Gender = updatedAnimal.Gender;
				existingAnimal.SetRecoveryScore(updatedAnimal.RecoveryScore);

				//Rewrite file.
				_repository.SaveAllAnimals(animals);
            }
        }

		public void DeleteAnimal(string animalId)
        {
            var animals = _repository.GetAllAnimals();
            var animalToDelete = animals.FirstOrDefault(a => a.AnimalID == animalId);

            if (animalToDelete != null)
            {
                animals.Remove(animalToDelete);
                _repository.SaveAllAnimals(animals);
            }
        }
    }
}
