namespace _26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("\nSum of the first 500 prime numbers: "); // Displaying a message

            int sum = 0; // Initializing a variable to hold the sum of prime numbers
            int ctr = 0; // Initializing a counter to count the prime numbers
            int n = 2; // Starting from the first prime number

            // Loop to find and sum the first 500 prime numbers
            while (ctr < 500)
            {
                if (isPrime(n)) // Checking if 'n' is a prime number by calling the 'isPrime' method
                {
                    sum += n; // Adding the prime number 'n' to the sum
                    ctr++; // Incrementing the counter of prime numbers found
                }
                n++; // Moving to the next number for evaluation
            }

            Console.WriteLine(sum);
        }

        public static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1 )  return false ;
            if (n == 2) return true ;

            for (int i = 2; i <= x  ; ++i) {
            if ( n % i ==0  )  return false ;

            }
            return true;
        }

    }


}
