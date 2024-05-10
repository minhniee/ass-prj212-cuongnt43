namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Data");
            Console.Write("Enter the number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Expected Output:");
            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine($"{a}*{i}={a*i}");
            }
             Console.ReadLine();
        }
    }
}
