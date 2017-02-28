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
using NuevoLoteDeAutos.Controlador;

namespace NuevoLoteDeAutos
{
    public partial class FrmCatalogoUsuario : Form
    {
        public static int usuarioforeneo;
      

       
        public void cargardatos()
        {
            this.dgvCatalogoUsuario.DataSource = usuarios.BuscarPorNombreUsuario(
                txtBuscarPorNombreCatalogoUsuario.Text, checkBox1.Checked);
        }

        public FrmCatalogoUsuario()
        {
            
            InitializeComponent();
            dgvCatalogoUsuario.AutoGenerateColumns = false;
        }
        /// <summary>
        /// boton para abrir la ventana de agregar usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarCatalogoUsuario_Click(object sender, EventArgs e)
        {
          FrmAgregarUsuario f = new FrmAgregarUsuario(this);
            f.ShowDialog();
        }
        /// <summary>
        /// boton para abrir la ventana de modificar usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModificarCatalogoUsuario_Click(object sender, EventArgs e)
        {
            usuarioforeneo = Convert.ToInt32(this.dgvCatalogoUsuario.CurrentRow.Cells["pkUsuario"].Value);//modificar
            FrmModificarUsuario f = new FrmModificarUsuario(this);
            f.ShowDialog();
        }

        private void txtBuscarPorNombreCatalogoUsuario_TextChanged(object sender, EventArgs e)
        {
            dgvCatalogoUsuario.DataSource = usuarios.BuscarPorNombreUsuari(txtBuscarPorNombreCatalogoUsuario.Text);
        }

        private void FrmCatalogoUsuario_Load(object sender, EventArgs e)
        {
            cargardatos();

        }

        private void btncancelarCatalogoUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Funcion que permite eliminar a un registro de la tabla de la base de datos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEliminarCatalogoUsuario_Click(object sender, EventArgs e)
        {
            usuarios deli = new usuarios();
            deli.eliminar(Convert.ToInt32(this.dgvCatalogoUsuario.CurrentRow.Cells["pkUsuario"].Value));

            cargardatos();

            //MessageBox.Show(Convert.ToInt32(this.dgvCatalogoUsuario.CurrentRow.Cells["pkUsuario"].Value).ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.cargardatos();
            
        }

        public void ProcesarPermisos()
        {
            int permisos = 0;

            permisos = Convert.ToInt32(btnEliminarCatalogoUsuario.Tag);
            btnEliminarCatalogoUsuario.Enabled = FrmMenu.SessionActiva.tienepermiso(permisos);

        }

        private void FrmCatalogoUsuario_Activated(object sender, EventArgs e)
        {
            this.ProcesarPermisos();
        }
    }
}
