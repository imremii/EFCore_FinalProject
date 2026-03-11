namespace ITIDatabaseSystem.Forms.UpdateForms
{
    partial class UStdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UStdForm));
            Updatelbl = new Label();
            Updatebtn = new Button();
            PNlbl = new Label();
            LNlbl = new Label();
            FNlbl = new Label();
            label6 = new Label();
            LNametxt = new TextBox();
            label5 = new Label();
            PNumbertxt = new TextBox();
            label4 = new Label();
            FNametxt = new TextBox();
            label1 = new Label();
            Backbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            IDtxt = new TextBox();
            Stdlist = new ComboBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // Updatelbl
            // 
            Updatelbl.AutoSize = true;
            Updatelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Updatelbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatelbl.ForeColor = Color.White;
            Updatelbl.Location = new Point(677, 541);
            Updatelbl.Name = "Updatelbl";
            Updatelbl.Size = new Size(250, 26);
            Updatelbl.TabIndex = 51;
            Updatelbl.Text = "1 Row Updated Successfully.";
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.FromArgb(174, 66, 107);
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatebtn.ForeColor = Color.FromArgb(239, 186, 214);
            Updatebtn.Location = new Point(770, 474);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(157, 49);
            Updatebtn.TabIndex = 50;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // PNlbl
            // 
            PNlbl.AutoSize = true;
            PNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            PNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PNlbl.ForeColor = Color.Red;
            PNlbl.Location = new Point(367, 500);
            PNlbl.Name = "PNlbl";
            PNlbl.Size = new Size(197, 23);
            PNlbl.TabIndex = 49;
            PNlbl.Text = "Phone number must be vaild.";
            // 
            // LNlbl
            // 
            LNlbl.AutoSize = true;
            LNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            LNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNlbl.ForeColor = Color.Red;
            LNlbl.Location = new Point(367, 396);
            LNlbl.Name = "LNlbl";
            LNlbl.Size = new Size(269, 23);
            LNlbl.TabIndex = 48;
            LNlbl.Text = "Last name must be vaild and not empty.";
            // 
            // FNlbl
            // 
            FNlbl.AutoSize = true;
            FNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            FNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FNlbl.ForeColor = Color.Red;
            FNlbl.Location = new Point(367, 295);
            FNlbl.Name = "FNlbl";
            FNlbl.Size = new Size(269, 23);
            FNlbl.TabIndex = 47;
            FNlbl.Text = "First name must be vaild and not empty.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(21, 357);
            label6.Name = "label6";
            label6.Size = new Size(110, 31);
            label6.TabIndex = 46;
            label6.Text = "Last Name";
            // 
            // LNametxt
            // 
            LNametxt.Location = new Point(21, 391);
            LNametxt.Name = "LNametxt";
            LNametxt.Size = new Size(330, 30);
            LNametxt.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(21, 459);
            label5.Name = "label5";
            label5.Size = new Size(150, 31);
            label5.TabIndex = 44;
            label5.Text = "Phone Number";
            // 
            // PNumbertxt
            // 
            PNumbertxt.Location = new Point(21, 493);
            PNumbertxt.Name = "PNumbertxt";
            PNumbertxt.Size = new Size(330, 30);
            PNumbertxt.TabIndex = 43;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(21, 261);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 42;
            label4.Text = "First Name";
            // 
            // FNametxt
            // 
            FNametxt.Location = new Point(21, 295);
            FNametxt.Name = "FNametxt";
            FNametxt.Size = new Size(330, 30);
            FNametxt.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 186, 214);
            label1.Location = new Point(21, 76);
            label1.Name = "label1";
            label1.Size = new Size(223, 40);
            label1.TabIndex = 40;
            label1.Text = "Update A Student";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(849, 27);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 39;
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
            label3.Location = new Point(21, 125);
            label3.Name = "label3";
            label3.Size = new Size(436, 30);
            label3.TabIndex = 38;
            label3.Text = "Please update the required data in the table.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(21, 34);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 37;
            label2.Text = "ITI DataBase System";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(21, 175);
            label7.Name = "label7";
            label7.Size = new Size(108, 31);
            label7.TabIndex = 53;
            label7.Text = "Student ID";
            // 
            // IDtxt
            // 
            IDtxt.Enabled = false;
            IDtxt.Location = new Point(21, 209);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(330, 30);
            IDtxt.TabIndex = 52;
            // 
            // Stdlist
            // 
            Stdlist.FormattingEnabled = true;
            Stdlist.Location = new Point(589, 209);
            Stdlist.Name = "Stdlist";
            Stdlist.Size = new Size(338, 34);
            Stdlist.TabIndex = 106;
            Stdlist.SelectedIndexChanged += Stdlist_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 0, 0, 0);
            label8.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(589, 175);
            label8.Name = "label8";
            label8.Size = new Size(86, 31);
            label8.TabIndex = 105;
            label8.Text = "Student";
            // 
            // UStdForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Update_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(956, 585);
            Controls.Add(Stdlist);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(IDtxt);
            Controls.Add(Updatelbl);
            Controls.Add(Updatebtn);
            Controls.Add(PNlbl);
            Controls.Add(LNlbl);
            Controls.Add(FNlbl);
            Controls.Add(label6);
            Controls.Add(LNametxt);
            Controls.Add(label5);
            Controls.Add(PNumbertxt);
            Controls.Add(label4);
            Controls.Add(FNametxt);
            Controls.Add(label1);
            Controls.Add(Backbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "UStdForm";
            Text = "Student Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Updatelbl;
        private Button Updatebtn;
        private Label PNlbl;
        private Label LNlbl;
        private Label FNlbl;
        private Label label6;
        private TextBox LNametxt;
        private Label label5;
        private TextBox PNumbertxt;
        private Label label4;
        private TextBox FNametxt;
        private Label label1;
        private Button Backbtn;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox IDtxt;
        private ComboBox Stdlist;
        private Label label8;
    }
}