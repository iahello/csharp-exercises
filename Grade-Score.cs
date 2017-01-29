using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program //IAH BUENACOSA WD-301
    {
        static void GradeMethod(char a) {
            switch (a) { 
                case 'A':
                case 'a':
                    Console.WriteLine("Equivalent Score: 90-100");
                    break;
                case 'B':
                case 'b':
                    Console.WriteLine("Equivalent Score: 80-89");
                    break;
                case 'C':

                case 'c':
                    Console.WriteLine("Equivalent Score: 75-79");
                    break;
                case 'D':
                case 'd':
                    Console.WriteLine("Equivalent Score: 74 Below");
                    break;
                default: 
                    Console.WriteLine("INVALID INPUT");
                    break;
            }
        }
        static void Main(string[] args)
        {
            char gradeInput;

            Console.Write("Enter Grade: ");
            gradeInput = char.Parse(Console.ReadLine());

            GradeMethod(gradeInput);
            Console.ReadKey();
        }
    }
}
