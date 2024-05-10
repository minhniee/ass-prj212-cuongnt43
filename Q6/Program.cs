namespace Q6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number to multiply");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the first number to multiply");     
            int b = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Input the first number to multiply");
            int c = Convert.ToInt32(Console.ReadLine());
            int sum = a * b * c;
            Console.WriteLine($"Expected Output:{sum}");
            Console.ReadLine();
        }
    }
}
