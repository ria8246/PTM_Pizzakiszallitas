using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    public class Utca
    {
        private string utcaNev;
        private List<Cim> cimek;


        public Utca() {
            utcaNev = "";
            cimek = new List<Cim>();
        }

        public Utca(string utcaNev,         List<Cim> cimek)
        {
            this.utcaNev = utcaNev;
            this.cimek = cimek; //?
        }

        public void CimHozzaadasa(Cim ujCim) {
            cimek.Add(ujCim);
        }

		// KRiSTóF által:
		public Utca (string utcaNev)
		{
			this.utcaNev = utcaNev;
			this.cimek = new List<Cim> ();
		}

		public int UtcaMeret ()
		{
			int meret = cimek.Count;

			return meret;
		}

		public List<Cim>.Enumerator GetIterator ()
		{
			List<Cim>.Enumerator ListIterator = cimek.GetEnumerator ();

			return ListIterator;
		}

		public string GetUtcaNev ()
		{
			return utcaNev;
		}
    }
}
