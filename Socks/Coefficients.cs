// © 2019 Company name. All rights reserved...

namespace Socks
{
    public class Coefficients
    {
        public double K_height;
        public double K_width;

        public Coefficients(int sampleWidth, int stretchedSampleWidth, int sampleHeight, int stretchedSampleHeight)
        {
            K_height = stretchedSampleHeight / sampleHeight;
            K_width = stretchedSampleWidth / sampleWidth;
        }
    }
}