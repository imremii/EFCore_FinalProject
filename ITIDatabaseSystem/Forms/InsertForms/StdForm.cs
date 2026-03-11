using ITIDatabaseSystem.Context;
using ITIDatabaseSystem.Models;
using ITIDatabaseSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITIDatabaseSystem.Forms.InsertForms
{
    public partial class StdForm : Form
    {
        AppDBContext db = new AppDBContext();
        public StdForm()
        {
            InitializeComponent();
            FNlbl.Hide();
            LNlbl.Hide();
            PNlbl.Hide();
            Insertlbl.Hide();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            var insrtForm = new InsertForm();
            insrtForm.Show();
            this.Close();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            FNlbl.Hide();
            LNlbl.Hide();
            PNlbl.Hide();
            Insertlbl.Hide();

            if (!Validations.CheckName(FNametxt.Text) && !string.IsNullOrWhiteSpace(FNametxt.Text))
            {
                FNlbl.Show();
                return;
            }


            if (!Validations.CheckName(LNametxt.Text) && !string.IsNullOrWhiteSpace(LNametxt.Text))
            {
                LNlbl.Show();
                return;
            }


            if (!Validations.CheckPhone(PNumbertxt.Text) && !string.IsNullOrWhiteSpace(PNumbertxt.Text))
            {
                PNlbl.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(FNametxt.Text) || string.IsNullOrWhiteSpace(LNametxt.Text))
            {
                Insertlbl.ForeColor = Color.Red;
                Insertlbl.Text = "Fields can't be empty.";
                Insertlbl.Show();
                return;
            }

            Student newRecord = new()
            {
                Std_FName = FNametxt.Text,
                Std_LName = LNametxt.Text,
                Std_Phone = PNumbertxt.Text
            };

            db.Students.Add(newRecord);
            db.SaveChanges();
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Text = "1 Row Added Successfully.";
            Insertlbl.Show();
        }
    }
}
