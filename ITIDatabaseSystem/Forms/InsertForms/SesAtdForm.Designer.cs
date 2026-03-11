namespace ITIDatabaseSystem.Forms.InsertForms
{
    partial class SesAtdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SesAtdForm));
            Stdlist = new ComboBox();
            label4 = new Label();
            CrsSesslist = new ComboBox();
            label5 = new Label();
            Insertlbl = new Label();
            Insertbtn = new Button();
            gradelbl = new Label();
            label = new Label();
            Notetxt = new TextBox();
            labele = new Label();
            Gradetxt = new TextBox();
            label1 = new Label();
            Backbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Stdlist
            // 
            Stdlist.FormattingEnabled = true;
            Stdlist.Location = new Point(31, 346);
            Stdlist.Name = "Stdlist";
            Stdlist.Size = new Size(338, 34);
            Stdlist.TabIndex = 104;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(31, 312);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 103;
            label4.Text = "Student";
            // 
            // CrsSesslist
            // 
            CrsSesslist.FormattingEnabled = true;
            CrsSesslist.Location = new Point(31, 229);
            CrsSesslist.Name = "CrsSesslist";
            CrsSesslist.Size = new Size(338, 34);
            CrsSesslist.TabIndex = 102;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(31, 195);
            label5.Name = "label5";
            label5.Size = new Size(152, 31);
            label5.TabIndex = 101;
            label5.Text = "Course Session";
            // 
            // Insertlbl
            // 
            Insertlbl.AutoSize = true;
            Insertlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Insertlbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Location = new Point(646, 518);
            Insertlbl.Name = "Insertlbl";
            Insertlbl.Size = new Size(232, 26);
            Insertlbl.TabIndex = 100;
            Insertlbl.Text = "1 Row Added Successfully.";
            // 
            // Insertbtn
            // 
            Insertbtn.BackColor = Color.FromArgb(174, 66, 107);
            Insertbtn.FlatStyle = FlatStyle.Flat;
            Insertbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Insertbtn.Location = new Point(709, 454);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(157, 49);
            Insertbtn.TabIndex = 99;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = false;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // gradelbl
            // 
            gradelbl.AutoSize = true;
            gradelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            gradelbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gradelbl.ForeColor = Color.Red;
            gradelbl.Location = new Point(31, 487);
            gradelbl.Name = "gradelbl";
            gradelbl.Size = new Size(242, 23);
            gradelbl.TabIndex = 97;
            gradelbl.Text = "Grade must be vaild and not empty.";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(0, 0, 0, 0);
            label.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.Window;
            label.Location = new Point(518, 195);
            label.Name = "label";
            label.Size = new Size(66, 31);
            label.TabIndex = 96;
            label.Text = "Notes";
            // 
            // Notetxt
            // 
            Notetxt.Location = new Point(518, 229);
            Notetxt.Name = "Notetxt";
            Notetxt.Size = new Size(330, 30);
            Notetxt.TabIndex = 95;
            // 
            // labele
            // 
            labele.AutoSize = true;
            labele.BackColor = Color.FromArgb(0, 0, 0, 0);
            labele.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labele.ForeColor = SystemColors.Window;
            labele.Location = new Point(31, 420);
            labele.Name = "labele";
            labele.Size = new Size(70, 31);
            labele.TabIndex = 94;
            labele.Text = "Grade";
            // 
            // Gradetxt
            // 
            Gradetxt.Location = new Point(31, 454);
            Gradetxt.Name = "Gradetxt";
            Gradetxt.Size = new Size(330, 30);
            Gradetxt.TabIndex = 93;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 186, 214);
            label1.Location = new Point(21, 85);
            label1.Name = "label1";
            label1.Size = new Size(352, 40);
            label1.TabIndex = 92;
            label1.Text = "Insert  A Session Attendance";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(788, 43);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 91;
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
            label3.Location = new Point(21, 134);
            label3.Name = "label3";
            label3.Size = new Size(517, 30);
            label3.TabIndex = 90;
            label3.Text = "Please enter the required data to insert into the table.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(21, 43);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 89;
            label2.Text = "ITI DataBase System";
            // 
            // SesAtdForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Insert_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(908, 585);
            Controls.Add(Stdlist);
            Controls.Add(label4);
            Controls.Add(CrsSesslist);
            Controls.Add(label5);
            Controls.Add(Insertlbl);
            Controls.Add(Insertbtn);
            Controls.Add(gradelbl);
            Controls.Add(label);
            Controls.Add(Notetxt);
            Controls.Add(labele);
            Controls.Add(Gradetxt);
            Controls.Add(label1);
            Controls.Add(Backbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "SesAtdForm";
            Text = "Session Attendance Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Stdlist;
        private Label label4;
        private ComboBox CrsSesslist;
        private Label label5;
        private Label Insertlbl;
        private Button Insertbtn;
        private Label gradelbl;
        private Label label;
        private TextBox Notetxt;
        private Label labele;
        private TextBox Gradetxt;
        private Label label1;
        private Button Backbtn;
        private Label label3;
        private Label label2;
    }
}