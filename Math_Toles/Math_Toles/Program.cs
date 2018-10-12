using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Toles
{
    class Program
    {
        static void Main(string[] args)
        {

            ulong number;
            string getNumber, rerun;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                getNumber = Console.ReadLine();
                number = ulong.Parse(getNumber);


                for (ulong x = 1; x <= 12; x++)
                {
                    var answer = number * x;
                    Console.WriteLine("{0, -2:0}{1, -2:0}{2, -2:0}", number + " X ", x, " = " + answer);

                }

                Console.Write("Do you wish to continue? Y/N ");
                rerun = Console.ReadLine();

                if (rerun.ToLower() == "n" || rerun.ToLower() == "no")
                {
                   
                        Console.WriteLine("Goodbye");
                    break;
                   
                }               
            }
            Console.ReadKey();
        }
    }
}
