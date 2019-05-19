// � 2019 Company name. All rights reserved...

namespace Socks
{
    internal static class Converters
    {
        public static double RowsToMillimeters(double rows, double sampleHeight, double sampleRows)
        {
            return rows * sampleHeight / sampleRows;
        }

        public static double MillimetersToRows(double millimeters, double sampleHeight, double sampleRows)
        {
            return millimeters * sampleRows / sampleHeight;
        }

        public static double LoopsToMillimeters(double loops, double sampleWidth, double sampleLoops)
        {
            return loops * sampleWidth / sampleLoops;
        }
        
        public static double MillimetersToLoops(double millimeters, double sampleWidth, double sampleLoops)
        {
            return (millimeters * sampleLoops) / sampleWidth;
        }
    }
}