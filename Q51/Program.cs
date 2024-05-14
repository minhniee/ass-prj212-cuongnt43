namespace Q51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 5, 7, 8 };

            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));

            var h_val = nums[0];

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > nums[0])
                    h_val = nums[i]; 
            }

            Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val);
        }
    }
}
