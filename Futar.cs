using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
	public enum FutarAllapot
	{
		pizzat_szallit,
		varakozik,
		visszafele_megy
	};

    public class Futar
    {

        private Utvonalterv szallitasiSorrend;
        

         private FutarAllapot aktualisAllapot;

        //
		/*
         public Futar()
         {
             aktualisAllapot = FutarAllapot.varakozik;
             szallitasiSorrend = new Utvonalterv();
         }
		*/
        
        public FutarAllapot getFutarAllapot(){
            return aktualisAllapot;
        }

        public Utvonalterv getSzallitasiSorrend() {
            return szallitasiSorrend;
        }

        public FutarAllapot Kiszallitas() {
            aktualisAllapot = FutarAllapot.pizzat_szallit;
            return aktualisAllapot;
        }

        public FutarAllapot VisszafeleMegy()
        {
            aktualisAllapot = FutarAllapot.visszafele_megy;
            return aktualisAllapot;
        }

        // KRiSTóF által
		private string FutarNev;
		private Color JeloloSzin;

		public Futar (string FutarNev, Color JeloloSzin)
		{
			aktualisAllapot = FutarAllapot.varakozik;
			szallitasiSorrend = new Utvonalterv ();
			this.FutarNev = FutarNev;
			this.JeloloSzin = JeloloSzin;
		}

		public FutarAllapot RendelestFelveszUtvonaltervbe (Rendeles ujRendeles)
		{
			aktualisAllapot = FutarAllapot.varakozik;
			szallitasiSorrend.RendelesHozzaadas (ujRendeles);

			return aktualisAllapot;
		}

		public FutarAllapot VisszatertFutar ()
		{
			aktualisAllapot = FutarAllapot.varakozik;
			szallitasiSorrend.RendelesekTorlese ();

			return aktualisAllapot;
		}

		public void UtvonaltervetFelvesz (Utvonalterv utvonalterv)
		{
			this.szallitasiSorrend = utvonalterv;

			return;
		}

		public string GetFutarNev ()
		{
			return FutarNev;
		}

		public Color GetJeloloSzin ()
		{
			return JeloloSzin;
		}
    }
}
