using Microsoft.Reporting.WinForms;
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
    public partial class informe_empleados: Form
    {
        private empleados empleados;
        public informe_empleados(empleados empleados)
        {
            InitializeComponent();
            this.empleados=empleados;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void informe_pacientes_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.empleadosTableAdapter.Fill(this.odonticDataSet.Empleados);
            this.reportViewer1.LocalReport.ReportPath = "../../informe_empleados.rdlc";
            ReportDataSource dataSource = new ReportDataSource("DataSet1", this.odonticDataSet.Tables["Empleados"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }

        private void informe_empleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            empleados.Show();
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
                    this.empleadosTableAdapter.FillByNombre(this.odonticDataSet.Empleados, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                } else if(filtrarComboBox.SelectedIndex == 1)
                {
                    this.empleadosTableAdapter.FillByGenero(this.odonticDataSet.Empleados, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                }else if (filtrarComboBox.SelectedIndex == 2)
                {
                    this.empleadosTableAdapter.FillByProvincia(this.odonticDataSet.Empleados, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                }
            }
        }

        private void deshacer_Click(object sender, EventArgs e)
        {
            this.empleadosTableAdapter.Fill(this.odonticDataSet.Empleados);
            reportViewer1.RefreshReport();
            filtrarTextBox.Clear();
        }


        private void Tooltips()
        {
            toolTip1.SetToolTip(filtrarComboBox, "Selecciona una Característica para Filtrar los Empleados");
            toolTip1.SetToolTip(lupa, "Pulsa para Filtrar los Empleados");
            toolTip1.SetToolTip(deshacer, "Pulsa para Deshacer el Filtro");
            toolTip1.InitialDelay = 1000;
        }
    }
}
