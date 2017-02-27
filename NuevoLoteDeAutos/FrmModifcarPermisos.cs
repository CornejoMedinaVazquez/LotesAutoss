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
    public partial class FrmModifcarPermisos : Form
    {
         FrmPermisosNegados pp;
        int indexrol;

        int indexrol2;
        public FrmModifcarPermisos(FrmPermisosNegados p)
        {
            InitializeComponent();
            pp = p;
        }

        private void FrmModifcarPermisos_Load(object sender, EventArgs e)
        {
            // llenar combo
            cmbPermisos.DataSource = permisosnegadosrol.getAll(true);
            cmbPermisos.DisplayMember = "sModulo";
            cmbPermisos.ValueMember = "pkPermiso";
            cmbPermisos.SelectedIndex = indexrol;

            // llenar combo
            cmbRoles.DataSource = permisosnegadosrol.getAll2(true);
            cmbRoles.DisplayMember = "sNombre";
            cmbRoles.ValueMember = "pkRol";
            cmbRoles.SelectedIndex = indexrol2;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            permisosnegadosrol npp = new Modelo.permisosnegadosrol();

            npp.pkPermisoNegadoRol = FrmPermisosNegados.permi;
            npp.permiso_pkPermiso = Convert.ToInt32(cmbPermisos.SelectedValue);
            npp.rol_pkRol = Convert.ToInt32(cmbRoles.SelectedValue);

            npp.modificar(npp);
            pp.cargardatos();
            this.Close();
        }
    }
}
