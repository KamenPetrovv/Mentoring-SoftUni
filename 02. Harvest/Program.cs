using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main ( string[] args )
        {
            int area = int.Parse(Console.ReadLine());
            double grapeForSqureM = double.Parse(Console.ReadLine());
            int litersNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grapeHarvested = area*grapeForSqureM;
            double wine = grapeHarvested*40/100/2.5;
            if (litersNeeded <= wine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(wine));
                double wineLeft = wine - litersNeeded;
                double litersPerWorker = wineLeft/workers;
                Console.WriteLine("{0} liters left -> {1} liters per person.",Math.Ceiling(wineLeft),Math.Ceiling(litersPerWorker));
            }
            else
            {
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(litersNeeded - wine));
            }
        }
    }
}
