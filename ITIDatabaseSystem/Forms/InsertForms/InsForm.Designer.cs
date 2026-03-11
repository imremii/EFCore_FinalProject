namespace ITIDatabaseSystem.Forms.InsertForms
{
    partial class InsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsForm));
            Deptlist = new ComboBox();
            Insertlbl = new Label();
            Insertbtn = new Button();
            label5 = new Label();
            label1 = new Label();
            Backbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            PNlbl = new Label();
            LNlbl = new Label();
            FNlbl = new Label();
            label6 = new Label();
            LNametxt = new TextBox();
            label4 = new Label();
            PNumbertxt = new TextBox();
            label7 = new Label();
            FNametxt = new TextBox();
            sallbl = new Label();
            label9 = new Label();
            Salarytxt = new TextBox();
            SuspendLayout();
            // 
            // Deptlist
            // 
            Deptlist.FormattingEnabled = true;
            Deptlist.Location = new Point(586, 332);
            Deptlist.Name = "Deptlist";
            Deptlist.Size = new Size(330, 34);
            Deptlist.TabIndex = 68;
            // 
            // Insertlbl
            // 
            Insertlbl.AutoSize = true;
            Insertlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Insertlbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Location = new Point(684, 523);
            Insertlbl.Name = "Insertlbl";
            Insertlbl.Size = new Size(232, 26);
            Insertlbl.TabIndex = 67;
            Insertlbl.Text = "1 Row Added Successfully.";
            // 
            // Insertbtn
            // 
            Insertbtn.BackColor = Color.FromArgb(174, 66, 107);
            Insertbtn.FlatStyle = FlatStyle.Flat;
            Insertbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Insertbtn.Location = new Point(759, 454);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(157, 49);
            Insertbtn.TabIndex = 66;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = false;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(586, 298);
            label5.Name = "label5";
            label5.Size = new Size(125, 31);
            label5.TabIndex = 61;
            label5.Text = "Department";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 186, 214);
            label1.Location = new Point(21, 64);
            label1.Name = "label1";
            label1.Size = new Size(244, 40);
            label1.TabIndex = 58;
            label1.Text = "Insert An Instructor";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(838, 22);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 57;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 113);
            label3.Name = "label3";
            label3.Size = new Size(517, 30);
            label3.TabIndex = 56;
            label3.Text = "Please enter the required data to insert into the table.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(21, 22);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 55;
            label2.Text = "ITI DataBase System";
            // 
            // PNlbl
            // 
            PNlbl.AutoSize = true;
            PNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            PNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PNlbl.ForeColor = Color.Red;
            PNlbl.Location = new Point(21, 501);
            PNlbl.Name = "PNlbl";
            PNlbl.Size = new Size(197, 23);
            PNlbl.TabIndex = 77;
            PNlbl.Text = "Phone number must be vaild.";
            // 
            // LNlbl
            // 
            LNlbl.AutoSize = true;
            LNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            LNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNlbl.ForeColor = Color.Red;
            LNlbl.Location = new Point(21, 369);
            LNlbl.Name = "LNlbl";
            LNlbl.Size = new Size(269, 23);
            LNlbl.TabIndex = 76;
            LNlbl.Text = "Last name must be vaild and not empty.";
            // 
            // FNlbl
            // 
            FNlbl.AutoSize = true;
            FNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            FNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FNlbl.ForeColor = Color.Red;
            FNlbl.Location = new Point(21, 249);
            FNlbl.Name = "FNlbl";
            FNlbl.Size = new Size(269, 23);
            FNlbl.TabIndex = 75;
            FNlbl.Text = "First name must be vaild and not empty.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(21, 298);
            label6.Name = "label6";
            label6.Size = new Size(110, 31);
            label6.TabIndex = 74;
            label6.Text = "Last Name";
            // 
            // LNametxt
            // 
            LNametxt.Location = new Point(21, 332);
            LNametxt.Name = "LNametxt";
            LNametxt.Size = new Size(330, 30);
            LNametxt.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(21, 428);
            label4.Name = "label4";
            label4.Size = new Size(150, 31);
            label4.TabIndex = 72;
            label4.Text = "Phone Number";
            // 
            // PNumbertxt
            // 
            PNumbertxt.Location = new Point(21, 462);
            PNumbertxt.Name = "PNumbertxt";
            PNumbertxt.Size = new Size(330, 30);
            PNumbertxt.TabIndex = 71;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(21, 179);
            label7.Name = "label7";
            label7.Size = new Size(110, 31);
            label7.TabIndex = 70;
            label7.Text = "First Name";
            // 
            // FNametxt
            // 
            FNametxt.Location = new Point(21, 213);
            FNametxt.Name = "FNametxt";
            FNametxt.Size = new Size(330, 30);
            FNametxt.TabIndex = 69;
            // 
            // sallbl
            // 
            sallbl.AutoSize = true;
            sallbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            sallbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sallbl.ForeColor = Color.Red;
            sallbl.Location = new Point(586, 252);
            sallbl.Name = "sallbl";
            sallbl.Size = new Size(144, 23);
            sallbl.TabIndex = 80;
            sallbl.Text = "Salary must be vaild.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 0, 0, 0);
            label9.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(586, 179);
            label9.Name = "label9";
            label9.Size = new Size(70, 31);
            label9.TabIndex = 79;
            label9.Text = "Salary";
            // 
            // Salarytxt
            // 
            Salarytxt.Location = new Point(586, 213);
            Salarytxt.Name = "Salarytxt";
            Salarytxt.Size = new Size(330, 30);
            Salarytxt.TabIndex = 78;
            // 
            // InsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Insert_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(954, 585);
            Controls.Add(sallbl);
            Controls.Add(label9);
            Controls.Add(Salarytxt);
            Controls.Add(PNlbl);
            Controls.Add(LNlbl);
            Controls.Add(FNlbl);
            Controls.Add(label6);
            Controls.Add(LNametxt);
            Controls.Add(label4);
            Controls.Add(PNumbertxt);
            Controls.Add(label7);
            Controls.Add(FNametxt);
            Controls.Add(Deptlist);
            Controls.Add(Insertlbl);
            Controls.Add(Insertbtn);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(Backbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "InsForm";
            Text = "Instructors Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox Deptlist;
        private Label Insertlbl;
        private Button Insertbtn;
        private Label label5;
        private Label label1;
        private Button Backbtn;
        private Label label3;
        private Label label2;
        private Label PNlbl;
        private Label LNlbl;
        private Label FNlbl;
        private Label label6;
        private TextBox LNametxt;
        private Label label4;
        private TextBox PNumbertxt;
        private Label label7;
        private TextBox FNametxt;
        private Label sallbl;
        private Label label9;
        private TextBox Salarytxt;
    }
}