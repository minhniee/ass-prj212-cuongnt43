namespace Q21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == 20 || b ==20 || a+b ==20)
            {
                Console.WriteLine("True");
            }else {
                Console.WriteLine("False");

            }
            Console.ReadLine();
        }
    }
}
