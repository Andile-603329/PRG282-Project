using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLifeRehabilitationCenter.Data
{
    public class Animal
    {
        public string AnimalID { get; init; }

        public string Name { get; set; }
        public string Species { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public DateTime DateAdmitted { get; init; }
        public int RecoveryScore { get; set; }

        public string HousingUnit { get; set;}

        
           
 

        

        public Animal(string animalID,string name,string species, int? age, string gender,DateTime dateAdmitted,int recoveryScore,string housingUnit)
        {
            AnimalID = animalID;
            Name = name;
            Age = age;
            Gender = gender;
            DateAdmitted = dateAdmitted;
            Species = species;
            HousingUnit = housingUnit;
            RecoveryScore = recoveryScore;
        }

        



    }
}
