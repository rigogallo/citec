namespace Citec.Catalogos.Factura
{
    partial class BuscarFactura
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
			this.Button1 = new System.Windows.Forms.Button();
			this.tb_numfactura = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Button1
			// 
			this.Button1.Location = new System.Drawing.Point(110, 94);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(116, 23);
			this.Button1.TabIndex = 113;
			this.Button1.Text = "Buscar";
			this.Button1.UseVisualStyleBackColor = true;
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// tb_numfactura
			// 
			this.tb_numfactura.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_numfactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.tb_numfactura.Location = new System.Drawing.Point(87, 65);
			this.tb_numfactura.Name = "tb_numfactura";
			this.tb_numfactura.Size = new System.Drawing.Size(160, 23);
			this.tb_numfactura.TabIndex = 111;
			this.tb_numfactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label4.ForeColor = System.Drawing.Color.Blue;
			this.Label4.Location = new System.Drawing.Point(53, 37);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(220, 14);
			this.Label4.TabIndex = 112;
			this.Label4.Text = "Ingrese el Número de la Factura";
			// 
			// BuscarFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(329, 168);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.tb_numfactura);
			this.Controls.Add(this.Label4);
			this.Name = "BuscarFactura";
			this.Text = "BuscarFactura";
			this.Load += new System.EventHandler(this.BuscarFactura_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox tb_numfactura;
        internal System.Windows.Forms.Label Label4;
    }
}