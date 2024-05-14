namespace Q56
{
    internal class Program
    {
        static void Main(string[] args)
        {
             static bool checkPalindrome(string inputString)
            {
                char[] c = inputString.ToCharArray();

                Array.Reverse(c);

                return new string(c).Equals(inputString);
            }

            
                Console.WriteLine(checkPalindrome("aaa"));    // Output: True
                Console.WriteLine(checkPalindrome("abc"));    // Output: False
                Console.WriteLine(checkPalindrome("madam"));  // Output: True
                Console.WriteLine(checkPalindrome("1234"));   // Output: False
            Console.ReadLine();
        }
    }
}
