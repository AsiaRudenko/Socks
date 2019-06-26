// © 2019 Company name. All rights reserved...

using System;

namespace Socks
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //read the input
            Console.WriteLine("Hi! Please type L to enter footLengthRows length or S to enter shoe size:");
            var str = Console.ReadLine();

            var size = new Size();

            if (Enum.IsDefined(typeof(InputLength), str))
            {
                //Use footLengthRows length
                var footLength = ReadInput.ReadLength();
                size = DealWithSizes.DetermineTheSize(footLength);
            }
            else if (Enum.IsDefined(typeof(InputSize), str))
            {
                //Use shoe size
                var shoeSize = ReadInput.ReadSize();
                size = DealWithSizes.DetermineTheSize(shoeSize);
            }

            //compute the coefficients
            //Sample sample = ReadInput.ReadSample();

            //HARDCODED FOR MY CURRENT SAMPLE
            Sample sample = new Sample(22, 31, 75, 77, 95, 95);

            Math.DoTheMath(size, sample);

            Console.WriteLine("So. The size is {6}-{7}. You need to start with {0} loops altogether. \n" +
                              "Add the loops until you have {1} on each needle. \n" +
                              "Work {2} rows until you start the heel. \n" +
                              "Make a heel with {3} loops on each side. \n" +
                              "Work {4} rows for calf. Add {8} loops on each needle. Work {5} rows for elastic.\n" +
                              "Use a {9} marker. "+
                              "Good luck!",
                size.start, size.oneNeedle, size.footLengthRows, size.heelRows, size.calf, size.elastic, size.shoe1, size.shoe2,
                size.elasticLoopsToAdd / 4, size.marker
            );
        }
    }
}