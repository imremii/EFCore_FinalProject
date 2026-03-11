using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace ITIDatabaseSystem.Models
{
    [PrimaryKey(nameof(CrsID), nameof(StdID))]
    public class StudentCourse
    {
        [ForeignKey("Course")]
        public int CrsID { get; set; }
       
        [ForeignKey("Student")]
        public int StdID { get; set; }
        public virtual Student Student { get; set; } = null!;
        public virtual Course Course { get; set; } = null!;
    }
}
