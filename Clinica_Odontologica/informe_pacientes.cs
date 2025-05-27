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
    public partial class informe_pacientes: Form
    {
        private pacientes pacientes;

        public informe_pacientes(pacientes pacientes)
        {
            InitializeComponent();
            this.pacientes = pacientes;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
        }

        private void informe_pacientes_Load(object sender, EventArgs e)
        {
            Tooltips();
            this.pacientesTableAdapter.Fill(this.odonticDataSet.Pacientes);
            this.reportViewer1.LocalReport.ReportPath = "../../informe_pacientes.rdlc";
            ReportDataSource dataSource = new ReportDataSource("DataSet1", this.odonticDataSet.Tables["Pacientes"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }

        private void informe_pacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            pacientes.Show();
            this.Dispose();
        }

        private void lupa_Click(object sender, EventArgs e)
        {
            if (filtrarTextBox.Enabled && filtrarTextBox.Text.Equals(""))
            {
                MessageBox.Show("Introduce un dato.");
            }
            else
            {

                if (filtrarComboBox.SelectedIndex == 0)
                {
                    this.pacientesTableAdapter.FillByNombre(this.odonticDataSet.Pacientes, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                }
                else if (filtrarComboBox.SelectedIndex == 1)
                {
                    this.pacientesTableAdapter.FillByGenero(this.odonticDataSet.Pacientes, filtrarTextBox.Text);
                    reportViewer1.RefreshReport();
                }
                else if (filtrarComboBox.SelectedIndex == 2)
                {
    
                    this.pacientesTableAdapter.FillByInfantil(this.odonticDataSet.Pacientes);
                    reportViewer1.RefreshReport();
                }
                else if (filtrarComboBox.SelectedIndex == 3)
                {
       
                    this.pacientesTableAdapter.FillByAdulto(this.odonticDataSet.Pacientes);
                    reportViewer1.RefreshReport();
                }
                else if (filtrarComboBox.SelectedIndex == 4)
                {
               
                    this.pacientesTableAdapter.FillByActivo(this.odonticDataSet.Pacientes);
                    reportViewer1.RefreshReport();
                }
                else if (filtrarComboBox.SelectedIndex == 5)
                {
           
                    this.pacientesTableAdapter.FillByInactivo(this.odonticDataSet.Pacientes);
                    reportViewer1.RefreshReport();
                }
            }
        }
        private void filtrarComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filtrarComboBox.SelectedIndex == 2 || filtrarComboBox.SelectedIndex == 3 || filtrarComboBox.SelectedIndex == 4 || filtrarComboBox.SelectedIndex == 5)
            {
                filtrarTextBox.Enabled = false;
            }
            else
            {
                filtrarTextBox.Enabled = true;
            }
        }

        private void deshacer_Click(object sender, EventArgs e)
        {
            this.pacientesTableAdapter.Fill(this.odonticDataSet.Pacientes);
            reportViewer1.RefreshReport();
            filtrarTextBox.Clear();
        }
        private void Tooltips()
        {
            toolTip1.SetToolTip(filtrarComboBox, "Selecciona una Característica para Filtrar los Pacientes");
            toolTip1.SetToolTip(lupa, "Pulsa para Filtrar los Pacientes");
            toolTip1.SetToolTip(deshacer, "Pulsa para Deshacer el Filtro");
            toolTip1.InitialDelay = 1000;
        }

     
    }
}
