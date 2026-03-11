using ITIDatabaseSystem.Context;
using ITIDatabaseSystem.Models;
using ITIDatabaseSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITIDatabaseSystem.Forms.InsertForms
{
    public partial class DeptForm : Form
    {
        AppDBContext db = new AppDBContext();
        public DeptForm()
        {
            InitializeComponent();
            namelbl.Hide();
            loclbl.Hide();
            mgrlbl.Hide();
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
            namelbl.Hide();
            loclbl.Hide();
            mgrlbl.Hide();
            Insertlbl.Hide();

            if (!Validations.CheckName(Nametxt.Text) && !string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                namelbl.Show();
                return;
            }


            if (!Validations.CheckNumber(Mgrtxt.Text) && !string.IsNullOrWhiteSpace(Mgrtxt.Text))
            {
                mgrlbl.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(Nametxt.Text) || string.IsNullOrWhiteSpace(Mgrtxt.Text))
            {
                Insertlbl.ForeColor = Color.Red;
                Insertlbl.Text = "Fields can't be empty.";
                Insertlbl.Show();
                return;
            }

            Department newRecord = new()
            {
                Dept_Name = Nametxt.Text,
                Dept_Location = Locationtxt.Text,
                ManagerID = Convert.ToInt32(Mgrtxt.Text)
            };

            db.Departments.Add(newRecord);
            db.SaveChanges();
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Text = "1 Row Added Successfully";
            Insertlbl.Show();
        }
    }
}
