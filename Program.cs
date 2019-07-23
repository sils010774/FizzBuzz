using System;

namespace FizzBuzz0704
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 21; i++)
            {
                //%dalījuma zīme bez atlikuma %

                if (i % 5 == 0 && i % 3 == 0)

                {
                    //alternatīva,kā izdrukāt iegūtos lielumus
                    //Console.WriteLine($"{i} FizzBuzz");
                    PrintValue(i, "FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    //Console.WriteLine($"{i} Fizz");
                    PrintValue(i, "Fizz");
                }
                else if (i % 5 == 0)
                {
                    //Console.WriteLine($"{i} Buzz");
                    PrintValue(i, "Buzz");
                }
                else
                {
                    //Console.WriteLine(i);
                    PrintValue(i, "");
                }






            }
        }

        static void PrintValue(int i, string text)
        {
        Console.WriteLine($"{i} {text}");
        }
    }
}
