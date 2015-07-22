using System;

class Person
{
    private string name;
    private int age;
    private string email;

    public Person(string Name,int Age) 
    {
        this.name = Name;
        this.age = Age;
    }
    public Person(string Name,int Age, string Email) : this(Name,Age)
    {
        this.email = Email;
    }

    public string Name 
    {
        get { return this.name;}
        set 
        {
            if (value == null)
            {
                throw new ArgumentNullException("The person must have a name!");
            }
            
            if (value.Trim() == String.Empty)
            {
                throw new ArgumentNullException("The person must have a name!");
            }
            else
            {
                this.name = value;
            }
        }
    }

    public int Age 
    {
        get {return this.age;}
        set 
        {
            if ((value >= 1) || (value <=100))
            {
                throw new ArgumentOutOfRangeException("Age is not correct input");
            }
            else
            {
                this.age = value;
            }
        }
    }

    public string Email
    {
        get { return this.email;}
        set
        {
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match
            (value, @"^([a-zA-Z0-9_\-\.]+)@(?<!hotmail|gmail|yahoo)((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
	        System.Text.RegularExpressions.RegexOptions.IgnoreCase);
        
            // Here we check the Match instance.
	    
            if (match.Success)
	        {
	            this.email = value;
	        }
            else
            {
                throw new ArgumentException("E-mail is not in valid format!");
            }
        }
    }

    public override string ToString()
    {
        return string.Format("Manager name:{0} age:{1} email:{2}", this.Name, this.Age,this.Email);
    }
}

