using ITIDatabaseSystem.Context;
using ITIDatabaseSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ITIDatabaseSystem.Forms
{
    public partial class SelectForm : Form
    {
        AppDBContext db = new AppDBContext();
        public SelectForm()
        {
            InitializeComponent();
            FillTableList();
        }

        private void FillTableList()
        {
            Tableslist.DataSource = new List<string>() {
                "Students",
                "Instructors",
                "Courses",
                "Departments",
                "Student Courses",
                "Course Sessions",
                "Course Sessions Attendance"
            };
        }
        private void Tableslist_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Tableslist.SelectedValue)
            {
                case "Courses":
                    db.Courses.Load();
                    Recordslist.DataSource = db.Courses.Local.Select(c => new { c.Crs_Name, c.Crs_ID }).ToList();
                    Recordslist.DisplayMember = "Crs_Name";
                    Recordslist.ValueMember = "Crs_ID";
                    break;

                case "Students":
                    db.Students.Load();
                    Recordslist.DataSource = db.Students.Local
                        .Select(s => new { FullName = s.Std_FName + " " + s.Std_LName, s.Std_ID })
                        .ToList();
                    Recordslist.DisplayMember = "FullName";
                    Recordslist.ValueMember = "Std_ID";
                    break;

                case "Instructors":
                    db.Instructors.Load();
                    Recordslist.DataSource = db.Instructors.Local
                        .Select(i => new { FullName = i.Ins_FName + " " + i.Ins_LName, i.Ins_ID })
                        .ToList();
                    Recordslist.DisplayMember = "FullName";
                    Recordslist.ValueMember = "Ins_ID";
                    break;

                case "Departments":
                    db.Departments.Load();
                    Recordslist.DataSource = db.Departments.Local.Select(d => new { d.Dept_Name, d.Dept_ID }).ToList();
                    Recordslist.DisplayMember = "Dept_Name";
                    Recordslist.ValueMember = "Dept_ID";
                    break;

                case "Student Courses":
                    db.StudentCourses.Load();
                    Recordslist.DataSource = db.StudentCourses.Local.Select(sc => new { StudentName = sc.Student.Std_FName + " " + sc.Student.Std_LName, sc.StdID }).ToList();
                    Recordslist.DisplayMember = "StudentName";
                    Recordslist.ValueMember = "StdID";
                    break;

                case "Course Sessions":
                    db.CourseSessions.Load();
                    Recordslist.DataSource = db.CourseSessions.Local.Select(d => new { d.Title, d.CrsID }).ToList();
                    Recordslist.DisplayMember = "Title";
                    Recordslist.ValueMember = "CrsID";
                    break;

                case "Course Sessions Attendance":
                    db.CourseSessionAttendances.Load();
                    Recordslist.DataSource = db.CourseSessionAttendances.Local.Select(d => new { FullName = d.Student.Std_FName + " " + d.Student.Std_LName, d.CrsSession_ID }).ToList();
                    Recordslist.DisplayMember = "FullName";
                    Recordslist.ValueMember = "CrsSession_ID";
                    break;
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            var backbtn = new StartPage();
            backbtn.Show();
            this.Close();
        }

        private void SelectAllbtn_Click(object sender, EventArgs e)
        {
            switch (Tableslist.SelectedValue)
            {
                case "Courses":
                    db.Courses.Load();
                    Datagrid.DataSource = db.Courses.Select(c => new
                    {
                        Course_ID = c.Crs_ID,
                        Course_Name = c.Crs_Name,
                        Course_Duration = c.Crs_Duration,
                    }).ToList();
                    break;

                case "Students":
                    db.Students.Load();
                    Datagrid.DataSource = db.Students.Select(s => new
                    {
                        Student_ID = s.Std_ID,
                        Full_Name = s.Std_FName + " " + s.Std_LName,
                        Student_Phone = s.Std_Phone
                    }).ToList();
                    break;

                case "Instructors":
                    db.Instructors.Load();
                    Datagrid.DataSource = db.Instructors.Select(i => new
                    {
                        Instructor_ID = i.Ins_ID,
                        Full_Name = i.Ins_FName + " " + i.Ins_LName,
                        Instructor_Phone = i.Ins_Phone,
                        Salary = i.Salary,
                        Department_Name =  i.Department.Dept_Name
                    }).ToList();
                    break;

                case "Departments":
                    db.Departments.Load();
                    Datagrid.DataSource = db.Departments.Select(d => new
                    {
                        Department_ID = d.Dept_ID,
                        Department_Name = d.Dept_Name,
                        Department_Location = d.Dept_Location,
                        Manager_Name = d.Instructors.Select(i => i.Ins_FName + " " + i.Ins_LName).FirstOrDefault() ?? "No Manager"
                    }).ToList();
                    break;

                case "Student Courses":
                    db.StudentCourses.Load();
                    Datagrid.DataSource = db.StudentCourses.Select(sc => new
                    {
                        Student_Name = sc.Student.Std_FName + " " + sc.Student.Std_LName,
                        Course_Name = sc.Course.Crs_Name
                    }).ToList();
                    break;

                case "Course Sessions":
                    db.CourseSessions.Load();
                    Datagrid.DataSource = db.CourseSessions.Select(cs => new
                    {
                        Session_ID = cs.CrsSession_ID,
                        Session_Title = cs.Title,
                        Session_Date = cs.Date,
                        Course_Name = cs.Course.Crs_Name
                    }).ToList();
                    break;

                case "Course Sessions Attendance":
                    db.CourseSessionAttendances.Load();
                    Datagrid.DataSource = db.CourseSessionAttendances.Select(csa => new
                    {
                        Student_ID = csa.StdID,
                        Session_ID = csa.CrsSession_ID,
                        Student_Name = csa.Student.Std_FName + " " + csa.Student.Std_LName,
                        Student_Grade = csa.Grade,
                        Notes = csa.Notes
                    }).ToList();
                    break;
            }
        }

        private void Selectbtn_Click(object sender, EventArgs e)
        {
            switch (Tableslist.SelectedValue)
            {
                case "Courses":
                    db.Courses.Load();
                    Datagrid.DataSource = db.Courses.Select(c => new
                    {
                        Course_ID = c.Crs_ID,
                        Course_Name = c.Crs_Name,
                        Course_Duration = c.Crs_Duration,
                    }).Where(c => c.Course_Name == Recordslist.Text).ToList();
                    break;

                case "Students":
                    db.Students.Load();
                    Datagrid.DataSource = db.Students.Select(s => new
                    {
                        Student_ID = s.Std_ID,
                        Full_Name = s.Std_FName + " " + s.Std_LName,
                        Student_Phone = s.Std_Phone
                    }).Where(s => s.Full_Name == Recordslist.Text).ToList();
                    break;

                case "Instructors":
                    db.Instructors.Load();
                    Datagrid.DataSource = db.Instructors.Select(i => new
                    {
                        Instructor_ID = i.Ins_ID,
                        Full_Name = i.Ins_FName + " " + i.Ins_LName,
                        Instructor_Phone = i.Ins_Phone,
                        Salary = i.Salary,
                        Department_Name = i.Department.Dept_Name
                    }).Where(i => i.Full_Name == Recordslist.Text).ToList();
                    break;

                case "Departments":
                    db.Departments.Load();
                    Datagrid.DataSource = db.Departments.Select(d => new
                    {
                        Department_ID = d.Dept_ID,
                        Department_Name = d.Dept_Name,
                        Department_Location = d.Dept_Location,
                        Manager_Name = d.Instructors.Select(i => i.Ins_FName + " " + i.Ins_LName).FirstOrDefault() ?? "No Manager"
                    }).Where(d => d.Department_Name == Recordslist.Text).ToList();
                    break;

                case "Student Courses":
                    db.StudentCourses.Load();
                    Datagrid.DataSource = db.StudentCourses.Select(sc => new
                    {
                        Student_Name = sc.Student.Std_FName + " " + sc.Student.Std_LName,
                        Course_Name = sc.Course.Crs_Name
                    }).Where(d => d.Student_Name == Recordslist.Text).ToList();
                    break;

                case "Course Sessions":
                    db.CourseSessions.Load();
                    Datagrid.DataSource = db.CourseSessions.Select(cs => new
                    {
                        Session_ID = cs.CrsSession_ID,
                        Session_Title = cs.Title,
                        Session_Date = cs.Date,
                        Course_Name = cs.Course.Crs_Name
                    }).Where(d => d.Session_Title == Recordslist.Text).ToList();
                    break;

                case "Course Sessions Attendance":
                    db.CourseSessionAttendances.Load();
                    Datagrid.DataSource = db.CourseSessionAttendances.Select(csa => new
                    {
                        Student_ID = csa.StdID,
                        Session_ID = csa.CrsSession_ID,
                        Student_Name = csa.Student.Std_FName + " " + csa.Student.Std_LName,
                        Student_Grade = csa.Grade,
                        Notes = csa.Notes
                    }).Where(d => d.Student_Name == Recordslist.Text).ToList();
                    break;
            }
        }
    }
}
