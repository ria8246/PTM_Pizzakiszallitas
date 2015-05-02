using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
	class PizzaSzallito
	{
		// Member declarations
		Iroda iroda = null;
		Konyha konyha = null;
		Rendelesek rendelesek = null;
		Futarok futarok = null;
		Varos varos = null;
		
		// Public methods
		public PizzaSzallito ()
		{
			Initialise ();
		}

		public void MainLoop ()
		{
			Pizza ElkeszitettPizza = null;
			Futar KovetkezoSzabadFutar = null;
			Utvonalterv KiszallitasiUtvonal = null;

			KiszallitasiUtvonal = iroda.UtvonalTervezes (rendelesek);
			/* ElkeszitettPizza = */ iroda.PizzatKeszittet (rendelesek, konyha); // Void return!!!
			KovetkezoSzabadFutar = futarok.KovetkezoFutar (); // Not implemented!
			if (KovetkezoSzabadFutar != null)
			{
				konyha.PizzatAtad (ElkeszitettPizza, KovetkezoSzabadFutar); // Not implemented!!!
				iroda.UtvonaltervAtadasa (KiszallitasiUtvonal, KovetkezoSzabadFutar); // Not implemented!!!
				iroda.FutartIndit (KovetkezoSzabadFutar, varos); // Planned.
			}

			return;
		}

		// Private methods
		private void Initialise ()
		{
			// TODO Rendeléseket XML-ből beolvasni...
			iroda = new Iroda ();
			konyha = new Konyha ();
			rendelesek = new Rendelesek ();
			futarok = new Futarok ();
			varos = new Varos ();

			return;
		}
	}
}
