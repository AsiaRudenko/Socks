using System;
using System.Reflection.Metadata.Ecma335;

namespace Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            //read the input
            double footLength = ReadInput.ReadLength();

            //TODO: also add diagnostics from shoesize
            Size size = DealWithSizes.DetermineTheSize(footLength);

            size.heel = (size.oneNeedle * 2) / 3;

            Math.DoTheMath(footLength, size);

            Console.WriteLine("So. The size is {6}-{7}. You need to start with {0} loops altogether. \n" +
                              "Add the loops until you have {1} on each needle. \n" +
                              "Work {2} rows until you start the heel. \n" +
                              "Make a heel with {3} loops on each side. \n" +
                              "Work {4} rows for calf and then {5} rows for elastic.\n" +
                              "Good luck!", 
                size.start, size.oneNeedle, size.foot, size.heel, size.calf, size.elastic, size.shoe1, size.shoe2
            );
        }
    }
}
