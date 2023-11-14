namespace ConsoleApp23
{
    internal class Program
    {
        static void Line()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------");
            Console.ResetColor();
        }
        static void Error_Or_End(int num_of_er, string text_of_er)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{num_of_er}, {text_of_er}");
            Console.ResetColor();
        }
        static void Sum()
        {
            Console.WriteLine("Sum was chosen. Please, input 2 numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine($"{a} + ({b}) = {a + b}");
            }
            else
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
        }
        static void Subtraction()
        {
            Console.WriteLine("Subtraction was chosen. Please, input 2 numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine($"{a} + {Math.Abs(b)} = {a - b}");
            }
            else
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }
        }
        static void Multiplication()
        {
            Console.WriteLine("Multiplication was chosen. Please, input 2 numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (b < 0)
            {
                Console.WriteLine($"{a} * ({b}) = {a * b}");
            }
            else
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }
        }
        static void Division()
        {
            Console.WriteLine("Division was chosen. Please, input 2 numbers");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (b == 0)
            {
                Error_Or_End(242, "Division by 0!");
            }
            else
            {
                if (b < 0)
                {
                    Console.WriteLine($"{a} / ({b}) = {a / b}");
                }
                else
                {
                    Console.WriteLine($"{a} / {b} = {a / b}");
                }
            }
        }
        static void Square_root()
        {
            Console.WriteLine("Square root was chosen. Please, input 1 number");
            double a = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                Error_Or_End(353, "Square root of a negative number!");
            }
            else
            {
                Console.WriteLine($"{a} ^ 1/2 = {Math.Sqrt(a)}");
            }
        }
        static void Exponentiation()
        {
            Console.WriteLine("Exponentiation was chosen. Please, input 2 numbers (second number is exponent)");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a == 0 && b <= 0)
            {
                Error_Or_End(565, "Value error!");
            }
            else
            {
                Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
            }
        }
        static void Main()
        {
            int num_of_op;
            do
            {
                Console.Write("Please, input number of operation:\n1 - sum\n2 - subtraction\n3 - multiplication\n4 - division\n5 - square root\n6 - exponentiation\n0 - end of program\n");
                Line();
                num_of_op = int.Parse(Console.ReadLine());
                switch (num_of_op)
                {
                    case 0:
                        Line();
                        Error_Or_End(0,"Ending of program... Please, press Enter twice");
                        break;
                    case 1:
                        Line();
                        Sum();
                        Line();
                        break;
                    case 2:
                        Line();
                        Subtraction();
                        Line();
                        break;
                    case 3:
                        Line();
                        Multiplication();
                        Line();
                        break;
                    case 4:
                        Line();
                        Division();
                        Line();
                        break;
                    case 5:
                        Line();
                        Square_root();
                        Line();
                        break;
                    case 6:
                        Line();
                        Exponentiation();
                        Line();
                        break;
                    default:
                        Line();
                        Error_Or_End(676, "Value out of range!");
                        Line();
                        break;
                }
            } while (num_of_op != 0);
            Console.ReadKey();
        }
    }
}
