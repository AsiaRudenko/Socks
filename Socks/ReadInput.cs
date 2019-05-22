// © 2019 Company name. All rights reserved...

using System;

namespace Socks
{
    public static class ReadInput
    {
        public static double ReadLength()
        {
            Console.WriteLine("Please enter the footLengthRows length in mm: ");
            var length = Console.ReadLine();

            return Convert.ToDouble(length);
        }

        public static int ReadSize()
        {
            Console.WriteLine("Please enter the shoe size (EU): ");
            var shoeSize = Console.ReadLine();

            return Convert.ToInt32(shoeSize);
        }

        public static Sample ReadSample()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter the width of your sample in millimetres:");
            double sampleWidth = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("How many loops are there:");
            int sampleLoops = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("And now the height in millimetres:");
            double sampleHeight = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("How many rows are there:");
            int sampleRows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now please stretch your sample a little bit to imitate it fitting the footLengthRows. Measure its width:");
            double stretchedSampleWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("And height:");
            double stretchedSampleHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Thanks!");
            Console.WriteLine();
            
            Sample mySample = new Sample(sampleLoops, sampleRows, sampleWidth, sampleHeight, stretchedSampleWidth, stretchedSampleHeight);

            return mySample;
        }
    }
}