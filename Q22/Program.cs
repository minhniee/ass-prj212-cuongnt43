namespace Q22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(n - 100) <= 20 || Math.Abs(n - 200) <= 20) {
                Console.WriteLine("True");
            }else
            {
                Console.WriteLine("False");

            }

        }
    }
}
