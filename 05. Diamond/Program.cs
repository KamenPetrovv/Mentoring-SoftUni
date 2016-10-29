using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Diamond
{
    class Program
    {
        static void Main ( string[] args )
        {
            int n = int.Parse (Console.ReadLine ( ));

            for ( int i = 0; i < 3 * n + 2; i++ )
            {
                if ( i < n )
                {
                    if ( i == 0 )
                    {
                        Console.Write (new string ('.', n));
                        Console.Write (new string ('*', 3 * n));
                        Console.Write (new string ('.', n));
                        Console.WriteLine ( );
                    }
                    else
                    {
                        Console.Write (new string ('.', n - i));
                        Console.Write ("*");
                        Console.Write (new string ('.', 3 * n + 2 * i - 2));
                        Console.Write ("*");
                        Console.Write (new string ('.', n - i));
                        Console.WriteLine ( );
                    }
                }
                else if ( i == n )
                {
                    Console.WriteLine (new string ('*', 5 * n));
                }
                else
                {
                    if ( i == 3 * n + 1 )
                    {
                        Console.Write (new string ('.', i - n));
                        Console.Write ("*");
                        Console.Write (new string ('*', 5 * n - ( i - n ) * 2 - 2));
                        Console.Write ("*");
                        Console.Write (new string ('.', i - n));
                        Console.WriteLine ( );
                    }
                    else
                    {
                        Console.Write (new string ('.', i - n));
                        Console.Write ("*");
                        Console.Write (new string ('.', 5 * n - ( i - n ) * 2 - 2));
                        Console.Write ("*");
                        Console.Write (new string ('.', i - n));
                        Console.WriteLine ( );
                    }

                }

            }
        }
    }
}
