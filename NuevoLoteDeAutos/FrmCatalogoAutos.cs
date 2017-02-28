using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NuevoLoteDeAutos.Controlador;
using NuevoLoteDeAutos.Modelo;

namespace NuevoLoteDeAutos
{
    
    public partial class FrmCatalogoAutos : Form
    {
        

      


        internal int clientes { get; set; }
        internal int propietarios { get; set; }
        clientes objcli = new clientes();
        public static int autoforaneo;
        public void cargardatos()
        {
            this.dgvDatosAuto.DataSource = autos.BuscarPorMarcayalta(
                txtBuscarModeloAuto.Text, chkStatus.Checked);
        }
        public FrmCatalogoAutos()
        {
         

            InitializeComponent();
            dgvDatosAuto.AutoGenerateColumns = false;
        }
        /// <summary>
        /// boten para abrir el boton de modificar auto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            autoforaneo = Convert.ToInt32(this.dgvDatosAuto.CurrentRow.Cells["pkAuto"].Value);//modificar
            FrmModificarAuto f = new FrmModificarAuto(this);
            f.ShowDialog();

        }

        private void txtBuscarModeloAuto_TextChanged(object sender, EventArgs e)
        {
            dgvDatosAuto.DataSource = autos.BuscarPorMarca(txtBuscarModeloAuto.Text);//buscamos por modelo de auto 

        }

        private void btnSalirAuto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvDatosAuto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                DataGridViewRow row = (DataGridViewRow)dgvDatosAuto.Rows[e.RowIndex];
                FrmAgregarPropietarioAuto.DefInstance.pkauto1 = Convert.ToInt32(row.Cells["pkAuto"].Value);
                FrmAgregarPropietarioAuto.DefInstance.modelo1 = row.Cells["sMarca"].Value.ToString();
                FrmAgregarPropietarioAuto.DefInstance.anio = row.Cells["iAnio"].Value.ToString();
                FrmAgregarPropietarioAuto.DefInstance.serie1 = row.Cells["iSerie"].Value.ToString();
                FrmAgregarPropietarioAuto.DefInstance.precio1 = row.Cells["iPrecio"].Value.ToString();
                FrmAgregarPropietarioAuto.DefInstance.nacionalidad1 = row.Cells["sNacionalidad"].Value.ToString();
                FrmAgregarPropietarioAuto.DefInstance.color = row.Cells["sColor"].Value.ToString();
                FrmAgregarPropietarioAuto.DefInstance.Show();
                this.Close();
            

           
        }

        private void FrmCatalogoAutos_Load(object sender, EventArgs e)
        {
           
            cargardatos();
           
        }

        private void btnEliminarAuto_Click(object sender, EventArgs e)
        {
            autos deli = new autos();
            deli.eliminar(Convert.ToInt32(this.dgvDatosAuto.CurrentRow.Cells["pkAuto"].Value));

            cargardatos();
        }



        private void chkStatus_CheckedChanged_1(object sender, EventArgs e)
        {
            this.cargardatos();
        }



        public void ProcesarPermisos()
        {
            int permisos = 0;

            permisos = Convert.ToInt32(btnEliminarAuto.Tag);
            btnEliminarAuto.Enabled = FrmMenu.SessionActiva.tienepermiso(permisos);

        }

        private void FrmCatalogoAutos_Activated(object sender, EventArgs e)
        {
            this.ProcesarPermisos();
        }
    }
}