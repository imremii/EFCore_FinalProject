namespace ITIDatabaseSystem.Forms.InsertForms
{
    partial class StdForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StdForm));
            Backbtn = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            FNametxt = new TextBox();
            label4 = new Label();
            label5 = new Label();
            PNumbertxt = new TextBox();
            label6 = new Label();
            LNametxt = new TextBox();
            FNlbl = new Label();
            LNlbl = new Label();
            PNlbl = new Label();
            Insertbtn = new Button();
            Insertlbl = new Label();
            SuspendLayout();
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(867, 24);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 24;
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
            label3.Location = new Point(30, 122);
            label3.Name = "label3";
            label3.Size = new Size(517, 30);
            label3.TabIndex = 23;
            label3.Text = "Please enter the required data to insert into the table.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(30, 31);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 22;
            label2.Text = "ITI DataBase System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Poppins", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 186, 214);
            label1.Location = new Point(30, 73);
            label1.Name = "label1";
            label1.Size = new Size(204, 40);
            label1.TabIndex = 25;
            label1.Text = "Insert A Student";
            // 
            // FNametxt
            // 
            FNametxt.Location = new Point(30, 206);
            FNametxt.Name = "FNametxt";
            FNametxt.Size = new Size(330, 30);
            FNametxt.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(30, 172);
            label4.Name = "label4";
            label4.Size = new Size(110, 31);
            label4.TabIndex = 27;
            label4.Text = "First Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Window;
            label5.Location = new Point(30, 370);
            label5.Name = "label5";
            label5.Size = new Size(150, 31);
            label5.TabIndex = 29;
            label5.Text = "Phone Number";
            // 
            // PNumbertxt
            // 
            PNumbertxt.Location = new Point(30, 404);
            PNumbertxt.Name = "PNumbertxt";
            PNumbertxt.Size = new Size(330, 30);
            PNumbertxt.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(0, 0, 0, 0);
            label6.Font = new Font("Poppins", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Window;
            label6.Location = new Point(30, 268);
            label6.Name = "label6";
            label6.Size = new Size(110, 31);
            label6.TabIndex = 31;
            label6.Text = "Last Name";
            // 
            // LNametxt
            // 
            LNametxt.Location = new Point(30, 302);
            LNametxt.Name = "LNametxt";
            LNametxt.Size = new Size(330, 30);
            LNametxt.TabIndex = 30;
            // 
            // FNlbl
            // 
            FNlbl.AutoSize = true;
            FNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            FNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FNlbl.ForeColor = Color.Red;
            FNlbl.Location = new Point(376, 206);
            FNlbl.Name = "FNlbl";
            FNlbl.Size = new Size(269, 23);
            FNlbl.TabIndex = 32;
            FNlbl.Text = "First name must be vaild and not empty.";
            // 
            // LNlbl
            // 
            LNlbl.AutoSize = true;
            LNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            LNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LNlbl.ForeColor = Color.Red;
            LNlbl.Location = new Point(376, 307);
            LNlbl.Name = "LNlbl";
            LNlbl.Size = new Size(269, 23);
            LNlbl.TabIndex = 33;
            LNlbl.Text = "Last name must be vaild and not empty.";
            // 
            // PNlbl
            // 
            PNlbl.AutoSize = true;
            PNlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            PNlbl.Font = new Font("Poppins", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PNlbl.ForeColor = Color.Red;
            PNlbl.Location = new Point(376, 411);
            PNlbl.Name = "PNlbl";
            PNlbl.Size = new Size(197, 23);
            PNlbl.TabIndex = 34;
            PNlbl.Text = "Phone number must be vaild.";
            // 
            // Insertbtn
            // 
            Insertbtn.BackColor = Color.FromArgb(174, 66, 107);
            Insertbtn.FlatStyle = FlatStyle.Flat;
            Insertbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Insertbtn.Location = new Point(788, 396);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(157, 49);
            Insertbtn.TabIndex = 35;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = false;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // Insertlbl
            // 
            Insertlbl.AutoSize = true;
            Insertlbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Insertlbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Location = new Point(718, 462);
            Insertlbl.Name = "Insertlbl";
            Insertlbl.Size = new Size(232, 26);
            Insertlbl.TabIndex = 36;
            Insertlbl.Text = "1 Row Added Successfully.";
            // 
            // StdForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Insert_Page;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(974, 503);
            Controls.Add(Insertlbl);
            Controls.Add(Insertbtn);
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
            Name = "StdForm";
            Text = "Student Table";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Backbtn;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox FNametxt;
        private Label label4;
        private Label label5;
        private TextBox PNumbertxt;
        private Label label6;
        private TextBox LNametxt;
        private Label FNlbl;
        private Label LNlbl;
        private Label PNlbl;
        private Button Insertbtn;
        private Label Insertlbl;
    }
}