namespace Q42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");

            string str = Console.ReadLine();

            if (str.Length < 4)
                Console.WriteLine(str.ToUpper());
            else
                Console.WriteLine(str.Substring(0, 4).ToLower() + str.Substring(4, str.Length - 4));
        }
    }
}
