// © 2019 Company name. All rights reserved...

using System;
using Socks;

internal static class Math
{
    public static void DoTheMath(Size size)
    {
        //compute the coefficients
        var sample = ReadInput.ReadSample();
        Coefficients myCoefficients = new Coefficients(sample.sampleWidth, sample.sampleHeight, sample.stretchedSampleWidth, sample.sampleHeight);

        //how long should the knitted foot be
        var SockLength_Mm = size.footLength / myCoefficients.K_height;

        //TODO: add foot width to the hardcoded data
        //TODO: compute the width
        //TODO: compute start based on width
        //TODO: apply coefficient to the width

        //how many rows do toes and heel take
        var ToesAndHeel_Rows = CountToes(size.start / 4, size.oneNeedle) + size.heel;

        //how many millimeters do toes and heel take
        var ToesAndHeel_Mm = Converters.RowsToMillimeters(ToesAndHeel_Rows);

        //how many millimeters should you knit between toes and heel
        var SockLength_Straight_Mm = SockLength_Mm - ToesAndHeel_Mm;

        //how many rows does it take
        var SockLength_Straight_Rows = Converters.MillimetersToRows(SockLength_Straight_Mm);

        //TODO: better converter
        size.foot = Convert.ToInt32(SockLength_Straight_Rows);

        //how high should the calf be
        //TODO: better converter
        //TODO: review the height (proportion)
        size.calf = (int) CountCalf(SockLength_Straight_Rows);

        //the elastic
        //TODO: review the height (proportion)
        CountElastic(size);
    }

    public static double CountToes(int start, int finish)
    {
        //how many rows it takes to make a toe
        return (finish - start) * 2;
    }

    public static double CountCalf(double footrows)
    {
        return 50 * footrows / 63;
    }

    public static void CountElastic(Size size)
    {
        var elastic = System.Math.Ceiling(0.4 * size.calf);
        size.elastic = (int) elastic;

        var elasticLoops = (int) (size.oneNeedle * 4 * 0.2 + size.oneNeedle * 4);

        double remainder = elasticLoops % 4;

        while (remainder != 0)
        {
            elasticLoops++;
            remainder = elasticLoops % 4;
        }

        var elasticLoopsToAdd = (elasticLoops / 4 - size.oneNeedle) * 4;

        size.elasticLoopsToAdd = elasticLoopsToAdd;
    }
}