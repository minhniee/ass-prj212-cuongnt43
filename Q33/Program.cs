namespace Q33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int a = Convert.ToInt32 (Console.ReadLine());

            if (a > 0 && (a %3 ==0 || a % 7 ==0))
            {
                Console.WriteLine("true");
            }else { Console.WriteLine("false"); }
        }
    }
}
