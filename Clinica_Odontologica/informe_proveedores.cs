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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Clinica_Odontologica
{
    public partial class informe_proveedores: Form
    {
        private proveedores proveedores;
        public informe_proveedores(proveedores proveedores)
        {
            InitializeComponent();
            this.proveedores = proveedores;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void informe_proveedores_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.proveedoresTableAdapter.Fill(this.odonticDataSet.Proveedores);
            this.reportViewer1.LocalReport.ReportPath = "../../informe_proveedores.rdlc";
            ReportDataSource dataSource = new ReportDataSource("DataSet1", this.odonticDataSet.Tables["Proveedores"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }

        private void informe_proveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            proveedores.Show();
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
                    this.proveedoresTableAdapter.FillByNombre(this.odonticDataSet.Proveedores, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                }
                else if (filtrarComboBox.SelectedIndex == 1)
                {
                    this.proveedoresTableAdapter.FillByProvincia(this.odonticDataSet.Proveedores, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                }
                else if (filtrarComboBox.SelectedIndex == 2)
                {
                    this.proveedoresTableAdapter.FillByPais(this.odonticDataSet.Proveedores, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                }
            }
        }

        private void deshacer_Click(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.Fill(this.odonticDataSet.Proveedores);
            reportViewer1.RefreshReport();
            filtrarTextBox.Clear();
        }

        private void Tooltips()
        {
            toolTip1.SetToolTip(filtrarComboBox, "Selecciona una Característica para Filtrar los Proveedores");
            toolTip1.SetToolTip(lupa, "Pulsa para Filtrar los Proveedores");
            toolTip1.SetToolTip(deshacer, "Pulsa para Deshacer el Filtro");
            toolTip1.InitialDelay = 1000;
        }
    }
}
