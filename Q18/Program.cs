namespace Q18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first integer:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");

            int b = Convert.ToInt32(Console.ReadLine());

            if ((a > 0 && b >0)  || (a < 0 && b <0))
            {
                Console.WriteLine("False");
            }else
            {
                Console.WriteLine("True");
            }
            Console.ReadLine();
        }
    }
}
