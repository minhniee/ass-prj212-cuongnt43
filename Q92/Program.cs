namespace Q92
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(test(35));
        }

        public static int test(int n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    n++;
                    i = 2;
                }
            }
            return n;
        }
    }
}
