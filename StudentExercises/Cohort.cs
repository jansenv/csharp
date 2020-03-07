using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string name { get; set; }
        public List<Student> StudentCollection = new List<Student>();
        public List<Instructor> InstructorsInCohort = new List<Instructor>();

        public void AddStudent(Student student)
        {
            StudentCollection.Add(student);
        }
    }
}