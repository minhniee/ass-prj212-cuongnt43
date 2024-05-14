namespace Q31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 1,2, 3 };
            int[] sumArr = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                sumArr[i] = arr1[i] * arr2[i];
            }
            foreach (int i in sumArr) {
            Console.WriteLine(i);
            }
        }
    }
}
