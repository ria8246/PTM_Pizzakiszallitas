using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PTM_Pizzakiszallitas
{
	/// <summary>
	/// Interaction logic for CityVisual.xaml
	/// </summary>
	public partial class CityVisual : UserControl
	{
		public CityVisual ()
		{
			InitializeComponent ();
		}

		private Rectangle DrawBuilding (string ToolTipText)
		{
			Rectangle Building = new Rectangle ();
			Building.Stroke = new SolidColorBrush (Colors.Black);
			Building.Fill = new SolidColorBrush (Colors.Blue);
			Building.StrokeThickness = 3;
			Building.Width = 25;
			Building.Height = 25;
			Building.ToolTip = ToolTipText;

			return Building;
		}

		private void DrawLine (int X1, int Y1, int X2, int Y2, int Thickness, string ToolTipText)
		{
			Line NewLine = new Line ();
			NewLine.Stroke = new SolidColorBrush (Colors.Black);
			NewLine.Fill = new SolidColorBrush (Colors.Black);
			NewLine.StrokeThickness = Thickness;
			NewLine.X1 = X1;
			NewLine.Y1 = Y1;
			NewLine.X2 = X2;
			NewLine.Y2 = Y2;
			NewLine.ToolTip = ToolTipText;

			Canvas.SetLeft (NewLine, NewLine.X1);
			Canvas.SetTop (NewLine, NewLine.Y1);
			CityDrawArea.Children.Add (NewLine);

			return;
		}

		private void DrawStreets ()
		{
			DrawLine (20, 10, 20, 160, 15, "Város utcái");
			DrawLine (20, 25, 400, 25, 5, "Egyetem utca");
			DrawLine (20, 43, 400, 43, 5, "Jutasi utca");
			DrawLine (20, 60, 400, 60, 5, "Vár utca");
			DrawLine (20, 78, 400, 78, 5, "Szikra utca");

			return;
		}

		public void DrawCity (Varos varos)
		{
			string VarosNev = varos.GetVarosNev ();
			CityName.Text = VarosNev;
			int VerticalOffset = 25;
			int HorizontalOffset = 25;
			int X = HorizontalOffset;
			int Y = VerticalOffset;
			Rectangle Building = null;
			List<Utca>.Enumerator UtcaIterator = varos.VarosiUtcak ();
			List<Cim>.Enumerator CimIterator;
			Utca utca = null;
			Cim cim = null;

			DrawStreets ();

			while (UtcaIterator.MoveNext ())
			{
				// Y = VerticalOffset; // Nem kell visszaállítani...
				utca = UtcaIterator.Current;

				CimIterator = utca.GetIterator ();
				while (CimIterator.MoveNext ())
				{
					X += HorizontalOffset + 10 + 50;
					cim = CimIterator.Current;

					Building = DrawBuilding (cim.ToString ());
					Canvas.SetLeft (Building, X);
					Canvas.SetTop (Building, Y);
					CityDrawArea.Children.Add (Building);
				}
				X = HorizontalOffset;
				Y += VerticalOffset + 10;
			}

			return;
		}

		public void VisitCity (Futar aktualisFutar, Rendeles aktualisRendeles)
		{
			string KiszallitasiCim = aktualisRendeles.RendelesiCim ().ToString ();
			System.Drawing.Color futarSzin = aktualisFutar.GetJeloloSzin ();
			System.Drawing.Color eredetiEpuletSzin = System.Drawing.Color.Blue;
			System.Collections.IEnumerator elemek = CityDrawArea.Children.GetEnumerator ();
			System.Windows.Media.Color ConvertedColor;
			UIElement elem = null;
			string aktualisCim;

			while (elemek.MoveNext ())
			{
				elem = (UIElement) elemek.Current;

				if (elem is Rectangle)
				{
					aktualisCim = (elem as Rectangle).ToolTip.ToString ();
					if (KiszallitasiCim == aktualisCim)
					{
						ConvertedColor = System.Windows.Media.Color.FromArgb (futarSzin.A, futarSzin.R, futarSzin.G, futarSzin.B);
						(elem as Rectangle).Fill = new SolidColorBrush (ConvertedColor);
						this.Refresh ();
						break;
					}
				}
			}
			System.Threading.Thread.Sleep (2 * 1000);
			if (elem != null && elem is Rectangle)
			{
				ConvertedColor = System.Windows.Media.Color.FromArgb (eredetiEpuletSzin.A, eredetiEpuletSzin.R, eredetiEpuletSzin.G, eredetiEpuletSzin.B);
				(elem as Rectangle).Fill = new SolidColorBrush (ConvertedColor);
				this.Refresh ();
			}

			return;
		}
	}
}
