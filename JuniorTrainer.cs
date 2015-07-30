using System;
using System.Collections.Generic;

namespace LearningSystem
{
    public class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string fname, string lname)
            : base(fname, lname)
        {

        }

        public JuniorTrainer(string fname, string lname, List<string> Courses)
            : base(fname, lname, Courses)
        {

        }

        public void CreateCourse(JuniorTrainer juniorTrainer, string name)
        {
            juniorTrainer.Courses.Add(name);
            Console.WriteLine(name + " was successfully created!");
        }
    }
}

