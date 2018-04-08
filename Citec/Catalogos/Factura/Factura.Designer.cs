namespace Citec.Catalogos.Factura
{
    partial class Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            this.Label11 = new System.Windows.Forms.Label();
            this.tb_tipoCambio = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.tb_totalgeneral = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.tb_IVA = new System.Windows.Forms.TextBox();
            this.fecha_venc = new System.Windows.Forms.DateTimePicker();
            this.fecha_fac = new System.Windows.Forms.DateTimePicker();
            this.Label6 = new System.Windows.Forms.Label();
            this.rb_credito = new System.Windows.Forms.RadioButton();
            this.rb_contado = new System.Windows.Forms.RadioButton();
            this.tb_numFactura = new System.Windows.Forms.TextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.tb_ruc = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_actualizar = new System.Windows.Forms.ToolStripButton();
            this.btn_cerrar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.Label4 = new System.Windows.Forms.Label();
            this.tb_total = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.dg_orden = new System.Windows.Forms.DataGridView();
            this.Id_Libro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Label8 = new System.Windows.Forms.Label();
            this.tb_filtro = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dg_productos = new System.Windows.Forms.DataGridView();
            this.ToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_orden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).BeginInit();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Blue;
            this.Label11.Location = new System.Drawing.Point(26, 149);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(99, 13);
            this.Label11.TabIndex = 151;
            this.Label11.Text = "Tasa de Cambio";
            // 
            // tb_tipoCambio
            // 
            this.tb_tipoCambio.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tipoCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_tipoCambio.Location = new System.Drawing.Point(132, 146);
            this.tb_tipoCambio.Name = "tb_tipoCambio";
            this.tb_tipoCambio.Size = new System.Drawing.Size(77, 22);
            this.tb_tipoCambio.TabIndex = 150;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.ForeColor = System.Drawing.Color.Blue;
            this.Label10.Location = new System.Drawing.Point(791, 552);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(40, 14);
            this.Label10.TabIndex = 149;
            this.Label10.Text = "Total";
            // 
            // tb_totalgeneral
            // 
            this.tb_totalgeneral.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalgeneral.Location = new System.Drawing.Point(842, 549);
            this.tb_totalgeneral.Name = "tb_totalgeneral";
            this.tb_totalgeneral.ReadOnly = true;
            this.tb_totalgeneral.Size = new System.Drawing.Size(195, 23);
            this.tb_totalgeneral.TabIndex = 148;
            this.tb_totalgeneral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Blue;
            this.Label7.Location = new System.Drawing.Point(792, 523);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(39, 14);
            this.Label7.TabIndex = 147;
            this.Label7.Text = "I.V.A";
            // 
            // tb_IVA
            // 
            this.tb_IVA.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_IVA.Location = new System.Drawing.Point(843, 520);
            this.tb_IVA.Name = "tb_IVA";
            this.tb_IVA.ReadOnly = true;
            this.tb_IVA.Size = new System.Drawing.Size(195, 23);
            this.tb_IVA.TabIndex = 146;
            this.tb_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fecha_venc
            // 
            this.fecha_venc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_venc.Location = new System.Drawing.Point(221, 164);
            this.fecha_venc.Name = "fecha_venc";
            this.fecha_venc.Size = new System.Drawing.Size(120, 20);
            this.fecha_venc.TabIndex = 145;
            // 
            // fecha_fac
            // 
            this.fecha_fac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_fac.Location = new System.Drawing.Point(221, 95);
            this.fecha_fac.Name = "fecha_fac";
            this.fecha_fac.Size = new System.Drawing.Size(120, 20);
            this.fecha_fac.TabIndex = 144;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Blue;
            this.Label6.Location = new System.Drawing.Point(218, 147);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(76, 13);
            this.Label6.TabIndex = 143;
            this.Label6.Text = "Vencimiento";
            // 
            // rb_credito
            // 
            this.rb_credito.AutoSize = true;
            this.rb_credito.Location = new System.Drawing.Point(292, 121);
            this.rb_credito.Name = "rb_credito";
            this.rb_credito.Size = new System.Drawing.Size(58, 17);
            this.rb_credito.TabIndex = 142;
            this.rb_credito.Text = "Credito";
            this.rb_credito.UseVisualStyleBackColor = true;
            // 
            // rb_contado
            // 
            this.rb_contado.AutoSize = true;
            this.rb_contado.Checked = true;
            this.rb_contado.Location = new System.Drawing.Point(221, 121);
            this.rb_contado.Name = "rb_contado";
            this.rb_contado.Size = new System.Drawing.Size(65, 17);
            this.rb_contado.TabIndex = 141;
            this.rb_contado.TabStop = true;
            this.rb_contado.Text = "Contado";
            this.rb_contado.UseVisualStyleBackColor = true;
            // 
            // tb_numFactura
            // 
            this.tb_numFactura.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_numFactura.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_numFactura.Location = new System.Drawing.Point(170, 22);
            this.tb_numFactura.Name = "tb_numFactura";
            this.tb_numFactura.Size = new System.Drawing.Size(177, 22);
            this.tb_numFactura.TabIndex = 140;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(93, 117);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(116, 23);
            this.Button1.TabIndex = 139;
            this.Button1.Text = "Agregar Cliente";
            this.Button1.UseVisualStyleBackColor = true;
            // 
            // tb_ruc
            // 
            this.tb_ruc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ruc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_ruc.Location = new System.Drawing.Point(93, 89);
            this.tb_ruc.Name = "tb_ruc";
            this.tb_ruc.Size = new System.Drawing.Size(116, 22);
            this.tb_ruc.TabIndex = 138;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Blue;
            this.Label5.Location = new System.Drawing.Point(28, 92);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(32, 13);
            this.Label5.TabIndex = 137;
            this.Label5.Text = "RUC";
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_guardar,
            this.btn_actualizar,
            this.btn_cerrar,
            this.ToolStripStatusLabel1});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 600);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(1055, 31);
            this.ToolStrip1.TabIndex = 136;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // btn_guardar
            // 
            this.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(28, 28);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.Image")));
            this.btn_actualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_actualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(28, 28);
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
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
            this.Label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Blue;
            this.Label4.Location = new System.Drawing.Point(765, 494);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(71, 14);
            this.Label4.TabIndex = 135;
            this.Label4.Text = "Sub-Total";
            // 
            // tb_total
            // 
            this.tb_total.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_total.Location = new System.Drawing.Point(842, 491);
            this.tb_total.Name = "tb_total";
            this.tb_total.ReadOnly = true;
            this.tb_total.Size = new System.Drawing.Size(195, 23);
            this.tb_total.TabIndex = 134;
            this.tb_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_total.TextChanged += new System.EventHandler(this.CambioDeSubtotal);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Label3.Location = new System.Drawing.Point(24, 5);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(146, 42);
            this.Label3.TabIndex = 133;
            this.Label3.Text = "Factura";
            // 
            // dg_orden
            // 
            this.dg_orden.AllowUserToAddRows = false;
            this.dg_orden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_orden.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dg_orden.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dg_orden.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dg_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_orden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Libro,
            this.DataGridViewTextBoxColumn1,
            this.DataGridViewTextBoxColumn2,
            this.Precio,
            this.Precio1,
            this.Precio2,
            this.Precio3,
            this.Precio4,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.SubTotal});
            this.dg_orden.GridColor = System.Drawing.Color.DarkKhaki;
            this.dg_orden.Location = new System.Drawing.Point(15, 207);
            this.dg_orden.Name = "dg_orden";
            this.dg_orden.Size = new System.Drawing.Size(1022, 278);
            this.dg_orden.TabIndex = 132;
            this.dg_orden.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            this.dg_orden.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ValidarMaximos);
            this.dg_orden.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.RemoverProducto);
            // 
            // Id_Libro
            // 
            this.Id_Libro.HeaderText = "Id_Libro";
            this.Id_Libro.Name = "Id_Libro";
            this.Id_Libro.Visible = false;
            // 
            // DataGridViewTextBoxColumn1
            // 
            this.DataGridViewTextBoxColumn1.HeaderText = "Modelo";
            this.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1";
            this.DataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn2
            // 
            this.DataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Precio1
            // 
            this.Precio1.HeaderText = "Porcentaje1";
            this.Precio1.Name = "Precio1";
            this.Precio1.Visible = false;
            // 
            // Precio2
            // 
            this.Precio2.HeaderText = "Porcentaje2";
            this.Precio2.Name = "Precio2";
            this.Precio2.Visible = false;
            // 
            // Precio3
            // 
            this.Precio3.HeaderText = "Porcentaje3";
            this.Precio3.Name = "Precio3";
            this.Precio3.Visible = false;
            // 
            // Precio4
            // 
            this.Precio4.HeaderText = "Porcentaje4";
            this.Precio4.Name = "Precio4";
            this.Precio4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Precio1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio2";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Precio3";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio4";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label8.Location = new System.Drawing.Point(743, 12);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(123, 16);
            this.Label8.TabIndex = 129;
            this.Label8.Text = "Filtrar por Modelo";
            // 
            // tb_filtro
            // 
            this.tb_filtro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_filtro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_filtro.Location = new System.Drawing.Point(872, 10);
            this.tb_filtro.Name = "tb_filtro";
            this.tb_filtro.Size = new System.Drawing.Size(166, 23);
            this.tb_filtro.TabIndex = 128;
            this.tb_filtro.TextChanged += new System.EventHandler(this.Filtrar);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Blue;
            this.Label9.Location = new System.Drawing.Point(557, 10);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(146, 18);
            this.Label9.TabIndex = 127;
            this.Label9.Text = "Agregar Productos";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Blue;
            this.Label2.Location = new System.Drawing.Point(218, 78);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(40, 13);
            this.Label2.TabIndex = 126;
            this.Label2.Text = "Fecha";
            // 
            // tb_nombre
            // 
            this.tb_nombre.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tb_nombre.Location = new System.Drawing.Point(93, 53);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(254, 22);
            this.tb_nombre.TabIndex = 125;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Blue;
            this.Label1.Location = new System.Drawing.Point(28, 55);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 124;
            this.Label1.Text = "Nombre";
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
            this.dg_productos.Location = new System.Drawing.Point(387, 39);
            this.dg_productos.Name = "dg_productos";
            this.dg_productos.ReadOnly = true;
            this.dg_productos.Size = new System.Drawing.Size(651, 145);
            this.dg_productos.TabIndex = 130;
            this.dg_productos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgregarProducto);
            this.dg_productos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgregarProducto);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 631);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.tb_tipoCambio);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.tb_totalgeneral);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.tb_IVA);
            this.Controls.Add(this.fecha_venc);
            this.Controls.Add(this.fecha_fac);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.rb_credito);
            this.Controls.Add(this.rb_contado);
            this.Controls.Add(this.tb_numFactura);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.tb_ruc);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.tb_total);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.dg_orden);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.tb_filtro);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.tb_nombre);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.dg_productos);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_orden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox tb_tipoCambio;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox tb_totalgeneral;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox tb_IVA;
        internal System.Windows.Forms.DateTimePicker fecha_venc;
        internal System.Windows.Forms.DateTimePicker fecha_fac;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.RadioButton rb_credito;
        internal System.Windows.Forms.RadioButton rb_contado;
        internal System.Windows.Forms.TextBox tb_numFactura;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox tb_ruc;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton btn_guardar;
        internal System.Windows.Forms.ToolStripButton btn_actualizar;
        internal System.Windows.Forms.ToolStripButton btn_cerrar;
        internal System.Windows.Forms.ToolStripLabel ToolStripStatusLabel1;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox tb_total;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DataGridView dg_orden;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Id_Libro;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Precio1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Precio2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Precio3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Precio4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        internal System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox tb_filtro;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox tb_nombre;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dg_productos;
    }
}