// © 2019 Company name. All rights reserved...

namespace Socks
{
    public static class MakeItFour
    {
        public static int MakeItDivideableByFour(double x)
        {
            int xInt = (int) System.Math.Round(x, 0);
            double remainder = xInt % 4;

            switch (remainder)
            {
                case 1:
                    xInt = xInt - 1;
                    break;
                case 2:
                    xInt = xInt - 2;
                    break;
                case 3:
                    xInt = xInt + 1;
                    break;
                case 4:
                    break;
            }
            return xInt;
        }
        
        public static int MakeItDivideableByFour(int x)
        {
            return 0;
        }
    }
}