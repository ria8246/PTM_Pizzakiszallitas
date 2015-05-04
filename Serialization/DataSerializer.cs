using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PTM_Pizzakiszallitas.Serialization
{
	class DataSerializer
	{
		public void CreateXMLDocument ()
		{
			string FileName = "test.xml";

			Rendeles tesztRendeles = new Rendeles ();

			Pizza pi = new Pizza ();
			pi.Atmero = 26;
			pi.Feltet = "sajtos";

			Cim c = new Cim ();
			c.VarosNev = "Veszprém";
			c.IrSzam = 8200;
			c.UtcaNev = "Egyetem";
			c.HazSzam = 10;

			tesztRendeles.pizzaInfo = pi;
			tesztRendeles.cim = c;

			XmlSerializer serializer = new XmlSerializer (typeof (Rendeles));
			TextWriter writer = new StreamWriter (FileName);

			serializer.Serialize (writer, tesztRendeles);
			writer.Close ();


			return;
		}
	}
}
