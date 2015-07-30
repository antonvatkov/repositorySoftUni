using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSystem
{
    public class Trainer : Person
    {
        private List<string> courses;

        public Trainer(string fname, string lname)
            : base(fname, lname)
        {
        }

        public Trainer(string fname, string lname, List<string> Courses)
            : this(fname, lname)
        {
            this.Courses = courses;
        }

        public List<string> Courses { get; set; }

        public override string ToString()
        {
            StringBuilder trainer = new StringBuilder();
            int count = 0;
            trainer.Append(base.ToString());

            foreach (var course in this.courses)
            {
                Console.WriteLine("{0}." + course);
                count++;
            }
            return trainer.ToString();
        }
    }
}

