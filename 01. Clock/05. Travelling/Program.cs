﻿using System;

namespace _05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double expenses = double.Parse(Console.ReadLine());
                double savings = 0;
                while (expenses > savings)
                {
                    savings += double.Parse(Console.ReadLine());

                }

                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
