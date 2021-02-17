using System;

namespace Debugging_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // System.FormatException


            Console.Write("please enter your age: ");
            var age = int.Parse(Console.ReadLine());

            //---------------------------------------------------------------------------

            ////System.IndexOutOfRangeException
            //int[] arr = new int[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    arr[i] = i;
            //}

            //Console.WriteLine(arr[9]);
            //---------------------------------------------------------------------------



            // DivideByZeroException
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(0);
            //    Console.WriteLine(10 / (i+1));
            //}


            //---------------------------------------------------------------------------

            // Unusual Behavior
            //Console.WriteLine()


            //var userAge = Console.ReadLine();

            //int x = 1;
            //int y = 0;


            //if (x > y)
            //{
            //    Console.WriteLine("X is greater than y");
            //}

        }
    }
}
