using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndAbstraction
{
    public enum WorkHoursPerDay
    {
        partTime = 4,fullTime = 8
    };

    public class Worker : Human
    {
        private const decimal weekWorkDays = 5M; 
        private decimal weekSalary;
        private WorkHoursPerDay workHours;

        public Worker(string firstName, string lastName, decimal weekSalary, WorkHoursPerDay workHours)
            : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHours = workHours;
        }

        public decimal WeekSalary 
        {
            get { return this.weekSalary;}
            set 
            {
                if ((value == 0)||(value < 0))
                {
                    throw new ArgumentOutOfRangeException("Invalid input salary must be possive and stimilating with a lot of bonuses and private car, phone and few beatifull secretaries :)");
                }
                this.weekSalary = value;
            } 
        }

        public WorkHoursPerDay WorkHours
        {
            get 
                {
                    return this.workHours;
                }
            set
            {
                if (!Enum.IsDefined(typeof(WorkHoursPerDay), value))
                {
                    throw new System.ArgumentException(
                    string.Format("Invalid WorkHoursPerDay state {0}.", value));
                }
                this.workHours = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal hours = (decimal)(this.workHours);
            return (this.weekSalary / (hours * weekWorkDays));
        }

        public override string ToString()
        {
            StringBuilder worker = new StringBuilder();
            worker.Append(base.ToString());

            worker.Append(Environment.NewLine);
            worker.AppendFormat("Week salary: {0}\n" , this.weekSalary);
            worker.AppendFormat("Work hours: {0} hours", this.workHours);
            return worker.ToString();
        }

    }
}
