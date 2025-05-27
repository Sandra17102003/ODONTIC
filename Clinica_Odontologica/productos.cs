using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinica_Odontologica
{
    public partial class productos : Form
    {
        private menu menu;
        public productos(menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = false;
        }

        private void productos_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.productosTableAdapter.Fill(this.odonticDataSet.Productos);
            this.categoriaTableAdapter.Fill(this.odonticDataSet.Categoria);
            this.marcaTableAdapter.Fill(this.odonticDataSet.Marca);
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

        private void productos_FormClosing(object sender, FormClosingEventArgs e)
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
            productosBindingSource.MoveFirst();
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            productosBindingSource.MovePrevious();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveNext();
        }

        private void ultimo_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveLast();
        }

        private void anadir_Click(object sender, EventArgs e)
        {
            productosBindingSource.AddNew();
            fecha_LanzamientoDateTimePicker.Value = DateTime.Now;
            fecha_CaducidadDateTimePicker.Value = DateTime.Now;
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
                if (MessageBox.Show("¿Está seguro de que desea borrar el producto con el número " + idTextBox.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    productosBindingSource.RemoveCurrent();
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
            string categoria = categoriaComboBox.Text;
            string marca = marcaComboBox.Text;
            string nombre = nombreTextBox.Text;
            string precio = precioTextBox.Text;
            string stock = stockTextBox.Text;
            string peso = pesoTextBox.Text;
            string envase_reciclable = envase_reciclableCheckBox.Checked ? "Envase Reciclable: Sí" : "Envase Reciclable: No";
            string fecha_lanzamiento = fecha_LanzamientoDateTimePicker.Text;
            string fecha_vencimiento = fecha_CaducidadDateTimePicker.Text;
            string descripcion = descripcionTextBox.Text;
            string opiniones = opinionesTextBox.Text;

            string registro = $"Id: {id}\n" +
                              $"Nombre: {nombre}\n" +
                              $"Categoría: {categoria}\n" +
                              $"Marca: {marca}\n" +
                              $"Precio: {precio} €\n" +
                              $"Stock: {stock}\n" +
                              $"Peso: {peso} g\n" +
                              $"Envase reciclable: {envase_reciclable}\n" +
                              $"Fecha de Lanzamiento: {fecha_lanzamiento}\n" +
                              $"Fecha de Vencimiento: {fecha_vencimiento}\n" +
                              $"Descripción: {descripcion}\n" +
                              $"Opiniones: {opiniones}\n";

            DrawText(e, registro);
        }

        private void DrawText(System.Drawing.Printing.PrintPageEventArgs e, string text)
        {
            Image imagen = fotos.Image;

            float imgY = e.MarginBounds.Top;
            float textY = imgY;
            int newWidth = 255;
            int newHeight = 243;

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

            lastTextHeight = e.Graphics.MeasureString(text, font).Height;
            lastTextY = y;
        }
        float lastTextHeight;
        float lastTextY;

        private void DrawText2(System.Drawing.Printing.PrintPageEventArgs e, string text)
        {
            Font font = new Font("Century", 14);
            float x = e.MarginBounds.Left;
            float y = lastTextY + lastTextHeight + 50;

            e.Graphics.DrawString(text, font, Brushes.Black, x, y);
        }


        private void informes_Click(object sender, EventArgs e)
        {
           informe_productos informe_productos = new informe_productos(this);
            this.Hide();
            informe_productos.Show();
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
                    if (productosBindingSource.Find("Id", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("No se ha encontrado ningún producto con id:" + idTextBox.Text);
                    }
                    else
                    {
                        productosBindingSource.Position = productosBindingSource.Find("ID", buscarTextBox.Text);
                    }
                }
                else
                {
                    if (productosBindingSource.Find("Nombre", buscarTextBox.Text) == -1)
                    {
                        MessageBox.Show("No se ha encontrado ningún producto con el nombre:" + buscarTextBox.Text);
                    }
                    else
                    {
                        productosBindingSource.Position = productosBindingSource.Find("Nombre", buscarTextBox.Text);
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
                    productosBindingSource.EndEdit();
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
            productosBindingSource.CancelEdit();
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

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoriaComboBox.SelectedIndex == 0)
            {
                Dentifricos.Visible = true;
                Enjuagues.Visible = false;
                Cepillos.Visible = false;
                Cera.Visible = false;   
            }
            if (categoriaComboBox.SelectedIndex == 1)
            {
                Dentifricos.Visible = false;
                Enjuagues.Visible = true;
                Cepillos.Visible = false;
                Cera.Visible = false;
            }
            if (categoriaComboBox.SelectedIndex == 2)
            {
                Dentifricos.Visible = false;
                Enjuagues.Visible = false;
                Cepillos.Visible = true;
                Cera.Visible = false;
            }
            if (categoriaComboBox.SelectedIndex == 3)
            {
                Dentifricos.Visible = false;
                Enjuagues.Visible = false;
                Cepillos.Visible = false;
                Cera.Visible = true;
            }
        }


        private bool Validar_Campos()
        {
            bool ok = true;

            if (nombreTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nombreTextBox, "Ingresa un dato");
            }

            if (string.IsNullOrEmpty(categoriaComboBox.Text))
            {
                ok = false;
                errorProvider1.SetError(categoriaComboBox, "Ingresa un dato");
            }

            if (string.IsNullOrEmpty(marcaComboBox.Text))
            {
                ok = false;
                errorProvider1.SetError(marcaComboBox, "Ingresa un dato");
            }

            if (modeloTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(modeloTextBox, "Ingresa un dato");
            }

            if (precioTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(precioTextBox, "Ingresa un dato numérico");
            }

            if (precaucionesTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(precaucionesTextBox, "Ingresa un dato numérico");
            }
            return ok;
        }

        private void BorrarError()
        {
            errorProvider1.SetError(nombreTextBox, "");
            errorProvider1.SetError(categoriaComboBox, "");
            errorProvider1.SetError(marcaComboBox, "");
            errorProvider1.SetError(modeloTextBox, "");
            errorProvider1.SetError(precioTextBox, "");
            errorProvider1.SetError(precaucionesTextBox, "");
        }

        private void modo_lectura()
        {
            //imagen
            fotos.Enabled = false;

            //documentacion
            documentacion.Enabled = false;

            //caracteristicas_generales
            caracteristicas_generales.Enabled = false;

            //Caracteristicas espeficicas
            Dentifricos.Enabled = false;
            Enjuagues.Enabled = false;
            Cepillos.Enabled = false;
            Cera.Enabled = false;

            //propiedades del envase
            propiedades_envase.Enabled = false;

            //buscar
            buscar.Enabled = true;
        }

        private void modo_escritura()
        {
            //imagen
            fotos.Enabled = true;

            //documentacion
            documentacion.Enabled = true;

            //caracteristicas_generales
            caracteristicas_generales.Enabled = true;

            //Caracteristicas espeficicas
            Dentifricos.Enabled = true;
            Enjuagues.Enabled = true;
            Cepillos.Enabled = true;
            Cera.Enabled = true;

            //propiedades del envase
            propiedades_envase.Enabled = true;
        }

        private void Tooltips()
        {
            toolTip1.SetToolTip(imprimir, "Pulsa para IMPRIMIR los Productos");
            toolTip1.SetToolTip(informes, "Pulsa para IR al Informe");
            toolTip1.SetToolTip(volver, "Pulsa para VOLVER a la Ventana anterior");
            toolTip1.SetToolTip(lupa, "Pulsa para BUSCAR un Producto");
            toolTip1.SetToolTip(primero, "Pulsa para ir al PRIMER Producto");
            toolTip1.SetToolTip(anterior, "Pulsa para ir al ANTERIOR Producto");
            toolTip1.SetToolTip(siguiente, "Pulsa para ir al SIGUIENTE Producto");
            toolTip1.SetToolTip(ultimo, "Pulsa para ir al ÚLTIMO Producto");
            toolTip1.SetToolTip(anadir, "Pulsa para AÑADIR un nuevo Producto");
            toolTip1.SetToolTip(eliminar, "Pulsa para ELIMINAR un Producto");
            toolTip1.SetToolTip(editar, "Pulsa para EDITAR un Producto");
            toolTip1.SetToolTip(aceptar, "Pulsa para ACEPTAR");
            toolTip1.SetToolTip(cancelar, "Pulsa para CANCELAR");
            toolTip1.InitialDelay = 1000;
        }
    }

}
