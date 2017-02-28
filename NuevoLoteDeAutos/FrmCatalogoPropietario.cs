using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NuevoLoteDeAutos.Controlador;//agrego
using NuevoLoteDeAutos.Modelo;// agrego carpeta modelo

namespace NuevoLoteDeAutos
{
    public partial class FrmCatalogoPropietario : Form
    {
        public static int propf;
       
        public void cargardatos()
        {
            this.dgvDatosPropietario.DataSource = propietarios.BuscarPorNombreUsuario(
                txtBuscarNombreCompleto.Text, checkBox1.Checked);
        }
        public FrmCatalogoPropietario()
        {
            
            InitializeComponent();
            dgvDatosPropietario.AutoGenerateColumns = false;
        }


        /// <summary>
        /// boton para abrir el form modificar propietario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificar_Click(object sender, EventArgs e)
        {
            propf = Convert.ToInt32(this.dgvDatosPropietario.CurrentRow.Cells["pkPropietario"].Value);//modificar
            FrmModificarPropietario f = new FrmModificarPropietario(this);
            f.ShowDialog();
        }

        private void txtBuscarNombreCompleto_TextChanged(object sender, EventArgs e)
        {
            dgvDatosPropietario.DataSource = propietarios.BuscarPorNoPropietario(txtBuscarNombreCompleto.Text);

        }
        /// <summary>
        /// boton para cerrar la ventana 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro de que quiere cerrar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmCatalogoPropietario_Load(object sender, EventArgs e)
        {

          
            cargardatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            propietarios deli = new propietarios();
            deli.eliminar(Convert.ToInt32(this.dgvDatosPropietario.CurrentRow.Cells["pkPropietario"].Value));

            cargardatos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.cargardatos();
        }

        private void dgvDatosPropietario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (DataGridViewRow)dgvDatosPropietario.Rows[e.RowIndex];
            FrmAgregarPropietarioAuto.DefInstance.pkPropietario = Convert.ToInt32(row.Cells["pkPropietario"].Value.ToString());
            FrmAgregarPropietarioAuto.DefInstance.sNombre = row.Cells["sNombre"].Value.ToString();
            FrmAgregarPropietarioAuto.DefInstance.sDireccion = row.Cells["sDireccion"].Value.ToString();
            FrmAgregarPropietarioAuto.DefInstance.sTelefono = row.Cells["sTelefono"].Value.ToString();
            FrmAgregarPropietarioAuto.DefInstance.sCorreo = row.Cells["sCorreo"].Value.ToString();
            FrmAgregarPropietarioAuto.DefInstance.iIfe = row.Cells["iIfe"].Value.ToString();
            FrmAgregarPropietarioAuto.DefInstance.sFoto = row.Cells["sFoto"].Value.ToString();
            FrmAgregarPropietarioAuto.DefInstance.Cliente_pkCliente = row.Cells["Cliente_pkCliente"].Value.ToString();


            FrmAgregarPropietarioAuto.DefInstance.Show();
            this.Close();
        }

        public void ProcesarPermisos()
        {
            int permisos = 0;

            permisos = Convert.ToInt32(btnEliminar.Tag);
            btnEliminar.Enabled = FrmMenu.SessionActiva.tienepermiso(permisos);

        }

        private void FrmCatalogoPropietario_Activated(object sender, EventArgs e)
        {
            this.ProcesarPermisos();
        }
    }
}