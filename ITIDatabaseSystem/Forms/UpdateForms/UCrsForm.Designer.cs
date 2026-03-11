namespace ITIDatabaseSystem.Forms.UpdateForms
{
    partial class UCrsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCrsForm));
            Crs = new Label();
            IDtxt = new TextBox();
            Updatelbl = new Label();
            Updatebtn = new Button();
            FNlbl = new Label();
            label4 = new Label();
            Nametxt = new TextBox();
            label1 = new Label();
            Backbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            Deptlist = new ComboBox();
            durationlbl = new Label();
            label = new Label();
            Durationtxt = new TextBox();
            label7 = new Label();
            Instlist = new ComboBox();
            edff = new Label();
            Crslist = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // Crs
            // 
            Crs.AutoSize = true;
            Crs.BackColor = Color.FromArgb(0, 0, 0, 0);
            Crs.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Crs.ForeColor = SystemColors.Window;
            Crs.Location = new Point(21, 166);
            Crs.Name = "Crs";
            Crs.Size = new Size(101, 31);
            Crs.TabIndex = 123;
            Crs.Text = "Course ID";
            // 
            // IDtxt
            // 
            IDtxt.Enabled = false;
            IDtxt.Location = new Point(21, 200);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(330, 30);
            IDtxt.TabIndex = 122;
            // 
            // Updatelbl
            // 
            Updatelbl.AutoSize = true;
            Updatelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Updatelbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatelbl.ForeColor = Color.White;
            Updatelbl.Location = new Point(677, 532);
            Updatelbl.Name = "Updatelbl";
            Updatelbl.Size = new Size(250, 26);
            Updatelbl.TabIndex = 121;
            Updatelbl.Text = "1 Row Updated Successfully.";
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.FromArgb(174, 66, 107);
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatebtn.ForeColor = Color.FromArgb(239, 186, 214);
            Updatebtn.Location = new Point(770, 465);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(157, 49);
            Updatebtn.TabIndex = 120;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            // 
            // FNlbl
            // 
            FNlbl.AutoSize = true;
            FNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            FNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FNlbl.ForeColor = Color.Red;
            FNlbl.Location = new Point(21, 319);
            FNlbl.Name = "FNlbl";
            FNlbl.Size = new Size(288, 23);
            FNlbl.TabIndex = 117;
            FNlbl.Text = "Course name must be vaild and not empty.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(21, 252);
            label4.Name = "label4";
            label4.Size = new Size(139, 31);
            label4.TabIndex = 112;
            label4.Text = "Course Name";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(21, 286);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(330, 30);
            Nametxt.TabIndex = 111;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 186, 214);
            label1.Location = new Point(21, 67);
            label1.Name = "label1";
            label1.Size = new Size(216, 40);
            label1.TabIndex = 110;
            label1.Text = "Update A Course";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(849, 18);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 109;
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
            label3.Location = new Point(21, 116);
            label3.Name = "label3";
            label3.Size = new Size(436, 30);
            label3.TabIndex = 108;
            label3.Text = "Please update the required data in the table.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(21, 25);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 107;
            label2.Text = "ITI DataBase System";
            // 
            // Deptlist
            // 
            Deptlist.FormattingEnabled = true;
            Deptlist.Location = new Point(21, 505);
            Deptlist.Name = "Deptlist";
            Deptlist.Size = new Size(330, 34);
            Deptlist.TabIndex = 130;
            // 
            // durationlbl
            // 
            durationlbl.AutoSize = true;
            durationlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            durationlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationlbl.ForeColor = Color.Red;
            durationlbl.Location = new Point(21, 428);
            durationlbl.Name = "durationlbl";
            durationlbl.Size = new Size(305, 23);
            durationlbl.TabIndex = 129;
            durationlbl.Text = "Course duration must be vaild and not empty.";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(0, 0, 0, 0);
            label.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.Window;
            label.Location = new Point(21, 357);
            label.Name = "label";
            label.Size = new Size(163, 31);
            label.TabIndex = 128;
            label.Text = "Course Duration";
            // 
            // Durationtxt
            // 
            Durationtxt.Location = new Point(21, 391);
            Durationtxt.Name = "Durationtxt";
            Durationtxt.Size = new Size(330, 30);
            Durationtxt.TabIndex = 127;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(0, 0, 0, 0);
            label7.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Window;
            label7.Location = new Point(21, 471);
            label7.Name = "label7";
            label7.Size = new Size(125, 31);
            label7.TabIndex = 126;
            label7.Text = "Department";
            // 
            // Instlist
            // 
            Instlist.FormattingEnabled = true;
            Instlist.Location = new Point(561, 196);
            Instlist.Name = "Instlist";
            Instlist.Size = new Size(330, 34);
            Instlist.TabIndex = 132;
            // 
            // edff
            // 
            edff.AutoSize = true;
            edff.BackColor = Color.FromArgb(0, 0, 0, 0);
            edff.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edff.ForeColor = SystemColors.Window;
            edff.Location = new Point(561, 162);
            edff.Name = "edff";
            edff.Size = new Size(102, 31);
            edff.TabIndex = 131;
            edff.Text = "Instructor";
            // 
            // Crslist
            // 
            Crslist.FormattingEnabled = true;
            Crslist.Location = new Point(561, 319);
            Crslist.Name = "Crslist";
            Crslist.Size = new Size(338, 34);
            Crslist.TabIndex = 134;
            Crslist.SelectedIndexChanged += Crslist_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(561, 285);
            label5.Name = "label5";
            label5.Size = new Size(79, 31);
            label5.TabIndex = 133;
            label5.Text = "Course";
            // 
            // UCrsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Update_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(972, 585);
            Controls.Add(Crslist);
            Controls.Add(label5);
            Controls.Add(Instlist);
            Controls.Add(edff);
            Controls.Add(Deptlist);
            Controls.Add(durationlbl);
            Controls.Add(label);
            Controls.Add(Durationtxt);
            Controls.Add(label7);
            Controls.Add(Crs);
            Controls.Add(IDtxt);
            Controls.Add(Updatelbl);
            Controls.Add(Updatebtn);
            Controls.Add(FNlbl);
            Controls.Add(label4);
            Controls.Add(Nametxt);
            Controls.Add(label1);
            Controls.Add(Backbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCrsForm";
            Text = "Course Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Crs;
        private TextBox IDtxt;
        private Label Updatelbl;
        private Button Updatebtn;
        private Label FNlbl;
        private Label label4;
        private TextBox Nametxt;
        private Label label1;
        private Button Backbtn;
        private Label label3;
        private Label label2;
        private ComboBox Deptlist;
        private Label durationlbl;
        private Label label;
        private TextBox Durationtxt;
        private Label label7;
        private ComboBox Instlist;
        private Label edff;
        private ComboBox Crslist;
        private Label label5;
    }
}