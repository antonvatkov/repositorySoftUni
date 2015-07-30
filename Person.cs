using System;
using System.Collections.Generic;
using System.Text;

namespace LearningSystem 
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private byte age;

        public Person(string firstName, string lastName)
            
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Person(string firstName,string lastName,byte age) 
            : this(firstName,lastName)
        {
            this.Age = age;
        }

        public string FirstName  { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        public override string ToString()
        {
            StringBuilder person = new StringBuilder();
            person.AppendFormat("First name:" + string.Empty.PadRight(20) + "{0} \n",this.FirstName); 
            person.AppendFormat("Last name:"+ string.Empty.PadRight(21) + "{0} \n",this.LastName);
            person.AppendFormat("Age: " + string.Empty.PadRight(26) + "{0} \n", this.Age.ToString());
            return person.ToString();
        }
    }
}