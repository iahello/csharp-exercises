using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_program
{
    class Program
    {
        static void Main(string[] args)
        {
            NamedClass input = new NamedClass();
            input.inputNames();

            Console.ReadKey();
        }
    }

    class NamedClass {

        private string [] names = new string[] { "name1", "name2", "name3", "name4", "name5" };

        public void inputNames()
        {   
            var num = 0;

            for (num = 0; num <= 4; num++) {
                Console.WriteLine("Enter name: ");
                names[num] = Console.ReadLine();
            }

            displayNames();
        }

        public void displayNames() {
            Console.WriteLine("The array elements are {0}, {1}, {2}, {3}, {4}", names[0], names[1], names[2], names[3], names[4]);
        }
    }
}
