using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WildLifeRehabilitationCenter.Data
{
    public class AnimalRepository
    {
        private readonly string fileName = "Animals.txt";

        public void SaveAnimal(Animal animal)
        {
            string line;
            try
            {
                var Age = animal.Age;
                if (Age == null)
                {
                    string AgeValue = "";
                    line = $"{animal.AnimalID}|{animal.Name}|{animal.Species}|{AgeValue}|{animal.Gender}|{animal.DateAdmitted}|{animal.RecoveryScore}";
                    using (StreamWriter writer = new StreamWriter(fileName,append:true))
                    {
                        writer.WriteLine(line);
                    }
                }
                else
                {
                    line = $"{animal.AnimalID}|{animal.Name}|{animal.Species}|{animal.Age}|{animal.Gender}|{animal.DateAdmitted}|{animal.RecoveryScore}";
                    using (StreamWriter writer = new StreamWriter(fileName,append:true))
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();
            try
            {
                if (!File.Exists(fileName))
                {
                    //Error handling
                    return animals;
                }

                using (StreamReader reader = new StreamReader(fileName))
                {
                    string? line;
                    while((line = reader.ReadLine()) != null)
                    {
                        string[] properties = line.Split("|");

                        if(properties.Length != 7)
                        {
                            continue;
                            //skipping bad line, all lines should have 7 properties
                        }
                        string AnimalID = properties[0];
                        string Name = properties[1];
                        string Species = properties[2];
                        int Age;
                        int? AgeValue;
                        if (int.TryParse(properties[3], out Age))
                        {
                            AgeValue = Age;
                        }
                        else
                        {
                            AgeValue = null;
                        }

                        string Gender = properties[4];
                        DateTime DateAdmitted;
                        if (DateTime.TryParse(properties[5], out DateAdmitted))
                        {
                            //date parsed successfully
                        }
                        else{
                            continue;
                            //skipping bad line
                        }
                        int recoveryScore;
                        if (int.TryParse(properties[6], out recoveryScore))
                        {
                            //score parsed successfully
                        }
                        else
                        {
                            continue;
                            //skip bad line
                        }

                        Animal animal = new Animal(AnimalID, Name, Species, AgeValue, Gender, DateAdmitted)
                        {
                            RecoveryScore = recoveryScore
                        };
                        animals.Add(animal);

                       
                    }
                }
                
            }
            catch
            {

            }
            return animals;

        }
        
    }
}
