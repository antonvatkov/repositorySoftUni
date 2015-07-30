using System;
using System.Collections.Generic;

namespace LearningSystem
{
    public class SeniorTrainer : Trainer
    {
        public SeniorTrainer(string fname, string lname)
            : base(fname, lname)
        {

        }

        public SeniorTrainer(string fname, string lname, List<string> Courses)
            : base(fname, lname, Courses)
        {

        }

        public static void DeleteCourse(SeniorTrainer trainer, string courseName)
        {
            trainer.Courses.Remove(courseName);
            Console.WriteLine(courseName + "was successfully deleted!");
        }
    }
}
