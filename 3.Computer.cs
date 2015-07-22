using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

class Computer
{
    private string name;
    private List<Component> components;

    public Computer(string name , List<Component> components)
    {
        this.Name = name;
        this.Components = components;
    }

    public string Name 
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("invalid input name");
            }
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("invalid input! name must not be empty!");
            }
            this.name = value;
        } 
    }

    public List<Component> Components
    {
        get { return this.components; }
        set
        {
            if (value.Count == 0)
            {
                throw new ArgumentException("invalid input! name must not be empty!");
            }
            this.components = value;
        } 
    }

    public decimal Price
    {
        get
        {
            return ComputerPrice(this);
        }
    }

    public decimal ComputerPrice(Computer computer)
    {
        var components = computer.Components;
        decimal totalSum = components.Sum(component => component.Price);

        return totalSum;
    }

    public override string ToString()
    {
        StringBuilder classObjectComputer = new StringBuilder(); 
        classObjectComputer.AppendFormat(string.Format("Computer name: {0}\n",this.name));
        string title = "Specification";
        Console.WriteLine(title.PadRight(50) + "\n");
        foreach (var component in components)
	    {
		    classObjectComputer.AppendLine(string.Format("Component name: {0}\n Component price: {1}\n Details: {2}\n",
            component.Name,component.Price,string.IsNullOrWhiteSpace(component.Details)
            ? "none" : component.Details));
	    }
        string total = "TOTAL: ";
        string totalPrice = this.Price.ToString("C", CultureInfo.CreateSpecificCulture("bg-BG"));
        classObjectComputer.Append(total);
        classObjectComputer.Append(string.Empty.PadRight(25));
        classObjectComputer.Append(totalPrice);
        
        return classObjectComputer.ToString();
    }
}

