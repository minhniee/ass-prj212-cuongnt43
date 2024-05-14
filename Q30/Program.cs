namespace Q30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string hexval = "40B";

            Console.WriteLine("Hexadecimal number: " + hexval);

            int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);

            Console.WriteLine(decValue);
        }
    }
}
