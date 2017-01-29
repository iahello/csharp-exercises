using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Program
    {

        static void MethodSum() {
            int a, b;

            Console.WriteLine("Addition");

            Console.Write("First Value: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Second Value: ");
            b = int.Parse(Console.ReadLine());

            int total = a + b;

            Console.WriteLine("Total: " + total);
        }

        static void MethodDiff() {
            int a, b;

            Console.WriteLine("Subtraction");

            Console.Write("First Value: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Second Value: ");
            b = int.Parse(Console.ReadLine());

            int total = a - b;

            Console.WriteLine("Total: " + total);
        }

        static void MethodEgg(int numberOfEggs) {
            numberOfEggs = 5;
        }

        static void Main(string[] args)
        {
            MethodSum();
            Console.WriteLine("************************");

            MethodDiff();    
            Console.WriteLine("************************");

            Monogram callName = new Monogram();
            callName.MethodHold();
            Console.WriteLine("");
            Console.WriteLine("************************");

            exponent call = new exponent();
            call.Hehe();
            Console.WriteLine("");
            Console.WriteLine("************************");

            Pizza order = new Pizza();
            order.GetVal();
            Console.WriteLine("");
            Console.WriteLine("************************");


            Console.ReadKey();
        }
    }

    class Monogram
    {
        public void MethodHold()
        {
            string first, middle, last;

            first = "Iah";
            middle = "Magtoto";
            last = "Buenacosa";

            Monogram disp = new Monogram();
            disp.MethodDisplay(first, middle, last);

        }

        public void MethodDisplay(string first, string middle, string last)
        {
            Console.WriteLine("My Name is: " + last + first + middle);
        }

    }

    class exponent
    {
        public void Hehe()
        {
            int a;
            a = 24;

            MethodSquare(a);
        }

        static void MethodSquare(int one) {
            int square = one * one;
            Console.WriteLine("From class exponent");
            Console.Write("Square of 24: " + square);
        }
    }

    class Pizza
    {
        public string topping; int dia; double price;

        public void GetVal() {
            Console.Write("Enter Chosen Topping: ");
            topping = Console.ReadLine();
            Console.Write("Enter Pizza Diameter: ");
            dia = int.Parse(Console.ReadLine());

            price = 13.99;

            Pizza theVal = new Pizza();
            theVal.DisplayVal(topping, dia, price);
        }

        public void DisplayVal(string a, int b, double c) {
            Console.WriteLine("Your Pizza Topping is: {0}, Diameter: {1}, Total Price: {2}", a,b,c);
        }
    }
}
