namespace Q62
{
    internal class Program
    {
        static void Main(string[] args)
        {
             static string reverse_remove_parentheses(string str)
            {
                int lid = str.LastIndexOf('(');

                if (lid == -1)
                {
                    return str;
                }
                else
                {
                    int rid = str.IndexOf(')', lid);

                    return reverse_remove_parentheses(
                        str.Substring(0, lid) +
                        new string(str.Substring(lid + 1, rid - lid - 1).Reverse().ToArray()) +
                        str.Substring(rid + 1)
                    );
                }
            }

                Console.WriteLine(reverse_remove_parentheses("p(rq)st"));       // Output: prqst
                Console.WriteLine(reverse_remove_parentheses("(p(rq)st)"));     // Output: pqrst
                Console.WriteLine(reverse_remove_parentheses("ab(cd(ef)gh)ij")); // Output: abcefdghij
        }
    }
}
