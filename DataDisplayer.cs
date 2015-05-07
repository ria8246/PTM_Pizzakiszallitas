using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTM_Pizzakiszallitas
{
	public partial class DataDisplayer : Form
	{
		public void RendelesHozzaadasa (Rendeles rendeles)
		{
			string PizzaFeltet = rendeles.RendeltPizza ().getFeltet ();
			int PizzaAtmero = rendeles.RendeltPizza ().getAtmero ();
			string VarosNev = rendeles.RendelesiCim ().getVarosNev ();
			int IranyitoSzam = rendeles.RendelesiCim ().getIranyitoSzam ();
			string UtcaNev = rendeles.RendelesiCim ().getUtcaNev ();
			int HazSzam = rendeles.RendelesiCim ().getHazSzam ();

			ListViewItem item = new ListViewItem (PizzaAtmero.ToString ());
			item.SubItems.Add (PizzaFeltet);
			item.SubItems.Add (VarosNev);
			item.SubItems.Add (IranyitoSzam.ToString ());
			item.SubItems.Add (UtcaNev);
			item.SubItems.Add (HazSzam.ToString ());

			lstvwRendelesek.Items.Add (item);
			lstvwRendelesek.Refresh ();

			return;
		}

		public DataDisplayer ()
		{
			InitializeComponent ();
		}

		private void btnDataDisplayerClose_Click (object sender, EventArgs e)
		{
			this.Hide ();

			return;
		}
	}
}
