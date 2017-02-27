using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NuevoLoteDeAutos.Controlador;//se agrega el using para la carpeta controlador

namespace NuevoLoteDeAutos
{
    public partial class FrmLogin : Form
    {
         ManejoSesion.SessiononHelper objsession;//se agrega

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            objsession = ManejoSesion.Login(txtUsuario.Text, txtPassword.Text);

            if (!objsession.isValid)
            {
                errorProvider1.SetError(txtUsuario, objsession.msgError);
                txtUsuario.Focus();
            }
            else
            {
                FrmMenu.SessionActiva = objsession;
                this.Close();

            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (FrmMenu.SessionActiva.isValid)
            {
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que no desea ingresar a la sesion?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               Application.Exit();
            }
        }
    }
}
