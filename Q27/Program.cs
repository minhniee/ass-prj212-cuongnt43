namespace Q27
{
    internal class Program
    {
        public static void Main()
        {
            string line = "Display the pattern like pyramid using the alphabet.";
            Console.WriteLine("\nOriginal String: " + line); // Displaying the original string

            string result = "";

            List<string> list = new List<string>();

            string[] word = line.Split(new[] { " " }, StringSplitOptions.None);

            for (int i = word.Length-1; i > 0; i--)
            {
                result += word[i] + " ";
            }

            list.Add(result);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
