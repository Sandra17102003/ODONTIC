namespace Clinica_Odontologica
{
    partial class informe_pacientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(informe_pacientes));
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
            this.pacientes_pictureBox = new System.Windows.Forms.PictureBox();
            this.odonticDataSet = new Clinica_Odontologica.OdonticDataSet();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.PacientesTableAdapter();
            this.tableAdapterManager = new Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientes_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1291, 754);
            this.panel1.TabIndex = 8;
            // 
            // reportViewer1
            // 
            this.reportViewer1.DocumentMapWidth = 88;
            this.reportViewer1.Location = new System.Drawing.Point(46, 11);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(970, 732);
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
            this.filtrar.Controls.Add(this.pacientes_pictureBox);
            this.filtrar.Location = new System.Drawing.Point(1047, 104);
            this.filtrar.Margin = new System.Windows.Forms.Padding(2);
            this.filtrar.Name = "filtrar";
            this.filtrar.Padding = new System.Windows.Forms.Padding(2);
            this.filtrar.Size = new System.Drawing.Size(224, 543);
            this.filtrar.TabIndex = 0;
            this.filtrar.TabStop = false;
            this.filtrar.Text = "Filtrar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 9.75F);
            this.label2.Location = new System.Drawing.Point(80, 326);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dato a filtrar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 9.75F);
            this.label1.Location = new System.Drawing.Point(80, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Filtrar por:";
            // 
            // deshacer
            // 
            this.deshacer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deshacer.Font = new System.Drawing.Font("Century", 9.75F);
            this.deshacer.Location = new System.Drawing.Point(64, 468);
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
            this.lupa.Location = new System.Drawing.Point(94, 402);
            this.lupa.Margin = new System.Windows.Forms.Padding(2);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(47, 45);
            this.lupa.TabIndex = 3;
            this.lupa.UseVisualStyleBackColor = true;
            this.lupa.Click += new System.EventHandler(this.lupa_Click);
            // 
            // filtrarTextBox
            // 
            this.filtrarTextBox.Location = new System.Drawing.Point(53, 357);
            this.filtrarTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.filtrarTextBox.Name = "filtrarTextBox";
            this.filtrarTextBox.Size = new System.Drawing.Size(139, 20);
            this.filtrarTextBox.TabIndex = 2;
            // 
            // filtrarComboBox
            // 
            this.filtrarComboBox.FormattingEnabled = true;
            this.filtrarComboBox.Items.AddRange(new object[] {
            "Nombre",
            "Género",
            "Infantil",
            "Adulto",
            "Activo",
            "Inactivo"});
            this.filtrarComboBox.Location = new System.Drawing.Point(53, 273);
            this.filtrarComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.filtrarComboBox.Name = "filtrarComboBox";
            this.filtrarComboBox.Size = new System.Drawing.Size(139, 21);
            this.filtrarComboBox.TabIndex = 1;
            this.filtrarComboBox.SelectedIndexChanged += new System.EventHandler(this.filtrarComboBox_SelectedIndexChanged);
            // 
            // pacientes_pictureBox
            // 
            this.pacientes_pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pacientes_pictureBox.BackgroundImage")));
            this.pacientes_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pacientes_pictureBox.Location = new System.Drawing.Point(46, 74);
            this.pacientes_pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pacientes_pictureBox.Name = "pacientes_pictureBox";
            this.pacientes_pictureBox.Size = new System.Drawing.Size(139, 137);
            this.pacientes_pictureBox.TabIndex = 0;
            this.pacientes_pictureBox.TabStop = false;
            // 
            // odonticDataSet
            // 
            this.odonticDataSet.DataSetName = "OdonticDataSet";
            this.odonticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.odonticDataSet;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.Compra_DetalleTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.MarcaTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = this.pacientesTableAdapter;
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
            // informe_pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 754);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "21");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "informe_pacientes";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Informe de los pacientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.informe_pacientes_FormClosing);
            this.Load += new System.EventHandler(this.informe_pacientes_Load);
            this.panel1.ResumeLayout(false);
            this.filtrar.ResumeLayout(false);
            this.filtrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientes_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox filtrar;
        private System.Windows.Forms.Button deshacer;
        private System.Windows.Forms.Button lupa;
        private System.Windows.Forms.TextBox filtrarTextBox;
        private System.Windows.Forms.ComboBox filtrarComboBox;
        private System.Windows.Forms.PictureBox pacientes_pictureBox;
        private OdonticDataSet odonticDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private OdonticDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private OdonticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}