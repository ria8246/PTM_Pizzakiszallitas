using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    public class Utcak
    {
        private List<Utca> utcak;

        public Utcak() {
            utcak = new List<Utca>();
        }

        public void utcaHozzaadasa(Utca ujUtca) {
            utcak.Add(ujUtca);
        }

		// KRiSTóF által:
		public int UtcakSzama ()
		{
			int dbSzam = utcak.Count;

			return dbSzam;
		}

		public List<Utca>.Enumerator GetIterator ()
		{
			List<Utca>.Enumerator ListIterator = utcak.GetEnumerator ();

			return ListIterator;
		}

    }
}
