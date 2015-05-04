using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PTM_Pizzakiszallitas
{
	class PizzaSzallito
	{
		// Private member declarations
		Iroda iroda = null;
		Rendelesek rendelesek = null;
		Futarok futarok = null;
		Varos varos = null;

		// Private methods
		private void Initialise ()
		{
			// TODO Rendeléseket XML-ből beolvasni...
			iroda = new Iroda ();
			rendelesek = new Rendelesek ();
			futarok = new Futarok ();
			varos = new Varos ();

			return;
		}
		
		// Public methods
		public PizzaSzallito ()
		{
			Initialise ();
		}

		public void MainLoop ()
		{
			Futar KovetkezoSzabadFutar = null;
			Utvonalterv KiszallitasiUtvonal = null;

			KovetkezoSzabadFutar = futarok.KovetkezoFutar (); // Not implemented!
			KiszallitasiUtvonal = iroda.UtvonalTervezes (rendelesek);
			if (KovetkezoSzabadFutar != null)
			{
				iroda.UtvonaltervAtadasa (KiszallitasiUtvonal, KovetkezoSzabadFutar); // Not implemented!!!
				iroda.FutartIndit (KovetkezoSzabadFutar); // Planned.
			}

			// TODO: Loop and Timer...

			return;
		}
	}
}
