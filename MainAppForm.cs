using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PTM_Pizzakiszallitas
{
	public partial class PizzakiszallitasMainForm : Form
	{
		private DataDisplayer dataDisplayer = null;
		private PizzaSzallito MainPizzaSzallito = null;

		public PizzakiszallitasMainForm ()
		{
			InitializeComponent ();
			InitialisePizzaSzallito ();
			InitialiseGUI (MainPizzaSzallito.GetRendelesek ());
			AppendLineToOutput ("=== XML adatok beolvasva... ===");
			InitializeCityVisualizerControl (MainPizzaSzallito.GetVaros ());
			AppendLineToOutput ("=== Város kirajzolva... ===");
		}

		private void InitialisePizzaSzallito ()
		{
			MainPizzaSzallito = new PizzaSzallito ();

			return;
		}

		private void InitialiseGUI (Rendelesek rendelesek)
		{
			int RendelesekSzama = rendelesek.RendelesekSzama ();
			Rendeles adottRendeles = null;
			Rendelesek visszatoltendoek = new Rendelesek ();
			dataDisplayer = new DataDisplayer ();

			for (int i = 0; i < RendelesekSzama; i++)
			{
				adottRendeles = rendelesek.RendelestKivesz ();
				dataDisplayer.RendelesHozzaadasa (adottRendeles);
				visszatoltendoek.RendelestHozzaad (adottRendeles);
			}
			for (int c = 0; c < RendelesekSzama; c++)
			{
				adottRendeles = visszatoltendoek.RendelestKivesz ();
				rendelesek.RendelestHozzaad (adottRendeles);
			}

			return;
		}

		private void InitializeCityVisualizerControl (Varos MegjelenitendoVaros)
		{
			cityVisualDisplayer.DrawCity (MegjelenitendoVaros);

			return;
		}

		public void ClearOutput ()
		{
			tbPizzaKiszallitasOutput.Clear ();

			return;
		}

		public void AppendLineToOutput (string ToAppend)
		{
			string NewLine = Environment.NewLine;

			tbPizzaKiszallitasOutput.AppendText (ToAppend);
			tbPizzaKiszallitasOutput.AppendText (NewLine);

			return;
		}

		private void btnMainFormClose_Click (object sender, EventArgs e)
		{
			this.Close ();

			return;
		}

		private void btnShowData_Click (object sender, EventArgs e)
		{
			dataDisplayer.Show ();

			return;
		}

		private void btnStartSimulation_Click (object sender, EventArgs e)
		{
			btnStartSimulation.Enabled = false;
			this.AppendLineToOutput ("=== Szimuláció megkezdve... ===");
			MainPizzaSzallito.Main (this);
			this.AppendLineToOutput ("=== Szimuláció befejezve... ===");

			return;
		}
	}
}
