﻿namespace PTM_Pizzakiszallitas
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
			this.btnMainFormClose = new System.Windows.Forms.Button();
			this.btnShowData = new System.Windows.Forms.Button();
			this.btnStartSimulation = new System.Windows.Forms.Button();
			this.CityVisualHostElement = new System.Windows.Forms.Integration.ElementHost();
			this.cityVisualDisplayer = new PTM_Pizzakiszallitas.CityVisual();
			this.btnDisplayDelivers = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbPizzaKiszallitasOutput
			// 
			this.tbPizzaKiszallitasOutput.Location = new System.Drawing.Point(12, 247);
			this.tbPizzaKiszallitasOutput.Multiline = true;
			this.tbPizzaKiszallitasOutput.Name = "tbPizzaKiszallitasOutput";
			this.tbPizzaKiszallitasOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbPizzaKiszallitasOutput.Size = new System.Drawing.Size(613, 213);
			this.tbPizzaKiszallitasOutput.TabIndex = 0;
			// 
			// lblPizzaKiszallitasOutput
			// 
			this.lblPizzaKiszallitasOutput.AutoSize = true;
			this.lblPizzaKiszallitasOutput.Location = new System.Drawing.Point(12, 231);
			this.lblPizzaKiszallitasOutput.Name = "lblPizzaKiszallitasOutput";
			this.lblPizzaKiszallitasOutput.Size = new System.Drawing.Size(128, 13);
			this.lblPizzaKiszallitasOutput.TabIndex = 1;
			this.lblPizzaKiszallitasOutput.Text = "PizzaKiszállítás kimenete:";
			// 
			// btnMainFormClose
			// 
			this.btnMainFormClose.Location = new System.Drawing.Point(550, 481);
			this.btnMainFormClose.Name = "btnMainFormClose";
			this.btnMainFormClose.Size = new System.Drawing.Size(75, 23);
			this.btnMainFormClose.TabIndex = 2;
			this.btnMainFormClose.Text = "Bezárás";
			this.btnMainFormClose.UseVisualStyleBackColor = true;
			this.btnMainFormClose.Click += new System.EventHandler(this.btnMainFormClose_Click);
			// 
			// btnShowData
			// 
			this.btnShowData.Location = new System.Drawing.Point(143, 481);
			this.btnShowData.Name = "btnShowData";
			this.btnShowData.Size = new System.Drawing.Size(197, 23);
			this.btnShowData.TabIndex = 3;
			this.btnShowData.Text = "Beolvasott adatok megjelenenítése";
			this.btnShowData.UseVisualStyleBackColor = true;
			this.btnShowData.Click += new System.EventHandler(this.btnShowData_Click);
			// 
			// btnStartSimulation
			// 
			this.btnStartSimulation.Location = new System.Drawing.Point(12, 481);
			this.btnStartSimulation.Name = "btnStartSimulation";
			this.btnStartSimulation.Size = new System.Drawing.Size(125, 23);
			this.btnStartSimulation.TabIndex = 4;
			this.btnStartSimulation.Text = "Szimuláció indítása";
			this.btnStartSimulation.UseVisualStyleBackColor = true;
			this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
			// 
			// CityVisualHostElement
			// 
			this.CityVisualHostElement.Location = new System.Drawing.Point(15, 12);
			this.CityVisualHostElement.Name = "CityVisualHostElement";
			this.CityVisualHostElement.Size = new System.Drawing.Size(610, 216);
			this.CityVisualHostElement.TabIndex = 5;
			this.CityVisualHostElement.Child = this.cityVisualDisplayer;
			// 
			// btnDisplayDelivers
			// 
			this.btnDisplayDelivers.Location = new System.Drawing.Point(346, 481);
			this.btnDisplayDelivers.Name = "btnDisplayDelivers";
			this.btnDisplayDelivers.Size = new System.Drawing.Size(144, 23);
			this.btnDisplayDelivers.TabIndex = 6;
			this.btnDisplayDelivers.Text = "Futárokhoz jelmagyarázat";
			this.btnDisplayDelivers.UseVisualStyleBackColor = true;
			this.btnDisplayDelivers.Click += new System.EventHandler(this.btnDisplayDelivers_Click);
			// 
			// PizzakiszallitasMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(637, 516);
			this.Controls.Add(this.btnDisplayDelivers);
			this.Controls.Add(this.CityVisualHostElement);
			this.Controls.Add(this.btnStartSimulation);
			this.Controls.Add(this.btnShowData);
			this.Controls.Add(this.btnMainFormClose);
			this.Controls.Add(this.lblPizzaKiszallitasOutput);
			this.Controls.Add(this.tbPizzaKiszallitasOutput);
			this.MaximizeBox = false;
			this.Name = "PizzakiszallitasMainForm";
			this.Text = "Pizzakiszállítás";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPizzaKiszallitasOutput;
		private System.Windows.Forms.Label lblPizzaKiszallitasOutput;
		private System.Windows.Forms.Button btnMainFormClose;
		private System.Windows.Forms.Button btnShowData;
		private System.Windows.Forms.Button btnStartSimulation;
		private System.Windows.Forms.Integration.ElementHost CityVisualHostElement;
		private CityVisual cityVisualDisplayer;
		private System.Windows.Forms.Button btnDisplayDelivers;
	}
}

