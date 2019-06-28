﻿using System;

namespace Socks
{
    internal static class Communicator
    {
        public static void ShowResult(Size size)
        {
            Console.WriteLine("So. The size is {6}-{7}. You need to start with {0} loops altogether. \n" +
                              "Add the loops until you have {1} on each needle. \n" +
                              "Work {2} rows until you start the heel. \n" +
                              "Make a heel with {3} loops on each side. \n" +
                              "Work {4} rows for calf. Add {8} loops on each needle. Work {5} rows for elastic.\n" +
                              "Use a {9} marker. " +
                              "Good luck!",
                size.start, size.oneNeedle, size.footLengthRows, size.heelRows, size.calf, size.elastic, size.shoe1, size.shoe2,
                size.elasticLoopsToAdd / 4, size.marker
            );
        }

        public static void SayHello()
        {
            Console.WriteLine("Hi! Please type L to enter footLengthRows length or S to enter shoe size:");
        }

        public static Size ReadTheSize()
        {
            var str = Console.ReadLine();
            var size = new Size();

            if (Enum.IsDefined(typeof(InputLength), str))
            {
                Console.WriteLine("Please enter the footLengthRows length in mm: ");
                var footLength = Convert.ToDouble(Console.ReadLine());
                size = DealWithSizes.DetermineTheSize(footLength);
            }
            else if (Enum.IsDefined(typeof(InputSize), str))
            {
                Console.WriteLine("Please enter the shoe size (EU): ");
                var shoeSize = Convert.ToInt32(Console.ReadLine());
                size = DealWithSizes.DetermineTheSize(shoeSize);
            }
            else
            {
                Console.WriteLine("Sorry, this isn't valid. Please enter either L or S.");
                ReadTheSize();
            }

            return size;
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