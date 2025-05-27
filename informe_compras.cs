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
    public partial class informe_compras: Form
    {
        private compras compras;    
        public informe_compras(compras compras)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.AutoSize = true;
            this.compras = compras;
        }
        private void informe_compras_Load(object sender, EventArgs e)
        {
            this.comprasTableAdapter.Fill(this.odonticDataSet.Compras);
            this.compra_DetalleTableAdapter.Fill(this.odonticDataSet.Compra_Detalle);
            this.comprasBindingSource.Filter = "Id=" + Properties.Settings.Default.id_compras;
            this.reportViewer1.RefreshReport();
        }

        private void informe_compras_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            compras.Show();
            this.Dispose();
        }

    }
}
