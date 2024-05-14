namespace Q91
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "25 Anna False 4/24/2021 11:43:11 AM -112 -34.67";

            string[] arr =  a.Split(' ',StringSplitOptions.None);

            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    Console.WriteLine(Convert.ToInt32(arr[i]));

                }catch (Exception e)
                {
                    continue;
                }

            }

        }
    }
}
