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
    public partial class proveedores: Form
    {
        private menu menu;
        public proveedores(menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void proveedores_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.proveedoresTableAdapter.Fill(this.odonticDataSet.Proveedores);
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

        private void proveedores_FormClosing(object sender, FormClosingEventArgs e)
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
            proveedoresBindingSource.MoveFirst();
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource.MovePrevious();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource.MoveNext();
        }

        private void ultimo_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource.MoveLast();
        }

        private void anadir_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource.AddNew();
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
            buscar.Enabled = false;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Está seguro de que desea borrar el proveedor con el número " + idTextBox.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    proveedoresBindingSource.RemoveCurrent();
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
            string nif = nIFTextBox.Text;
            string telefono = telefonoTextBox.Text;
            string email = emailTextBox.Text;
            string direccion = direccionTextBox.Text;
            string localidad = localidadTextBox.Text;
            string codigo_postal = codigo_PostalTextBox.Text;
            string provincia = provinciaTextBox.Text;
            string pais = paisTextBox.Text;
            string num_cuenta = numero_CuentaTextBox.Text;
            string notas = notasTextBox.Text;


            string registro = $"Id: {id}\n" +
                              $"Nombre: {nombre}\n" +
                              $"NIF: {nif}\n" +
                              $"Teléfono: {telefono}\n" +
                              $"Email: {email}\n" +
                              $"Dirección: {direccion}\n" +
                              $"Localidad: {localidad}\n" +
                              $"Código Postal: {codigo_postal}\n" +
                              $"Provincia: {provincia}\n" +
                              $"País: {pais}\n" +
                              $"Numero de Cuenta: {num_cuenta}\n" +
                              $"Comentarios: {notas}\n";
            DrawText(e, registro);
        }

        private void DrawText(System.Drawing.Printing.PrintPageEventArgs e, string text)
        {
            Image imagen = fotos.Image;

            float imgY = e.MarginBounds.Top;
            float textY = imgY;
            int newWidth = 255;
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
            informe_proveedores informe_proveedores = new informe_proveedores(this);
            this.Hide();
            informe_proveedores.Show();
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

                    if (proveedoresBindingSource.Find("Id", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("No se ha encontrado ningún producto con id:" + idTextBox.Text);
                    }
                    else
                    {
                        proveedoresBindingSource.Position = proveedoresBindingSource.Find("ID", buscarTextBox.Text);
                    }
                }
                else
                {
                    if (proveedoresBindingSource.Find("Nombre", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("No se ha encontrado ningún producto con el nombre:" + buscarTextBox.Text);
                    }
                    else
                    {
                        proveedoresBindingSource.Position = proveedoresBindingSource.Find("Nombre", buscarTextBox.Text);
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
                    proveedoresBindingSource.EndEdit();
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
            proveedoresBindingSource.CancelEdit();
            BorrarError();
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
            aceptar.Visible = false;
            cancelar.Visible = false;
            modo_lectura();
        }

        private bool Validar_Campos()
        {
            bool ok = true;

            if (nombreTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nombreTextBox, "Ingresa un dato");
            }

            if (nIFTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nIFTextBox, "Ingresa un dato");
            }

            if (numero_CuentaTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(numero_CuentaTextBox, "Ingresa un dato");
            }
            return ok;
        }

        private void BorrarError()
        {
            errorProvider1.SetError(nombreTextBox, "");
            errorProvider1.SetError(nIFTextBox, "");
            errorProvider1.SetError(numero_CuentaTextBox, "");
        }


        private void modo_lectura()
        {
            //Imagen
            fotos.Enabled = false;

            //Comentarios
            notas_groupBox.Enabled = false;

            //Información Personal
            informacion_personal_groupBox.Enabled = false;

            //Datos de Contacto
            datos_contacto_groupBox.Enabled = false;

            //Datos Bancarios
            cuenta_groupBox.Enabled = false;

            //buscar
            buscar.Enabled = true;
        }

        private void modo_escritura()
        {
            //Imagen
            fotos.Enabled = true;

            //Comentarios
            notas_groupBox.Enabled = true;

            //Información Personal
            informacion_personal_groupBox.Enabled = true;

            //Datos de Contacto
            datos_contacto_groupBox.Enabled = true;

            //Datos Bancarios
            cuenta_groupBox.Enabled = true;

            //buscar
            buscar.Enabled = false;
        }
        private void Tooltips()
        {
            toolTip1.SetToolTip(imprimir, "Pulsa para IMPRIMIR los Proveedores");
            toolTip1.SetToolTip(informes, "Pulsa para IR al Informe");
            toolTip1.SetToolTip(volver, "Pulsa para VOLVER a la Ventana anterior");
            toolTip1.SetToolTip(lupa, "Pulsa para BUSCAR un Proveedor");
            toolTip1.SetToolTip(primero, "Pulsa para ir al PRIMER Proveedor");
            toolTip1.SetToolTip(anterior, "Pulsa para ir al ANTERIOR Proveedor");
            toolTip1.SetToolTip(siguiente, "Pulsa para ir al SIGUIENTE Proveedor");
            toolTip1.SetToolTip(ultimo, "Pulsa para ir al ÚLTIMO Proveedor");
            toolTip1.SetToolTip(anadir, "Pulsa para AÑADIR un nuevo Proveedor");
            toolTip1.SetToolTip(eliminar, "Pulsa para ELIMINAR un Proveedor");
            toolTip1.SetToolTip(editar, "Pulsa para EDITAR un Proveedor");
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

        private void nIFTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nIFTextBox.Text))
            {
                errorProvider1.SetError(nIFTextBox, "");
            }
        }

        private void numero_CuentaTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(numero_CuentaTextBox.Text))
            {
                errorProvider1.SetError(numero_CuentaTextBox, "");
            }
        }
    }
}
