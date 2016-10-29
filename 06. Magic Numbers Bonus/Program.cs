using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Magic_Numbers_Bonus
{
    class Program
    {
        static void Main ( string[] args )
        {
            int n = int.Parse (Console.ReadLine ( ));

            for ( int i = 100000; i < 10000000; i++ )
            {
                int firstDigit = i / 100000;
                int secondDigit = ( i / 10000 ) % 10;
                int thirdDigit = ( i / 1000 ) % 10;
                int fourthDigit = ( i / 100 ) % 10;
                int fifthDigit = ( i / 10 ) % 10;
                int sixthDigit = i % 10;
                int mult = firstDigit * secondDigit * thirdDigit * fourthDigit * fifthDigit * sixthDigit;
                if ( mult == n )
                {
                    Console.Write (i + " ");
                }
            }

        }
    }
}

