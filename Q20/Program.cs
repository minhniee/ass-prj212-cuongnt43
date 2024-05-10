namespace Q20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine((a - b) * 2);
            }else
            {
                Console.WriteLine(b-a);
            }
            Console.ReadLine();
        }
    }
}
