﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            double number1 = 0;
            double number2 = 0;
          
            Console.WriteLine("Wpisz numer.");
            number1 = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                string symbol;
                Console.WriteLine("Wpisz znak");
                symbol = Console.ReadLine();

                if (symbol == "V")
                {
                    number1 = Math.Sqrt(number1);
                    Console.WriteLine(Math.Round(number1,2));
                    Console.WriteLine("Wpisz znak");
                    symbol = Console.ReadLine();
                }
                else
                  if (symbol == "!")
                {
                    // int number1 = (int)(number1);
                    for (double t = number1 - 1; t > 0; t--)
                    {
                        number1 = number1 * t;
                    }
                    Console.WriteLine(Math.Round(number1, 2));
                    Console.WriteLine("Wpisz znak");
                    symbol = Console.ReadLine();
                }

                Console.WriteLine("Wpisz numer");
                number2 = Convert.ToDouble(Console.ReadLine());

                if (symbol == "+")
                {
                    number1 = number1 + number2;
                }
                else

                if (symbol == "-")
                {
                    number1 = number1 - number2;
                }
                else

                 if (symbol == "*")
                {
                    number1 = number1 * number2;
                }
                else

                if (symbol == "-")
                {
                    number1 = number1 / number2;
                }
                else

                if (symbol == "^")
                {
                    number1 = Math.Pow(number1, number2);
                }
                else


                if (symbol == "%")
                {
                    number1 = (number1 / number2) * 100;
                }
                else
   
                if (symbol == "C")
                {
                    Main();
                }

                Console.WriteLine(Math.Round(number1,2));

            }
        }
    }
}

