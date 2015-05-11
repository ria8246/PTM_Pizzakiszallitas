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
			const string VeszpremVarosNeve = "Veszprém";
			const int VeszpremIranyitoszama = 8200;

			#region Rendelések létrehozása
			Serialization.Rendeles tesztRendeles1 = new Serialization.Rendeles (new Serialization.Pizza (23, "ananászos"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Szikra", 5));
			Serialization.Rendeles tesztRendeles2 = new Serialization.Rendeles (new Serialization.Pizza (32, "kukoricás"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Egyetem", 18));
			Serialization.Rendeles tesztRendeles3 = new Serialization.Rendeles (new Serialization.Pizza (23, "ananászos"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Jutasi", 7));
			Serialization.Rendeles tesztRendeles4 = new Serialization.Rendeles (new Serialization.Pizza (26, "sajtos"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Vár", 2));
			Serialization.Rendeles tesztRendeles5 = new Serialization.Rendeles (new Serialization.Pizza (26, "sajtos"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Egyetem", 10));
			Serialization.Rendeles tesztRendeles6 = new Serialization.Rendeles (new Serialization.Pizza (32, "kukoricás"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Vár", 6));
			Serialization.Rendeles tesztRendeles7 = new Serialization.Rendeles (new Serialization.Pizza (28, "sonkás"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Jutasi", 3));
			Serialization.Rendeles tesztRendeles8 = new Serialization.Rendeles (new Serialization.Pizza (28, "sonkás"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Szikra", 1));
			Serialization.Rendeles tesztRendeles9 = new Serialization.Rendeles (new Serialization.Pizza (12, "gombás"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Egyetem", 22));
			Serialization.Rendeles tesztRendeles10 = new Serialization.Rendeles (new Serialization.Pizza (15, "szalámis"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Szikra", 9));
			Serialization.Rendeles tesztRendeles11 = new Serialization.Rendeles (new Serialization.Pizza (15, "szalámis"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Jutasi", 15));
			Serialization.Rendeles tesztRendeles12 = new Serialization.Rendeles (new Serialization.Pizza (12, "gombás"), new Serialization.Cim (VeszpremVarosNeve, VeszpremIranyitoszama, "Vár", 10));
			#endregion

			#region Rendeléshez hozzáadás
			Serialization.Rendelesek rendelesek = new Serialization.Rendelesek ();
			rendelesek.AddRendeles (tesztRendeles1);
			rendelesek.AddRendeles (tesztRendeles2);
			rendelesek.AddRendeles (tesztRendeles3);
			rendelesek.AddRendeles (tesztRendeles4);
			rendelesek.AddRendeles (tesztRendeles5);
			rendelesek.AddRendeles (tesztRendeles6);
			rendelesek.AddRendeles (tesztRendeles7);
			rendelesek.AddRendeles (tesztRendeles8);
			rendelesek.AddRendeles (tesztRendeles9);
			rendelesek.AddRendeles (tesztRendeles10);
			rendelesek.AddRendeles (tesztRendeles11);
			rendelesek.AddRendeles (tesztRendeles12);
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
