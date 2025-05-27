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
    public partial class informe_tratamientos: Form
    {
        private tratamientos tratamientos;
        public informe_tratamientos(tratamientos tratamientos)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.tratamientos = tratamientos;
        }

        private void informe_tratamientos_Load(object sender, EventArgs e)
        {
            this.tratamientosTableAdapter.Fill(this.odonticDataSet.Tratamientos);
            this.tratamiento_DetalleTableAdapter.Fill(this.odonticDataSet.Tratamiento_Detalle);
            this.tratamientosBindingSource.Filter = "Id=" + Properties.Settings.Default.id_tratamientos;
            this.reportViewer1.RefreshReport();
        }

        private void informe_tratamientos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            tratamientos.Show();
            this.Dispose();
        }
    }
}
