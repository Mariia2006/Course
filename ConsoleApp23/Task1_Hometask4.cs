namespace ConsoleApp2
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
    class UAN
    {
        private List<double> exchange = new List<double> { 0.036, 0.032, 0.15 };

        public double UsdExchange
        {
            get { return exchange[0]; }
            set { exchange[0] = value; }
        }
        public double EurExchange
        {
            get { return exchange[1]; }
            set { exchange[1] = value; }
        }
        public double PlnExchange
        {
            get { return exchange[2]; }
            set { exchange[2] = value; }
        }
        public double Convert(double value)
        {

        }
    }
    internal class Program
    {
        enum Errors
        {
            Wrong_Value = 404,
            Invalid_Value = 505,
        }
        static void showMessage(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static void Line()
        {
            showMessage("-----------------------------------------------------------------", ConsoleColor.Red);
        }
        static string Qualifier(int valuta, double value)
        {
            switch (value)
            {
                case 1:

                    break;
                case 2:
                    break;
                case 3:
                    return UAN uAN = new UAN();
                    break;
                case 4:
                    break;
            }
        }
        static void Main(string[] args)
        {
            int valuta = MessageHelper.getInt("Please, enter from which valute you want to conert. 1 - USD, 2 - EUR, 3 - UAH, 4 - PLN. If you want to close the program press 0");
            if (valuta != 1 && valuta != 2 && valuta != 3 && valuta != 4 && valuta != 0)
            {
                showMessage($"{Errors.Wrong_Value} {(int)Errors.Wrong_Value}", ConsoleColor.Red);
            }
            else if (valuta == 0)
            {

            }
            else
            {
                double value = MessageHelper.getDouble("Please, enter the amount of money you want to convert");
                Qualifier(valuta, value);

            }
        }
    }
}
