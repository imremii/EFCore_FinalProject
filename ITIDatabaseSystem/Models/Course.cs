using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITIDatabaseSystem.Models
{
    public class Course
    {
        [Key]
        public int Crs_ID { get; set; }
       
        [MaxLength(255)]
        public string? Crs_Name { get; set; }
        public int? Crs_Duration { get; set; }
       
        [ForeignKey("Department")]
        public int DeptID { get; set; }
        public virtual Department Department { get; set; } = null!;
       
        [ForeignKey("Instructor")]
        public int InsID { get; set; }
        public virtual Instructor Instructor { get; set; } = null!;
        public virtual ICollection<StudentCourse> Std_Courses { get; set; } = new HashSet<StudentCourse>();
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();


    }
}
