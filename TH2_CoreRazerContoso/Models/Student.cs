using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TH2_CoreRazerContoso.Models
{
    public class Student
    {
        // Primary Key
        public int StudentID { get; set; }
        
        [StringLength(20, ErrorMessage ="The first name must be less than 20 characters" ), Required, DisplayName("Last Name")]
        public string LastName { get; set; }
        
        [StringLength(20), Required, DisplayName("First Name")]
        public string FirstName { get; set; }

        [DataType(DataType.Date), DisplayName("Enrollment Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime EnrollmentDate { get; set; }

        // Navigation Property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
