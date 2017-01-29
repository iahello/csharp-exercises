using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFirstCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age; 

            Console.Write("Enter Name: ");   
            name = Console.ReadLine();

            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("\n");
            Console.WriteLine("Thank you, " + name);
            Console.ReadKey();
        }
    }
}
