using ITIDatabaseSystem.Context;
using ITIDatabaseSystem.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ITIDatabaseSystem.Forms.UpdateForms
{
    public partial class UInsForm : Form
    {
        AppDBContext db = new AppDBContext();
        public UInsForm()
        {
            InitializeComponent();
            FillDeptList();
            FillInstList();
            Updatelbl.Hide();
            sallbl.Hide();
            PNlbl.Hide();
            LNlbl.Hide();
            FNlbl.Hide();
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

        private void Instlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            Updatelbl.Hide();
            sallbl.Hide();
            PNlbl.Hide();
            LNlbl.Hide();
            FNlbl.Hide();

            IDtxt.Text = db.Instructors
            .Where(ent => ent.Ins_ID == Convert.ToInt32(Instlist.SelectedValue))
            .Select(ent => ent.Ins_ID)
            .FirstOrDefault()
            .ToString();

            FNametxt.Text = db.Instructors
            .Where(ent => ent.Ins_ID == Convert.ToInt32(Instlist.SelectedValue))
            .Select(ent => ent.Ins_FName)
            .FirstOrDefault()
            .ToString();

            LNametxt.Text = db.Instructors
            .Where(ent => ent.Ins_ID == Convert.ToInt32(Instlist.SelectedValue))
            .Select(ent => ent.Ins_LName)
            .FirstOrDefault()
            .ToString();

            PNumbertxt.Text = db.Instructors
            .Where(ent => ent.Ins_ID == Convert.ToInt32(Instlist.SelectedValue))
            .Select(ent => ent.Ins_Phone)
            .FirstOrDefault()
            .ToString();

            Salarytxt.Text = db.Instructors
            .Where(ent => ent.Ins_ID == Convert.ToInt32(Instlist.SelectedValue))
            .Select(ent => ent.Salary)
            .FirstOrDefault()
            .ToString();

            Deptlist.SelectedValue = db.Instructors
           .Where(ent => ent.Ins_ID == Convert.ToInt32(Instlist.SelectedValue))
           .Select(ent => ent.Dept_ID)
           .FirstOrDefault();

        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            Updatelbl.Hide();
            sallbl.Hide();
            PNlbl.Hide();
            LNlbl.Hide();
            FNlbl.Hide();

            db.Instructors.Include(i => i.Department).Load();
            var toUpdate = db.Instructors.Local.FirstOrDefault(ent => ent.Ins_ID == Convert.ToInt32(Instlist.SelectedValue));

            bool op1 = toUpdate.Ins_FName == FNametxt.Text;
            bool op2 = toUpdate.Ins_LName == LNametxt.Text;
            bool op3 = toUpdate.Ins_Phone == PNumbertxt.Text;
            bool op4 = toUpdate.Salary.ToString() == Salarytxt.Text;
            bool op5 = toUpdate.Dept_ID.ToString() == Deptlist.SelectedValue?.ToString();

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


            if (!Validations.CheckSalary(Salarytxt.Text))
            {
                sallbl.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(FNametxt.Text) || string.IsNullOrWhiteSpace(LNametxt.Text))
            {
                Updatelbl.ForeColor = Color.Red;
                Updatelbl.Text = "Fields can't be empty.";
                Updatelbl.Show();
                return;
            }

            if (!op1 || !op2 || !op3 || !op4 || !op5)
            {
                toUpdate.Ins_FName = FNametxt.Text;
                toUpdate.Ins_LName = LNametxt.Text;
                toUpdate.Ins_Phone = PNumbertxt.Text;
                toUpdate.Salary = Convert.ToDecimal(Salarytxt.Text);
                toUpdate.Dept_ID = Convert.ToInt32(Deptlist.SelectedValue);

                db.SaveChanges();

                Updatelbl.ForeColor = Color.White;
                Updatelbl.Text = "1 Row Updated Successfully";
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
