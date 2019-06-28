using System;

namespace Socks
{
    internal static class Math
    {
        public static void DoTheMath(Size size, Sample sample)
        {
            Coefficients myCoefficients = new Coefficients(sample);

            //how long and wide should the knitted foot be
            var sockLengthMm = size.footLength / myCoefficients.KHeight(); 
            var sockDiameterMm = size.footDiameter / myCoefficients.KWidth(); 
            var sockDiameterLoops = (int) System.Math.Round(Converters.MillimetersToLoops(sockDiameterMm, sample.width, sample.loops), 0);
            
            sockDiameterLoops = Converters.MakeItFour(sockDiameterLoops);
        
            size.oneNeedle = sockDiameterLoops / 4;
            size.start = size.oneNeedle * 2;

            //how many rows do toes and heelHeightRows take
            size.heelRows = (int) System.Math.Round((double)size.oneNeedle * 2 / 3, 0);
            var toesAndHeelRows = CountToes(size.start / 4, size.oneNeedle) + size.heelRows;
            var toesAndHeelMm = Converters.RowsToMillimeters(toesAndHeelRows, sample.height, sample.rows);

            //how many millimeters should you knit between toes and heelHeightRows and how many rows does it take
            var sockLengthStraightMm = sockLengthMm - toesAndHeelMm;
            var sockLengthStraightRows = Converters.MillimetersToRows(sockLengthStraightMm, sample.height, sample.rows);
            //TODO: better converter
            size.footLengthRows = Convert.ToInt32(sockLengthStraightRows);

            //how high should the calf be
            //TODO: better converter
            //TODO: review the height (proportion)
            size.calf = (int) CountCalf(sockLengthStraightRows);

            //the elastic
            //TODO: review the height (proportion)
            CountElastic(size);
        }

        private static double CountToes(int start, int finish)
        {
            //how many rows it takes to make a toe
            return (finish - start) * 2;
        }

        private static double CountCalf(double footrows)
        {
            return 50 * footrows / 63;
        }

        private static void CountElastic(Size size)
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

            size.elasticLoopsToAdd = (elasticLoops / 4 - size.oneNeedle) * 4;
        }
    }
}