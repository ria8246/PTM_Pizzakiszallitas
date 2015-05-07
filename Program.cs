using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PTM_Pizzakiszallitas
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main (string [] args)
		{
			Application.EnableVisualStyles ();
			Application.SetCompatibleTextRenderingDefault (false);

			Serialization.DataSerializer ds_write = new Serialization.DataSerializer ();
			ds_write.CreateXMLDocument ("input.xml");

			Application.EnableVisualStyles ();
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new PizzakiszallitasMainForm ());

			return;
		}
	}
}
