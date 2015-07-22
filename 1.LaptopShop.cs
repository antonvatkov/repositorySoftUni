using System;

class Program
{
    static void Main()
    {
        var myLaptop = new Laptop("Samsung NP300", 849m);
        Console.WriteLine(myLaptop);
        Console.ReadKey();

        var dreamLaptop = new Laptop("Yoga 2 Pro","IBM", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",8,"240 GB SSD","ATI Radeon 870 3GB DDR5 1024 bit","48`Samsung LED 3D SMART TV",new Battery("Li-Ion, 6-cells, 4500 mAh",4.5d),1800m);
        Console.WriteLine(dreamLaptop);
        Console.ReadKey();
    }
}

