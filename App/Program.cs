﻿using System;
using Library;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The answer is {new Thing().Get(42)}.");
            Console.WriteLine("Hello World!");

            Console.WriteLine("This line is from the ubuntu client. @@");
	        Console.ReadKey();
        }
    }
}
