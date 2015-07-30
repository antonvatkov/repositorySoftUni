using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LearningSystem;

namespace LearningSystem 
{
    public enum Grade
    {
       None=0,Cheater=1,Week=2,Min=3,Good=4,VeryGood=5,Excelent=6
    };

    public class Student : Person 
    {
        public Student(string fname,string lname) : base(fname,lname)
        {
        }
                        
        public string StudentId 
        {
            get 
            {
                return generateStudentId();
            }
        }

        public List<Grade> grades
        {
            get {return new List<Grade>();}
            set {this.grades = value; }
        }

        public string generateStudentId() 
        {
            string Id = Guid.NewGuid().ToString().GetHashCode().ToString("x");
            return Id; 
        }

        public double AverageGrade
        {
            get
            {
                return this.CalcAverageGrade(this);
            }
        }

        public double CalcAverageGrade(Student student)
        {
            int count = 0;
            double average = 0.00d;

            if (student.grades.Count == 0)
            {
                return average;
            }
            else
            {
                foreach (var grade in student.grades)
                {
                    average += (int)grade;
                    count++;
                }

                average = (average / count);
                return average;
            }
        }

        public Grade? grade 
        {
            get {return this.grade ;}
            set {
                if (((int)value < 0) || (((int)value) > 6))
                {
                    throw new ArgumentException("Invalid Input! Grades range is 0-6!");
                }
                this.grade = value;
                } 
        }
        public override string ToString()
        {
            StringBuilder student = new StringBuilder();
            student.Append(base.ToString());
            student.AppendFormat("Student number:" + string.Empty.PadRight(16) + "{0} \n",this.StudentId);
            student.AppendFormat("Average Grade:" + string.Empty.PadRight(17) + "{0} \n",this.AverageGrade.ToString());
            return student.ToString();
        }
    }
}
