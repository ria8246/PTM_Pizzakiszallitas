using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PTM_Pizzakiszallitas.Serialization
{
	class Pizza
	{
		[XmlAttribute]
		public int Atmero { get; set; }
		public string Feltet { get; set; }
	}
}
