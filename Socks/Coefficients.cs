// © 2019 Company name. All rights reserved...


//TODO: check all the input with setters for properties
//TODO: mark all constant fields / properties' setters as private
//TODO: make an indexer for Sizes?
/*
 *          public class HttpCookie
   {
   private readonly Dictionary<string, string> _dictionary;
   public DateTime Expiry { get; set; }
   
   public HttpCookie()
   {
   _dictionary = new Dictionary<string, string>();
   }
   
   public string this[string key]
   {
   get { return _dictionary[key]; }
   set { _dictionary[key] = value; }
   }
   }
 */

namespace Socks
{
    public class Coefficients
    {
        private double kHeight { get; set; }
        private double kWidth { get; set; }

        public double KHeight()
        {
            return kHeight;
        }

        public double KWidth()
        {
            return kWidth;
        }

        public Coefficients(Sample sample)
        {
            kHeight = sample.heightStretched / sample.height;
            kWidth = sample.widthStretched / sample.width;
        }
    }
}