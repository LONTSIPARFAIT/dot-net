namespace CRUD_DotNet
{
    partial class FormStudent
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
            panel1 = new Panel();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            txtSection = new TextBox();
            label4 = new Label();
            txtClass = new TextBox();
            label3 = new Label();
            txtRegister = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Blue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 101);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(270, 21);
            label1.Name = "label1";
            label1.Size = new Size(214, 54);
            label1.TabIndex = 0;
            label1.Text = "Inscription";
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.ButtonHighlight;
            txtName.Location = new Point(238, 67);
            txtName.Name = "txtName";
            txtName.Size = new Size(264, 31);
            txtName.TabIndex = 2;
            txtName.TextChanged += this.txtName_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 27);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 3;
            label2.Text = "Name";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(255, 224, 192);
            panel2.Controls.Add(btnSave);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtSection);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtClass);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtRegister);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtName);
            panel2.Location = new Point(2, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(778, 430);
            panel2.TabIndex = 4;
            panel2.Paint += this.panel2_Paint;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkOliveGreen;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(224, 358);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(352, 43);
            btnSave.TabIndex = 4;
            btnSave.Text = "Enregistrez";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += this.btnSave_click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(238, 272);
            label5.Name = "label5";
            label5.Size = new Size(87, 30);
            label5.TabIndex = 3;
            label5.Text = "Section";
            // 
            // txtSection
            // 
            txtSection.BackColor = SystemColors.ButtonHighlight;
            txtSection.Location = new Point(238, 312);
            txtSection.Name = "txtSection";
            txtSection.Size = new Size(264, 31);
            txtSection.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(238, 198);
            label4.Name = "label4";
            label4.Size = new Size(62, 30);
            label4.TabIndex = 3;
            label4.Text = "Class";
            // 
            // txtClass
            // 
            txtClass.BackColor = SystemColors.ButtonHighlight;
            txtClass.Location = new Point(238, 238);
            txtClass.Name = "txtClass";
            txtClass.Size = new Size(264, 31);
            txtClass.TabIndex = 2;
            txtClass.TextChanged += this.txtClass_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(238, 111);
            label3.Name = "label3";
            label3.Size = new Size(94, 30);
            label3.TabIndex = 3;
            label3.Text = "Register";
            // 
            // txtRegister
            // 
            txtRegister.BackColor = SystemColors.ButtonHighlight;
            txtRegister.Location = new Point(238, 151);
            txtRegister.Name = "txtRegister";
            txtRegister.Size = new Size(264, 31);
            txtRegister.TabIndex = 2;
            // 
            // FormStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(792, 563);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormStudent";
            Text = "FormStudent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Panel panel2;
        private Label label4;
        private TextBox txtClass;
        private Label label3;
        private TextBox txtRegister;
        private Label label5;
        private TextBox txtSection;
        private Button btnSave;
        private Button btnSave;
        private Button BtnSave;
    }
}