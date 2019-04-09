using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
	public class SockSize
	{
		public double footLengthMin { get; set; }
		public double footLengthMax { get; set; }
		public double footLength { get; set; }

		public string shoe1 { get; set; }
		public string shoe2 { get; set; }
		public int start { get; set; }
		public int oneNeedle { get; set; }

		public int foot { get; set; }
		public int heel { get; set; }

		public int calf { get; set; }
		public int elastic { get; set; }
		public int elasticLoopsToAdd { get; set; }
	}
}
