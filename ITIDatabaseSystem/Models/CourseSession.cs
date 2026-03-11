using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITIDatabaseSystem.Models
{
    public class CourseSession
    {
        [Key]
        public int CrsSession_ID { get; set; }
       
        [MaxLength(255)]
        public string? Title { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("Instructor")]
        public int? InsID { get; set; }
        public virtual Instructor Instructor { get; set; } = null!;

        [ForeignKey("Course")]
        public int CrsID { get; set; }
        public virtual Course Course { get; set; } = null!;
        public virtual ICollection<CourseSessionAttendance> CrsSesAttendance { get; set; } = new HashSet<CourseSessionAttendance>();


    }
}
