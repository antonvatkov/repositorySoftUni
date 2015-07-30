using System;
using System.Text;
namespace LearningSystem
{
    public class DropOutStudent : Student
    {
        private string dropReason;

        public DropOutStudent(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public string DropReason { get; set; }

        public void Reapply()
        {
            StringBuilder studentInfo = new StringBuilder();
            Console.WriteLine(string.Empty.PadRight(50) + "Student ifnormation \n" + studentInfo.ToString());
            studentInfo.AppendFormat("Dropout reason:" + this.dropReason.PadRight(50) + "\n");
        }

        public virtual string ToString()
        {
            StringBuilder dropOutStudent = new StringBuilder();
            dropOutStudent.AppendFormat("First name:" + this.FirstName.PadRight(50) + "\n");
            dropOutStudent.AppendFormat("Last name:" + this.LastName.PadRight(50) + "\n");
            dropOutStudent.AppendFormat("Age:" + this.Age.ToString().PadRight(50) + "\n");
            dropOutStudent.AppendFormat("Student number:" + this.StudentId.PadRight(50) + "\n");
            dropOutStudent.AppendFormat("Average Grade:" + this.AverageGrade.ToString().PadRight(50) + "\n");
            dropOutStudent.Append(this.dropReason);
            return dropOutStudent.ToString();
        }
    }
}
