using System;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private byte? ram;
    private string hdd;
    private string graphicsCard;
    private string screen;
    private Battery battery;
    private decimal price;

    public Laptop(string model,decimal price)
    {
        this.Model = model;
        this.Price = price;
    }

    public Laptop(string model, string manufacturer, string processor, byte? ram,string hdd,
    string graphicsCard,string screen,Battery battery, decimal price)
    : this(model, price)
    {
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.Hdd = hdd;
        this.GraphicsCard = graphicsCard;
        this.Screen = screen;
        this.Battery = new Battery();
    }

    public string Model
    {
        get { return this.model;}
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Invalid input! model");
            }
            value = value.Trim();
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input for model");
            }
            this.model = value;
        }
    }
    
    public decimal Price
    {
        get {return this.price;}
        set 
        {
            this.price = value;
        }
    }

    public string Manufacturer 
    {
        get { return this.manufacturer;}
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Invalid input! manufacturer");
            }
            value = value.Trim();
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input for manufacturer");
            }
            this.manufacturer = value;
        } 
    }

    public string Processor
    {
        get { return this.processor;}
        set 
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Invalid input! processor");
            }
            value = value.Trim();
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input for processor");
            }
            this.processor = value;
        }
    }

    public byte? Ram
    {
        get { return this.ram;}
        set 
        {
            if (value < 0)
            {
                throw new ArgumentException("ram has to be possitive value!");
            }
            if (value == 0)
            {
                throw new ArgumentNullException("ram invalid input!");
            }
            if (value > 128)
            {
                throw new ArgumentException("ram invalid input out of range!");
            }
            this.ram = value;
        }
    }
    
    public  string Hdd 
    { 
        get {return this.hdd;}
        set 
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Invalid input! hdd");
            }
            value = value.Trim();
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input for hdd");
            }
            this.hdd = value;
        } 
    }

    public string GraphicsCard
    {
        get { return this.graphicsCard;}
        set 
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Invalid input! graphicsCard");
            }
            value = value.Trim();
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input for graphicsCard");
            }
            this.graphicsCard = value;
        }
    }

    public string Screen
    {
        get { return this.screen;}
        set 
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Invalid input! screen");
            }
            value = value.Trim();
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid input for screen");
            }
            this.screen = value;
        }
    }

    public Battery Battery { get; set; }

    public override string ToString()
    {
        return string.Format(" model: {0} \n manufacturer: {1} \n processor: {2} \n RAM: {3} GB \n graphics card: {4} \n HDD: {5} \n screen: {6} \n {7} \n price: {8} lv.",
        this.model, this.manufacturer, this.processor, this.ram, this.graphicsCard, this.hdd, this.screen, this.Battery, this.price);
    }
}

