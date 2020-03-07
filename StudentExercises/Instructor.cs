using System.Collections.Generic;

namespace StudentExercises
{
    public class Instructor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SlackHandle { get; set; }
        public string Cohort { get; set; }
        public string Specialty { get; set; }

        public void assignExercise(Student student, Exercise singleExercise)
        {
            student.Exercises.Add(singleExercise);
        }
    }
}