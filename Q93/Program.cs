namespace Q93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int sq = 1;

            while (sq < a/ sq) {

                sq++;
            }

            if(sq > a / sq)
            {
                sq =sq - 1;
            }
            Console.WriteLine(sq);
        }
    }
}
