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
            btnEdit = new Button();
            lblSelectedAnimalName = new Label();
            lblAnimalSelected = new Label();
            numRecoveryScore = new NumericUpDown();
            DtpDateAdmitted = new DateTimePicker();
            cmbGender = new ComboBox();
            numAge = new NumericUpDown();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAnimalID = new TextBox();
            lblRecoveryScore = new Label();
            lblDateAdmitted = new Label();
            lblGender = new Label();
            lblAge = new Label();
            lblSpecies = new Label();
            lblName = new Label();
            lblAnimalID = new Label();
            btnAdd = new Button();
            ViewAnimals = new GroupBox();
            textBox1 = new TextBox();
            lblSearch = new Label();
            dgvAnimals = new DataGridView();
            AnimalSummary = new GroupBox();
            btnGenerateSummary = new Button();
            txtSummaryDisplay = new RichTextBox();
            DeleteAnimal = new GroupBox();
            btnDelete = new Button();
            lblSelectedAnimalName2 = new Label();
            lblSlectedAnimal2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            AddEditComponents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ViewAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            AnimalSummary.SuspendLayout();
            DeleteAnimal.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // AddEditComponents
            // 
            AddEditComponents.Controls.Add(btnEdit);
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
            AddEditComponents.Location = new Point(25, 119);
            AddEditComponents.Margin = new Padding(3, 2, 3, 2);
            AddEditComponents.Name = "AddEditComponents";
            AddEditComponents.Padding = new Padding(3, 2, 3, 2);
            AddEditComponents.Size = new Size(357, 346);
            AddEditComponents.TabIndex = 0;
            AddEditComponents.TabStop = false;
            AddEditComponents.Text = "Edit Animals";
            AddEditComponents.Enter += groupBox1_Enter;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(112, 304);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 22);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit Animal";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblSelectedAnimalName
            // 
            lblSelectedAnimalName.AutoSize = true;
            lblSelectedAnimalName.Location = new Point(140, 272);
            lblSelectedAnimalName.Name = "lblSelectedAnimalName";
            lblSelectedAnimalName.Size = new Size(36, 15);
            lblSelectedAnimalName.TabIndex = 15;
            lblSelectedAnimalName.Text = "None";
            // 
            // lblAnimalSelected
            // 
            lblAnimalSelected.AutoSize = true;
            lblAnimalSelected.Location = new Point(30, 272);
            lblAnimalSelected.Name = "lblAnimalSelected";
            lblAnimalSelected.Size = new Size(95, 15);
            lblAnimalSelected.TabIndex = 14;
            lblAnimalSelected.Text = "Animal Selected:";
            // 
            // numRecoveryScore
            // 
            numRecoveryScore.Location = new Point(139, 238);
            numRecoveryScore.Margin = new Padding(3, 2, 3, 2);
            numRecoveryScore.Name = "numRecoveryScore";
            numRecoveryScore.Size = new Size(138, 23);
            numRecoveryScore.TabIndex = 13;
            // 
            // DtpDateAdmitted
            // 
            DtpDateAdmitted.Location = new Point(138, 203);
            DtpDateAdmitted.Margin = new Padding(3, 2, 3, 2);
            DtpDateAdmitted.Name = "DtpDateAdmitted";
            DtpDateAdmitted.Size = new Size(140, 23);
            DtpDateAdmitted.TabIndex = 12;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(138, 172);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(140, 23);
            cmbGender.TabIndex = 11;
            // 
            // numAge
            // 
            numAge.Location = new Point(138, 139);
            numAge.Margin = new Padding(3, 2, 3, 2);
            numAge.Name = "numAge";
            numAge.Size = new Size(138, 23);
            numAge.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(138, 64);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(139, 23);
            txtName.TabIndex = 9;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(138, 100);
            txtSpecies.Margin = new Padding(3, 2, 3, 2);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(139, 23);
            txtSpecies.TabIndex = 8;
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(138, 35);
            txtAnimalID.Margin = new Padding(3, 2, 3, 2);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(139, 23);
            txtAnimalID.TabIndex = 7;
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(31, 240);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(87, 15);
            lblRecoveryScore.TabIndex = 6;
            lblRecoveryScore.Text = "Recovery Score";
            // 
            // lblDateAdmitted
            // 
            lblDateAdmitted.AutoSize = true;
            lblDateAdmitted.Location = new Point(30, 203);
            lblDateAdmitted.Name = "lblDateAdmitted";
            lblDateAdmitted.Size = new Size(84, 15);
            lblDateAdmitted.TabIndex = 5;
            lblDateAdmitted.Text = "Date Admitted";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(31, 174);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(30, 139);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(83, 15);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age (optional)";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(31, 106);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(46, 15);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(31, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(30, 38);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(59, 15);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(134, 31);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(102, 22);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add Animal";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ViewAnimals
            // 
            ViewAnimals.Controls.Add(textBox1);
            ViewAnimals.Controls.Add(lblSearch);
            ViewAnimals.Controls.Add(dgvAnimals);
            ViewAnimals.Location = new Point(452, 32);
            ViewAnimals.Margin = new Padding(3, 2, 3, 2);
            ViewAnimals.Name = "ViewAnimals";
            ViewAnimals.Padding = new Padding(3, 2, 3, 2);
            ViewAnimals.Size = new Size(624, 434);
            ViewAnimals.TabIndex = 1;
            ViewAnimals.TabStop = false;
            ViewAnimals.Text = "View Animals";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 48);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(40, 50);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search";
            // 
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToOrderColumns = true;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(37, 88);
            dgvAnimals.Margin = new Padding(3, 2, 3, 2);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.Size = new Size(557, 326);
            dgvAnimals.TabIndex = 0;
            // 
            // AnimalSummary
            // 
            AnimalSummary.Controls.Add(btnGenerateSummary);
            AnimalSummary.Controls.Add(txtSummaryDisplay);
            AnimalSummary.Location = new Point(1137, 32);
            AnimalSummary.Margin = new Padding(3, 2, 3, 2);
            AnimalSummary.Name = "AnimalSummary";
            AnimalSummary.Padding = new Padding(3, 2, 3, 2);
            AnimalSummary.Size = new Size(400, 314);
            AnimalSummary.TabIndex = 2;
            AnimalSummary.TabStop = false;
            AnimalSummary.Text = "Animal Summary";
            // 
            // btnGenerateSummary
            // 
            btnGenerateSummary.Location = new Point(264, 18);
            btnGenerateSummary.Name = "btnGenerateSummary";
            btnGenerateSummary.Size = new Size(101, 23);
            btnGenerateSummary.TabIndex = 1;
            btnGenerateSummary.Text = "Summary";
            btnGenerateSummary.UseVisualStyleBackColor = true;
            btnGenerateSummary.Click += btnGenerateSummary_Click;
            // 
            // txtSummaryDisplay
            // 
            txtSummaryDisplay.Location = new Point(26, 48);
            txtSummaryDisplay.Margin = new Padding(3, 2, 3, 2);
            txtSummaryDisplay.Name = "txtSummaryDisplay";
            txtSummaryDisplay.ReadOnly = true;
            txtSummaryDisplay.Size = new Size(349, 242);
            txtSummaryDisplay.TabIndex = 0;
            txtSummaryDisplay.Text = "";
            txtSummaryDisplay.TextChanged += richTextBox1_TextChanged;
            // 
            // DeleteAnimal
            // 
            DeleteAnimal.Controls.Add(btnDelete);
            DeleteAnimal.Controls.Add(lblSelectedAnimalName2);
            DeleteAnimal.Controls.Add(lblSlectedAnimal2);
            DeleteAnimal.Location = new Point(1137, 359);
            DeleteAnimal.Margin = new Padding(3, 2, 3, 2);
            DeleteAnimal.Name = "DeleteAnimal";
            DeleteAnimal.Padding = new Padding(3, 2, 3, 2);
            DeleteAnimal.Size = new Size(400, 106);
            DeleteAnimal.TabIndex = 3;
            DeleteAnimal.TabStop = false;
            DeleteAnimal.Text = "Delete Animal";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(264, 58);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 22);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSelectedAnimalName2
            // 
            lblSelectedAnimalName2.AutoSize = true;
            lblSelectedAnimalName2.Location = new Point(176, 62);
            lblSelectedAnimalName2.Name = "lblSelectedAnimalName2";
            lblSelectedAnimalName2.Size = new Size(36, 15);
            lblSelectedAnimalName2.TabIndex = 18;
            lblSelectedAnimalName2.Text = "None";
            // 
            // lblSlectedAnimal2
            // 
            lblSlectedAnimal2.AutoSize = true;
            lblSlectedAnimal2.Location = new Point(26, 62);
            lblSlectedAnimal2.Name = "lblSlectedAnimal2";
            lblSlectedAnimal2.Size = new Size(95, 15);
            lblSlectedAnimal2.TabIndex = 3;
            lblSlectedAnimal2.Text = "Animal Selected:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(99, 455);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(25, 16);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(357, 83);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Animals";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 38);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 17;
            label2.Text = "Add animal here: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1594, 495);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(DeleteAnimal);
            Controls.Add(AnimalSummary);
            Controls.Add(ViewAnimals);
            Controls.Add(AddEditComponents);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Baobab Ridge Wildlife Rehabilitation Records System";
            AddEditComponents.ResumeLayout(false);
            AddEditComponents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numRecoveryScore).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ViewAnimals.ResumeLayout(false);
            ViewAnimals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            AnimalSummary.ResumeLayout(false);
            DeleteAnimal.ResumeLayout(false);
            DeleteAnimal.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridView dgvAnimals;
        private GroupBox AnimalSummary;
        private RichTextBox txtSummaryDisplay;
        private GroupBox DeleteAnimal;
        private Button btnDelete;
        private Label lblSelectedAnimalName2;
        private Label lblSlectedAnimal2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Button btnGenerateSummary;
    }
}
