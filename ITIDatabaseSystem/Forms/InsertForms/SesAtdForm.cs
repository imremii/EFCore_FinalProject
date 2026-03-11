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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ITIDatabaseSystem.Forms.InsertForms
{
    public partial class SesAtdForm : Form
    {

        AppDBContext db = new AppDBContext();
        public SesAtdForm()
        {
            InitializeComponent();
            FillCrsSesList();
            FillStdList();
            gradelbl.Hide();
            Insertlbl.Hide();
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

        private void Backbtn_Click(object sender, EventArgs e)
        {
            var insrtForm = new InsertForm();
            insrtForm.Show();
            this.Close();
        }

        private void Insertbtn_Click(object sender, EventArgs e)
        {
            gradelbl.Hide();
            Insertlbl.Hide();

            if (!Validations.CheckNumber(Gradetxt.Text) && !string.IsNullOrWhiteSpace(Gradetxt.Text))
            {
                gradelbl.Show();
                return;
            }

            CourseSessionAttendance newRecord = new()
            {
                Grade = Convert.ToInt32(Gradetxt.Text),
                Notes = Notetxt.Text,
                CrsSession_ID = Convert.ToInt32(CrsSesslist.SelectedValue),
                StdID = Convert.ToInt32(Stdlist.SelectedValue),
            };

            db.CourseSessionAttendances.Add(newRecord);
            db.SaveChanges();
            Insertlbl.ForeColor = Color.White;
            Insertlbl.Text = "1 Row Added Successfully";
            Insertlbl.Show();
        }
    }
}
