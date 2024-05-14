namespace Q55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(array_adjacent_elements_product(new int[] { 2, 4, 2, 6, 9, 3 }) == 27);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 0, -1, -1, -2 }) == 2);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 6, 1, 12, 3, 1, 4 }) == 36);
            Console.WriteLine(array_adjacent_elements_product(new int[] { 1, 4, 3, 0 }) == 16);
        }

        public static int array_adjacent_elements_product(int[] input_array)
        {
            // Initializing variables
            int array_index = 0;

            // Calculating the product of the first two elements in the array
            int product = input_array[array_index] * input_array[array_index + 1];

            // Moving to the next element in the array
            array_index++;

            // Loop to calculate the maximum product of adjacent elements
            while (array_index + 1 < input_array.Length)
            {
                // Checking if the product of the current adjacent elements is greater than the existing product
                product = ((input_array[array_index] * input_array[array_index + 1]) > product) ?
                           (input_array[array_index] * input_array[array_index + 1]) :
                            product;

                // Moving to the next pair of adjacent elements in the array
                array_index++;
            }

            // Returning the maximum product of adjacent elements in the array
            return product;
        }
    }
}
