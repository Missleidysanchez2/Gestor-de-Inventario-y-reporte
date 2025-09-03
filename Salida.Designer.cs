namespace Gestor_de_Inventario
{
    partial class Salida
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
            this.btnRegistrarSalida = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.TextBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cmbMotivo = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarSalida
            // 
            this.btnRegistrarSalida.Location = new System.Drawing.Point(45, 166);
            this.btnRegistrarSalida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrarSalida.Name = "btnRegistrarSalida";
            this.btnRegistrarSalida.Size = new System.Drawing.Size(220, 45);
            this.btnRegistrarSalida.TabIndex = 0;
            this.btnRegistrarSalida.Text = "Registro de salida ";
            this.btnRegistrarSalida.UseVisualStyleBackColor = true;
            this.btnRegistrarSalida.Click += new System.EventHandler(this.btnRegistrarSalida_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre de Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Motivo";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(510, 118);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(96, 30);
            this.lblUsuario.TabIndex = 13;
            //this.lblUsuario.TextChanged += new System.EventHandler(this.lblUsuario_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha";
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.Location = new System.Drawing.Point(35, 228);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.Size = new System.Drawing.Size(554, 259);
            this.dgvHistorial.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 23);
            this.label7.TabIndex = 16;
            this.label7.Text = "Salida de inventario";
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(243, 121);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(176, 30);
            this.lblFecha.TabIndex = 18;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(213, 79);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(180, 31);
            this.cmbProductos.TabIndex = 19;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(504, 75);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(38, 30);
            this.txtCantidad.TabIndex = 20;
            // 
            // cmbMotivo
            // 
            this.cmbMotivo.FormattingEnabled = true;
            this.cmbMotivo.Location = new System.Drawing.Point(92, 118);
            this.cmbMotivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMotivo.Name = "cmbMotivo";
            this.cmbMotivo.Size = new System.Drawing.Size(80, 31);
            this.cmbMotivo.TabIndex = 21;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(458, 178);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(107, 33);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(314, 169);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(107, 40);
            this.btnAtras.TabIndex = 22;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // Salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 520);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.cmbMotivo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvHistorial);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrarSalida);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Salida";
            this.Text = "Salida";
            this.Load += new System.EventHandler(this.Salida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarSalida;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lblUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lblFecha;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbMotivo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAtras;
    }
}