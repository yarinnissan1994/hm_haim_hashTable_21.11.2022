using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm22112022cs
{
    internal class IceCream
    {
		public IceCream(int id, int ballCount)
		{
			_id = id;
			this.ballCount = ballCount;	
		}

		private int _id;

		public int Id
		{
			get { return _id; }
		}

		public int ballCount { get; set; }

	}
}
