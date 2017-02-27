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

    public partial class FrmCategoriaRoles : Form
    {
        public static int Rol;
        public void cargardatos()
        {
            this.dataGridView1.DataSource = roles.BuscarPorNombreRo(
                txtBuscarrol.Text, checkBox1.Checked);
        }
        public FrmCategoriaRoles()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void FrmCategoriaRoles_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.cargardatos();
        }

        private void txtBuscarrol_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = roles.BuscarPorNombreRol(txtBuscarrol.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            roles deli = new roles();
            deli.eliminar(Convert.ToInt32(dataGridView1.CurrentRow.Cells["pkRol"].Value));

            cargardatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Rol = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["pkRol"].Value);//modificar

            FrmModificarRol f = new FrmModificarRol(this);
            f.ShowDialog();
        }
    }
}
