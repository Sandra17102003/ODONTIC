namespace Clinica_Odontologica
{
    partial class proveedores
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
            System.Windows.Forms.Label paciente;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nIFLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label codigo_PostalLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label paisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(proveedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.notas_groupBox = new System.Windows.Forms.GroupBox();
            this.notasTextBox = new System.Windows.Forms.TextBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odonticDataSet = new Clinica_Odontologica.OdonticDataSet();
            this.cuenta_groupBox = new System.Windows.Forms.GroupBox();
            this.numero_CuentaTextBox = new System.Windows.Forms.TextBox();
            this.datos_contacto_groupBox = new System.Windows.Forms.GroupBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.provinciaTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.codigo_PostalTextBox = new System.Windows.Forms.TextBox();
            this.informacion_personal_groupBox = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nIFTextBox = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.fotos = new System.Windows.Forms.PictureBox();
            this.buscar = new System.Windows.Forms.GroupBox();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.buscarComboBox = new System.Windows.Forms.ComboBox();
            this.lupa = new System.Windows.Forms.Button();
            this.ultimo = new System.Windows.Forms.Button();
            this.siguiente = new System.Windows.Forms.Button();
            this.anterior = new System.Windows.Forms.Button();
            this.primero = new System.Windows.Forms.Button();
            this.informes = new System.Windows.Forms.Button();
            this.imprimir = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.anadir = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableAdapterManager = new Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager();
            this.proveedoresTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.ProveedoresTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            paciente = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nIFLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            codigo_PostalLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.notas_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).BeginInit();
            this.cuenta_groupBox.SuspendLayout();
            this.datos_contacto_groupBox.SuspendLayout();
            this.informacion_personal_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotos)).BeginInit();
            this.buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // paciente
            // 
            paciente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            paciente.AutoSize = true;
            paciente.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            paciente.ForeColor = System.Drawing.Color.Black;
            paciente.Location = new System.Drawing.Point(412, 22);
            paciente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            paciente.Name = "paciente";
            paciente.Size = new System.Drawing.Size(303, 54);
            paciente.TabIndex = 84;
            paciente.Text = "PROVEEDOR:";
            paciente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Century", 9.75F);
            idLabel.Location = new System.Drawing.Point(42, 72);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 16);
            idLabel.TabIndex = 116;
            idLabel.Text = "Id:";
            // 
            // nIFLabel
            // 
            nIFLabel.AutoSize = true;
            nIFLabel.Font = new System.Drawing.Font("Century", 9.75F);
            nIFLabel.Location = new System.Drawing.Point(38, 217);
            nIFLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nIFLabel.Name = "nIFLabel";
            nIFLabel.Size = new System.Drawing.Size(36, 16);
            nIFLabel.TabIndex = 118;
            nIFLabel.Text = "NIF:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Century", 9.75F);
            nombreLabel.Location = new System.Drawing.Point(28, 141);
            nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(59, 16);
            nombreLabel.TabIndex = 120;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            telefonoLabel.Location = new System.Drawing.Point(54, 33);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(60, 16);
            telefonoLabel.TabIndex = 122;
            telefonoLabel.Text = "Teléfono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Century", 9.75F);
            emailLabel.Location = new System.Drawing.Point(54, 67);
            emailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(47, 16);
            emailLabel.TabIndex = 124;
            emailLabel.Text = "Email:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Century", 9.75F);
            direccionLabel.Location = new System.Drawing.Point(54, 111);
            direccionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(67, 16);
            direccionLabel.TabIndex = 126;
            direccionLabel.Text = "Dirección:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.Font = new System.Drawing.Font("Century", 9.75F);
            localidadLabel.Location = new System.Drawing.Point(54, 153);
            localidadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(68, 16);
            localidadLabel.TabIndex = 128;
            localidadLabel.Text = "Localidad:";
            // 
            // codigo_PostalLabel
            // 
            codigo_PostalLabel.AutoSize = true;
            codigo_PostalLabel.Font = new System.Drawing.Font("Century", 9.75F);
            codigo_PostalLabel.Location = new System.Drawing.Point(54, 196);
            codigo_PostalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codigo_PostalLabel.Name = "codigo_PostalLabel";
            codigo_PostalLabel.Size = new System.Drawing.Size(91, 16);
            codigo_PostalLabel.TabIndex = 130;
            codigo_PostalLabel.Text = "Código Postal:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Font = new System.Drawing.Font("Century", 9.75F);
            provinciaLabel.Location = new System.Drawing.Point(54, 233);
            provinciaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(68, 16);
            provinciaLabel.TabIndex = 132;
            provinciaLabel.Text = "Provincia:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Font = new System.Drawing.Font("Century", 9.75F);
            paisLabel.Location = new System.Drawing.Point(67, 280);
            paisLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(37, 16);
            paisLabel.TabIndex = 134;
            paisLabel.Text = "País:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 755);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.notas_groupBox);
            this.panel2.Controls.Add(this.cuenta_groupBox);
            this.panel2.Controls.Add(this.datos_contacto_groupBox);
            this.panel2.Controls.Add(this.informacion_personal_groupBox);
            this.panel2.Controls.Add(this.cancelar);
            this.panel2.Controls.Add(this.aceptar);
            this.panel2.Controls.Add(this.fotos);
            this.panel2.Controls.Add(this.buscar);
            this.panel2.Controls.Add(this.ultimo);
            this.panel2.Controls.Add(this.siguiente);
            this.panel2.Controls.Add(this.anterior);
            this.panel2.Controls.Add(this.primero);
            this.panel2.Controls.Add(this.informes);
            this.panel2.Controls.Add(this.imprimir);
            this.panel2.Controls.Add(this.editar);
            this.panel2.Controls.Add(this.eliminar);
            this.panel2.Controls.Add(this.anadir);
            this.panel2.Controls.Add(paciente);
            this.panel2.Controls.Add(this.volver);
            this.panel2.Location = new System.Drawing.Point(47, 37);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1199, 679);
            this.panel2.TabIndex = 1;
            // 
            // notas_groupBox
            // 
            this.notas_groupBox.Controls.Add(this.notasTextBox);
            this.notas_groupBox.Location = new System.Drawing.Point(106, 460);
            this.notas_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.notas_groupBox.Name = "notas_groupBox";
            this.notas_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.notas_groupBox.Size = new System.Drawing.Size(237, 134);
            this.notas_groupBox.TabIndex = 141;
            this.notas_groupBox.TabStop = false;
            this.notas_groupBox.Text = "Notas:";
            // 
            // notasTextBox
            // 
            this.notasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Notas", true));
            this.notasTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.notasTextBox.Location = new System.Drawing.Point(34, 31);
            this.notasTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.notasTextBox.Multiline = true;
            this.notasTextBox.Name = "notasTextBox";
            this.notasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notasTextBox.Size = new System.Drawing.Size(174, 76);
            this.notasTextBox.TabIndex = 139;
            this.notasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.odonticDataSet;
            // 
            // odonticDataSet
            // 
            this.odonticDataSet.DataSetName = "OdonticDataSet";
            this.odonticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cuenta_groupBox
            // 
            this.cuenta_groupBox.Controls.Add(this.numero_CuentaTextBox);
            this.cuenta_groupBox.Location = new System.Drawing.Point(421, 521);
            this.cuenta_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.cuenta_groupBox.Name = "cuenta_groupBox";
            this.cuenta_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.cuenta_groupBox.Size = new System.Drawing.Size(525, 81);
            this.cuenta_groupBox.TabIndex = 140;
            this.cuenta_groupBox.TabStop = false;
            this.cuenta_groupBox.Text = "Número de cuenta:";
            // 
            // numero_CuentaTextBox
            // 
            this.numero_CuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Numero_Cuenta", true));
            this.numero_CuentaTextBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero_CuentaTextBox.Location = new System.Drawing.Point(40, 37);
            this.numero_CuentaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numero_CuentaTextBox.Name = "numero_CuentaTextBox";
            this.numero_CuentaTextBox.Size = new System.Drawing.Size(436, 24);
            this.numero_CuentaTextBox.TabIndex = 137;
            this.numero_CuentaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numero_CuentaTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.numero_CuentaTextBox_Validating);
            // 
            // datos_contacto_groupBox
            // 
            this.datos_contacto_groupBox.Controls.Add(direccionLabel);
            this.datos_contacto_groupBox.Controls.Add(localidadLabel);
            this.datos_contacto_groupBox.Controls.Add(this.direccionTextBox);
            this.datos_contacto_groupBox.Controls.Add(this.paisTextBox);
            this.datos_contacto_groupBox.Controls.Add(paisLabel);
            this.datos_contacto_groupBox.Controls.Add(this.emailTextBox);
            this.datos_contacto_groupBox.Controls.Add(telefonoLabel);
            this.datos_contacto_groupBox.Controls.Add(this.localidadTextBox);
            this.datos_contacto_groupBox.Controls.Add(this.provinciaTextBox);
            this.datos_contacto_groupBox.Controls.Add(codigo_PostalLabel);
            this.datos_contacto_groupBox.Controls.Add(this.telefonoTextBox);
            this.datos_contacto_groupBox.Controls.Add(emailLabel);
            this.datos_contacto_groupBox.Controls.Add(provinciaLabel);
            this.datos_contacto_groupBox.Controls.Add(this.codigo_PostalTextBox);
            this.datos_contacto_groupBox.Location = new System.Drawing.Point(779, 180);
            this.datos_contacto_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.datos_contacto_groupBox.Name = "datos_contacto_groupBox";
            this.datos_contacto_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.datos_contacto_groupBox.Size = new System.Drawing.Size(385, 314);
            this.datos_contacto_groupBox.TabIndex = 116;
            this.datos_contacto_groupBox.TabStop = false;
            this.datos_contacto_groupBox.Text = "Datos de Contacto:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.direccionTextBox.Location = new System.Drawing.Point(171, 113);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(191, 22);
            this.direccionTextBox.TabIndex = 127;
            this.direccionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Pais", true));
            this.paisTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.paisTextBox.Location = new System.Drawing.Point(171, 280);
            this.paisTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(191, 22);
            this.paisTextBox.TabIndex = 135;
            this.paisTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.emailTextBox.Location = new System.Drawing.Point(171, 68);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(191, 22);
            this.emailTextBox.TabIndex = 125;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Localidad", true));
            this.localidadTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.localidadTextBox.Location = new System.Drawing.Point(171, 154);
            this.localidadTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(191, 22);
            this.localidadTextBox.TabIndex = 129;
            this.localidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Provincia", true));
            this.provinciaTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.provinciaTextBox.Location = new System.Drawing.Point(171, 234);
            this.provinciaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.Size = new System.Drawing.Size(191, 22);
            this.provinciaTextBox.TabIndex = 133;
            this.provinciaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.telefonoTextBox.Location = new System.Drawing.Point(171, 33);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(191, 22);
            this.telefonoTextBox.TabIndex = 123;
            this.telefonoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codigo_PostalTextBox
            // 
            this.codigo_PostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Codigo_Postal", true));
            this.codigo_PostalTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.codigo_PostalTextBox.Location = new System.Drawing.Point(171, 196);
            this.codigo_PostalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.codigo_PostalTextBox.Name = "codigo_PostalTextBox";
            this.codigo_PostalTextBox.Size = new System.Drawing.Size(191, 22);
            this.codigo_PostalTextBox.TabIndex = 131;
            this.codigo_PostalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // informacion_personal_groupBox
            // 
            this.informacion_personal_groupBox.Controls.Add(this.idTextBox);
            this.informacion_personal_groupBox.Controls.Add(idLabel);
            this.informacion_personal_groupBox.Controls.Add(this.nombreTextBox);
            this.informacion_personal_groupBox.Controls.Add(nIFLabel);
            this.informacion_personal_groupBox.Controls.Add(this.nIFTextBox);
            this.informacion_personal_groupBox.Controls.Add(nombreLabel);
            this.informacion_personal_groupBox.Location = new System.Drawing.Point(420, 180);
            this.informacion_personal_groupBox.Margin = new System.Windows.Forms.Padding(2);
            this.informacion_personal_groupBox.Name = "informacion_personal_groupBox";
            this.informacion_personal_groupBox.Padding = new System.Windows.Forms.Padding(2);
            this.informacion_personal_groupBox.Size = new System.Drawing.Size(327, 314);
            this.informacion_personal_groupBox.TabIndex = 115;
            this.informacion_personal_groupBox.TabStop = false;
            this.informacion_personal_groupBox.Text = "Información Personal:";
            // 
            // idTextBox
            // 
            this.idTextBox.AutoSize = true;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(177, 72);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(13, 13);
            this.idTextBox.TabIndex = 122;
            this.idTextBox.Text = "0";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.nombreTextBox.Location = new System.Drawing.Point(118, 140);
            this.nombreTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(173, 22);
            this.nombreTextBox.TabIndex = 121;
            this.nombreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nombreTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombreTextBox_Validating);
            // 
            // nIFTextBox
            // 
            this.nIFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "NIF", true));
            this.nIFTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.nIFTextBox.Location = new System.Drawing.Point(118, 217);
            this.nIFTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nIFTextBox.Name = "nIFTextBox";
            this.nIFTextBox.Size = new System.Drawing.Size(173, 22);
            this.nIFTextBox.TabIndex = 119;
            this.nIFTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nIFTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.nIFTextBox_Validating);
            // 
            // cancelar
            // 
            this.cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelar.BackgroundImage")));
            this.cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelar.Location = new System.Drawing.Point(1094, 591);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(64, 60);
            this.cancelar.TabIndex = 11;
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // aceptar
            // 
            this.aceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptar.BackgroundImage")));
            this.aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aceptar.Location = new System.Drawing.Point(1003, 591);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(62, 60);
            this.aceptar.TabIndex = 10;
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // fotos
            // 
            this.fotos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fotos.BackgroundImage")));
            this.fotos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fotos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fotos.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.proveedoresBindingSource, "Imagen", true));
            this.fotos.Location = new System.Drawing.Point(106, 102);
            this.fotos.Name = "fotos";
            this.fotos.Size = new System.Drawing.Size(237, 263);
            this.fotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotos.TabIndex = 95;
            this.fotos.TabStop = false;
            this.fotos.Click += new System.EventHandler(this.fotos_Click);
            // 
            // buscar
            // 
            this.buscar.Controls.Add(this.buscarTextBox);
            this.buscar.Controls.Add(this.buscarComboBox);
            this.buscar.Controls.Add(this.lupa);
            this.buscar.Location = new System.Drawing.Point(779, 90);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(385, 61);
            this.buscar.TabIndex = 94;
            this.buscar.TabStop = false;
            this.buscar.Text = "Buscar:";
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Location = new System.Drawing.Point(123, 22);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(192, 20);
            this.buscarTextBox.TabIndex = 12;
            this.buscarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buscarComboBox
            // 
            this.buscarComboBox.FormattingEnabled = true;
            this.buscarComboBox.Items.AddRange(new object[] {
            "ID",
            "Nombre"});
            this.buscarComboBox.Location = new System.Drawing.Point(6, 22);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(95, 21);
            this.buscarComboBox.TabIndex = 10;
            // 
            // lupa
            // 
            this.lupa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lupa.BackgroundImage")));
            this.lupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lupa.Location = new System.Drawing.Point(321, 11);
            this.lupa.Name = "lupa";
            this.lupa.Size = new System.Drawing.Size(40, 39);
            this.lupa.TabIndex = 9;
            this.lupa.UseVisualStyleBackColor = true;
            this.lupa.Click += new System.EventHandler(this.lupa_Click);
            // 
            // ultimo
            // 
            this.ultimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ultimo.BackgroundImage")));
            this.ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ultimo.Location = new System.Drawing.Point(637, 90);
            this.ultimo.Name = "ultimo";
            this.ultimo.Size = new System.Drawing.Size(63, 62);
            this.ultimo.TabIndex = 3;
            this.ultimo.UseVisualStyleBackColor = true;
            this.ultimo.Click += new System.EventHandler(this.ultimo_Click);
            // 
            // siguiente
            // 
            this.siguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siguiente.BackgroundImage")));
            this.siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.siguiente.Location = new System.Drawing.Point(567, 90);
            this.siguiente.Name = "siguiente";
            this.siguiente.Size = new System.Drawing.Size(64, 62);
            this.siguiente.TabIndex = 2;
            this.siguiente.UseVisualStyleBackColor = true;
            this.siguiente.Click += new System.EventHandler(this.siguiente_Click);
            // 
            // anterior
            // 
            this.anterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anterior.BackgroundImage")));
            this.anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anterior.Location = new System.Drawing.Point(488, 90);
            this.anterior.Name = "anterior";
            this.anterior.Size = new System.Drawing.Size(73, 62);
            this.anterior.TabIndex = 1;
            this.anterior.UseVisualStyleBackColor = true;
            this.anterior.Click += new System.EventHandler(this.anterior_Click);
            // 
            // primero
            // 
            this.primero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("primero.BackgroundImage")));
            this.primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.primero.Location = new System.Drawing.Point(421, 90);
            this.primero.Name = "primero";
            this.primero.Size = new System.Drawing.Size(65, 62);
            this.primero.TabIndex = 0;
            this.primero.UseVisualStyleBackColor = true;
            this.primero.Click += new System.EventHandler(this.primero_Click);
            // 
            // informes
            // 
            this.informes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("informes.BackgroundImage")));
            this.informes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.informes.Location = new System.Drawing.Point(1100, 22);
            this.informes.Name = "informes";
            this.informes.Size = new System.Drawing.Size(64, 62);
            this.informes.TabIndex = 8;
            this.informes.UseVisualStyleBackColor = true;
            this.informes.Click += new System.EventHandler(this.informes_Click);
            // 
            // imprimir
            // 
            this.imprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("imprimir.BackgroundImage")));
            this.imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imprimir.Location = new System.Drawing.Point(1029, 22);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(65, 62);
            this.imprimir.TabIndex = 7;
            this.imprimir.UseVisualStyleBackColor = true;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // editar
            // 
            this.editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar.BackgroundImage")));
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.Location = new System.Drawing.Point(918, 22);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(58, 62);
            this.editar.TabIndex = 6;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // eliminar
            // 
            this.eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminar.BackgroundImage")));
            this.eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminar.Location = new System.Drawing.Point(849, 22);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(63, 62);
            this.eliminar.TabIndex = 5;
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // anadir
            // 
            this.anadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anadir.BackgroundImage")));
            this.anadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anadir.Location = new System.Drawing.Point(779, 22);
            this.anadir.Name = "anadir";
            this.anadir.Size = new System.Drawing.Size(64, 62);
            this.anadir.TabIndex = 4;
            this.anadir.UseVisualStyleBackColor = true;
            this.anadir.Click += new System.EventHandler(this.anadir_Click);
            // 
            // volver
            // 
            this.volver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volver.BackgroundImage")));
            this.volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volver.Location = new System.Drawing.Point(2, 2);
            this.volver.Margin = new System.Windows.Forms.Padding(2);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(68, 62);
            this.volver.TabIndex = 12;
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            this.tableAdapterManager.ProveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.Tipo_TratamientoTableAdapter = null;
            this.tableAdapterManager.Tratamiento_DetalleTableAdapter = null;
            this.tableAdapterManager.TratamientosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Venta_DetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "ODONTIC.chm";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 755);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "9");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "proveedores";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Proveedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.proveedores_FormClosing);
            this.Load += new System.EventHandler(this.proveedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.notas_groupBox.ResumeLayout(false);
            this.notas_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).EndInit();
            this.cuenta_groupBox.ResumeLayout(false);
            this.cuenta_groupBox.PerformLayout();
            this.datos_contacto_groupBox.ResumeLayout(false);
            this.datos_contacto_groupBox.PerformLayout();
            this.informacion_personal_groupBox.ResumeLayout(false);
            this.informacion_personal_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotos)).EndInit();
            this.buscar.ResumeLayout(false);
            this.buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.PictureBox fotos;
        private System.Windows.Forms.GroupBox buscar;
        private System.Windows.Forms.Button lupa;
        private System.Windows.Forms.Button ultimo;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.Button anterior;
        private System.Windows.Forms.Button primero;
        private System.Windows.Forms.Button informes;
        private System.Windows.Forms.Button imprimir;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button anadir;
        private System.Windows.Forms.Button volver;
        private OdonticDataSet odonticDataSet;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private OdonticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private OdonticDataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.GroupBox datos_contacto_groupBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox codigo_PostalTextBox;
        private System.Windows.Forms.TextBox provinciaTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox numero_CuentaTextBox;
        private System.Windows.Forms.TextBox notasTextBox;
        private System.Windows.Forms.GroupBox informacion_personal_groupBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nIFTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.GroupBox notas_groupBox;
        private System.Windows.Forms.GroupBox cuenta_groupBox;
        private System.Windows.Forms.Label idTextBox;
        private System.Windows.Forms.ComboBox buscarComboBox;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}