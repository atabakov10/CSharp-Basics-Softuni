﻿using System;

namespace _11._Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {    // Monday-Friday
             //            плод banana  apple orange  grapefruit kiwi    pineapple grapes
             //цена    2.50    1.20    0.85    1.45    2.70    5.50    3.85

            //    Резултатът да се отпечата закръглен с 2 цифри след десетичната точка. При невалиден ден от седмицата или невалидно име на плод да се отпечата "error".
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50;
                        break;
                    case "apple":
                        price = 1.20;
                        break;
                    case "orange":
                        price = 0.85;
                        break;
                    case "grapefruit":
                        price = 1.45;
                        break;
                    case "kiwi":
                        price = 2.70;
                        break;
                    case "pineapple":
                        price = 5.50;
                        break;
                    case "grapes":
                        price = 3.85;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70;
                        break;
                    case "apple":
                        price = 1.25;
                        break;
                    case "orange":
                        price = 0.90;
                        break;
                    case "grapefruit":
                        price = 1.60;
                        break;
                    case "kiwi":
                        price = 3.00;
                        break;
                    case "pineapple":
                        price = 5.60;
                        break;
                    case "grapes":
                        price = 4.20;
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }

            }
            else
            {
                Console.WriteLine("error");

            }
            double total = quantity * price;
            if (price != 0)
            {
                 Console.WriteLine($"{total:f2}");
            }
            
        }
        
       
        
    }
}
//плод banana	apple	orange	grapefruit	kiwi	pineapple	grapes
//цена	2.70	1.25	0.90	1.60	3.00	5.60	4.20
