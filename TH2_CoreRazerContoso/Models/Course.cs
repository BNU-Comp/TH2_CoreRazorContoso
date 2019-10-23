using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace TH2_CoreRazerContoso.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        // Relationship or Navigation Property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
