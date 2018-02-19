namespace Citec.Catalogos.Factura
{
    partial class AnularFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnularFacturas));
            this.Label7 = new System.Windows.Forms.Label();
            this.dg_facturasPendientes = new System.Windows.Forms.DataGridView();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_cerrar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg_facturasPendientes)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Location = new System.Drawing.Point(17, 7);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(96, 23);
            this.Label7.TabIndex = 85;
            this.Label7.Text = "Facturas ";
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
            this.dg_facturasPendientes.Location = new System.Drawing.Point(21, 49);
            this.dg_facturasPendientes.Name = "dg_facturasPendientes";
            this.dg_facturasPendientes.ReadOnly = true;
            this.dg_facturasPendientes.Size = new System.Drawing.Size(764, 338);
            this.dg_facturasPendientes.TabIndex = 84;
            this.dg_facturasPendientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AnularFactura);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_cerrar});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 408);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(805, 31);
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
            // AnularFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 439);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.dg_facturasPendientes);
            this.Controls.Add(this.ToolStrip1);
            this.Name = "AnularFacturas";
            this.Text = "Anular Facturas";
            this.Load += new System.EventHandler(this.AnularFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_facturasPendientes)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.DataGridView dg_facturasPendientes;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btn_cerrar;
    }
}