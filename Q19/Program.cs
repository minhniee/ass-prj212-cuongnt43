namespace Q19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b) {
                sum = a + b;
            }
            Console.WriteLine(sum * 3);
            Console.ReadKey();
        }
    }
}
