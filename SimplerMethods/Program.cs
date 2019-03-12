using System;
using System.Collections.Generic;

namespace SimplerMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var dungBeetle = new Bug("dungBeetle", "OtherName",
                new List<string> { "ibis", "crows", "foxes" },
                new List<string> { "dung", "more dung", "roasted dung", "dung dessert" });

            Console.WriteLine(dungBeetle.PreyList());
            Console.WriteLine(dungBeetle.PredatorList());
            Console.WriteLine(dungBeetle.Eat("crows"));
            Console.WriteLine(dungBeetle.Eat("dung"));
            Console.ReadKey();
        }
    }

}