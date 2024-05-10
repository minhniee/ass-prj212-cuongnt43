namespace Q16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(first_last("w3resource")); 
            Console.WriteLine(first_last("Python")); 
            Console.WriteLine(first_last("x"));
            string a = "w3resource";
            //Console.WriteLine(a.Substring(a.Length-1));
            //Console.WriteLine(a.Substring(1,a.Length - 2));

            //Console.WriteLine(a.Substring(0, 1));


            Console.ReadLine();
        }

        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1)
                : ustr; 
        }
    }
}
