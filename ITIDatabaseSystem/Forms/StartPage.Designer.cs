namespace ITIDatabaseSystem
{
    partial class StartPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Selectbtn = new Button();
            Insertbtn = new Button();
            Updatebtn = new Button();
            Deletebtn = new Button();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(239, 186, 214);
            label1.Location = new Point(23, 70);
            label1.Name = "label1";
            label1.Size = new Size(274, 78);
            label1.TabIndex = 0;
            label1.Text = "Welcome !";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(23, 137);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 1;
            label2.Text = "ITI DataBase System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Poppins", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 168);
            label3.Name = "label3";
            label3.Size = new Size(477, 30);
            label3.TabIndex = 2;
            label3.Text = "Please Select The Operation you would like to perform.";
            // 
            // Selectbtn
            // 
            Selectbtn.BackColor = Color.FromArgb(174, 66, 107);
            Selectbtn.FlatStyle = FlatStyle.Flat;
            Selectbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Selectbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Selectbtn.Location = new Point(35, 260);
            Selectbtn.Name = "Selectbtn";
            Selectbtn.Size = new Size(157, 49);
            Selectbtn.TabIndex = 3;
            Selectbtn.Text = "Select";
            Selectbtn.UseVisualStyleBackColor = false;
            Selectbtn.Click += Selectbtn_Click;
            // 
            // Insertbtn
            // 
            Insertbtn.BackColor = Color.FromArgb(174, 66, 107);
            Insertbtn.FlatStyle = FlatStyle.Flat;
            Insertbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Insertbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Insertbtn.Location = new Point(232, 260);
            Insertbtn.Name = "Insertbtn";
            Insertbtn.Size = new Size(157, 49);
            Insertbtn.TabIndex = 4;
            Insertbtn.Text = "Insert";
            Insertbtn.UseVisualStyleBackColor = false;
            Insertbtn.Click += Insertbtn_Click;
            // 
            // Updatebtn
            // 
            Updatebtn.BackColor = Color.FromArgb(174, 66, 107);
            Updatebtn.FlatStyle = FlatStyle.Flat;
            Updatebtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Updatebtn.ForeColor = Color.FromArgb(239, 186, 214);
            Updatebtn.Location = new Point(424, 260);
            Updatebtn.Name = "Updatebtn";
            Updatebtn.Size = new Size(157, 49);
            Updatebtn.TabIndex = 5;
            Updatebtn.Text = "Update";
            Updatebtn.UseVisualStyleBackColor = false;
            Updatebtn.Click += Updatebtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.FromArgb(174, 66, 107);
            Deletebtn.FlatStyle = FlatStyle.Flat;
            Deletebtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = Color.FromArgb(239, 186, 214);
            Deletebtn.Location = new Point(609, 260);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(157, 49);
            Deletebtn.TabIndex = 6;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(13, 407);
            label4.Name = "label4";
            label4.Size = new Size(337, 30);
            label4.TabIndex = 7;
            label4.Text = "Created By : Reem Mohamed Rashad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 0, 0, 0);
            label5.Font = new Font("Poppins", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(609, 407);
            label5.Name = "label5";
            label5.Size = new Size(179, 30);
            label5.TabIndex = 8;
            label5.Text = "ITI - EF Core Project";
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(73, 16, 114);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(806, 460);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Deletebtn);
            Controls.Add(Updatebtn);
            Controls.Add(Insertbtn);
            Controls.Add(Selectbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "StartPage";
            Text = "ITI DB System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button Selectbtn;
        private Button Insertbtn;
        private Button Updatebtn;
        private Button Deletebtn;
        private Label label4;
        private Label label5;
    }
}
