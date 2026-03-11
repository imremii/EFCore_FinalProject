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
    public partial class CrsForm : Form
    {

        AppDBContext db = new AppDBContext();
        public CrsForm()
        {
            InitializeComponent();
            FillDeptList();
            FillInstList();
            durationlbl.Hide();
            namelbl.Hide();
            Insertlbl.Hide();

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            var insrtForm = new InsertForm();
            insrtForm.Show();
            this.Close();
        }

        private void FillInstList()
        {
            Instlist.DataSource = db.Instructors
                .Select(i => new
                {
                    InstName = i.Ins_FName + " " + i.Ins_LName,
                    i.Ins_ID
                })
                .ToList();

            Instlist.DisplayMember = "InstName";
            Instlist.ValueMember = "Ins_ID";
        }

        private void FillDeptList()
        {
            Deptlist.DataSource = db.Departments
                .Select(d => new
                {
                    DeptName = d.Dept_Name,
                    d.Dept_ID
                })
                .ToList();

            Deptlist.DisplayMember = "DeptName";
            Deptlist.ValueMember = "Dept_ID";
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            durationlbl.Hide();
            namelbl.Hide();
            Insertlbl.Hide();

            if (!Validations.CheckCrsName(Nametxt.Text) && !string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                namelbl.Show();
                return;
            }


            if (!Validations.CheckNumber(Durationtxt.Text) && !string.IsNullOrWhiteSpace(Durationtxt.Text))
            {
                durationlbl.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                Insertlbl.ForeColor = Color.Red;
                Insertlbl.Text = "Fields can't be empty.";
                Insertlbl.Show();
                return;
            }

            Course newRecord = new()
            {
                Crs_Name = Nametxt.Text,
                Crs_Duration = Convert.ToInt32(Durationtxt.Text),
                DeptID = Convert.ToInt32(Deptlist.SelectedValue),
                InsID = Convert.ToInt32(Instlist.SelectedValue),
            };

            db.Courses.Add(newRecord);
            db.SaveChanges();
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Text = "1 Row Added Successfully";
            Insertlbl.Show();
        }

        private void edff_Click(object sender, EventArgs e)
        {

        }
    }
}
