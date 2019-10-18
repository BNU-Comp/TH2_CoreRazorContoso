using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TH2_CoreRazerContoso.Models
{
    /// <summary>
    /// This represents a student enrolled on a course
    /// Author: Derek
    /// </summary>
    public class Enrollment
    {
        // Primary Key
        public int EnrollmentID { get; set; }
        // Foreign Key
        public int CourseID { get; set; }
        // Foreign Key
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
