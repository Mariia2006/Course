namespace ConsoleApp38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string withoutSpaces = new string(input.Where(i => !char.IsWhiteSpace(i)).ToArray());

            Dictionary<char, int> elem_count = new Dictionary<char, int>();

            foreach (char i in withoutSpaces)
            {
                if (elem_count.ContainsKey(i))
                {
                    elem_count[i]++;
                }
                else
                {
                    elem_count[i] = 1;
                }
            }

            Console.WriteLine("Elements in line:");
            
            foreach (var elem in elem_count)
            {
                Console.WriteLine($"{elem.Key}: {elem.Value}");
            }
        }
    }
}
