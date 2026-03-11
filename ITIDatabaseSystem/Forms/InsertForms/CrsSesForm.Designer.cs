namespace ITIDatabaseSystem.Forms.InsertForms
{
    partial class CrsSesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrsSesForm));
            Insertlbl = new Label();
            Insertbtn = new Button();
            datebl = new Label();
            namelbl = new Label();
            label = new Label();
            Datetxt = new TextBox();
            labele = new Label();
            Nametxt = new TextBox();
            label1 = new Label();
            Backbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            Crslist = new ComboBox();
            Inslist = new ComboBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // Insertlbl
            // 
            Insertlbl.AutoSize = true;
            Insertlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Insertlbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Location = new Point(672, 507);
            Insertlbl.Name = "Insertlbl";
            Insertlbl.Size = new Size(232, 26);
            Insertlbl.TabIndex = 82;
            Insertlbl.Text = "1 Row Added Successfully.";
            // 
            // Insertbtn
            // 
            Insertbtn.BackColor = Color.FromArgb(174, 66, 107);
            Insertbtn.FlatStyle = FlatStyle.Flat;
            Insertbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Insertbtn.Location = new Point(735, 443);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(157, 49);
            Insertbtn.TabIndex = 81;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = false;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // datebl
            // 
            datebl.AutoSize = true;
            datebl.BackColor = Color.FromArgb(0, 0, 0, 0);
            datebl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datebl.ForeColor = Color.Red;
            datebl.Location = new Point(522, 261);
            datebl.Name = "datebl";
            datebl.Size = new Size(330, 23);
            datebl.TabIndex = 80;
            datebl.Text = "Date must be in the following format (mm/dd/yy).";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            namelbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelbl.ForeColor = Color.Red;
            namelbl.Location = new Point(35, 484);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(230, 23);
            namelbl.TabIndex = 79;
            namelbl.Text = "Titile must be vaild and not empty.";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(0, 0, 0, 0);
            label.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.Window;
            label.Location = new Point(522, 184);
            label.Name = "label";
            label.Size = new Size(57, 31);
            label.TabIndex = 78;
            label.Text = "Date";
            // 
            // Datetxt
            // 
            Datetxt.Location = new Point(522, 218);
            Datetxt.Name = "Datetxt";
            Datetxt.Size = new Size(330, 30);
            Datetxt.TabIndex = 77;
            // 
            // labele
            // 
            labele.AutoSize = true;
            labele.BackColor = Color.FromArgb(0, 0, 0, 0);
            labele.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labele.ForeColor = SystemColors.Window;
            labele.Location = new Point(35, 417);
            labele.Name = "labele";
            labele.Size = new Size(50, 31);
            labele.TabIndex = 75;
            labele.Text = "Title";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(35, 451);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(330, 30);
            Nametxt.TabIndex = 74;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 186, 214);
            label1.Location = new Point(25, 74);
            label1.Name = "label1";
            label1.Size = new Size(208, 40);
            label1.TabIndex = 73;
            label1.Text = "Insert  A Session";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(814, 32);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 72;
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
            label3.Location = new Point(25, 123);
            label3.Name = "label3";
            label3.Size = new Size(517, 30);
            label3.TabIndex = 71;
            label3.Text = "Please enter the required data to insert into the table.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(25, 32);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 70;
            label2.Text = "ITI DataBase System";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(35, 184);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 84;
            label5.Text = "Course";
            // 
            // Crslist
            // 
            Crslist.FormattingEnabled = true;
            Crslist.Location = new Point(35, 218);
            Crslist.Name = "Crslist";
            Crslist.Size = new Size(338, 34);
            Crslist.TabIndex = 86;
            // 
            // Inslist
            // 
            Inslist.FormattingEnabled = true;
            Inslist.Location = new Point(35, 335);
            Inslist.Name = "Inslist";
            Inslist.Size = new Size(338, 34);
            Inslist.TabIndex = 88;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(35, 301);
            label4.Name = "label4";
            label4.Size = new Size(102, 31);
            label4.TabIndex = 87;
            label4.Text = "Instructor";
            // 
            // CrsSesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Insert_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(916, 585);
            Controls.Add(Inslist);
            Controls.Add(label4);
            Controls.Add(Crslist);
            Controls.Add(label5);
            Controls.Add(Insertlbl);
            Controls.Add(Insertbtn);
            Controls.Add(datebl);
            Controls.Add(namelbl);
            Controls.Add(label);
            Controls.Add(Datetxt);
            Controls.Add(labele);
            Controls.Add(Nametxt);
            Controls.Add(label1);
            Controls.Add(Backbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "CrsSesForm";
            Text = "Course Sessions Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Insertlbl;
        private Button Insertbtn;
        private Label datebl;
        private Label namelbl;
        private Label label;
        private TextBox Datetxt;
        private Label labele;
        private TextBox Nametxt;
        private Label label1;
        private Button Backbtn;
        private Label label3;
        private Label label2;
        private Label label5;
        private ComboBox Crslist;
        private ComboBox Inslist;
        private Label label4;
    }
}