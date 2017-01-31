using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm_Lab_Exam_Buenacosa
{
    class Program
    {
        static void Main(string[] args)
        {
            var choice = 'a';
            var exit = 'e';
            do { 
                Console.WriteLine("\nMAIN MENU");
                Console.WriteLine("[S] STACK Class Demo");
                Console.WriteLine("[Q] Queue Class Menu");
                Console.WriteLine("[E] Exit Program");
                Console.Write("Enter Your Choice : ");
                choice = char.Parse(Console.ReadLine());

                switch (choice) { 
                    case 'S':
                    case 's':
                        ClassStack callMenu = new ClassStack();
                        callMenu.StackMenu();
                        break;
                    case 'Q':
                    case 'q':
                        ClassQueue callQMenu = new ClassQueue();
                        callQMenu.QueueMenu();
                        break;
                }
            } while (choice != exit);
            
            Console.ReadKey();
        }
    }

    class ClassStack {
        public Stack haha = new Stack() ;
        public void StackMenu () {
            var Schoice = 0;
            
            do
            {
                Console.WriteLine("\nStack Menu");
                Console.WriteLine("[1] Push an Element");
                Console.WriteLine("[2] Display List");
                Console.WriteLine("[3] Pop an Element");
                Console.WriteLine("[4] Search an Element");
                Console.WriteLine("[5] Quit");
                Console.Write("Enter Your Choice : ");
                Schoice = int.Parse(Console.ReadLine());
            
                switch (Schoice)
                {
                    case 1:
                        StackPush();
                        break;
                    case 2:
                        StackDisplay();
                        break;
                    case 3:
                        StackPop();
                        break;
                    case 4:
                        StackSearch();
                        break;

                }
            } while (Schoice != 5);
        }
        public void StackPush () {
            var elem = "";
            Console.Write("Enter the Element to Add : ");
            elem = Console.ReadLine();
            haha.Push(elem);
            Console.WriteLine("\n{0} has been added to the Stack.", elem);
        }
        public void StackDisplay()
        {
            var elem = "";
            Console.WriteLine("The Stack List is as Follows :");
            foreach (string i in haha) { Console.WriteLine(i); }
        }
        public void StackPop()
        {
            Console.WriteLine("\nelement has been popped from the Stack.");
            haha.Pop();
        }
        public void StackSearch()
        {
            var elem = "";
            Console.Write("Enter the Element you want to Search : ");
            elem = Console.ReadLine();

            if (haha.Contains(elem))
            {
                Console.Write("Element is found");
            }
            else
            {
                Console.Write("Element is not found");
            }
            
        }

    }

    class ClassQueue
    {
        public Queue hehe = new Queue();
        public void QueueMenu() {
            var Qchoice = 0;
            do {
                Console.WriteLine("\nQueue Menu");
                Console.WriteLine("[1] Enqueue an Element");
                Console.WriteLine("[2] Display Queue List");
                Console.WriteLine("[3] Dequeue an Element");
                Console.WriteLine("[4] Search an Element");
                Console.WriteLine("[5] Quit");
                Console.Write("Enter Your Choice : ");
                Qchoice = int.Parse(Console.ReadLine());

                switch (Qchoice)
                {
                    case 1:
                        MethodEnqueue();
                        break;
                    case 2:
                        MethodDisplay();
                        break;
                    case 3:
                        MethodDequeue();
                        break;
                    case 4:
                        MethodSearch();
                        break;
                }
            } while (Qchoice != 5);
        }
        public void MethodEnqueue()
        {
            var elem = "";
            Console.Write("Enter the Element to Add : ");
            elem = Console.ReadLine();
            hehe.Enqueue(elem);
            Console.WriteLine("\n{0} has been added to the Queue.", elem);    
        }
        public void MethodDisplay()
        {
            var elem = "";
            Console.WriteLine("The Stack List is as Follows :");
            foreach (string i in hehe) { Console.WriteLine(i); }
        }
        public void MethodDequeue()
        {
            Console.WriteLine("\nelement has been popped from the Queue.");
            hehe.Dequeue();
        }
        public void MethodSearch()
        {
            var elem = "";
            Console.Write("Enter the Element you want to Search : ");
            elem = Console.ReadLine();

            if (hehe.Contains(elem))
            {
                Console.Write("Element is found");
            }
            else
            {
                Console.Write("Element is not found");
            }
        }
    }
}
