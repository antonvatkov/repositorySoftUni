using System;
using System.Text;

namespace LearningSystem
{
    public class OnSiteStudent : CurrentStudent
    {
        private int numberOfVisits;

        public OnSiteStudent(string firstName, string lastName, int numberOfVisits)
            : base(firstName,lastName)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits { get; set; }

        public override string ToString()
        {
            StringBuilder onSiteStudent = new StringBuilder();
            onSiteStudent.Append(base.ToString());
            onSiteStudent.AppendFormat("Number of visits:" + string.Empty.PadRight(15) + "{0} \n", this.numberOfVisits);
            return onSiteStudent.ToString();
        }
    }
}

