namespace WildLifeRehabilitationCenter
{
    partial class AddAnimalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new Label();
            lblAnimalId = new Label();
            txtAnimalID = new TextBox();
            lblName = new Label();
            lblSpecies = new Label();
            lblAge = new Label();
            lblGender = new Label();
            lblRecoveryScore = new Label();
            txtName = new TextBox();
            txtSpecies = new TextBox();
            txtAge = new TextBox();
            cmbGender = new ComboBox();
            txtRecoveryScore = new TextBox();
            lblStatus = new Label();
            lblHousingUnit = new Label();
            btnAddAnimal = new Button();
            btnCancel = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(245, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(175, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Animal";
            lblTitle.Click += label1_Click;
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Location = new Point(46, 89);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(59, 15);
            lblAnimalId.TabIndex = 1;
            lblAnimalId.Text = "Animal ID";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(145, 89);
            txtAnimalID.Margin = new Padding(3, 2, 3, 2);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(212, 23);
            txtAnimalID.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(46, 137);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(46, 181);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(46, 15);
            lblSpecies.TabIndex = 4;
            lblSpecies.Text = "Species";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(43, 225);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(28, 15);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(46, 275);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(45, 15);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(46, 320);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(87, 15);
            lblRecoveryScore.TabIndex = 7;
            lblRecoveryScore.Text = "Recovery Score";
            // 
            // txtName
            // 
            txtName.Location = new Point(145, 137);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 23);
            txtName.TabIndex = 8;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(145, 181);
            txtSpecies.Margin = new Padding(3, 2, 3, 2);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(212, 23);
            txtSpecies.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(145, 223);
            txtAge.Margin = new Padding(3, 2, 3, 2);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(212, 23);
            txtAge.TabIndex = 10;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Female", "Male" });
            cmbGender.Location = new Point(145, 275);
            cmbGender.Margin = new Padding(3, 2, 3, 2);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(212, 23);
            cmbGender.TabIndex = 11;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(145, 320);
            txtRecoveryScore.Margin = new Padding(3, 2, 3, 2);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(212, 23);
            txtRecoveryScore.TabIndex = 12;
            txtRecoveryScore.TextChanged += txtRecoveryScore_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(58, 370);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(122, 15);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status: Not calculated";
            // 
            // lblHousingUnit
            // 
            lblHousingUnit.AutoSize = true;
            lblHousingUnit.Location = new Point(58, 399);
            lblHousingUnit.Name = "lblHousingUnit";
            lblHousingUnit.Size = new Size(160, 15);
            lblHousingUnit.TabIndex = 14;
            lblHousingUnit.Text = "Housing Unit: Not calculated";
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Location = new Point(223, 429);
            btnAddAnimal.Margin = new Padding(3, 2, 3, 2);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(100, 22);
            btnAddAnimal.TabIndex = 15;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(353, 429);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 22);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 452);
            Controls.Add(btnCancel);
            Controls.Add(btnAddAnimal);
            Controls.Add(lblHousingUnit);
            Controls.Add(lblStatus);
            Controls.Add(txtRecoveryScore);
            Controls.Add(cmbGender);
            Controls.Add(txtAge);
            Controls.Add(txtSpecies);
            Controls.Add(txtName);
            Controls.Add(lblRecoveryScore);
            Controls.Add(lblGender);
            Controls.Add(lblAge);
            Controls.Add(lblSpecies);
            Controls.Add(lblName);
            Controls.Add(txtAnimalID);
            Controls.Add(lblAnimalId);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddAnimalForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add New Animal";
            Load += AddAnimalForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAnimalId;
        private TextBox txtAnimalID;
        private Label lblName;
        private Label lblSpecies;
        private Label lblAge;
        private Label lblGender;
        private Label lblRecoveryScore;
        private TextBox txtName;
        private TextBox txtSpecies;
        private TextBox txtAge;
        private ComboBox cmbGender;
        private TextBox txtRecoveryScore;
        private Label lblStatus;
        private Label lblHousingUnit;
        private Button btnAddAnimal;
        private Button btnCancel;
        private ContextMenuStrip contextMenuStrip1;
    }
}