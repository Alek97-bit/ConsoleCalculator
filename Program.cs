using System;
using System.Collections.Generic;
using System.Linq;


namespace Calculator
{
    public class Program
    {
        public static void Main()
        {
            double number1 = 0;


            Console.WriteLine("Wpisz numer.");
            number1 = Convert.ToDouble(Console.ReadLine());
            Cal(number1);

        }
        static void Cal(double number1)
        {
            for (int i = 0; i < 10; i++)
            {

                double number2 = 0;
                string symbol;
                Console.WriteLine("Wpisz znak");
                symbol = Console.ReadLine();

                if (symbol == "V" || symbol == "!")
                {
                    if (symbol == "V")
                    {
                        number1 = Math.Sqrt(number1);
                    }
                    else
                      if (symbol == "!")
                    {
                        // int number1 = (int)(number1);
                        for (double t = number1 - 1; t > 0; t--)
                        {
                            number1 = number1 * t;
                        }
                    }
                    Console.WriteLine(Math.Round(number1, 2));
                    Cal(number1);

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

                Console.WriteLine(Math.Round(number1, 2));
            }
            
        }
    }
}

