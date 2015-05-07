namespace PTM_Pizzakiszallitas
{
	partial class DataDisplayer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.lstvwRendelesek = new System.Windows.Forms.ListView();
			this.PizzaAtmero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PizzaFeltet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CimVarosNev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.VarosIrSzam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CimUtcaNev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CimHazSzam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnDataDisplayerClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstvwRendelesek
			// 
			this.lstvwRendelesek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PizzaAtmero,
            this.PizzaFeltet,
            this.CimVarosNev,
            this.VarosIrSzam,
            this.CimUtcaNev,
            this.CimHazSzam});
			this.lstvwRendelesek.FullRowSelect = true;
			this.lstvwRendelesek.GridLines = true;
			this.lstvwRendelesek.Location = new System.Drawing.Point(12, 12);
			this.lstvwRendelesek.Name = "lstvwRendelesek";
			this.lstvwRendelesek.Size = new System.Drawing.Size(721, 337);
			this.lstvwRendelesek.TabIndex = 0;
			this.lstvwRendelesek.UseCompatibleStateImageBehavior = false;
			this.lstvwRendelesek.View = System.Windows.Forms.View.Details;
			// 
			// PizzaAtmero
			// 
			this.PizzaAtmero.Text = "Pizza átmérő";
			this.PizzaAtmero.Width = 84;
			// 
			// PizzaFeltet
			// 
			this.PizzaFeltet.Text = "Pizza feltét";
			this.PizzaFeltet.Width = 83;
			// 
			// CimVarosNev
			// 
			this.CimVarosNev.Text = "Város";
			this.CimVarosNev.Width = 79;
			// 
			// VarosIrSzam
			// 
			this.VarosIrSzam.Text = "Irányítószám";
			this.VarosIrSzam.Width = 91;
			// 
			// CimUtcaNev
			// 
			this.CimUtcaNev.Text = "Utca";
			this.CimUtcaNev.Width = 203;
			// 
			// CimHazSzam
			// 
			this.CimHazSzam.Text = "Házszám";
			this.CimHazSzam.Width = 176;
			// 
			// btnDataDisplayerClose
			// 
			this.btnDataDisplayerClose.Location = new System.Drawing.Point(658, 370);
			this.btnDataDisplayerClose.Name = "btnDataDisplayerClose";
			this.btnDataDisplayerClose.Size = new System.Drawing.Size(75, 23);
			this.btnDataDisplayerClose.TabIndex = 1;
			this.btnDataDisplayerClose.Text = "Bezárás";
			this.btnDataDisplayerClose.UseVisualStyleBackColor = true;
			this.btnDataDisplayerClose.Click += new System.EventHandler(this.btnDataDisplayerClose_Click);
			// 
			// DataDisplayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(745, 405);
			this.Controls.Add(this.btnDataDisplayerClose);
			this.Controls.Add(this.lstvwRendelesek);
			this.Name = "DataDisplayer";
			this.Text = "DataDisplayer";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstvwRendelesek;
		private System.Windows.Forms.Button btnDataDisplayerClose;
		private System.Windows.Forms.ColumnHeader PizzaAtmero;
		private System.Windows.Forms.ColumnHeader PizzaFeltet;
		private System.Windows.Forms.ColumnHeader CimVarosNev;
		private System.Windows.Forms.ColumnHeader VarosIrSzam;
		private System.Windows.Forms.ColumnHeader CimUtcaNev;
		private System.Windows.Forms.ColumnHeader CimHazSzam;
	}
}