using Microsoft.Reporting.WinForms;
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
    public partial class informe_productos: Form
    {
        private productos productos;
        public informe_productos(productos productos)
        {
            InitializeComponent();
            this.productos = productos;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void informe_productos_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.productosTableAdapter.Fill(this.odonticDataSet.Productos);
            this.reportViewer1.LocalReport.ReportPath = "../../informe_productos.rdlc";
            ReportDataSource dataSource = new ReportDataSource("DataSet1", this.odonticDataSet.Tables["Productos"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();

        }

        private void informe_productos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            productos.Show();
            this.Dispose();
        }

        private void lupa_Click(object sender, EventArgs e)
        {
            if (filtrarTextBox.Text.Equals(""))
            {
                MessageBox.Show("Introduce un dato.");
            }
            else
            {
                if (filtrarComboBox.SelectedIndex == 0)
                {
                    this.productosTableAdapter.FillByCategoria(this.odonticDataSet.Productos, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                }
                else if (filtrarComboBox.SelectedIndex == 1)
                {
                    this.productosTableAdapter.FillByMarca(this.odonticDataSet.Productos, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                }
                else if (filtrarComboBox.SelectedIndex == 2)
                {
                    this.productosTableAdapter.FillByNombre(this.odonticDataSet.Productos, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                }
            }
        }

        private void deshacer_Click(object sender, EventArgs e)
        {
            this.productosTableAdapter.Fill(this.odonticDataSet.Productos);
            reportViewer1.RefreshReport();
            filtrarTextBox.Clear();
        }

        private void Tooltips()
        {
            toolTip1.SetToolTip(filtrarComboBox, "Selecciona una Característica para Filtrar los Productos");
            toolTip1.SetToolTip(lupa, "Pulsa para Filtrar los Productos");
            toolTip1.SetToolTip(deshacer, "Pulsa para Deshacer el Filtro");
            toolTip1.InitialDelay = 1000;
        }
    }
}
