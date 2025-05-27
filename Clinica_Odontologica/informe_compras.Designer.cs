namespace Clinica_Odontologica
{
    partial class informe_compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informe_compras));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odonticDataSet = new Clinica_Odontologica.OdonticDataSet();
            this.compra_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.compra_DetalleTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.Compra_DetalleTableAdapter();
            this.tableAdapterManager = new Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager();
            this.comprasTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.ComprasTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compra_DetalleBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.odonticDataSet;
            // 
            // odonticDataSet
            // 
            this.odonticDataSet.DataSetName = "OdonticDataSet";
            this.odonticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compra_DetalleBindingSource
            // 
            this.compra_DetalleBindingSource.DataMember = "Compra_Detalle";
            this.compra_DetalleBindingSource.DataSource = this.odonticDataSet;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 754);
            this.panel1.TabIndex = 7;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 88;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.comprasBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.compra_DetalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Clinica_Odontologica.informe_compras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(80, 29);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1130, 692);
            this.reportViewer1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 104);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(6, 6);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // compra_DetalleTableAdapter
            // 
            this.compra_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.Compra_DetalleTableAdapter = this.compra_DetalleTableAdapter;
            this.tableAdapterManager.ComprasTableAdapter = this.comprasTableAdapter;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.MarcaTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Tipo_TratamientoTableAdapter = null;
            this.tableAdapterManager.Tratamiento_DetalleTableAdapter = null;
            this.tableAdapterManager.TratamientosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Venta_DetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "ODONTIC.chm";
            // 
            // informe_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 754);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "19");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "informe_compras";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Informe de las compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.informe_compras_FormClosing);
            this.Load += new System.EventHandler(this.informe_compras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compra_DetalleBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private OdonticDataSet odonticDataSet;
        private System.Windows.Forms.BindingSource compra_DetalleBindingSource;
        private OdonticDataSetTableAdapters.Compra_DetalleTableAdapter compra_DetalleTableAdapter;
        private OdonticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private OdonticDataSetTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}