namespace ITIDatabaseSystem.Forms.InsertForms
{
    partial class CrsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrsForm));
            Insertlbl = new Label();
            Insertbtn = new Button();
            durationlbl = new Label();
            namelbl = new Label();
            label = new Label();
            Durationtxt = new TextBox();
            label5 = new Label();
            labele = new Label();
            Nametxt = new TextBox();
            label1 = new Label();
            Backbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            Deptlist = new ComboBox();
            Instlist = new ComboBox();
            edff = new Label();
            SuspendLayout();
            // 
            // Insertlbl
            // 
            Insertlbl.AutoSize = true;
            Insertlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Insertlbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Location = new Point(684, 508);
            Insertlbl.Name = "Insertlbl";
            Insertlbl.Size = new Size(232, 26);
            Insertlbl.TabIndex = 51;
            Insertlbl.Text = "1 Row Added Successfully.";
            // 
            // Insertbtn
            // 
            Insertbtn.BackColor = Color.FromArgb(174, 66, 107);
            Insertbtn.FlatStyle = FlatStyle.Flat;
            Insertbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Insertbtn.Location = new Point(759, 439);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(157, 49);
            Insertbtn.TabIndex = 50;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = false;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // durationlbl
            // 
            durationlbl.AutoSize = true;
            durationlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            durationlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            durationlbl.ForeColor = Color.Red;
            durationlbl.Location = new Point(12, 372);
            durationlbl.Name = "durationlbl";
            durationlbl.Size = new Size(305, 23);
            durationlbl.TabIndex = 48;
            durationlbl.Text = "Course duration must be vaild and not empty.";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            namelbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelbl.ForeColor = Color.Red;
            namelbl.Location = new Point(12, 234);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(288, 23);
            namelbl.TabIndex = 47;
            namelbl.Text = "Course name must be vaild and not empty.";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(0, 0, 0, 0);
            label.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.Window;
            label.Location = new Point(12, 295);
            label.Name = "label";
            label.Size = new Size(163, 31);
            label.TabIndex = 46;
            label.Text = "Course Duration";
            // 
            // Durationtxt
            // 
            Durationtxt.Location = new Point(12, 329);
            Durationtxt.Name = "Durationtxt";
            Durationtxt.Size = new Size(330, 30);
            Durationtxt.TabIndex = 45;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(12, 420);
            label5.Name = "label5";
            label5.Size = new Size(125, 31);
            label5.TabIndex = 44;
            label5.Text = "Department";
            // 
            // labele
            // 
            labele.AutoSize = true;
            labele.BackColor = Color.FromArgb(0, 0, 0, 0);
            labele.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labele.ForeColor = SystemColors.Window;
            labele.Location = new Point(12, 167);
            labele.Name = "labele";
            labele.Size = new Size(139, 31);
            labele.TabIndex = 42;
            labele.Text = "Course Name";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(12, 201);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(330, 30);
            Nametxt.TabIndex = 41;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 186, 214);
            label1.Location = new Point(12, 68);
            label1.Name = "label1";
            label1.Size = new Size(197, 40);
            label1.TabIndex = 40;
            label1.Text = "Insert A Course";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(838, 26);
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
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(517, 30);
            label3.TabIndex = 38;
            label3.Text = "Please enter the required data to insert into the table.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(12, 26);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 37;
            label2.Text = "ITI DataBase System";
            // 
            // Deptlist
            // 
            Deptlist.FormattingEnabled = true;
            Deptlist.Location = new Point(12, 454);
            Deptlist.Name = "Deptlist";
            Deptlist.Size = new Size(330, 34);
            Deptlist.TabIndex = 52;
            // 
            // Instlist
            // 
            Instlist.FormattingEnabled = true;
            Instlist.Location = new Point(551, 197);
            Instlist.Name = "Instlist";
            Instlist.Size = new Size(330, 34);
            Instlist.TabIndex = 54;
            // 
            // edff
            // 
            edff.AutoSize = true;
            edff.BackColor = Color.FromArgb(0, 0, 0, 0);
            edff.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edff.ForeColor = SystemColors.Window;
            edff.Location = new Point(551, 163);
            edff.Name = "edff";
            edff.Size = new Size(102, 31);
            edff.TabIndex = 53;
            edff.Text = "Instructor";
            // 
            // CrsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Insert_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 585);
            Controls.Add(Instlist);
            Controls.Add(edff);
            Controls.Add(Deptlist);
            Controls.Add(Insertlbl);
            Controls.Add(Insertbtn);
            Controls.Add(durationlbl);
            Controls.Add(namelbl);
            Controls.Add(label);
            Controls.Add(Durationtxt);
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
            Name = "CrsForm";
            Text = "Course Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Insertlbl;
        private Button Insertbtn;
        private Label durationlbl;
        private Label namelbl;
        private Label label;
        private TextBox Durationtxt;
        private Label label5;
        private Label labele;
        private TextBox Nametxt;
        private Label label1;
        private Button Backbtn;
        private Label label3;
        private Label label2;
        private ComboBox Deptlist;
        private ComboBox Instlist;
        private Label edff;
    }
}