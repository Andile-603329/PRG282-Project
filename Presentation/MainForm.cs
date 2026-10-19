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
            var animals = new List<Animal>()
{
            new Animal("WR-0001", "Kiki", "Parrot",5, "Female", DateTime.Now,43,"Recovery Ward"),
            new Animal("WR-0987", "Max", "Dog", null,"Male", DateTime.Now,16,"Intensive Care Unit")
};

            AnimalRepo.SeedAnimals(animals);

            List<Animal> List = AnimalRepo.GetAllAnimals();
            dgvAnimals.DataSource = AnimalRepo.GetAllAnimals();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

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
                var selectedAnimal = (Animal)dgvAnimals.SelectedRows[0].DataBoundItem;

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

        // Builds the summary from Animals.txt, saves it to summary.txt and shows it on the form.
        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            AnimalRepository animalRepository = new AnimalRepository();
            SummaryService summaryService = new SummaryService();
            SummaryFileRepository summaryFileRepository = new SummaryFileRepository();

            List<Animal> animals = animalRepository.GetAllAnimals();
            SummaryResult result = summaryService.BuildSummary(animals);
            string reportText = summaryFileRepository.BuildReportText(result, DateTime.Now);

            // Show the report on the form (a message box alone is not enough).
            richTextBox1.Text = reportText;

            bool saved = summaryFileRepository.WriteSummary(reportText);
            if (!saved)
            {
                MessageBox.Show("The summary could not be saved to summary.txt. Make sure the file is not open in another program or set to read-only.",
                    "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
