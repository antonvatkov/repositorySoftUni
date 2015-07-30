using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearningSystem
{
    public class SULSTest
    {
        static void Main()
        {
            var oneCurrentStudent = new CurrentStudent("Stefan", "Petkov");
            var oneDropoutStudent = new DropOutStudent("Goro", "Bashev");
            //oneDropoutStudent.Grades.Add(6);
            var oneGraduateStudent = new GraduateStudent("Ivan", "Ivanov");
            var oneJuniorTraner = new JuniorTrainer("Sashka", "Vaseva");
            //oneJuniorTraner.CreateCourse(oneJuniorTraner,"OOP");
            var oneSeniorTrainer = new SeniorTrainer("Martin", "Petrov", new List<string>(new string[] { "C# beginners", "C# Advanced" }));
            //oneSeniorTrainer.Courses.Remove("C# beginners");
            var oneOnsiteStudent = new OnSiteStudent("Ivan", "Petrov", 24);
            var oneOnlineStudent = new OnlineStudent("Lara", "Djakova", "C# Advanced");

            List<Person> learningAcademy = new List<Person>(new Person[]
            {
                oneCurrentStudent,
                oneDropoutStudent,
                oneGraduateStudent,
                oneJuniorTraner,
                oneOnlineStudent,
                oneOnsiteStudent,
                oneSeniorTrainer
            });

            var currentStudents = learningAcademy
                .Where(x => x is CurrentStudent)
                .OrderBy(x => ((Student)x).StudentId)
                .Select(x => x);

            foreach (var currentStudent in currentStudents)
            {
                Console.WriteLine(currentStudent);
            }
            Console.ReadKey();
        }
    }
}




