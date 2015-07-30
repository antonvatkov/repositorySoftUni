using System;
using System.Text;

namespace LearningSystem
{
    public class CurrentStudent : Student
    {
        private string currentCourse;


        public CurrentStudent(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public CurrentStudent(string firstName, string lastName, string currentCourse)
            : this(firstName, lastName)
        {
            this.CurrentCourse = currentCourse;
        }

        public string  CurrentCourse { get; set; }
        //public string CurrentCourse 
        //{
        //    get 
        //    {
        //        if (CurrentCourse == string.Empty)
        //        {
        //            return "None";
        //        }
        //        else
        //        {
        //            return this.currentCourse;
        //        };
        //    }
        //    set 
        //    {
        //        if (CurrentCourse != string.Empty)
        //        {
        //            this.currentCourse = value;
        //        }
        //        this.currentCourse = "None";
        //    } 
        //}


        public override string ToString()
        {
            StringBuilder currentStudent = new StringBuilder();
            currentStudent.Append(base.ToString());
            //currentStudent.Append("Current Course:" + this.currentCourse.PadRight(150) + "\n");
            return currentStudent.ToString();
        }
    }
}
