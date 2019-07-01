namespace Socks
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Communicator.SayHello();
            
            var size = Communicator.ReadTheSize();

            //compute the coefficients
            //Sample sample = Communicator.ReadSample();
            
            //HARDCODED FOR MY CURRENT SAMPLE
            Sample sample = new Sample(22, 31, 75, 77, 95, 95);

            var sock = Math.DoTheMath(size, sample);

            Communicator.ShowResult(size, sock);
        }
    }
}