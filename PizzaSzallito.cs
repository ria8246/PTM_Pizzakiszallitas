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
		/*
		Varos varos = null;
		Futarok futarok = null;
		 Rendelesek rendelesek = null;
		*/

		// Public methods
		public PizzaSzallito ()
		{
			Initialise ();
		}

		// Private methods
		private void Initialise ()
		{
			iroda = new Iroda ();
			konyha = new Konyha ();

			return;
		}
	}
}
