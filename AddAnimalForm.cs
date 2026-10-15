using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WildLifeRehabilitationCenter.Data;

namespace WildLifeRehabilitationCenter
{
    public partial class AddAnimalForm : Form
    {
        private readonly AnimalRepository repository = new AnimalRepository();
        public AddAnimalForm()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddAnimalForm_Load(object sender, EventArgs e)
        {

        }

        private void txtRecoveryScore_TextChanged(object sender, EventArgs e)
        {
            int score;

            // Check if the score is a valid number
            if (!int.TryParse(txtRecoveryScore.Text, out score))
            {
                lblStatus.Text = "Status: Not calculated";
                lblHousingUnit.Text = "Housing Unit: Not calculated";
                return;
            }

            // Check if the score is between 0 and 100
            if (score < 0 || score > 100)
            {
                lblStatus.Text = "Status: Invalid score";
                lblHousingUnit.Text = "Housing Unit: Invalid score";
            }
            else if (score <= 19)
            {
                lblStatus.Text = "Status: Critical";
                lblHousingUnit.Text = "Housing Unit: Intensive Care Unit";
            }
            else if (score <= 39)
            {
                lblStatus.Text = "Status: Serious";
                lblHousingUnit.Text = "Housing Unit: High-Dependency Ward";
            }
            else if (score <= 59)
            {
                lblStatus.Text = "Status: Stable";
                lblHousingUnit.Text = "Housing Unit: Recovery Ward";
            }
            else if (score <= 79)
            {
                lblStatus.Text = "Status: Recovering";
                lblHousingUnit.Text = "Housing Unit: Outdoor Enclosure";
            }
            else
            {
                lblStatus.Text = "Status: Release-Ready";
                lblHousingUnit.Text = "Housing Unit: Pre-Release Camp";
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {



            // Get the information entered by the user
            string animalID = txtAnimalID.Text.Trim().ToUpper();
            string name = txtName.Text.Trim();
            string species = txtSpecies.Text.Trim();
            string gender = cmbGender.Text;
            int age;
            int score;

            // Check the Animal ID
            if (!animalID.StartsWith("WR-") || animalID.Length != 7)
            {
                MessageBox.Show("Enter an Animal ID like WR-1234.");
                txtAnimalID.Focus();
                return;
            }


            // Check that all four characters after WR- are digits
            bool validDigits = true;

            for (int i = 3; i < 7; i++)
            {
                if (animalID[i] < '0' || animalID[i] > '9')
                {
                    validDigits = false;
                    break;
                }
            }

            if (!validDigits)
            {
                MessageBox.Show("The Animal ID must contain four numbers after WR-.");
                txtAnimalID.Focus();
                return;
            }

            // Check that the name was entered
            if (name == "" || name.Length > 30 || name.Contains("|"))
            {
                MessageBox.Show("Enter a name of 1 to 30 characters.");
                txtName.Focus();
                return;
            }

            // Check that the species was entered
            if (species == "" || species.Length > 30 || species.Contains("|"))
            {
                MessageBox.Show("Enter a species of 1 to 30 characters.");
                txtSpecies.Focus();
                return;
            }

            // Check the age
            if (!int.TryParse(txtAge.Text, out age) || age < 0 || age > 100)
            {
                MessageBox.Show("Age must be a whole number between 0 and 100.");
                txtAge.Focus();
                return;
            }

            // Check that a gender was selected
            if (gender == "")
            {
                MessageBox.Show("Please select a gender.");
                cmbGender.Focus();
                return;
            }

            // Check the recovery score
            if (!int.TryParse(txtRecoveryScore.Text, out score)
                || score < 0 || score > 100)
            {
                MessageBox.Show("Recovery score must be between 0 and 100.");
                txtRecoveryScore.Focus();
                return;
            }

            // Check whether the Animal ID already exists
            List<Animal> animals = repository.GetAllAnimals();

            foreach (Animal animal in animals)
            {
                if (animal.AnimalID.ToUpper() == animalID)
                {
                    MessageBox.Show("This Animal ID already exists.");
                    txtAnimalID.Focus();
                    return;
                }
            }

            // Create the new animal
            Animal newAnimal = new Animal(
                animalID,
                name,
                species,
                age,
                gender,
                DateTime.Now)
            {
                RecoveryScore = score
            };

            // Save the animal
            repository.SaveAnimal(newAnimal);

            MessageBox.Show("Animal added successfully!");

            // Clear the form
            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            txtRecoveryScore.Clear();

            lblStatus.Text = "Status: Not calculated";
            lblHousingUnit.Text = "Housing Unit: Not calculated";

            txtAnimalID.Focus();
        }
        
    
    }
}
