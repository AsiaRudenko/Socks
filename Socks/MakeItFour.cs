// © 2019 Company name. All rights reserved...

namespace Socks
{
    public static class MakeItFour
    {
        public static int MakeItDivideableByFour(int x)
        {
            double remainder = x % 4;

            switch (remainder)
            {
                case 1:
                    x = x - 1;
                    break;
                case 2:
                    x = x + 2;
                    break;
                case 3:
                    x = x + 1;
                    break;
                case 4:
                    break;
            }
            return x;
        }
    }
}