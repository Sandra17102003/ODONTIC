namespace Clinica_Odontologica
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Iniciar_Sesion = new System.Windows.Forms.Button();
            this.contraseña_textBox = new System.Windows.Forms.TextBox();
            this.usuario_textBox = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.Label();
            this.odonticDataSet = new Clinica_Odontologica.OdonticDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Clinica_Odontologica.OdonticDataSetTableAdapters.TableAdapterManager();
            this.empleadosTableAdapter = new Clinica_Odontologica.OdonticDataSetTableAdapters.EmpleadosTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1716, 929);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.Iniciar_Sesion);
            this.panel2.Controls.Add(this.contraseña_textBox);
            this.panel2.Controls.Add(this.usuario_textBox);
            this.panel2.Controls.Add(this.contraseña);
            this.panel2.Controls.Add(this.usuario);
            this.panel2.Location = new System.Drawing.Point(416, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(961, 830);
            this.panel2.TabIndex = 0;
            // 
            // Iniciar_Sesion
            // 
            this.Iniciar_Sesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Iniciar_Sesion.BackColor = System.Drawing.Color.SkyBlue;
            this.Iniciar_Sesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Iniciar_Sesion.Font = new System.Drawing.Font("Century Schoolbook", 24F);
            this.Iniciar_Sesion.Location = new System.Drawing.Point(185, 577);
            this.Iniciar_Sesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Iniciar_Sesion.Name = "Iniciar_Sesion";
            this.Iniciar_Sesion.Size = new System.Drawing.Size(555, 66);
            this.Iniciar_Sesion.TabIndex = 2;
            this.Iniciar_Sesion.Text = "Iniciar  Sesión";
            this.Iniciar_Sesion.UseVisualStyleBackColor = false;
            this.Iniciar_Sesion.Click += new System.EventHandler(this.Iniciar_Sesion_Click);
            // 
            // contraseña_textBox
            // 
            this.contraseña_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.contraseña_textBox.Font = new System.Drawing.Font("Century Schoolbook", 24F);
            this.contraseña_textBox.Location = new System.Drawing.Point(185, 443);
            this.contraseña_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.contraseña_textBox.Name = "contraseña_textBox";
            this.contraseña_textBox.PasswordChar = '•';
            this.contraseña_textBox.Size = new System.Drawing.Size(556, 46);
            this.contraseña_textBox.TabIndex = 1;
            this.contraseña_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contraseña_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.contraseña_textBox_Validating);
            // 
            // usuario_textBox
            // 
            this.usuario_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usuario_textBox.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario_textBox.Location = new System.Drawing.Point(185, 228);
            this.usuario_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usuario_textBox.Name = "usuario_textBox";
            this.usuario_textBox.Size = new System.Drawing.Size(556, 46);
            this.usuario_textBox.TabIndex = 0;
            this.usuario_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usuario_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.usuario_textBox_Validating);
            // 
            // contraseña
            // 
            this.contraseña.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.contraseña.AutoSize = true;
            this.contraseña.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.Location = new System.Drawing.Point(232, 350);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(339, 54);
            this.contraseña.TabIndex = 1;
            this.contraseña.Text = "CONTRASEÑA:";
            this.contraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usuario
            // 
            this.usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.usuario.AutoSize = true;
            this.usuario.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.Location = new System.Drawing.Point(295, 140);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(232, 54);
            this.usuario.TabIndex = 0;
            this.usuario.Text = "USUARIO:";
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "ODONTIC.chm";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1716, 929);
            this.Controls.Add(this.panel1);
            this.helpProvider1.SetHelpKeyword(this, "2");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "login";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "ODONTIC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.odonticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usuario;
        private System.Windows.Forms.Label contraseña;
        private System.Windows.Forms.TextBox usuario_textBox;
        private System.Windows.Forms.TextBox contraseña_textBox;
        private System.Windows.Forms.Button Iniciar_Sesion;
        private System.Windows.Forms.Panel panel2;
        private OdonticDataSet odonticDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private OdonticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private OdonticDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

