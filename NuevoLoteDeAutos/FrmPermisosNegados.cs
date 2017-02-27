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
    public partial class FrmPermisosNegados : Form
    {
        public static int permi;
        public FrmPermisosNegados()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }
        public void cargardatos()
        {
            this.dataGridView1.DataSource = permisosnegadosrol.datos();

        }

        private void FrmPermisosNegados_Load(object sender, EventArgs e)
        {
            cargardatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            permisosnegadosrol deli = new permisosnegadosrol();
            deli.eliminar(Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["pkPermisoNegadoRol"].Value));

            cargardatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            permi = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells["pkPermisoNegadoRol"].Value);//modificar
            FrmModifcarPermisos f = new FrmModifcarPermisos(this);
            f.ShowDialog();
        }
    }
}
