namespace Relationship
{
    partial class Sessions
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            lblMessage = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDelete = new SMS_ADMIN.ControlDesign.CustomButton();
            customButton4 = new SMS_ADMIN.ControlDesign.CustomButton();
            btnModifier = new SMS_ADMIN.ControlDesign.CustomButton();
            btnNettoyer = new SMS_ADMIN.ControlDesign.CustomButton();
            txtDateFin = new SMS_ADMIN.ControlDesign.CustomDateTimePicker();
            txtDateDebut = new SMS_ADMIN.ControlDesign.CustomDateTimePicker();
            txtAnneeAcademique = new SMS_ADMIN.ControlDesign.CustomTextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnAjouter = new SMS_ADMIN.ControlDesign.CustomButton();
            cmbActive = new SMS_ADMIN.ControlDesign.CustomComboBox();
            btnGoTo = new SMS_ADMIN.ControlDesign.CustomButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = Color.LightCyan;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Thistle;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Green;
            dataGridView1.Location = new Point(427, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(325, 250);
            dataGridView1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(lblMessage, 0, 0);
            tableLayoutPanel2.Location = new Point(446, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(325, 27);
            tableLayoutPanel2.TabIndex = 21;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(308, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(14, 21);
            lblMessage.TabIndex = 0;
            lblMessage.Text = ".";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.1903646F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.2391663F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.57047F));
            tableLayoutPanel1.Controls.Add(btnDelete, 2, 5);
            tableLayoutPanel1.Controls.Add(customButton4, 0, 5);
            tableLayoutPanel1.Controls.Add(btnModifier, 0, 5);
            tableLayoutPanel1.Controls.Add(btnNettoyer, 2, 4);
            tableLayoutPanel1.Controls.Add(txtDateFin, 2, 2);
            tableLayoutPanel1.Controls.Add(txtDateDebut, 2, 1);
            tableLayoutPanel1.Controls.Add(txtAnneeAcademique, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 1, 2);
            tableLayoutPanel1.Controls.Add(label4, 1, 3);
            tableLayoutPanel1.Controls.Add(btnAjouter, 1, 4);
            tableLayoutPanel1.Controls.Add(cmbActive, 2, 3);
            tableLayoutPanel1.Location = new Point(29, 94);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.6572762F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.71831F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7793427F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3098583F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.5352116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.Size = new Size(380, 254);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Left;
            btnDelete.BackColor = Color.AliceBlue;
            btnDelete.BackgroundColor = Color.AliceBlue;
            btnDelete.BorderColor = Color.Red;
            btnDelete.BorderRadius = 5;
            btnDelete.BorderSize = 2;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(0, 0, 64);
            btnDelete.Location = new Point(175, 217);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(201, 32);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.TextColor = Color.FromArgb(0, 0, 64);
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            customButton4.Anchor = AnchorStyles.Left;
            customButton4.BackColor = Color.AliceBlue;
            customButton4.BackgroundColor = Color.AliceBlue;
            customButton4.BorderColor = Color.FromArgb(0, 64, 0);
            customButton4.BorderRadius = 5;
            customButton4.BorderSize = 2;
            customButton4.FlatAppearance.BorderSize = 0;
            customButton4.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 64, 0);
            customButton4.FlatStyle = FlatStyle.Flat;
            customButton4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customButton4.ForeColor = Color.FromArgb(0, 0, 64);
            customButton4.Location = new Point(3, 217);
            customButton4.Name = "customButton4";
            customButton4.Size = new Size(1, 32);
            customButton4.TabIndex = 20;
            customButton4.Text = "Add";
            customButton4.TextColor = Color.FromArgb(0, 0, 64);
            customButton4.UseVisualStyleBackColor = false;
            // 
            // btnModifier
            // 
            btnModifier.Anchor = AnchorStyles.Left;
            btnModifier.BackColor = Color.AliceBlue;
            btnModifier.BackgroundColor = Color.AliceBlue;
            btnModifier.BorderColor = Color.FromArgb(0, 64, 0);
            btnModifier.BorderRadius = 5;
            btnModifier.BorderSize = 2;
            btnModifier.FlatAppearance.BorderSize = 0;
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifier.ForeColor = Color.FromArgb(0, 0, 64);
            btnModifier.Location = new Point(7, 217);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(162, 32);
            btnModifier.TabIndex = 7;
            btnModifier.Text = "Edit";
            btnModifier.TextColor = Color.FromArgb(0, 0, 64);
            btnModifier.UseVisualStyleBackColor = false;
            // 
            // btnNettoyer
            // 
            btnNettoyer.Anchor = AnchorStyles.Left;
            btnNettoyer.BackColor = Color.Azure;
            btnNettoyer.BackgroundColor = Color.Azure;
            btnNettoyer.BorderColor = Color.Red;
            btnNettoyer.BorderRadius = 5;
            btnNettoyer.BorderSize = 2;
            btnNettoyer.FlatAppearance.BorderSize = 0;
            btnNettoyer.FlatStyle = FlatStyle.Flat;
            btnNettoyer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNettoyer.ForeColor = Color.FromArgb(0, 0, 64);
            btnNettoyer.Location = new Point(175, 172);
            btnNettoyer.Name = "btnNettoyer";
            btnNettoyer.Size = new Size(200, 34);
            btnNettoyer.TabIndex = 6;
            btnNettoyer.Text = "Reset";
            btnNettoyer.TextColor = Color.FromArgb(0, 0, 64);
            btnNettoyer.UseVisualStyleBackColor = false;
            // 
            // txtDateFin
            // 
            txtDateFin.BorderColor = Color.MediumSlateBlue;
            txtDateFin.BorderSize = 2;
            txtDateFin.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateFin.Location = new Point(175, 89);
            txtDateFin.MinimumSize = new Size(0, 35);
            txtDateFin.Name = "txtDateFin";
            txtDateFin.Size = new Size(200, 35);
            txtDateFin.SkinColor = Color.White;
            txtDateFin.TabIndex = 3;
            txtDateFin.TextColor = Color.FromArgb(0, 0, 64);
            // 
            // txtDateDebut
            // 
            txtDateDebut.BorderColor = Color.MediumSlateBlue;
            txtDateDebut.BorderSize = 2;
            txtDateDebut.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDateDebut.Location = new Point(175, 47);
            txtDateDebut.MinimumSize = new Size(0, 35);
            txtDateDebut.Name = "txtDateDebut";
            txtDateDebut.Size = new Size(200, 35);
            txtDateDebut.SkinColor = Color.White;
            txtDateDebut.TabIndex = 2;
            txtDateDebut.TextColor = Color.FromArgb(0, 0, 64);
            // 
            // txtAnneeAcademique
            // 
            txtAnneeAcademique.Anchor = AnchorStyles.Left;
            txtAnneeAcademique.BackColor = SystemColors.Window;
            txtAnneeAcademique.BorderColor = Color.MediumSlateBlue;
            txtAnneeAcademique.BorderFocusColor = Color.HotPink;
            txtAnneeAcademique.BorderRadius = 0;
            txtAnneeAcademique.BorderSize = 2;
            txtAnneeAcademique.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAnneeAcademique.ForeColor = Color.FromArgb(0, 0, 64);
            txtAnneeAcademique.Location = new Point(176, 4);
            txtAnneeAcademique.Margin = new Padding(4);
            txtAnneeAcademique.Multiline = false;
            txtAnneeAcademique.Name = "txtAnneeAcademique";
            txtAnneeAcademique.Padding = new Padding(10, 7, 10, 7);
            txtAnneeAcademique.PasswordChar = false;
            txtAnneeAcademique.PlaceholderColor = Color.DarkGray;
            txtAnneeAcademique.PlaceholderText = "";
            txtAnneeAcademique.Size = new Size(200, 35);
            txtAnneeAcademique.TabIndex = 1;
            txtAnneeAcademique.Texts = "";
            txtAnneeAcademique.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(7, 11);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Session";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(7, 54);
            label3.Name = "label3";
            label3.Size = new Size(86, 21);
            label3.TabIndex = 3;
            label3.Text = "Start Date";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 64);
            label5.Location = new Point(7, 95);
            label5.Name = "label5";
            label5.Size = new Size(79, 21);
            label5.TabIndex = 8;
            label5.Text = "End Date";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(7, 135);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 9;
            label4.Text = "Active";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAjouter
            // 
            btnAjouter.Anchor = AnchorStyles.Left;
            btnAjouter.BackColor = Color.AliceBlue;
            btnAjouter.BackgroundColor = Color.AliceBlue;
            btnAjouter.BorderColor = Color.FromArgb(0, 64, 0);
            btnAjouter.BorderRadius = 5;
            btnAjouter.BorderSize = 2;
            btnAjouter.FlatAppearance.BorderSize = 0;
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAjouter.ForeColor = Color.FromArgb(0, 0, 64);
            btnAjouter.Location = new Point(7, 172);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(162, 34);
            btnAjouter.TabIndex = 5;
            btnAjouter.Text = "Save";
            btnAjouter.TextColor = Color.FromArgb(0, 0, 64);
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // cmbActive
            // 
            cmbActive.BackColor = Color.White;
            cmbActive.BorderColor = Color.MediumSlateBlue;
            cmbActive.BorderSize = 2;
            cmbActive.DropDownStyle = ComboBoxStyle.DropDown;
            cmbActive.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbActive.ForeColor = Color.DimGray;
            cmbActive.IconColor = Color.MediumSlateBlue;
            cmbActive.ListBackColor = Color.White;
            cmbActive.ListTextColor = Color.DimGray;
            cmbActive.Location = new Point(175, 129);
            cmbActive.MinimumSize = new Size(200, 30);
            cmbActive.Name = "cmbActive";
            cmbActive.Padding = new Padding(2);
            cmbActive.Size = new Size(200, 33);
            cmbActive.TabIndex = 4;
            cmbActive.Texts = "";
            // 
            // btnGoTo
            // 
            btnGoTo.Anchor = AnchorStyles.Left;
            btnGoTo.BackColor = Color.LightSteelBlue;
            btnGoTo.BackgroundColor = Color.LightSteelBlue;
            btnGoTo.BorderColor = Color.FromArgb(0, 64, 0);
            btnGoTo.BorderRadius = 5;
            btnGoTo.BorderSize = 2;
            btnGoTo.FlatAppearance.BorderSize = 0;
            btnGoTo.FlatStyle = FlatStyle.Flat;
            btnGoTo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGoTo.ForeColor = Color.FromArgb(0, 0, 64);
            btnGoTo.Location = new Point(301, 374);
            btnGoTo.Name = "btnGoTo";
            btnGoTo.Size = new Size(162, 34);
            btnGoTo.TabIndex = 23;
            btnGoTo.Text = "Go To";
            btnGoTo.TextColor = Color.FromArgb(0, 0, 64);
            btnGoTo.UseVisualStyleBackColor = false;
            btnGoTo.Click += btnGoTo_Click;
            // 
            // Sessions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGoTo);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Sessions";
            Text = "Form1";
            Load += Sessions_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblMessage;
        private TableLayoutPanel tableLayoutPanel1;
        private SMS_ADMIN.ControlDesign.CustomButton btnDelete;
        private SMS_ADMIN.ControlDesign.CustomButton customButton4;
        private SMS_ADMIN.ControlDesign.CustomButton btnModifier;
        private SMS_ADMIN.ControlDesign.CustomButton btnNettoyer;
        private SMS_ADMIN.ControlDesign.CustomDateTimePicker txtDateFin;
        private SMS_ADMIN.ControlDesign.CustomDateTimePicker txtDateDebut;
        private SMS_ADMIN.ControlDesign.CustomTextBox txtAnneeAcademique;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private SMS_ADMIN.ControlDesign.CustomButton btnAjouter;
        private SMS_ADMIN.ControlDesign.CustomComboBox cmbActive;
        private SMS_ADMIN.ControlDesign.CustomButton btnGoTo;
    }
}