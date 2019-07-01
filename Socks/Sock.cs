namespace Socks
{
    public class Sock
    {
        public int length { get; }
        public int start { get; }
        public int heel { get; }
        public int calf { get; }
        public int elasticRows { get; }
        public int elasticLoopsToAddOnNeedle { get; }
        public int oneNeedle { get; }

        public Sock()
        {
            
        }

        public Sock(int length, int start, int heel, int calf, int elasticRows, int elasticLoopsToAddOnNeedle, int oneNeedle)
        {
            this.length = length;
            this.start = start;
            this.heel = heel;
            this.calf = calf;
            this.elasticRows = elasticRows;
            this.elasticLoopsToAddOnNeedle = elasticLoopsToAddOnNeedle;
            this.oneNeedle = oneNeedle;
        }
    }
}