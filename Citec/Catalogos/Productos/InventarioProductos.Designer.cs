namespace Citec.Catalogos.Productos
{
    partial class InventarioProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioProductos));
            this.dg_productos = new System.Windows.Forms.DataGridView();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_actulizar = new System.Windows.Forms.ToolStripButton();
            this.btn_cerrar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Label4 = new System.Windows.Forms.Label();
            this.tb_modelo = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).BeginInit();
            this.ToolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dg_productos
            // 
            this.dg_productos.AllowUserToAddRows = false;
            this.dg_productos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_productos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg_productos.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.dg_productos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_productos.GridColor = System.Drawing.Color.DarkKhaki;
            this.dg_productos.Location = new System.Drawing.Point(12, 55);
            this.dg_productos.Name = "dg_productos";
            this.dg_productos.ReadOnly = true;
            this.dg_productos.Size = new System.Drawing.Size(944, 405);
            this.dg_productos.TabIndex = 85;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_actulizar,
            this.btn_cerrar,
            this.ToolStripStatusLabel1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 489);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(975, 31);
            this.ToolStrip1.TabIndex = 84;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btn_actulizar
            // 
            this.btn_actulizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_actulizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actulizar.Image")));
            this.btn_actulizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_actulizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_actulizar.Name = "btn_actulizar";
            this.btn_actulizar.Size = new System.Drawing.Size(28, 28);
            this.btn_actulizar.Text = "Actualizar";
            this.btn_actulizar.Click += new System.EventHandler(this.btn_actulizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_cerrar.DoubleClickEnabled = true;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_cerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(28, 28);
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(0, 28);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label4.Location = new System.Drawing.Point(559, 18);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(123, 16);
            this.Label4.TabIndex = 83;
            this.Label4.Text = "Filtrar por Modelo";
            // 
            // tb_modelo
            // 
            this.tb_modelo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_modelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_modelo.Location = new System.Drawing.Point(688, 16);
            this.tb_modelo.Name = "tb_modelo";
            this.tb_modelo.Size = new System.Drawing.Size(268, 23);
            this.tb_modelo.TabIndex = 82;
            this.tb_modelo.TextChanged += new System.EventHandler(this.Filtrar);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(14, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(249, 23);
            this.Label1.TabIndex = 81;
            this.Label1.Text = "Inventarios de Productos";
            // 
            // InventarioProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 520);
            this.Controls.Add(this.dg_productos);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.tb_modelo);
            this.Controls.Add(this.Label1);
            this.Name = "InventarioProductos";
            this.Text = "InventarioProductos";
            this.Load += new System.EventHandler(this.InventarioProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).EndInit();
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dg_productos;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btn_actulizar;
        internal System.Windows.Forms.ToolStripButton btn_cerrar;
        internal System.Windows.Forms.ToolStripLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tb_modelo;
        internal System.Windows.Forms.Label Label1;
    }
}