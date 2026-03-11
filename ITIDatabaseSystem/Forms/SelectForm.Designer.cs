namespace ITIDatabaseSystem.Forms
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            label3 = new Label();
            label2 = new Label();
            Datagrid = new DataGridView();
            label1 = new Label();
            Tableslist = new ComboBox();
            Recordslist = new ComboBox();
            label4 = new Label();
            SelectAllbtn = new Button();
            Selectbtn = new Button();
            Backbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Datagrid).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.Font = new Font("Poppins Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 69);
            label3.Name = "label3";
            label3.Size = new Size(411, 30);
            label3.TabIndex = 4;
            label3.Text = "Please Choose the required data to select.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Poppins SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(174, 66, 107);
            label2.Location = new Point(27, 29);
            label2.Name = "label2";
            label2.Size = new Size(200, 31);
            label2.TabIndex = 3;
            label2.Text = "ITI DataBase System";
            // 
            // Datagrid
            // 
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            Datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Datagrid.BackgroundColor = Color.FromArgb(73, 16, 114);
            Datagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Datagrid.Dock = DockStyle.Bottom;
            Datagrid.Location = new Point(0, 322);
            Datagrid.Margin = new Padding(3, 4, 3, 4);
            Datagrid.Name = "Datagrid";
            Datagrid.RowHeadersWidth = 51;
            Datagrid.Size = new Size(869, 195);
            Datagrid.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(27, 134);
            label1.Name = "label1";
            label1.Size = new Size(182, 26);
            label1.TabIndex = 6;
            label1.Text = "Please select the table.";
            // 
            // Tableslist
            // 
            Tableslist.ForeColor = Color.FromArgb(174, 66, 107);
            Tableslist.FormattingEnabled = true;
            Tableslist.Location = new Point(27, 174);
            Tableslist.Name = "Tableslist";
            Tableslist.Size = new Size(317, 34);
            Tableslist.TabIndex = 7;
            Tableslist.Text = "Select the table";
            Tableslist.SelectedIndexChanged += Tableslist_SelectedIndexChanged;
            // 
            // Recordslist
            // 
            Recordslist.ForeColor = Color.FromArgb(174, 66, 107);
            Recordslist.FormattingEnabled = true;
            Recordslist.Location = new Point(461, 174);
            Recordslist.Name = "Recordslist";
            Recordslist.Size = new Size(317, 34);
            Recordslist.TabIndex = 9;
            Recordslist.Text = "Select the record";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 0, 0, 0);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(461, 134);
            label4.Name = "label4";
            label4.Size = new Size(194, 26);
            label4.TabIndex = 8;
            label4.Text = "Please select the record.";
            // 
            // SelectAllbtn
            // 
            SelectAllbtn.BackColor = Color.FromArgb(174, 66, 107);
            SelectAllbtn.FlatStyle = FlatStyle.Flat;
            SelectAllbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SelectAllbtn.ForeColor = Color.FromArgb(239, 186, 214);
            SelectAllbtn.Location = new Point(157, 256);
            SelectAllbtn.Name = "SelectAllbtn";
            SelectAllbtn.Size = new Size(237, 41);
            SelectAllbtn.TabIndex = 10;
            SelectAllbtn.Text = "Select All";
            SelectAllbtn.UseVisualStyleBackColor = false;
            SelectAllbtn.Click += SelectAllbtn_Click;
            // 
            // Selectbtn
            // 
            Selectbtn.BackColor = Color.FromArgb(174, 66, 107);
            Selectbtn.FlatStyle = FlatStyle.Flat;
            Selectbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Selectbtn.ForeColor = Color.FromArgb(239, 186, 214);
            Selectbtn.Location = new Point(438, 256);
            Selectbtn.Name = "Selectbtn";
            Selectbtn.Size = new Size(237, 41);
            Selectbtn.TabIndex = 11;
            Selectbtn.Text = "Select Record";
            Selectbtn.UseVisualStyleBackColor = false;
            Selectbtn.Click += Selectbtn_Click;
            // 
            // Backbtn
            // 
            Backbtn.BackColor = Color.FromArgb(239, 186, 214);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.Font = new Font("Poppins SemiBold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Backbtn.ForeColor = Color.FromArgb(73, 16, 114);
            Backbtn.Location = new Point(764, 26);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(78, 38);
            Backbtn.TabIndex = 12;
            Backbtn.Text = "Back";
            Backbtn.UseVisualStyleBackColor = false;
            Backbtn.Click += Backbtn_Click;
            // 
            // SelectForm
            // 
            AutoScaleDimensions = new SizeF(9F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(869, 517);
            Controls.Add(Backbtn);
            Controls.Add(Selectbtn);
            Controls.Add(SelectAllbtn);
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
            Name = "SelectForm";
            Text = "Select From DB";
            ((System.ComponentModel.ISupportInitialize)Datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private DataGridView Datagrid;
        private Label label1;
        private ComboBox Tableslist;
        private ComboBox Recordslist;
        private Label label4;
        private Button SelectAllbtn;
        private Button Selectbtn;
        private Button Backbtn;
    }
}