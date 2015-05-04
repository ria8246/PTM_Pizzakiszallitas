using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PTM_Pizzakiszallitas.Serialization
{
	[Serializable]
	public class Cim
	{
		public string VarosNev { get; set; }
		public int IrSzam { get; set; }
		public string UtcaNev { get; set; }
		public int HazSzam { get; set; }

		public Cim ()
		{
		}

		public Cim (string VarosNev, int IrSzam, string UtcaNev, int HazSzam)
		{
			this.VarosNev = VarosNev;
			this.IrSzam = IrSzam;
			this.UtcaNev = UtcaNev;
			this.HazSzam = HazSzam;
		}
	}
}
