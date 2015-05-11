using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM_Pizzakiszallitas
{
    class CimHasonlito : IComparer<Rendeles>
    {
        public int Compare(Rendeles x, Rendeles y)
        {
            int compareVaros = x.Item1.getVarosNev().CompareTo( y.Item1.getVarosNev() );
            if (compareVaros == 0)
            {
                int compareUtca = x.Item1.getUtcaNev().CompareTo( y.Item1.getUtcaNev() );
                if (compareUtca == 0)
                {
                    return x.Item1.getHazSzam().CompareTo( y.Item1.getHazSzam() );
                }

                return compareUtca;
            }

            return compareVaros;
        }
    }
}
