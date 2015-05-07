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
			Serialization.Rendeles tesztRendeles1 = new Serialization.Rendeles (new Serialization.Pizza (26, "sajtos"), new Serialization.Cim ("Veszprém", 8200, "Egyetem", 10));
			Serialization.Rendeles tesztRendeles2 = new Serialization.Rendeles (new Serialization.Pizza (32, "kukoricás"), new Serialization.Cim ("Veszprém", 8200, "Kemecse", 6));
			Serialization.Rendeles tesztRendeles3 = new Serialization.Rendeles (new Serialization.Pizza (12, "gombás"), new Serialization.Cim ("Veszprém", 8200, "Lovassy", 20));
			Serialization.Rendeles tesztRendeles4 = new Serialization.Rendeles (new Serialization.Pizza (28, "sonkás"), new Serialization.Cim ("Veszprém", 8200, "Bajcsy-Zsilinszky", 25));
			Serialization.Rendeles tesztRendeles5 = new Serialization.Rendeles (new Serialization.Pizza (23, "ananászos"), new Serialization.Cim ("Veszprém", 8200, "Malomkő", 14));
			Serialization.Rendeles tesztRendeles6 = new Serialization.Rendeles (new Serialization.Pizza (15, "szalámis"), new Serialization.Cim ("Veszprém", 8200, "Kossuth", 7));
			#endregion

			#region Rendeléshez hozzáadás
			Serialization.Rendelesek rendelesek = new Serialization.Rendelesek ();
			rendelesek.AddRendeles (tesztRendeles1);
			rendelesek.AddRendeles (tesztRendeles2);
			rendelesek.AddRendeles (tesztRendeles3);
			rendelesek.AddRendeles (tesztRendeles4);
			rendelesek.AddRendeles (tesztRendeles5);
			rendelesek.AddRendeles (tesztRendeles6);
			#endregion

			return rendelesek;
		}

		public void CreateXMLDocument (string FileName)
		{
			Serialization.Rendelesek rendelesek = CreatePredefinedDataSets ();
			XmlSerializer serializer = new XmlSerializer (typeof (Serialization.Rendelesek));
			TextWriter writer = new StreamWriter (FileName);
			serializer.Serialize (writer, rendelesek);
			writer.Close ();

			return;
		}

		public Rendelesek ReadXMLDocument (string FileName)
		{
			XmlSerializer serializer = new XmlSerializer (typeof (Serialization.Rendelesek));
			FileStream file = new FileStream (FileName, FileMode.Open);
			Serialization.Rendelesek readInput = (Serialization.Rendelesek) serializer.Deserialize (file);
			file.Close ();

			return readInput;
		}
	}
}
