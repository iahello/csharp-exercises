using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrelimExam_Buenacosa
{
    class Program
    {
        
        static string BonusMethod(int a) // Computes Bonus
        {
            double bonus;

            if (a >=100 && a <= 1000) {
                bonus = a * .10;
                return "\n Your Bonus is 10% of your Salary = " + bonus;
            }
            else if (a >= 1001 && a <= 3000) { 
                bonus = a * .25;
                return "\n Your Bonus is 25% of your Salary = " + bonus;
            }
            else if (a >= 3001 && a <= 5000) {
                bonus = a * .50;
                return "\n Your Bonus is 50% of your Salary = " + bonus;
            }
            else if (a >= 5001 && a <= 10000) {
                bonus = a * .75;
                return "\n Your Bonus is 75% of your Salary = " + bonus;
            }
            else if (a >= 10001) {          
                return "\n Your Bonus is 100% of your Salary = " + a;
            }
            else { return "\n BONUS NOT APPLIED"; }
        }

        static void SalaryDisplay (int b) // Displays Salary
        {
            Console.Write("\n Your salary is: {0}", b);
        }

        static void Main(string[] args) // Gets Input and Computes Salary
        {
            int hr, ratePerHr, salary;

            Console.WriteLine("***** Welcome to Oli Angel Company *****");
            Console.Write("\n Enter Your Rate Per Hour: ");
            ratePerHr = int.Parse(Console.ReadLine());
            Console.Write("\n Enter Hours Worked: ");
            hr = int.Parse(Console.ReadLine());

            salary = ratePerHr * hr;

            SalaryDisplay(salary);
            Console.Write(BonusMethod(salary));

            while ( salary >= 100) {
                Console.Write("\n \n Enter Your Rate Per Hour: ");
                ratePerHr = int.Parse(Console.ReadLine());
                Console.Write("\n Enter Hours Worked: ");
                hr = int.Parse(Console.ReadLine());

                salary = ratePerHr * hr;

                SalaryDisplay(salary);
                Console.Write(BonusMethod(salary));
            }
            
            Console.ReadKey();
        }
    }
}
