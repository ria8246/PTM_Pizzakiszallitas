using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PTM_Pizzakiszallitas.Serialization
{
	[Serializable]
	public class Pizza
	{
		public int Atmero { get; set; }
		public string Feltet { get; set; }

		public Pizza ()
		{
		}

		public Pizza (int Atmero, string Feltet)
		{
			this.Atmero = Atmero;
			this.Feltet = Feltet;
		}
	}
}
