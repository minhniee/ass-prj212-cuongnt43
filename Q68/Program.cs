namespace Q68
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine(test("PHP Exercises", 'E', 'e')); // Output: 2
                Console.WriteLine(test("Latest News, Breaking News LIVE", 'A', 'a')); // Output: 3
            

             static int test(string str1, char uc, char lc)
            {
                return str1.Split(uc, lc).Length - 1;
            }
    }
}
