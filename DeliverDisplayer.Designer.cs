namespace PTM_Pizzakiszallitas
{
	partial class DeliverDisplayer
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
			this.components = new System.ComponentModel.Container();
			this.lblDeliversText = new System.Windows.Forms.Label();
			this.lvDelivers = new System.Windows.Forms.ListView();
			this.ilLegend = new System.Windows.Forms.ImageList(this.components);
			this.btnCloseDelivers = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblDeliversText
			// 
			this.lblDeliversText.AutoSize = true;
			this.lblDeliversText.Location = new System.Drawing.Point(12, 9);
			this.lblDeliversText.Name = "lblDeliversText";
			this.lblDeliversText.Size = new System.Drawing.Size(84, 13);
			this.lblDeliversText.TabIndex = 0;
			this.lblDeliversText.Text = "Kiszállítók listája";
			// 
			// lvDelivers
			// 
			this.lvDelivers.LargeImageList = this.ilLegend;
			this.lvDelivers.Location = new System.Drawing.Point(12, 34);
			this.lvDelivers.Name = "lvDelivers";
			this.lvDelivers.Size = new System.Drawing.Size(242, 295);
			this.lvDelivers.TabIndex = 1;
			this.lvDelivers.UseCompatibleStateImageBehavior = false;
			// 
			// ilLegend
			// 
			this.ilLegend.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.ilLegend.ImageSize = new System.Drawing.Size(60, 60);
			this.ilLegend.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btnCloseDelivers
			// 
			this.btnCloseDelivers.Location = new System.Drawing.Point(179, 343);
			this.btnCloseDelivers.Name = "btnCloseDelivers";
			this.btnCloseDelivers.Size = new System.Drawing.Size(75, 23);
			this.btnCloseDelivers.TabIndex = 2;
			this.btnCloseDelivers.Text = "Elrejtés";
			this.btnCloseDelivers.UseVisualStyleBackColor = true;
			this.btnCloseDelivers.Click += new System.EventHandler(this.btnCloseDelivers_Click);
			// 
			// DeliverDisplayer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(269, 378);
			this.Controls.Add(this.btnCloseDelivers);
			this.Controls.Add(this.lvDelivers);
			this.Controls.Add(this.lblDeliversText);
			this.MaximizeBox = false;
			this.Name = "DeliverDisplayer";
			this.Text = "DeliverDisplayer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDeliversText;
		private System.Windows.Forms.ListView lvDelivers;
		private System.Windows.Forms.ImageList ilLegend;
		private System.Windows.Forms.Button btnCloseDelivers;
	}
}