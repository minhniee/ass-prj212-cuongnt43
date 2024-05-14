namespace Q76
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Ascii value of 1 is: " + test('1'));
                Console.WriteLine("Ascii value of A is: " + test('A'));
                Console.WriteLine("Ascii value of a is: " + test('a'));
                Console.WriteLine("Ascii value of # is: " + test('#'));
            }

            public static int test(char ch)
            {
                return (int)ch; 
            }
        }
    }
}
