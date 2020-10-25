using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** This program does addition, substraction, division and multiplcation ***");

            int keepGoing = 1;
            while (keepGoing == 1)
            {
                double[] numbers = new double[2];
                Console.Write("Please enter your first number: ");
                numbers[0] = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please enter your second number: ");
                numbers[1] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter what operation you want to do from +, -, *, /");
                string doMAth = Console.ReadLine();

                double answer = operation(doMAth, numbers[0], numbers[1]);

                if (answer == 0)
                {
                    Console.WriteLine("You did not choose a valid operation.");
                }
                else
                {
                    Console.WriteLine("You have entered: " + numbers[0] + " " + doMAth + " " + numbers[1] + " = " + answer);
                }

                Console.WriteLine("If you want to calculate anything else, please enter Yes. If you want to exit, enter any button");
                string cont = Console.ReadLine();

                if (cont == "yes" || cont == "Yes")
                {
                    keepGoing = 1;
                }
                else
                {
                    keepGoing = 0;
                }

            }

        }



        static double operation(string condition, double x, double y)
        {
            double result;
            switch (condition)
            {
                case ("+"):
                    result = (x + y);
                    break;
                case ("-"):
                    result = (x - y);
                    break;
                case ("*"):
                    result = (x * y);
                    break;
                case ("/"):
                    result = (x / y);
                    break;
                default:
                    result = 0;
                    break;
            }
            return (result);
        }

        static double Add(double x, double y)
        {
            return (x + y);
        }

        static double Subst(double x, double y)
        {
            return (x - y);
        }

        static double Div(double x, double y)
        {
            return (x / y);
        }

        static double Multip(double x, double y)
        {
            return (x * y);
        }
    }

}

        
