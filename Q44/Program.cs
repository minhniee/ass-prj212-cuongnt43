namespace Q44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string : ");

            string str = Console.ReadLine();

            var result = string.Empty;

            for (var i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                    result += str[i];
            }
            Console.WriteLine(result);
        }
    }
}
