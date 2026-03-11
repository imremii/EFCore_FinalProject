using ITIDatabaseSystem.Forms.UpdateForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITIDatabaseSystem.Forms
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
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
            var stdForm = new UStdForm();
            stdForm.Show();
            this.Hide();
        }

        private void Crsbtn_Click(object sender, EventArgs e)
        {
            var crsForm = new UCrsForm();
            crsForm.Show();
            this.Hide();
        }

        private void Insbtn_Click(object sender, EventArgs e)
        {
            var insForm = new UInsForm();
            insForm.Show();
            this.Hide();
        }

        private void Deptbtn_Click(object sender, EventArgs e)
        {
            var deptForm = new UDeptForm();
            deptForm.Show();
            this.Hide();
        }

        private void CrsSesbtn_Click(object sender, EventArgs e)
        {
            var crsSesForm = new UCrsSesForm();
            crsSesForm.Show();
            this.Hide();
        }

        private void SessAtdbtn_Click(object sender, EventArgs e)
        {
            var sesAtdForm = new USesAtdForm();
            sesAtdForm.Show();
            this.Hide();
        }

    }
}
