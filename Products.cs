using System;
using System.Linq;
using System.Collections.Generic;

namespace L4764
{
    public class Products
    {
        public List<Product> Prods;
        public Products()
        {
            Prods = new List<Product>();
        }
        public void Add(int bcef, int g)
        {
            if (Prods.Exists(x => x.G == g))
            {
                Prods.Where(x => x.G == g).FirstOrDefault().BCEF.Add(bcef);
            }
            else
                Prods.Add(new Product(bcef, g));
        }
        public string GetString(long val)
        {
            string retval = val.ToString();

            var possG = Prods.Where(x => x.BCEF.Contains(val));
            var possBCEF = Prods.Where(x => x.G == val);

            if (possG.FirstOrDefault() == null)
                retval += "         ";
            else
            {
                if (possBCEF != null && possBCEF.Count() == 0)
                    foreach (var b in possG)
                        retval += $"   G={b.G,4}";
                else
                    retval += "         ";
            }

            if (possBCEF.FirstOrDefault() != null)
            {
                retval += "   BCEF=";
                foreach (var q in possBCEF)
                    foreach (var r in q.BCEF)
                        retval += $"{r,4}  ";

            }
            return retval;
        }
    }
}

