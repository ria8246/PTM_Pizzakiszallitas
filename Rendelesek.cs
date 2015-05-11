using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTM_Pizzakiszallitas
{
   public class Rendelesek
    {
        private Stack<Rendeles> rendelesek;

        public Rendelesek() {
            rendelesek = new Stack<Rendeles>();
        }


        public void RendelestHozzaad(Rendeles ujRendeles) 
        {
            rendelesek.Push(ujRendeles);
        }

	   /*
        public Rendeles RendelestKivesz() {
            return rendelesek.Pop();        
        }
	   */
		// KRiSTóF által:
		public int RendelesekSzama ()
		{
			int dbSzam = rendelesek.Count;

			return dbSzam;
		}

		public Rendeles RendelestKivesz ()
		{
			Rendeles rendeles = null;
			int RendelesekSzamaAStackben = rendelesek.Count;

			if (RendelesekSzamaAStackben == 0)
			{
				return rendeles;
			}
			rendeles = rendelesek.Pop ();

			return rendeles;
		}
    }
}
