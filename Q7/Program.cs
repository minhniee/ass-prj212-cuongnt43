namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Expected Output: ");

            Console.WriteLine($"{a + b}");
            Console.WriteLine($"{a - b}");
            Console.WriteLine($"{a * b}");
            Console.WriteLine($"{a / b}");
            Console.WriteLine($"{a % b}");



            Console.ReadLine();
        }
    }
}
