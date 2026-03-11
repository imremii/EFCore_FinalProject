using System;
using System.Collections.Generic;
using System.Text;
using ITIDatabaseSystem.Models;

namespace ITIDatabaseSystem.Repository
{
    public class ProjectRepository
    {
        public static List<Student> getStudents()
        {
            return new List<Student>()
            {
                new Student {Std_ID = 1, Std_FName = "Liam", Std_LName = "Anderson", Std_Phone = "01010000001"},
                new Student {Std_ID = 2, Std_FName = "Olivia", Std_LName = "Martinez", Std_Phone = "01010000002"},
                new Student {Std_ID = 3, Std_FName = "Noah", Std_LName = "Thompson", Std_Phone = "01010000003"},
                new Student {Std_ID = 4, Std_FName = "Monica", Std_LName = "Williams", Std_Phone = "01010000004"},
                new Student {Std_ID = 5, Std_FName = "Elijah", Std_LName = "Brown", Std_Phone = "01010000005"},
                new Student {Std_ID = 6, Std_FName = "Ava", Std_LName = "Garcia", Std_Phone = "01010000006"},
                new Student {Std_ID = 7, Std_FName = "Lucas", Std_LName = "Miller", Std_Phone = "01010000007"},
                new Student {Std_ID = 8, Std_FName = "Sophia", Std_LName = "Davis", Std_Phone = "01010000008"},
                new Student {Std_ID = 9, Std_FName = "Mason", Std_LName = "Wilson", Std_Phone = "01010000009"},
                new Student {Std_ID = 10, Std_FName = "Isabella", Std_LName = "Moore", Std_Phone = "01010000010"},
                new Student {Std_ID = 11, Std_FName = "James", Std_LName = "Taylor", Std_Phone = "01010000011"},
                new Student {Std_ID = 12, Std_FName = "Mia", Std_LName = "Anderson", Std_Phone = "01010000012"},
                new Student {Std_ID = 13, Std_FName = "Benjamin", Std_LName = "Thomas", Std_Phone = "01010000013"},
                new Student {Std_ID = 14, Std_FName = "Charlotte", Std_LName = "Jackson", Std_Phone = "01010000014"},
                new Student {Std_ID = 15, Std_FName = "Henry", Std_LName = "White", Std_Phone = "01010000015"}
            };
        }

        public static List<Instructor> getInstructors()
        {
            return new List<Instructor>()
            {
                new Instructor {Ins_ID = 1, Ins_FName = "Dr. Emily", Ins_LName = "Smith", Ins_Phone = "01020000001", Salary = 5000, Dept_ID = 1},
                new Instructor {Ins_ID = 2, Ins_FName = "Dr. Michael", Ins_LName = "Johnson", Ins_Phone = "01020000002", Salary = 5500, Dept_ID = 2},
                new Instructor {Ins_ID = 3, Ins_FName = "Dr. Sarah", Ins_LName = "Williams", Ins_Phone = "01020000003", Salary = 6000, Dept_ID = 3},
                new Instructor {Ins_ID = 4, Ins_FName = "Dr. David", Ins_LName = "Brown", Ins_Phone = "01020000004", Salary = 6500, Dept_ID = 4},
                new Instructor {Ins_ID = 5, Ins_FName = "Dr. Jessica", Ins_LName = "Jones", Ins_Phone = "01020000005", Salary = 7000, Dept_ID = 5}
            };
        }

        public static List<Department> getDepartments()
        {
            return new List<Department>()
            {
                new Department {Dept_ID = 1, Dept_Name = "SD", Dept_Location = "Building A", ManagerID = null},
                new Department {Dept_ID = 2, Dept_Name = "UI/UX", Dept_Location = "Building B", ManagerID = null},
                new Department {Dept_ID = 3, Dept_Name = "Mobile", Dept_Location = "Building C", ManagerID = null},
                new Department {Dept_ID = 4, Dept_Name = "Cloud", Dept_Location = "Building D", ManagerID = null},
                new Department {Dept_ID = 5, Dept_Name = "Open Source", Dept_Location = "Building E", ManagerID = null}
            };
        }

            public static List<Course> getCourses()
        {
            return new List<Course>()
                {
                    new Course {Crs_ID = 1, Crs_Name = "C# Programming",Crs_Duration = 40, DeptID = 1, InsID = 1},
                    new Course {Crs_ID = 2, Crs_Name = "UI/UX Design", Crs_Duration = 35, DeptID = 2, InsID = 2},
                    new Course {Crs_ID = 3, Crs_Name = "Mobile App Development", Crs_Duration = 45, DeptID = 3, InsID = 3},
                    new Course {Crs_ID = 4, Crs_Name = "Cloud Computing", Crs_Duration = 50, DeptID = 4, InsID = 4},
                    new Course {Crs_ID = 5, Crs_Name = "Open Source Software", Crs_Duration = 30, DeptID = 5, InsID = 5}
                };
        }


        public static List<StudentCourse> getStudentCourses()
        {
            return new List<StudentCourse>()
            {
                new StudentCourse {StdID = 1, CrsID = 1},
                new StudentCourse {StdID = 2, CrsID = 2},
                new StudentCourse {StdID = 3, CrsID = 3},
                new StudentCourse {StdID = 4, CrsID = 4},
                new StudentCourse {StdID = 5, CrsID = 5},
                new StudentCourse {StdID = 6, CrsID = 1},
                new StudentCourse {StdID = 7, CrsID = 2},
                new StudentCourse {StdID = 8, CrsID = 3},
                new StudentCourse {StdID = 9, CrsID = 4},
                new StudentCourse {StdID = 10, CrsID = 5},
                new StudentCourse {StdID = 11, CrsID = 1},
                new StudentCourse {StdID = 12, CrsID = 2},
                new StudentCourse {StdID = 13, CrsID = 3},
                new StudentCourse {StdID = 14, CrsID = 4},
                new StudentCourse {StdID = 15, CrsID = 5}
            };
        }

        public static List<CourseSession> getCourseSessions()
        {
            return new List<CourseSession>()
            {
                new CourseSession {CrsSession_ID = 1, CrsID = 1, InsID = 1, Title = "Data Types",  Date = new DateTime(2026, 2, 20)},
                new CourseSession {CrsSession_ID = 2, CrsID = 2, InsID = 2, Title = "UI/UX Principles", Date = new DateTime(2026, 2, 21)},
                new CourseSession {CrsSession_ID = 3, CrsID = 3, InsID = 3, Title = "Mobile App Architecture", Date = new DateTime(2026, 2, 22)},
                new CourseSession {CrsSession_ID = 4, CrsID = 4, InsID = 4, Title = "Cloud Infrastructure", Date = new DateTime(2026, 2, 23)},
                new CourseSession {CrsSession_ID = 5, CrsID = 5, InsID = 5, Title = "Open Source Contributions", Date = new DateTime(2026, 2, 24)}
            };
        }

        public static List<CourseSessionAttendance> getCourseSessionAttendances()
        {
            return new List<CourseSessionAttendance>()
            {
                new CourseSessionAttendance {StdCrs_ID = 1, Grade = 85, Notes = "Good understanding of data types", CrsSession_ID = 1, StdID = 1},
                new CourseSessionAttendance {StdCrs_ID = 2, Grade = 90, Notes = "Excellent grasp of UI/UX principles", CrsSession_ID = 2, StdID = 2},
                new CourseSessionAttendance {StdCrs_ID = 3, Grade = 80, Notes = "Solid knowledge of mobile app architecture", CrsSession_ID = 3, StdID = 3},
                new CourseSessionAttendance {StdCrs_ID = 4, Grade = 88, Notes = "Strong understanding of cloud infrastructure", CrsSession_ID = 4, StdID = 4},
                new CourseSessionAttendance {StdCrs_ID = 5, Grade = 92, Notes = "Outstanding contributions to open source projects", CrsSession_ID = 5, StdID = 5},
                new CourseSessionAttendance {StdCrs_ID = 6, Grade = 78, Notes = "Needs improvement in data types", CrsSession_ID = 1, StdID = 6},
                new CourseSessionAttendance {StdCrs_ID = 7, Grade = 82, Notes = "Good understanding of UI/UX principles", CrsSession_ID = 2, StdID = 7},
                new CourseSessionAttendance {StdCrs_ID = 8, Grade = 75, Notes = "Average knowledge of mobile app architecture", CrsSession_ID = 3, StdID = 8},
                new CourseSessionAttendance {StdCrs_ID = 9, Grade = 80, Notes = "Solid understanding of cloud infrastructure", CrsSession_ID = 4, StdID = 9},
                new CourseSessionAttendance {StdCrs_ID = 10, Grade = 85, Notes = "Good contributions to open source projects", CrsSession_ID = 5, StdID = 10},
                new CourseSessionAttendance {StdCrs_ID = 11, Grade = 82, Notes = "Good understanding of data types", CrsSession_ID = 1, StdID = 11},
                new CourseSessionAttendance {StdCrs_ID = 12, Grade = 88, Notes = "Strong grasp of UI/UX principles", CrsSession_ID = 2, StdID = 12},
                new CourseSessionAttendance {StdCrs_ID = 13, Grade = 79, Notes = "Average knowledge of mobile app architecture", CrsSession_ID = 3, StdID = 13},
                new CourseSessionAttendance {StdCrs_ID = 14, Grade = 84, Notes = "Good understanding of cloud infrastructure", CrsSession_ID = 4, StdID = 14},
                new CourseSessionAttendance {StdCrs_ID = 15, Grade = 91, Notes = "Excellent contributions to open source projects", CrsSession_ID = 5, StdID = 15}
            };
        }

    }
}
