namespace Clinica_Odontologica
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.volver = new System.Windows.Forms.Button();
            this.empleado = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ventas = new System.Windows.Forms.Button();
            this.tratamientos = new System.Windows.Forms.Button();
            this.pacientes = new System.Windows.Forms.Button();
            this.productos = new System.Windows.Forms.Button();
            this.compras = new System.Windows.Forms.Button();
            this.proveedores = new System.Windows.Forms.Button();
            this.empleados = new System.Windows.Forms.Button();
            this.usuario = new System.Windows.Forms.Label();
            this.rol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.odonticDataSet = new Clinica_Odontologica.OdonticDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager();
            this.empleadosTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.EmpleadosTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1823, 961);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.volver);
            this.panel2.Controls.Add(this.empleado);
            this.panel2.Controls.Add(this.ventas);
            this.panel2.Controls.Add(this.tratamientos);
            this.panel2.Controls.Add(this.pacientes);
            this.panel2.Controls.Add(this.productos);
            this.panel2.Controls.Add(this.compras);
            this.panel2.Controls.Add(this.proveedores);
            this.panel2.Controls.Add(this.empleados);
            this.panel2.Controls.Add(this.usuario);
            this.panel2.Controls.Add(this.rol);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(63, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1695, 868);
            this.panel2.TabIndex = 1;
            // 
            // volver
            // 
            this.volver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("volver.BackgroundImage")));
            this.volver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.volver.Location = new System.Drawing.Point(36, 20);
            this.volver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(77, 76);
            this.volver.TabIndex = 7;
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // empleado
            // 
            this.empleado.BackColor = System.Drawing.Color.AliceBlue;
            this.empleado.Controls.Add(this.logo);
            this.empleado.Location = new System.Drawing.Point(3, 114);
            this.empleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empleado.Name = "empleado";
            this.empleado.Size = new System.Drawing.Size(1689, 375);
            this.empleado.TabIndex = 4;
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(461, 14);
            this.logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(785, 341);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // ventas
            // 
            this.ventas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ventas.BackgroundImage")));
            this.ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ventas.Location = new System.Drawing.Point(1279, 529);
            this.ventas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ventas.Name = "ventas";
            this.ventas.Size = new System.Drawing.Size(283, 254);
            this.ventas.TabIndex = 6;
            this.ventas.UseVisualStyleBackColor = true;
            this.ventas.Click += new System.EventHandler(this.ventas_Click);
            // 
            // tratamientos
            // 
            this.tratamientos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tratamientos.BackgroundImage")));
            this.tratamientos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tratamientos.Location = new System.Drawing.Point(865, 529);
            this.tratamientos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tratamientos.Name = "tratamientos";
            this.tratamientos.Size = new System.Drawing.Size(300, 254);
            this.tratamientos.TabIndex = 5;
            this.tratamientos.UseVisualStyleBackColor = true;
            this.tratamientos.Click += new System.EventHandler(this.tratamientos_Click);
            // 
            // pacientes
            // 
            this.pacientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pacientes.BackgroundImage")));
            this.pacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pacientes.Location = new System.Drawing.Point(473, 529);
            this.pacientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pacientes.Name = "pacientes";
            this.pacientes.Size = new System.Drawing.Size(277, 254);
            this.pacientes.TabIndex = 4;
            this.pacientes.UseVisualStyleBackColor = true;
            this.pacientes.Click += new System.EventHandler(this.pacientes_Click);
            // 
            // productos
            // 
            this.productos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("productos.BackgroundImage")));
            this.productos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.productos.Location = new System.Drawing.Point(93, 529);
            this.productos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productos.Name = "productos";
            this.productos.Size = new System.Drawing.Size(273, 254);
            this.productos.TabIndex = 3;
            this.productos.UseVisualStyleBackColor = true;
            this.productos.Click += new System.EventHandler(this.productos_Click);
            // 
            // compras
            // 
            this.compras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("compras.BackgroundImage")));
            this.compras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.compras.Location = new System.Drawing.Point(1069, 149);
            this.compras.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.compras.Name = "compras";
            this.compras.Size = new System.Drawing.Size(288, 249);
            this.compras.TabIndex = 2;
            this.compras.UseVisualStyleBackColor = true;
            this.compras.Click += new System.EventHandler(this.compras_Click);
            // 
            // proveedores
            // 
            this.proveedores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("proveedores.BackgroundImage")));
            this.proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.proveedores.Location = new System.Drawing.Point(653, 149);
            this.proveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proveedores.Name = "proveedores";
            this.proveedores.Size = new System.Drawing.Size(307, 249);
            this.proveedores.TabIndex = 1;
            this.proveedores.UseVisualStyleBackColor = true;
            this.proveedores.Click += new System.EventHandler(this.proveedores_Click);
            // 
            // empleados
            // 
            this.empleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("empleados.BackgroundImage")));
            this.empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.empleados.Location = new System.Drawing.Point(265, 149);
            this.empleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empleados.Name = "empleados";
            this.empleados.Size = new System.Drawing.Size(269, 249);
            this.empleados.TabIndex = 0;
            this.empleados.UseVisualStyleBackColor = true;
            this.empleados.Click += new System.EventHandler(this.empleados_Click);
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Algerian", 22.2F);
            this.usuario.Location = new System.Drawing.Point(1212, 54);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(155, 41);
            this.usuario.TabIndex = 2;
            this.usuario.Text = "label3";
            // 
            // rol
            // 
            this.rol.AutoSize = true;
            this.rol.Font = new System.Drawing.Font("Algerian", 22.2F);
            this.rol.Location = new System.Drawing.Point(787, 54);
            this.rol.Name = "rol";
            this.rol.Size = new System.Drawing.Size(155, 41);
            this.rol.TabIndex = 1;
            this.rol.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Has Iniciado sesión como:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaTableAdapter = null;
            this.tableAdapterManager.Compra_DetalleTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "ODONTIC.chm";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1823, 961);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "menu";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Menú";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.menu_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.empleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label rol;
        private OdonticDataSet odonticDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private OdonticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel empleado;
        private System.Windows.Forms.Button compras;
        private System.Windows.Forms.Button proveedores;
        private System.Windows.Forms.Button empleados;
        private System.Windows.Forms.Button ventas;
        private System.Windows.Forms.Button tratamientos;
        private System.Windows.Forms.Button pacientes;
        private System.Windows.Forms.Button productos;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button volver;
        private OdonticDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}