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
    public partial class FrmModificarRol : Form
    {
        FrmCategoriaRoles wRol;//modificar
        public FrmModificarRol(FrmCategoriaRoles wrol)
        {
            InitializeComponent();
            wRol = wrol;
            wRol.cargardatos();
        }

        private void FrmModificarRol_Load(object sender, EventArgs e)
        {
            roles nUsuarios = roles.Getallrol(FrmCategoriaRoles.Rol);
            txtRol.Text = nUsuarios.sNombre;
            txtDescripcion.Text = nUsuarios.sDescripcion;
        

        }

        private void btnAgregarNuevoRol_Click(object sender, EventArgs e)
        {
            roles nrol = new Modelo.roles();
            nrol.pkRol = FrmCategoriaRoles.Rol;
            nrol.sNombre = txtRol.Text;
            nrol.sDescripcion = txtDescripcion.Text;


            nrol.modificar(nrol);
            wRol.cargardatos();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
