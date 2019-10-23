﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TH2_CoreRazerContoso.Models;

namespace TH2_CoreRazerContoso.Data
{
    public class DbInitialiser
    {
        public static void Initialize(UniversityContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Student.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2001-09-01")},
                new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };

            foreach (Student s in students)
            {
                context.Student.Add(s);
            }

            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{CourseID=1,Title="Chemistry",Credits=3},
                new Course{CourseID=2,Title="Microeconomics",Credits=3},
                new Course{CourseID=3,Title="Macroeconomics",Credits=3},
                new Course{CourseID=4,Title="Calculus",Credits=4},
                new Course{CourseID=5,Title="Trigonometry",Credits=4},
                new Course{CourseID=6,Title="Composition",Credits=3},
                new Course{CourseID=2042,Title="Literature",Credits=4}
            };

            foreach (Course c in courses)
            {
                context.Course.Add(c);
            }

            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1,Grade=Grades.First},
                new Enrollment{StudentID=1,CourseID=2,Grade=Grades.LowerSecond},
                new Enrollment{StudentID=1,CourseID=3,Grade=Grades.UpperSecond},
                new Enrollment{StudentID=2,CourseID=4,Grade=Grades.UpperSecond},
                new Enrollment{StudentID=2,CourseID=5,Grade=Grades.Pass},
                new Enrollment{StudentID=2,CourseID=6,Grade=Grades.Fail},
                new Enrollment{StudentID=3,CourseID=1},
                new Enrollment{StudentID=4,CourseID=1},
                new Enrollment{StudentID=4,CourseID=2,Grade=Grades.Fail},
                new Enrollment{StudentID=5,CourseID=3,Grade=Grades.LowerSecond},
                new Enrollment{StudentID=6,CourseID=4},
                new Enrollment{StudentID=7,CourseID=5,Grade=Grades.First},
            };

            foreach (Enrollment e in enrollments)
            {
                context.Enrollment.Add(e);
            }

            context.SaveChanges();
        }
    }
}
