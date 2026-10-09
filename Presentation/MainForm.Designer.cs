namespace WildLifeRehabilitationCenter.Presentation
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AddEditComponents = new GroupBox();
            lblAnimalID = new Label();
            lblName = new Label();
            lblSpecies = new Label();
            lblAge = new Label();
            lblGender = new Label();
            lblDateAdmitted = new Label();
            lblRecoveryScore = new Label();
            txtAnimalID = new TextBox();
            txtSpecies = new TextBox();
            txtName = new TextBox();
            numAge = new NumericUpDown();
            cmbGender = new ComboBox();
            DtpDateAdmitted = new DateTimePicker();
            numRecoveryScore = new NumericUpDown();
            lblAnimalSelected = new Label();
            lblSelectedAnimalName = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            ViewAnimals = new GroupBox();
            dataGridView1 = new DataGridView();
            lblSearch = new Label();
            textBox1 = new TextBox();
            AnimalSummary = new GroupBox();
            richTextBox1 = new RichTextBox();
            DeleteAnimal = new GroupBox();
            lblSlectedAnimal2 = new Label();
            lblSelectedAnimalName2 = new Label();
            btnDelete = new Button();
            AddEditComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).BeginInit();
            ViewAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            AnimalSummary.SuspendLayout();
            DeleteAnimal.SuspendLayout();
            SuspendLayout();
            // 
            // AddEditComponents
            // 
            AddEditComponents.Controls.Add(btnEdit);
            AddEditComponents.Controls.Add(btnAdd);
            AddEditComponents.Controls.Add(lblSelectedAnimalName);
            AddEditComponents.Controls.Add(lblAnimalSelected);
            AddEditComponents.Controls.Add(numRecoveryScore);
            AddEditComponents.Controls.Add(DtpDateAdmitted);
            AddEditComponents.Controls.Add(cmbGender);
            AddEditComponents.Controls.Add(numAge);
            AddEditComponents.Controls.Add(txtName);
            AddEditComponents.Controls.Add(txtSpecies);
            AddEditComponents.Controls.Add(txtAnimalID);
            AddEditComponents.Controls.Add(lblRecoveryScore);
            AddEditComponents.Controls.Add(lblDateAdmitted);
            AddEditComponents.Controls.Add(lblGender);
            AddEditComponents.Controls.Add(lblAge);
            AddEditComponents.Controls.Add(lblSpecies);
            AddEditComponents.Controls.Add(lblName);
            AddEditComponents.Controls.Add(lblAnimalID);
            AddEditComponents.Location = new Point(29, 42);
            AddEditComponents.Name = "AddEditComponents";
            AddEditComponents.Size = new Size(408, 579);
            AddEditComponents.TabIndex = 0;
            AddEditComponents.TabStop = false;
            AddEditComponents.Text = "Add Or Edit Animals";
            AddEditComponents.Enter += groupBox1_Enter;
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(34, 69);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(75, 20);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(34, 117);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(34, 165);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(59, 20);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(34, 209);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(106, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age (optional)";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(34, 254);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // lblDateAdmitted
            // 
            lblDateAdmitted.AutoSize = true;
            lblDateAdmitted.Location = new Point(34, 297);
            lblDateAdmitted.Name = "lblDateAdmitted";
            lblDateAdmitted.Size = new Size(108, 20);
            lblDateAdmitted.TabIndex = 5;
            lblDateAdmitted.Text = "Date Admitted";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(34, 344);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(110, 20);
            lblRecoveryScore.TabIndex = 6;
            lblRecoveryScore.Text = "Recovery Score";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(170, 69);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(158, 27);
            txtAnimalID.TabIndex = 7;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(170, 165);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(158, 27);
            txtSpecies.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(170, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(158, 27);
            txtName.TabIndex = 9;
            // 
            // numAge
            // 
            numAge.Location = new Point(170, 209);
            numAge.Name = "numAge";
            numAge.Size = new Size(158, 27);
            numAge.TabIndex = 10;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(169, 254);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(159, 28);
            cmbGender.TabIndex = 11;
            // 
            // DtpDateAdmitted
            // 
            DtpDateAdmitted.Location = new Point(168, 297);
            DtpDateAdmitted.Name = "DtpDateAdmitted";
            DtpDateAdmitted.Size = new Size(159, 27);
            DtpDateAdmitted.TabIndex = 12;
            // 
            // numRecoveryScore
            // 
            numRecoveryScore.Location = new Point(169, 344);
            numRecoveryScore.Name = "numRecoveryScore";
            numRecoveryScore.Size = new Size(158, 27);
            numRecoveryScore.TabIndex = 13;
            // 
            // lblAnimalSelected
            // 
            lblAnimalSelected.AutoSize = true;
            lblAnimalSelected.Location = new Point(34, 399);
            lblAnimalSelected.Name = "lblAnimalSelected";
            lblAnimalSelected.Size = new Size(120, 20);
            lblAnimalSelected.TabIndex = 14;
            lblAnimalSelected.Text = "Animal Selected:";
            // 
            // lblSelectedAnimalName
            // 
            lblSelectedAnimalName.AutoSize = true;
            lblSelectedAnimalName.Location = new Point(168, 399);
            lblSelectedAnimalName.Name = "lblSelectedAnimalName";
            lblSelectedAnimalName.Size = new Size(45, 20);
            lblSelectedAnimalName.TabIndex = 15;
            lblSelectedAnimalName.Text = "None";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(34, 475);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 29);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(211, 475);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 29);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit Animal";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // ViewAnimals
            // 
            ViewAnimals.Controls.Add(textBox1);
            ViewAnimals.Controls.Add(lblSearch);
            ViewAnimals.Controls.Add(dataGridView1);
            ViewAnimals.Location = new Point(516, 42);
            ViewAnimals.Name = "ViewAnimals";
            ViewAnimals.Size = new Size(713, 579);
            ViewAnimals.TabIndex = 1;
            ViewAnimals.TabStop = false;
            ViewAnimals.Text = "View Animals";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(42, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(637, 435);
            dataGridView1.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(46, 67);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(53, 20);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // AnimalSummary
            // 
            AnimalSummary.Controls.Add(richTextBox1);
            AnimalSummary.Location = new Point(1299, 42);
            AnimalSummary.Name = "AnimalSummary";
            AnimalSummary.Size = new Size(457, 419);
            AnimalSummary.TabIndex = 2;
            AnimalSummary.TabStop = false;
            AnimalSummary.Text = "Animal Summary";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(30, 64);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(398, 321);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // DeleteAnimal
            // 
            DeleteAnimal.Controls.Add(btnDelete);
            DeleteAnimal.Controls.Add(lblSelectedAnimalName2);
            DeleteAnimal.Controls.Add(lblSlectedAnimal2);
            DeleteAnimal.Location = new Point(1299, 479);
            DeleteAnimal.Name = "DeleteAnimal";
            DeleteAnimal.Size = new Size(457, 142);
            DeleteAnimal.TabIndex = 3;
            DeleteAnimal.TabStop = false;
            DeleteAnimal.Text = "Delete Animal";
            // 
            // lblSlectedAnimal2
            // 
            lblSlectedAnimal2.AutoSize = true;
            lblSlectedAnimal2.Location = new Point(30, 82);
            lblSlectedAnimal2.Name = "lblSlectedAnimal2";
            lblSlectedAnimal2.Size = new Size(120, 20);
            lblSlectedAnimal2.TabIndex = 3;
            lblSlectedAnimal2.Text = "Animal Selected:";
            // 
            // lblSelectedAnimalName2
            // 
            lblSelectedAnimalName2.AutoSize = true;
            lblSelectedAnimalName2.Location = new Point(201, 82);
            lblSelectedAnimalName2.Name = "lblSelectedAnimalName2";
            lblSelectedAnimalName2.Size = new Size(45, 20);
            lblSelectedAnimalName2.TabIndex = 18;
            lblSelectedAnimalName2.Text = "None";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(302, 78);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1822, 660);
            Controls.Add(DeleteAnimal);
            Controls.Add(AnimalSummary);
            Controls.Add(ViewAnimals);
            Controls.Add(AddEditComponents);
            Name = "MainForm";
            Text = "Baobab Ridge Wildlife Rehabilitation Records System";
            AddEditComponents.ResumeLayout(false);
            AddEditComponents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).EndInit();
            ViewAnimals.ResumeLayout(false);
            ViewAnimals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            AnimalSummary.ResumeLayout(false);
            DeleteAnimal.ResumeLayout(false);
            DeleteAnimal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox AddEditComponents;
        private Label lblRecoveryScore;
        private Label lblDateAdmitted;
        private Label lblGender;
        private Label lblAge;
        private Label lblSpecies;
        private Label lblName;
        private Label lblAnimalID;
        private NumericUpDown numRecoveryScore;
        private DateTimePicker DtpDateAdmitted;
        private ComboBox cmbGender;
        private NumericUpDown numAge;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAnimalID;
        private Button btnEdit;
        private Button btnAdd;
        private Label lblSelectedAnimalName;
        private Label lblAnimalSelected;
        private GroupBox ViewAnimals;
        private TextBox textBox1;
        private Label lblSearch;
        private DataGridView dataGridView1;
        private GroupBox AnimalSummary;
        private RichTextBox richTextBox1;
        private GroupBox DeleteAnimal;
        private Button btnDelete;
        private Label lblSelectedAnimalName2;
        private Label lblSlectedAnimal2;
    }
}
