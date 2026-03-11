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
    public partial class InsForm : Form
    {
        AppDBContext db = new AppDBContext();
        public InsForm()
        {
            InitializeComponent();
            FillDeptList();
            FNlbl.Hide();
            LNlbl.Hide();
            sallbl.Hide();
            PNlbl.Hide();
            Insertlbl.Hide();
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
            sallbl.Hide();
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


            if (!Validations.CheckNumber(Salarytxt.Text) && !string.IsNullOrWhiteSpace(Salarytxt.Text))
            {
                sallbl.Show();
                return;
            }

            if (string.IsNullOrWhiteSpace(FNametxt.Text) || string.IsNullOrWhiteSpace(LNametxt.Text))
            {
                Insertlbl.ForeColor = Color.Red;
                Insertlbl.Text = "Fields can't be empty.";
                Insertlbl.Show();
                return;
            }

            Instructor newRecord = new()
            {
                Ins_FName = FNametxt.Text,
                Ins_LName = LNametxt.Text,
                Salary = Convert.ToDecimal(Salarytxt.Text),
                Ins_Phone = PNumbertxt.Text,
                Dept_ID = Convert.ToInt32(Deptlist.SelectedValue)
            };

            db.Instructors.Add(newRecord);
            db.SaveChanges();
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Text = "1 Row Added Successfully";
            Insertlbl.Show();
        }
    }
}
