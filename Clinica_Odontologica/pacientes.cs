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
    public partial class pacientes: Form
    {
        private menu menu;
        public pacientes(menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }
        private void pacientes_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.pacientesTableAdapter.Fill(this.odonticDataSet.Pacientes);
            modo_lectura();
            aceptar.Visible = false;
            cancelar.Visible = false;
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
            this.Dispose();
        }

        private void pacientes_FormClosing(object sender, FormClosingEventArgs e)
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
            pacientesBindingSource.MoveFirst();

        }

        private void anterior_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.MovePrevious();

        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.MoveNext();

        }

        private void ultimo_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.MoveLast();

        }

        private void anadir_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.AddNew();
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
            buscar.Enabled = false;
            aceptar.Visible = true;
            cancelar.Visible = true;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de que desea borrar el cliente con el número " + idTextBox.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    pacientesBindingSource.RemoveCurrent();
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
            fotos.Enabled = true;
            fotos.Visible = true;
            primero.Enabled = false;
            anterior.Enabled = false;
            siguiente.Enabled = false;
            ultimo.Enabled = false;
            anadir.Enabled = false;
            eliminar.Enabled = false;
            editar.Enabled = false;
            imprimir.Enabled = false;
            informes.Enabled = false;
            buscar.Enabled = false;
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
            string apellidos = apellidoTextBox.Text;
            string dni = dNITextBox.Text;
            string genero = generoTextBox.Text;
            string fecha_nacimiento = fecha_NacimientoDateTimePicker.Text;
            string edad = edadTextBox.Text;
            string telefono = telefonoTextBox.Text;
            string email = emailTextBox.Text;
            string direccion = direccionTextBox.Text;
            string localidad = localidadTextBox.Text;
            string codigo_postal = codigo_PostalTextBox.Text;
            string provincia = provinciaTextBox.Text;
            string pais = paisTextBox.Text;

            string altura = alturaTextBox.Text;
            string peso = pesoTextBox.Text;

            string historial = historial_MedicoTextBox.Text;
            string alergias = alergiasTextBox.Text;
            string estado_salud = estado_SaludTextBox.Text;

            string seguro = seguro_SaludTextBox.Text;
            string numero_seguro = numero_SeguroTextBox.Text;

            string infantil = infantilCheckBox.Text;
            string activo = activoCheckBox.Text;

            string nota = notasTextBox.Text;

            string registro = $"Id: {id}\n" +
                              $"Nombre: {nombre}\n" +
                              $"Género: {genero}\n" +
                              $"DNI: {dni}\n" +
                              $"Dirección: {direccion}\n" +
                              $"Localidad: {localidad}\n" +
                              $"Código Postal: {codigo_postal}\n" +
                              $"Provincia: {provincia}\n" +
                              $"País: {pais}\n" +
                              $"Teléfono: {telefono}\n" +
                              $"Fecha de Nacimiento: {fecha_nacimiento}\n" +
                              $"Edad: {edad}\n" +
                              $"Email: {email}\n" +
                              $"Altura: {altura}\n" +
                              $"Peso: {peso}\n" +
                              $"Historial Médico: {historial}\n" +
                              $"Alergias: {alergias}\n" +
                              $"Estado de Salud: {estado_salud}\n" +
                              $"Seguro de Salud: {seguro}\n" +
                              $"Número del Seguro: {numero_seguro}\n" +
                              $"Infantil: {infantil}\n" +
                              $"Activo: {activo}\n" +
                              $" Notas: {nota}\n";
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
            informe_pacientes informe_pacientes = new informe_pacientes(this);
            this.Hide();
            informe_pacientes.Show();
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
            else
            {
                String busca = buscarComboBox.SelectedItem.ToString();
                if (busca.Equals("ID"))
                {

                    if (pacientesBindingSource.Find("Id", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("No se ha encontrado ningún Paciente con id:" + idTextBox.Text);
                    }
                    else
                    {
                        pacientesBindingSource.Position = pacientesBindingSource.Find("ID", buscarTextBox.Text);
                    }
                }
                else
                {
                    if (pacientesBindingSource.Find("Nombre", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("No se ha encontrado ningún Paciente con el nombre:" + buscarTextBox.Text);
                    }
                    else
                    {
                        pacientesBindingSource.Position = pacientesBindingSource.Find("Nombre", buscarTextBox.Text);
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
                    pacientesBindingSource.EndEdit();
                    tableAdapterManager.UpdateAll(odonticDataSet);
                    MessageBox.Show("Los cambios se han guardado correctamente en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    aceptar.Visible = false;
                    cancelar.Visible = false;
                    modo_lectura();
                    primero.Enabled = true;
                    anterior.Enabled = true;
                    siguiente.Enabled = true;
                    anadir.Enabled = true;
                    eliminar.Enabled = true;
                    editar.Enabled = true;
                    imprimir.Enabled = true;
                    informes.Enabled = true;
                    buscar.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            pacientesBindingSource.CancelEdit();
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
            buscar.Enabled = true;
        }


        private bool Validar_Campos()
        {
            bool ok = true;

            if (nombreTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nombreTextBox, "Ingresa un dato");
            }

            if (generoTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(generoTextBox, "Ingresa un dato");
            }

            if (dNITextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dNITextBox, "Ingresa un dato");
            }


            if (telefonoTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(telefonoTextBox, "Ingresa un dato numérico");
            }

            if (emailTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(emailTextBox, "Ingresa un dato");
            }

            if (alturaTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(alturaTextBox, "Ingresa un dato");
            }


            if (pesoTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(pesoTextBox, "Ingresa un dato");
            }

            return ok;
        }
        private void BorrarError()
        {
            errorProvider1.SetError(nombreTextBox, "");
            errorProvider1.SetError(generoTextBox, "");
            errorProvider1.SetError(dNITextBox, "");
            errorProvider1.SetError(telefonoTextBox, "");
            errorProvider1.SetError(emailTextBox, "");
            errorProvider1.SetError(alturaTextBox, "");
            errorProvider1.SetError(pesoTextBox, "");
        }


        private void modo_lectura()
        {
            //Imagen
            fotos.Enabled = false;

            //informacion personal
            informacion_personal.Enabled = false;

            // datos de contacto
            datos_contacto.Enabled = false;

            //especificaciones
            especificaciones.Enabled = false;

            //historial médico
            historial_medico.Enabled = false;

            //seguro médico
            seguro_medico.Enabled = false;

            //categoria del paciente
            categoria_paciente.Enabled = false;

            //notas
            notas.Enabled = false;
        }

        private void modo_escritura()
        {
            //Imagen
            fotos.Enabled = true;

            //informacion personal
            informacion_personal.Enabled = true;

            // datos de contacto
            datos_contacto.Enabled = true;

            //especificaciones
            especificaciones.Enabled = true;

            //historial médico
            historial_medico.Enabled = true;

            //seguro médico
            seguro_medico.Enabled = true;

            //categoria del paciente
            categoria_paciente.Enabled = true;

            //notas
            notas.Enabled = true;
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
    }

}
