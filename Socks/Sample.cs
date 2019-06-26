// © 2019 Company name. All rights reserved...

namespace Socks
{
    public class Sample
    {
        private int _loops;
        private int _rows;
        private double _width;
        private double _height;
        private double _widthStretched;
        private double _heightStretched;

        public int loops
        {
            get => _loops;
            set => _loops = value;
        }

        public int rows
        {
            get => _rows;
            set => _rows = value;
        }

        public double width
        {
            get => _width;
            set => _width = value;
        }

        public double height
        {
            get => _height;
            set => _height = value;
        }

        public double widthStretched
        {
            get => _widthStretched;
            set => _widthStretched = value;
        }

        public double heightStretched
        {
            get => _heightStretched;
            set => _heightStretched = value;
        }

        public Sample(int Loops, int Rows, double Width, double Height, double WidthStretched, double HeightStretched)
        {
            loops = Loops;
            rows = Rows;

            width = Width;
            height = Height;

            widthStretched = WidthStretched;
            heightStretched = HeightStretched;
        }

    }
}