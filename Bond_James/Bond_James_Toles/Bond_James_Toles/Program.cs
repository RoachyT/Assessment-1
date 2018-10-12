using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bond_James_Toles
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your First name?");
            var firstName = Console.ReadLine();
            Console.WriteLine("What is your Last name?");
            var lastName = Console.ReadLine();

            Console.WriteLine(lastName + " " + firstName);
            Console.ReadKey();
        }
    }
}
