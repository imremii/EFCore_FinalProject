using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ITIDatabaseSystem.Forms.InsertForms;

namespace ITIDatabaseSystem.Forms
{
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            var backbtn = new StartPage();
            backbtn.Show();
            this.Close();
        }

        private void Stdbtn_Click(object sender, EventArgs e)
        {
            var stdForm = new StdForm();
            stdForm.Show();
            this.Hide();
        }

        private void Crsbtn_Click(object sender, EventArgs e)
        {
            var crsForm = new CrsForm();
            crsForm.Show();
            this.Hide();
        }

        private void Insbtn_Click(object sender, EventArgs e)
        {
            var insForm = new InsForm();
            insForm.Show();
            this.Hide();
        }

        private void Deptbtn_Click(object sender, EventArgs e)
        {
            var deptForm = new DeptForm();
            deptForm.Show();
            this.Hide();
        }

        private void CrsSesbtn_Click(object sender, EventArgs e)
        {
            var crsSesForm = new CrsSesForm();
            crsSesForm.Show();
            this.Hide();
        }

        private void SessAtdbtn_Click(object sender, EventArgs e)
        {
            var sesAtdForm = new SesAtdForm();
            sesAtdForm.Show();
            this.Hide();
        }
    }
}
