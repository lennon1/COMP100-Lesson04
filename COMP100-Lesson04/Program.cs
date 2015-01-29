using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP100_Lesson04
{
    class Program
    {

        static void Main(string[] args) // This is our first Program
        {
            int myValue = 101;

            Console.WriteLine("My Current Value is: {0}", myValue);
            Console.WriteLine();
            Console.Write("Enter any value: ");
            string newValue = Console.ReadLine();
            Console.WriteLine("You Typed: {0}", newValue);
            Console.WriteLine("I'm adding it to my current value");
            myValue += Convert.ToInt32(newValue);
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine();

            Console.WriteLine("My New Value is: {0}", myValue);

            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to Exit...");
            Console.ReadKey();
             
        }
    }
}
