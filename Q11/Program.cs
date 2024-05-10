namespace Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a <= 0)
            {
                Console.WriteLine($"You look older than {-a}");
            }else
            {
                Console.WriteLine($"You look older than {a}");

            }

            Console.ReadLine();
        }
    }
}
