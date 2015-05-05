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
			this.btnDataDisplayerClose = new System.Windows.Forms.Button();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lstvwRendelesek
			// 
			this.lstvwRendelesek.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lstvwRendelesek.GridLines = true;
			this.lstvwRendelesek.Location = new System.Drawing.Point(12, 12);
			this.lstvwRendelesek.Name = "lstvwRendelesek";
			this.lstvwRendelesek.Size = new System.Drawing.Size(543, 337);
			this.lstvwRendelesek.TabIndex = 0;
			this.lstvwRendelesek.UseCompatibleStateImageBehavior = false;
			this.lstvwRendelesek.View = System.Windows.Forms.View.List;
			// 
			// btnDataDisplayerClose
			// 
			this.btnDataDisplayerClose.Location = new System.Drawing.Point(12, 370);
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
			this.ClientSize = new System.Drawing.Size(584, 405);
			this.Controls.Add(this.btnDataDisplayerClose);
			this.Controls.Add(this.lstvwRendelesek);
			this.Name = "DataDisplayer";
			this.Text = "DataDisplayer";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstvwRendelesek;
		private System.Windows.Forms.Button btnDataDisplayerClose;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}