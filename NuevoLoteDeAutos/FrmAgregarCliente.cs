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
using System.IO;

namespace NuevoLoteDeAutos
{
    public partial class FrmAgregarCliente : Form
    {
        internal int pkAuto1 { get; set; }
        internal int pkCliente { get; set; }
        internal string nombre1 { get; set; }
        internal string direccion1 { get; set; }
        internal string modelo1 { get; set; }
        internal string anio { get; set; }
        internal string serie1 { get; set; }
        internal string precio1 { get; set; }
        internal string nacionalidad1 { get; set; }
        internal string color { get; set; }
        internal string foto1 { get; set; }
        internal string foto2 { get; set; }
        internal string foto3 { get; set; }
        double subtotal = 0, comision = 0, iva = 0, grantotal = 0;



        public FrmAgregarCliente()//recibimos variables a mostrar
        {
            InitializeComponent();

        }
        /// <summary>
        /// boton para abrir la ventana de buscar cliente catalogo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnBuscarAgregarCliente_Click(object sender, EventArgs e)
        {
            FrmCtalogoCliente f = new FrmCtalogoCliente();
            f.ShowDialog();
            txtNombreCompletoAgregarCliente.Text = this.nombre1;
            txtDireccionCompletaAgregarCliente.Text = this.direccion1;
        }
        /// <summary>
        /// boton para mandar al form final de ventas 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarVenta_Click(object sender, EventArgs e)
        {

            FrmClientesVentas f = new FrmClientesVentas(txtNombreCompletoAgregarCliente.Text, txtDireccionCompletaAgregarCliente.Text, grantotal, this.pkCliente, this.pkAuto1);
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)//LLamamos al catalogo de autos para insertar la busqueda
        {

            FrmCatalogoAutos frmcat = new FrmCatalogoAutos();
            frmcat.ShowDialog();
            lblModeloDatoAuto.Text = this.modelo1;
            lblAnioDatoAuto.Text = this.anio;
            lblNumeroSerieDatoAuto.Text = this.serie1;
            lblPrecioDatoAuto.Text = this.precio1;
            lblNacionalidadDatoAuto.Text = this.nacionalidad1;
            lblColorDatoAuto.Text = this.color;

            //calculamos totales a pagar por el cliente
            calculartotal();

        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FrmAgregarCliente_Load(object sender, EventArgs e)
        {
            txtNombreCompletoAgregarCliente.Text = this.nombre1;
            txtDireccionCompletaAgregarCliente.Text = this.direccion1;
            lblModeloDatoAuto.Text = this.modelo1;
            lblAnioDatoAuto.Text = this.anio;
            lblNumeroSerieDatoAuto.Text = this.serie1;
            lblPrecioDatoAuto.Text = this.precio1;
            lblNacionalidadDatoAuto.Text = this.nacionalidad1;
            lblColorDatoAuto.Text = this.color;
            lblPrecioDatoAuto.Text = subtotal.ToString();


        }

        private void lblPrecioDatoAuto_TextChanged(object sender, EventArgs e)
        {
            calculartotal();
        }

        private void gpbDatosAuto_Enter(object sender, EventArgs e)
        {

        }

        private void lblNumeroSerieDatoAuto_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in autos.BuscarPorSerie(lblNumeroSerieDatoAuto.Text))
            {
                foto1 = item.foto1;
                foto2 = item.foto2;
                foto3 = item.foto3;

                if (File.Exists("c://foto//" + item.foto1 + ""))
                {
                    ptbFotoAuto1.Image = new Bitmap("c://foto//" + item.foto1 + "");

                }

                if (File.Exists("c://foto//" + item.foto2 + ""))
                {

                    ptbFotoAuto2.Image = new Bitmap("c://foto//" + item.foto2 + "");
                }

                if (File.Exists("c://foto//" + item.foto3 + ""))
                {

                    ptbFotoAuto3.Image = new Bitmap("c://foto//" + item.foto3 + "");
                }

            }
        }

        //metodo para no perder datos en el form///
        private static FrmAgregarCliente _Form1 = null;

        public static FrmAgregarCliente DefInstance
        {
            get
            {
                if (_Form1 == null || _Form1.IsDisposed)
                    _Form1 = new FrmAgregarCliente();
                else
                    _Form1.BringToFront();
                return _Form1;
            }
            set
            {
                _Form1 = value;
            }
        }
        public void calculartotal()
        {
            try
            {
                subtotal = Convert.ToDouble(lblPrecioDatoAuto.Text);
                comision = subtotal * .2;
                iva = subtotal * .16;
                grantotal = subtotal + comision + iva;

                txtSubtotalCliente.Text = subtotal.ToString();
                txtDatosAauto.Text = comision.ToString();
                txtIvaCliente.Text = iva.ToString();
                txtTotalCliente.Text = grantotal.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Necesita escoger un vehiculo");
            }

        }
    }
}