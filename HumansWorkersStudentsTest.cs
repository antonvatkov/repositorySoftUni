using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction
{
    public class HumansWorkersStudentsTest
    {
        static void Main()
        {
            Student petar = new Student("Petar", "Stefanov");
            Student gosho = new Student("Georgi", "Stefanov");
            Student maria = new Student("Maria", "Savova");
            Student petia = new Student("Petia", "Mihailova");
            Student martin = new Student("Martin", "Karbovski");
            Student eva = new Student("Eva", "Stefanova");
            Student pavel = new Student("Pavel", "Stefanov");
            Student mario = new Student("Super", "Mario");
            Student vladimir = new Student("Vladimir", "Vazov");
            Student evelina = new Student("Elelina", "Mitreva");

            Worker petarJ = new Worker("Petar", "Jechev", 200M, WorkHoursPerDay.fullTime);
            Worker goshoS = new Worker("Georgi", "Simov", 300M, WorkHoursPerDay.fullTime);
            Worker mariaS = new Worker("Maria", "Simova", 250M, WorkHoursPerDay.fullTime);
            Worker petiaM = new Worker("Petia", "Maneva",280M,WorkHoursPerDay.fullTime);
            Worker martinK = new Worker("Martin", "Kirilov", 600M, WorkHoursPerDay.fullTime);
            Worker evaS = new Worker("Eva", "Savova", 400M, WorkHoursPerDay.fullTime);
            Worker pavelD = new Worker("Pavel", "Dimitrov", 400M, WorkHoursPerDay.fullTime);
            Worker luiji = new Worker("Super", "Luiji",1000M,WorkHoursPerDay.fullTime);
            Worker vlado = new Worker("Vlado", "Berian", 100M, WorkHoursPerDay.partTime);
            Worker evelinaK = new Worker("Elelina", "Kikerezova", 150, WorkHoursPerDay.partTime);

            List<Student> course = new List<Student>
                (new Student[] 
                    {
                        petar,
                        gosho,
                        maria,
                        petia,
                        martin,
                        eva,
                        pavel,
                        mario,
                        vladimir,
                        evelina
                    });

            List<Worker> workGroup = new List<Worker>
                (new Worker[] 
                    {
                        petarJ,
                        goshoS,
                        mariaS,
                        petiaM,
                        martinK,
                        evaS,
                        pavelD,
                        luiji,
                        vlado,
                        evelinaK
                    });

            var sortedStudents = from student in course
                                orderby student.FacultyNumber ascending
                                select student;

            var sortedWorkers = from worker in workGroup
                                orderby worker.MoneyPerHour() descending
                                select worker;


            var mixedHumans = new List<Human>();
            var murged = mixedHumans.Concat(sortedStudents).Concat(sortedWorkers).ToList();

            var sortedMurged = from human in murged
                               orderby human.FirstName ascending
                               orderby human.LastName ascending
                               select human;



            foreach (var human in sortedMurged)
            {
                Console.WriteLine(human);
            }

        }
    }
}
