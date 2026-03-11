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
    public partial class UStdForm : Form
    {

        AppDBContext db = new AppDBContext();
        public UStdForm()
        {
            InitializeComponent();
            FillStdList();
            FNlbl.Hide();
            LNlbl.Hide();
            PNlbl.Hide();
            Updatelbl.Hide();

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            var updForm = new UpdateForm();
            updForm.Show();
            this.Hide();
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

        private void Stdlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            FNlbl.Hide();
            LNlbl.Hide();
            PNlbl.Hide();
            Updatelbl.Hide();

            int id = Convert.ToInt32(Stdlist.SelectedValue);

            var student = db.Students
                .FirstOrDefault(ent => ent.Std_ID == id);

            if (student != null)
            {
                IDtxt.Text = Convert.ToString(student.Std_ID);
                FNametxt.Text = student.Std_FName;
                LNametxt.Text = student.Std_LName;
                PNumbertxt.Text = student.Std_Phone;
            }
            else
            {
                IDtxt.Text = "";
                FNametxt.Text = "";
                LNametxt.Text = "";
                PNumbertxt.Text = "";
            }

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            FNlbl.Hide();
            LNlbl.Hide();
            PNlbl.Hide();
            Updatelbl.Hide();

            var toUpdate = db.Students.Local.FirstOrDefault(ent => ent.Std_ID == Convert.ToInt32(Stdlist.SelectedValue));

            bool op1 = toUpdate.Std_FName == FNametxt.Text;
            bool op2 = toUpdate.Std_LName == LNametxt.Text;
            bool op3 = toUpdate.Std_Phone == PNumbertxt.Text;


            if (!Validations.CheckName(FNametxt.Text))
            {
                FNlbl.Show();
                return;
            }


            if (!Validations.CheckName(LNametxt.Text))
            {
                LNlbl.Show();
                return;
            }


            if (!Validations.CheckPhone(PNumbertxt.Text))
            {
                PNlbl.Show();
                return;
            }


            if (string.IsNullOrWhiteSpace(FNametxt.Text) || string.IsNullOrWhiteSpace(LNametxt.Text))
            {
                Updatelbl.ForeColor = Color.Red;
                Updatelbl.Text = "Fields can't be empty.";
                Updatelbl.Show();
                return;
            }

            if (!op1 || !op2 || !op3)
            {
                toUpdate.Std_FName = FNametxt.Text;
                toUpdate.Std_LName = LNametxt.Text;
                toUpdate.Std_Phone = PNumbertxt.Text;

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
