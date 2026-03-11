namespace ITIDatabaseSystem.Forms
{
    partial class DeleteForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteForm));
            Backbtn = new Button();
            Deletebtn = new Button();
            Recordslist = new ComboBox();
            label4 = new Label();
            Tableslist = new ComboBox();
            label1 = new Label();
            Datagrid = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            Deletelbl = new Label();
            ((System.ComponentModel.ISupportInitialize)Datagrid).BeginInit();
            SuspendLayout();
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(791, 30);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 22;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.FromArgb(174, 66, 107);
            Deletebtn.FlatStyle = FlatStyle.Flat;
            Deletebtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletebtn.ForeColor = Color.FromArgb(239, 186, 214);
            Deletebtn.Location = new Point(249, 239);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(350, 41);
            Deletebtn.TabIndex = 21;
            Deletebtn.Text = "Delete Record";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Recordslist
            // 
            Recordslist.ForeColor = Color.FromArgb(174, 66, 107);
            Recordslist.FormattingEnabled = true;
            Recordslist.Location = new Point(461, 161);
            Recordslist.Name = "Recordslist";
            Recordslist.Size = new Size(317, 34);
            Recordslist.TabIndex = 19;
            Recordslist.Text = "Select the record";
            Recordslist.SelectedIndexChanged += Recordslist_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(461, 121);
            label4.Name = "label4";
            label4.Size = new Size(194, 26);
            label4.TabIndex = 18;
            label4.Text = "Please select the record.";
            // 
            // Tableslist
            // 
            Tableslist.ForeColor = Color.FromArgb(174, 66, 107);
            Tableslist.FormattingEnabled = true;
            Tableslist.Location = new Point(27, 161);
            Tableslist.Name = "Tableslist";
            Tableslist.Size = new Size(317, 34);
            Tableslist.TabIndex = 17;
            Tableslist.Text = "Select the table";
            Tableslist.SelectedIndexChanged += Tableslist_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(27, 121);
            label1.Name = "label1";
            label1.Size = new Size(182, 26);
            label1.TabIndex = 16;
            label1.Text = "Please select the table.";
            // 
            // Datagrid
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Datagrid.BackgroundColor = Color.FromArgb(73, 16, 114);
            Datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Datagrid.Dock = DockStyle.Bottom;
            Datagrid.Location = new Point(0, 331);
            Datagrid.Margin = new Padding(3, 4, 3, 4);
            Datagrid.Name = "Datagrid";
            Datagrid.RowHeadersWidth = 51;
            Datagrid.Size = new Size(904, 212);
            Datagrid.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 70);
            label3.Name = "label3";
            label3.Size = new Size(414, 30);
            label3.TabIndex = 14;
            label3.Text = "Please Choose the required data to delete.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(27, 30);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 13;
            label2.Text = "ITI DataBase System";
            // 
            // Deletelbl
            // 
            Deletelbl.AutoSize = true;
            Deletelbl.BackColor = Color.FromArgb(0, 0, 0, 0);
            Deletelbl.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Deletelbl.ForeColor = Color.FromArgb(239, 186, 214);
            Deletelbl.Location = new Point(296, 290);
            Deletelbl.Name = "Deletelbl";
            Deletelbl.Size = new Size(243, 26);
            Deletelbl.TabIndex = 23;
            Deletelbl.Text = "1 Row Deleted Successfully.";
            Deletelbl.Click += Deletelbl_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(904, 543);
            Controls.Add(Deletelbl);
            Controls.Add(Backbtn);
            Controls.Add(Deletebtn);
            Controls.Add(Recordslist);
            Controls.Add(label4);
            Controls.Add(Tableslist);
            Controls.Add(label1);
            Controls.Add(Datagrid);
            Controls.Add(label3);
            Controls.Add(label2);
            DoubleBuffered = true;
            Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "DeleteForm";
            Text = "DeleteForm";
            ((System.ComponentModel.ISupportInitialize)Datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Backbtn;
        private Button Deletebtn;
        private ComboBox Recordslist;
        private Label label4;
        private ComboBox Tableslist;
        private Label label1;
        private DataGridView Datagrid;
        private Label label3;
        private Label label2;
        private Label Deletelbl;
    }
}