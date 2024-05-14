namespace Q95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "<>()[]{}";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "(<>";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));

            text = "[<>()[]{}]";
            Console.WriteLine("Original string: " + text);
            Console.WriteLine("Verify the said string contains valid parentheses: " + test(text));
        }

        public static bool test(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s.ToCharArray()) {
                if (c == '(')
                    stack.Push(')');
                else if (c == '<') 
                    stack.Push('>');
                else if (c == '[') 
                    stack.Push(']');
                else if (c == '{') 
                    stack.Push('}');
                else if (stack.Count == 0 || stack.Pop() != c) 
                return false;



            }
            return stack.Count == 0;
        }
    }
}
