namespace Gestor_de_Inventario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IniciodeSeccion = new System.Windows.Forms.Button();
            this.chkRecordar = new System.Windows.Forms.CheckBox();
            this.picVerClave = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picVerClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(351, 52);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(202, 30);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsuario_KeyDown);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(352, 135);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(202, 30);
            this.txtClave.TabIndex = 1;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtClave_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(391, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // IniciodeSeccion
            // 
            this.IniciodeSeccion.Location = new System.Drawing.Point(352, 184);
            this.IniciodeSeccion.Margin = new System.Windows.Forms.Padding(4);
            this.IniciodeSeccion.Name = "IniciodeSeccion";
            this.IniciodeSeccion.Size = new System.Drawing.Size(170, 53);
            this.IniciodeSeccion.TabIndex = 4;
            this.IniciodeSeccion.Text = "Iniciar Seccion";
            this.IniciodeSeccion.UseVisualStyleBackColor = true;
            this.IniciodeSeccion.Click += new System.EventHandler(this.IniciodeSeccion_Click);
            this.IniciodeSeccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IniciodeSeccion_KeyDown);
            // 
            // chkRecordar
            // 
            this.chkRecordar.AutoSize = true;
            this.chkRecordar.Location = new System.Drawing.Point(315, 247);
            this.chkRecordar.Name = "chkRecordar";
            this.chkRecordar.Size = new System.Drawing.Size(181, 27);
            this.chkRecordar.TabIndex = 8;
            this.chkRecordar.Text = "Recordar Usuario";
            this.chkRecordar.UseVisualStyleBackColor = true;
            // 
            // picVerClave
            // 
            this.picVerClave.Image = global::Gestor_de_Inventario.Properties.Resources._8442581;
            this.picVerClave.Location = new System.Drawing.Point(540, 132);
            this.picVerClave.Name = "picVerClave";
            this.picVerClave.Size = new System.Drawing.Size(39, 37);
            this.picVerClave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picVerClave.TabIndex = 9;
            this.picVerClave.TabStop = false;
            this.picVerClave.Click += new System.EventHandler(this.picVerClave_Click_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Gestor_de_Inventario.Properties.Resources.pngtree_lock_icon_png_image_16468872__1_;
            this.pictureBox3.Location = new System.Drawing.Point(300, 132);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 51);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Gestor_de_Inventario.Properties.Resources.png_clipart_profile_logo_computer_icons_user_user_blue_heroes_thumbnail__1_;
            this.pictureBox2.Location = new System.Drawing.Point(292, 51);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestor_de_Inventario.Properties.Resources._2f6356591b811d53630db26de04bde41__1_;
            this.pictureBox1.Location = new System.Drawing.Point(13, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 290);
            this.Controls.Add(this.picVerClave);
            this.Controls.Add(this.chkRecordar);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.IniciodeSeccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Inicio de Seccion";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picVerClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IniciodeSeccion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox chkRecordar;
        private System.Windows.Forms.PictureBox picVerClave;
    }
}

