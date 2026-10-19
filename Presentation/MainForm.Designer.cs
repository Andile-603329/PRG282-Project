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
            richTextBox1 = new RichTextBox();
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
            AddEditComponents.Location = new Point(29, 159);
            AddEditComponents.Name = "AddEditComponents";
            AddEditComponents.Size = new Size(408, 461);
            AddEditComponents.TabIndex = 0;
            AddEditComponents.TabStop = false;
            AddEditComponents.Text = "Edit Animals";
            AddEditComponents.Enter += groupBox1_Enter;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(128, 405);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(117, 29);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit Animal";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblSelectedAnimalName
            // 
            lblSelectedAnimalName.AutoSize = true;
            lblSelectedAnimalName.Location = new Point(160, 363);
            lblSelectedAnimalName.Name = "lblSelectedAnimalName";
            lblSelectedAnimalName.Size = new Size(45, 20);
            lblSelectedAnimalName.TabIndex = 15;
            lblSelectedAnimalName.Text = "None";
            // 
            // lblAnimalSelected
            // 
            lblAnimalSelected.AutoSize = true;
            lblAnimalSelected.Location = new Point(34, 363);
            lblAnimalSelected.Name = "lblAnimalSelected";
            lblAnimalSelected.Size = new Size(120, 20);
            lblAnimalSelected.TabIndex = 14;
            lblAnimalSelected.Text = "Animal Selected:";
            // 
            // numRecoveryScore
            // 
            numRecoveryScore.Location = new Point(159, 317);
            numRecoveryScore.Name = "numRecoveryScore";
            numRecoveryScore.Size = new Size(158, 27);
            numRecoveryScore.TabIndex = 13;
            // 
            // DtpDateAdmitted
            // 
            DtpDateAdmitted.Location = new Point(158, 271);
            DtpDateAdmitted.Name = "DtpDateAdmitted";
            DtpDateAdmitted.Size = new Size(159, 27);
            DtpDateAdmitted.TabIndex = 12;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(158, 229);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(159, 28);
            cmbGender.TabIndex = 11;
            // 
            // numAge
            // 
            numAge.Location = new Point(158, 185);
            numAge.Name = "numAge";
            numAge.Size = new Size(158, 27);
            numAge.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(158, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(158, 27);
            txtName.TabIndex = 9;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(158, 133);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(158, 27);
            txtSpecies.TabIndex = 8;
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(158, 47);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(158, 27);
            txtAnimalID.TabIndex = 7;
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(35, 320);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(110, 20);
            lblRecoveryScore.TabIndex = 6;
            lblRecoveryScore.Text = "Recovery Score";
            // 
            // lblDateAdmitted
            // 
            lblDateAdmitted.AutoSize = true;
            lblDateAdmitted.Location = new Point(34, 271);
            lblDateAdmitted.Name = "lblDateAdmitted";
            lblDateAdmitted.Size = new Size(108, 20);
            lblDateAdmitted.TabIndex = 5;
            lblDateAdmitted.Text = "Date Admitted";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(35, 232);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(34, 185);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(106, 20);
            lblAge.TabIndex = 3;
            lblAge.Text = "Age (optional)";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(35, 141);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(59, 20);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(35, 89);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(34, 51);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(75, 20);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal ID";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(153, 41);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(117, 29);
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
            ViewAnimals.Location = new Point(517, 43);
            ViewAnimals.Name = "ViewAnimals";
            ViewAnimals.Size = new Size(713, 579);
            ViewAnimals.TabIndex = 1;
            ViewAnimals.TabStop = false;
            ViewAnimals.Text = "View Animals";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
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
            // dgvAnimals
            // 
            dgvAnimals.AllowUserToOrderColumns = true;
            dgvAnimals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAnimals.Location = new Point(42, 118);
            dgvAnimals.Name = "dgvAnimals";
            dgvAnimals.RowHeadersWidth = 51;
            dgvAnimals.Size = new Size(637, 435);
            dgvAnimals.TabIndex = 0;
            // 
            // AnimalSummary
            // 
            AnimalSummary.Controls.Add(richTextBox1);
            AnimalSummary.Location = new Point(1299, 43);
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
            DeleteAnimal.Size = new Size(457, 141);
            DeleteAnimal.TabIndex = 3;
            DeleteAnimal.TabStop = false;
            DeleteAnimal.Text = "Delete Animal";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(302, 77);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 29);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblSelectedAnimalName2
            // 
            lblSelectedAnimalName2.AutoSize = true;
            lblSelectedAnimalName2.Location = new Point(201, 83);
            lblSelectedAnimalName2.Name = "lblSelectedAnimalName2";
            lblSelectedAnimalName2.Size = new Size(45, 20);
            lblSelectedAnimalName2.TabIndex = 18;
            lblSelectedAnimalName2.Text = "None";
            // 
            // lblSlectedAnimal2
            // 
            lblSlectedAnimal2.AutoSize = true;
            lblSlectedAnimal2.Location = new Point(30, 83);
            lblSlectedAnimal2.Name = "lblSlectedAnimal2";
            lblSlectedAnimal2.Size = new Size(120, 20);
            lblSlectedAnimal2.TabIndex = 3;
            lblSlectedAnimal2.Text = "Animal Selected:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 607);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Location = new Point(29, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 111);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Animals";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 51);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 17;
            label2.Text = "Add animal here: ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1822, 660);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(DeleteAnimal);
            Controls.Add(AnimalSummary);
            Controls.Add(ViewAnimals);
            Controls.Add(AddEditComponents);
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
        private RichTextBox richTextBox1;
        private GroupBox DeleteAnimal;
        private Button btnDelete;
        private Label lblSelectedAnimalName2;
        private Label lblSlectedAnimal2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
    }
}
