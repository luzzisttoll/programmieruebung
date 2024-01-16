using System;
using System.Collections.Generic;

namespace StringMirror
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(StringMirrored("bla", "alb"));       //output: 0
            Console.WriteLine(StringMirrored("blebla", "a2balb")); //output: 3
        }

        public static int StringMirrored(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return 0; //länge überprüfen, wenn unterschiedlich --> nicht gespiegelt
            }

            Stack<char> stack = new Stack<char>();


            for (int i = 0; i < str1.Length; i++)
            {
                stack.Push(str1[i]);
            }

        
            for (int i = 0; i < str2.Length; i++)
            {
                if (str2[i] != stack.Pop())
                {
                    return i; //rückgabe der position, ab der sich die string unterscheiden
                }
            }

            return 0; //string sind identisch
        }
    }
}
