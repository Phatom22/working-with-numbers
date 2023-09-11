using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("5+2 = "+5+2);
            Console.WriteLine("5-2 = " +(5-2));
            Console.WriteLine("5*2 = " + (5 * 2));
           
            Console.WriteLine( 5 / 2.0);
            //declaring variables
            int num1 = 2;
            //increamenting  numbers
            num1 = num1 + 1;
            num1 += 1;
            Console.WriteLine("num1 = " + num1);
            int num2 = 2;
            num2++;

            Console.WriteLine(num2);
            //absolute of a number
            Console.WriteLine(Math.Abs(-61));

            //minimunof a number
            Console.WriteLine(Math.Min(5, 9));

            //power of a number
            Console.WriteLine(Math.Pow(5, 3));



            //Freeze cmd
            Console.ReadLine();

        }
    }
}
