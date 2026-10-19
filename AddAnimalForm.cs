using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WildLifeRehabilitationCenter.Business;
using WildLifeRehabilitationCenter.Data;

namespace WildLifeRehabilitationCenter
{
    public partial class AddAnimalForm : Form
    {
        private Animal _animalToEdit;
        private bool _isEditMode => _animalToEdit != null;

        private readonly AnimalRepository repository = new AnimalRepository();

        public AddAnimalForm()
        {
            InitializeComponent();
        }

        public AddAnimalForm(Animal animalToEdit)
        {
            InitializeComponent();
            _animalToEdit = animalToEdit;
            PopulateFormFields();
        }

        private void PopulateFormFields()
        {
            if (_isEditMode)
            {
                this.Text = "Edit Animal"; // Change window title
                btnAddAnimal.Text = "Update Animal"; // Change button text

                txtAnimalID.Text = _animalToEdit.AnimalID;
                txtAnimalID.Enabled = false;

                txtName.Text = _animalToEdit.Name;
                txtSpecies.Text = _animalToEdit.Species;
                cmbGender.Text = _animalToEdit.Gender;
                txtAge.Text = _animalToEdit.Age?.ToString() ?? "";
                txtRecoveryScore.Text = _animalToEdit.RecoveryScore.ToString();
            }
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
            else
            {
                AnimalService service = new AnimalService();
                lblStatus.Text = service.ClassifyAnimal(score);
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                // Update the existing animal
                UpdateAnimal();
            }
            else
            {
                // Add a new animal
                AddNewAnimal();
            }
        }

        private void UpdateAnimal()
        {
            // Update the properties of the existing object in memory
            _animalToEdit.Name = txtName.Text;
            _animalToEdit.Species = txtSpecies.Text;
            _animalToEdit.Gender = cmbGender.Text;
            _animalToEdit.Age = string.IsNullOrEmpty(txtAge.Text) ? (int?)null : int.Parse(txtAge.Text);
            _animalToEdit.SetRecoveryScore(int.Parse(txtRecoveryScore.Text));
            // Call your Update service
            AnimalService service = new AnimalService();
            service.UpdateAnimal(_animalToEdit);
            MessageBox.Show("Animal updated successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AddNewAnimal()
        {
            // Get the information entered by the user
            string animalID = txtAnimalID.Text.Trim().ToUpper();
            string name = txtName.Text.Trim();
            string species = txtSpecies.Text.Trim();
            string gender = cmbGender.Text;
            int age;
            int score;
            string HousingUnit = cmbHousingUnit.Text;

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


            if (_isEditMode)
            {
                btnAddAnimal.Text = "Update Animal"; // Change button text

                // Update the properties of the existing object in memory
                _animalToEdit.Name = txtName.Text;
                _animalToEdit.Species = txtSpecies.Text;
                _animalToEdit.Gender = cmbGender.Text;
                _animalToEdit.Age = string.IsNullOrEmpty(txtAge.Text) ? (int?)null : int.Parse(txtAge.Text);
                _animalToEdit.RecoveryScore = int.Parse(txtRecoveryScore.Text);
                _animalToEdit.HousingUnit = cmbHousingUnit.Text;

                // Call your Update service
                AnimalService service = new AnimalService();
                service.UpdateAnimal(_animalToEdit);
            }
            else
            {
                // Create the new animal
                Animal newAnimal = new Animal(
                    animalID,
                    name,
                    species,
                    age,
                    gender,
                    DateTime.Now,
                    score,
                    HousingUnit
                    );

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

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
