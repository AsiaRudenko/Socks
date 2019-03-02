using System;
using System.Collections.Generic;

namespace Socks
{
    public static class DealWithSizes
    {
        public static List<Size> CreateSizes()
        {
            List<Size> sizes = new List<Size>();
            
            sizes.Add(new Size() {footLengthMin = 247, footLengthMax = 260, footLength = 253.5, start = 28, oneNeedle = 14, shoe1 = "39", shoe2 = "40"});
            sizes.Add(new Size() {footLengthMin = 260.1, footLengthMax = 273.5, footLength = 266.5, start = 28, oneNeedle = 14, shoe1 = "41", shoe2 = "42"});
            sizes.Add(new Size() {footLengthMin = 273.6, footLengthMax = 286.5, footLength = 280, start = 28, oneNeedle = 15, shoe1 = "43", shoe2 = "44"});
            sizes.Add(new Size() {footLengthMin = 286.6, footLengthMax = 300, footLength = 293.5, start = 28, oneNeedle = 15, shoe1 = "45", shoe2 = "46"});
            sizes.Add(new Size() {footLengthMin = 300.1, footLengthMax = 313, footLength = 306, start = 28, oneNeedle = 16, shoe1 = "47", shoe2 = "48"});

            return sizes;
        }

        public static Size DetermineTheSize(double mm)
        {
            List<Size> sizes = CreateSizes();

            foreach (Size size in sizes)
            {
                if ((mm >= size.footLengthMin) && (mm<=size.footLengthMax))
                {
                    return size;
                }
            }
            return null;
        }

        public static Size DetermineTheSize(string shoe)
        {
            List<Size> sizes = CreateSizes();

            foreach (Size size in sizes)
            {
                if ((shoe == size.shoe1)^(shoe == size.shoe2))
                {
                    return size;
                }
            }
            return null;
        }
    }

    public class Size
    {
        public double footLengthMin { get; set; }
        public double footLengthMax { get; set; }
        public double footLength { get; set; }
        
        public string shoe1 { get; set; }
        public string shoe2 { get; set; }
        public int start{ get; set; }
        public int oneNeedle{ get; set; }

        public int foot { get; set; }
        public int heel  { get; set; }

        //TODO: IMPLEMENT
        public int calf { get; set; }
        //TODO: IMPLEMENT
        public int elastic { get; set; }
    }

}