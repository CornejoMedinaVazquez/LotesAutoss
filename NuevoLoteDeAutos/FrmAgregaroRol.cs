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
    public partial class FrmAgregaroRol : Form
    {
        public FrmAgregaroRol()
        {
            InitializeComponent();
        }

        private void btnAgregarNuevoRol_Click(object sender, EventArgs e)
        {
           roles nroles = new roles();
            nroles.sNombre = txtRol.Text;
            nroles.sDescripcion = txtDescripcion.Text;

            roles croles = new roles();
            croles.guardar(nroles);
            if(MessageBox.Show("¿Se a agregado con exito su registro?", "Ojo...!!", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
        }

        private void FrmCatalogoRol_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCategoriaRoles f = new FrmCategoriaRoles();
            f.ShowDialog();
        }
    }
}
