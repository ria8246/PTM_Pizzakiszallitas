using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
   public class Utvonalterv
    {
        private List<Rendeles> kiszallitando;

        public Utvonalterv() {
            kiszallitando = new List<Rendeles>();
			lastVisited = 0;
        }

        public void RendelesHozzaadas(Rendeles hozzaadando) {
            kiszallitando.Add(hozzaadando);
        }

		// KRiSTóF által:
		private int lastVisited;

		public Rendeles KovetkezoRendeles ()
		{
			Rendeles kovetkezo = null;
			int dbSzam = kiszallitando.Count;

			if (dbSzam == 0)
			{
				return kovetkezo;
			}
			
			if (lastVisited == dbSzam)
			{
				return kovetkezo;
			}
			else
			{
				kovetkezo = kiszallitando [lastVisited];
				lastVisited++;
				return kovetkezo;
			}
		}
    }
}
