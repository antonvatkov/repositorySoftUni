using System;

class Component
{
    private string name;
    private string details;
    private decimal price;

    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    public Component(string name, string details, decimal price)
        : this(name, price)
    {
        this.Details = details;
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0.0m)
            {
                throw new ArgumentException("price cannot be negative!");
            }
            if (value == 0.0m)
            {
                throw new ArgumentNullException("price invalid input");
            }
            this.price = value;

        }
    }

    public string Name
    {
        get { return this.name;}
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

    public string Details
    {
        get { return this.details;}
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("invalid input details");
            }
            value = value.Trim();
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("invalid input! details must not be empty!");
            }
            this.details = value; 
        ;} 
    }
}

