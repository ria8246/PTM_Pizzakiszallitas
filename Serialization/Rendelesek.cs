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
		[XmlArrayItem ("Rendeles", typeof (Rendeles))]
		public List<Rendeles> rendelesek = null;

		public Rendelesek ()
		{
			rendelesek = new List<Rendeles> ();
		}

		public void AddRendeles (Rendeles rendeles)
		{
			rendelesek.Add (rendeles);

			return;
		}
	}
}
