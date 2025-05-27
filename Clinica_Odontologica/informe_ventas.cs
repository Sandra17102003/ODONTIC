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
    public partial class informe_ventas: Form
    {
        private ventas ventas;
        public informe_ventas(ventas ventas)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.ventas = ventas;
        }

        private void informe_ventas_Load(object sender, EventArgs e)
        {
            this.ventasTableAdapter.Fill(this.odonticDataSet.Ventas);
            this.venta_DetalleTableAdapter.Fill(this.odonticDataSet.Venta_Detalle);
            this.ventasBindingSource.Filter = "Id=" + Properties.Settings.Default.id_ventas;
            this.reportViewer1.RefreshReport();
        }

        private void informe_ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            ventas.Show();
            this.Dispose();
        }
    }
}
