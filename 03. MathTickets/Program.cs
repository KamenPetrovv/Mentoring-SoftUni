using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MathTickets
{
    class Program
    {
        static void Main ( string[] args )
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int peopleInTheGroup = int.Parse(Console.ReadLine());
            int percent = 0;
            if (peopleInTheGroup >=1 && peopleInTheGroup <=4)
            {
                percent = 75;
            }
            else if ( peopleInTheGroup >= 5 && peopleInTheGroup <= 9 )
            {
                percent = 60;
            }
            else if (peopleInTheGroup >= 10 && peopleInTheGroup <= 24)
            {
                percent = 50;
            }
            else if (peopleInTheGroup >= 25 && peopleInTheGroup <= 49)
            {
                percent = 40;
            }
            else if (peopleInTheGroup >= 50)
            {
                percent = 25;
            }
            double moneyLeft = budget - budget*percent/100;
            double moneyNeeded = 0;
            if (category == "VIP")
            {
                moneyNeeded = 499.99*peopleInTheGroup;
            }
            else
            {
                moneyNeeded = 249.99*peopleInTheGroup;
            }

            if (moneyNeeded <= moneyLeft)
            {
                Console.WriteLine("Yes! You have {0:f2} leva left.",moneyLeft - moneyNeeded);
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0:f2} leva.", moneyNeeded - moneyLeft);
            }
        }
    }
}
