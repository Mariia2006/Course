using System.Diagnostics.Metrics;

namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] numbers = new int[10];
            int rem = int.MinValue;
            int sum = 0;
            int index = 0;

            Console.WriteLine("There are 100 random numbers:");

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                numbers[i] = rand.Next(1, 10);
                Console.Write(numbers[i] + " ");
            }

            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                sum = numbers[i];
                for (int j = 1; j <= 4 && i + 4 <= numbers.Length - 1; j++)
                {
                    sum += numbers[i + j];
                }
                if (rem < sum)
                {
                    rem = sum;
                    index = i;
                }
            }
            Console.WriteLine("Numbers with the largest sum have indexes: ");

            for (int i = index; i < index + 5; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
