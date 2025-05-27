using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinica_Odontologica
{
    public partial class tratamientos: Form
    {
        private menu menu; 
        public tratamientos(menu menu)
        {
            InitializeComponent();
            this.menu = menu;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void tratamientos_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.tratamientosTableAdapter.Fill(this.odonticDataSet.Tratamientos);
            this.empleadosTableAdapter.Fill(this.odonticDataSet.Empleados);
            this.pacientesTableAdapter.Fill(this.odonticDataSet.Pacientes);
            this.tipo_TratamientoTableAdapter.Fill(this.odonticDataSet.Tipo_Tratamiento);
            this.tratamiento_DetalleTableAdapter.Fill(this.odonticDataSet.Tratamiento_Detalle);

            modo_lectura();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
            this.Dispose();
        }

        private void tratamientos_FormClosing(object sender, FormClosingEventArgs e)
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

        private void nombre_pacienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdonticDataSet.PacientesRow fila_paciente;
            if (nombre_pacienteComboBox.SelectedIndex != -1)
            {
                fila_paciente = odonticDataSet.Pacientes[nombre_pacienteComboBox.SelectedIndex];
                iD_PacienteTextBox.Text = fila_paciente.Id.ToString();
                dNITextBox.Text = fila_paciente.DNI.ToString();
                telefonoTextBox.Text = fila_paciente.Telefono.ToString();
                emailTextBox.Text = fila_paciente.Email;
            }
        }

        //TRATAMIENTO
        private void primero_Click(object sender, EventArgs e)
        {
            tratamientosBindingSource.MoveFirst();
        }

        private void anterior_Click(object sender, EventArgs e)
        {
            tratamientosBindingSource.MovePrevious();
        }

        private void siguiente_Click(object sender, EventArgs e)
        {
            tratamientosBindingSource.MoveNext();
        }

        private void ultimo_Click(object sender, EventArgs e)
        {
            tratamientosBindingSource.MoveLast();   
        }

        private void anadir_Click(object sender, EventArgs e)
        {
            modo_escritura_tratamientos();
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
            tratamientosBindingSource.AddNew();
            fecha_InicioDateTimePicker.Value = DateTime.Now;
            fecha_FINDateTimePicker.Value = DateTime.Now;
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tratamiento_DetalleDataGridView.Rows.Count >= 1)
                {
                    MessageBox.Show("No se puede eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (MessageBox.Show("¿Está seguro de que desea borrar la compra con el número " + id_tratamiento.Text + "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        tratamientosBindingSource.RemoveCurrent();
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
            modo_escritura_tratamientos();
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

                    tratamientosBindingSource.EndEdit();
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
            tratamientosBindingSource.CancelEdit();
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
            Properties.Settings.Default.id_tratamientos = id_tratamiento.Text;
            informe_tratamientos informe_tratamientos = new informe_tratamientos(this);
            this.Hide();
            informe_tratamientos.Show();
        }

        private void lupa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(buscarTextBox.Text))
            {
                MessageBox.Show("Por favor, introduce un valor en el campo de búsqueda.");
                return;
            }

            String busca = buscarComboBox.SelectedItem.ToString();
            if (busca.Equals("Número de Tratamiento"))
            {

                if (tratamientosBindingSource.Find("Id", buscarTextBox.Text) == -1)
                {
                    MessageBox.Show("No se ha encontrado ningún producto con Id:" + id_tratamiento.Text);
                }
                else
                {
                    tratamientosBindingSource.Position = tratamientosBindingSource.Find("ID", buscarTextBox.Text);
                }
            }
        }

        //LINEAS DEL TRATAMIENTO
        private void primero2_Click(object sender, EventArgs e)
        {
            tratamiento_DetalleBindingSource.MoveFirst();
        }

        private void anterior2_Click(object sender, EventArgs e)
        {
            tratamiento_DetalleBindingSource.MovePrevious();
        }

        private void siguiente2_Click(object sender, EventArgs e)
        {
            tratamiento_DetalleBindingSource.MoveNext();
        }

        private void ultimo2_Click(object sender, EventArgs e)
        {
            tratamiento_DetalleBindingSource.MoveLast();
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
            tratamiento_DetalleBindingSource.AddNew();
            fecha_DateTimePicker.Value = DateTime.Now;
        }

        private void eliminar2_Click(object sender, EventArgs e)
        {
            try
            {
                tratamiento_DetalleBindingSource.RemoveCurrent();
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
                    foreach (DataGridViewRow fila in tratamiento_DetalleDataGridView.Rows)
                    {
                        if (fila.IsNewRow || fila == tratamiento_DetalleDataGridView.CurrentRow)
                            continue;

                        if (fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == id_TratamientoTextBox.Text.ToString())
                        {
                            MessageBox.Show("El ID del producto ya existe en la lista. Introduce otro producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    tratamiento_DetalleBindingSource.EndEdit();
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
            tratamiento_DetalleBindingSource.CancelEdit();
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
            tratamiento_DetalleBindingSource.EndEdit();
            tratamientosBindingSource.EndEdit();
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

        private void nombre_tratamientoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OdonticDataSet.TratamientosRow fila_tratamiento;
            if (nombre_tratamientoComboBox.SelectedIndex != -1)
            {
                fila_tratamiento = odonticDataSet.Tratamientos[nombre_tratamientoComboBox.SelectedIndex];
                id_TratamientoTextBox.Text = fila_tratamiento.Id.ToString();
            }
        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void sesionesTextBox_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void CalcularTotal()
        {
            if (int.TryParse(sesionesTextBox.Text, out int valorTextBox1) && int.TryParse(precioTextBox.Text, out int valorTextBox2))
            {

                int total = valorTextBox1 * valorTextBox2;

                totalTextBox.Text = total.ToString();

            }
            else
            {
                totalTextBox.Text = "Error";
            }
        }

        private void tratamiento_DetalleDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            calcularTotal();
        }


        private void calcularTotal()
        {
            decimal totalSum = 0;

            foreach (DataGridViewRow row in tratamiento_DetalleDataGridView.Rows)
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
            foreach (DataGridViewRow row in tratamiento_DetalleDataGridView.Rows)
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

            //TRATAMIENTOS
            id_tratamiento.Enabled = false;
            iD_PacienteTextBox.Enabled = false;
            nombre_pacienteComboBox.Enabled = false;
            dNITextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            metodo_pagoComboBox.Enabled = false;
            descuentosTextBox.Enabled = false;
            importeTextBox.Enabled = false;
            fecha_InicioDateTimePicker.Enabled = false;
            fecha_FINDateTimePicker.Enabled = false;
            aceptar.Visible = false;
            cancelar.Visible = false;

            //LISTA DEL TRATAMIENTO
            aceptar2.Visible = false;
            cancelar2.Visible = false;
            guardar.Visible = false;
            id_TratamientoTextBox.Enabled = false;
            nombre_tratamientoComboBox.Enabled = false;
            sesionesTextBox.Enabled = false;
            precioTextBox.Enabled = false;
            totalTextBox.Enabled = false;
            empleadoComboBox.Enabled = false;
            zonaComboBox.Enabled = false;
            fecha_DateTimePicker.Enabled = false;
            horaTextBox.Enabled = false;
            tratamiento_DetalleDataGridView.Enabled = false;
        }

        private void modo_escritura_tratamientos()
        {
            // TRATAMIENTOS
            id_tratamiento.Enabled = true;
            iD_PacienteTextBox.Enabled = true;
            nombre_pacienteComboBox.Enabled = true;
            dNITextBox.Enabled = true;
            telefonoTextBox.Enabled = true;
            emailTextBox.Enabled = true;
            metodo_pagoComboBox.Enabled = true;
            descuentosTextBox.Enabled = true;
            importeTextBox.Enabled = false;  // No editable en esta etapa
            fecha_InicioDateTimePicker.Enabled = true;
            fecha_FINDateTimePicker.Enabled = true;

            //LISTA DEL TRATAMIENTO
            primero2.Enabled = false;
            anterior2.Enabled = false;
            siguiente2.Enabled = false;
            ultimo2.Enabled = false;
            anadir2.Enabled = false;
            eliminar2.Enabled = false;
            editar2.Enabled = false;

            id_TratamientoTextBox.Enabled = false;
            nombre_tratamientoComboBox.Enabled = false;
            sesionesTextBox.Enabled = false;
            precioTextBox.Enabled = false;
            totalTextBox.Enabled = false;
            empleadoComboBox.Enabled = false;
            zonaComboBox.Enabled = false;
            fecha_DateTimePicker.Enabled = false;
            horaTextBox.Enabled = false;
            tratamiento_DetalleDataGridView.Enabled = false;

            aceptar2.Enabled = false;
            cancelar2.Enabled = false;
            guardar.Enabled = false;

        }
        private void modo_escritura_detalle()
        {
            // TRATAMIENTOS
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

            id_tratamiento.Enabled = false;
            iD_PacienteTextBox.Enabled = false;
            nombre_pacienteComboBox.Enabled = false;
            dNITextBox.Enabled = false;
            telefonoTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            metodo_pagoComboBox.Enabled = false;
            descuentosTextBox.Enabled = false;
            importeTextBox.Enabled = false;
            fecha_InicioDateTimePicker.Enabled = false;
            fecha_FINDateTimePicker.Enabled = false;

            //LISTA DEL TRATAMIENTO
            primero2.Enabled = true;
            anterior2.Enabled = true;
            siguiente2.Enabled = true;
            ultimo2.Enabled = true;
            anadir2.Enabled = true;
            eliminar2.Enabled = true;
            editar2.Enabled = true;

            id_TratamientoTextBox.Enabled = true;
            nombre_tratamientoComboBox.Enabled = true;
            sesionesTextBox.Enabled = true;
            precioTextBox.Enabled = true;
            totalTextBox.Enabled = true;
            empleadoComboBox.Enabled = true;
            zonaComboBox.Enabled = true;
            fecha_DateTimePicker.Enabled = true;
            horaTextBox.Enabled = true;
            tratamiento_DetalleDataGridView.Enabled = true;

        }
        private void habilitar_control_C_D()
        {
            //LISTA DEL TRATAMIENTO
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
            //LISTA DEL TRATAMIENTO
            id_TratamientoTextBox.Enabled = false;
            nombre_tratamientoComboBox.Enabled = false;
            sesionesTextBox.Enabled = false;
            precioTextBox.Enabled = false;
            totalTextBox.Enabled = false;
            empleadoComboBox.Enabled = false;
            zonaComboBox.Enabled = false;
            fecha_DateTimePicker.Enabled = false;
            horaTextBox.Enabled = false;
            tratamiento_DetalleDataGridView.Enabled = false;
            guardar.Enabled = true;
            buscarComboBox.Enabled = true;
            buscarTextBox.Enabled = true;
            lupa.Enabled = true;
        }


        //TRATAMIENTOS
        private bool Validar_Campos()
        {
            bool ok = true;

            if (iD_PacienteTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(iD_PacienteTextBox, "Ingresa un dato");
            }

            if (string.IsNullOrEmpty(nombre_pacienteComboBox.Text))
            {
                ok = false;
                errorProvider1.SetError(nombre_pacienteComboBox, "Ingresa un dato");

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

            return ok;
        }

        private void BorrarError()
        {
            errorProvider1.SetError(iD_PacienteTextBox, "");
            errorProvider1.SetError(nombre_pacienteComboBox, "");
            errorProvider1.SetError(dNITextBox, "");
            errorProvider1.SetError(metodo_pagoComboBox, "");
        }

        //LISTA DEL TRATAMIENTO
        private bool Validar_Campos_D()
        {
            bool ok = true;
            if (string.IsNullOrEmpty(nombre_tratamientoComboBox.Text))
            {
                ok = false;
                errorProvider1.SetError(nombre_tratamientoComboBox, "Ingresa un dato");
            }

            if (id_TratamientoTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(id_TratamientoTextBox, "Ingresa un dato");
            }

            if (precioTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(precioTextBox, "Ingresa un dato");
            }

            if (sesionesTextBox.Text == "")
            {
                ok = false;
                errorProvider1.SetError(sesionesTextBox, "Ingresa un dato");
            }
            return ok;
        }

        private void BorrarError_D()
        {
            errorProvider1.SetError(nombre_tratamientoComboBox, "");
            errorProvider1.SetError(id_TratamientoTextBox, "");
            errorProvider1.SetError(precioTextBox, "");
            errorProvider1.SetError(sesionesTextBox, "");
        }

        private void Tooltips()
        {
            toolTip1.SetToolTip(volver, "Pulsa para VOLVER a la página anterior");
            toolTip1.SetToolTip(lupa, "Pulsa para BUSCAR un Tratamiento");
            toolTip1.SetToolTip(primero, "Pulsa para ir al PRIMER Tratamiento ");
            toolTip1.SetToolTip(anterior, "Pulsa para ir al ANTERIOR Tratamiento");
            toolTip1.SetToolTip(siguiente, "Pulsa para ir al SIGUIENTE Tratamiento");
            toolTip1.SetToolTip(ultimo, "Pulsa para ir al ÚLTIMO Tratamiento ");
            toolTip1.SetToolTip(anadir, "Pulsa para AÑADIR un nuevo Tratamiento");
            toolTip1.SetToolTip(eliminar, "Pulsa para ELIMINAR un Tratamiento");
            toolTip1.SetToolTip(editar, "Pulsa para EDITAR un Tratamiento");
            toolTip1.SetToolTip(aceptar, "Pulsa para ACEPTAR");
            toolTip1.SetToolTip(cancelar, "Pulsa para CANCELAR");
            toolTip1.SetToolTip(informes, "Pulsa para IR al Informe");
            toolTip1.SetToolTip(primero2, "Pulsa para ir al PRIMER Tratamiento ");
            toolTip1.SetToolTip(anterior2, "Pulsa para ir al ANTERIOR Tratamiento");
            toolTip1.SetToolTip(siguiente2, "Pulsa para ir al SIGUIENTE Tratamiento");
            toolTip1.SetToolTip(ultimo2, "Pulsa para ir al ÚLTIMO Tratamiento");
            toolTip1.SetToolTip(anadir2, "Pulsa para AÑADIR un nuevo Tratamiento");
            toolTip1.SetToolTip(eliminar2, "Pulsa para ELIMINAR un Tratamiento");
            toolTip1.SetToolTip(editar2, "Pulsa para EDITAR un Tratamiento");
            toolTip1.SetToolTip(aceptar2, "Pulsa para ACEPTAR");
            toolTip1.SetToolTip(cancelar2, "Pulsa para CANCELAR");
            toolTip1.SetToolTip(guardar, "Pulsa para GUARDAR todo");
            toolTip1.InitialDelay = 1000;
        }

        private void nombre_pacienteComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombre_pacienteComboBox.Text))
            {
                errorProvider1.SetError(nombre_pacienteComboBox, "");
            }
        }

        private void iD_PacienteTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(iD_PacienteTextBox.Text))
            {
                errorProvider1.SetError(iD_PacienteTextBox, "");
            }
        }

        private void dNITextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(dNITextBox.Text))
            {
                errorProvider1.SetError(dNITextBox, "");
            }
        }

        private void metodo_pagoComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(metodo_pagoComboBox.Text))
            {
                errorProvider1.SetError(metodo_pagoComboBox, "");
            }
        }

        private void nombre_tratamientoComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nombre_tratamientoComboBox.Text))
            {
                errorProvider1.SetError(nombre_tratamientoComboBox, "");
            }
        }

        private void id_TratamientoTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(id_TratamientoTextBox.Text))
            {
                errorProvider1.SetError(id_TratamientoTextBox, "");
            }
        }

        private void sesionesTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(sesionesTextBox.Text))
            {
                errorProvider1.SetError(sesionesTextBox, "");
            }
        }

        private void precioTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(precioTextBox.Text))
            {
                errorProvider1.SetError(precioTextBox, "");
            }
        }

      
    }
}
