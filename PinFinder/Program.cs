using System;
using System.Linq;

namespace PinFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pin = { 0, 3, 5, 9 };
            int[] generatedPin = FindPin(pin);
            foreach(int i in generatedPin)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] FindPin(int[] pin)
        {
            int[] numberPadKeys = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            bool findingPin = true;

            int[] generatedPin = new int[4];

            while (findingPin)
            {
                Random rnd = new Random();

                generatedPin[0] = rnd.Next(0, 10);
                generatedPin[1] = rnd.Next(0, 10);
                generatedPin[2] = rnd.Next(0, 10);
                generatedPin[3] = rnd.Next(0, 10);

                if (generatedPin.SequenceEqual(pin))
                    findingPin = false;
                
            }

            return generatedPin;
        }
    }
}
