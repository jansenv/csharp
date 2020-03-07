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
        }
    }
}
