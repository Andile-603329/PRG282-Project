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
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnimalForm addForm = new AddAnimalForm();
            addForm.ShowDialog();
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

                    dgvAnimals.Refresh();
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
                        dgvAnimals.Refresh();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an animal row to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            AnimalRepository animalRepository = new AnimalRepository();
            SummaryService summaryService = new SummaryService();
            SummaryFileRepository summaryFileRepository = new SummaryFileRepository();

            // 1. Get all animals from animals.txt
            List<Animal> animals = animalRepository.GetAllAnimals();

            // 2. Do the calculations
            SummaryResult result = summaryService.BuildSummary(animals);

            // 3. Turn the results into the report text
            string reportText = summaryFileRepository.BuildReportText(result, DateTime.Now);

            // 4. Show the report on the form (the brief says a message box alone is not enough)
            txtSummaryDisplay.Text = reportText;

            // 5. Save to summary.txt, and warn the user if it failed
            bool saved = summaryFileRepository.WriteSummary(reportText);
            if (!saved)
            {
                MessageBox.Show("The summary could not be saved to summary.txt. Make sure the file is not open in another program or set to read-only.",
                    "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
