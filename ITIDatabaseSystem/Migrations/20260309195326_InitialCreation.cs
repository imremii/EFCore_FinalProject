using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ITIDatabaseSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Std_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Std_FName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Std_LName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Std_Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Std_ID);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Crs_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Crs_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Crs_Duration = table.Column<int>(type: "int", nullable: true),
                    DeptID = table.Column<int>(type: "int", nullable: false),
                    InsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Crs_ID);
                });

            migrationBuilder.CreateTable(
                name: "StudentCourses",
                columns: table => new
                {
                    CrsID = table.Column<int>(type: "int", nullable: false),
                    StdID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentCourses", x => new { x.StdID, x.CrsID });
                    table.ForeignKey(
                        name: "FK_StudentCourses_Courses_CrsID",
                        column: x => x.CrsID,
                        principalTable: "Courses",
                        principalColumn: "Crs_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentCourses_Students_StdID",
                        column: x => x.StdID,
                        principalTable: "Students",
                        principalColumn: "Std_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSessionAttendances",
                columns: table => new
                {
                    StdCrs_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CrsSession_ID = table.Column<int>(type: "int", nullable: false),
                    StdID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessionAttendances", x => x.StdCrs_ID);
                    table.ForeignKey(
                        name: "FK_CourseSessionAttendances_Students_StdID",
                        column: x => x.StdID,
                        principalTable: "Students",
                        principalColumn: "Std_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSessions",
                columns: table => new
                {
                    CrsSession_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsID = table.Column<int>(type: "int", nullable: true),
                    CrsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSessions", x => x.CrsSession_ID);
                    table.ForeignKey(
                        name: "FK_CourseSessions_Courses_CrsID",
                        column: x => x.CrsID,
                        principalTable: "Courses",
                        principalColumn: "Crs_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Dept_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dept_Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Dept_Location = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ManagerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Dept_ID);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Ins_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ins_FName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ins_LName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ins_Phone = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(8,2)", nullable: true),
                    Dept_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Ins_ID);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_Dept_ID",
                        column: x => x.Dept_ID,
                        principalTable: "Departments",
                        principalColumn: "Dept_ID");
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Dept_ID", "Dept_Location", "Dept_Name", "ManagerID" },
                values: new object[,]
                {
                    { 1, "Building A", "SD", null },
                    { 2, "Building B", "UI/UX", null },
                    { 3, "Building C", "Mobile", null },
                    { 4, "Building D", "Cloud", null },
                    { 5, "Building E", "Open Source", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Std_ID", "Std_FName", "Std_LName", "Std_Phone" },
                values: new object[,]
                {
                    { 1, "Liam", "Anderson", "01010000001" },
                    { 2, "Olivia", "Martinez", "01010000002" },
                    { 3, "Noah", "Thompson", "01010000003" },
                    { 4, "Monica", "Williams", "01010000004" },
                    { 5, "Elijah", "Brown", "01010000005" },
                    { 6, "Ava", "Garcia", "01010000006" },
                    { 7, "Lucas", "Miller", "01010000007" },
                    { 8, "Sophia", "Davis", "01010000008" },
                    { 9, "Mason", "Wilson", "01010000009" },
                    { 10, "Isabella", "Moore", "01010000010" },
                    { 11, "James", "Taylor", "01010000011" },
                    { 12, "Mia", "Anderson", "01010000012" },
                    { 13, "Benjamin", "Thomas", "01010000013" },
                    { 14, "Charlotte", "Jackson", "01010000014" },
                    { 15, "Henry", "White", "01010000015" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Ins_ID", "Dept_ID", "Ins_FName", "Ins_LName", "Ins_Phone", "Salary" },
                values: new object[,]
                {
                    { 1, 1, "Dr. Emily", "Smith", "01020000001", 5000m },
                    { 2, 2, "Dr. Michael", "Johnson", "01020000002", 5500m },
                    { 3, 3, "Dr. Sarah", "Williams", "01020000003", 6000m },
                    { 4, 4, "Dr. David", "Brown", "01020000004", 6500m },
                    { 5, 5, "Dr. Jessica", "Jones", "01020000005", 7000m }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Crs_ID", "Crs_Duration", "Crs_Name", "DeptID", "InsID" },
                values: new object[,]
                {
                    { 1, 40, "C# Programming", 1, 1 },
                    { 2, 35, "UI/UX Design", 2, 2 },
                    { 3, 45, "Mobile App Development", 3, 3 },
                    { 4, 50, "Cloud Computing", 4, 4 },
                    { 5, 30, "Open Source Software", 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "CourseSessions",
                columns: new[] { "CrsSession_ID", "CrsID", "Date", "InsID", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Data Types" },
                    { 2, 2, new DateTime(2026, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "UI/UX Principles" },
                    { 3, 3, new DateTime(2026, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Mobile App Architecture" },
                    { 4, 4, new DateTime(2026, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Cloud Infrastructure" },
                    { 5, 5, new DateTime(2026, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Open Source Contributions" }
                });

            migrationBuilder.InsertData(
                table: "StudentCourses",
                columns: new[] { "CrsID", "StdID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 },
                    { 1, 6 },
                    { 2, 7 },
                    { 3, 8 },
                    { 4, 9 },
                    { 5, 10 },
                    { 1, 11 },
                    { 2, 12 },
                    { 3, 13 },
                    { 4, 14 },
                    { 5, 15 }
                });

            migrationBuilder.InsertData(
                table: "CourseSessionAttendances",
                columns: new[] { "StdCrs_ID", "CrsSession_ID", "Grade", "Notes", "StdID" },
                values: new object[,]
                {
                    { 1, 1, 85, "Good understanding of data types", 1 },
                    { 2, 2, 90, "Excellent grasp of UI/UX principles", 2 },
                    { 3, 3, 80, "Solid knowledge of mobile app architecture", 3 },
                    { 4, 4, 88, "Strong understanding of cloud infrastructure", 4 },
                    { 5, 5, 92, "Outstanding contributions to open source projects", 5 },
                    { 6, 1, 78, "Needs improvement in data types", 6 },
                    { 7, 2, 82, "Good understanding of UI/UX principles", 7 },
                    { 8, 3, 75, "Average knowledge of mobile app architecture", 8 },
                    { 9, 4, 80, "Solid understanding of cloud infrastructure", 9 },
                    { 10, 5, 85, "Good contributions to open source projects", 10 },
                    { 11, 1, 82, "Good understanding of data types", 11 },
                    { 12, 2, 88, "Strong grasp of UI/UX principles", 12 },
                    { 13, 3, 79, "Average knowledge of mobile app architecture", 13 },
                    { 14, 4, 84, "Good understanding of cloud infrastructure", 14 },
                    { 15, 5, 91, "Excellent contributions to open source projects", 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_DeptID",
                table: "Courses",
                column: "DeptID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InsID",
                table: "Courses",
                column: "InsID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_CrsSession_ID",
                table: "CourseSessionAttendances",
                column: "CrsSession_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessionAttendances_StdID",
                table: "CourseSessionAttendances",
                column: "StdID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_CrsID",
                table: "CourseSessions",
                column: "CrsID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSessions_InsID",
                table: "CourseSessions",
                column: "InsID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments",
                column: "ManagerID",
                unique: true,
                filter: "[ManagerID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_Dept_ID",
                table: "Instructors",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CrsID",
                table: "StudentCourses",
                column: "CrsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Departments_DeptID",
                table: "Courses",
                column: "DeptID",
                principalTable: "Departments",
                principalColumn: "Dept_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InsID",
                table: "Courses",
                column: "InsID",
                principalTable: "Instructors",
                principalColumn: "Ins_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessionAttendances_CourseSessions_CrsSession_ID",
                table: "CourseSessionAttendances",
                column: "CrsSession_ID",
                principalTable: "CourseSessions",
                principalColumn: "CrsSession_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseSessions_Instructors_InsID",
                table: "CourseSessions",
                column: "InsID",
                principalTable: "Instructors",
                principalColumn: "Ins_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ManagerID",
                table: "Departments",
                column: "ManagerID",
                principalTable: "Instructors",
                principalColumn: "Ins_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_Dept_ID",
                table: "Instructors");

            migrationBuilder.DropTable(
                name: "CourseSessionAttendances");

            migrationBuilder.DropTable(
                name: "StudentCourses");

            migrationBuilder.DropTable(
                name: "CourseSessions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Instructors");
        }
    }
}
