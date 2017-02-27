using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevoLoteDeAutos.Modelo;
using System.Windows.Forms;

namespace NuevoLoteDeAutos
{
    public partial class FromVentasPropietarioAuto : Form
    {
        FrmAgregarPropietarioAuto u;
        public FromVentasPropietarioAuto(FrmAgregarPropietarioAuto i)
        {
            InitializeComponent();
            u = i;

        }


        private void btnCancelarVentaVentaPropietarioAuto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        double total = 200, pago, grantotal;
        private void btnAceptarVentaVentaPropietarioAuto_Click(object sender, EventArgs e)
        {

            pago = Convert.ToDouble(txtPrecioVentaVentaPropietarioAuto.Text);


            if (total > Convert.ToDouble(txtPrecioVentaVentaPropietarioAuto.Text))
            {
                MessageBox.Show("ccc");
                txtPrecioVentaVentaPropietarioAuto.Focus();
            }
            else
            {
                //grantotal = total - pago;
                //txtCambioVentaVentaPropietarioAuto.Text = grantotal.ToString();
                //u.guardarlosdatos2();
                //u.guardarlosdatos1();
                //this.Close();
                //FrmAgregarPropietarioAuto x = new FrmAgregarPropietarioAuto();
                //x.Close();
            }
        }
    }
}