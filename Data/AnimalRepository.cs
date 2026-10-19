using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

namespace WildLifeRehabilitationCenter.Data
{
    public class AnimalRepository
    {
        private readonly string fileName = "Animals.txt";

        public void SaveAnimal(Animal animal)
        {
            try
            {
                string ageValue = animal.Age.HasValue
                    ? animal.Age.Value.ToString()
                    : "";

                string line = $"{animal.AnimalID}|{animal.Name}|{animal.Species}|{ageValue}|{animal.RecoveryScore}|{animal.Status}|{animal.HousingUnit}";

                using (StreamWriter writer = new StreamWriter(fileName, true))
                {
                    writer.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();

            if (!File.Exists(fileName))
            {
                return animals;
            }

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string? line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] fields = line.Split('|');

                        if (fields.Length != 7)
                        {
                            continue;
                        }

                        int? age = null;

                        if (fields[3] != "")
                        {
                            if (int.TryParse(fields[3], out int parsedAge))
                            {
                                age = parsedAge;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (!int.TryParse(fields[4], out int score))
                        {
                            continue;
                        }

                        Animal animal = new Animal(
                            fields[0],
                            fields[1],
                            fields[2],
                            age,
                            score,
                            fields[5],
                            fields[6]);

                        animals.Add(animal);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return animals;
        }

        public void SaveAllAnimals(List<Animal> animals)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, false))
                {
                    foreach (Animal animal in animals)
                    {
                        string ageValue = animal.Age.HasValue
                            ? animal.Age.Value.ToString()
                            : "";

                        string line = $"{animal.AnimalID}|{animal.Name}|{animal.Species}|{ageValue}|{animal.RecoveryScore}|{animal.Status}|{animal.HousingUnit}";

                        writer.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public DataTable LoadAnimals(List<Animal> animals)
        {
            DataTable table = new DataTable();

            table.Columns.Add("AnimalID");
            table.Columns.Add("Name");
            table.Columns.Add("Species");
            table.Columns.Add("Age");
            table.Columns.Add("RecoveryScore");
            table.Columns.Add("Status");
            table.Columns.Add("HousingUnit");

            foreach (Animal animal in animals)
            {
                table.Rows.Add(
                    animal.AnimalID,
                    animal.Name,
                    animal.Species,
                    animal.Age.HasValue ? animal.Age.Value.ToString() : "",
                    animal.RecoveryScore,
                    animal.Status,
                    animal.HousingUnit);
            }

            return table;
        }
    }
}
