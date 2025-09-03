namespace GestorInventario
{
    partial class ProductosForm
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
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnTema = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.Agregar = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.ComboBox();
            this.txtCategoria = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTema)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 818);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "label10";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnTema);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.Agregar);
            this.panel1.Controls.Add(this.txtProveedor);
            this.panel1.Controls.Add(this.txtCategoria);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.txtCodigo);
            this.panel1.Controls.Add(this.txtPrecio);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(38, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 546);
            this.panel1.TabIndex = 11;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(684, 259);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(91, 36);
            this.btnAtras.TabIndex = 23;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(547, 259);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(96, 36);
            this.btnSalir.TabIndex = 22;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTema
            // 
            this.btnTema.Image = global::Gestor_de_Inventario.Properties.Resources.pngtree_sun_line_icon_png_image_90407601;
            this.btnTema.Location = new System.Drawing.Point(799, 4);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(58, 50);
            this.btnTema.TabIndex = 21;
            this.btnTema.TabStop = false;
            this.btnTema.Click += new System.EventHandler(this.btnTema_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(369, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Proveedor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Categoria";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 23);
            this.label5.TabIndex = 17;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(472, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Codigo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre de producto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestor_de_Inventario.Properties.Resources.png_clipart_computer_icons_edison_state_community_college_google_search_symbol_magnifying_glass_material_logo_google_logo;
            this.pictureBox1.Location = new System.Drawing.Point(29, 34);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 39);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(149, 129);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(316, 55);
            this.txtDescripcion.TabIndex = 12;
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(13, 330);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(845, 184);
            this.dgvProductos.TabIndex = 11;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(390, 259);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 36);
            this.button3.TabIndex = 10;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(232, 259);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 36);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Editar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Agregar
            // 
            this.Agregar.Location = new System.Drawing.Point(86, 259);
            this.Agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(96, 36);
            this.Agregar.TabIndex = 8;
            this.Agregar.Text = "Agregar";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click_1);
            // 
            // txtProveedor
            // 
            this.txtProveedor.FormattingEnabled = true;
            this.txtProveedor.Location = new System.Drawing.Point(493, 200);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(199, 31);
            this.txtProveedor.TabIndex = 7;
            // 
            // txtCategoria
            // 
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.Location = new System.Drawing.Point(149, 197);
            this.txtCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(185, 31);
            this.txtCategoria.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(731, 90);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(58, 30);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(547, 93);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(77, 30);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(547, 147);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(56, 30);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(230, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 30);
            this.txtNombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Producto";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(77, 41);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(388, 30);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged_1);
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 601);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProductosForm";
            this.Text = "ProductosForm";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnTema)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.ComboBox txtProveedor;
        private System.Windows.Forms.ComboBox txtCategoria;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox btnTema;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAtras;
    }
}