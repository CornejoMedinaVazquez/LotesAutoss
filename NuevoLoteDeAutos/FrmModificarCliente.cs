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
    public partial class FrmModificarCliente : Form
    {
        FrmCtalogoCliente mcliente;
        public FrmModificarCliente(FrmCtalogoCliente mCliente)
        {
            InitializeComponent();
            mcliente = mCliente;
            mcliente.cargardatos();

        }

        private void btnAceptarModificarCliente_Click(object sender, EventArgs e)
        {
            clientes objetoclientes = new clientes();
            objetoclientes.pkCliente = FrmCtalogoCliente.clienteforaneo;
            objetoclientes.sNombre = txtNombreCompletoModificarCliente.Text;
            objetoclientes.sDireccion = txtDireccionCompletaModificarCliente.Text;
            objetoclientes.guardar(objetoclientes);

            mcliente.cargardatos();
            mcliente.Show();
            this.Close();
        }

        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            clientes nClientes = clientes.Getallclientes(FrmCtalogoCliente.clienteforaneo);
            txtNombreCompletoModificarCliente.Text = nClientes.sNombre;
            txtDireccionCompletaModificarCliente.Text = nClientes.sDireccion;

           
        }

        private void btnCancelarModificarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
