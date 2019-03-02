namespace Socks
{
    internal static class Converters
    {
        public static double RowsToMillimeters(double rows)
        {
            return (rows * 120) / 40;
        }

        public static double MillimetersToRows(double millimeters)
        {
            return (millimeters * 40) / 120;
        }
    }
}