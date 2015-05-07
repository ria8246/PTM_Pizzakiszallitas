using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PTM_Pizzakiszallitas
{
	public class PizzaSzallito
	{
		// Private member declarations
		Iroda iroda = null;
		Rendelesek rendelesek = null;
		Futarok futarok = null;
		Varos varos = null;

		// Private methods
		private void Initialise ()
		{
			iroda = new Iroda ();
			rendelesek = TransformRendelesDataFromSerializedToNonSerialized ("input.xml");
			futarok = new Futarok ();
			varos = new Varos ();

			return;
		}

		#region Convering Orders from serialized form to non-serialized form
		private Rendelesek TransformRendelesDataFromSerializedToNonSerialized (string FileName)
		{
			Rendelesek rendelesek = new Rendelesek ();
			Serialization.Rendelesek serializedRendelesek = ReadInputFromFile (FileName);
			TransformOrders (serializedRendelesek, rendelesek);

			return rendelesek;
		}

		private Serialization.Rendelesek ReadInputFromFile (string FileName)
		{
			Serialization.DataSerializer dataSerializer = new Serialization.DataSerializer ();
			Serialization.Rendelesek ReadSerializedInputData = dataSerializer.ReadXMLDocument (FileName);

			return ReadSerializedInputData;
		}

		private void TransformOrders (Serialization.Rendelesek TransformFrom, Rendelesek TransformTo)
		{
			List<Serialization.Rendeles>.Enumerator SerRenListEnumerator = TransformFrom.GetEnumerator ();

			while (SerRenListEnumerator.MoveNext ())
			{
				Serialization.Rendeles SerRendeles = SerRenListEnumerator.Current;
				Rendeles NotSerRendeles = TransformOrder (SerRendeles);
				TransformTo.RendelestHozzaad (NotSerRendeles);
			}

			return;
		}

		private Rendeles TransformOrder (Serialization.Rendeles TransformFrom)
		{
			string PizzaFeltet = TransformFrom.pizza.Feltet;
			int PizzaAtmero = TransformFrom.pizza.Atmero;
			string VarosNev = TransformFrom.cim.VarosNev;
			int IranyitoSzam = TransformFrom.cim.IrSzam;
			string UtcaNev = TransformFrom.cim.UtcaNev;
			int HazSzam = TransformFrom.cim.HazSzam;

			Pizza rendeltPizza = new Pizza (PizzaFeltet, PizzaAtmero);
			Cim rendelesiCim = new Cim (IranyitoSzam, VarosNev, UtcaNev, HazSzam);
			Rendeles TransformTo = new Rendeles (rendelesiCim, rendeltPizza);

			return TransformTo;
		}
		#endregion

		// Public methods
		public PizzaSzallito ()
		{
			Initialise ();
		}

		public Rendelesek GetRendelesek ()
		{
			return rendelesek;
		}

		public void Main ()
		{
			


			return;
		}
	}
}
