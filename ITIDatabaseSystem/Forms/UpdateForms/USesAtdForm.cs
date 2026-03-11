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
    public partial class USesAtdForm : Form
    {
        AppDBContext db = new AppDBContext();
        public USesAtdForm()
        {
            InitializeComponent();
            FillCrsSesList();
            FillStdList();
            FillSesAtdList();
            gradelbl.Hide();
            Updatelbl.Hide();
        }

        private void FillStdList()
        {
            Stdlist.DataSource = db.Students
           .Select(s => new
           {
               StdName = s.Std_FName + " " + s.Std_LName,
               s.Std_ID
           }).ToList();

            Stdlist.DisplayMember = "StdName";
            Stdlist.ValueMember = "Std_ID";
        }

        private void FillCrsSesList()
        {
            CrsSesslist.DataSource = db.CourseSessions
           .Select(c => new
           {
               c.Title,
               c.CrsSession_ID
           }).ToList();

            CrsSesslist.DisplayMember = "Title";
            CrsSesslist.ValueMember = "CrsSession_ID";
        }

        private void FillSesAtdList()
        {
            SesAtdlist.DataSource = db.CourseSessionAttendances
               .Select(a => new
               {
                   a.StdCrs_ID,
                   DisplayName = a.Student.Std_FName + " " + a.Student.Std_LName + " - " + a.CrsSessID.Title
               }).ToList();

            SesAtdlist.DisplayMember = "DisplayName";
            SesAtdlist.ValueMember = "StdCrs_ID";
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            var updForm = new UpdateForm();
            updForm.Show();
            this.Hide();
        }

        private void SesAtdlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            gradelbl.Hide();
            Updatelbl.Hide();

            if (SesAtdlist.SelectedValue == null) return;

            int selectedID = Convert.ToInt32(SesAtdlist.SelectedValue);

            IDtxt.Text = db.CourseSessionAttendances
                .Where(ent => ent.StdCrs_ID == selectedID)
                .Select(ent => ent.CrsSession_ID)
                .FirstOrDefault()
                .ToString();

            Stdlist.SelectedValue = db.CourseSessionAttendances
                .Where(ent => ent.StdCrs_ID == selectedID)
                .Select(ent => ent.StdID)
                .FirstOrDefault();

            CrsSesslist.SelectedValue = db.CourseSessionAttendances
                .Where(ent => ent.StdCrs_ID == selectedID)
                .Select(ent => ent.CrsSession_ID) 
                .FirstOrDefault();

            Gradetxt.Text = db.CourseSessionAttendances
                .Where(ent => ent.StdCrs_ID == selectedID)
                .Select(ent => ent.Grade)
                .FirstOrDefault()
                ?.ToString();

            Notetxt.Text = db.CourseSessionAttendances
                .Where(ent => ent.StdCrs_ID == selectedID)
                .Select(ent => ent.Notes)
                .FirstOrDefault();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            gradelbl.Hide();
            Updatelbl.Hide();

            if (SesAtdlist.SelectedValue == null) return;

            int selectedID = Convert.ToInt32(SesAtdlist.SelectedValue);

            var toUpdate = db.CourseSessionAttendances
                .FirstOrDefault(ent => ent.StdCrs_ID == selectedID);

            if (toUpdate == null) return;

            bool op1 = toUpdate.StdID.ToString() == Stdlist.SelectedValue?.ToString();
            bool op2 = toUpdate.CrsSession_ID.ToString() == CrsSesslist.SelectedValue?.ToString();
            bool op3 = toUpdate.Grade.ToString() == Gradetxt.Text;
            bool op4 = toUpdate.Notes == Notetxt.Text;

            if (!Validations.CheckNumber(Gradetxt.Text))
            {
                gradelbl.Show();
                return;
            }

            if (!op1 || !op2 || !op3 || !op4)
            {
                toUpdate.StdID = Convert.ToInt32(Stdlist.SelectedValue);
                toUpdate.CrsSession_ID = Convert.ToInt32(CrsSesslist.SelectedValue);
                toUpdate.Grade = Convert.ToInt32(Gradetxt.Text);
                toUpdate.Notes = Notetxt.Text;

                db.SaveChanges();

                Updatelbl.ForeColor = Color.White;
                Updatelbl.Text = "1 Row Updated Successfully.";
                Updatelbl.Show();
            }
            else
            {
                Updatelbl.ForeColor = Color.Red;
                Updatelbl.Text = "Update any data first.";
                Updatelbl.Show();
            }
        }
    }
}
