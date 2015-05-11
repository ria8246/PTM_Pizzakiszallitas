using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    public class Varos
    {
        private string varosNev;
        private int iranyitoSzam;
        private Utcak utcak;

        public Varos() {
            varosNev = "";
            iranyitoSzam = 0;
            utcak = new Utcak();
        }

        public Varos(string varosNev,        int iranyitoSzam,        Utcak utcak) {
            this.varosNev = varosNev;
            this.iranyitoSzam = iranyitoSzam;
            this.utcak = utcak; //?
        }

		// KRiSTóF által:
		public Varos (string varosNev, int iranyitoSzam)
		{
			this.varosNev = varosNev;
			this.iranyitoSzam = iranyitoSzam;
			this.utcak = new Utcak ();
		}

		public void AddUtca (Utca UjUtca)
		{
			utcak.utcaHozzaadasa (UjUtca);

			return;
		}

		public int VarosUtcainakSzama ()
		{
			int dbSzam = utcak.UtcakSzama ();

			return dbSzam;
		}

		public List<Utca>.Enumerator VarosiUtcak ()
		{
			List<Utca>.Enumerator utcaIterator = utcak.GetIterator ();

			return utcaIterator;
		}
	}
}
