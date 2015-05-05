using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    class Utcak
    {
        private List<Utca> utcak;

        public Utcak() {
            utcak = new List<Utca>();
        }

        public void utcaHozzaadasa(Utca ujUtca) {
            utcak.Add(ujUtca);
        }

    }
}
