namespace ITIDatabaseSystem.Forms
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            Backbtn = new Button();
            Stdbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            Crsbtn = new Button();
            SessAtdbtn = new Button();
            CrsSesbtn = new Button();
            Deptbtn = new Button();
            Insbtn = new Button();
            SuspendLayout();
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(748, 21);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 21;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;

            // 
            // Stdbtn
            // 
            Stdbtn.BackColor = Color.FromArgb(174, 66, 107);
            Stdbtn.FlatStyle = FlatStyle.Flat;
            Stdbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stdbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Stdbtn.Location = new Point(29, 161);
            Stdbtn.Name = "Stdbtn";
            Stdbtn.Size = new Size(186, 52);
            Stdbtn.TabIndex = 19;
            Stdbtn.Text = "Students";
            Stdbtn.UseVisualStyleBackColor = false;
            Stdbtn.Click += Stdbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(25, 83);
            label3.Name = "label3";
            label3.Size = new Size(479, 30);
            label3.TabIndex = 14;
            label3.Text = "Please Choose the required table to update data.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(25, 43);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 13;
            label2.Text = "ITI DataBase System";
            // 
            // Crsbtn
            // 
            Crsbtn.BackColor = Color.FromArgb(174, 66, 107);
            Crsbtn.FlatStyle = FlatStyle.Flat;
            Crsbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Crsbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Crsbtn.Location = new Point(322, 161);
            Crsbtn.Name = "Crsbtn";
            Crsbtn.Size = new Size(186, 52);
            Crsbtn.TabIndex = 22;
            Crsbtn.Text = "Courses";
            Crsbtn.UseVisualStyleBackColor = false;
            Crsbtn.Click += Crsbtn_Click;
            // 
            // SessAtdbtn
            // 
            SessAtdbtn.BackColor = Color.FromArgb(174, 66, 107);
            SessAtdbtn.FlatStyle = FlatStyle.Flat;
            SessAtdbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SessAtdbtn.ForeColor = Color.FromArgb(239, 186, 214);
            SessAtdbtn.Location = new Point(599, 269);
            SessAtdbtn.Name = "SessAtdbtn";
            SessAtdbtn.Size = new Size(186, 52);
            SessAtdbtn.TabIndex = 23;
            SessAtdbtn.Text = "Session Attends";
            SessAtdbtn.UseVisualStyleBackColor = false;
            SessAtdbtn.Click += SessAtdbtn_Click;
            // 
            // CrsSesbtn
            // 
            CrsSesbtn.BackColor = Color.FromArgb(174, 66, 107);
            CrsSesbtn.FlatStyle = FlatStyle.Flat;
            CrsSesbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CrsSesbtn.ForeColor = Color.FromArgb(239, 186, 214);
            CrsSesbtn.Location = new Point(322, 269);
            CrsSesbtn.Name = "CrsSesbtn";
            CrsSesbtn.Size = new Size(186, 52);
            CrsSesbtn.TabIndex = 24;
            CrsSesbtn.Text = "Course Sessions";
            CrsSesbtn.UseVisualStyleBackColor = false;
            CrsSesbtn.Click += CrsSesbtn_Click;

            // 
            // Deptbtn
            // 
            Deptbtn.BackColor = Color.FromArgb(174, 66, 107);
            Deptbtn.FlatStyle = FlatStyle.Flat;
            Deptbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deptbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Deptbtn.Location = new Point(29, 269);
            Deptbtn.Name = "Deptbtn";
            Deptbtn.Size = new Size(186, 52);
            Deptbtn.TabIndex = 25;
            Deptbtn.Text = "Departments";
            Deptbtn.UseVisualStyleBackColor = false;
            Deptbtn.Click += Deptbtn_Click;
            // 
            // Insbtn
            // 
            Insbtn.BackColor = Color.FromArgb(174, 66, 107);
            Insbtn.FlatStyle = FlatStyle.Flat;
            Insbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Insbtn.Location = new Point(599, 161);
            Insbtn.Name = "Insbtn";
            Insbtn.Size = new Size(186, 52);
            Insbtn.TabIndex = 26;
            Insbtn.Text = "Instructors";
            Insbtn.UseVisualStyleBackColor = false;
            Insbtn.Click += Insbtn_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Update_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(850, 458);
            Controls.Add(Insbtn);
            Controls.Add(Deptbtn);
            Controls.Add(CrsSesbtn);
            Controls.Add(SessAtdbtn);
            Controls.Add(Crsbtn);
            Controls.Add(Backbtn);
            Controls.Add(Stdbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpdateForm";
            Text = "Update DB";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Backbtn;
        private Button Stdbtn;
        private Label label3;
        private Label label2;
        private Button Crsbtn;
        private Button SessAtdbtn;
        private Button CrsSesbtn;
        private Button Deptbtn;
        private Button Insbtn;
    }
}