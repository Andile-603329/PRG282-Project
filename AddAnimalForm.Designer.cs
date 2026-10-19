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
            cmbHousingUnit = new ComboBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(280, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Animal";
            lblTitle.Click += label1_Click;
            // 
            // lblAnimalId
            // 
            lblAnimalId.AutoSize = true;
            lblAnimalId.Location = new Point(53, 119);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(75, 20);
            lblAnimalId.TabIndex = 1;
            lblAnimalId.Text = "Animal ID";
            // 
            // txtAnimalID
            // 
            txtAnimalID.Location = new Point(166, 119);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(242, 27);
            txtAnimalID.TabIndex = 2;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(53, 183);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(53, 241);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(59, 20);
            lblSpecies.TabIndex = 4;
            lblSpecies.Text = "Species";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(49, 300);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 5;
            lblAge.Text = "Age";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(53, 367);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(57, 20);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender";
            // 
            // lblRecoveryScore
            // 
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(53, 427);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(110, 20);
            lblRecoveryScore.TabIndex = 7;
            lblRecoveryScore.Text = "Recovery Score";
            // 
            // txtName
            // 
            txtName.Location = new Point(166, 183);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 27);
            txtName.TabIndex = 8;
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(166, 241);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(242, 27);
            txtSpecies.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(166, 297);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(242, 27);
            txtAge.TabIndex = 10;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Female", "Male" });
            cmbGender.Location = new Point(166, 367);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(242, 28);
            cmbGender.TabIndex = 11;
            // 
            // txtRecoveryScore
            // 
            txtRecoveryScore.Location = new Point(166, 427);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(242, 27);
            txtRecoveryScore.TabIndex = 12;
            txtRecoveryScore.TextChanged += txtRecoveryScore_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(53, 519);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(153, 20);
            lblStatus.TabIndex = 13;
            lblStatus.Text = "Status: Not calculated";
            // 
            // lblHousingUnit
            // 
            lblHousingUnit.AutoSize = true;
            lblHousingUnit.Location = new Point(53, 480);
            lblHousingUnit.Name = "lblHousingUnit";
            lblHousingUnit.Size = new Size(95, 20);
            lblHousingUnit.TabIndex = 14;
            lblHousingUnit.Text = "Housing Unit";
            // 
            // btnAddAnimal
            // 
            btnAddAnimal.Location = new Point(255, 572);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(114, 29);
            btnAddAnimal.TabIndex = 15;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(403, 572);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 29);
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
            // cmbHousingUnit
            // 
            cmbHousingUnit.FormattingEnabled = true;
            cmbHousingUnit.Items.AddRange(new object[] { "Intensive Care Unit", "High-Dependency Ward", "Recovery ward", "Outdoor Enclosure", "Pre-Release Camp" });
            cmbHousingUnit.Location = new Point(166, 477);
            cmbHousingUnit.Name = "cmbHousingUnit";
            cmbHousingUnit.Size = new Size(242, 28);
            cmbHousingUnit.TabIndex = 17;
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 603);
            Controls.Add(cmbHousingUnit);
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
        private ComboBox cmbHousingUnit;
    }
}