using System;

namespace WildLifeRehabilitationCenter.Data
{
    public class Animal
    {
        public string AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int? Age { get; set; }
        public int RecoveryScore { get; set; }
        public string Status { get; set; }
        public string HousingUnit { get; set; }

        // Temporary compatibility with the existing Main Form.
        public string Gender { get; set; }
        public DateTime DateAdmitted { get; set; }

        public Animal(string animalID, string name, string species,
            int? age, int recoveryScore, string status, string housingUnit)
        {
            AnimalID = animalID;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryScore;
            Status = status;
            HousingUnit = housingUnit;
            Gender = "";
            DateAdmitted = DateTime.Now;
        }

        public Animal(string animalID, string name, string species,
            int? age, string gender, DateTime dateAdmitted)
        {
            AnimalID = animalID;
            Name = name;
            Species = species;
            Age = age;
            Gender = gender;
            DateAdmitted = dateAdmitted;
            RecoveryScore = 0;
            Status = "Critical";
            HousingUnit = "Intensive Care Unit";
        }

        public void SetRecoveryScore(int value)
        {
            if (value < 0 || value > 100)
            {
                return;
            }

            RecoveryScore = value;

            if (value <= 19)
            {
                Status = "Critical";
                HousingUnit = "Intensive Care Unit";
            }
            else if (value <= 39)
            {
                Status = "Serious";
                HousingUnit = "High-Dependency Ward";
            }
            else if (value <= 59)
            {
                Status = "Stable";
                HousingUnit = "Recovery Ward";
            }
            else if (value <= 79)
            {
                Status = "Recovering";
                HousingUnit = "Outdoor Enclosure";
            }
            else
            {
                Status = "Release-Ready";
                HousingUnit = "Pre-Release Camp";
            }
        }
    }
}
