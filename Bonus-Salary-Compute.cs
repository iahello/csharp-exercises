using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bonusSalary
{
    class Program //IAH BUENACOSA WD-301
    {
        static string BonusMethod(int a)
        {
            switch (a)
            {
                case 1: 
                    return "Bonus Amount: 50% of Monthly Salary";
                case 2:
                    return "Bonus Amount: 100% of Monthly Salary";
                case 3:
                    return "Bonus Amount: 200% of Monthly Salary";
                default:
                    return "INVALID INPUT";
            }
        }
        static void Main(string[] args)
        {
            
            int clazz=0;
            Console.WriteLine("R2R2 Inc. Christmas Bonus"); 
            while (clazz < 4) {
                Console.Write("Enter Class Level: ");
                clazz = int.Parse(Console.ReadLine());
                Console.WriteLine(BonusMethod(clazz));
            }
            Console.ReadKey();
        }
    }
}
