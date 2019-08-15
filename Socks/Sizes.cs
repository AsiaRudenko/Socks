using System.Collections.Generic;

namespace Socks
{
    public static class DealWithSizes
    {
        private static List<Size> CreateSizes()
        {
            var sizes = new List<Size>
            {
                new Size
                {
                    footLengthMin = 220,
                    footLengthMax = 233.4,
                    footLength = 226.5,
                    shoe1 = 35,
                    shoe2 = 36,
                    footDiameter = 224,
                    marker = "red"
                },
                new Size
                {
                    footLengthMin = 233.5,
                    footLengthMax = 246.9,
                    footLength = 240,
                    shoe1 = 37,
                    shoe2 = 38,
                    footDiameter = 232,
                    marker = "blue"
                },
                new Size
                {
                    footLengthMin = 247,
                    footLengthMax = 260,
                    footLength = 253.5,
                    shoe1 = 39,
                    shoe2 = 40,
                    footDiameter = 240,
                    marker = "green"
                },
                new Size
                {
                    footLengthMin = 260.1,
                    footLengthMax = 273.5,
                    footLength = 266.5,
                    shoe1 = 41,
                    shoe2 = 42,
                    footDiameter = 262,
                    marker = "yellow"
                },
                new Size
                {
                    footLengthMin = 273.6,
                    footLengthMax = 286.5,
                    footLength = 280,
                    shoe1 = 43,
                    shoe2 = 44,
                    footDiameter = 270,
                    marker = "orange"
                },
                new Size
                {
                    footLengthMin = 286.6,
                    footLengthMax = 300,
                    footLength = 293.5,
                    shoe1 = 45,
                    shoe2 = 46,
                    footDiameter = 278,
                    marker = "pink or violet"
                },
                new Size
                {
                    footLengthMin = 300.1,
                    footLengthMax = 313,
                    footLength = 306,
                    shoe1 = 47,
                    shoe2 = 48,
                    footDiameter = 286,
                    marker = "???"
                }
            };
            
            return sizes;
        }

        public static Size DetermineTheSize(double mm)
        {
            var sizes = CreateSizes();

            foreach (var size in sizes)
                if (mm >= size.footLengthMin && mm <= size.footLengthMax)
                    return size;
            return null;
        }

        public static Size DetermineTheSize(int shoeSize)
        {
            var sizes = CreateSizes();

            foreach (var size in sizes)
                if ((shoeSize == size.shoe1) ^ (shoeSize == size.shoe2))
                    return size;
            return null;
        }
    }
}