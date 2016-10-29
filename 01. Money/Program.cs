using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main ( string[] args )
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double uians = double.Parse(Console.ReadLine());
            double comissionPercent = double.Parse(Console.ReadLine());

            double leva = bitcoins*1168;
            double dollars = uians*0.15;
            leva += dollars*1.76;
            double euros = leva/1.95;
            double comission = euros*comissionPercent/100;
            double result = euros - comission;
            Console.WriteLine(result);
        }
    }
}
