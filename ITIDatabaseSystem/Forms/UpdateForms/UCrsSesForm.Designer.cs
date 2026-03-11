namespace ITIDatabaseSystem.Forms.UpdateForms
{
    partial class UCrsSesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCrsSesForm));
            Inslist = new ComboBox();
            label4 = new Label();
            Crslist = new ComboBox();
            label5 = new Label();
            datebl = new Label();
            namelbl = new Label();
            label = new Label();
            Datetxt = new TextBox();
            labele = new Label();
            Nametxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Backbtn = new Button();
            label3 = new Label();
            Crs = new Label();
            IDtxt = new TextBox();
            CrsSesslist = new ComboBox();
            label6 = new Label();
            Updatelbl = new Label();
            Updatebtn = new Button();
            SuspendLayout();
            // 
            // Inslist
            // 
            Inslist.FormattingEnabled = true;
            Inslist.Location = new Point(26, 401);
            Inslist.Name = "Inslist";
            Inslist.Size = new Size(338, 34);
            Inslist.TabIndex = 98;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(26, 361);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 97;
            label4.Text = "Instructor";
            // 
            // Crslist
            // 
            Crslist.FormattingEnabled = true;
            Crslist.Location = new Point(26, 303);
            Crslist.Name = "Crslist";
            Crslist.Size = new Size(338, 34);
            Crslist.TabIndex = 96;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(26, 269);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 95;
            label5.Text = "Course";
            // 
            // datebl
            // 
            datebl.AutoSize = true;
            datebl.BackColor = Color.FromArgb(0, 0, 0, 0);
            datebl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datebl.ForeColor = Color.Red;
            datebl.Location = new Point(488, 254);
            datebl.Name = "datebl";
            datebl.Size = new Size(330, 23);
            datebl.TabIndex = 94;
            datebl.Text = "Date must be in the following format (mm/dd/yy).";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            namelbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelbl.ForeColor = Color.Red;
            namelbl.Location = new Point(26, 526);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(230, 23);
            namelbl.TabIndex = 93;
            namelbl.Text = "Titile must be vaild and not empty.";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(0, 0, 0, 0);
            label.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.Window;
            label.Location = new Point(488, 177);
            label.Name = "label";
            label.Size = new Size(57, 31);
            label.TabIndex = 92;
            label.Text = "Date";
            // 
            // Datetxt
            // 
            Datetxt.Location = new Point(488, 211);
            Datetxt.Name = "Datetxt";
            Datetxt.Size = new Size(330, 30);
            Datetxt.TabIndex = 91;
            // 
            // labele
            // 
            labele.AutoSize = true;
            labele.BackColor = Color.FromArgb(0, 0, 0, 0);
            labele.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labele.ForeColor = SystemColors.Window;
            labele.Location = new Point(26, 459);
            labele.Name = "labele";
            labele.Size = new Size(50, 31);
            labele.TabIndex = 90;
            labele.Text = "Title";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(26, 493);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(330, 30);
            Nametxt.TabIndex = 89;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 116);
            label1.Name = "label1";
            label1.Size = new Size(436, 30);
            label1.TabIndex = 142;
            label1.Text = "Please update the required data in the table.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(239, 186, 214);
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(312, 40);
            label2.TabIndex = 141;
            label2.Text = "Update A Course Session";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(805, 25);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 140;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(174, 66, 107);
            label3.Location = new Point(26, 25);
            label3.Name = "label3";
            label3.Size = new Size(200, 31);
            label3.TabIndex = 139;
            label3.Text = "ITI DataBase System";
            // 
            // Crs
            // 
            Crs.AutoSize = true;
            Crs.BackColor = Color.FromArgb(0, 0, 0, 0);
            Crs.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Crs.ForeColor = SystemColors.Window;
            Crs.Location = new Point(26, 177);
            Crs.Name = "Crs";
            Crs.Size = new Size(104, 31);
            Crs.TabIndex = 162;
            Crs.Text = "Session ID";
            // 
            // IDtxt
            // 
            IDtxt.Enabled = false;
            IDtxt.Location = new Point(26, 211);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(330, 30);
            IDtxt.TabIndex = 161;
            // 
            // CrsSesslist
            // 
            CrsSesslist.FormattingEnabled = true;
            CrsSesslist.Location = new Point(488, 340);
            CrsSesslist.Name = "CrsSesslist";
            CrsSesslist.Size = new Size(338, 34);
            CrsSesslist.TabIndex = 164;
            CrsSesslist.SelectedIndexChanged += CrsSesslist_SelectedIndexChanged;
            CrsSesslist.Click += CrsSesslist_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(488, 306);
            label6.Name = "label6";
            label6.Size = new Size(152, 31);
            label6.TabIndex = 163;
            label6.Text = "Course Session";
            // 
            // Updatelbl
            // 
            Updatelbl.AutoSize = true;
            Updatelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Updatelbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatelbl.ForeColor = Color.White;
            Updatelbl.Location = new Point(633, 528);
            Updatelbl.Name = "Updatelbl";
            Updatelbl.Size = new Size(250, 26);
            Updatelbl.TabIndex = 166;
            Updatelbl.Text = "1 Row Updated Successfully.";
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.FromArgb(174, 66, 107);
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatebtn.ForeColor = Color.FromArgb(239, 186, 214);
            Updatebtn.Location = new Point(726, 459);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(157, 49);
            Updatebtn.TabIndex = 165;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // UCrsSesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Update_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 585);
            Controls.Add(Updatelbl);
            Controls.Add(Updatebtn);
            Controls.Add(CrsSesslist);
            Controls.Add(label6);
            Controls.Add(Crs);
            Controls.Add(IDtxt);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(Backbtn);
            Controls.Add(label3);
            Controls.Add(Inslist);
            Controls.Add(label4);
            Controls.Add(Crslist);
            Controls.Add(label5);
            Controls.Add(datebl);
            Controls.Add(namelbl);
            Controls.Add(label);
            Controls.Add(Datetxt);
            Controls.Add(labele);
            Controls.Add(Nametxt);
            DoubleBuffered = true;
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCrsSesForm";
            Text = "Course Sessions Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Inslist;
        private Label label4;
        private ComboBox Crslist;
        private Label label5;
        private Label datebl;
        private Label namelbl;
        private Label label;
        private TextBox Datetxt;
        private Label labele;
        private TextBox Nametxt;
        private Label label1;
        private Label label2;
        private Button Backbtn;
        private Label label3;
        private Label Crs;
        private TextBox IDtxt;
        private ComboBox CrsSesslist;
        private Label label6;
        private Label Updatelbl;
        private Button Updatebtn;
    }
}