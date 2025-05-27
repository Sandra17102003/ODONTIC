using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Odontologica
{
    public partial class empleados: Form
    {
        private menu menu;

        public empleados(menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);
        }

        private void empleados_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.empleadosTableAdapter.Fill(this.odonticDataSet.Empleados);
            aceptar.Visible = false;
            cancelar.Visible = false;
            modo_lectura();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
            this.Dispose();
        }

        private void empleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que quieres cerrar esta Ventana?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            if (!(e.Cancel == true))
            {
                this.Hide();
                menu.Show();
            }
        }
        private void primero_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveFirst();
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MovePrevious();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveNext();
        }

        private void ultimo_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveLast();
        }

        private void anadir_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.AddNew();
            fecha_NacimientoDateTimePicker.Value = DateTime.Now;
            fotos.Visible = true;
            modo_escritura();
            primero.Enabled = false;
            anterior.Enabled = false;
            siguiente.Enabled = false;
            ultimo.Enabled = false;
            anadir.Enabled = false;
            eliminar.Enabled = false;
            editar.Enabled = false;
            imprimir.Enabled = false;
            informes.Enabled = false;
            aceptar.Visible = true;
            cancelar.Visible = true;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de que desea borrar el empleado con el número " + idTextBox.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    empleadosBindingSource.RemoveCurrent();
                    tableAdapterManager.UpdateAll(odonticDataSet);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            modo_escritura();
            fotos.Visible = true;
            fotos.Enabled = true;
            primero.Enabled = false;
            anterior.Enabled = false;
            siguiente.Enabled = false;
            ultimo.Enabled = false;
            anadir.Enabled = false;
            eliminar.Enabled = false;
            editar.Enabled = false;
            imprimir.Enabled = false;
            informes.Enabled = false;
            aceptar.Visible = true;
            cancelar.Visible = true;
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printDialog1.PrinterSettings;
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string id = idTextBox.Text;
            string nombre = nombreTextBox.Text;
            string apellidos = apellidosTextBox.Text;
            string dni = dNITextBox.Text;
            string fecha_nacimiento = fecha_NacimientoDateTimePicker.Text;
            string edad = edadTextBox.Text;
            string genero = generoTextBox.Text;
            string email = emailTextBox.Text;
            string telefono = telefonoTextBox.Text;
            string direccion = direccionTextBox.Text;
            string codigo_postal = codigo_PostalTextBox.Text;
            string localidad = localidadTextBox.Text;
            string provincia = provinciaTextBox.Text;
            string pais = paisTextBox.Text;
            string rol = rolTextBox.Text;
            string usuario = usuarioTextBox.Text;
            string contraseña = contraseñaTextBox.Text;
            string estudios = estudiosTextBox.Text;
            string notas = notasTextBox.Text;


            string registro = $"Id: {id}\n" +
                              $"Nombre: {nombre}\n" +
                              $"Apellidos: {apellidos}\n" +
                              $"DNI: {dni}\n" +
                              $"Fecha de Nacimiento: {fecha_nacimiento}\n" +
                              $"Edad: {edad}\n" +
                              $"Género: {genero}\n" +
                              $"Email: {email}\n" +
                              $"Teléfono: {telefono}\n" +
                              $"Dirección: {direccion}\n" +
                              $"Código Postal: {codigo_postal}\n" +
                              $"Localidad: {localidad}\n" +
                              $"Provincia: {provincia}\n" +
                              $"País: {pais}\n" +
                              $"ROL: {rol}\n" +
                              $"USUARIO: {usuario}\n" +
                              $"CONTRASEÑA: {contraseña}\n" +
                              $"Estudios: {estudios}\n" +
                              $"Comentarios: {notas}\n";
            DrawText(e, registro);
        }

        private void DrawText(System.Drawing.Printing.PrintPageEventArgs e, string text)
        {
            Image imagen = fotos.Image;

            float imgY = e.MarginBounds.Top;
            float textY = imgY;
            int newWidth = 205;
            int newHeight = 255;

            if (imagen != null)
            {
                Image resizedImage = imagen.GetThumbnailImage(newWidth, newHeight, null, IntPtr.Zero);
                float imgX = e.MarginBounds.Left + (e.MarginBounds.Width - imagen.Width) / 2;
                e.Graphics.DrawImage(resizedImage, imgX, imgY);
                textY = imgY + newHeight + 50;
            }

            Font font = new Font("Century", 14);
            float x = e.MarginBounds.Left;
            float y = textY;

            e.Graphics.DrawString(text, font, Brushes.Black, x, y);
        }

        private void informes_Click(object sender, EventArgs e)
        {
            informe_empleados informe_empleados = new informe_empleados(this);
            this.Hide();
            informe_empleados.Show();
        }

        private void fotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "Archivos gráficos | *.png; *.jpg;";

            if (op.ShowDialog() == DialogResult.OK)
            {
                fotos.Image = Image.FromFile(op.FileName);
                fotos.BackgroundImage = null;
            }
        }

        private void lupa_Click(object sender, EventArgs e)
        {

            if (buscarTextBox.Text.Equals(""))
            {
                MessageBox.Show("Introduce un dato.");
            }
            else {
                String busca = buscarComboBox.SelectedItem.ToString();
                if (busca.Equals("ID"))
                {

                    if (empleadosBindingSource.Find("Id", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("No se ha encontrado ningún producto con id:" + idTextBox.Text);
                    }
                    else
                    {
                        empleadosBindingSource.Position = empleadosBindingSource.Find("ID", buscarTextBox.Text);
                    }
                }
                else
                {
                    if (empleadosBindingSource.Find("Nombre", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("No se ha encontrado ningún producto con el nombre:" + buscarTextBox.Text);
                    }
                    else
                    {
                        empleadosBindingSource.Position = empleadosBindingSource.Find("Nombre", buscarTextBox.Text);
                    }
                }
                buscarTextBox.Clear();
            }
        }
        private void aceptar_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (Validar_Campos())
            {
                try
                {
                    empleadosBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(odonticDataSet);
                    MessageBox.Show("Los cambios se han guardado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aceptar.Visible = false;
                    cancelar.Visible = false;
                    modo_lectura();
                    primero.Enabled = true;
                    anterior.Enabled = true;
                    siguiente.Enabled = true;
                    ultimo.Enabled = true;
                    anadir.Enabled = true;
                    eliminar.Enabled = true;
                    editar.Enabled = true;
                    imprimir.Enabled = true;
                    informes.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.CancelEdit();
            BorrarError();
            aceptar.Visible = false;
            cancelar.Visible = false;
            modo_lectura();
            primero.Enabled = true;
            anterior.Enabled = true;
            siguiente.Enabled = true;
            ultimo.Enabled = true;
            anadir.Enabled = true;
            eliminar.Enabled = true;
            editar.Enabled = true;
            imprimir.Enabled = true;
            informes.Enabled = true;
        }

        private bool Validar_Campos()
        {
            bool ok = true;

            if (nombreTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nombreTextBox, "Ingresa un dato");
            }

            if (dNITextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dNITextBox, "Ingresa un dato");

            }

            if (emailTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(emailTextBox, "Ingresa un dato");
            }

            if (telefonoTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(telefonoTextBox, "Ingresa un dato numérico");
            }

            if (rolTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(rolTextBox, "Ingresa un dato numérico");
            }


            if (usuarioTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(usuarioTextBox, "Ingresa un dato");
            }

            if (contraseñaTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(contraseñaTextBox, "Ingresa un dato");
            }

            return ok;
        }

        private void BorrarError()
        {
            errorProvider1.SetError(nombreTextBox, "");
            errorProvider1.SetError(dNITextBox, "");
            errorProvider1.SetError(emailTextBox, "");
            errorProvider1.SetError(telefonoTextBox, "");
            errorProvider1.SetError(rolTextBox, "");
            errorProvider1.SetError(usuarioTextBox, "");
            errorProvider1.SetError(contraseñaTextBox, "");
        }

        private void modo_lectura()
        {
            //imagen
            fotos.Enabled = false;

            //comentarios
            notas_groupBox.Enabled = false; 

            //informacion personal
            informacion_personal_groupBox.Enabled = false;

            //datos de contacto
            datos_contacto_groupBox.Enabled = false;

            //especificaciones
            especificaciones_groupBox.Enabled = false;

            //estudios
            estudios_groupBox.Enabled = false;

            //buscar
            buscar.Enabled = true;
        }

        private void modo_escritura()
        {
            //imagen
            fotos.Enabled = true;

            //comentarios
            notas_groupBox.Enabled = true;

            //informacion personal
            informacion_personal_groupBox.Enabled = true;

            //datos de contacto
            datos_contacto_groupBox.Enabled = true;

            //especificaciones
            especificaciones_groupBox.Enabled = true;

            //estudios
            estudios_groupBox.Enabled = true;

            //buscar
            buscar.Enabled = false;
        }

        private void Tooltips()
        {
            toolTip1.SetToolTip(imprimir, "Pulsa para IMPRIMIR los Empleados");
            toolTip1.SetToolTip(informes, "Pulsa para IR al Informe");
            toolTip1.SetToolTip(volver, "Pulsa para VOLVER a la Ventana anterior");
            toolTip1.SetToolTip(lupa, "Pulsa para BUSCAR un Empleado");
            toolTip1.SetToolTip(primero, "Pulsa para ir al PRIMER Empleado");
            toolTip1.SetToolTip(anterior, "Pulsa para ir al ANTERIOR Empleado");
            toolTip1.SetToolTip(siguiente, "Pulsa para ir al SIGUIENTE Empleado");
            toolTip1.SetToolTip(ultimo, "Pulsa para ir al ÚLTIMO Empleado");
            toolTip1.SetToolTip(anadir, "Pulsa para AÑADIR un nuevo Empleado");
            toolTip1.SetToolTip(eliminar, "Pulsa para ELIMINAR un Empleado");
            toolTip1.SetToolTip(editar, "Pulsa para EDITAR un Empleado");
            toolTip1.SetToolTip(aceptar, "Pulsa para ACEPTAR");
            toolTip1.SetToolTip(cancelar, "Pulsa para CANCELAR");
            toolTip1.InitialDelay = 1000;
        }

        private void nombreTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "");
            }
        }

        private void dNITextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dNITextBox.Text))
            {
                errorProvider1.SetError(dNITextBox, "");
            }
        }

        private void emailTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                errorProvider1.SetError(emailTextBox, "");
            }
        }

        private void telefonoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(telefonoTextBox.Text))
            {
                errorProvider1.SetError(telefonoTextBox, "");
            }
        }

        private void rolTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rolTextBox.Text))
            {
                errorProvider1.SetError(rolTextBox, "");
            }
        }

        private void usuarioTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(usuarioTextBox.Text))
            {
                errorProvider1.SetError(usuarioTextBox, "");
            }
        }

        private void contraseñaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(contraseñaTextBox.Text))
            {
                errorProvider1.SetError(contraseñaTextBox, "");
            }
        }
    }
}
