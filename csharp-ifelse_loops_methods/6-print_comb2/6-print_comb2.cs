﻿using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    Console.Write($"{i}{j}");

                    if (i != 8 || j != 9) // Check if it's not the last number pair
                    {
                        Console.Write(", ");
                    }
                }
            }

            Console.WriteLine();
        }
    
    }
}
