namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the First number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");

            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");

            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the four  number:");

            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The average of {a}, {b}, {c}, {d} is: {(a + b + c + d)/4}");
            Console.ReadLine();
        }
    }
}
