// © 2019 Company name. All rights reserved...

using System;

namespace Socks
{
    public static class ReadInput
    {
        public static double ReadLength()
        {
            Console.WriteLine("Please enter the foot length in mm: ");
            var length = Console.ReadLine();

            return Convert.ToDouble(length);
        }

        public static int ReadSize()
        {
            Console.WriteLine("Please enter the shoe size (EU): ");
            var shoeSize = Console.ReadLine();

            return Convert.ToInt32(shoeSize);
        }

        public static (int sampleWidth, int sampleHeight, int stretchedSampleWidth, int stretchedSampleHeight) ReadSample()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the width of your sample in centimetres:");
            int sampleWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And now the height in centimetres:");
            int sampleHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now please stretch your sample a little bit to imitate it fitting the foot. Measure its width:");
            int stretchedSampleWidth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And height:");
            int stretchedSampleHeight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thanks!");
            Console.WriteLine();
            return (sampleWidth, sampleHeight, stretchedSampleWidth, stretchedSampleHeight);
        }
    }
}