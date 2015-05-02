using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace PTM_Pizzakiszallitas.Serialization
{
	[XmlRootAttribute ("Rendelesek", Namespace="PTM", IsNullable=false)]
	class Rendeles
	{
		public PizzaInfo pizzaInfo;
		public Cim cim;
	}
}
