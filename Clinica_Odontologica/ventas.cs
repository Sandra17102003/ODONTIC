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
    public partial class ventas: Form
    {
        private menu menu;

        public ventas(menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }
        public ventas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }
        private void ventas_Load(object sender, EventArgs e)
        {

            Tooltips();
            this.ventasTableAdapter.Fill(this.odonticDataSet.Ventas);
            this.pacientesTableAdapter.Fill(this.odonticDataSet.Pacientes);
            this.productosTableAdapter.Fill(this.odonticDataSet.Productos);
            this.venta_DetalleTableAdapter.Fill(this.odonticDataSet.Venta_Detalle);
            modo_lectura();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
            this.Dispose();
        }

        private void ventas_FormClosing(object sender, FormClosingEventArgs e)
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

        private void nombre_PacienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdonticDataSet.PacientesRow fila_paciente;
            if (nombre_PacienteComboBox.SelectedIndex != -1)
            {
                fila_paciente = odonticDataSet.Pacientes[nombre_PacienteComboBox.SelectedIndex];
                iD_PacienteTextBox.Text = fila_paciente.Id.ToString();
                dNITextBox.Text = fila_paciente.DNI.ToString();
                telefonoTextBox.Text = fila_paciente.Telefono.ToString();
                emailTextBox.Text = fila_paciente.Email;
            }
        }

        //VENTA
        private void primero_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveFirst();
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MovePrevious();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveNext();
        }

        private void ultimo_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveLast();
        }

        private void anadir_Click(object sender, EventArgs e)
        {
            modo_escritura_ventas();
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
            ventasBindingSource.AddNew();
            fecha_PedidoDateTimePicker.Value = DateTime.Now;
            fecha_EntregaDateTimePicker.Value = DateTime.Now;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (venta_DetalleDataGridView.Rows.Count >= 1)
                {
                    MessageBox.Show("No se puede eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro de que desea borrar la compra con el número " + idTextBox.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        ventasBindingSource.RemoveCurrent();
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
            modo_escritura_ventas();
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

                    ventasBindingSource.EndEdit();
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
            ventasBindingSource.CancelEdit();
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
            Properties.Settings.Default.id_ventas = idTextBox.Text;
            informe_ventas informe_ventas = new informe_ventas(this);
            this.Hide();
            informe_ventas.Show();
        }

        private void lupa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(buscarTextBox.Text))
            {
                MessageBox.Show("Por favor, introduce un valor en el campo de búsqueda.");
                return;
            }

            String busca = buscarComboBox.SelectedItem.ToString();
            if (busca.Equals("Número de Venta"))
            {

                if (ventasBindingSource.Find("Id", buscarTextBox.Text) == -1)
                {
                    MessageBox.Show("No se ha encontrado ningún producto con Id:" + idTextBox.Text);
                }
                else
                {
                    ventasBindingSource.Position = ventasBindingSource.Find("ID", buscarTextBox.Text);
                }

            }
        }
        //LINEAS DE LA VENTA
        private void primero2_Click(object sender, EventArgs e)
        {
            venta_DetalleBindingSource.MoveFirst();
        }

        private void anterior2_Click(object sender, EventArgs e)
        {
            venta_DetalleBindingSource.MovePrevious();
        }

        private void siguiente2_Click(object sender, EventArgs e)
        {
            venta_DetalleBindingSource.MoveNext();
        }

        private void ultimo2_Click(object sender, EventArgs e)
        {
            venta_DetalleBindingSource.MoveLast();  
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
            venta_DetalleBindingSource.AddNew();
        }

        private void eliminar2_Click(object sender, EventArgs e)
        {

            try
            {
                venta_DetalleBindingSource.RemoveCurrent();
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
                    foreach (DataGridViewRow fila in venta_DetalleDataGridView.Rows)
                    {
                        if (fila.IsNewRow || fila == venta_DetalleDataGridView.CurrentRow)
                            continue;

                        if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == iD_ProductoTextBox.Text.ToString())
                        {
                            MessageBox.Show("El ID del producto ya existe en la lista. Introduce otro producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    venta_DetalleBindingSource.EndEdit();
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
            venta_DetalleBindingSource.CancelEdit();
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
            ventasBindingSource.EndEdit();
            venta_DetalleBindingSource.EndEdit();
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

        private void venta_DetalleDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            venta_DetalleBindingSource.EndEdit();
            calcularTotal();
        }

        private void calcularTotal()
        {
            decimal totalSum = 0;
            foreach (DataGridViewRow row in venta_DetalleDataGridView.Rows)
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
            foreach (DataGridViewRow row in venta_DetalleDataGridView.Rows)
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
            iD_PacienteTextBox.Enabled = false;
            nombre_PacienteComboBox.Enabled = false;
            dNITextBox.Enabled = false;
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
            venta_DetalleDataGridView.Enabled = false;
        }

        private void modo_escritura_ventas()
        {
            // COMPRAS
            idTextBox.Enabled = true;
            iD_PacienteTextBox.Enabled = true;
            nombre_PacienteComboBox.Enabled = true;
            dNITextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            metodo_pagoComboBox.Enabled = true;
            descuentosTextBox.Enabled = true;
            importeTextBox.Enabled = false;  // No editable en esta etapa
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
            venta_DetalleDataGridView.Enabled = false;
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
            iD_PacienteTextBox.Enabled = false;
            nombre_PacienteComboBox.Enabled = false;
            dNITextBox.Enabled = false;
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
            venta_DetalleDataGridView.Enabled = true;

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
            venta_DetalleDataGridView.Enabled = false;
            guardar.Enabled = true;
            buscarComboBox.Enabled = true;
            buscarTextBox.Enabled = true;
            lupa.Enabled = true;
        }

        //VENTAS
        private bool Validar_Campos()
        {
            bool ok = true;

            if (iD_PacienteTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(iD_PacienteTextBox, "Ingresa un dato");
            }

            if (string.IsNullOrEmpty(nombre_PacienteComboBox.Text))
            {
                ok = false;
                errorProvider1.SetError(nombre_PacienteComboBox, "Ingresa un dato");

            }

            if (dNITextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(dNITextBox, "Ingresa un dato");
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
            errorProvider1.SetError(iD_PacienteTextBox, "");
            errorProvider1.SetError(nombre_PacienteComboBox, "");
            errorProvider1.SetError(dNITextBox, "");
            errorProvider1.SetError(metodo_pagoComboBox, "");
            errorProvider1.SetError(fecha_PedidoDateTimePicker, "");
            errorProvider1.SetError(fecha_EntregaDateTimePicker, "");
        }

        //VENTAS-DETALLE
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
            toolTip1.SetToolTip(lupa, "Pulsa para BUSCAR una Venta");
            toolTip1.SetToolTip(primero, "Pulsa para ir a la PRIMERA Venta ");
            toolTip1.SetToolTip(anterior, "Pulsa para ir a la ANTERIOR Venta");
            toolTip1.SetToolTip(siguiente, "Pulsa para ir a la SIGUIENTE Venta");
            toolTip1.SetToolTip(ultimo, "Pulsa para ir a la ÚLTIMA Venta ");
            toolTip1.SetToolTip(anadir, "Pulsa para AÑADIR una nueva Venta");
            toolTip1.SetToolTip(eliminar, "Pulsa para ELIMINAR una Venta");
            toolTip1.SetToolTip(editar, "Pulsa para EDITAR una Venta");
            toolTip1.SetToolTip(aceptar, "Pulsa para ACEPTAR");
            toolTip1.SetToolTip(cancelar, "Pulsa para CANCELAR");
            toolTip1.SetToolTip(informes, "Pulsa para IR al Informe");
            toolTip1.SetToolTip(primero2, "Pulsa para ir a la PRIMERA Venta ");
            toolTip1.SetToolTip(anterior2, "Pulsa para ir a la ANTERIOR Venta");
            toolTip1.SetToolTip(siguiente2, "Pulsa para ir a la SIGUIENTE Venta");
            toolTip1.SetToolTip(ultimo2, "Pulsa para ir a la ÚLTIMA Venta");
            toolTip1.SetToolTip(anadir2, "Pulsa para AÑADIR una nueva Venta");
            toolTip1.SetToolTip(eliminar2, "Pulsa para ELIMINAR una Venta");
            toolTip1.SetToolTip(editar2, "Pulsa para EDITAR una Venta");
            toolTip1.SetToolTip(aceptar2, "Pulsa para ACEPTAR");
            toolTip1.SetToolTip(cancelar2, "Pulsa para CANCELAR");
            toolTip1.SetToolTip(guardar, "Pulsa para GUARDAR todo");
            toolTip1.InitialDelay = 1000;
        }

        private void nombre_PacienteComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombre_PacienteComboBox.Text))
            {
                errorProvider1.SetError(nombre_PacienteComboBox, "");
            }
        }

        private void dNITextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dNITextBox.Text))
            {
                errorProvider1.SetError(dNITextBox, "");
            }
        }

        private void iD_PacienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(iD_PacienteTextBox.Text))
            {
                errorProvider1.SetError(iD_PacienteTextBox, "");
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
