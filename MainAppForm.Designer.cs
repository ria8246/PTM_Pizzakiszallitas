namespace PTM_Pizzakiszallitas
{
	partial class PizzakiszallitasMainForm
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
			this.tbPizzaKiszallitasOutput = new System.Windows.Forms.TextBox();
			this.lblPizzaKiszallitasOutput = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tbPizzaKiszallitasOutput
			// 
			this.tbPizzaKiszallitasOutput.Location = new System.Drawing.Point(12, 247);
			this.tbPizzaKiszallitasOutput.Multiline = true;
			this.tbPizzaKiszallitasOutput.Name = "tbPizzaKiszallitasOutput";
			this.tbPizzaKiszallitasOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbPizzaKiszallitasOutput.Size = new System.Drawing.Size(613, 86);
			this.tbPizzaKiszallitasOutput.TabIndex = 0;
			// 
			// lblPizzaKiszallitasOutput
			// 
			this.lblPizzaKiszallitasOutput.AutoSize = true;
			this.lblPizzaKiszallitasOutput.Location = new System.Drawing.Point(12, 231);
			this.lblPizzaKiszallitasOutput.Name = "lblPizzaKiszallitasOutput";
			this.lblPizzaKiszallitasOutput.Size = new System.Drawing.Size(129, 13);
			this.lblPizzaKiszallitasOutput.TabIndex = 1;
			this.lblPizzaKiszallitasOutput.Text = "PizzakiSzállítás kimenete:";
			// 
			// PizzakiszallitasMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 409);
			this.Controls.Add(this.lblPizzaKiszallitasOutput);
			this.Controls.Add(this.tbPizzaKiszallitasOutput);
			this.Name = "PizzakiszallitasMainForm";
			this.Text = "Pizzakiszállítás";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPizzaKiszallitasOutput;
		private System.Windows.Forms.Label lblPizzaKiszallitasOutput;
	}
}

