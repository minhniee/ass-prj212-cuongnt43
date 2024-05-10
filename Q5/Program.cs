namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swaping");
            Console.WriteLine($"First Number:{a}");
            Console.WriteLine($"Second Number:{b}");



            Console.ReadLine();
        }
    }
}
