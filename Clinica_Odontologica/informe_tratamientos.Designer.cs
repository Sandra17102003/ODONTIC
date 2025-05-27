namespace Clinica_Odontologica
{
    partial class informe_tratamientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informe_tratamientos));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odonticDataSet = new Clinica_Odontologica.OdonticDataSet();
            this.tratamiento_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tratamiento_DetalleTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.Tratamiento_DetalleTableAdapter();
            this.tableAdapterManager = new Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager();
            this.tratamientosTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.TratamientosTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamiento_DetalleBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tratamientosBindingSource
            // 
            this.tratamientosBindingSource.DataMember = "Tratamientos";
            this.tratamientosBindingSource.DataSource = this.odonticDataSet;
            // 
            // odonticDataSet
            // 
            this.odonticDataSet.DataSetName = "OdonticDataSet";
            this.odonticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tratamiento_DetalleBindingSource
            // 
            this.tratamiento_DetalleBindingSource.DataMember = "Tratamiento_Detalle";
            this.tratamiento_DetalleBindingSource.DataSource = this.odonticDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 754);
            this.panel1.TabIndex = 10;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tratamientosBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.tratamiento_DetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clinica_Odontologica.informe_tratamientos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(72, 22);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1131, 693);
            this.reportViewer1.TabIndex = 0;
            // 
            // tratamiento_DetalleTableAdapter
            // 
            this.tratamiento_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.Compra_DetalleTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.MarcaTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Tipo_TratamientoTableAdapter = null;
            this.tableAdapterManager.Tratamiento_DetalleTableAdapter = this.tratamiento_DetalleTableAdapter;
            this.tableAdapterManager.TratamientosTableAdapter = this.tratamientosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Venta_DetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // tratamientosTableAdapter
            // 
            this.tratamientosTableAdapter.ClearBeforeFill = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "ODONTIC.chm";
            // 
            // informe_tratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 754);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "22");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "informe_tratamientos";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Informe de los tratamientos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.informe_tratamientos_FormClosing);
            this.Load += new System.EventHandler(this.informe_tratamientos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamiento_DetalleBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private OdonticDataSet odonticDataSet;
        private System.Windows.Forms.BindingSource tratamiento_DetalleBindingSource;
        private OdonticDataSetTableAdapters.Tratamiento_DetalleTableAdapter tratamiento_DetalleTableAdapter;
        private OdonticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private OdonticDataSetTableAdapters.TratamientosTableAdapter tratamientosTableAdapter;
        private System.Windows.Forms.BindingSource tratamientosBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}