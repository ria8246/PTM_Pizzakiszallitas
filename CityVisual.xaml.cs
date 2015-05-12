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

		private Rectangle DrawBuilding ()
		{
			Rectangle Building = new Rectangle ();
			Building.Stroke = new SolidColorBrush (Colors.Black);
			Building.Fill = new SolidColorBrush (Colors.Blue);
			Building.StrokeThickness = 2;
			Building.Width = 25;
			Building.Height = 25;

			return Building;
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
			while (UtcaIterator.MoveNext ())
			{
				// Y = VerticalOffset; // Nem kell visszaállítani...
				utca = UtcaIterator.Current;

				CimIterator = utca.GetIterator ();
				while (CimIterator.MoveNext ())
				{
					X += HorizontalOffset + 10 + 50;
					cim = CimIterator.Current;

					Building = DrawBuilding ();

					Canvas.SetLeft (Building, X);
					Canvas.SetTop (Building, Y);

					CityDrawArea.Children.Add (Building);
				}
				X = HorizontalOffset;
				Y += VerticalOffset + 10;
			}

			return;
		}
	}
}
