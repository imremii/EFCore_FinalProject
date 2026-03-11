using ITIDatabaseSystem.Context;
using ITIDatabaseSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ITIDatabaseSystem.Repository;

namespace ITIDatabaseSystem.Forms.InsertForms
{
    public partial class CrsSesForm : Form
    {

        AppDBContext db = new AppDBContext();

        public CrsSesForm()
        {
            InitializeComponent();
            FillCrsList();
            FillInstList();
            namelbl.Hide();
            datebl.Hide();
            Insertlbl.Hide();
        }

        private void FillInstList()
        {
            Inslist.DataSource = db.Instructors
                .Select(i => new
                {
                    InstName = i.Ins_FName + " " + i.Ins_LName,
                    i.Ins_ID
                })
                .ToList();

            Inslist.DisplayMember = "InstName";
            Inslist.ValueMember = "Ins_ID";
        }

        private void FillCrsList()
        {
            Crslist.DataSource = db.Courses
                .Select(c => new
                {
                    CrsName = c.Crs_Name,
                    c.Crs_ID
                })
                .ToList();

            Crslist.DisplayMember = "CrsName";
            Crslist.ValueMember = "Crs_ID";
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
            datebl.Hide();
            Insertlbl.Hide();

            if (!Validations.CheckDate(Datetxt.Text) && !string.IsNullOrWhiteSpace(Datetxt.Text))
            {
                datebl.Show();
                return;
            }

            if (!Validations.CheckName(Nametxt.Text) && !string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                namelbl.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(Datetxt.Text))
            {
                Insertlbl.ForeColor = Color.Red;
                Insertlbl.Text = "Fields can't be empty.";
                Insertlbl.Show();
                return;
            }

            CourseSession newRecord = new()
            {
                CrsID = Convert.ToInt32(Crslist.SelectedValue),
                InsID = Convert.ToInt32(Inslist.SelectedValue),
                Title = Nametxt.Text,
                Date = Convert.ToDateTime(Datetxt.Text),
            };

            db.CourseSessions.Add(newRecord);
            db.SaveChanges();
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Text = "1 Row Added Successfully";
            Insertlbl.Show();
        }
    }
}
