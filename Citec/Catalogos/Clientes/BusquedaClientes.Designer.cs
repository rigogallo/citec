namespace Citec.Catalogos.Clientes
{
	partial class BusquedaClientes
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Label8 = new System.Windows.Forms.Label();
			this.tb_filtro = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.dg_clientes = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).BeginInit();
			this.SuspendLayout();
			// 
			// Label8
			// 
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.Label8.Location = new System.Drawing.Point(354, 20);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(126, 16);
			this.Label8.TabIndex = 115;
			this.Label8.Text = "Filtrar por Nombre";
			// 
			// tb_filtro
			// 
			this.tb_filtro.Location = new System.Drawing.Point(486, 19);
			this.tb_filtro.Name = "tb_filtro";
			this.tb_filtro.Size = new System.Drawing.Size(259, 20);
			this.tb_filtro.TabIndex = 114;
			// 
			// Label9
			// 
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label9.ForeColor = System.Drawing.Color.Blue;
			this.Label9.Location = new System.Drawing.Point(10, 20);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(86, 23);
			this.Label9.TabIndex = 113;
			this.Label9.Text = "Clientes";
			// 
			// dg_clientes
			// 
			this.dg_clientes.AllowUserToAddRows = false;
			this.dg_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dg_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dg_clientes.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
			this.dg_clientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dg_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg_clientes.GridColor = System.Drawing.Color.DarkKhaki;
			this.dg_clientes.Location = new System.Drawing.Point(12, 55);
			this.dg_clientes.Name = "dg_clientes";
			this.dg_clientes.ReadOnly = true;
			this.dg_clientes.Size = new System.Drawing.Size(733, 244);
			this.dg_clientes.TabIndex = 112;
			// 
			// BusquedaClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(757, 311);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.tb_filtro);
			this.Controls.Add(this.Label9);
			this.Controls.Add(this.dg_clientes);
			this.Name = "BusquedaClientes";
			this.Text = "Busqueda Clientes";
			this.Load += new System.EventHandler(this.BusquedaClientes_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg_clientes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox tb_filtro;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.DataGridView dg_clientes;
	}
}