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
	public partial class DeliverDisplayer : Form
	{
		public DeliverDisplayer ()
		{
			InitializeComponent ();
		}

		public void InitializeDelivers (Futarok futarok)
		{
			Futar futar = null;
			string FutarNeve;
			Color FutarSzine;
			List<Futar>.Enumerator FutarIterator = futarok.GetFutarIterator ();
			ListViewItem listaFutarElem = null;
			Bitmap SzinDoboz = null;
			int listaIndex = 0;

			while (FutarIterator.MoveNext ())
			{
				futar = FutarIterator.Current;
				FutarNeve = futar.GetFutarNev ();
				FutarSzine = futar.GetJeloloSzin ();

				listaFutarElem = new ListViewItem ();
				listaFutarElem.Text = FutarNeve;
				listaFutarElem.ImageIndex = listaIndex;
				SzinDoboz = new Bitmap (60, 60);

				for (int y = 0; y < SzinDoboz.Width; y++)
				{
					for (int x = 0; x < SzinDoboz.Width; x++)
					{
						SzinDoboz.SetPixel (x, y, FutarSzine);
					}
				}
				ilLegend.Images.Add (SzinDoboz);
				lvDelivers.Items.Add (listaFutarElem);
				listaIndex++;
			}

			return;
		}

		private void btnCloseDelivers_Click (object sender, EventArgs e)
		{
			this.Hide ();

			return;
		}
	}
}
