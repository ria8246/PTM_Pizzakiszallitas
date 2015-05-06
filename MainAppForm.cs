using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PTM_Pizzakiszallitas
{
	public partial class PizzakiszallitasMainForm : Form
	{
		public PizzakiszallitasMainForm ()
		{
			InitializeComponent ();
		}

		public void ClearOutput ()
		{
			tbPizzaKiszallitasOutput.Clear ();

			return;
		}

		public void AppendLineToOutput (string ToAppend)
		{
			string NewLine = Environment.NewLine;

			tbPizzaKiszallitasOutput.AppendText (ToAppend);
			tbPizzaKiszallitasOutput.AppendText (NewLine);

			return;
		}

		private void btnMainFormClose_Click (object sender, EventArgs e)
		{
			this.Close ();

			return;
		}
	}
}
