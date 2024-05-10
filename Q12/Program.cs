namespace Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Digit: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write($"{a} ");
                    }
                    else
                    {
                        Console.Write($"{a}");

                    }
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
