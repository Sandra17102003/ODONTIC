namespace Clinica_Odontologica
{
    partial class tratamientos
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
            System.Windows.Forms.Label tratamiento_detalle;
            System.Windows.Forms.Label tratamiento;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label iD_PacienteLabel;
            System.Windows.Forms.Label nombre_PacienteLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label metodo_PagoLabel;
            System.Windows.Forms.Label descuentosLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label fecha_InicioLabel;
            System.Windows.Forms.Label fecha_FINLabel;
            System.Windows.Forms.Label nombre_TratamientoLabel;
            System.Windows.Forms.Label id_TratamientoLabel;
            System.Windows.Forms.Label empleadoLabel;
            System.Windows.Forms.Label zonaLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label horaLabel;
            System.Windows.Forms.Label sesionesLabel;
            System.Windows.Forms.Label precioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tratamientos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.zonaComboBox = new System.Windows.Forms.ComboBox();
            this.tratamiento_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tratamientosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odonticDataSet = new Clinica_Odontologica.OdonticDataSet();
            this.empleadoComboBox = new System.Windows.Forms.ComboBox();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombre_tratamientoComboBox = new System.Windows.Forms.ComboBox();
            this.tipo_TratamientoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.sesionesTextBox = new System.Windows.Forms.TextBox();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.fecha_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.id_TratamientoTextBox = new System.Windows.Forms.TextBox();
            this.tratamiento_DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guardar = new System.Windows.Forms.Button();
            this.cancelar2 = new System.Windows.Forms.Button();
            this.aceptar2 = new System.Windows.Forms.Button();
            this.ultimo2 = new System.Windows.Forms.Button();
            this.siguiente2 = new System.Windows.Forms.Button();
            this.anterior2 = new System.Windows.Forms.Button();
            this.primero2 = new System.Windows.Forms.Button();
            this.editar2 = new System.Windows.Forms.Button();
            this.eliminar2 = new System.Windows.Forms.Button();
            this.anadir2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metodo_pagoComboBox = new System.Windows.Forms.ComboBox();
            this.nombre_pacienteComboBox = new System.Windows.Forms.ComboBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_tratamiento = new System.Windows.Forms.Label();
            this.iD_PacienteTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.descuentosTextBox = new System.Windows.Forms.TextBox();
            this.importeTextBox = new System.Windows.Forms.TextBox();
            this.fecha_InicioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_FINDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cancelar = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.buscar = new System.Windows.Forms.GroupBox();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.buscarComboBox = new System.Windows.Forms.ComboBox();
            this.lupa = new System.Windows.Forms.Button();
            this.ultimo = new System.Windows.Forms.Button();
            this.siguiente = new System.Windows.Forms.Button();
            this.anterior = new System.Windows.Forms.Button();
            this.primero = new System.Windows.Forms.Button();
            this.informes = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.anadir = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.odonticDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager();
            this.empleadosTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.EmpleadosTableAdapter();
            this.pacientesTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.PacientesTableAdapter();
            this.tipo_TratamientoTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.Tipo_TratamientoTableAdapter();
            this.tratamiento_DetalleTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.Tratamiento_DetalleTableAdapter();
            this.tratamientosTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.TratamientosTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            tratamiento_detalle = new System.Windows.Forms.Label();
            tratamiento = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            iD_PacienteLabel = new System.Windows.Forms.Label();
            nombre_PacienteLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            metodo_PagoLabel = new System.Windows.Forms.Label();
            descuentosLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            fecha_InicioLabel = new System.Windows.Forms.Label();
            fecha_FINLabel = new System.Windows.Forms.Label();
            nombre_TratamientoLabel = new System.Windows.Forms.Label();
            id_TratamientoLabel = new System.Windows.Forms.Label();
            empleadoLabel = new System.Windows.Forms.Label();
            zonaLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            sesionesLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamiento_DetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TratamientoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamiento_DetalleDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tratamiento_detalle
            // 
            tratamiento_detalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            tratamiento_detalle.AutoSize = true;
            tratamiento_detalle.Font = new System.Drawing.Font("Algerian", 27F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tratamiento_detalle.ForeColor = System.Drawing.Color.Black;
            tratamiento_detalle.Location = new System.Drawing.Point(96, 27);
            tratamiento_detalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tratamiento_detalle.Name = "tratamiento_detalle";
            tratamiento_detalle.Size = new System.Drawing.Size(464, 40);
            tratamiento_detalle.TabIndex = 84;
            tratamiento_detalle.Text = "Lineas del Tratamiento";
            tratamiento_detalle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tratamiento
            // 
            tratamiento.Anchor = System.Windows.Forms.AnchorStyles.Top;
            tratamiento.AutoSize = true;
            tratamiento.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tratamiento.ForeColor = System.Drawing.Color.Black;
            tratamiento.Location = new System.Drawing.Point(97, 22);
            tratamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tratamiento.Name = "tratamiento";
            tratamiento.Size = new System.Drawing.Size(361, 54);
            tratamiento.TabIndex = 84;
            tratamiento.Text = "TRATAMIENTO:";
            tratamiento.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Century", 9.75F);
            idLabel.Location = new System.Drawing.Point(92, 117);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 16);
            idLabel.TabIndex = 94;
            idLabel.Text = "Id:";
            // 
            // iD_PacienteLabel
            // 
            iD_PacienteLabel.AutoSize = true;
            iD_PacienteLabel.Font = new System.Drawing.Font("Century", 9.75F);
            iD_PacienteLabel.Location = new System.Drawing.Point(92, 190);
            iD_PacienteLabel.Name = "iD_PacienteLabel";
            iD_PacienteLabel.Size = new System.Drawing.Size(102, 16);
            iD_PacienteLabel.TabIndex = 96;
            iD_PacienteLabel.Text = "ID del Paciente:";
            // 
            // nombre_PacienteLabel
            // 
            nombre_PacienteLabel.AutoSize = true;
            nombre_PacienteLabel.Font = new System.Drawing.Font("Century", 9.75F);
            nombre_PacienteLabel.Location = new System.Drawing.Point(92, 154);
            nombre_PacienteLabel.Name = "nombre_PacienteLabel";
            nombre_PacienteLabel.Size = new System.Drawing.Size(135, 16);
            nombre_PacienteLabel.TabIndex = 98;
            nombre_PacienteLabel.Text = "Nombre del Paciente:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Font = new System.Drawing.Font("Century", 9.75F);
            dNILabel.Location = new System.Drawing.Point(92, 220);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(37, 16);
            dNILabel.TabIndex = 100;
            dNILabel.Text = "DNI:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            telefonoLabel.Location = new System.Drawing.Point(92, 254);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(60, 16);
            telefonoLabel.TabIndex = 102;
            telefonoLabel.Text = "Teléfono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Century", 9.75F);
            emailLabel.Location = new System.Drawing.Point(92, 293);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(47, 16);
            emailLabel.TabIndex = 104;
            emailLabel.Text = "Email:";
            // 
            // metodo_PagoLabel
            // 
            metodo_PagoLabel.AutoSize = true;
            metodo_PagoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            metodo_PagoLabel.Location = new System.Drawing.Point(562, 158);
            metodo_PagoLabel.Name = "metodo_PagoLabel";
            metodo_PagoLabel.Size = new System.Drawing.Size(103, 16);
            metodo_PagoLabel.TabIndex = 106;
            metodo_PagoLabel.Text = "Método de Pago:";
            // 
            // descuentosLabel
            // 
            descuentosLabel.AutoSize = true;
            descuentosLabel.Font = new System.Drawing.Font("Century", 9.75F);
            descuentosLabel.Location = new System.Drawing.Point(562, 197);
            descuentosLabel.Name = "descuentosLabel";
            descuentosLabel.Size = new System.Drawing.Size(78, 16);
            descuentosLabel.TabIndex = 108;
            descuentosLabel.Text = "Descuentos:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Font = new System.Drawing.Font("Century", 9.75F);
            importeLabel.Location = new System.Drawing.Point(562, 239);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(58, 16);
            importeLabel.TabIndex = 110;
            importeLabel.Text = "Importe:";
            // 
            // fecha_InicioLabel
            // 
            fecha_InicioLabel.AutoSize = true;
            fecha_InicioLabel.Font = new System.Drawing.Font("Century", 9.75F);
            fecha_InicioLabel.Location = new System.Drawing.Point(562, 273);
            fecha_InicioLabel.Name = "fecha_InicioLabel";
            fecha_InicioLabel.Size = new System.Drawing.Size(101, 16);
            fecha_InicioLabel.TabIndex = 112;
            fecha_InicioLabel.Text = "Fecha de Inicio:";
            // 
            // fecha_FINLabel
            // 
            fecha_FINLabel.AutoSize = true;
            fecha_FINLabel.Font = new System.Drawing.Font("Century", 9.75F);
            fecha_FINLabel.Location = new System.Drawing.Point(562, 308);
            fecha_FINLabel.Name = "fecha_FINLabel";
            fecha_FINLabel.Size = new System.Drawing.Size(93, 16);
            fecha_FINLabel.TabIndex = 114;
            fecha_FINLabel.Text = "Fecha de FIN:";
            // 
            // nombre_TratamientoLabel
            // 
            nombre_TratamientoLabel.AutoSize = true;
            nombre_TratamientoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            nombre_TratamientoLabel.Location = new System.Drawing.Point(26, 126);
            nombre_TratamientoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombre_TratamientoLabel.Name = "nombre_TratamientoLabel";
            nombre_TratamientoLabel.Size = new System.Drawing.Size(159, 16);
            nombre_TratamientoLabel.TabIndex = 90;
            nombre_TratamientoLabel.Text = "Nombre del Tratamiento:";
            // 
            // id_TratamientoLabel
            // 
            id_TratamientoLabel.AutoSize = true;
            id_TratamientoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            id_TratamientoLabel.Location = new System.Drawing.Point(430, 125);
            id_TratamientoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_TratamientoLabel.Name = "id_TratamientoLabel";
            id_TratamientoLabel.Size = new System.Drawing.Size(102, 16);
            id_TratamientoLabel.TabIndex = 91;
            id_TratamientoLabel.Text = "Id Tratamiento:";
            // 
            // empleadoLabel
            // 
            empleadoLabel.AutoSize = true;
            empleadoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            empleadoLabel.Location = new System.Drawing.Point(646, 119);
            empleadoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            empleadoLabel.Name = "empleadoLabel";
            empleadoLabel.Size = new System.Drawing.Size(69, 16);
            empleadoLabel.TabIndex = 92;
            empleadoLabel.Text = "Empleado:";
            // 
            // zonaLabel
            // 
            zonaLabel.AutoSize = true;
            zonaLabel.Font = new System.Drawing.Font("Century", 9.75F);
            zonaLabel.Location = new System.Drawing.Point(874, 121);
            zonaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            zonaLabel.Name = "zonaLabel";
            zonaLabel.Size = new System.Drawing.Size(40, 16);
            zonaLabel.TabIndex = 93;
            zonaLabel.Text = "Zona:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Century", 9.75F);
            totalLabel.Location = new System.Drawing.Point(1120, 126);
            totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(42, 16);
            totalLabel.TabIndex = 94;
            totalLabel.Text = "Total:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Century", 9.75F);
            fechaLabel.Location = new System.Drawing.Point(90, 171);
            fechaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(47, 16);
            fechaLabel.TabIndex = 95;
            fechaLabel.Text = "Fecha:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Font = new System.Drawing.Font("Century", 9.75F);
            horaLabel.Location = new System.Drawing.Point(448, 174);
            horaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(41, 16);
            horaLabel.TabIndex = 96;
            horaLabel.Text = "Hora:";
            // 
            // sesionesLabel
            // 
            sesionesLabel.AutoSize = true;
            sesionesLabel.Font = new System.Drawing.Font("Century", 9.75F);
            sesionesLabel.Location = new System.Drawing.Point(646, 174);
            sesionesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sesionesLabel.Name = "sesionesLabel";
            sesionesLabel.Size = new System.Drawing.Size(61, 16);
            sesionesLabel.TabIndex = 97;
            sesionesLabel.Text = "Sesiones:";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Font = new System.Drawing.Font("Century", 9.75F);
            precioLabel.Location = new System.Drawing.Point(886, 171);
            precioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(48, 16);
            precioLabel.TabIndex = 98;
            precioLabel.Text = "Precio:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 857);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.zonaComboBox);
            this.panel3.Controls.Add(this.empleadoComboBox);
            this.panel3.Controls.Add(this.nombre_tratamientoComboBox);
            this.panel3.Controls.Add(precioLabel);
            this.panel3.Controls.Add(this.precioTextBox);
            this.panel3.Controls.Add(sesionesLabel);
            this.panel3.Controls.Add(this.sesionesTextBox);
            this.panel3.Controls.Add(horaLabel);
            this.panel3.Controls.Add(this.horaTextBox);
            this.panel3.Controls.Add(fechaLabel);
            this.panel3.Controls.Add(this.fecha_DateTimePicker);
            this.panel3.Controls.Add(totalLabel);
            this.panel3.Controls.Add(this.totalTextBox);
            this.panel3.Controls.Add(zonaLabel);
            this.panel3.Controls.Add(empleadoLabel);
            this.panel3.Controls.Add(id_TratamientoLabel);
            this.panel3.Controls.Add(this.id_TratamientoTextBox);
            this.panel3.Controls.Add(nombre_TratamientoLabel);
            this.panel3.Controls.Add(this.tratamiento_DetalleDataGridView);
            this.panel3.Controls.Add(this.guardar);
            this.panel3.Controls.Add(this.cancelar2);
            this.panel3.Controls.Add(this.aceptar2);
            this.panel3.Controls.Add(this.ultimo2);
            this.panel3.Controls.Add(this.siguiente2);
            this.panel3.Controls.Add(this.anterior2);
            this.panel3.Controls.Add(this.primero2);
            this.panel3.Controls.Add(this.editar2);
            this.panel3.Controls.Add(this.eliminar2);
            this.panel3.Controls.Add(this.anadir2);
            this.panel3.Controls.Add(tratamiento_detalle);
            this.panel3.Location = new System.Drawing.Point(53, 403);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1230, 423);
            this.panel3.TabIndex = 2;
            // 
            // zonaComboBox
            // 
            this.zonaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tratamiento_DetalleBindingSource, "Zona", true));
            this.zonaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamiento_DetalleBindingSource, "Zona", true));
            this.zonaComboBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.zonaComboBox.FormattingEnabled = true;
            this.zonaComboBox.Items.AddRange(new object[] {
            "1. Incisivos",
            "2. Caninos",
            "3. Premolares",
            "4. Molares",
            "5. Encías",
            "6. Raíz dental",
            "7. Hueso maxilar/mandíbula",
            "8. ATM (articulación)",
            "9. Mucosas orales",
            "10. Estética dental"});
            this.zonaComboBox.Location = new System.Drawing.Point(932, 115);
            this.zonaComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.zonaComboBox.Name = "zonaComboBox";
            this.zonaComboBox.Size = new System.Drawing.Size(122, 23);
            this.zonaComboBox.TabIndex = 102;
            // 
            // tratamiento_DetalleBindingSource
            // 
            this.tratamiento_DetalleBindingSource.DataMember = "FK_Tratamiento";
            this.tratamiento_DetalleBindingSource.DataSource = this.tratamientosBindingSource;
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
            // empleadoComboBox
            // 
            this.empleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tratamiento_DetalleBindingSource, "Empleado", true));
            this.empleadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamiento_DetalleBindingSource, "Empleado", true));
            this.empleadoComboBox.DataSource = this.empleadosBindingSource;
            this.empleadoComboBox.DisplayMember = "Nombre";
            this.empleadoComboBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.empleadoComboBox.FormattingEnabled = true;
            this.empleadoComboBox.Location = new System.Drawing.Point(722, 119);
            this.empleadoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.empleadoComboBox.Name = "empleadoComboBox";
            this.empleadoComboBox.Size = new System.Drawing.Size(116, 23);
            this.empleadoComboBox.TabIndex = 101;
            this.empleadoComboBox.ValueMember = "Nombre";
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.odonticDataSet;
            // 
            // nombre_tratamientoComboBox
            // 
            this.nombre_tratamientoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tratamiento_DetalleBindingSource, "Nombre_Tratamiento", true));
            this.nombre_tratamientoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamiento_DetalleBindingSource, "Nombre_Tratamiento", true));
            this.nombre_tratamientoComboBox.DataSource = this.tipo_TratamientoBindingSource;
            this.nombre_tratamientoComboBox.DisplayMember = "Nombre";
            this.nombre_tratamientoComboBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.nombre_tratamientoComboBox.FormattingEnabled = true;
            this.nombre_tratamientoComboBox.Location = new System.Drawing.Point(188, 122);
            this.nombre_tratamientoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_tratamientoComboBox.Name = "nombre_tratamientoComboBox";
            this.nombre_tratamientoComboBox.Size = new System.Drawing.Size(193, 23);
            this.nombre_tratamientoComboBox.TabIndex = 100;
            this.nombre_tratamientoComboBox.ValueMember = "Nombre";
            this.nombre_tratamientoComboBox.SelectedIndexChanged += new System.EventHandler(this.nombre_tratamientoComboBox_SelectedIndexChanged);
            // 
            // tipo_TratamientoBindingSource
            // 
            this.tipo_TratamientoBindingSource.DataMember = "Tipo_Tratamiento";
            this.tipo_TratamientoBindingSource.DataSource = this.odonticDataSet;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamiento_DetalleBindingSource, "Precio", true));
            this.precioTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.precioTextBox.Location = new System.Drawing.Point(939, 174);
            this.precioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(95, 22);
            this.precioTextBox.TabIndex = 99;
            this.precioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.precioTextBox.TextChanged += new System.EventHandler(this.precioTextBox_TextChanged);
            // 
            // sesionesTextBox
            // 
            this.sesionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamiento_DetalleBindingSource, "Sesiones", true));
            this.sesionesTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.sesionesTextBox.Location = new System.Drawing.Point(714, 174);
            this.sesionesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.sesionesTextBox.Name = "sesionesTextBox";
            this.sesionesTextBox.Size = new System.Drawing.Size(95, 22);
            this.sesionesTextBox.TabIndex = 98;
            this.sesionesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sesionesTextBox.TextChanged += new System.EventHandler(this.sesionesTextBox_TextChanged);
            // 
            // horaTextBox
            // 
            this.horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamiento_DetalleBindingSource, "Hora", true));
            this.horaTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.horaTextBox.Location = new System.Drawing.Point(510, 171);
            this.horaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.Size = new System.Drawing.Size(95, 22);
            this.horaTextBox.TabIndex = 97;
            this.horaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fecha_DateTimePicker
            // 
            this.fecha_DateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tratamiento_DetalleBindingSource, "Fecha", true));
            this.fecha_DateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.fecha_DateTimePicker.Location = new System.Drawing.Point(188, 168);
            this.fecha_DateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fecha_DateTimePicker.Name = "fecha_DateTimePicker";
            this.fecha_DateTimePicker.Size = new System.Drawing.Size(193, 22);
            this.fecha_DateTimePicker.TabIndex = 96;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamiento_DetalleBindingSource, "Total", true));
            this.totalTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.totalTextBox.Location = new System.Drawing.Point(1093, 156);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(95, 22);
            this.totalTextBox.TabIndex = 95;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // id_TratamientoTextBox
            // 
            this.id_TratamientoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamiento_DetalleBindingSource, "Id_Tratamiento", true));
            this.id_TratamientoTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.id_TratamientoTextBox.Location = new System.Drawing.Point(537, 122);
            this.id_TratamientoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.id_TratamientoTextBox.Name = "id_TratamientoTextBox";
            this.id_TratamientoTextBox.Size = new System.Drawing.Size(56, 22);
            this.id_TratamientoTextBox.TabIndex = 92;
            this.id_TratamientoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tratamiento_DetalleDataGridView
            // 
            this.tratamiento_DetalleDataGridView.AllowUserToAddRows = false;
            this.tratamiento_DetalleDataGridView.AllowUserToDeleteRows = false;
            this.tratamiento_DetalleDataGridView.AutoGenerateColumns = false;
            this.tratamiento_DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tratamiento_DetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.tratamiento_DetalleDataGridView.DataSource = this.tratamiento_DetalleBindingSource;
            this.tratamiento_DetalleDataGridView.Location = new System.Drawing.Point(28, 214);
            this.tratamiento_DetalleDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.tratamiento_DetalleDataGridView.Name = "tratamiento_DetalleDataGridView";
            this.tratamiento_DetalleDataGridView.RowHeadersWidth = 51;
            this.tratamiento_DetalleDataGridView.RowTemplate.Height = 24;
            this.tratamiento_DetalleDataGridView.Size = new System.Drawing.Size(1025, 179);
            this.tratamiento_DetalleDataGridView.TabIndex = 90;
            this.tratamiento_DetalleDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.tratamiento_DetalleDataGridView_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Tratamiento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Tratamiento";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre_Tratamiento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre_Tratamiento";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sesiones";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sesiones";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn6.HeaderText = "Total";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn7.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Empleado";
            this.dataGridViewTextBoxColumn8.HeaderText = "Empleado";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Zona";
            this.dataGridViewTextBoxColumn9.HeaderText = "Zona";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn10.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardar.BackgroundImage")));
            this.guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardar.Location = new System.Drawing.Point(1094, 293);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(92, 89);
            this.guardar.TabIndex = 90;
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // cancelar2
            // 
            this.cancelar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelar2.BackgroundImage")));
            this.cancelar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelar2.Location = new System.Drawing.Point(1142, 204);
            this.cancelar2.Name = "cancelar2";
            this.cancelar2.Size = new System.Drawing.Size(67, 63);
            this.cancelar2.TabIndex = 11;
            this.cancelar2.UseVisualStyleBackColor = true;
            this.cancelar2.Click += new System.EventHandler(this.cancelar2_Click);
            // 
            // aceptar2
            // 
            this.aceptar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptar2.BackgroundImage")));
            this.aceptar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aceptar2.Location = new System.Drawing.Point(1069, 204);
            this.aceptar2.Name = "aceptar2";
            this.aceptar2.Size = new System.Drawing.Size(67, 63);
            this.aceptar2.TabIndex = 10;
            this.aceptar2.UseVisualStyleBackColor = true;
            this.aceptar2.Click += new System.EventHandler(this.aceptar2_Click);
            // 
            // ultimo2
            // 
            this.ultimo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ultimo2.BackgroundImage")));
            this.ultimo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ultimo2.Location = new System.Drawing.Point(821, 17);
            this.ultimo2.Name = "ultimo2";
            this.ultimo2.Size = new System.Drawing.Size(63, 62);
            this.ultimo2.TabIndex = 3;
            this.ultimo2.UseVisualStyleBackColor = true;
            this.ultimo2.Click += new System.EventHandler(this.ultimo2_Click);
            // 
            // siguiente2
            // 
            this.siguiente2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("siguiente2.BackgroundImage")));
            this.siguiente2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.siguiente2.Location = new System.Drawing.Point(751, 17);
            this.siguiente2.Name = "siguiente2";
            this.siguiente2.Size = new System.Drawing.Size(64, 62);
            this.siguiente2.TabIndex = 2;
            this.siguiente2.UseVisualStyleBackColor = true;
            this.siguiente2.Click += new System.EventHandler(this.siguiente2_Click);
            // 
            // anterior2
            // 
            this.anterior2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anterior2.BackgroundImage")));
            this.anterior2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anterior2.Location = new System.Drawing.Point(672, 17);
            this.anterior2.Name = "anterior2";
            this.anterior2.Size = new System.Drawing.Size(73, 62);
            this.anterior2.TabIndex = 1;
            this.anterior2.UseVisualStyleBackColor = true;
            this.anterior2.Click += new System.EventHandler(this.anterior2_Click);
            // 
            // primero2
            // 
            this.primero2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("primero2.BackgroundImage")));
            this.primero2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.primero2.Location = new System.Drawing.Point(605, 17);
            this.primero2.Name = "primero2";
            this.primero2.Size = new System.Drawing.Size(65, 62);
            this.primero2.TabIndex = 0;
            this.primero2.UseVisualStyleBackColor = true;
            this.primero2.Click += new System.EventHandler(this.primero2_Click);
            // 
            // editar2
            // 
            this.editar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar2.BackgroundImage")));
            this.editar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar2.Location = new System.Drawing.Point(1131, 17);
            this.editar2.Name = "editar2";
            this.editar2.Size = new System.Drawing.Size(58, 62);
            this.editar2.TabIndex = 6;
            this.editar2.UseVisualStyleBackColor = true;
            this.editar2.Click += new System.EventHandler(this.editar2_Click);
            // 
            // eliminar2
            // 
            this.eliminar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eliminar2.BackgroundImage")));
            this.eliminar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminar2.Location = new System.Drawing.Point(1020, 17);
            this.eliminar2.Name = "eliminar2";
            this.eliminar2.Size = new System.Drawing.Size(63, 62);
            this.eliminar2.TabIndex = 5;
            this.eliminar2.UseVisualStyleBackColor = true;
            this.eliminar2.Click += new System.EventHandler(this.eliminar2_Click);
            // 
            // anadir2
            // 
            this.anadir2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anadir2.BackgroundImage")));
            this.anadir2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.anadir2.Location = new System.Drawing.Point(950, 17);
            this.anadir2.Name = "anadir2";
            this.anadir2.Size = new System.Drawing.Size(64, 62);
            this.anadir2.TabIndex = 4;
            this.anadir2.UseVisualStyleBackColor = true;
            this.anadir2.Click += new System.EventHandler(this.anadir2_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.metodo_pagoComboBox);
            this.panel2.Controls.Add(this.nombre_pacienteComboBox);
            this.panel2.Controls.Add(this.id_tratamiento);
            this.panel2.Controls.Add(idLabel);
            this.panel2.Controls.Add(iD_PacienteLabel);
            this.panel2.Controls.Add(this.iD_PacienteTextBox);
            this.panel2.Controls.Add(nombre_PacienteLabel);
            this.panel2.Controls.Add(dNILabel);
            this.panel2.Controls.Add(this.dNITextBox);
            this.panel2.Controls.Add(telefonoLabel);
            this.panel2.Controls.Add(this.telefonoTextBox);
            this.panel2.Controls.Add(emailLabel);
            this.panel2.Controls.Add(this.emailTextBox);
            this.panel2.Controls.Add(metodo_PagoLabel);
            this.panel2.Controls.Add(descuentosLabel);
            this.panel2.Controls.Add(this.descuentosTextBox);
            this.panel2.Controls.Add(importeLabel);
            this.panel2.Controls.Add(this.importeTextBox);
            this.panel2.Controls.Add(fecha_InicioLabel);
            this.panel2.Controls.Add(this.fecha_InicioDateTimePicker);
            this.panel2.Controls.Add(fecha_FINLabel);
            this.panel2.Controls.Add(this.fecha_FINDateTimePicker);
            this.panel2.Controls.Add(this.cancelar);
            this.panel2.Controls.Add(this.aceptar);
            this.panel2.Controls.Add(this.buscar);
            this.panel2.Controls.Add(this.ultimo);
            this.panel2.Controls.Add(this.siguiente);
            this.panel2.Controls.Add(this.anterior);
            this.panel2.Controls.Add(this.primero);
            this.panel2.Controls.Add(this.informes);
            this.panel2.Controls.Add(this.editar);
            this.panel2.Controls.Add(this.eliminar);
            this.panel2.Controls.Add(this.anadir);
            this.panel2.Controls.Add(tratamiento);
            this.panel2.Controls.Add(this.volver);
            this.panel2.Location = new System.Drawing.Point(51, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1230, 362);
            this.panel2.TabIndex = 1;
            // 
            // metodo_pagoComboBox
            // 
            this.metodo_pagoComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metodo_pagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "Metodo_Pago", true));
            this.metodo_pagoComboBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.metodo_pagoComboBox.FormattingEnabled = true;
            this.metodo_pagoComboBox.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo",
            "PayPal",
            "Transferencia bancaria"});
            this.metodo_pagoComboBox.Location = new System.Drawing.Point(702, 159);
            this.metodo_pagoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.metodo_pagoComboBox.Name = "metodo_pagoComboBox";
            this.metodo_pagoComboBox.Size = new System.Drawing.Size(235, 23);
            this.metodo_pagoComboBox.TabIndex = 118;
            this.metodo_pagoComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.metodo_pagoComboBox_Validating);
            // 
            // nombre_pacienteComboBox
            // 
            this.nombre_pacienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tratamientosBindingSource, "Nombre_Paciente", true));
            this.nombre_pacienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "Nombre_Paciente", true));
            this.nombre_pacienteComboBox.DataSource = this.pacientesBindingSource;
            this.nombre_pacienteComboBox.DisplayMember = "Nombre";
            this.nombre_pacienteComboBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.nombre_pacienteComboBox.FormattingEnabled = true;
            this.nombre_pacienteComboBox.Location = new System.Drawing.Point(258, 154);
            this.nombre_pacienteComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_pacienteComboBox.Name = "nombre_pacienteComboBox";
            this.nombre_pacienteComboBox.Size = new System.Drawing.Size(227, 23);
            this.nombre_pacienteComboBox.TabIndex = 117;
            this.nombre_pacienteComboBox.ValueMember = "Nombre";
            this.nombre_pacienteComboBox.SelectedIndexChanged += new System.EventHandler(this.nombre_pacienteComboBox_SelectedIndexChanged);
            this.nombre_pacienteComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombre_pacienteComboBox_Validating);
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.odonticDataSet;
            // 
            // id_tratamiento
            // 
            this.id_tratamiento.AutoSize = true;
            this.id_tratamiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "Id", true));
            this.id_tratamiento.Location = new System.Drawing.Point(345, 114);
            this.id_tratamiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.id_tratamiento.Name = "id_tratamiento";
            this.id_tratamiento.Size = new System.Drawing.Size(13, 13);
            this.id_tratamiento.TabIndex = 116;
            this.id_tratamiento.Text = "0";
            // 
            // iD_PacienteTextBox
            // 
            this.iD_PacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "ID_Paciente", true));
            this.iD_PacienteTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.iD_PacienteTextBox.Location = new System.Drawing.Point(258, 193);
            this.iD_PacienteTextBox.Name = "iD_PacienteTextBox";
            this.iD_PacienteTextBox.Size = new System.Drawing.Size(227, 22);
            this.iD_PacienteTextBox.TabIndex = 97;
            this.iD_PacienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iD_PacienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.iD_PacienteTextBox_Validating);
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "DNI", true));
            this.dNITextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.dNITextBox.Location = new System.Drawing.Point(258, 223);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(227, 22);
            this.dNITextBox.TabIndex = 101;
            this.dNITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dNITextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dNITextBox_Validating);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.telefonoTextBox.Location = new System.Drawing.Point(258, 256);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(227, 22);
            this.telefonoTextBox.TabIndex = 103;
            this.telefonoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.emailTextBox.Location = new System.Drawing.Point(258, 296);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(227, 22);
            this.emailTextBox.TabIndex = 105;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descuentosTextBox
            // 
            this.descuentosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "Descuentos", true));
            this.descuentosTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.descuentosTextBox.Location = new System.Drawing.Point(701, 197);
            this.descuentosTextBox.Name = "descuentosTextBox";
            this.descuentosTextBox.Size = new System.Drawing.Size(235, 22);
            this.descuentosTextBox.TabIndex = 109;
            this.descuentosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // importeTextBox
            // 
            this.importeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tratamientosBindingSource, "Importe", true));
            this.importeTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.importeTextBox.Location = new System.Drawing.Point(701, 239);
            this.importeTextBox.Name = "importeTextBox";
            this.importeTextBox.Size = new System.Drawing.Size(235, 22);
            this.importeTextBox.TabIndex = 111;
            this.importeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fecha_InicioDateTimePicker
            // 
            this.fecha_InicioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tratamientosBindingSource, "Fecha_Inicio", true));
            this.fecha_InicioDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.fecha_InicioDateTimePicker.Location = new System.Drawing.Point(701, 272);
            this.fecha_InicioDateTimePicker.Name = "fecha_InicioDateTimePicker";
            this.fecha_InicioDateTimePicker.Size = new System.Drawing.Size(235, 22);
            this.fecha_InicioDateTimePicker.TabIndex = 113;
            // 
            // fecha_FINDateTimePicker
            // 
            this.fecha_FINDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tratamientosBindingSource, "Fecha_FIN", true));
            this.fecha_FINDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.fecha_FINDateTimePicker.Location = new System.Drawing.Point(701, 307);
            this.fecha_FINDateTimePicker.Name = "fecha_FINDateTimePicker";
            this.fecha_FINDateTimePicker.Size = new System.Drawing.Size(235, 22);
            this.fecha_FINDateTimePicker.TabIndex = 115;
            // 
            // cancelar
            // 
            this.cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelar.BackgroundImage")));
            this.cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelar.Location = new System.Drawing.Point(1107, 267);
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
            this.aceptar.Location = new System.Drawing.Point(1016, 267);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(62, 60);
            this.aceptar.TabIndex = 10;
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // buscar
            // 
            this.buscar.Controls.Add(this.buscarTextBox);
            this.buscar.Controls.Add(this.buscarComboBox);
            this.buscar.Controls.Add(this.lupa);
            this.buscar.Location = new System.Drawing.Point(804, 90);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(385, 61);
            this.buscar.TabIndex = 94;
            this.buscar.TabStop = false;
            this.buscar.Text = "Buscar:";
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Location = new System.Drawing.Point(148, 24);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(168, 20);
            this.buscarTextBox.TabIndex = 16;
            this.buscarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buscarComboBox
            // 
            this.buscarComboBox.FormattingEnabled = true;
            this.buscarComboBox.Items.AddRange(new object[] {
            "Número de Tratamiento"});
            this.buscarComboBox.Location = new System.Drawing.Point(14, 24);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(120, 21);
            this.buscarComboBox.TabIndex = 15;
            // 
            // lupa
            // 
            this.lupa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lupa.BackgroundImage")));
            this.lupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lupa.Location = new System.Drawing.Point(327, 11);
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
            this.ultimo.Location = new System.Drawing.Point(714, 29);
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
            this.siguiente.Location = new System.Drawing.Point(644, 29);
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
            this.anterior.Location = new System.Drawing.Point(565, 29);
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
            this.primero.Location = new System.Drawing.Point(498, 29);
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
            this.informes.Location = new System.Drawing.Point(1125, 22);
            this.informes.Name = "informes";
            this.informes.Size = new System.Drawing.Size(64, 62);
            this.informes.TabIndex = 8;
            this.informes.UseVisualStyleBackColor = true;
            this.informes.Click += new System.EventHandler(this.informes_Click);
            // 
            // editar
            // 
            this.editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar.BackgroundImage")));
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.editar.Location = new System.Drawing.Point(943, 22);
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
            this.eliminar.Location = new System.Drawing.Point(874, 22);
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
            this.anadir.Location = new System.Drawing.Point(804, 22);
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
            // odonticDataSetBindingSource
            // 
            this.odonticDataSetBindingSource.DataSource = this.odonticDataSet;
            this.odonticDataSetBindingSource.Position = 0;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.Compra_DetalleTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = this.empleadosTableAdapter;
            this.tableAdapterManager.MarcaTableAdapter = null;
            this.tableAdapterManager.PacientesTableAdapter = this.pacientesTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Tipo_TratamientoTableAdapter = this.tipo_TratamientoTableAdapter;
            this.tableAdapterManager.Tratamiento_DetalleTableAdapter = this.tratamiento_DetalleTableAdapter;
            this.tableAdapterManager.TratamientosTableAdapter = this.tratamientosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Venta_DetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // tipo_TratamientoTableAdapter
            // 
            this.tipo_TratamientoTableAdapter.ClearBeforeFill = true;
            // 
            // tratamiento_DetalleTableAdapter
            // 
            this.tratamiento_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // tratamientosTableAdapter
            // 
            this.tratamientosTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "ODONTIC.chm";
            // 
            // tratamientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 857);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "15");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tratamientos";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Tratamientos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.tratamientos_FormClosing);
            this.Load += new System.EventHandler(this.tratamientos_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tratamiento_DetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamientosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipo_TratamientoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tratamiento_DetalleDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.buscar.ResumeLayout(false);
            this.buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button cancelar2;
        private System.Windows.Forms.Button aceptar2;
        private System.Windows.Forms.Button ultimo2;
        private System.Windows.Forms.Button siguiente2;
        private System.Windows.Forms.Button anterior2;
        private System.Windows.Forms.Button primero2;
        private System.Windows.Forms.Button editar2;
        private System.Windows.Forms.Button eliminar2;
        private System.Windows.Forms.Button anadir2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.GroupBox buscar;
        private System.Windows.Forms.Button lupa;
        private System.Windows.Forms.Button ultimo;
        private System.Windows.Forms.Button siguiente;
        private System.Windows.Forms.Button anterior;
        private System.Windows.Forms.Button primero;
        private System.Windows.Forms.Button informes;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button anadir;
        private System.Windows.Forms.Button volver;
        private OdonticDataSet odonticDataSet;
        private OdonticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private OdonticDataSetTableAdapters.TratamientosTableAdapter tratamientosTableAdapter;
        private System.Windows.Forms.BindingSource tratamientosBindingSource;
        private System.Windows.Forms.TextBox iD_PacienteTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox descuentosTextBox;
        private System.Windows.Forms.TextBox importeTextBox;
        private System.Windows.Forms.DateTimePicker fecha_InicioDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_FINDateTimePicker;
        private System.Windows.Forms.ComboBox metodo_pagoComboBox;
        private System.Windows.Forms.ComboBox nombre_pacienteComboBox;
        private System.Windows.Forms.Label id_tratamiento;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.ComboBox buscarComboBox;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private OdonticDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private OdonticDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource odonticDataSetBindingSource;
        private System.Windows.Forms.BindingSource tipo_TratamientoBindingSource;
        private OdonticDataSetTableAdapters.Tipo_TratamientoTableAdapter tipo_TratamientoTableAdapter;
        private System.Windows.Forms.BindingSource tratamiento_DetalleBindingSource;
        private OdonticDataSetTableAdapters.Tratamiento_DetalleTableAdapter tratamiento_DetalleTableAdapter;
        private System.Windows.Forms.DataGridView tratamiento_DetalleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox id_TratamientoTextBox;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.TextBox sesionesTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.DateTimePicker fecha_DateTimePicker;
        private System.Windows.Forms.ComboBox empleadoComboBox;
        private System.Windows.Forms.ComboBox nombre_tratamientoComboBox;
        private System.Windows.Forms.ComboBox zonaComboBox;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}