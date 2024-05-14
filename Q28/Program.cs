namespace Q29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            FileInfo file = new FileInfo("C:\\Users\\minhl\\OneDrive\\Desktop\\SE 5");
            Console.WriteLine(file.Length.ToString());
        }
    }
}
