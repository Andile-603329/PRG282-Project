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
				existingAnimal.RecoveryScore = updatedAnimal.RecoveryScore;
				existingAnimal.HousingUnit = updatedAnimal.HousingUnit;

				//Rewrite file.
				_repository.SaveAllAnimals(animals);
            }
        }

		public string ClassifyAnimal(int score)
		{
			
			if(score < 0 || score > 100)
			{
				return "Invalid Data, could not classify recovery status";

			}
			else
			{
                if (score <= 19)
                {
                    return  "Status: Critical";
               
                }
                else if (score <= 39)
                {
                    return "Status: Serious";
                    
                }
                else if (score <= 59)
                {
                    return "Status: Stable";
                  
                }
                else if (score <= 79)
                {
                    return "Status: Recovering";
                    
                }
                else
                {
                    return "Status: Release-Ready";
                    
                }
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
