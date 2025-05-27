using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Odontologica
{
    public partial class compras: Form
    {
        private menu menu;
        public compras(menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }
        private void compras_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.comprasTableAdapter.Fill(this.odonticDataSet.Compras);
            this.productosTableAdapter.Fill(this.odonticDataSet.Productos);
            this.proveedoresTableAdapter.Fill(this.odonticDataSet.Proveedores);
            this.compra_DetalleTableAdapter.Fill(this.odonticDataSet.Compra_Detalle);
            modo_lectura();
        }
        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
            this.Dispose();
        }
        private void compras_FormClosing(object sender, FormClosingEventArgs e)
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

        private void nombre_ProveedorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdonticDataSet.ProveedoresRow fila_proveedor;
            if (nombre_ProveedorComboBox.SelectedIndex != -1)
            {
                fila_proveedor = odonticDataSet.Proveedores[nombre_ProveedorComboBox.SelectedIndex];
                iD_ProveedorTextBox.Text = fila_proveedor.Id.ToString();
                nIFTextBox.Text = fila_proveedor.NIF.ToString();

                if (!fila_proveedor.IsTelefonoNull())
                    telefonoTextBox.Text = fila_proveedor.Telefono.ToString();
                else
                    telefonoTextBox.Text = "";
                if (!fila_proveedor.IsEmailNull())
                    emailTextBox.Text = fila_proveedor.Email;
                else
                    emailTextBox.Text = "";
            }
        }

        //COMPRAS
        private void primero_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveFirst();
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MovePrevious();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveNext();
        }

        private void ultimo_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveLast();
        }

        private void anadir_Click(object sender, EventArgs e)
        {
            modo_escritura_compras();
            primero.Enabled = false;
            anterior.Enabled = false;
            siguiente.Enabled = false;
            ultimo.Enabled = false;
            anadir.Enabled = false;
            eliminar.Enabled = false;
            editar.Enabled = false;
            informes.Enabled = false;
            lupa.Enabled = false;
            aceptar.Visible = true;
            cancelar.Visible = true;
            comprasBindingSource.AddNew();
            fecha_PedidoDateTimePicker.Value = DateTime.Now;
            fecha_EntregaDateTimePicker.Value = DateTime.Now;

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (compra_DetalleDataGridView.Rows.Count >= 1)
                {
                    MessageBox.Show("No se puede eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro de que desea borrar la compra con el número " + idTextBox.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        comprasBindingSource.RemoveCurrent();
                        tableAdapterManager.UpdateAll(odonticDataSet);
                        guardar.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editar_Click(object sender, EventArgs e)
        {
            modo_escritura_compras();
            BorrarError();
            primero.Enabled = false;
            anterior.Enabled = false;
            siguiente.Enabled = false;
            ultimo.Enabled = false;
            anadir.Enabled = false;
            eliminar.Enabled = false;
            editar.Enabled = false;
            informes.Enabled = false;
            lupa.Enabled = false;
            aceptar.Visible = true;
            cancelar.Visible = true;
            aceptar.Enabled = true;
            cancelar.Enabled = true;
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            BorrarError();
            if (Validar_Campos())
            {
                try
                {
                    if (string.IsNullOrEmpty(descuentosTextBox.Text))
                    {
                        descuentosTextBox.Text = "0";
                    }

                    comprasBindingSource.EndEdit();
                    aceptar.Visible = false;
                    cancelar.Visible = false;
                    habilitar_control_C_D();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            comprasBindingSource.CancelEdit();
            BorrarError();
            modo_lectura();
            primero.Enabled = true;
            anterior.Enabled = true;
            siguiente.Enabled = true;
            ultimo.Enabled = true;
            anadir.Enabled = true;
            eliminar.Enabled = true;
            editar.Enabled = true;
            informes.Enabled = true;
            lupa.Enabled = true;
        }

        private void informes_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.id_compras = idTextBox.Text;
            informe_compras informe_compras = new informe_compras(this);
            this.Hide();
            informe_compras.Show();
        }

        private void lupa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(buscarTextBox.Text))
            {
                MessageBox.Show("Por favor, introduce un valor en el campo de búsqueda.");
                return;
            }

            String busca = buscarComboBox.SelectedItem.ToString();
            if (busca.Equals("Número de Compra"))
            {

                if (comprasBindingSource.Find("Id", buscarTextBox.Text) == -1)
                {
                    MessageBox.Show("No se ha encontrado ningún producto con Id:" + idTextBox.Text);
                }
                else
                {
                    comprasBindingSource.Position = comprasBindingSource.Find("ID", buscarTextBox.Text);
                }

            }
        }

        //LINEAS DE LA COMPRA
        private void primero2_Click(object sender, EventArgs e)
        {
            compra_DetalleBindingSource.MoveFirst();
        }

        private void anterior2_Click(object sender, EventArgs e)
        {
            compra_DetalleBindingSource.MovePrevious(); 
        }

        private void siguiente2_Click(object sender, EventArgs e)
        {
            compra_DetalleBindingSource.MoveNext();
        }

        private void ultimo2_Click(object sender, EventArgs e)
        {
            compra_DetalleBindingSource.MoveLast();
        }

        private void anadir2_Click(object sender, EventArgs e)
        {
            modo_escritura_detalle();
            primero2.Enabled = false;
            anterior2.Enabled = false;
            siguiente2.Enabled = false;
            ultimo2.Enabled = false;
            anadir2.Enabled = false;
            eliminar2.Enabled = false;
            editar2.Enabled = false;
            informes.Enabled = false;
            lupa.Enabled = false;
            aceptar2.Visible = true;
            cancelar2.Visible = true;
            aceptar2.Enabled = true;
            cancelar2.Enabled = true;
            compra_DetalleBindingSource.AddNew();

        }

        private void eliminar2_Click(object sender, EventArgs e)
        {
            try
            {
                compra_DetalleBindingSource.RemoveCurrent();
                tableAdapterManager.UpdateAll(odonticDataSet);
                guardar.Visible = true;
                guardar.Enabled = true;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el elemento actual: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editar2_Click(object sender, EventArgs e)
        {
            guardar.Visible = false;
            modo_escritura_detalle();
            BorrarError_D();
            primero2.Enabled = false;
            anterior2.Enabled = false;
            siguiente2.Enabled = false;
            ultimo2.Enabled = false;
            anadir2.Enabled = false;
            eliminar2.Enabled = false;
            editar2.Enabled = false;
            informes.Enabled = false;
            lupa.Enabled = false;
            aceptar2.Visible = true;
            cancelar2.Visible = true;
            aceptar2.Enabled = true;
            cancelar2.Enabled = true;
        }

        private void aceptar2_Click(object sender, EventArgs e)
        {
            BorrarError_D();
            if (Validar_Campos_D())
            {
                try
                {
                    foreach (DataGridViewRow fila in compra_DetalleDataGridView.Rows)
                    {
                        if (fila.IsNewRow || fila == compra_DetalleDataGridView.CurrentRow)
                            continue;

                        if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == iD_ProductoTextBox.Text.ToString())
                        {
                            MessageBox.Show("El ID del producto ya existe en la lista. Introduce otro producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    compra_DetalleBindingSource.EndEdit();
                    aceptar2.Visible = false;
                    cancelar2.Visible = false;
                    guardar.Visible = true;
                    calcularTotal();
                    deshabilitar_control_C_D();
                    primero2.Enabled = true;
                    anterior2.Enabled = true;
                    siguiente2.Enabled = true;
                    ultimo2.Enabled = true;
                    anadir2.Enabled = true;
                    eliminar2.Enabled = true;
                    editar2.Enabled = true;
                    informes.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los cambios en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelar2_Click(object sender, EventArgs e)
        {
            BorrarError_D();
            compra_DetalleBindingSource.CancelEdit();
            aceptar2.Visible = false;
            cancelar2.Visible = false;
            guardar.Visible = true;
            deshabilitar_control_C_D();
            primero2.Enabled = true;
            anterior2.Enabled = true;
            siguiente2.Enabled = true;
            ultimo2.Enabled = true;
            anadir2.Enabled = true;
            eliminar2.Enabled = true;
            editar2.Enabled = true;
            informes.Enabled = true;
            lupa.Enabled = true;
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            comprasBindingSource.EndEdit();
            compra_DetalleBindingSource.EndEdit();
            RecalcularTotal();
            tableAdapterManager.UpdateAll(odonticDataSet);
            if (string.IsNullOrEmpty(descuentosTextBox.Text))
            {
                descuentosTextBox.Text = "0";
            }
            modo_lectura();
            deshabilitar_control_C_D();
            primero2.Enabled = false;
            anterior2.Enabled = false;
            siguiente2.Enabled = false;
            ultimo2.Enabled = false;
            anadir2.Enabled = false;
            eliminar2.Enabled = false;
            editar2.Enabled = false;
            informes.Enabled = true;
            MessageBox.Show("El registro se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nombre_ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdonticDataSet.ProductosRow fila_producto;
            if (nombre_ProductoComboBox.SelectedIndex != -1)
            {
                fila_producto = odonticDataSet.Productos[nombre_ProductoComboBox.SelectedIndex];
                iD_ProductoTextBox.Text = fila_producto.Id.ToString();
                precio_UnidadTextBox.Text = fila_producto.Precio.ToString();
            }
        }

        private void precio_UnidadTextBox_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        private void cantidadTextBox_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            if (int.TryParse(precio_UnidadTextBox.Text, out int valorTextBox1) && int.TryParse(cantidadTextBox.Text, out int valorTextBox2))
            {
                int total = valorTextBox1 * valorTextBox2;
                totalTextBox.Text = total.ToString();
            }
            else
            {
                totalTextBox.Text = "Error";
            }
        }

        private void compra_DetalleDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            compra_DetalleBindingSource.EndEdit();
            calcularTotal();
        }

        private void calcularTotal()
        {
            decimal totalSum = 0;
            foreach (DataGridViewRow row in compra_DetalleDataGridView.Rows)
            {
                if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() != "")
                {
                    totalSum += Convert.ToDecimal(row.Cells[5].Value);
                }
            }
            importeTextBox.Text = totalSum.ToString();
        }

        private void RecalcularTotal()
        {
            //importe inicial
            decimal totalSum = 0;
            foreach (DataGridViewRow row in compra_DetalleDataGridView.Rows)
            {
                if (row.Cells[5].Value != null && row.Cells[5].Value.ToString() != "")
                {
                    totalSum += Convert.ToDecimal(row.Cells[5].Value);
                }
            }

            //descuento
            decimal descuentoPorcentaje = 0;
            if (!string.IsNullOrEmpty(descuentosTextBox.Text))
            {
                descuentoPorcentaje = Convert.ToDecimal(descuentosTextBox.Text);
            }

            //importe total con descuento
            decimal totalConDescuento = totalSum - (totalSum * (descuentoPorcentaje / 100));

            importeTextBox.Text = totalConDescuento.ToString();
        }

        private void modo_lectura()
        {
            primero.Enabled = true;
            anterior.Enabled = true;
            siguiente.Enabled = true;
            ultimo.Enabled = true;
            anadir.Enabled = true;
            eliminar.Enabled = true;
            editar.Enabled = true;

            // COMPRAS
            idTextBox.Enabled = false;
            iD_ProveedorTextBox.Enabled = false;
            nombre_ProveedorComboBox.Enabled = false;
            nIFTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            metodo_pagoComboBox.Enabled = false;
            descuentosTextBox.Enabled = false;
            importeTextBox.Enabled = false;
            fecha_PedidoDateTimePicker.Enabled = false;
            fecha_EntregaDateTimePicker.Enabled = false;
            aceptar.Visible = false;
            cancelar.Visible = false;

            // COMPRAS DETALLE
            aceptar2.Visible = false;
            cancelar2.Visible = false;
            guardar.Visible = false;
            iD_ProductoTextBox.Enabled = false;
            nombre_ProductoComboBox.Enabled = false;
            cantidadTextBox.Enabled = false;
            precio_UnidadTextBox.Enabled = false;
            totalTextBox.Enabled = false;
            compra_DetalleDataGridView.Enabled = false;
            aceptar2.Visible = false;
            cancelar2.Visible = false;
        }

        private void modo_escritura_compras()
        {
            // COMPRAS
            idTextBox.Enabled = true;
            iD_ProveedorTextBox.Enabled = true;
            nombre_ProveedorComboBox.Enabled = true;
            nIFTextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            metodo_pagoComboBox.Enabled = true;
            descuentosTextBox.Enabled = true;
            importeTextBox.Enabled = false;
            fecha_PedidoDateTimePicker.Enabled = true;
            fecha_EntregaDateTimePicker.Enabled = true;

            // COMPRAS DETALLE
            primero2.Enabled = false;
            anterior2.Enabled = false;
            siguiente2.Enabled = false;
            ultimo2.Enabled = false;
            anadir2.Enabled = false;
            eliminar2.Enabled = false;
            editar2.Enabled = false;

            iD_ProductoTextBox.Enabled = false;
            nombre_ProductoComboBox.Enabled = false;
            cantidadTextBox.Enabled = false;
            precio_UnidadTextBox.Enabled = false;
            totalTextBox.Enabled = false;
            compra_DetalleDataGridView.Enabled = false;

            aceptar2.Enabled = false;
            cancelar2.Enabled = false;
            guardar.Enabled = false;

        }
        private void modo_escritura_detalle()
        {
            // COMPRAS
            primero.Enabled = false;
            anterior.Enabled = false;
            siguiente.Enabled = false;
            ultimo.Enabled = false;
            anadir.Enabled = false;
            eliminar.Enabled = false;
            editar.Enabled = false;
            buscarComboBox.Enabled = false;
            buscarTextBox.Enabled = false;
            lupa.Enabled = false;

            idTextBox.Enabled = false;
            iD_ProveedorTextBox.Enabled = false;
            nombre_ProveedorComboBox.Enabled = false;
            nIFTextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            metodo_pagoComboBox.Enabled = false;
            descuentosTextBox.Enabled = false;
            importeTextBox.Enabled = false;
            fecha_PedidoDateTimePicker.Enabled = false;
            fecha_EntregaDateTimePicker.Enabled = false;

            // COMPRAS DETALLE
            primero2.Enabled = true;
            anterior2.Enabled = true;
            siguiente2.Enabled = true;
            ultimo2.Enabled = true;
            anadir2.Enabled = true;
            eliminar2.Enabled = true;
            editar2.Enabled = true;

            iD_ProductoTextBox.Enabled = true;
            nombre_ProductoComboBox.Enabled = true;
            cantidadTextBox.Enabled = true;
            precio_UnidadTextBox.Enabled = true;
            totalTextBox.Enabled = true;
            compra_DetalleDataGridView.Enabled = true;

        }
        private void habilitar_control_C_D()
        {
            // COMPRAS DETALLE
            primero2.Enabled = true;
            anterior2.Enabled = true;
            siguiente2.Enabled = true;
            ultimo2.Enabled = true;
            anadir2.Enabled = true;
            eliminar2.Enabled = true;
            editar2.Enabled = true;
            guardar.Enabled = true;
        }

        private void deshabilitar_control_C_D()
        {
            // COMPRAS DETALLE
            iD_ProductoTextBox.Enabled = false;
            nombre_ProductoComboBox.Enabled = false;
            cantidadTextBox.Enabled = false;
            precio_UnidadTextBox.Enabled = false;
            totalTextBox.Enabled = false;
            compra_DetalleDataGridView.Enabled = false;
            guardar.Enabled = true;
            buscarComboBox.Enabled = true;
            buscarTextBox.Enabled = true;
            lupa.Enabled = true;
        }


        //COMPRA
        private bool Validar_Campos()
        {
            bool ok = true;

            if (iD_ProveedorTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(iD_ProveedorTextBox, "Ingresa un dato");
            }

            if (string.IsNullOrEmpty(nombre_ProveedorComboBox.Text))
            {
                ok = false;
                errorProvider1.SetError(nombre_ProveedorComboBox, "Ingresa un dato");

            }

            if (nIFTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(nIFTextBox, "Ingresa un dato");
            }

            if (string.IsNullOrEmpty(metodo_pagoComboBox.Text))
            {
                ok = false;
                errorProvider1.SetError(metodo_pagoComboBox, "Ingresa un dato");
            }


            if (fecha_PedidoDateTimePicker.Value == DateTimePicker.MinimumDateTime || fecha_PedidoDateTimePicker.Value == DateTimePicker.MaximumDateTime)
            {
                ok = false;
                errorProvider1.SetError(fecha_PedidoDateTimePicker, "Selecciona una fecha válida");

            }

            if (fecha_EntregaDateTimePicker.Value == DateTimePicker.MinimumDateTime || fecha_EntregaDateTimePicker.Value == DateTimePicker.MaximumDateTime)
            {
                ok = false;
                errorProvider1.SetError(fecha_EntregaDateTimePicker, "Selecciona una fecha válida");
            }
            return ok;
        }

        private void BorrarError()
        {
            errorProvider1.SetError(iD_ProveedorTextBox, "");
            errorProvider1.SetError(nombre_ProveedorComboBox, "");
            errorProvider1.SetError(nIFTextBox, "");
            errorProvider1.SetError(metodo_pagoComboBox, "");
            errorProvider1.SetError(fecha_PedidoDateTimePicker, "");
            errorProvider1.SetError(fecha_EntregaDateTimePicker, "");
        }

        //COMPRA-DETALLE
        private bool Validar_Campos_D()
        {
            bool ok = true;
            if (string.IsNullOrEmpty(nombre_ProductoComboBox.Text))
            {
                ok = false;
                errorProvider1.SetError(nombre_ProductoComboBox, "Ingresa un dato");
            }

            if (iD_ProductoTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(iD_ProductoTextBox, "Ingresa un dato");
            }

            if (precio_UnidadTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(precio_UnidadTextBox, "Ingresa un dato");
            }

            if (cantidadTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(cantidadTextBox, "Ingresa un dato");
            }
            return ok;
        }

        private void BorrarError_D()
        {
            errorProvider1.SetError(nombre_ProductoComboBox, "");
            errorProvider1.SetError(iD_ProductoTextBox, "");
            errorProvider1.SetError(precio_UnidadTextBox, "");
            errorProvider1.SetError(cantidadTextBox, "");
        }

        private void Tooltips()
        {
            toolTip1.SetToolTip(volver, "Pulsa para VOLVER a la página anterior");
            toolTip1.SetToolTip(lupa, "Pulsa para BUSCAR una Compra");
            toolTip1.SetToolTip(primero, "Pulsa para ir a la PRIMERA Compra ");
            toolTip1.SetToolTip(anterior, "Pulsa para ir a la ANTERIOR Compra");
            toolTip1.SetToolTip(siguiente, "Pulsa para ir a la SIGUIENTE Compra");
            toolTip1.SetToolTip(ultimo, "Pulsa para ir a la ÚLTIMA Compra ");
            toolTip1.SetToolTip(anadir, "Pulsa para AÑADIR una nueva Compra");
            toolTip1.SetToolTip(eliminar, "Pulsa para ELIMINAR una Compra");
            toolTip1.SetToolTip(editar, "Pulsa para EDITAR una Compra");
            toolTip1.SetToolTip(aceptar, "Pulsa para ACEPTAR");
            toolTip1.SetToolTip(cancelar, "Pulsa para CANCELAR");
            toolTip1.SetToolTip(informes, "Pulsa para IR al Informe");
            toolTip1.SetToolTip(primero2, "Pulsa para ir a la PRIMERA Compra ");
            toolTip1.SetToolTip(anterior2, "Pulsa para ir a la ANTERIOR Compra");
            toolTip1.SetToolTip(siguiente2, "Pulsa para ir a la SIGUIENTE Compra");
            toolTip1.SetToolTip(ultimo2, "Pulsa para ir a la ÚLTIMA Compra");
            toolTip1.SetToolTip(anadir2, "Pulsa para AÑADIR una nueva Compra");
            toolTip1.SetToolTip(eliminar2, "Pulsa para ELIMINAR una Compra");
            toolTip1.SetToolTip(editar2, "Pulsa para EDITAR una Compra");
            toolTip1.SetToolTip(aceptar2, "Pulsa para ACEPTAR");
            toolTip1.SetToolTip(cancelar2, "Pulsa para CANCELAR");
            toolTip1.SetToolTip(guardar, "Pulsa para GUARDAR todo");
            toolTip1.InitialDelay = 1000;
        }

        private void nombre_ProveedorComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombre_ProveedorComboBox.Text))
            {
                errorProvider1.SetError(nombre_ProveedorComboBox, "");
            }
        }

        private void iD_ProveedorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(iD_ProveedorTextBox.Text))
            {
                errorProvider1.SetError(iD_ProveedorTextBox, "");
            }
        }

        private void nIFTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nIFTextBox.Text))
            {
                errorProvider1.SetError(nIFTextBox, "");
            }
        }

        private void metodo_pagoComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(metodo_pagoComboBox.Text))
            {
                errorProvider1.SetError(metodo_pagoComboBox, "");
            }
        }

        private void nombre_ProductoComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombre_ProductoComboBox.Text))
            {
                errorProvider1.SetError(nombre_ProductoComboBox, "");
            }
        }

        private void iD_ProductoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(iD_ProductoTextBox.Text))
            {
                errorProvider1.SetError(iD_ProductoTextBox, "");
            }
        }

        private void precio_UnidadTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(precio_UnidadTextBox.Text))
            {
                errorProvider1.SetError(precio_UnidadTextBox, "");
            }
        }

        private void cantidadTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cantidadTextBox.Text))
            {
                errorProvider1.SetError(cantidadTextBox, "");
            }
        }
    }
}
