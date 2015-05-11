using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
    public class Iroda
    {

		public Iroda ()
		{

		}

		//A tárolt cimeket sorbarendezi, majd végig megy rajta egy ciklussal és
		//átpakolja az Utvonaltervbe, a már rendezett sorrendben
		public Utvonalterv UtvonalTervezes (Rendelesek rendelesek, int feldolgozandoRendelesekSzama)
		{
			Utvonalterv utvonalterv = new Utvonalterv ();
			List<Rendeles> rendezendoRendelesek = new List<Rendeles> ();

			for (int i = 0; i < feldolgozandoRendelesekSzama; i++)
			{
                Rendeles r = rendelesek.RendelestKivesz();
                if (r != null)
                {
                    rendezendoRendelesek.Add( r );
                }

			}

            IComparer<Rendeles> comparer = new CimHasonlito();
            rendezendoRendelesek.Sort(comparer);

			foreach (Rendeles item in rendezendoRendelesek)
			{
				utvonalterv.RendelesHozzaadas (item);
			}

			return utvonalterv;

		}

		//Meghivja a futar Kiszalitas metodusat, majd visszadja a visszatérési értéket
		public FutarAllapot FutartIndit (Futar futar)
		{
			return futar.Kiszallitas ();
		}

    }
}
