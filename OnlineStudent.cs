using System;
using System.Text;

namespace LearningSystem
{
    class OnlineStudent : CurrentStudent
    {
        public OnlineStudent(string firstName, string lastName)
            : base(firstName, lastName)
        {

        }

        public OnlineStudent(string firstName, string lastName, string currentCourse)
            : base(firstName, lastName, currentCourse)
        {

        }

        public override string ToString()
        {
            StringBuilder onlineStudent = new StringBuilder();
            onlineStudent.Append(base.ToString());
            return onlineStudent.ToString();
        }
    }
}

