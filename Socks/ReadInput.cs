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
    }
}