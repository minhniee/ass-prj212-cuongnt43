﻿using System.Text.RegularExpressions;

namespace Q83
{
    internal class Program
    {
        static void Main(string[] args)
        {
                string text;


                text = "Python";
                Console.WriteLine("Orginal string: " + text);
                Console.WriteLine("After removing all the vowels from the said string: " + test(text));

                text = "C Sharp";
                Console.WriteLine("\nOrginal string: " + text);
                Console.WriteLine("After removing all the vowels from the said string: " + test(text));

                text = "JavaScript";
                Console.WriteLine("\nOrginal string: " + text);
                Console.WriteLine("After removing all the vowels from the said string: " + test(text));
            }

            public static string test(string text)
            {
                return new Regex(@"[aeiouAEIOU]").Replace(text, "");
            }
        }
    }
