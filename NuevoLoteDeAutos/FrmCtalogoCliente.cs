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
    public partial class FrmCtalogoCliente : Form
    {
        public static int clienteforaneo;
        public void cargardatos()
        {
            this.dgvCatalogoCliente.DataSource = clientes.BuscarPorApellidos(
                txtBuscarPorNombreCatalogoCliente.Text);
        }
        public FrmCtalogoCliente()
        {
            InitializeComponent();
            dgvCatalogoCliente.AutoGenerateColumns = false;//las columnas que no quiero que aparescan se generen
        }
        /// <summary>
        /// boton modoficar cliente catalogo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarCatalogoCliente_Click(object sender, EventArgs e)
        {
            clienteforaneo = Convert.ToInt32(this.dgvCatalogoCliente.CurrentRow.Cells["pkIdcliente"].Value);//modificar
            FrmModificarCliente f = new FrmModificarCliente(this);
            f.ShowDialog();
        }

        private void txtBuscarPorNombreCatalogoCliente_TextChanged(object sender, EventArgs e)
        {
            dgvCatalogoCliente.DataSource = clientes.BuscarPorApellidos(txtBuscarPorNombreCatalogoCliente.Text);

        }


        private void dgvCatalogoCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvCatalogoCliente.Rows[e.RowIndex];
            FrmAgregarCliente.DefInstance.pkCliente = Convert.ToInt32(row.Cells["pkIdcliente"].Value.ToString());
            FrmAgregarCliente.DefInstance.nombre1 = row.Cells["sNombre"].Value.ToString();
            FrmAgregarCliente.DefInstance.direccion1 = row.Cells["sDireccion"].Value.ToString();

            FrmAgregarCliente.DefInstance.Show();
            this.Close();
        }

        private void FrmCtalogoCliente_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btnEliminarCatalogoCliente_Click(object sender, EventArgs e)
        {
            clientes deli = new clientes();
            deli.eliminar(Convert.ToInt32(this.dgvCatalogoCliente.CurrentRow.Cells["pkIdcliente"].Value));

            cargardatos();
        }

        private void btncancelarCatalogoCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        public void ProcesarPermisos()
        {
            int permisos = 0;

            permisos = Convert.ToInt32(btnEliminarCatalogoCliente.Tag);
            btnEliminarCatalogoCliente.Enabled = FrmMenu.SessionActiva.tienepermiso(permisos);

        }

        private void FrmCtalogoCliente_Activated(object sender, EventArgs e)
        {
            this.ProcesarPermisos();
        }
    }
}