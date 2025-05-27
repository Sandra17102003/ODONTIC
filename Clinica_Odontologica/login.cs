using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinica_Odontologica
{
    public partial class login : Form
    {
        public static login l;
        public login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            l = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.empleadosTableAdapter.Fill(this.odonticDataSet.Empleados);
            this.AcceptButton = Iniciar_Sesion;
        }

        private void Iniciar_Sesion_Click(object sender, EventArgs e)
        {
            BorrarError();

            if (Validar_Campos())
            {
                Boolean correcto = true;
                if (usuario_textBox.Text.Equals(""))
                {
                    correcto = false;

                }

                if (contraseña_textBox.Text.Equals(""))
                {
                    correcto = false;

                }

                if (correcto == true)
                {
                    OdonticDataSet.EmpleadosRow fila;

                    if (empleadosBindingSource.Find("usuario", usuario_textBox.Text) != -1)
                    {
                        fila = (OdonticDataSet.EmpleadosRow)odonticDataSet.Empleados.Rows[empleadosBindingSource.Find("usuario", usuario_textBox.Text)];
                        if (fila.Contraseña == contraseña_textBox.Text)
                        {
                            Properties.Settings.Default.rol = fila.Rol;
                            Properties.Settings.Default.usuario = fila.Usuario;
                            menu ventprin = new menu();
                            this.Visible = false;
                            ventprin.Show();
                            usuario_textBox.Clear();
                            contraseña_textBox.Clear();
                        }
                        else
                        { MessageBox.Show("contraseña incorrecta"); }
                    }

                    else { MessageBox.Show("El usuario incorrecto"); }
                }
            }
        }
        private bool Validar_Campos()
        {
            bool ok = true;

            if (usuario_textBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(usuario_textBox, "Ingresa un usuario");
            }

            if (contraseña_textBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(contraseña_textBox, "Ingresa su contraseña");
            }

            return ok;
        }
        private void Tooltips()
        {
            toolTip1.SetToolTip(Iniciar_Sesion, "Pulsa para Entrar en la aplicación");
        }

        private void BorrarError()
        {
            errorProvider1.SetError(usuario_textBox, "");
            errorProvider1.SetError(contraseña_textBox, "");

        }

        private void usuario_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usuario_textBox.Text))
            {
                errorProvider1.SetError(usuario_textBox, "");
            }
        }

        private void contraseña_textBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(contraseña_textBox.Text))
            {
                errorProvider1.SetError(contraseña_textBox, "");
            }
        }
    }
}
