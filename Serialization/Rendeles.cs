using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PTM_Pizzakiszallitas.Serialization
{
	[Serializable]
	public class Rendeles
	{
		[XmlElement ("Pizza")]
		public Pizza pizza;

		[XmlElement ("Cim")]
		public Cim cim;

		public Rendeles ()
		{
		}

		public Rendeles (Pizza pizza, Cim cim)
		{
			this.pizza = pizza;
			this.cim = cim;
		}
	}
}
