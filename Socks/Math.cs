using System;
using Socks;

static internal class Math
{
    public static void DoTheMath(double footLength, Size size)
    {
        //how long should the fool knitted foot be
        double SockLength_Mm = footLength / Coefficients.k_length;

        //how many rows do toes and heel take
        double ToesAndHeel_Rows = CountToes(size.start / 4, size.oneNeedle) + size.heel;

        //how many millimeters do toes and heel take
        double ToesAndHeel_Mm = Converters.RowsToMillimeters(ToesAndHeel_Rows);

        //how many millimeters should you knit between toes and heel
        double SockLength_Straight_Mm = SockLength_Mm - ToesAndHeel_Mm;

        //how many rows does it take
        double SockLength_Straight_Rows = Converters.MillimetersToRows(SockLength_Straight_Mm);

        //TODO: better converter
        size.foot = Convert.ToInt32(SockLength_Straight_Rows);
        //TODO: better converter
        size.calf = (int) CountCalf(SockLength_Straight_Rows);
    }

    public static double CountToes(int start, int finish)
    {
        //how many rows it takes to make a toe
        return (finish - start) * 2;
    }

    public static double CountCalf(double footrows)
    {
        return (50 * footrows) / 63;
    }
}