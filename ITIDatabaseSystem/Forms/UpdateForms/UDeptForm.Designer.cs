namespace ITIDatabaseSystem.Forms.UpdateForms
{
    partial class UDeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UDeptForm));
            mgrlbl = new Label();
            Mgrtxt = new TextBox();
            loclbl = new Label();
            namelbl = new Label();
            label = new Label();
            Locationtxt = new TextBox();
            label5 = new Label();
            labele = new Label();
            Nametxt = new TextBox();
            label1 = new Label();
            Backbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            Deptlist = new ComboBox();
            label8 = new Label();
            Updatelbl = new Label();
            Updatebtn = new Button();
            Crs = new Label();
            IDtxt = new TextBox();
            SuspendLayout();
            // 
            // mgrlbl
            // 
            mgrlbl.AutoSize = true;
            mgrlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            mgrlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mgrlbl.ForeColor = Color.Red;
            mgrlbl.Location = new Point(487, 244);
            mgrlbl.Name = "mgrlbl";
            mgrlbl.Size = new Size(275, 23);
            mgrlbl.TabIndex = 82;
            mgrlbl.Text = "Manager ID must be vaild and not empty.";
            // 
            // Mgrtxt
            // 
            Mgrtxt.Location = new Point(487, 207);
            Mgrtxt.Name = "Mgrtxt";
            Mgrtxt.Size = new Size(330, 30);
            Mgrtxt.TabIndex = 81;
            // 
            // loclbl
            // 
            loclbl.AutoSize = true;
            loclbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            loclbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loclbl.ForeColor = Color.Red;
            loclbl.Location = new Point(22, 486);
            loclbl.Name = "loclbl";
            loclbl.Size = new Size(338, 23);
            loclbl.TabIndex = 80;
            loclbl.Text = "Department Location must be vaild and not empty.";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            namelbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelbl.ForeColor = Color.Red;
            namelbl.Location = new Point(22, 349);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(321, 23);
            namelbl.TabIndex = 79;
            namelbl.Text = "Department name must be vaild and not empty.";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(0, 0, 0, 0);
            label.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.Window;
            label.Location = new Point(22, 409);
            label.Name = "label";
            label.Size = new Size(208, 31);
            label.TabIndex = 78;
            label.Text = "Department Location";
            // 
            // Locationtxt
            // 
            Locationtxt.Location = new Point(22, 443);
            Locationtxt.Name = "Locationtxt";
            Locationtxt.Size = new Size(330, 30);
            Locationtxt.TabIndex = 77;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(487, 173);
            label5.Name = "label5";
            label5.Size = new Size(118, 31);
            label5.TabIndex = 76;
            label5.Text = "Manager ID";
            // 
            // labele
            // 
            labele.AutoSize = true;
            labele.BackColor = Color.FromArgb(0, 0, 0, 0);
            labele.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labele.ForeColor = SystemColors.Window;
            labele.Location = new Point(22, 282);
            labele.Name = "labele";
            labele.Size = new Size(185, 31);
            labele.TabIndex = 75;
            labele.Text = "Department Name";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(22, 316);
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
            label1.Location = new Point(22, 70);
            label1.Name = "label1";
            label1.Size = new Size(275, 40);
            label1.TabIndex = 73;
            label1.Text = "Update A Department";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(801, 28);
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
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(22, 28);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 70;
            label2.Text = "ITI DataBase System";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(22, 119);
            label4.Name = "label4";
            label4.Size = new Size(436, 30);
            label4.TabIndex = 138;
            label4.Text = "Please update the required data in the table.";
            // 
            // Deptlist
            // 
            Deptlist.FormattingEnabled = true;
            Deptlist.Location = new Point(487, 333);
            Deptlist.Name = "Deptlist";
            Deptlist.Size = new Size(330, 34);
            Deptlist.TabIndex = 156;
            Deptlist.SelectedIndexChanged += Deptlist_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(0, 0, 0, 0);
            label8.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(487, 299);
            label8.Name = "label8";
            label8.Size = new Size(125, 31);
            label8.TabIndex = 155;
            label8.Text = "Department";
            // 
            // Updatelbl
            // 
            Updatelbl.AutoSize = true;
            Updatelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Updatelbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatelbl.ForeColor = Color.White;
            Updatelbl.Location = new Point(629, 542);
            Updatelbl.Name = "Updatelbl";
            Updatelbl.Size = new Size(250, 26);
            Updatelbl.TabIndex = 158;
            Updatelbl.Text = "1 Row Updated Successfully.";
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.FromArgb(174, 66, 107);
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatebtn.ForeColor = Color.FromArgb(239, 186, 214);
            Updatebtn.Location = new Point(722, 473);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(157, 49);
            Updatebtn.TabIndex = 157;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Crs
            // 
            Crs.AutoSize = true;
            Crs.BackColor = Color.FromArgb(0, 0, 0, 0);
            Crs.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Crs.ForeColor = SystemColors.Window;
            Crs.Location = new Point(22, 178);
            Crs.Name = "Crs";
            Crs.Size = new Size(147, 31);
            Crs.TabIndex = 160;
            Crs.Text = "Department ID";
            // 
            // IDtxt
            // 
            IDtxt.Enabled = false;
            IDtxt.Location = new Point(22, 212);
            IDtxt.Name = "IDtxt";
            IDtxt.Size = new Size(330, 30);
            IDtxt.TabIndex = 159;
            // 
            // UDeptForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Update_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(900, 585);
            Controls.Add(Crs);
            Controls.Add(IDtxt);
            Controls.Add(Updatelbl);
            Controls.Add(Updatebtn);
            Controls.Add(Deptlist);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(mgrlbl);
            Controls.Add(Mgrtxt);
            Controls.Add(loclbl);
            Controls.Add(namelbl);
            Controls.Add(label);
            Controls.Add(Locationtxt);
            Controls.Add(label5);
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
            Name = "UDeptForm";
            Text = "Departments Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label mgrlbl;
        private TextBox Mgrtxt;
        private Label loclbl;
        private Label namelbl;
        private Label label;
        private TextBox Locationtxt;
        private Label label5;
        private Label labele;
        private TextBox Nametxt;
        private Label label1;
        private Button Backbtn;
        private Label label3;
        private Label label2;
        private Label label4;
        private ComboBox Deptlist;
        private Label label8;
        private Label Updatelbl;
        private Button Updatebtn;
        private Label Crs;
        private TextBox IDtxt;
    }
}