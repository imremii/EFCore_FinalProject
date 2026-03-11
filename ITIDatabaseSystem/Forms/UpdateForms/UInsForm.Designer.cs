namespace ITIDatabaseSystem.Forms.UpdateForms
{
    partial class UInsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UInsForm));
            Instlist = new ComboBox();
            edff = new Label();
            Updatelbl = new Label();
            Updatebtn = new Button();
            label1 = new Label();
            Backbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            sallbl = new Label();
            label9 = new Label();
            Salarytxt = new TextBox();
            PNlbl = new Label();
            LNlbl = new Label();
            FNlbl = new Label();
            label6 = new Label();
            LNametxt = new TextBox();
            label4 = new Label();
            PNumbertxt = new TextBox();
            label5 = new Label();
            FNametxt = new TextBox();
            Deptlist = new ComboBox();
            label8 = new Label();
            Crs = new Label();
            IDtxt = new TextBox();
            SuspendLayout();
            // 
            // Instlist
            // 
            Instlist.FormattingEnabled = true;
            Instlist.Location = new Point(529, 410);
            Instlist.Name = "Instlist";
            Instlist.Size = new Size(330, 34);
            Instlist.TabIndex = 152;
            Instlist.SelectedIndexChanged += Instlist_SelectedIndexChanged;
            // 
            // edff
            // 
            edff.AutoSize = true;
            edff.BackColor = Color.FromArgb(0, 0, 0, 0);
            edff.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edff.ForeColor = SystemColors.Window;
            edff.Location = new Point(529, 376);
            edff.Name = "edff";
            edff.Size = new Size(102, 31);
            edff.TabIndex = 151;
            edff.Text = "Instructor";
            // 
            // Updatelbl
            // 
            Updatelbl.AutoSize = true;
            Updatelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Updatelbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatelbl.ForeColor = Color.White;
            Updatelbl.Location = new Point(668, 582);
            Updatelbl.Name = "Updatelbl";
            Updatelbl.Size = new Size(250, 26);
            Updatelbl.TabIndex = 143;
            Updatelbl.Text = "1 Row Updated Successfully.";
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.FromArgb(174, 66, 107);
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatebtn.ForeColor = Color.FromArgb(239, 186, 214);
            Updatebtn.Location = new Point(761, 513);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(157, 49);
            Updatebtn.TabIndex = 142;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 186, 214);
            label1.Location = new Point(12, 65);
            label1.Name = "label1";
            label1.Size = new Size(263, 40);
            label1.TabIndex = 138;
            label1.Text = "Update An Instructor";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(840, 23);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 137;
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
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(436, 30);
            label3.TabIndex = 136;
            label3.Text = "Please update the required data in the table.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 135;
            label2.Text = "ITI DataBase System";
            // 
            // sallbl
            // 
            sallbl.AutoSize = true;
            sallbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            sallbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sallbl.ForeColor = Color.Red;
            sallbl.Location = new Point(529, 232);
            sallbl.Name = "sallbl";
            sallbl.Size = new Size(144, 23);
            sallbl.TabIndex = 166;
            sallbl.Text = "Salary must be vaild.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(0, 0, 0, 0);
            label9.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.Window;
            label9.Location = new Point(529, 159);
            label9.Name = "label9";
            label9.Size = new Size(70, 31);
            label9.TabIndex = 165;
            label9.Text = "Salary";
            // 
            // Salarytxt
            // 
            Salarytxt.Location = new Point(529, 193);
            Salarytxt.Name = "Salarytxt";
            Salarytxt.Size = new Size(330, 30);
            Salarytxt.TabIndex = 164;
            // 
            // PNlbl
            // 
            PNlbl.AutoSize = true;
            PNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            PNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PNlbl.ForeColor = Color.Red;
            PNlbl.Location = new Point(22, 539);
            PNlbl.Name = "PNlbl";
            PNlbl.Size = new Size(197, 23);
            PNlbl.TabIndex = 163;
            PNlbl.Text = "Phone number must be vaild.";
            // 
            // LNlbl
            // 
            LNlbl.AutoSize = true;
            LNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            LNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNlbl.ForeColor = Color.Red;
            LNlbl.Location = new Point(22, 425);
            LNlbl.Name = "LNlbl";
            LNlbl.Size = new Size(269, 23);
            LNlbl.TabIndex = 162;
            LNlbl.Text = "Last name must be vaild and not empty.";
            // 
            // FNlbl
            // 
            FNlbl.AutoSize = true;
            FNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            FNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FNlbl.ForeColor = Color.Red;
            FNlbl.Location = new Point(22, 319);
            FNlbl.Name = "FNlbl";
            FNlbl.Size = new Size(269, 23);
            FNlbl.TabIndex = 161;
            FNlbl.Text = "First name must be vaild and not empty.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(22, 354);
            label6.Name = "label6";
            label6.Size = new Size(110, 31);
            label6.TabIndex = 160;
            label6.Text = "Last Name";
            // 
            // LNametxt
            // 
            LNametxt.Location = new Point(22, 388);
            LNametxt.Name = "LNametxt";
            LNametxt.Size = new Size(330, 30);
            LNametxt.TabIndex = 159;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(22, 466);
            label4.Name = "label4";
            label4.Size = new Size(150, 31);
            label4.TabIndex = 158;
            label4.Text = "Phone Number";
            // 
            // PNumbertxt
            // 
            PNumbertxt.Location = new Point(22, 500);
            PNumbertxt.Name = "PNumbertxt";
            PNumbertxt.Size = new Size(330, 30);
            PNumbertxt.TabIndex = 157;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(22, 249);
            label5.Name = "label5";
            label5.Size = new Size(110, 31);
            label5.TabIndex = 156;
            label5.Text = "First Name";
            // 
            // FNametxt
            // 
            FNametxt.Location = new Point(22, 283);
            FNametxt.Name = "FNametxt";
            FNametxt.Size = new Size(330, 30);
            FNametxt.TabIndex = 155;
            // 
            // Deptlist
            // 
            Deptlist.FormattingEnabled = true;
            Deptlist.Location = new Point(529, 304);
            Deptlist.Name = "Deptlist";
            Deptlist.Size = new Size(330, 34);
            Deptlist.TabIndex = 154;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 0, 0, 0);
            label8.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(529, 270);
            label8.Name = "label8";
            label8.Size = new Size(125, 31);
            label8.TabIndex = 153;
            label8.Text = "Department";
            // 
            // Crs
            // 
            Crs.AutoSize = true;
            Crs.BackColor = Color.FromArgb(0, 0, 0, 0);
            Crs.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Crs.ForeColor = SystemColors.Window;
            Crs.Location = new Point(22, 159);
            Crs.Name = "Crs";
            Crs.RightToLeft = RightToLeft.Yes;
            Crs.Size = new Size(124, 31);
            Crs.TabIndex = 168;
            Crs.Text = "Instructor ID";
            // 
            // IDtxt
            // 
            IDtxt.Enabled = false;
            IDtxt.Location = new Point(22, 193);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(330, 30);
            IDtxt.TabIndex = 167;
            // 
            // UInsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Update_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(942, 626);
            Controls.Add(Crs);
            Controls.Add(IDtxt);
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
            Controls.Add(label5);
            Controls.Add(FNametxt);
            Controls.Add(Deptlist);
            Controls.Add(label8);
            Controls.Add(Instlist);
            Controls.Add(edff);
            Controls.Add(Updatelbl);
            Controls.Add(Updatebtn);
            Controls.Add(label1);
            Controls.Add(Backbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "UInsForm";
            Text = "Instructors Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Instlist;
        private Label edff;
        private Label Updatelbl;
        private Button Updatebtn;
        private Label label1;
        private Button Backbtn;
        private Label label3;
        private Label label2;
        private Label sallbl;
        private Label label9;
        private TextBox Salarytxt;
        private Label PNlbl;
        private Label LNlbl;
        private Label FNlbl;
        private Label label6;
        private TextBox LNametxt;
        private Label label4;
        private TextBox PNumbertxt;
        private Label label5;
        private TextBox FNametxt;
        private ComboBox Deptlist;
        private Label label8;
        private Label Crs;
        private TextBox IDtxt;
    }
}