using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PTM_Pizzakiszallitas.Serialization
{
	class Cim
	{
		[XmlAttribute]
		public string VarosNev { get; set; }
		public int IrSzam { get; set; }
		public string UtcaNev { get; set; }
		public int HazSzam { get; set; }
	}
}
