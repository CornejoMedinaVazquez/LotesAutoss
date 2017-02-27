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
    
    public partial class FrmModificarUsuario : Form
    {
         FrmCatalogoUsuario mUsuario;//modificar
        
        int indexrol;

        public FrmModificarUsuario(FrmCatalogoUsuario musuario)
        {
            InitializeComponent();

            mUsuario = musuario;//modificar

            mUsuario.cargardatos();//modificar


        }

        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            // llenar combo
            cmbRolModificarUsuario.DataSource = roles.getAll(true);
            cmbRolModificarUsuario.DisplayMember = "sNombre";
            cmbRolModificarUsuario.ValueMember = "pkRol";

            cmbRolModificarUsuario.SelectedIndex = indexrol;

            usuarios nUsuarios = usuarios.GetallUsuarios(FrmCatalogoUsuario.usuarioforeneo);
            txtEmailModificarrUsuario.Text = nUsuarios.sEmail;
            txtContrasenaModificarUsuario.Text = nUsuarios.sPassword;
            cmbRolModificarUsuario.SelectedValue = nUsuarios.rol_pkRol;
        }

        private void btnCancelarModificarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btbAceptarModificarUsuario_Click(object sender, EventArgs e)
        {
            usuarios nUsuarios = new Modelo.usuarios();
            nUsuarios.pkUsuario = FrmCatalogoUsuario.usuarioforeneo;
            nUsuarios.sEmail = txtEmailModificarrUsuario.Text;
            nUsuarios.sPassword = txtContrasenaModificarUsuario.Text;
            nUsuarios.rol_pkRol = Convert.ToInt32(cmbRolModificarUsuario.SelectedValue);

            nUsuarios.modificar(nUsuarios);
            mUsuario.cargardatos();
            this.Close();
        }
    }
}
