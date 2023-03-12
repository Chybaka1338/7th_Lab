using System;
using System.Collections.Generic;

namespace _7th_Lab
{
    internal class Program
    {
        static int seed = DateTime.Now.Millisecond;
        static Random r = new Random(seed);

        static void Main(string[] args)
        {
            
            Person per = new Student("");
            Console.WriteLine(per.GetType());
            if ( == per.GetType())
            {
                Console.WriteLine("true");
            }
            Console.ReadKey();
        }

    }
}
