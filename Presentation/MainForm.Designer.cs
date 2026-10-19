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
            btnAdd = new Button();
            ViewAnimals = new GroupBox();
            textBox1 = new TextBox();
            lblSearch = new Label();
            dgvAnimals = new DataGridView();
            DeleteAnimal = new GroupBox();
            btnDelete = new Button();
            lblDeleteSelected = new Label();
            lblSlectedAnimal2 = new Label();
            AnimalSummary = new GroupBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            btnEdit = new Button();
            AddEditComponents = new GroupBox();
            lblEditSelected = new Label();
            lblAnimalID = new Label();
            ViewAnimals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).BeginInit();
            DeleteAnimal.SuspendLayout();
            AnimalSummary.SuspendLayout();
            groupBox1.SuspendLayout();
            AddEditComponents.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(223, 26);
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
            ViewAnimals.Location = new Point(452, 16);
            ViewAnimals.Margin = new Padding(3, 2, 3, 2);
            ViewAnimals.Name = "ViewAnimals";
            ViewAnimals.Padding = new Padding(3, 2, 3, 2);
            ViewAnimals.Size = new Size(940, 521);
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
            dgvAnimals.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAnimals.Size = new Size(881, 409);
            dgvAnimals.TabIndex = 0;
            // 
            // AnimalSummary
            // 
            AnimalSummary.Controls.Add(richTextBox1);
            AnimalSummary.Location = new Point(1137, 32);
            AnimalSummary.Margin = new Padding(3, 2, 3, 2);
            AnimalSummary.Name = "AnimalSummary";
            AnimalSummary.Padding = new Padding(3, 2, 3, 2);
            AnimalSummary.Size = new Size(400, 314);
            AnimalSummary.TabIndex = 2;
            AnimalSummary.TabStop = false;
            AnimalSummary.Text = "Animal Summary";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(26, 48);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(349, 242);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // DeleteAnimal
            // 
            DeleteAnimal.Controls.Add(btnDelete);
            DeleteAnimal.Controls.Add(lblDeleteSelected);
            DeleteAnimal.Controls.Add(lblSlectedAnimal2);
            DeleteAnimal.Location = new Point(25, 154);
            DeleteAnimal.Margin = new Padding(3, 2, 3, 2);
            DeleteAnimal.Name = "DeleteAnimal";
            DeleteAnimal.Padding = new Padding(3, 2, 3, 2);
            DeleteAnimal.Size = new Size(400, 65);
            DeleteAnimal.TabIndex = 3;
            DeleteAnimal.TabStop = false;
            DeleteAnimal.Text = "Delete Animal";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(223, 26);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 22);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblDeleteSelected
            // 
            lblDeleteSelected.AutoSize = true;
            lblDeleteSelected.Location = new Point(143, 30);
            lblDeleteSelected.Name = "lblDeleteSelected";
            lblDeleteSelected.Size = new Size(36, 15);
            lblDeleteSelected.TabIndex = 18;
            lblDeleteSelected.Text = "None";
            // 
            // lblSlectedAnimal2
            // 
            lblSlectedAnimal2.AutoSize = true;
            lblSlectedAnimal2.Location = new Point(21, 30);
            lblSlectedAnimal2.Name = "lblSlectedAnimal2";
            lblSlectedAnimal2.Size = new Size(95, 15);
            lblSlectedAnimal2.TabIndex = 3;
            lblSlectedAnimal2.Text = "Animal Selected:";
            // 
            // AnimalSummary
            // 
            AnimalSummary.Controls.Add(richTextBox1);
            AnimalSummary.Location = new Point(25, 223);
            AnimalSummary.Margin = new Padding(3, 2, 3, 2);
            AnimalSummary.Name = "AnimalSummary";
            AnimalSummary.Padding = new Padding(3, 2, 3, 2);
            AnimalSummary.Size = new Size(400, 314);
            AnimalSummary.TabIndex = 2;
            AnimalSummary.TabStop = false;
            AnimalSummary.Text = "Animal Summary";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(26, 48);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(349, 242);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
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
            groupBox1.Size = new Size(400, 65);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Animals";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 30);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 17;
            label2.Text = "Add animal here: ";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(223, 26);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(102, 22);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Edit Animal";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // AddEditComponents
            // 
            AddEditComponents.Controls.Add(lblEditSelected);
            AddEditComponents.Controls.Add(btnEdit);
            AddEditComponents.Controls.Add(lblAnimalID);
            AddEditComponents.Location = new Point(25, 85);
            AddEditComponents.Margin = new Padding(3, 2, 3, 2);
            AddEditComponents.Name = "AddEditComponents";
            AddEditComponents.Padding = new Padding(3, 2, 3, 2);
            AddEditComponents.Size = new Size(400, 65);
            AddEditComponents.TabIndex = 0;
            AddEditComponents.TabStop = false;
            AddEditComponents.Text = "Edit Animals";
            // 
            // lblEditSelected
            // 
            lblEditSelected.AutoSize = true;
            lblEditSelected.Location = new Point(143, 30);
            lblEditSelected.Name = "lblEditSelected";
            lblEditSelected.Size = new Size(36, 15);
            lblEditSelected.TabIndex = 19;
            lblEditSelected.Text = "None";
            // 
            // lblAnimalID
            // 
            lblAnimalID.AutoSize = true;
            lblAnimalID.Location = new Point(32, 30);
            lblAnimalID.Name = "lblAnimalID";
            lblAnimalID.Size = new Size(95, 15);
            lblAnimalID.TabIndex = 0;
            lblAnimalID.Text = "Animal Selected:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 552);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(DeleteAnimal);
            Controls.Add(AnimalSummary);
            Controls.Add(ViewAnimals);
            Controls.Add(AddEditComponents);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Baobab Ridge Wildlife Rehabilitation Records System";
            ViewAnimals.ResumeLayout(false);
            ViewAnimals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAnimals).EndInit();
            DeleteAnimal.ResumeLayout(false);
            DeleteAnimal.PerformLayout();
            AnimalSummary.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            AddEditComponents.ResumeLayout(false);
            AddEditComponents.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAdd;
        private GroupBox ViewAnimals;
        private TextBox textBox1;
        private Label lblSearch;
        private DataGridView dgvAnimals;
        private GroupBox AnimalSummary;
        private RichTextBox txtSummaryDisplay;
        private GroupBox DeleteAnimal;
        private Button btnDelete;
        private Label lblDeleteSelected;
        private Label lblSlectedAnimal2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
    }
}
