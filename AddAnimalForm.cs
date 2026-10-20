using System;
using System.Windows.Forms;
using WildLifeRehabilitationCenter.Business;
using WildLifeRehabilitationCenter.Data;

namespace WildLifeRehabilitationCenter
{
    public partial class AddAnimalForm : Form
    {
        private Animal? _animalToEdit;
        private readonly AnimalRepository repository = new AnimalRepository();

        private bool _isEditMode
        {
            get { return _animalToEdit != null; }
        }

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
            if (_animalToEdit != null)
            {
                this.Text = "Edit Animal";
                btnAddAnimal.Text = "Update Animal";

                txtAnimalID.Text = _animalToEdit.AnimalID;
                txtAnimalID.Enabled = false;
                txtName.Text = _animalToEdit.Name;
                txtSpecies.Text = _animalToEdit.Species;
                txtAge.Text = _animalToEdit.Age?.ToString() ?? "";
                txtRecoveryScore.Text =
                    _animalToEdit.RecoveryScore.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void AddAnimalForm_Load(object sender, EventArgs e)
        {
        }

        private void txtRecoveryScore_TextChanged(
            object sender, EventArgs e)
        {
            if (!int.TryParse(txtRecoveryScore.Text, out int score)
                || score < 0 || score > 100)
            {
                lblStatus.Text = "Status: Not calculated";
                lblHousingUnit.Text = "Housing Unit: Not calculated";
                return;
            }

            if (score <= 19)
            {
                lblStatus.Text = "Status: Critical";
                lblHousingUnit.Text =
                    "Housing Unit: Intensive Care Unit";
            }
            else if (score <= 39)
            {
                lblStatus.Text = "Status: Serious";
                lblHousingUnit.Text =
                    "Housing Unit: High-Dependency Ward";
            }
            else if (score <= 59)
            {
                lblStatus.Text = "Status: Stable";
                lblHousingUnit.Text = "Housing Unit: Recovery Ward";
            }
            else if (score <= 79)
            {
                lblStatus.Text = "Status: Recovering";
                lblHousingUnit.Text =
                    "Housing Unit: Outdoor Enclosure";
            }
            else
            {
                lblStatus.Text = "Status: Release-Ready";
                lblHousingUnit.Text =
                    "Housing Unit: Pre-Release Camp";
            }
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            if (_isEditMode)
            {
                UpdateAnimal();
            }
            else
            {
                AddNewAnimal();
            }
        }

        private bool ValidateAnimal(
            out string animalID,
            out string name,
            out string species,
            out int age,
            out int score)
        {
            animalID = txtAnimalID.Text.Trim().ToUpper();
            name = txtName.Text.Trim();
            species = txtSpecies.Text.Trim();
            age = 0;
            score = 0;

            if (animalID.Length != 7 ||
                !animalID.StartsWith("WR-"))
            {
                MessageBox.Show("Enter an Animal ID like WR-0001.");
                txtAnimalID.Focus();
                return false;
            }

            for (int i = 3; i < 7; i++)
            {
                if (animalID[i] < '0' || animalID[i] > '9')
                {
                    MessageBox.Show(
                        "Animal ID must contain four digits after WR-.");
                    txtAnimalID.Focus();
                    return false;
                }
            }

            if (name == "" || name.Length > 30 || name.Contains("|"))
            {
                MessageBox.Show("Enter a name of 1 to 30 characters.");
                txtName.Focus();
                return false;
            }

            if (species == "" || species.Length > 30 ||
                species.Contains("|"))
            {
                MessageBox.Show("Enter a species of 1 to 30 characters.");
                txtSpecies.Focus();
                return false;
            }

            if (!int.TryParse(txtAge.Text, out age) ||
                age < 0 || age > 100)
            {
                MessageBox.Show(
                    "Age must be a whole number between 0 and 100.");
                txtAge.Focus();
                return false;
            }

            if (!int.TryParse(txtRecoveryScore.Text, out score) ||
                score < 0 || score > 100)
            {
                MessageBox.Show(
                    "Recovery score must be between 0 and 100.");
                txtRecoveryScore.Focus();
                return false;
            }

            return true;
        }

        private void AddNewAnimal()
        {
            if (!ValidateAnimal(
                out string animalID,
                out string name,
                out string species,
                out int age,
                out int score))
            {
                return;
            }

            // Check whether this Animal ID already exists.
            foreach (Animal animal in repository.GetAllAnimals())
            {
                if (animal.AnimalID.Equals(
                    animalID, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This Animal ID already exists.");
                    txtAnimalID.Focus();
                    return;
                }
            }

            // Create the animal and calculate its status and housing.
            Animal newAnimal = new Animal(
                animalID,
                name,
                species,
                age,
                score,
                "",
                "");

            newAnimal.SetRecoveryScore(score);

            // Save the animal using the required seven-field format.
            repository.SaveAnimal(newAnimal);

            MessageBox.Show("Animal added successfully!");
            this.DialogResult = DialogResult.OK;
            this.Close();

            txtAnimalID.Clear();
            txtName.Clear();
            txtSpecies.Clear();
            txtAge.Clear();
            txtRecoveryScore.Clear();

            lblStatus.Text = "Status: Not calculated";
            lblHousingUnit.Text = "Housing Unit: Not calculated";

            txtAnimalID.Focus();
        }

        private void UpdateAnimal()
        {
            if (_animalToEdit == null)
            {
                MessageBox.Show("No animal was selected to update.");
                return;
            }

            if (!ValidateAnimal(
                out string animalID,
                out string name,
                out string species,
                out int age,
                out int score))
            {
                return;
            }

            _animalToEdit.Name = name;
            _animalToEdit.Species = species;
            _animalToEdit.Age = age;
            _animalToEdit.SetRecoveryScore(score);

            AnimalService service = new AnimalService();
            service.UpdateAnimal(_animalToEdit);

            MessageBox.Show("Animal updated successfully!");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
