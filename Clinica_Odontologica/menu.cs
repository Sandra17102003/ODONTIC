using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Odontologica
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.Fill(this.odonticDataSet.Empleados);
            rol.Text = Properties.Settings.Default.rol;
            usuario.Text = Properties.Settings.Default.usuario;

            if (Properties.Settings.Default.rol == "Administrador")
            {
                empleado.Visible = false;
                this.helpProvider1.SetHelpKeyword(this, "5");
            }
            else if (Properties.Settings.Default.rol == "Empleado")
            {
                empleado.Visible = true;
                this.helpProvider1.SetHelpKeyword(this, "6");
            }
        }

        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres cerrar esta Ventana?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            if (!(e.Cancel == true))
            {
                this.Hide();
                login.l.Show();
            }
        }

        private void volver_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Visible = false;
            login.Show();
        }

        private void empleados_Click(object sender, EventArgs e)
        {
            empleados empleados = new empleados(this);
            this.Hide();
            empleados.Show();
        }
        private void proveedores_Click(object sender, EventArgs e)
        {
            proveedores proveedores = new proveedores(this);
            this.Hide();
            proveedores.Show();
        }

        private void productos_Click(object sender, EventArgs e)
        {
            productos productos = new productos(this);
            this.Hide();
            productos.Show();
        }

        private void pacientes_Click(object sender, EventArgs e)
        {
            pacientes pacientes = new pacientes(this);
            this.Hide();
            pacientes.Show();
            
        }

        private void compras_Click(object sender, EventArgs e)
        {
            compras compras = new compras(this);
            this.Hide();
            compras.Show();
        }

        private void ventas_Click(object sender, EventArgs e)
        {
            ventas ventas = new ventas(this);
            this.Hide();
            ventas.Show();
        }

        private void tratamientos_Click(object sender, EventArgs e)
        {
            tratamientos tratamientos = new tratamientos(this);
            this.Hide();
            tratamientos.Show();
        }
    }
}
