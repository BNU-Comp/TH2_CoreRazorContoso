using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TH2_CoreRazerContoso.Models
{
    public class Student
    {
        // Primary Key
        public int StudentID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        // Navigation Property
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
