// © 2019 Company name. All rights reserved...

namespace Socks
{
    public class Coefficients
    {
        public double KStretchHeight;
        public double KStretchWidth;

        public double KRows;
        public double KLoops;
        
        public Coefficients(double sampleWidth, double stretchedSampleWidth, double sampleHeight, double stretchedSampleHeight)
        {
            KStretchHeight = stretchedSampleHeight / sampleHeight;
            KStretchWidth = stretchedSampleWidth / sampleWidth;
        }
    }
}