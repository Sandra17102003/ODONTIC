namespace Clinica_Odontologica
{
    partial class informe_empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informe_empleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.button1 = new System.Windows.Forms.Button();
            this.filtrar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.deshacer = new System.Windows.Forms.Button();
            this.lupa = new System.Windows.Forms.Button();
            this.filtrarTextBox = new System.Windows.Forms.TextBox();
            this.filtrarComboBox = new System.Windows.Forms.ComboBox();
            this.empleados_pictureBox = new System.Windows.Forms.PictureBox();
            this.odonticDataSet = new Clinica_Odontologica.OdonticDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleados_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.filtrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 754);
            this.panel1.TabIndex = 6;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 88;
            this.reportViewer1.Location = new System.Drawing.Point(26, 11);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(989, 732);
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
            // filtrar
            // 
            this.filtrar.BackColor = System.Drawing.Color.AliceBlue;
            this.filtrar.Controls.Add(this.label2);
            this.filtrar.Controls.Add(this.label1);
            this.filtrar.Controls.Add(this.deshacer);
            this.filtrar.Controls.Add(this.lupa);
            this.filtrar.Controls.Add(this.filtrarTextBox);
            this.filtrar.Controls.Add(this.filtrarComboBox);
            this.filtrar.Controls.Add(this.empleados_pictureBox);
            this.filtrar.Location = new System.Drawing.Point(1036, 89);
            this.filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.filtrar.Name = "filtrar";
            this.filtrar.Padding = new System.Windows.Forms.Padding(2);
            this.filtrar.Size = new System.Drawing.Size(227, 582);
            this.filtrar.TabIndex = 0;
            this.filtrar.TabStop = false;
            this.filtrar.Text = "Filtrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F);
            this.label2.Location = new System.Drawing.Point(79, 348);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Dato a filtrar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F);
            this.label1.Location = new System.Drawing.Point(79, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Filtrar por:";
            // 
            // deshacer
            // 
            this.deshacer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deshacer.Font = new System.Drawing.Font("Century", 9.75F);
            this.deshacer.Location = new System.Drawing.Point(73, 515);
            this.deshacer.Margin = new System.Windows.Forms.Padding(2);
            this.deshacer.Name = "deshacer";
            this.deshacer.Size = new System.Drawing.Size(107, 30);
            this.deshacer.TabIndex = 19;
            this.deshacer.Text = "Deshacer";
            this.deshacer.UseVisualStyleBackColor = true;
            this.deshacer.Click += new System.EventHandler(this.deshacer_Click);
            // 
            // lupa
            // 
            this.lupa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lupa.BackgroundImage")));
            this.lupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lupa.Location = new System.Drawing.Point(98, 440);
            this.lupa.Margin = new System.Windows.Forms.Padding(2);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(47, 50);
            this.lupa.TabIndex = 3;
            this.lupa.UseVisualStyleBackColor = true;
            this.lupa.Click += new System.EventHandler(this.lupa_Click);
            // 
            // filtrarTextBox
            // 
            this.filtrarTextBox.Location = new System.Drawing.Point(38, 381);
            this.filtrarTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.filtrarTextBox.Name = "filtrarTextBox";
            this.filtrarTextBox.Size = new System.Drawing.Size(161, 20);
            this.filtrarTextBox.TabIndex = 2;
            // 
            // filtrarComboBox
            // 
            this.filtrarComboBox.FormattingEnabled = true;
            this.filtrarComboBox.Items.AddRange(new object[] {
            "Nombre",
            "Género",
            "Provincia"});
            this.filtrarComboBox.Location = new System.Drawing.Point(38, 297);
            this.filtrarComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.filtrarComboBox.Name = "filtrarComboBox";
            this.filtrarComboBox.Size = new System.Drawing.Size(161, 21);
            this.filtrarComboBox.TabIndex = 1;
            // 
            // empleados_pictureBox
            // 
            this.empleados_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empleados_pictureBox.BackgroundImage")));
            this.empleados_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.empleados_pictureBox.Location = new System.Drawing.Point(37, 54);
            this.empleados_pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.empleados_pictureBox.Name = "empleados_pictureBox";
            this.empleados_pictureBox.Size = new System.Drawing.Size(161, 158);
            this.empleados_pictureBox.TabIndex = 0;
            this.empleados_pictureBox.TabStop = false;
            // 
            // odonticDataSet
            // 
            this.odonticDataSet.DataSetName = "OdonticDataSet";
            this.odonticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.odonticDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.Compra_DetalleTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = this.empleadosTableAdapter;
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
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "ODONTIC.chm";
            // 
            // informe_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 754);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "18");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "informe_empleados";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Informe de los empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.informe_empleados_FormClosing);
            this.Load += new System.EventHandler(this.informe_pacientes_Load);
            this.panel1.ResumeLayout(false);
            this.filtrar.ResumeLayout(false);
            this.filtrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empleados_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox filtrar;
        private System.Windows.Forms.PictureBox empleados_pictureBox;
        private System.Windows.Forms.ComboBox filtrarComboBox;
        private System.Windows.Forms.TextBox filtrarTextBox;
        private System.Windows.Forms.Button lupa;
        private OdonticDataSet odonticDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private OdonticDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private OdonticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button deshacer;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}