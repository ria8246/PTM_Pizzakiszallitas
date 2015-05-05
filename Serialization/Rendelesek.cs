using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PTM_Pizzakiszallitas.Serialization
{
	[XmlRootAttribute ("RendelesTarolo")]
	public class Rendelesek
	{
		[XmlArray ("Rendelesek")]
		[XmlArrayItem ("Rendeles", typeof (Serialization.Rendeles))]
		public List<Serialization.Rendeles> rendelesek = null;

		public Rendelesek ()
		{
			rendelesek = new List<Serialization.Rendeles> ();
		}

		public void AddRendeles (Serialization.Rendeles rendeles)
		{
			rendelesek.Add (rendeles);

			return;
		}
	}
}
