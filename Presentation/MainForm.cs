
using WildLifeRehabilitationCenter;
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
    }
}
