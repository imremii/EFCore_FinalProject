using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITIDatabaseSystem.Models
{
    public class Instructor
    {
        [Key]
        public int Ins_ID { get; set; }
       
        [MaxLength(255)]
        public string? Ins_FName { get; set; } = string.Empty;
        
        [MaxLength(255)]
        public string? Ins_LName { get; set; } = string.Empty;
       
        [MaxLength(255)]
        public string? Ins_Phone { get; set; } = string.Empty;
        public decimal? Salary { get; set; }
        
        [ForeignKey("Department")]
        public int? Dept_ID { get; set; }
        public Department? Department { get; set; } = null!;
        public Department? ManagedBy { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();

    }
}
