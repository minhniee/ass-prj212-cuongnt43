//namespace Q4
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int sum = 0;
//            int a ;
//            char op = Convert.ToChar(Console.ReadLine());

//            for (int i = 0; i < args.Length; i++)
//            {
//                a = Convert.ToInt32(Console.ReadLine());
//                switch (op)
//                {
//                    case '+':
//                        sum += a;
//                        break;

//                    case '-':
//                        sum -= a;
//                        break;

//                    case '*':
//                        sum *= a;
//                        break;

//                    case '/':
//                        sum /= a;
//                        break;


//                    default:
//                        Console.WriteLine("incorrect!");
//                        break;
//                }

//            }
//            Console.WriteLine(sum);
//            Console.ReadLine();
//        }
//    }
//}
using System;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Usage: [operator] [number1] [number2] ...");
                return;
            }

            char op = args[0][0]; // Assume first argument is the operator
            int sum = Convert.ToInt32(args[1]); // Initialize sum to the first number

            for (int i = 2; i < args.Length; i++) // Start loop from the second number
            {
                int a = Convert.ToInt32(args[i]);
                switch (op)
                {
                    case '+':
                        sum += a;
                        break;

                    case '-':
                        sum -= a;
                        break;

                    case '*':
                        sum *= a;
                        break;

                    case '/':
                        if (a == 0)
                        {
                            Console.WriteLine("Cannot divide by zero!");
                            return;
                        }
                        sum /= a;
                        break;

                    default:
                        Console.WriteLine("Incorrect operator!");
                        return;
                }
            }

            Console.WriteLine($"Result: {sum}");
            Console.ReadLine();
        }
    }
}

