using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NuevoLoteDeAutos.Modelo;

namespace NuevoLoteDeAutos
{
    public partial class FrmCatalogoVentas : Form
    {
        public FrmCatalogoVentas()
        {
            InitializeComponent();
            dgvCatalogoCliente.AutoGenerateColumns = false;
        }

        public void cargardatos()
        {
            this.dgvCatalogoCliente.DataSource = ventas.BuscarPorConcepto(
                txtBuscarPorNombreCatalogoCliente.Text);
        }

        private void txtBuscarPorNombreCatalogoCliente_TextChanged(object sender, EventArgs e)
        {
            dgvCatalogoCliente.DataSource = ventas.BuscarPorConcepto(txtBuscarPorNombreCatalogoCliente.Text);
        }

        private void FrmCatalogoVentas_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btncancelarCatalogoCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
