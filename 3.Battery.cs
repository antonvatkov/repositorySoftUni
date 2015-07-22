using System;

class Battery
{
    private string batteryType;
    private double batteryLife;
    
    public Battery()
    {

    }

    public Battery(string batteryType) :this()
    {
        this.BatteryType = batteryType;
    }

    public Battery(string batteryType, double batteryLife)
        : this(batteryType)
    {
        this.BatteryLife = batteryLife;
    }

    public string BatteryType
    {
        get { return this.batteryType; }
        set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid input! battery");
                }
                value = value.Trim();
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid input for battery");
                }
                this.batteryType = value;
            }
    }

    public double BatteryLife
    {
        get { return this.batteryLife;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("invalid input for batteryLife!");
            }
            if (value == 0)
            {
                throw new ArgumentNullException("invalid input ! batteryLiFee must have value!");
            }
            this.batteryLife = value;
        }
    }

    public override string ToString()
    {
        return string.Format("battery: {0} \n battery life: {1} hours", this.batteryType, this.batteryLife);
    }
}

