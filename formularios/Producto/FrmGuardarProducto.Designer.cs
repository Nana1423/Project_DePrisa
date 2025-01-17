﻿namespace POS_DePrisa.formularios.Producto
{
    partial class FrmGuardarProducto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpProducto = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbKitSi = new System.Windows.Forms.RadioButton();
            this.rbKitNo = new System.Windows.Forms.RadioButton();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.rbIvaSi = new System.Windows.Forms.RadioButton();
            this.rbIvaNo = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvListaKit = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvListaProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvListaProductoPrincipal = new System.Windows.Forms.DataGridView();
            this.roundedButton3 = new POS_DePrisa.customControls.RoundedButton();
            this.roundedButton2 = new POS_DePrisa.customControls.RoundedButton();
            this.roundedButton1 = new POS_DePrisa.customControls.RoundedButton();
            this.btnGuardarProducto = new POS_DePrisa.customControls.RoundedButton();
            this.btnAgregar = new POS_DePrisa.customControls.RoundedButton();
            this.btnQuitar = new POS_DePrisa.customControls.RoundedButton();
            this.tabControl1.SuspendLayout();
            this.tpProducto.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpProducto);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 484);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Tag = "Producto";
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpProducto
            // 
            this.tpProducto.BackColor = System.Drawing.Color.Transparent;
            this.tpProducto.Controls.Add(this.roundedButton3);
            this.tpProducto.Controls.Add(this.roundedButton2);
            this.tpProducto.Controls.Add(this.roundedButton1);
            this.tpProducto.Controls.Add(this.panel2);
            this.tpProducto.Controls.Add(this.btnGuardarProducto);
            this.tpProducto.Controls.Add(this.txtDescuento);
            this.tpProducto.Controls.Add(this.txtPrecio);
            this.tpProducto.Controls.Add(this.txtCantidad);
            this.tpProducto.Controls.Add(this.cbxCategoria);
            this.tpProducto.Controls.Add(this.txtDescripcion);
            this.tpProducto.Controls.Add(this.txtNombre);
            this.tpProducto.Controls.Add(this.txtCodigoBarra);
            this.tpProducto.Controls.Add(this.rbIvaSi);
            this.tpProducto.Controls.Add(this.rbIvaNo);
            this.tpProducto.Controls.Add(this.label9);
            this.tpProducto.Controls.Add(this.label5);
            this.tpProducto.Controls.Add(this.label8);
            this.tpProducto.Controls.Add(this.label7);
            this.tpProducto.Controls.Add(this.label1);
            this.tpProducto.Controls.Add(this.label6);
            this.tpProducto.Controls.Add(this.label4);
            this.tpProducto.Controls.Add(this.label3);
            this.tpProducto.Controls.Add(this.label2);
            this.tpProducto.ImageKey = "(ninguno)";
            this.tpProducto.Location = new System.Drawing.Point(4, 22);
            this.tpProducto.Name = "tpProducto";
            this.tpProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tpProducto.Size = new System.Drawing.Size(764, 458);
            this.tpProducto.TabIndex = 1;
            this.tpProducto.Text = "Nuevo producto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbKitSi);
            this.panel2.Controls.Add(this.rbKitNo);
            this.panel2.Location = new System.Drawing.Point(131, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 32);
            this.panel2.TabIndex = 22;
            // 
            // rbKitSi
            // 
            this.rbKitSi.AutoSize = true;
            this.rbKitSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKitSi.Location = new System.Drawing.Point(54, 8);
            this.rbKitSi.Name = "rbKitSi";
            this.rbKitSi.Size = new System.Drawing.Size(38, 21);
            this.rbKitSi.TabIndex = 6;
            this.rbKitSi.TabStop = true;
            this.rbKitSi.Text = "SI";
            this.rbKitSi.UseVisualStyleBackColor = true;
            this.rbKitSi.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbKitNo
            // 
            this.rbKitNo.AutoSize = true;
            this.rbKitNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbKitNo.Location = new System.Drawing.Point(1, 8);
            this.rbKitNo.Name = "rbKitNo";
            this.rbKitNo.Size = new System.Drawing.Size(47, 21);
            this.rbKitNo.TabIndex = 5;
            this.rbKitNo.TabStop = true;
            this.rbKitNo.Text = "NO";
            this.rbKitNo.UseVisualStyleBackColor = true;
            this.rbKitNo.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(131, 225);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(64, 20);
            this.txtDescuento.TabIndex = 20;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(131, 188);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(64, 20);
            this.txtPrecio.TabIndex = 19;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(131, 154);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(64, 20);
            this.txtCantidad.TabIndex = 18;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(131, 125);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(179, 21);
            this.cbxCategoria.TabIndex = 17;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(131, 80);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(209, 39);
            this.txtDescripcion.TabIndex = 16;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 15;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(131, 22);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(209, 20);
            this.txtCodigoBarra.TabIndex = 14;
            // 
            // rbIvaSi
            // 
            this.rbIvaSi.AutoSize = true;
            this.rbIvaSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIvaSi.Location = new System.Drawing.Point(184, 301);
            this.rbIvaSi.Name = "rbIvaSi";
            this.rbIvaSi.Size = new System.Drawing.Size(38, 21);
            this.rbIvaSi.TabIndex = 13;
            this.rbIvaSi.Text = "SI";
            this.rbIvaSi.UseVisualStyleBackColor = true;
            // 
            // rbIvaNo
            // 
            this.rbIvaNo.AutoSize = true;
            this.rbIvaNo.Checked = true;
            this.rbIvaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbIvaNo.Location = new System.Drawing.Point(131, 301);
            this.rbIvaNo.Name = "rbIvaNo";
            this.rbIvaNo.Size = new System.Drawing.Size(47, 21);
            this.rbIvaNo.TabIndex = 12;
            this.rbIvaNo.TabStop = true;
            this.rbIvaNo.Text = "NO";
            this.rbIvaNo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(34, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tiene IVA?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Descuento(%)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cantidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tiene kit?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo de barras";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.dgvListaKit);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtBuscarProducto);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.dgvListaProductos);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.btnQuitar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 458);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Detalles Kit";
            // 
            // dgvListaKit
            // 
            this.dgvListaKit.AllowUserToAddRows = false;
            this.dgvListaKit.AllowUserToDeleteRows = false;
            this.dgvListaKit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaKit.Location = new System.Drawing.Point(441, 77);
            this.dgvListaKit.MultiSelect = false;
            this.dgvListaKit.Name = "dgvListaKit";
            this.dgvListaKit.ReadOnly = true;
            this.dgvListaKit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaKit.Size = new System.Drawing.Size(306, 306);
            this.dgvListaKit.TabIndex = 12;
            this.dgvListaKit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaKit_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(438, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(195, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "Productos que pertenecen al kit";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(11, 37);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(306, 20);
            this.txtBuscarProducto.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Buscar Producto";
            // 
            // dgvListaProductos
            // 
            this.dgvListaProductos.AllowUserToAddRows = false;
            this.dgvListaProductos.AllowUserToDeleteRows = false;
            this.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductos.Location = new System.Drawing.Point(11, 77);
            this.dgvListaProductos.MultiSelect = false;
            this.dgvListaProductos.Name = "dgvListaProductos";
            this.dgvListaProductos.ReadOnly = true;
            this.dgvListaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProductos.Size = new System.Drawing.Size(306, 306);
            this.dgvListaProductos.TabIndex = 0;
            this.dgvListaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaProductos_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 10);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(799, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Buscar Producto";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(802, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 20);
            this.textBox1.TabIndex = 11;
            // 
            // dgvListaProductoPrincipal
            // 
            this.dgvListaProductoPrincipal.AllowUserToAddRows = false;
            this.dgvListaProductoPrincipal.AllowUserToDeleteRows = false;
            this.dgvListaProductoPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProductoPrincipal.Location = new System.Drawing.Point(802, 109);
            this.dgvListaProductoPrincipal.MultiSelect = false;
            this.dgvListaProductoPrincipal.Name = "dgvListaProductoPrincipal";
            this.dgvListaProductoPrincipal.ReadOnly = true;
            this.dgvListaProductoPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaProductoPrincipal.Size = new System.Drawing.Size(424, 306);
            this.dgvListaProductoPrincipal.TabIndex = 12;
            // 
            // roundedButton3
            // 
            this.roundedButton3.AutoSize = true;
            this.roundedButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.roundedButton3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.roundedButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedButton3.BorderRadius = 10;
            this.roundedButton3.BorderSize = 1;
            this.roundedButton3.FlatAppearance.BorderSize = 0;
            this.roundedButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton3.ForeColor = System.Drawing.Color.Black;
            this.roundedButton3.Image = global::POS_DePrisa.Properties.Resources.iconClean24;
            this.roundedButton3.Location = new System.Drawing.Point(37, 343);
            this.roundedButton3.Name = "roundedButton3";
            this.roundedButton3.Size = new System.Drawing.Size(95, 38);
            this.roundedButton3.TabIndex = 25;
            this.roundedButton3.Text = "Limpiar ";
            this.roundedButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton3.TextColor = System.Drawing.Color.Black;
            this.roundedButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton3.UseVisualStyleBackColor = false;
            // 
            // roundedButton2
            // 
            this.roundedButton2.AutoSize = true;
            this.roundedButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.roundedButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.roundedButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedButton2.BorderRadius = 10;
            this.roundedButton2.BorderSize = 1;
            this.roundedButton2.FlatAppearance.BorderSize = 0;
            this.roundedButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton2.ForeColor = System.Drawing.Color.Black;
            this.roundedButton2.Image = global::POS_DePrisa.Properties.Resources.iconDelete24;
            this.roundedButton2.Location = new System.Drawing.Point(341, 343);
            this.roundedButton2.Name = "roundedButton2";
            this.roundedButton2.Size = new System.Drawing.Size(89, 38);
            this.roundedButton2.TabIndex = 24;
            this.roundedButton2.Text = "Eliminar";
            this.roundedButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton2.TextColor = System.Drawing.Color.Black;
            this.roundedButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton2.UseVisualStyleBackColor = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.AutoSize = true;
            this.roundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.roundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.roundedButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.roundedButton1.BorderRadius = 10;
            this.roundedButton1.BorderSize = 1;
            this.roundedButton1.FlatAppearance.BorderSize = 0;
            this.roundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roundedButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundedButton1.ForeColor = System.Drawing.Color.Black;
            this.roundedButton1.Image = global::POS_DePrisa.Properties.Resources.icondUpdate24;
            this.roundedButton1.Location = new System.Drawing.Point(234, 343);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(101, 38);
            this.roundedButton1.TabIndex = 23;
            this.roundedButton1.Text = "Actualizar";
            this.roundedButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.roundedButton1.TextColor = System.Drawing.Color.Black;
            this.roundedButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.roundedButton1.UseVisualStyleBackColor = false;
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.AutoSize = true;
            this.btnGuardarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.btnGuardarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.btnGuardarProducto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGuardarProducto.BorderRadius = 10;
            this.btnGuardarProducto.BorderSize = 1;
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarProducto.Image = global::POS_DePrisa.Properties.Resources.iconAdd24;
            this.btnGuardarProducto.Location = new System.Drawing.Point(138, 343);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(90, 38);
            this.btnGuardarProducto.TabIndex = 21;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardarProducto.TextColor = System.Drawing.Color.Black;
            this.btnGuardarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.btnAgregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.btnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.BorderRadius = 10;
            this.btnAgregar.BorderSize = 1;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = global::POS_DePrisa.Properties.Resources.iconAdd28;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(323, 162);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 38);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.TextColor = System.Drawing.Color.Black;
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.AutoSize = true;
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.btnQuitar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(243)))));
            this.btnQuitar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnQuitar.BorderRadius = 10;
            this.btnQuitar.BorderSize = 1;
            this.btnQuitar.Enabled = false;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.Color.Black;
            this.btnQuitar.Image = global::POS_DePrisa.Properties.Resources.iconClose32;
            this.btnQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitar.Location = new System.Drawing.Point(323, 206);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(112, 38);
            this.btnQuitar.TabIndex = 6;
            this.btnQuitar.Text = "Remover ";
            this.btnQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitar.TextColor = System.Drawing.Color.Black;
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = false;
            // 
            // FrmGuardarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1238, 494);
            this.Controls.Add(this.dgvListaProductoPrincipal);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmGuardarProducto";
            this.Text = "FrmGuardarProducto";
            this.Load += new System.EventHandler(this.FrmGuardarProducto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpProducto.ResumeLayout(false);
            this.tpProducto.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaKit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProductoPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpProducto;
        private System.Windows.Forms.RadioButton rbKitSi;
        private System.Windows.Forms.RadioButton rbKitNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.RadioButton rbIvaSi;
        private System.Windows.Forms.RadioButton rbIvaNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private customControls.RoundedButton btnGuardarProducto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvListaProductos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Label label11;
        private customControls.RoundedButton btnAgregar;
        private customControls.RoundedButton btnQuitar;
        private System.Windows.Forms.DataGridView dgvListaKit;
        private customControls.RoundedButton roundedButton3;
        private customControls.RoundedButton roundedButton2;
        private customControls.RoundedButton roundedButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvListaProductoPrincipal;
    }
}