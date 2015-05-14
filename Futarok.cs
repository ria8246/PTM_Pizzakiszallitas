using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    public class Futarok
    {
        private List<Futar> futarok;
		
		/*
        public Futarok() {
            futarok = new List<Futar>();
            for (int i = 0; i < 4; i++)
            {
                //futarok.Push(new Futar());
                futarok.Add(new Futar());
            }
        }
		*/
		/*
        public Futar KovetkezoFutar(int index)
        {
            //return stack.Pop();

            return futarok.ElementAt(index);
        }
		*/

		// KRiSTóF által:
		public Futarok ()
		{
			futarok = new List<Futar> ();
		}

		public void UjFutarHozzaadasa (Futar UjFutar)
		{
			futarok.Add (UjFutar);

			return;
		}

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

		public List<Futar>.Enumerator GetFutarIterator ()
		{
			List<Futar>.Enumerator listIterator = futarok.GetEnumerator ();

			return listIterator;
		}

		public Futar KovetkezoFutar (int index)
		{
			Futar szabadFutar = null;
			try
			{
				szabadFutar = futarok.ElementAt (index);

				return szabadFutar;
			}
			catch (ArgumentOutOfRangeException)
			{
				szabadFutar = KovetkezoFutar ();

				return szabadFutar;
			}
		}

		public static int KovetkezoIndex (int ElozoIndex, int Meret)
		{
			int UjIndex = ElozoIndex;
			UjIndex++;

			if (UjIndex % Meret == 0)
			{
				UjIndex = 0;
			}

			return UjIndex;
		}
    }
}
