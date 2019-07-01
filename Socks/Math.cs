using System;

namespace Socks
{
    internal static class Math
    {
        public static Sock DoTheMath(Size size, Sample sample)
        {
            Coefficients myCoefficients = new Coefficients(sample);

            //how long and wide should the knitted foot be
            var sockLengthMm = size.footLength / myCoefficients.KHeight();
            var sockDiameterMm = size.footDiameter / myCoefficients.KWidth();

            //TODO: better converter
            var sockDiameterLoops = (int) System.Math.Round(Converters.MillimetersToLoops(sockDiameterMm, sample.width, sample.loops), 0);
            sockDiameterLoops = Converters.MakeItFour(sockDiameterLoops);

            int oneNeedle = sockDiameterLoops / 4;
            int start = oneNeedle * 2;
            
            //how many footRows do toes and heelHeightRows take
            int heelRows = (int)System.Math.Round((double)oneNeedle * 2 / 3, 0);
            
            var toesAndHeelRows = CountToes(start / 4, oneNeedle) + heelRows;
            var toesAndHeelMm = Converters.RowsToMillimeters(toesAndHeelRows, sample.height, sample.rows);

            //how many millimeters should you knit between toes and heelHeightRows and how many footRows does it take
            var sockLengthStraightMm = sockLengthMm - toesAndHeelMm;
            var sockLengthStraightRows = Converters.MillimetersToRows(sockLengthStraightMm, sample.height, sample.rows);

            int length = Convert.ToInt32(sockLengthStraightRows);

            //how high should the calf be
            //TODO: better converter
            int calf = (int) CountCalf(sockLengthStraightRows);

            (int rows, int add) elastic = CountElastic(size, calf, oneNeedle);
            var sock = new Sock(length, start, heelRows, calf, elastic.rows, elastic.add, oneNeedle);

            return sock;
        }

        private static double CountToes(int start, int finish)
        {
            //how many footRows it takes to make a toe
            return (finish - start) * 2;
        }

        private static double CountCalf(double footRows)
        {
            return 50 * footRows / 63;
        }

        private static (int, int) CountElastic(Size size, int calf, int oneNeedle)
        {
            int elastic = (int) System.Math.Ceiling(0.4 * calf);
            //size.elasticRows = (int) elasticRows;

            var elasticLoops = (int) (oneNeedle * 4 * 0.2 + oneNeedle * 4);

            double remainder = elasticLoops % 4;

            while (remainder != 0)
            {
                elasticLoops++;
                remainder = elasticLoops % 4;
            }

            //size.elasticLoopsToAddOnNeedle = (elasticLoops / 4 - size.oneNeedle) * 4;
            int elasticLoopsToAdd = elasticLoops / 4 - oneNeedle;
            return (elastic, elasticLoopsToAdd);
        }
    }
}