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
    public partial class UCrsSesForm : Form
    {
        AppDBContext db = new AppDBContext();
        public UCrsSesForm()
        {
            InitializeComponent();
            FillCrsSesList();
            FillCrsList();
            FillInstList();
            namelbl.Hide();
            datebl.Hide();
            Updatelbl.Hide();

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
            var updForm = new UpdateForm();
            updForm.Show();
            this.Hide();
        }

        private void CrsSesslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            namelbl.Hide();
            datebl.Hide();
            Updatelbl.Hide();

            IDtxt.Text = db.CourseSessions
            .Where(ent => ent.CrsSession_ID == Convert.ToInt32(CrsSesslist.SelectedValue))
            .Select(ent => ent.CrsSession_ID)
            .FirstOrDefault()
            .ToString();

            Inslist.SelectedValue = db.CourseSessions
            .Where(ent => ent.CrsSession_ID == Convert.ToInt32(CrsSesslist.SelectedValue))
            .Select(ent => ent.InsID)
            .FirstOrDefault();

            Crslist.SelectedValue = db.CourseSessions
            .Where(ent => ent.CrsSession_ID == Convert.ToInt32(CrsSesslist.SelectedValue))
            .Select(ent => ent.CrsID)
            .FirstOrDefault();

            Nametxt.Text = db.CourseSessions
            .Where(ent => ent.CrsSession_ID == Convert.ToInt32(CrsSesslist.SelectedValue))
            .Select(ent => ent.Title)
            .FirstOrDefault()
            .ToString();

            Datetxt.Text = db.CourseSessions
            .Where(ent => ent.CrsSession_ID == Convert.ToInt32(CrsSesslist.SelectedValue))
            .Select(ent => ent.Date)
            .FirstOrDefault()
            .ToString();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            namelbl.Hide();
            datebl.Hide();
            Updatelbl.Hide();

            var selectedSessId = Convert.ToInt32(CrsSesslist.SelectedValue);
            var toUpdate = db.CourseSessions.FirstOrDefault(ent => ent.CrsSession_ID == selectedSessId);

            if (toUpdate == null)
            {
                Updatelbl.ForeColor = Color.Red;
                Updatelbl.Text = "Selected session not found.";
                Updatelbl.Show();
                return;
            }

            bool op1 = (toUpdate.InsID?.ToString() ?? string.Empty) == (Inslist.SelectedValue?.ToString() ?? string.Empty);
            bool op2 = (toUpdate.CrsID.ToString() ?? string.Empty) == (Crslist.SelectedValue?.ToString() ?? string.Empty);
            bool op3 = (toUpdate.Title ?? string.Empty) == (Nametxt.Text ?? string.Empty);
            bool op4 = toUpdate.Date.ToString() == (Datetxt.Text ?? string.Empty);


            if (!Validations.CheckDate(Datetxt.Text))
            {
                datebl.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(Datetxt.Text) || string.IsNullOrEmpty(Nametxt.Text))
            {
                Updatelbl.ForeColor = Color.Red;
                Updatelbl.Text = "Fields cant't be empty.";
                Updatelbl.Show();
                return;
            }

            if (!op1 || !op2 || !op3 || !op4)
            {
                toUpdate.InsID = Convert.ToInt32(Inslist.SelectedValue);
                toUpdate.CrsID = Convert.ToInt32(Crslist.SelectedValue);
                toUpdate.Title = Nametxt.Text;
                toUpdate.Date = Convert.ToDateTime(Datetxt.Text);

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
