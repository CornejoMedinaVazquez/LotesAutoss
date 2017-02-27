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
    public partial class FrmPermisosNegadosPorRol : Form
    {
       //  FrmPermisosNegados wp;
        int indexrol;

        int indexrol2;

        public FrmPermisosNegadosPorRol()
        {
            InitializeComponent();
            //wp = mp;
        }


        private void FrmPermisosNegadosPorRol_Load(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (
                MessageBox.Show("¿Seguro que desea abandonar esta ventana?", "Aviso...!!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            permisosnegadosrol npernega = new Modelo.permisosnegadosrol();
        
           
            npernega.permiso_pkPermiso = Convert.ToInt32(cmbPermisos.SelectedValue);
            npernega.rol_pkRol = Convert.ToInt32(cmbRoles.SelectedValue);

            permisosnegadosrol cr = new permisosnegadosrol();
            cr.guardar(npernega);

            if (
                MessageBox.Show("Se ha agregado con exito", "Aviso...!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            FrmPermisosNegados f = new FrmPermisosNegados();
            f.ShowDialog();
        }
    }
}