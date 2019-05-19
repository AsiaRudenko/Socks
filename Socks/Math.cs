// � 2019 Company name. All rights reserved...

using System;
using Socks;

internal static class Math
{
    public static void DoTheMath(Size size)
    {
        //compute the coefficients
        Sample sample = ReadInput.ReadSample();
        
        
        Coefficients myCoefficients = new Coefficients(sample.width, sample.widthStretched, sample.height, sample.heightStretched);

        //how long and wide should the knitted foot be
        double SockLength_Mm = size.footLength / myCoefficients.KStretchHeight;
        
        double SockDiameter_Mm = size.footDiameter / myCoefficients.KStretchWidth;
        int SockDiameter_Loops = (int) System.Math.Round(Converters.MillimetersToLoops(SockDiameter_Mm, sample.width, sample.loops), 0);

        SockDiameter_Loops = MakeItFour.MakeItDivideableByFour(SockDiameter_Loops);
        
        size.oneNeedle = SockDiameter_Loops / 4;
        size.start = size.oneNeedle * 2;
        
        //how many rows do toes and heelHeightRows take
        var ToesAndHeel_Rows = CountToes(size.start / 4, size.oneNeedle) + size.heelHeightRows;

        //how many millimeters do toes and heelHeightRows take
        var ToesAndHeel_Mm = Converters.RowsToMillimeters(ToesAndHeel_Rows, sample.height, sample.rows);

        //how many millimeters should you knit between toes and heelHeightRows
        var SockLength_Straight_Mm = SockLength_Mm - ToesAndHeel_Mm;

        //how many rows does it take
        var SockLength_Straight_Rows = Converters.MillimetersToRows(SockLength_Straight_Mm, sample.height, sample.rows);

        //TODO: better converter
        size.footLengthRows = Convert.ToInt32(SockLength_Straight_Rows);

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