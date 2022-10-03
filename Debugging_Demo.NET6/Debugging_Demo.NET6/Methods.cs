using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging_Demo.NET6;

internal class Methods
{
    private static Random r;

    public int SampleProperty { get; set; }

    public static void DoesSomethingRandom()
    {
        Console.Write("Type something here: ");
        var parsedNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A random number: {r.Next(1, 11)}");
        Console.WriteLine();
    }
}
