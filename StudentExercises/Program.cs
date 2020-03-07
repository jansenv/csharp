using System;

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
                SlackHandle = "SageFoo"
            };

            Student RyanB = new Student()
            {
                FirstName = "Ryan",
                LastName = "Bishop",
                SlackHandle = "RyanB"
            };

            Student JohnG = new Student()
            {
                FirstName = "John",
                LastName = "Gilliam",
                SlackHandle = "JG"
            };

            Student SpencerT = new Student()
            {
                FirstName = "Spencer",
                LastName = "Truett",
                SlackHandle = "ST"
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
                Specialty = "Dad Jokes"
            };

            Instructor AdamS = new Instructor()
            {
                FirstName = "Adam",
                LastName = "Sheaffer",
                SlackHandle = "AdamS",
                Specialty = "var"
            };

            Instructor Leah = new Instructor()
            {
                FirstName = "Leah",
                LastName = "Hoefling",
                SlackHandle = "LemurLeah",
                Specialty = "Traveling"
            };

            C35.AddInstructor(SteveB);
            C36.AddInstructor(AdamS);
            C37.AddInstructor(Leah);
        }
    }
}
