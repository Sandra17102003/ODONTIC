namespace Clinica_Odontologica
{
    partial class ventas
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
            System.Windows.Forms.Label venta_detalle;
            System.Windows.Forms.Label venta;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label iD_PacienteLabel;
            System.Windows.Forms.Label nombre_PacienteLabel;
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label metodo_PagoLabel;
            System.Windows.Forms.Label descuentosLabel;
            System.Windows.Forms.Label importeLabel;
            System.Windows.Forms.Label fecha_PedidoLabel;
            System.Windows.Forms.Label fecha_EntregaLabel;
            System.Windows.Forms.Label nombre_ProductoLabel;
            System.Windows.Forms.Label iD_ProductoLabel;
            System.Windows.Forms.Label precio_UnidadLabel;
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.venta_DetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venta_DetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.odonticDataSet = new Clinica_Odontologica.OdonticDataSet();
            this.nombre_ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.precio_UnidadTextBox = new System.Windows.Forms.TextBox();
            this.iD_ProductoTextBox = new System.Windows.Forms.TextBox();
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
            this.nombre_PacienteComboBox = new System.Windows.Forms.ComboBox();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.Label();
            this.iD_PacienteTextBox = new System.Windows.Forms.TextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.descuentosTextBox = new System.Windows.Forms.TextBox();
            this.importeTextBox = new System.Windows.Forms.TextBox();
            this.fecha_PedidoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fecha_EntregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
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
            this.ventasTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.VentasTableAdapter();
            this.tableAdapterManager = new Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager();
            this.pacientesTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.PacientesTableAdapter();
            this.productosTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.ProductosTableAdapter();
            this.venta_DetalleTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.Venta_DetalleTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.odonticDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            venta_detalle = new System.Windows.Forms.Label();
            venta = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            iD_PacienteLabel = new System.Windows.Forms.Label();
            nombre_PacienteLabel = new System.Windows.Forms.Label();
            dNILabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            metodo_PagoLabel = new System.Windows.Forms.Label();
            descuentosLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            fecha_PedidoLabel = new System.Windows.Forms.Label();
            fecha_EntregaLabel = new System.Windows.Forms.Label();
            nombre_ProductoLabel = new System.Windows.Forms.Label();
            iD_ProductoLabel = new System.Windows.Forms.Label();
            precio_UnidadLabel = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venta_DetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venta_DetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // venta_detalle
            // 
            venta_detalle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            venta_detalle.AutoSize = true;
            venta_detalle.Font = new System.Drawing.Font("Algerian", 27.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            venta_detalle.ForeColor = System.Drawing.Color.Black;
            venta_detalle.Location = new System.Drawing.Point(94, 36);
            venta_detalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            venta_detalle.Name = "venta_detalle";
            venta_detalle.Size = new System.Drawing.Size(380, 41);
            venta_detalle.TabIndex = 84;
            venta_detalle.Text = "Lineas de la Venta";
            venta_detalle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // venta
            // 
            venta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            venta.AutoSize = true;
            venta.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            venta.ForeColor = System.Drawing.Color.Black;
            venta.Location = new System.Drawing.Point(95, 10);
            venta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            venta.Name = "venta";
            venta.Size = new System.Drawing.Size(189, 54);
            venta.TabIndex = 84;
            venta.Text = "VENTA:";
            venta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Century", 9.75F);
            idLabel.Location = new System.Drawing.Point(114, 136);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 16);
            idLabel.TabIndex = 94;
            idLabel.Text = "Id:";
            // 
            // iD_PacienteLabel
            // 
            iD_PacienteLabel.AutoSize = true;
            iD_PacienteLabel.Font = new System.Drawing.Font("Century", 9.75F);
            iD_PacienteLabel.Location = new System.Drawing.Point(110, 240);
            iD_PacienteLabel.Name = "iD_PacienteLabel";
            iD_PacienteLabel.Size = new System.Drawing.Size(102, 16);
            iD_PacienteLabel.TabIndex = 96;
            iD_PacienteLabel.Text = "ID del Paciente:";
            // 
            // nombre_PacienteLabel
            // 
            nombre_PacienteLabel.AutoSize = true;
            nombre_PacienteLabel.Font = new System.Drawing.Font("Century", 9.75F);
            nombre_PacienteLabel.Location = new System.Drawing.Point(110, 173);
            nombre_PacienteLabel.Name = "nombre_PacienteLabel";
            nombre_PacienteLabel.Size = new System.Drawing.Size(139, 16);
            nombre_PacienteLabel.TabIndex = 98;
            nombre_PacienteLabel.Text = "Nombre del  Paciente:";
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.Font = new System.Drawing.Font("Century", 9.75F);
            dNILabel.Location = new System.Drawing.Point(110, 204);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(37, 16);
            dNILabel.TabIndex = 100;
            dNILabel.Text = "DNI:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            telefonoLabel.Location = new System.Drawing.Point(110, 271);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(60, 16);
            telefonoLabel.TabIndex = 102;
            telefonoLabel.Text = "Teléfono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Century", 9.75F);
            emailLabel.Location = new System.Drawing.Point(110, 307);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(47, 16);
            emailLabel.TabIndex = 104;
            emailLabel.Text = "Email:";
            // 
            // metodo_PagoLabel
            // 
            metodo_PagoLabel.AutoSize = true;
            metodo_PagoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            metodo_PagoLabel.Location = new System.Drawing.Point(582, 176);
            metodo_PagoLabel.Name = "metodo_PagoLabel";
            metodo_PagoLabel.Size = new System.Drawing.Size(103, 16);
            metodo_PagoLabel.TabIndex = 106;
            metodo_PagoLabel.Text = "Método de Pago:";
            // 
            // descuentosLabel
            // 
            descuentosLabel.AutoSize = true;
            descuentosLabel.Font = new System.Drawing.Font("Century", 9.75F);
            descuentosLabel.Location = new System.Drawing.Point(592, 212);
            descuentosLabel.Name = "descuentosLabel";
            descuentosLabel.Size = new System.Drawing.Size(78, 16);
            descuentosLabel.TabIndex = 108;
            descuentosLabel.Text = "Descuentos:";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Font = new System.Drawing.Font("Century", 9.75F);
            importeLabel.Location = new System.Drawing.Point(604, 248);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(58, 16);
            importeLabel.TabIndex = 110;
            importeLabel.Text = "Importe:";
            // 
            // fecha_PedidoLabel
            // 
            fecha_PedidoLabel.AutoSize = true;
            fecha_PedidoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            fecha_PedidoLabel.Location = new System.Drawing.Point(582, 281);
            fecha_PedidoLabel.Name = "fecha_PedidoLabel";
            fecha_PedidoLabel.Size = new System.Drawing.Size(107, 16);
            fecha_PedidoLabel.TabIndex = 112;
            fecha_PedidoLabel.Text = "Fecha de Pedido:";
            // 
            // fecha_EntregaLabel
            // 
            fecha_EntregaLabel.AutoSize = true;
            fecha_EntregaLabel.Font = new System.Drawing.Font("Century", 9.75F);
            fecha_EntregaLabel.Location = new System.Drawing.Point(582, 318);
            fecha_EntregaLabel.Name = "fecha_EntregaLabel";
            fecha_EntregaLabel.Size = new System.Drawing.Size(116, 16);
            fecha_EntregaLabel.TabIndex = 114;
            fecha_EntregaLabel.Text = "Fecha de Entrega:";
            // 
            // nombre_ProductoLabel
            // 
            nombre_ProductoLabel.AutoSize = true;
            nombre_ProductoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            nombre_ProductoLabel.Location = new System.Drawing.Point(64, 119);
            nombre_ProductoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombre_ProductoLabel.Name = "nombre_ProductoLabel";
            nombre_ProductoLabel.Size = new System.Drawing.Size(137, 16);
            nombre_ProductoLabel.TabIndex = 97;
            nombre_ProductoLabel.Text = "Nombre del Producto:";
            // 
            // iD_ProductoLabel
            // 
            iD_ProductoLabel.AutoSize = true;
            iD_ProductoLabel.Font = new System.Drawing.Font("Century", 9.75F);
            iD_ProductoLabel.Location = new System.Drawing.Point(362, 122);
            iD_ProductoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            iD_ProductoLabel.Name = "iD_ProductoLabel";
            iD_ProductoLabel.Size = new System.Drawing.Size(104, 16);
            iD_ProductoLabel.TabIndex = 98;
            iD_ProductoLabel.Text = "ID del Producto:";
            // 
            // precio_UnidadLabel
            // 
            precio_UnidadLabel.AutoSize = true;
            precio_UnidadLabel.Font = new System.Drawing.Font("Century", 9.75F);
            precio_UnidadLabel.Location = new System.Drawing.Point(600, 122);
            precio_UnidadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            precio_UnidadLabel.Name = "precio_UnidadLabel";
            precio_UnidadLabel.Size = new System.Drawing.Size(96, 16);
            precio_UnidadLabel.TabIndex = 99;
            precio_UnidadLabel.Text = "Precio/Unidad:";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Century", 9.75F);
            cantidadLabel.Location = new System.Drawing.Point(829, 122);
            cantidadLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(65, 16);
            cantidadLabel.TabIndex = 100;
            cantidadLabel.Text = "Cantidad:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new System.Drawing.Font("Century", 9.75F);
            totalLabel.Location = new System.Drawing.Point(1030, 122);
            totalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(42, 16);
            totalLabel.TabIndex = 101;
            totalLabel.Text = "Total:";
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
            this.panel1.Size = new System.Drawing.Size(1315, 754);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.venta_DetalleDataGridView);
            this.panel3.Controls.Add(this.nombre_ProductoComboBox);
            this.panel3.Controls.Add(totalLabel);
            this.panel3.Controls.Add(this.totalTextBox);
            this.panel3.Controls.Add(cantidadLabel);
            this.panel3.Controls.Add(this.cantidadTextBox);
            this.panel3.Controls.Add(precio_UnidadLabel);
            this.panel3.Controls.Add(this.precio_UnidadTextBox);
            this.panel3.Controls.Add(iD_ProductoLabel);
            this.panel3.Controls.Add(this.iD_ProductoTextBox);
            this.panel3.Controls.Add(nombre_ProductoLabel);
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
            this.panel3.Controls.Add(venta_detalle);
            this.panel3.Location = new System.Drawing.Point(53, 383);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1227, 352);
            this.panel3.TabIndex = 2;
            // 
            // venta_DetalleDataGridView
            // 
            this.venta_DetalleDataGridView.AllowUserToAddRows = false;
            this.venta_DetalleDataGridView.AllowUserToDeleteRows = false;
            this.venta_DetalleDataGridView.AutoGenerateColumns = false;
            this.venta_DetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.venta_DetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.venta_DetalleDataGridView.DataSource = this.venta_DetalleBindingSource;
            this.venta_DetalleDataGridView.Location = new System.Drawing.Point(77, 164);
            this.venta_DetalleDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.venta_DetalleDataGridView.Name = "venta_DetalleDataGridView";
            this.venta_DetalleDataGridView.RowHeadersWidth = 51;
            this.venta_DetalleDataGridView.RowTemplate.Height = 24;
            this.venta_DetalleDataGridView.Size = new System.Drawing.Size(753, 179);
            this.venta_DetalleDataGridView.TabIndex = 103;
            this.venta_DetalleDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.venta_DetalleDataGridView_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_Venta";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_Venta";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_Producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_Producto";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre_Producto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre_Producto";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio_Unidad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio_Unidad";
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
            // venta_DetalleBindingSource
            // 
            this.venta_DetalleBindingSource.DataMember = "FK_Venta";
            this.venta_DetalleBindingSource.DataSource = this.ventasBindingSource;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.odonticDataSet;
            // 
            // odonticDataSet
            // 
            this.odonticDataSet.DataSetName = "OdonticDataSet";
            this.odonticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombre_ProductoComboBox
            // 
            this.nombre_ProductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.venta_DetalleBindingSource, "Nombre_Producto", true));
            this.nombre_ProductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.venta_DetalleBindingSource, "Nombre_Producto", true));
            this.nombre_ProductoComboBox.DataSource = this.productosBindingSource;
            this.nombre_ProductoComboBox.DisplayMember = "Nombre";
            this.nombre_ProductoComboBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.nombre_ProductoComboBox.FormattingEnabled = true;
            this.nombre_ProductoComboBox.Location = new System.Drawing.Point(209, 119);
            this.nombre_ProductoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_ProductoComboBox.Name = "nombre_ProductoComboBox";
            this.nombre_ProductoComboBox.Size = new System.Drawing.Size(129, 23);
            this.nombre_ProductoComboBox.TabIndex = 100;
            this.nombre_ProductoComboBox.ValueMember = "Nombre";
            this.nombre_ProductoComboBox.SelectedIndexChanged += new System.EventHandler(this.nombre_ProductoComboBox_SelectedIndexChanged);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.odonticDataSet;
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.venta_DetalleBindingSource, "Total", true));
            this.totalTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.totalTextBox.Location = new System.Drawing.Point(1093, 119);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(95, 22);
            this.totalTextBox.TabIndex = 104;
            this.totalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.venta_DetalleBindingSource, "Cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.cantidadTextBox.Location = new System.Drawing.Point(898, 115);
            this.cantidadTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(95, 22);
            this.cantidadTextBox.TabIndex = 103;
            this.cantidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cantidadTextBox.TextChanged += new System.EventHandler(this.cantidadTextBox_TextChanged);
            // 
            // precio_UnidadTextBox
            // 
            this.precio_UnidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.venta_DetalleBindingSource, "Precio_Unidad", true));
            this.precio_UnidadTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.precio_UnidadTextBox.Location = new System.Drawing.Point(700, 119);
            this.precio_UnidadTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.precio_UnidadTextBox.Name = "precio_UnidadTextBox";
            this.precio_UnidadTextBox.Size = new System.Drawing.Size(95, 22);
            this.precio_UnidadTextBox.TabIndex = 102;
            this.precio_UnidadTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.precio_UnidadTextBox.TextChanged += new System.EventHandler(this.precio_UnidadTextBox_TextChanged);
            // 
            // iD_ProductoTextBox
            // 
            this.iD_ProductoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.venta_DetalleBindingSource, "ID_Producto", true));
            this.iD_ProductoTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.iD_ProductoTextBox.Location = new System.Drawing.Point(472, 119);
            this.iD_ProductoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.iD_ProductoTextBox.Name = "iD_ProductoTextBox";
            this.iD_ProductoTextBox.Size = new System.Drawing.Size(95, 22);
            this.iD_ProductoTextBox.TabIndex = 101;
            this.iD_ProductoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guardar.BackgroundImage")));
            this.guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guardar.Location = new System.Drawing.Point(1076, 216);
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
            this.cancelar2.Location = new System.Drawing.Point(976, 189);
            this.cancelar2.Name = "cancelar2";
            this.cancelar2.Size = new System.Drawing.Size(64, 60);
            this.cancelar2.TabIndex = 11;
            this.cancelar2.UseVisualStyleBackColor = true;
            this.cancelar2.Click += new System.EventHandler(this.cancelar2_Click);
            // 
            // aceptar2
            // 
            this.aceptar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("aceptar2.BackgroundImage")));
            this.aceptar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aceptar2.Location = new System.Drawing.Point(871, 189);
            this.aceptar2.Name = "aceptar2";
            this.aceptar2.Size = new System.Drawing.Size(62, 60);
            this.aceptar2.TabIndex = 10;
            this.aceptar2.UseVisualStyleBackColor = true;
            this.aceptar2.Click += new System.EventHandler(this.aceptar2_Click);
            // 
            // ultimo2
            // 
            this.ultimo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ultimo2.BackgroundImage")));
            this.ultimo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ultimo2.Location = new System.Drawing.Point(802, 17);
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
            this.siguiente2.Location = new System.Drawing.Point(732, 17);
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
            this.anterior2.Location = new System.Drawing.Point(653, 17);
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
            this.primero2.Location = new System.Drawing.Point(586, 17);
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
            this.panel2.Controls.Add(this.nombre_PacienteComboBox);
            this.panel2.Controls.Add(this.idTextBox);
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
            this.panel2.Controls.Add(fecha_PedidoLabel);
            this.panel2.Controls.Add(this.fecha_PedidoDateTimePicker);
            this.panel2.Controls.Add(fecha_EntregaLabel);
            this.panel2.Controls.Add(this.fecha_EntregaDateTimePicker);
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
            this.panel2.Controls.Add(venta);
            this.panel2.Controls.Add(this.volver);
            this.panel2.Location = new System.Drawing.Point(51, 11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 359);
            this.panel2.TabIndex = 1;
            // 
            // metodo_pagoComboBox
            // 
            this.metodo_pagoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Metodo_Pago", true));
            this.metodo_pagoComboBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.metodo_pagoComboBox.FormattingEnabled = true;
            this.metodo_pagoComboBox.Items.AddRange(new object[] {
            "Tarjeta",
            "Efectivo",
            "PayPal",
            "Transferencia bancaria"});
            this.metodo_pagoComboBox.Location = new System.Drawing.Point(715, 170);
            this.metodo_pagoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.metodo_pagoComboBox.Name = "metodo_pagoComboBox";
            this.metodo_pagoComboBox.Size = new System.Drawing.Size(199, 23);
            this.metodo_pagoComboBox.TabIndex = 118;
            this.metodo_pagoComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.metodo_pagoComboBox_Validating);
            // 
            // nombre_PacienteComboBox
            // 
            this.nombre_PacienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "Nombre_Paciente", true));
            this.nombre_PacienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Nombre_Paciente", true));
            this.nombre_PacienteComboBox.DataSource = this.pacientesBindingSource;
            this.nombre_PacienteComboBox.DisplayMember = "Nombre";
            this.nombre_PacienteComboBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.nombre_PacienteComboBox.FormattingEnabled = true;
            this.nombre_PacienteComboBox.Location = new System.Drawing.Point(281, 173);
            this.nombre_PacienteComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombre_PacienteComboBox.Name = "nombre_PacienteComboBox";
            this.nombre_PacienteComboBox.Size = new System.Drawing.Size(231, 23);
            this.nombre_PacienteComboBox.TabIndex = 117;
            this.nombre_PacienteComboBox.ValueMember = "Nombre";
            this.nombre_PacienteComboBox.SelectedIndexChanged += new System.EventHandler(this.nombre_PacienteComboBox_SelectedIndexChanged);
            this.nombre_PacienteComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.nombre_PacienteComboBox_Validating);
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.odonticDataSet;
            // 
            // idTextBox
            // 
            this.idTextBox.AutoSize = true;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Id", true));
            this.idTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.idTextBox.Location = new System.Drawing.Point(382, 144);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(13, 15);
            this.idTextBox.TabIndex = 116;
            this.idTextBox.Text = "0";
            // 
            // iD_PacienteTextBox
            // 
            this.iD_PacienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "ID_Paciente", true));
            this.iD_PacienteTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.iD_PacienteTextBox.Location = new System.Drawing.Point(281, 244);
            this.iD_PacienteTextBox.Name = "iD_PacienteTextBox";
            this.iD_PacienteTextBox.Size = new System.Drawing.Size(234, 22);
            this.iD_PacienteTextBox.TabIndex = 97;
            this.iD_PacienteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.iD_PacienteTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.iD_PacienteTextBox_Validating);
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "DNI", true));
            this.dNITextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.dNITextBox.Location = new System.Drawing.Point(281, 208);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(234, 22);
            this.dNITextBox.TabIndex = 101;
            this.dNITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dNITextBox.Validating += new System.ComponentModel.CancelEventHandler(this.dNITextBox_Validating);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Telefono", true));
            this.telefonoTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.telefonoTextBox.Location = new System.Drawing.Point(281, 276);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(234, 22);
            this.telefonoTextBox.TabIndex = 103;
            this.telefonoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.emailTextBox.Location = new System.Drawing.Point(281, 311);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(234, 22);
            this.emailTextBox.TabIndex = 105;
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // descuentosTextBox
            // 
            this.descuentosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Descuentos", true));
            this.descuentosTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.descuentosTextBox.Location = new System.Drawing.Point(715, 206);
            this.descuentosTextBox.Name = "descuentosTextBox";
            this.descuentosTextBox.Size = new System.Drawing.Size(199, 22);
            this.descuentosTextBox.TabIndex = 109;
            this.descuentosTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // importeTextBox
            // 
            this.importeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Importe", true));
            this.importeTextBox.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.importeTextBox.Location = new System.Drawing.Point(715, 240);
            this.importeTextBox.Name = "importeTextBox";
            this.importeTextBox.Size = new System.Drawing.Size(199, 22);
            this.importeTextBox.TabIndex = 111;
            this.importeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fecha_PedidoDateTimePicker
            // 
            this.fecha_PedidoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "Fecha_Pedido", true));
            this.fecha_PedidoDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.fecha_PedidoDateTimePicker.Location = new System.Drawing.Point(715, 278);
            this.fecha_PedidoDateTimePicker.Name = "fecha_PedidoDateTimePicker";
            this.fecha_PedidoDateTimePicker.Size = new System.Drawing.Size(199, 22);
            this.fecha_PedidoDateTimePicker.TabIndex = 113;
            // 
            // fecha_EntregaDateTimePicker
            // 
            this.fecha_EntregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "Fecha_Entrega", true));
            this.fecha_EntregaDateTimePicker.Font = new System.Drawing.Font("Times New Roman", 9.2F);
            this.fecha_EntregaDateTimePicker.Location = new System.Drawing.Point(715, 318);
            this.fecha_EntregaDateTimePicker.Name = "fecha_EntregaDateTimePicker";
            this.fecha_EntregaDateTimePicker.Size = new System.Drawing.Size(199, 22);
            this.fecha_EntregaDateTimePicker.TabIndex = 115;
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
            this.buscarTextBox.Location = new System.Drawing.Point(123, 22);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(192, 20);
            this.buscarTextBox.TabIndex = 16;
            // 
            // buscarComboBox
            // 
            this.buscarComboBox.FormattingEnabled = true;
            this.buscarComboBox.Items.AddRange(new object[] {
            "Número de Venta"});
            this.buscarComboBox.Location = new System.Drawing.Point(15, 22);
            this.buscarComboBox.Name = "buscarComboBox";
            this.buscarComboBox.Size = new System.Drawing.Size(95, 21);
            this.buscarComboBox.TabIndex = 15;
            // 
            // lupa
            // 
            this.lupa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lupa.BackgroundImage")));
            this.lupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lupa.Location = new System.Drawing.Point(329, 11);
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
            this.ultimo.Location = new System.Drawing.Point(620, 22);
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
            this.siguiente.Location = new System.Drawing.Point(550, 22);
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
            this.anterior.Location = new System.Drawing.Point(471, 22);
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
            this.primero.Location = new System.Drawing.Point(404, 22);
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
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.Tipo_TratamientoTableAdapter = null;
            this.tableAdapterManager.Tratamiento_DetalleTableAdapter = null;
            this.tableAdapterManager.TratamientosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Venta_DetalleTableAdapter = this.venta_DetalleTableAdapter;
            this.tableAdapterManager.VentasTableAdapter = this.ventasTableAdapter;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // venta_DetalleTableAdapter
            // 
            this.venta_DetalleTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // odonticDataSetBindingSource
            // 
            this.odonticDataSetBindingSource.DataSource = this.odonticDataSet;
            this.odonticDataSetBindingSource.Position = 0;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "ODONTIC.chm";
            // 
            // ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 754);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "16");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventas";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Ventas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ventas_FormClosing);
            this.Load += new System.EventHandler(this.ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.venta_DetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venta_DetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.buscar.ResumeLayout(false);
            this.buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSetBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private OdonticDataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private OdonticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iD_PacienteTextBox;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox descuentosTextBox;
        private System.Windows.Forms.TextBox importeTextBox;
        private System.Windows.Forms.DateTimePicker fecha_PedidoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fecha_EntregaDateTimePicker;
        private System.Windows.Forms.Label idTextBox;
        private System.Windows.Forms.ComboBox nombre_PacienteComboBox;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.ComboBox buscarComboBox;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private OdonticDataSetTableAdapters.PacientesTableAdapter pacientesTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox metodo_pagoComboBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox precio_UnidadTextBox;
        private System.Windows.Forms.TextBox iD_ProductoTextBox;
        private System.Windows.Forms.ComboBox nombre_ProductoComboBox;
        private System.Windows.Forms.BindingSource odonticDataSetBindingSource;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private OdonticDataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource venta_DetalleBindingSource;
        private OdonticDataSetTableAdapters.Venta_DetalleTableAdapter venta_DetalleTableAdapter;
        private System.Windows.Forms.DataGridView venta_DetalleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}