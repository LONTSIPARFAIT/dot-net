namespace CRUD_DotNet
{
    partial class CrudStudent
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
            BtnNew = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.Blue;
            BtnNew.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnNew.ForeColor = Color.Yellow;
            BtnNew.Location = new Point(30, 126);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(148, 67);
            BtnNew.TabIndex = 0;
            BtnNew.Text = "New";
            BtnNew.UseVisualStyleBackColor = false;
            BtnNew.Click += BtnNew_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Location = new Point(2, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 89);
            panel1.TabIndex = 1;
            // 
            // CrudStudent
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(BtnNew);
            Name = "CrudStudent";
            Text = "crudStudent";
            Click += BtnNew_Click;
            ResumeLayout(false);
        }

        #endregion

        private Button BtnNew;
        private Panel panel1;
    }
}
