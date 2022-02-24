using System;

namespace VP_lab2
{
    class Program
    {
        public static void Main(string[] args)
        {
            ushort x = 27, y = 13;
            Console.WriteLine("x = " + x + " y = " + y);
            Console.WriteLine("x = " + new RomanNumber(x) + " y = " + new RomanNumber(y));
            Console.WriteLine("x + y = " + RomanNumber.Add(new RomanNumber(x), new RomanNumber(y)));
            Console.WriteLine("x - y = " + RomanNumber.Sub(new RomanNumber(x), new RomanNumber(y)));
            Console.WriteLine("x * y = " + RomanNumber.Mul(new RomanNumber(x), new RomanNumber(y)));
            Console.WriteLine("x / y = " + RomanNumber.Div(new RomanNumber(x), new RomanNumber(y)));

            ushort[] array = new ushort[10];
            RomanNumber[] romanNumberArray = new RomanNumber[10];

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                array[i] = (ushort)(new Random().Next(1, 3999));
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                romanNumberArray[i] = new RomanNumber(array[i]);
                Console.Write(romanNumberArray[i] + " ");
            }
            Console.WriteLine();

            Array.Sort(array);
            Array.Sort(romanNumberArray);

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(romanNumberArray[i] + " ");
            }
            Console.WriteLine();
        }
    }
}