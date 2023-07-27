namespace Relationship.View
{
    partial class Classes
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel4 = new TableLayoutPanel();
            lblMessage = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            txtClasse = new SMS_ADMIN.ControlDesign.CustomTextBox();
            cmbSession = new SMS_ADMIN.ControlDesign.CustomComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAjouter = new SMS_ADMIN.ControlDesign.CustomButton();
            btnNettoyer = new SMS_ADMIN.ControlDesign.CustomButton();
            btnModifier = new SMS_ADMIN.ControlDesign.CustomButton();
            btnEffacer = new SMS_ADMIN.ControlDesign.CustomButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(lblMessage, 0, 0);
            tableLayoutPanel4.Location = new Point(403, 16);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(375, 32);
            tableLayoutPanel4.TabIndex = 16;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.Green;
            lblMessage.Location = new Point(358, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(14, 21);
            lblMessage.TabIndex = 0;
            lblMessage.Text = ".";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(txtClasse, 0, 0);
            tableLayoutPanel3.Controls.Add(cmbSession, 0, 1);
            tableLayoutPanel3.Location = new Point(132, 164);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(206, 88);
            tableLayoutPanel3.TabIndex = 15;
            // 
            // txtClasse
            // 
            txtClasse.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtClasse.BackColor = SystemColors.Window;
            txtClasse.BorderColor = Color.MediumSlateBlue;
            txtClasse.BorderFocusColor = Color.HotPink;
            txtClasse.BorderRadius = 0;
            txtClasse.BorderSize = 2;
            txtClasse.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtClasse.ForeColor = Color.FromArgb(0, 0, 64);
            txtClasse.Location = new Point(4, 4);
            txtClasse.Margin = new Padding(4);
            txtClasse.Multiline = false;
            txtClasse.Name = "txtClasse";
            txtClasse.Padding = new Padding(10, 7, 10, 7);
            txtClasse.PasswordChar = false;
            txtClasse.PlaceholderColor = Color.DarkGray;
            txtClasse.PlaceholderText = "";
            txtClasse.Size = new Size(198, 35);
            txtClasse.TabIndex = 1;
            txtClasse.Texts = "";
            txtClasse.UnderlinedStyle = false;
            // 
            // cmbSession
            // 
            cmbSession.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cmbSession.BackColor = Color.White;
            cmbSession.BorderColor = Color.MediumSlateBlue;
            cmbSession.BorderSize = 2;
            cmbSession.DropDownStyle = ComboBoxStyle.DropDown;
            cmbSession.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSession.ForeColor = Color.DimGray;
            cmbSession.IconColor = Color.MediumSlateBlue;
            cmbSession.ListBackColor = Color.White;
            cmbSession.ListTextColor = Color.DimGray;
            cmbSession.Location = new Point(3, 47);
            cmbSession.MinimumSize = new Size(200, 30);
            cmbSession.Name = "cmbSession";
            cmbSession.Padding = new Padding(2);
            cmbSession.Size = new Size(200, 36);
            cmbSession.TabIndex = 2;
            cmbSession.Texts = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(btnAjouter, 0, 0);
            tableLayoutPanel2.Controls.Add(btnNettoyer, 1, 0);
            tableLayoutPanel2.Controls.Add(btnModifier, 0, 1);
            tableLayoutPanel2.Controls.Add(btnEffacer, 1, 1);
            tableLayoutPanel2.Location = new Point(22, 258);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 41F));
            tableLayoutPanel2.Size = new Size(316, 81);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // btnAjouter
            // 
            btnAjouter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnAjouter.BackColor = Color.AliceBlue;
            btnAjouter.BackgroundColor = Color.AliceBlue;
            btnAjouter.BorderColor = Color.FromArgb(0, 64, 0);
            btnAjouter.BorderRadius = 5;
            btnAjouter.BorderSize = 2;
            btnAjouter.FlatAppearance.BorderSize = 0;
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAjouter.ForeColor = Color.FromArgb(0, 0, 64);
            btnAjouter.Location = new Point(3, 3);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(152, 34);
            btnAjouter.TabIndex = 3;
            btnAjouter.Text = "Save";
            btnAjouter.TextColor = Color.FromArgb(0, 0, 64);
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnNettoyer
            // 
            btnNettoyer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnNettoyer.BackColor = Color.Azure;
            btnNettoyer.BackgroundColor = Color.Azure;
            btnNettoyer.BorderColor = Color.Red;
            btnNettoyer.BorderRadius = 5;
            btnNettoyer.BorderSize = 2;
            btnNettoyer.FlatAppearance.BorderSize = 0;
            btnNettoyer.FlatStyle = FlatStyle.Flat;
            btnNettoyer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNettoyer.ForeColor = Color.FromArgb(0, 0, 64);
            btnNettoyer.Location = new Point(161, 3);
            btnNettoyer.Name = "btnNettoyer";
            btnNettoyer.Size = new Size(152, 34);
            btnNettoyer.TabIndex = 4;
            btnNettoyer.Text = "Reset";
            btnNettoyer.TextColor = Color.FromArgb(0, 0, 64);
            btnNettoyer.UseVisualStyleBackColor = false;
            btnNettoyer.Click += btnNettoyer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnModifier.BackColor = Color.AliceBlue;
            btnModifier.BackgroundColor = Color.AliceBlue;
            btnModifier.BorderColor = Color.FromArgb(0, 64, 0);
            btnModifier.BorderRadius = 5;
            btnModifier.BorderSize = 2;
            btnModifier.FlatAppearance.BorderSize = 0;
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifier.ForeColor = Color.FromArgb(0, 0, 64);
            btnModifier.Location = new Point(3, 44);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(152, 32);
            btnModifier.TabIndex = 5;
            btnModifier.Text = "Edit";
            btnModifier.TextColor = Color.FromArgb(0, 0, 64);
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnEffacer
            // 
            btnEffacer.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnEffacer.BackColor = Color.AliceBlue;
            btnEffacer.BackgroundColor = Color.AliceBlue;
            btnEffacer.BorderColor = Color.Red;
            btnEffacer.BorderRadius = 5;
            btnEffacer.BorderSize = 2;
            btnEffacer.FlatAppearance.BorderSize = 0;
            btnEffacer.FlatStyle = FlatStyle.Flat;
            btnEffacer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEffacer.ForeColor = Color.FromArgb(0, 0, 64);
            btnEffacer.Location = new Point(161, 44);
            btnEffacer.Name = "btnEffacer";
            btnEffacer.Size = new Size(152, 32);
            btnEffacer.TabIndex = 6;
            btnEffacer.Text = "Delete";
            btnEffacer.TextColor = Color.FromArgb(0, 0, 64);
            btnEffacer.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.8431377F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Location = new Point(22, 164);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.136364F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.863636F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(103, 88);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(3, 56);
            label2.Name = "label2";
            label2.Size = new Size(67, 21);
            label2.TabIndex = 1;
            label2.Text = "Session";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 64);
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 9;
            label4.Text = "Option";
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            dataGridView1.Location = new Point(367, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(414, 170);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Classes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "Classes";
            Text = "Classes";
            Load += Classes_Load;
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel4;
        private Label lblMessage;
        private TableLayoutPanel tableLayoutPanel3;
        private SMS_ADMIN.ControlDesign.CustomTextBox txtClasse;
        private SMS_ADMIN.ControlDesign.CustomComboBox cmbSession;
        private TableLayoutPanel tableLayoutPanel2;
        private SMS_ADMIN.ControlDesign.CustomButton btnAjouter;
        private SMS_ADMIN.ControlDesign.CustomButton btnNettoyer;
        private SMS_ADMIN.ControlDesign.CustomButton btnModifier;
        private SMS_ADMIN.ControlDesign.CustomButton btnEffacer;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Label label4;
        private DataGridView dataGridView1;
    }
}