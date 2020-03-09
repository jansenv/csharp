using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise MartinsAquarium = new Exercise()
            {
                name = "MartinsAquarium",
                language = "JavaScript"
            };

            Exercise CongressionalRep = new Exercise()
            {
                name = "Congressional Representative",
                language = "HTML"
            };

            Exercise Nutshell = new Exercise()
            {
                name = "Nutshell",
                language = "React"
            };

            Exercise Buildings = new Exercise()
            {
                name = "Buildings",
                language = "C#"
            };

            Cohort C35 = new Cohort()
            {
                name = "Cohort 35"
            };

            Cohort C36 = new Cohort()
            {
                name = "Cohort 36"
            };

            Cohort C37 = new Cohort()
            {
                name = "Cohort 37"
            };

            Student Sage = new Student()
            {
                FirstName = "Sage",
                LastName = "Foo",
                SlackHandle = "SageFoo",
                Cohort = "Cohort 35"
            };

            Student RyanB = new Student()
            {
                FirstName = "Ryan",
                LastName = "Bishop",
                SlackHandle = "RyanB",
                Cohort = "Cohort 36"
            };

            Student JohnG = new Student()
            {
                FirstName = "John",
                LastName = "Gilliam",
                SlackHandle = "JG",
                Cohort = "Cohort 37"
            };

            Student SpencerT = new Student()
            {
                FirstName = "Spencer",
                LastName = "Truett",
                SlackHandle = "ST",
                Cohort = "Cohort 37"
            };

            Student SlackerStudent = new Student()
            {
                FirstName = "Slacker",
                LastName = "McGee",
                SlackHandle = "SM",
                Cohort = "Cohort 37"
            };

            C35.AddStudent(Sage);
            C36.AddStudent(RyanB);
            C37.AddStudent(JohnG);
            C37.AddStudent(SpencerT);

            Instructor SteveB = new Instructor()
            {
                FirstName = "Steve",
                LastName = "Brownlee",
                SlackHandle = "choortlehort",
                Specialty = "Dad Jokes",
                Cohort = "Cohort 35"
            };

            Instructor AdamS = new Instructor()
            {
                FirstName = "Adam",
                LastName = "Sheaffer",
                SlackHandle = "AdamS",
                Specialty = "var",
                Cohort = "Cohort 36"
            };

            Instructor Leah = new Instructor()
            {
                FirstName = "Leah",
                LastName = "Hoefling",
                SlackHandle = "LemurLeah",
                Specialty = "Traveling",
                Cohort = "Cohort 37"
            };

            C35.AddInstructor(SteveB);
            C36.AddInstructor(AdamS);
            C37.AddInstructor(Leah);

            SteveB.assignExercise(Sage, MartinsAquarium);
            SteveB.assignExercise(Sage, CongressionalRep);
            SteveB.assignExercise(RyanB, Nutshell);
            SteveB.assignExercise(RyanB, Buildings);
            SteveB.assignExercise(JohnG, MartinsAquarium);
            SteveB.assignExercise(JohnG, Nutshell);
            SteveB.assignExercise(SpencerT, CongressionalRep);
            SteveB.assignExercise(SpencerT, Nutshell);
            SteveB.assignExercise(SpencerT, MartinsAquarium);

            AdamS.assignExercise(Sage, Nutshell);
            AdamS.assignExercise(Sage, Buildings);
            AdamS.assignExercise(RyanB, MartinsAquarium);
            AdamS.assignExercise(RyanB, CongressionalRep);
            AdamS.assignExercise(JohnG, Buildings);
            AdamS.assignExercise(JohnG, CongressionalRep);
            AdamS.assignExercise(SpencerT, Buildings);
            AdamS.assignExercise(SpencerT, MartinsAquarium);

            Leah.assignExercise(Sage, Nutshell);
            Leah.assignExercise(Sage, MartinsAquarium);
            Leah.assignExercise(RyanB, MartinsAquarium);
            Leah.assignExercise(RyanB, Buildings);
            Leah.assignExercise(JohnG, Nutshell);
            Leah.assignExercise(JohnG, Buildings);
            Leah.assignExercise(SpencerT, CongressionalRep);
            Leah.assignExercise(SpencerT, MartinsAquarium);

            List<Student> students = new List<Student>();
            students.Add(Sage);
            students.Add(RyanB);
            students.Add(JohnG);
            students.Add(SpencerT);
            students.Add(SlackerStudent);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(MartinsAquarium);
            exercises.Add(CongressionalRep);
            exercises.Add(Buildings);
            exercises.Add(Nutshell);

            List<Instructor> instructors = new List<Instructor>();
            instructors.Add(SteveB);
            instructors.Add(AdamS);
            instructors.Add(Leah);

            List<Cohort> cohorts = new List<Cohort>();
            cohorts.Add(C35);
            cohorts.Add(C36);
            cohorts.Add(C37);


            // foreach (Exercise exercise in exercises)
            // {
            //     Console.WriteLine($"{exercise.name}:");

            //     foreach (Student student in students)
            //     {
            //         foreach (Exercise studentExercise in student.Exercises)
            //         {
            //             if (exercise.name == studentExercise.name)
            //             {
            //                 Console.WriteLine($"{student.FirstName} {student.LastName}");

            //             }

            //         }

            //     }
            //     Console.WriteLine($"--------------------");

            // }

            // List exercises for the JavaScript language by using the Where() LINQ method.

            // IEnumerable<Exercise> JavaScriptExercises =
            // from exercise in exercises
            // where exercise.language == "JavaScript"
            // select exercise;

            // foreach (Exercise exercise in JavaScriptExercises)
            // {
            //     Console.WriteLine(exercise.name);
            // }

            // IEnumerable<Student> StudentsInCohort37 =
            // from student in students
            // where student.Cohort == "Cohort 37"
            // select student;

            // foreach (Student student in StudentsInCohort37)
            // {
            //     Console.WriteLine(student.FirstName);
            // }

            // IEnumerable<Instructor> InstructorsInCohort37 =
            // from instructor in instructors
            // where instructor.Cohort == "Cohort 37"
            // select instructor;

            // foreach (Instructor instructor in InstructorsInCohort37)
            // {
            //     Console.WriteLine(instructor.FirstName);
            // };

            // IEnumerable<Student> StudentsByLastName =
            // from student in students
            // orderby student.LastName descending
            // select student;

            // foreach (Student student in StudentsByLastName)
            // {
            //     Console.WriteLine(student.LastName);
            // }

            // IEnumerable<Student> StudentsWithoutExercises =
            // from student in students
            // where student.Exercises.Count == 0
            // select student;

            // foreach (Student student in StudentsWithoutExercises)
            // {
            //     Console.WriteLine(student.FirstName);
            // }

            // IEnumerable<Student> StudentWithMostExercises =
            // from student in students
            // orderby student.Exercises.Count() descending
            // select student;

            // var overachiever = StudentWithMostExercises.FirstOrDefault();

            // Console.WriteLine(overachiever.FirstName);

            // IEnumerable<Student> StudentsPerCohort =
            // from

            var studentsPerCohort = students
            .GroupBy(student => student.Cohort)
            .Select(Group =>
            {
                return new CohortReport
                {
                    StudentCount = Group.Count(),
                    CohortName = Group.Key
                };
            });

            foreach (var cohort in studentsPerCohort)
            {
                Console.WriteLine($"{cohort.CohortName} has {cohort.StudentCount}");
            }


        }

        public class CohortReport
        {
            public int StudentCount { get; set; }
            public string CohortName { get; set; }
        }
    }
}