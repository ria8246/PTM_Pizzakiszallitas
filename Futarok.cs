using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    public class Futarok
    {
        private List<Futar> futarok;

        public Futarok() {
            futarok = new List<Futar>();
            for (int i = 0; i < 4; i++)
            {
                //futarok.Push(new Futar());
                futarok.Add(new Futar());
            }
        }

        public Futar KovetkezoFutar(int index)
        {
            //return stack.Pop();

            return futarok.ElementAt(index);
        }

		// KRiSTóF által:
        public int FutarokSzama ()
		{
			int dbSzam = futarok.Count;

			return dbSzam;
		}

		public Futar KovetkezoFutar ()
		{
			Futar szabadFutar = null;
			List<Futar>.Enumerator listIterator = futarok.GetEnumerator ();

			while (listIterator.MoveNext ())
			{
				if (listIterator.Current.getFutarAllapot () == FutarAllapot.varakozik)
				{
					szabadFutar = listIterator.Current;
					return szabadFutar;
				}
			}

			return szabadFutar;
		}

    }
}
