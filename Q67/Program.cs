namespace Q67
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine(test("PHP")); // Output: 968
                Console.WriteLine(test("JAVASCRIPT")); // Output: J9781691
            }

            public static string test(string str1)
            {
                return str1.Replace("P", "9").Replace("T", "0").Replace("S", "1").Replace("H", "6").Replace("A", "8");
            }
        }
    }

