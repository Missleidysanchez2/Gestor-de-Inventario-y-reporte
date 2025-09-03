namespace Gestor_de_Inventario
{
    partial class UsuarioForm
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.gestordeInventarioDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestordeInventarioDataSet2 = new Gestor_de_Inventario.GestordeInventarioDataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.gestordeInventarioDataSet = new Gestor_de_Inventario.GestordeInventarioDataSet();
            this.gestordeInventarioDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosTableAdapter = new Gestor_de_Inventario.GestordeInventarioDataSetTableAdapters.ProductosTableAdapter();
            this.gestordeInventarioDataSet1 = new Gestor_de_Inventario.GestordeInventarioDataSet1();
            this.gestordeInventarioDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestordeInventarioDataSet3 = new Gestor_de_Inventario.GestordeInventarioDataSet3();
            this.gestordeInventarioDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gestordeInventarioDataSet2BindingSource
            // 
            this.gestordeInventarioDataSet2BindingSource.DataSource = this.gestordeInventarioDataSet2;
            this.gestordeInventarioDataSet2BindingSource.Position = 0;
            // 
            // gestordeInventarioDataSet2
            // 
            this.gestordeInventarioDataSet2.DataSetName = "GestordeInventarioDataSet2";
            this.gestordeInventarioDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gestordeInventarioDataSet3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Gestor_de_Inventario.Reporte.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(779, 377);
            this.reportViewer1.TabIndex = 0;
            // 
            // gestordeInventarioDataSet
            // 
            this.gestordeInventarioDataSet.DataSetName = "GestordeInventarioDataSet";
            this.gestordeInventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestordeInventarioDataSetBindingSource
            // 
            this.gestordeInventarioDataSetBindingSource.DataSource = this.gestordeInventarioDataSet;
            this.gestordeInventarioDataSetBindingSource.Position = 0;
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.gestordeInventarioDataSetBindingSource;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // gestordeInventarioDataSet1
            // 
            this.gestordeInventarioDataSet1.DataSetName = "GestordeInventarioDataSet1";
            this.gestordeInventarioDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestordeInventarioDataSet1BindingSource
            // 
            this.gestordeInventarioDataSet1BindingSource.DataSource = this.gestordeInventarioDataSet1;
            this.gestordeInventarioDataSet1BindingSource.Position = 0;
            // 
            // gestordeInventarioDataSet3
            // 
            this.gestordeInventarioDataSet3.DataSetName = "GestordeInventarioDataSet3";
            this.gestordeInventarioDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestordeInventarioDataSet3BindingSource
            // 
            this.gestordeInventarioDataSet3BindingSource.DataSource = this.gestordeInventarioDataSet3;
            this.gestordeInventarioDataSet3BindingSource.Position = 0;
            // 
            // UsuarioForm
            // 
            this.ClientSize = new System.Drawing.Size(779, 377);
            this.Controls.Add(this.reportViewer1);
            this.Name = "UsuarioForm";
            this.Load += new System.EventHandler(this.UsuarioForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestordeInventarioDataSet3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gestordeInventarioDataSetBindingSource;
        private GestordeInventarioDataSet gestordeInventarioDataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private GestordeInventarioDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource gestordeInventarioDataSet1BindingSource;
        private GestordeInventarioDataSet1 gestordeInventarioDataSet1;
        private System.Windows.Forms.BindingSource gestordeInventarioDataSet2BindingSource;
        private GestordeInventarioDataSet2 gestordeInventarioDataSet2;
        private System.Windows.Forms.BindingSource gestordeInventarioDataSet3BindingSource;
        private GestordeInventarioDataSet3 gestordeInventarioDataSet3;
    }
}