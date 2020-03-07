using System.Collections.Generic;

namespace StudentExercises
{
    public class Cohort
    {
        public string name { get; set; }
        public List<Student> StudentCollection = new List<Student>();
        public List<Instructor> InstructorCollection = new List<Instructor>();

        public void AddStudent(Student student)
        {
            StudentCollection.Add(student);
        }

        public void AddInstructor(Instructor instructor)
        {
            InstructorCollection.Add(instructor);
        }
    }
}