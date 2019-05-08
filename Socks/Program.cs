// © 2019 Company name. All rights reserved...

using System;

namespace Socks
{
    internal enum InputLength
    {
        l,
        L,
        Length,
        length,
        д,
        Д
    }

    internal enum InputSize
    {
        s,
        S,
        Size,
        size,
        ы,
        Ы
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //read the input
            Console.WriteLine("Hi! Please type L to enter foot length or S to enter shoe size:");
            var str = Console.ReadLine();

            InputLength inputLength;
            InputSize inputSize;
            var size = new Size();

            if (Enum.IsDefined(typeof(InputLength), str))
            {
                //Use foot length
                var footLength = ReadInput.ReadLength();
                size = DealWithSizes.DetermineTheSize(footLength);
            }
            else if (Enum.IsDefined(typeof(InputSize), str))
            {
                //Use shoe size
                var shoeSize = ReadInput.ReadSize();
                size = DealWithSizes.DetermineTheSize(shoeSize);
            }

            size.heel = size.oneNeedle * 2 / 3;

            Math.DoTheMath(size);

            Console.WriteLine("So. The size is {6}-{7}. You need to start with {0} loops altogether. \n" +
                              "Add the loops until you have {1} on each needle. \n" +
                              "Work {2} rows until you start the heel. \n" +
                              "Make a heel with {3} loops on each side. \n" +
                              "Work {4} rows for calf. Add {8} loops on each needle. Work {5} rows for elastic.\n" +
                              "Good luck!",
                size.start, size.oneNeedle, size.foot, size.heel, size.calf, size.elastic, size.shoe1, size.shoe2,
                size.elasticLoopsToAdd / 4
            );
        }
    }
}