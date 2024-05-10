namespace Q13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Digit: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (i  == 0 || i == a - 1)
                    {
                        Console.Write($"{a}{a}");
                    }
                    else
                    {
                        Console.Write($"{a} ");

                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
