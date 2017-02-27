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
    public partial class FrmAgregarUsuario : Form
    {
        FrmCatalogoUsuario wUsuario;
        int indexrol;

        public FrmAgregarUsuario(FrmCatalogoUsuario vUsuario)
        {
            InitializeComponent();
            wUsuario = vUsuario;
        }

        
        /// <summary>
        /// funcion que permite llenar el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAgregarUsuario_Load(object sender, EventArgs e)
        {
            cmbRolAgregarUsuario.DataSource = roles.getAll(true);
            cmbRolAgregarUsuario.DisplayMember = "sNombre";
            cmbRolAgregarUsuario.ValueMember = "pkRol";

            cmbRolAgregarUsuario.SelectedIndex = indexrol;
        }
        /// <summary>
        /// funcion para agregar algun regitro 
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btbAceptarAgregarUsuario_Click(object sender, EventArgs e)
        {     
           usuarios nUsuarios =new usuarios();
            nUsuarios.sEmail = txtEmailAgregarUsuario.Text;
            nUsuarios.sPassword = txtContrasenaAgregarUsuario.Text;
            nUsuarios.rol_pkRol = Convert.ToInt32(cmbRolAgregarUsuario.SelectedValue.ToString());

            usuarios cUsuarios = new usuarios();
            cUsuarios.guardar(nUsuarios);

            wUsuario.cargardatos();
            this.Close();
        }

        private void btnCancelarAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void cmbRolAgregarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
