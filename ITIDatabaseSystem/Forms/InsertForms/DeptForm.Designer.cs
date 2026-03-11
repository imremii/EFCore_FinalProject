namespace ITIDatabaseSystem.Forms.InsertForms
{
    partial class DeptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeptForm));
            Insertlbl = new Label();
            Insertbtn = new Button();
            loclbl = new Label();
            namelbl = new Label();
            label = new Label();
            Locationtxt = new TextBox();
            label5 = new Label();
            labele = new Label();
            Nametxt = new TextBox();
            label1 = new Label();
            Backbtn = new Button();
            label2 = new Label();
            Mgrtxt = new TextBox();
            mgrlbl = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Insertlbl
            // 
            Insertlbl.AutoSize = true;
            Insertlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Insertlbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Location = new Point(669, 505);
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
            Insertbtn.Location = new Point(732, 441);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(157, 49);
            Insertbtn.TabIndex = 66;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = false;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // loclbl
            // 
            loclbl.AutoSize = true;
            loclbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            loclbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loclbl.ForeColor = Color.Red;
            loclbl.Location = new Point(22, 408);
            loclbl.Name = "loclbl";
            loclbl.Size = new Size(338, 23);
            loclbl.TabIndex = 65;
            loclbl.Text = "Department Location must be vaild and not empty.";
            // 
            // namelbl
            // 
            namelbl.AutoSize = true;
            namelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            namelbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelbl.ForeColor = Color.Red;
            namelbl.Location = new Point(22, 272);
            namelbl.Name = "namelbl";
            namelbl.Size = new Size(321, 23);
            namelbl.TabIndex = 64;
            namelbl.Text = "Department name must be vaild and not empty.";
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.FromArgb(0, 0, 0, 0);
            label.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.Window;
            label.Location = new Point(22, 331);
            label.Name = "label";
            label.Size = new Size(208, 31);
            label.TabIndex = 63;
            label.Text = "Department Location";
            // 
            // Locationtxt
            // 
            Locationtxt.Location = new Point(22, 365);
            Locationtxt.Name = "Locationtxt";
            Locationtxt.Size = new Size(330, 30);
            Locationtxt.TabIndex = 62;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(540, 201);
            label5.Name = "label5";
            label5.Size = new Size(118, 31);
            label5.TabIndex = 61;
            label5.Text = "Manager ID";
            // 
            // labele
            // 
            labele.AutoSize = true;
            labele.BackColor = Color.FromArgb(0, 0, 0, 0);
            labele.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labele.ForeColor = SystemColors.Window;
            labele.Location = new Point(22, 205);
            labele.Name = "labele";
            labele.Size = new Size(185, 31);
            labele.TabIndex = 60;
            labele.Text = "Department Name";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(22, 239);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(330, 30);
            Nametxt.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 186, 214);
            label1.Location = new Point(22, 72);
            label1.Name = "label1";
            label1.Size = new Size(256, 40);
            label1.TabIndex = 58;
            label1.Text = "Insert A Department";
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(811, 30);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 57;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(22, 30);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 55;
            label2.Text = "ITI DataBase System";
            // 
            // Mgrtxt
            // 
            Mgrtxt.Location = new Point(540, 235);
            Mgrtxt.Name = "Mgrtxt";
            Mgrtxt.Size = new Size(330, 30);
            Mgrtxt.TabIndex = 68;
            // 
            // mgrlbl
            // 
            mgrlbl.AutoSize = true;
            mgrlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            mgrlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mgrlbl.ForeColor = Color.Red;
            mgrlbl.Location = new Point(540, 272);
            mgrlbl.Name = "mgrlbl";
            mgrlbl.Size = new Size(275, 23);
            mgrlbl.TabIndex = 69;
            mgrlbl.Text = "Manager ID must be vaild and not empty.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 121);
            label3.Name = "label3";
            label3.Size = new Size(517, 30);
            label3.TabIndex = 56;
            label3.Text = "Please enter the required data to insert into the table.";
            // 
            // DeptForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Insert_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(932, 565);
            Controls.Add(mgrlbl);
            Controls.Add(Mgrtxt);
            Controls.Add(Insertlbl);
            Controls.Add(Insertbtn);
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
            Name = "DeptForm";
            Text = "Departments Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Instlist;
        private Label edff;
        private Label Insertlbl;
        private Button Insertbtn;
        private Label loclbl;
        private Label namelbl;
        private Label label;
        private TextBox Locationtxt;
        private Label label5;
        private Label labele;
        private TextBox Nametxt;
        private Label label1;
        private Button Backbtn;
        private Label label2;
        private TextBox Mgrtxt;
        private Label mgrlbl;
        private Label label3;
    }
}