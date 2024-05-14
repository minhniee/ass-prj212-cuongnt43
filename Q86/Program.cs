namespace Q86
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string text;

                text = "Python 3.0";
                Console.WriteLine("Original string:: " + text);

                Console.WriteLine(test(text));

                text = "dsfkaso230samdm2423sa";

                Console.WriteLine("\nOriginal string:: " + text);

                Console.WriteLine(test(text));
            }

            public static string test(string text)
            {
                // Counting the number of letters in the given 'text' using LINQ
                int ctr_letters = text.Count(char.IsLetter);

                // Counting the number of digits in the given 'text' using LINQ
                int ctr_digits = text.Count(char.IsDigit);

                // Returning the count of letters and digits as a string
                return "Number of letters: " + ctr_letters + "  Number of digits: " + ctr_digits;
            }
    }
}
