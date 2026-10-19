using System.Drawing;
using System.Windows.Forms;

namespace WildLifeRehabilitationCenter
{
    partial class AddAnimalForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblTitle = new Label();
            lblAnimalId = new Label();
            txtAnimalID = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblSpecies = new Label();
            txtSpecies = new TextBox();
            lblAge = new Label();
            txtAge = new TextBox();
            lblRecoveryScore = new Label();
            txtRecoveryScore = new TextBox();
            lblStatus = new Label();
            lblHousingUnit = new Label();
            btnAddAnimal = new Button();
            btnCancel = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);

            SuspendLayout();

            // Form title
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(250, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add New Animal";
            lblTitle.Click += label1_Click;

            // Animal ID
            lblAnimalId.AutoSize = true;
            lblAnimalId.Location = new Point(53, 119);
            lblAnimalId.Name = "lblAnimalId";
            lblAnimalId.Size = new Size(75, 20);
            lblAnimalId.TabIndex = 1;
            lblAnimalId.Text = "Animal ID";

            txtAnimalID.Location = new Point(166, 119);
            txtAnimalID.Name = "txtAnimalID";
            txtAnimalID.Size = new Size(242, 27);
            txtAnimalID.TabIndex = 2;

            // Name
            lblName.AutoSize = true;
            lblName.Location = new Point(53, 183);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 3;
            lblName.Text = "Name";

            txtName.Location = new Point(166, 183);
            txtName.Name = "txtName";
            txtName.Size = new Size(242, 27);
            txtName.TabIndex = 4;

            // Species
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(53, 241);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(59, 20);
            lblSpecies.TabIndex = 5;
            lblSpecies.Text = "Species";

            txtSpecies.Location = new Point(166, 241);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(242, 27);
            txtSpecies.TabIndex = 6;

            // Age
            lblAge.AutoSize = true;
            lblAge.Location = new Point(49, 300);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(36, 20);
            lblAge.TabIndex = 7;
            lblAge.Text = "Age";

            txtAge.Location = new Point(166, 297);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(242, 27);
            txtAge.TabIndex = 8;

            // Recovery score
            lblRecoveryScore.AutoSize = true;
            lblRecoveryScore.Location = new Point(49, 360);
            lblRecoveryScore.Name = "lblRecoveryScore";
            lblRecoveryScore.Size = new Size(110, 20);
            lblRecoveryScore.TabIndex = 9;
            lblRecoveryScore.Text = "Recovery Score";

            txtRecoveryScore.Location = new Point(166, 353);
            txtRecoveryScore.Name = "txtRecoveryScore";
            txtRecoveryScore.Size = new Size(242, 27);
            txtRecoveryScore.TabIndex = 10;
            txtRecoveryScore.TextChanged += txtRecoveryScore_TextChanged;

            // Animal status
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(49, 438);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(153, 20);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status: Not calculated";

            // Housing unit
            lblHousingUnit.AutoSize = true;
            lblHousingUnit.Location = new Point(53, 486);
            lblHousingUnit.Name = "lblHousingUnit";
            lblHousingUnit.Size = new Size(199, 20);
            lblHousingUnit.TabIndex = 12;
            lblHousingUnit.Text = "Housing Unit: Not calculated";

            // Add or update button
            btnAddAnimal.Location = new Point(255, 572);
            btnAddAnimal.Name = "btnAddAnimal";
            btnAddAnimal.Size = new Size(114, 29);
            btnAddAnimal.TabIndex = 13;
            btnAddAnimal.Text = "Add Animal";
            btnAddAnimal.UseVisualStyleBackColor = true;
            btnAddAnimal.Click += btnAddAnimal_Click;

            // Cancel button
            btnCancel.Location = new Point(403, 572);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(104, 29);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;

            // Context menu
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);

            // Add Animal form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 630);

            Controls.Add(btnCancel);
            Controls.Add(btnAddAnimal);
            Controls.Add(lblHousingUnit);
            Controls.Add(lblStatus);
            Controls.Add(txtRecoveryScore);
            Controls.Add(lblRecoveryScore);
            Controls.Add(txtAge);
            Controls.Add(lblAge);
            Controls.Add(txtSpecies);
            Controls.Add(lblSpecies);
            Controls.Add(txtName);
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
        private TextBox txtName;
        private Label lblSpecies;
        private TextBox txtSpecies;
        private Label lblAge;
        private TextBox txtAge;
        private Label lblRecoveryScore;
        private TextBox txtRecoveryScore;
        private Label lblStatus;
        private Label lblHousingUnit;
        private Button btnAddAnimal;
        private Button btnCancel;
        private ContextMenuStrip contextMenuStrip1;
    }
}
