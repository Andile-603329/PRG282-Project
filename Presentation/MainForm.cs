using WildLifeRehabilitationCenter;
using WildLifeRehabilitationCenter.Business;
using WildLifeRehabilitationCenter.Data;
using System;
using System.Windows.Forms;

namespace WildLifeRehabilitationCenter.Presentation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            AnimalRepository AnimalRepo = new AnimalRepository();
            dgvAnimals.DataSource = AnimalRepo.GetAllAnimals();       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnimalForm addForm = new AddAnimalForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                RefreshAnimalGrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count > 0)
            {
                //Get selected animal ID from the DataGridView
                var selectedAnimal = (Animal)dgvAnimals.SelectedRows[0].DataBoundItem;

                //Confirm
                var confirmResult = MessageBox.Show($"Are you sure to delete animal {selectedAnimal.Name}?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    AnimalService service = new AnimalService();
                    service.DeleteAnimal(selectedAnimal.AnimalID);

                    RefreshAnimalGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select an animal row to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAnimals.SelectedRows.Count > 0)
            {
                var selectedAnimal  = (Animal)dgvAnimals.SelectedRows[0].DataBoundItem;

                using (AddAnimalForm editForm = new AddAnimalForm(selectedAnimal))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        RefreshAnimalGrid();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an animal row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshAnimalGrid()
        {
            AnimalRepository AnimalRepo = new AnimalRepository();
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = AnimalRepo.GetAllAnimals();
        }
    }
}
