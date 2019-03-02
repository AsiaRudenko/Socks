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
    }
}