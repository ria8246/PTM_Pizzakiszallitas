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
			varos = InitializeCity ();

			return;
		}

		private Varos InitializeCity ()
		{
			const string VeszpremVarosNeve = "Veszprém";
			const int VeszpremIranyitoszama = 8200;

			Utca UjUtca = null;
			Cim UjCim1 = null;
			Cim UjCim2 = null;
			Cim UjCim3 = null;
			Cim UjCim4 = null;
			varos = new Varos (VeszpremVarosNeve, VeszpremIranyitoszama);

			#region Egyetem utca
			string utca1 = "Egyetem";
			UjUtca = new Utca (utca1);
			UjCim1 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca1, 10);
			UjCim2 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca1, 14);
			UjCim3 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca1, 18);
			UjCim4 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca1, 22);
			UjUtca.CimHozzaadasa (UjCim1);
			UjUtca.CimHozzaadasa (UjCim2);
			UjUtca.CimHozzaadasa (UjCim3);
			UjUtca.CimHozzaadasa (UjCim4);
			varos.AddUtca (UjUtca);
			#endregion

			#region Jutasi utca
			string utca2 = "Jutasi";
			UjUtca = new Utca (utca2);
			UjCim1 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca2, 3);
			UjCim2 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca2, 7);
			UjCim3 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca2, 11);
			UjCim4 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca2, 15);
			UjUtca.CimHozzaadasa (UjCim1);
			UjUtca.CimHozzaadasa (UjCim2);
			UjUtca.CimHozzaadasa (UjCim3);
			UjUtca.CimHozzaadasa (UjCim4);
			varos.AddUtca (UjUtca);
			#endregion

			#region Vár utca
			string utca3 = "Vár";
			UjUtca = new Utca (utca3);
			UjCim1 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca3, 2);
			UjCim2 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca3, 6);
			UjCim3 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca3, 10);
			UjCim4 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca3, 14);
			UjUtca.CimHozzaadasa (UjCim1);
			UjUtca.CimHozzaadasa (UjCim2);
			UjUtca.CimHozzaadasa (UjCim3);
			UjUtca.CimHozzaadasa (UjCim4);
			varos.AddUtca (UjUtca);
			#endregion

			#region Szikra utca
			string utca4 = "Szikra";
			UjUtca = new Utca (utca4);
			UjCim1 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca4, 1);
			UjCim2 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca4, 5);
			UjCim3 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca4, 9);
			UjCim4 = new Cim (VeszpremIranyitoszama, VeszpremVarosNeve, utca4, 13);
			UjUtca.CimHozzaadasa (UjCim1);
			UjUtca.CimHozzaadasa (UjCim2);
			UjUtca.CimHozzaadasa (UjCim3);
			UjUtca.CimHozzaadasa (UjCim4);
			varos.AddUtca (UjUtca);
			#endregion

			return varos;
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

		public Varos GetVaros ()
		{
			return varos;
		}

		public void Main (PizzakiszallitasMainForm form)
		{
			Utvonalterv megtervezettUtvonal = null;
			Futar szabadFutar = null;
			Rendeles aktualisRendeles = null;
			FutarAllapot aktualisFutarAllapot = FutarAllapot.varakozik;
			string message = "";
			int rendelesekSzama = 0;

			rendelesekSzama = rendelesek.RendelesekSzama ();
			for (int i = 0; i < rendelesekSzama; i++)
			{
				megtervezettUtvonal = iroda.UtvonalTervezes (rendelesek, 2);
				szabadFutar = futarok.KovetkezoFutar ();
				if (szabadFutar != null)
				{
					aktualisFutarAllapot = szabadFutar.getFutarAllapot ();
					message = "#" + szabadFutar.GetHashCode () + " futár állapota: " + aktualisFutarAllapot.ToString ();
					form.AppendLineToOutput (message);
					System.Threading.Thread.Sleep (2 * 1000);

					szabadFutar.UtvonaltervetFelvesz (megtervezettUtvonal);
					aktualisFutarAllapot = iroda.FutartIndit (szabadFutar);
					message = "#" + szabadFutar.GetHashCode () + " futár állapota: " + szabadFutar.getFutarAllapot ().ToString ();
					form.AppendLineToOutput (message);
					System.Threading.Thread.Sleep (2 * 1000);

					while ((aktualisRendeles = szabadFutar.getSzallitasiSorrend ().KovetkezoRendeles ()) != null)
					{
						message = "\t#" + szabadFutar.GetHashCode () + " futár tartózkodási helye: " + aktualisRendeles.RendelesiCim ().ToString ();
						form.AppendLineToOutput (message);
						System.Threading.Thread.Sleep (2 * 1000);
					}
					message = "\t\t#" + szabadFutar.GetHashCode () + " futár állapota: " + szabadFutar.VisszafeleMegy ().ToString ();
					form.AppendLineToOutput (message);
					System.Threading.Thread.Sleep (2 * 1000);
				}
			}

			return;
		}
	}
}
