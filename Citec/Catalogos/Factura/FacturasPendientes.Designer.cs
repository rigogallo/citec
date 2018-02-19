namespace Citec.Catalogos.Factura
{
    partial class FacturasPendientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasPendientes));
            this.Label7 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_cerrar = new System.Windows.Forms.ToolStripButton();
            this.dg_facturasPendientes = new System.Windows.Forms.DataGridView();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_facturasPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Location = new System.Drawing.Point(8, 9);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(199, 23);
            this.Label7.TabIndex = 85;
            this.Label7.Text = "Facturas Pendientes";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cerrar});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 296);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(790, 31);
            this.ToolStrip1.TabIndex = 83;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_cerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(28, 28);
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // dg_facturasPendientes
            // 
            this.dg_facturasPendientes.AllowUserToAddRows = false;
            this.dg_facturasPendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_facturasPendientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg_facturasPendientes.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dg_facturasPendientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_facturasPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_facturasPendientes.GridColor = System.Drawing.Color.DarkKhaki;
            this.dg_facturasPendientes.Location = new System.Drawing.Point(12, 53);
            this.dg_facturasPendientes.Name = "dg_facturasPendientes";
            this.dg_facturasPendientes.ReadOnly = true;
            this.dg_facturasPendientes.Size = new System.Drawing.Size(764, 214);
            this.dg_facturasPendientes.TabIndex = 84;
            // 
            // FacturasPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 327);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.dg_facturasPendientes);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "FacturasPendientes";
            this.Text = "Facturas Pendientes";
            this.Load += new System.EventHandler(this.FacturasPendientes_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_facturasPendientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btn_cerrar;
        internal System.Windows.Forms.DataGridView dg_facturasPendientes;
    }
}