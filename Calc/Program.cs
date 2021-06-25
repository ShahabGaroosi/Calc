using System;

namespace Calc
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userSelection;
            double a, b;

            do
            {
                userSelection = Menu();

                switch (userSelection)
                {
                    case 1:
                        a = GetValue(); b = GetValue();
                        Console.WriteLine(Addition(a, b));
                        break;
                    case 2:
                        a = GetValue(); b = GetValue();
                        Console.WriteLine(Subtraction(a, b));
                        break;
                    case 3:
                        a = GetValue(); b = GetValue();
                        Console.WriteLine(Multiplication(a, b));
                        break;
                    case 4:
                        a = GetValue(); b = GetValue();
                        Console.WriteLine(Division(a, b));
                        break;
                }
            } while (userSelection != 0);
        }

        static int Menu()
        {
            Console.WriteLine("----Menu----");
            Console.WriteLine("1: Addition.");
            Console.WriteLine("2: Subraction.");
            Console.WriteLine("3: Multiplication.");
            Console.WriteLine("4: Division.");
            Console.WriteLine("0: Exit.");

            int userSelection = 0;
            int.TryParse(Console.ReadLine(), out userSelection);

            return userSelection;
        }
        static double GetValue()
        {
            double i;
            while(!Double.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Error: Not a number. Please input a number.");
            }
            return i;
        }
        public static double Addition(double a, double b)
        {
            return a + b;
        }
        public static double Subtraction(double a, double b)
        {
            return a - b;
        }
        public static double Multiplication(double a, double b)
        {
            return a * b;
        }
        public static string Division(double a, double b)
        {
            return (b == 0 ? "Error: Could not divide by zero!" : (a / b).ToString());
        }
        public static double[] Addition(double[,] a)
        {
            return ArrayArithmetic(Addition, a);
        }
        public static double[] Subtraction(double[,] a)
        {
            return ArrayArithmetic(Subtraction, a);
        }

        static double[] ArrayArithmetic(Func<double, double, double> func, double[,] a)
        {
            double[] b = new double[a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                b[i] = func(a[i, 0], a[i, 1]);
            }
            return b;
        }
    }
}