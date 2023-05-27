using System;
using System.Linq;
using System.Collections.Generic;

namespace L4764
{
	public class Product
	{
        public List<long> BCEF { get; set; }
        public long G { get; set; }

        public Product(int bcef, int g)
		{
            G = g;
            BCEF = new List<long>()
			{
				bcef
			};
		}
        public override string ToString()
        {
            return $"{BCEF.Order().FirstOrDefault()}, {G}";
        }
    }
}

