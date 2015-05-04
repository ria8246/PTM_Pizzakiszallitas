using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PTM_Pizzakiszallitas.Serialization
{
	public class DataSerializer
	{
		private Rendelesek CreatePredefinedDataSets ()
		{
			#region Rendelések létrehozása
			Rendeles tesztRendeles1 = new Rendeles (new Pizza (26, "sajtos"), new Cim ("Veszprém", 8200, "Egyetem", 10));
			Rendeles tesztRendeles2 = new Rendeles (new Pizza (32, "kukoricás"), new Cim ("Veszprém", 8200, "Kemecse", 6));
			Rendeles tesztRendeles3 = new Rendeles (new Pizza (12, "gombás"), new Cim ("Veszprém", 8200, "Lovassy", 20));
			Rendeles tesztRendeles4 = new Rendeles (new Pizza (28, "sonkás"), new Cim ("Veszprém", 8200, "Bajcsy-Zsilinszky", 25));
			Rendeles tesztRendeles5 = new Rendeles (new Pizza (23, "ananászos"), new Cim ("Veszprém", 8200, "Malomkő", 14));
			#endregion

			#region Rendeléshez hozzáadás
			Rendelesek rendelesek = new Rendelesek ();
			rendelesek.AddRendeles (tesztRendeles1);
			rendelesek.AddRendeles (tesztRendeles2);
			rendelesek.AddRendeles (tesztRendeles3);
			rendelesek.AddRendeles (tesztRendeles4);
			rendelesek.AddRendeles (tesztRendeles5);
			#endregion

			return rendelesek;
		}

		public void CreateXMLDocument (string FileName)
		{
			Rendelesek rendelesek = CreatePredefinedDataSets ();
			XmlSerializer serializer = new XmlSerializer (typeof (Rendelesek));
			TextWriter writer = new StreamWriter (FileName);
			serializer.Serialize (writer, rendelesek);
			writer.Close ();

			return;
		}

		public Rendelesek ReadXMLDocument (string FileName)
		{
			XmlSerializer serializer = new XmlSerializer (typeof (Rendelesek));
			FileStream file = new FileStream (FileName, FileMode.Open);
			Rendelesek readInput = (Rendelesek) serializer.Deserialize (file);
			file.Close ();

			return readInput;
		}
	}
}
