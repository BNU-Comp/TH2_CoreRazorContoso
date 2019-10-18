using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TH2_CoreRazerContoso.Models
{
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grades? Grade { get; set; }

        // Navigation/Relationship
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }

    public enum Grades
    {
        First,
        UpperSecond,
        LowerSecond,
        Third,
        Pass,
        Fail
    }
}
