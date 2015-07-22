using System;
using System.Collections.Generic;
using System.Linq;

class PcCatalog
{
    static void Main()
    {
        List<Computer> computerCatalog = new List<Computer>();

        int catalogCount = 0;
        bool catalogValidation = false;

        while ((catalogValidation == false) || (catalogCount < 1))
        {
            Console.WriteLine("Please, insert the number of computers in catalog?");
            string temp = Console.ReadLine();
            catalogValidation = int.TryParse(temp, out catalogCount);
            if ((catalogValidation == false) || (catalogCount < 1))
            {
                throw new ArgumentNullException("\n Catalog must have at least one computer! \n");            
            }
        }

        for (int i = 1; i <= catalogCount; i++)
        {
            Console.WriteLine("Please enter the name of the [{0}] computer",i);
            string compName = Console.ReadLine();
            Console.WriteLine("Please enter the number of components of a computer.");
            int numberComponets = int.Parse(Console.ReadLine());
            
            List<Component> components = new List<Component>();

            for (int k = 1; k <= numberComponets; k++)
            {
                Console.WriteLine("Please enter the name of the [{0}] component",k);
                string componentName = Console.ReadLine();
                Console.WriteLine("Please enter the price of the[{0}] component",k);
                decimal componentPrice = decimal.Parse(Console.ReadLine());

                components.Add(new Component(componentName, componentPrice));

            }

            Computer computer = new Computer(compName, components);
            computerCatalog.Add(computer);
        }
        var sortedCatelog = computerCatalog.OrderBy(computer => computer.Price);

        foreach (var computer in sortedCatelog)
        {
            Console.WriteLine(computer);
            Console.ReadKey();
        }
    }
}

