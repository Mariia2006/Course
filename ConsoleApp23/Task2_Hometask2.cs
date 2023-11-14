namespace ConsoleApp24
{
    internal class Program
    {
        static void Line()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------------");
            Console.ResetColor();
        }
        static void Error_Or_End(int number_of_er, string text_of_er)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{number_of_er}, {text_of_er}");
            Console.ResetColor();
        }
        static void Celsius_Fahrenheit()
        {
            Console.Write("Please, input value\nCelsius: ");
            double a = double.Parse(Console.ReadLine());
            if (a >= -273)
            {
                Console.WriteLine($"{a} -> {1.8 * a + 32}");
            }
            else
            {
                Error_Or_End(202, "The temperature limit has been crossed!");
            }
        }
        static void Celsius_Kelvin()
        {
            Console.Write("Please, input value\nCelsius: ");
            double a = double.Parse(Console.ReadLine());
            if (a >= -273)
            {
                Console.WriteLine($"{a} -> {a + 273.15}");
            }
            else
            {
                Error_Or_End(303, "The temperature limit has been crossed!");
            }
        }
        static void Fahrenheit_Celsius()
        {
            Console.Write("Please, input value\nFahrenheit: ");
            double a = double.Parse(Console.ReadLine());
            if (a >= -459.67)
            {
                Console.WriteLine($"{a} -> {(a - 32) / 1.8}");
            }
            else
            {
                Error_Or_End(101, "The temperature limit has been crossed!");
            }
        }
        static void Fahrenheit_Kelvin()
        {
            Console.Write("Please, input value\nFahrenheit: ");
            double a = double.Parse(Console.ReadLine());
            if (a >= -459.67)
            {
                Console.WriteLine($"{a} -> {(a - 32) / 1.8 + 273.15}");
            }
            else
            {
                Error_Or_End(404, "The temperature limit has been crossed!");
            }
        }
        static void Kelvin_Celsius()
        {
            Console.Write("Please, input value\nKelvin: ");
            double a = double.Parse(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine($"{a} -> {a - 273.15}");
            }
            else
            {
                Error_Or_End(505, "The temperature limit has been crossed!");
            }
        }
        static void Kelvin_Fahrenheit()
        {
            Console.Write("Please, input value\nKelvin: ");
            double a = double.Parse(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine($"{a} -> {1.8 * (a - 273.15) + 32}");
            }
            else
            {
                Error_Or_End(606, "The temperature limit has been crossed!");
            }
        }
        static void Main(string[] args)
        {
            int number_of_input;
            do
            {
                Console.WriteLine("Please, choose from which to which unit of measurement you want to convert\n1 - Celsius -> Fahrenheit\n2 - Celsius -> Kelvin\n3 - Fahrenheit -> Celsius\n4 - Fahrenheit -> Kelvin\n5 - Kelvin -> Celsius\n6 - Kelvin -> Fahrenheit");
                Line();
                number_of_input = int.Parse(Console.ReadLine());
                Line();
                switch(number_of_input)
                {
                    case 1:
                        Celsius_Fahrenheit();
                        Line();
                        break;
                    case 2:
                        Celsius_Kelvin();
                        Line();
                        break;
                    case 3:
                        Fahrenheit_Celsius();
                        Line();
                        break;
                    case 4:
                        Fahrenheit_Kelvin();
                        Line();
                        break;
                    case 5:
                        Kelvin_Celsius();
                        Line();
                        break;
                    case 6:
                        Kelvin_Fahrenheit();
                        Line();
                        break;
                    case 0:
                        Error_Or_End(0, "Ending of program... Please, press Enter twice");
                        break;
                    default:
                        Error_Or_End(707, "Incorrect value!");
                        Line();
                        break;
                }
            } 
            while (number_of_input != 0 );
            Console.ReadKey();
        }
    }
}
