using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Debugging_Demo
{
    class Program
    {
        private static List<int> myList;

        static void Main(string[] args)
        {
            PrintNums();
        }

        public static void PrintNums()
        {            
            var a = 0;
            var b = 0;
            //myList.Add(a);
            //myList.Add(b);
            var answer = a / b;
            Console.WriteLine(answer);
        }

    }
}
