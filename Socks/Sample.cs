namespace Socks
{
    public class Sample
    {
        public int loops { get; }

        public int rows { get; }

        public double width { get; }

        public double height { get; }

        public double widthStretched { get; }

        public double heightStretched { get; }

        public Sample(int loops, int rows, double width, double height, double widthStretched, double heightStretched)
        {
            this.loops = loops;
            this.rows = rows;

            this.width = width;
            this.height = height;

            this.widthStretched = widthStretched;
            this.heightStretched = heightStretched;
        }

    }
}