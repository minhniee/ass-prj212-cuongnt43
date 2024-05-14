namespace Q43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a string : ");

            string str = Console.ReadLine();

            Console.WriteLine(test(str));
        }

        public static bool test(string str)
        {
            var ctr = 0; 

            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('w'))
                    ctr++;

                if (str.Substring(i, 2).Equals("ww") && ctr > 2)
                    return true; 
            }

            return false;
        }
}
