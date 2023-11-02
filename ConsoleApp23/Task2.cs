namespace ConsoleApp30
{
    static class MessageHelper
    {
        public static string getString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public static int getInt(string message)
        {
            return Convert.ToInt32(getString(message));
        }

        public static double getDouble(string message)
        {
            return Convert.ToDouble(getString(message));
        }
    }
    internal class Program
    {
        static double Product(double amount_of_money, double number, double prise)
        {
            double count_money = 0;
            double count_of_number = 0;
            Line(ConsoleColor.Yellow);
            if (amount_of_money > 0)
            {
                for (int i = 0; amount_of_money - count_money >= 0 && count_of_number <= number; i++)
                {
                    count_money += prise;
                    if (amount_of_money - count_money >= 0)
                    {
                        count_of_number++;
                    }
                }
                showMessage($"Amount of products: {count_of_number}\nRest: {amount_of_money - count_of_number * prise}\n", ConsoleColor.White);
            }
            else
            {
                showMessage($"{Errors.WrongValueOfSum} {(int)Errors.WrongValueOfSum}", ConsoleColor.Red);
            }
            return number - count_of_number;
        }
        static void showMessage(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        static void Line(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("---------------------------------------------------");
            Console.ResetColor();
        }
        enum Errors
        {
            WrongValueOfSum = 404,
            WrongValueOfChoise = 505
        }
        static void Main(string[] args)
        {
            double rest = 0;
            bool IsTrue = true;
            do
            {
                var prises = new List<double>() { 12, 52, 70 };
                var numbers = new List<double>() { 34, 56, 12 };
                var products = new List<string>() { $"Soap. Amount: {numbers[0]}, Prise: {prises[0]}\n", $"Toothpaste Amount: {numbers[1]}, Prise: {prises[1]}\n", $"Shampoo Amount: {numbers[2]} , Prise: {prises[2]}\n" };
                showMessage("Products: ", ConsoleColor.Green);
                Line(ConsoleColor.Yellow);
                foreach (var product in products)
                {
                    showMessage(product, ConsoleColor.White);
                }
                Line(ConsoleColor.Yellow);
                int choise = MessageHelper.getInt("Please, choose your product. 1 - Soap, 2 - Toothpaste, 3 - Shampoo. If you want to close the program, press 0, then Enter twise.");
                switch (choise)
                {
                    case 0:
                        showMessage("Closing program...", ConsoleColor.Green);
                        IsTrue = false;
                        break;
                    case 1:
                        rest = Product(MessageHelper.getDouble("Please, choose amount of money."), numbers[0], prises[0]);
                        numbers[0] = rest;
                        break;
                    case 2:
                        rest = Product(MessageHelper.getDouble("Please, choose amount of money."), numbers[1], prises[1]);
                        numbers[1] = rest;
                        break;
                    case 3:
                        rest = Product(MessageHelper.getDouble("Please, choose amount of money."), numbers[2], prises[2]);
                        numbers[2] = rest;
                        break;
                    default:
                        showMessage($"{Errors.WrongValueOfChoise} {(int)Errors.WrongValueOfChoise}", ConsoleColor.Red);
                        break;
                }
            }
            while (IsTrue);
        }
    }
}
