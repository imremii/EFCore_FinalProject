using ITIDatabaseSystem.Context;
using ITIDatabaseSystem.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITIDatabaseSystem.Forms.UpdateForms
{
    public partial class UCrsForm : Form
    {
        AppDBContext db = new AppDBContext();
        public UCrsForm()
        {
            InitializeComponent();
            FillDeptList();
            FillInstList();
            FillCrsList();
            FNlbl.Hide();
            durationlbl.Hide();
            Updatelbl.Hide();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            var updForm = new UpdateForm();
            updForm.Show();
            this.Hide();
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

        private void Crslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            FNlbl.Hide();
            durationlbl.Hide();
            Updatelbl.Hide();

            IDtxt.Text = db.Courses
            .Where(ent => ent.Crs_ID == Convert.ToInt32(Crslist.SelectedValue))
            .Select(ent => ent.Crs_ID)
            .FirstOrDefault()
            .ToString();

            Nametxt.Text = db.Courses
           .Where(ent => ent.Crs_ID == Convert.ToInt32(Crslist.SelectedValue))
           .Select(ent => ent.Crs_Name)
           .FirstOrDefault()
           .ToString();

            Durationtxt.Text = db.Courses
            .Where(ent => ent.Crs_ID == Convert.ToInt32(Crslist.SelectedValue))
            .Select(ent => ent.Crs_Duration)
            .FirstOrDefault()
            .ToString();

            Deptlist.SelectedValue = db.Courses
            .Where(ent => ent.Crs_ID == Convert.ToInt32(Crslist.SelectedValue))
            .Select(ent => ent.DeptID)
            .FirstOrDefault();

            Instlist.SelectedValue = db.Courses
            .Where(ent => ent.Crs_ID == Convert.ToInt32(Crslist.SelectedValue))
            .Select(ent => ent.InsID)
            .FirstOrDefault();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            FNlbl.Hide();
            durationlbl.Hide();
            Updatelbl.Hide();

            var toUpdate = db.Courses.FirstOrDefault(ent => ent.Crs_ID == Convert.ToInt32(Crslist.SelectedValue));

            bool op1 = toUpdate.Crs_Name == Nametxt.Text;
            bool op2 = toUpdate.Crs_Duration.ToString() == Durationtxt.Text;
            bool op3 = toUpdate.DeptID.ToString() == Deptlist.SelectedValue?.ToString();
            bool op4 = toUpdate.InsID.ToString() == Instlist.SelectedValue?.ToString();

            if (!Validations.CheckCrsName(Nametxt.Text))
            {
                FNlbl.Show();
                return;
            }


            if (!Validations.CheckNumber(Durationtxt.Text))
            {
                durationlbl.Show();
                return;
            }


            if (string.IsNullOrWhiteSpace(Nametxt.Text))
            {
                Updatelbl.ForeColor = Color.Red;
                Updatelbl.Text = "Fields can't be empty.";
                Updatelbl.Show();
                return;
            }

            if (!op1 || !op2 || !op3 || !op4)
            {
                toUpdate.Crs_Name = Nametxt.Text;
                toUpdate.Crs_Duration = Convert.ToInt32(Durationtxt.Text);
                toUpdate.DeptID = Convert.ToInt32(Deptlist.SelectedValue);
                toUpdate.InsID = Convert.ToInt32(Instlist.SelectedValue);

                db.SaveChanges();

                Updatelbl.ForeColor = Color.White;
                Updatelbl.Text = "1 Row Updated Successfully.";
                Updatelbl.Show();
            }
            else
            {
                Updatelbl.ForeColor = Color.Red;
                Updatelbl.Text = "Update any data first..";
                Updatelbl.Show();
            }


        }
    }
}
