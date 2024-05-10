namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Result of specified numbers {a}, {b} and {c}, (x+y).z is {(a+b)*c} and x.y + y.z is {a*b + b*c}");


            Console.ReadLine();
        }
    }
}
