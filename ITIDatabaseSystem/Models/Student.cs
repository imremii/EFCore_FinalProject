using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITIDatabaseSystem.Models
{
    public class Student
    {
        [Key]
        public int Std_ID { get; set; }
        
        [MaxLength(255)]
        public string? Std_FName { get; set; }
        
        [MaxLength(255)]
        public string? Std_LName { get; set; }
        
        [MaxLength(255)]
        public string? Std_Phone { get; set; }
        public virtual ICollection<StudentCourse> Std_Courses { get; set; } = new HashSet<StudentCourse>();
        public virtual ICollection<CourseSessionAttendance> CrsSAs { get; set; } = new HashSet<CourseSessionAttendance>();

        public override string ToString()
        {
            return $"ID: {Std_ID} | Name: {Std_FName} {Std_LName} | Phone: {Std_Phone}";
        }
    }
}
