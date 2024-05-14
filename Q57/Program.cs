namespace Q57
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ] static int adjacent_Elements_Product(int[] input_Array)
            {
                int max = input_Array[0] * input_Array[1];

                for (int x = 1; x <= input_Array.Length - 2; x++)
                {
                    max = Math.Max(max, input_Array[x] * input_Array[x + 1]);
                }

                return max;
            }

                Console.WriteLine(adjacent_Elements_Product(new int[] { 1, -3, 4, -5, 1 })); // Output: 20
                Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, 4, 5, 2 })); // Output: 20
                Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 3, -4, 5, 2 })); // Output: 15
                Console.WriteLine(adjacent_Elements_Product(new int[] { 1, 0, -4, 0, 2 })); // Output: 0
        }
    }
}
