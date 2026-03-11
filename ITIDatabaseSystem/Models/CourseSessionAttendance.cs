using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITIDatabaseSystem.Models
{
    public class CourseSessionAttendance
    {
        [Key]
        public int StdCrs_ID { get; set; }
        public int? Grade { get; set; }
        public string? Notes { get; set; }
       
        [ForeignKey("CrsSessID")]
        public int CrsSession_ID { get; set; }
        public CourseSession CrsSessID { get; set; } = null!;
       
        [ForeignKey("Student")]
        public int StdID { get; set; }
        public Student Student { get; set; } = null!;

    }
}
