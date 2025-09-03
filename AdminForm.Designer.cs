namespace InventarioApp
{
    partial class FrmDashboard
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
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbModoOscuro = new System.Windows.Forms.PictureBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.btnSalidas = new System.Windows.Forms.Button();
            this.btnEntradas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlertas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxActividad = new System.Windows.Forms.ListBox();
            this.j = new System.Windows.Forms.GroupBox();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.Busque = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModoOscuro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductos.Location = new System.Drawing.Point(311, 348);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.RowTemplate.Height = 24;
            this.dgvProductos.Size = new System.Drawing.Size(659, 270);
            this.dgvProductos.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbModoOscuro);
            this.panel1.Controls.Add(this.lblRol);
            this.panel1.Controls.Add(this.btnSalidas);
            this.panel1.Controls.Add(this.btnEntradas);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.btnProveedores);
            this.panel1.Controls.Add(this.btnCategorias);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 661);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pbModoOscuro
            // 
            this.pbModoOscuro.Image = global::Gestor_de_Inventario.Properties.Resources.pngtree_sun_line_icon_png_image_90407601;
            this.pbModoOscuro.Location = new System.Drawing.Point(3, 3);
            this.pbModoOscuro.Name = "pbModoOscuro";
            this.pbModoOscuro.Size = new System.Drawing.Size(54, 54);
            this.pbModoOscuro.TabIndex = 6;
            this.pbModoOscuro.TabStop = false;
            this.pbModoOscuro.Click += new System.EventHandler(this.pbModoOscuro_Click);
            // 
            // lblRol
            // 
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(144, 56);
            this.lblRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 23);
            this.lblRol.TabIndex = 5;
            // 
            // btnSalidas
            // 
            this.btnSalidas.Location = new System.Drawing.Point(13, 290);
            this.btnSalidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalidas.Name = "btnSalidas";
            this.btnSalidas.Size = new System.Drawing.Size(249, 70);
            this.btnSalidas.TabIndex = 4;
            this.btnSalidas.Text = "Salida";
            this.btnSalidas.UseVisualStyleBackColor = true;
            this.btnSalidas.Click += new System.EventHandler(this.btnSalidas_Click_1);
            this.btnSalidas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSalidas_KeyDown);
            // 
            // btnEntradas
            // 
            this.btnEntradas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEntradas.Location = new System.Drawing.Point(13, 177);
            this.btnEntradas.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntradas.Name = "btnEntradas";
            this.btnEntradas.Size = new System.Drawing.Size(249, 66);
            this.btnEntradas.TabIndex = 3;
            this.btnEntradas.Text = "Entrada";
            this.btnEntradas.UseVisualStyleBackColor = true;
            this.btnEntradas.Click += new System.EventHandler(this.btnEntradas_Click_1);
            this.btnEntradas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEntradas_KeyDown);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(13, 89);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(249, 59);
            this.btnProductos.TabIndex = 2;
            this.btnProductos.Text = "Producto";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            this.btnProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnProductos_KeyDown);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Location = new System.Drawing.Point(13, 514);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(249, 65);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedor";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click_1);
            this.btnProveedores.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnProveedores_KeyDown);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Location = new System.Drawing.Point(13, 397);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(249, 65);
            this.btnCategorias.TabIndex = 0;
            this.btnCategorias.Text = "Categoria ";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.button1_Click);
            this.btnCategorias.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnCategorias_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1017, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Administrador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAlertas
            // 
            this.lblAlertas.AutoSize = true;
            this.lblAlertas.Location = new System.Drawing.Point(353, 57);
            this.lblAlertas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAlertas.Name = "lblAlertas";
            this.lblAlertas.Size = new System.Drawing.Size(200, 23);
            this.lblAlertas.TabIndex = 5;
            this.lblAlertas.Text = "Alertas de Inventario\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxActividad);
            this.groupBox1.Location = new System.Drawing.Point(684, 57);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(443, 264);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alertas de Inventario";
            // 
            // listBoxActividad
            // 
            this.listBoxActividad.FormattingEnabled = true;
            this.listBoxActividad.ItemHeight = 23;
            this.listBoxActividad.Location = new System.Drawing.Point(17, 33);
            this.listBoxActividad.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxActividad.Name = "listBoxActividad";
            this.listBoxActividad.Size = new System.Drawing.Size(409, 211);
            this.listBoxActividad.TabIndex = 0;
            // 
            // j
            // 
            this.j.Location = new System.Drawing.Point(311, 89);
            this.j.Margin = new System.Windows.Forms.Padding(4);
            this.j.Name = "j";
            this.j.Padding = new System.Windows.Forms.Padding(4);
            this.j.Size = new System.Drawing.Size(338, 106);
            this.j.TabIndex = 7;
            this.j.TabStop = false;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(311, 264);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(338, 30);
            this.txtBusqueda.TabIndex = 8;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged_1);
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            // 
            // Busque
            // 
            this.Busque.AutoSize = true;
            this.Busque.Location = new System.Drawing.Point(310, 225);
            this.Busque.Name = "Busque";
            this.Busque.Size = new System.Drawing.Size(155, 23);
            this.Busque.TabIndex = 9;
            this.Busque.Text = "Buscar productos";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1013, 348);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(114, 40);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            this.btnActualizar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnActualizar_KeyDown);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(1020, 466);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(107, 40);
            this.btnAtras.TabIndex = 11;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            this.btnAtras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAtras_KeyDown);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1020, 585);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 33);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSalir_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1020, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 661);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.Busque);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.j);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblAlertas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvProductos);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDashboard";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbModoOscuro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalidas;
        private System.Windows.Forms.Button btnEntradas;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlertas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox j;
        private System.Windows.Forms.ListBox listBoxActividad;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label Busque;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pbModoOscuro;
        private System.Windows.Forms.Button button1;
    }
}