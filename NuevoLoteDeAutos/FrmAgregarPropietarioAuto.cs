using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.VisualStyles;
using NuevoLoteDeAutos.Modelo;


// se agrega el usung para la foto

namespace NuevoLoteDeAutos
{
    public partial class FrmAgregarPropietarioAuto : Form
    {
        double subtotal = 0, comision = 0, iva = 0;
        int indx;
        int indexrol;
        double total = 200, pago, grantotal;
        public static int autopropietario = 1;
        internal int pkPropietario { get; set; }
        internal string sNombre { get; set; }
        internal string sDireccion { get; set; }
        internal string sTelefono { get; set; }
        internal string sCorreo { get; set; }
        internal string iIfe { get; set; }
        internal string sFoto { get; set; }
        internal string Cliente_pkCliente { get; set; }

        internal int pkauto1 { get; set; }
        internal string modelo1 { get; set; }
        internal string anio { get; set; }
        internal string serie1 { get; set; }
        internal string precio1 { get; set; }
        internal string nacionalidad1 { get; set; }
        internal string splaca { get; set; }
        internal string color { get; set; }
        internal string foto1 { get; set; }
        internal string foto2 { get; set; }
        internal string foto3 { get; set; }


        private string foto;

        // FrmCatalogoPropietario sPropietario;

        public FrmAgregarPropietarioAuto()
        {
            InitializeComponent();
            // sPropietario = vPropietario;
        }
        /// <summary>
        /// Boton el cual te manda al form de catalogo de propietario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmCatalogoPropietario f = new FrmCatalogoPropietario();

            f.ShowDialog();
            txtNombreCompletoPropietario.Text = this.sNombre;
            txtDireccionCompletaPropietario.Text = this.sDireccion;
            txtCorreoPropietario.Text = this.sCorreo;
            txtTelefonoPropietario.Text = this.sTelefono;
            txtIFEPropietario.Text = this.iIfe;

        }
        /// <summary>
        /// boton que te lleva al form de ventas del propietario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrarRegistro_Click(object sender, EventArgs e)
        {

            //FromVentasPropietarioAuto f = new FromVentasPropietarioAuto(this);
            //f.ShowDialog();
            try
            {


                pago = Convert.ToDouble(textBox5.Text);


                if (total > Convert.ToDouble(textBox5.Text))
                {
                    MessageBox.Show("ccc");
                    textBox5.Focus();
                }
                else
                {
                    grantotal = total - pago;
                    textBox6.Text = grantotal.ToString();

                    if (textBox5.Text == "")
                    {
                        MessageBox.Show("Favor de introducir cantidad a pagar");
                        textBox5.Focus();
                    }

                    else
                    {
                        if (total > Convert.ToDouble(textBox5.Text))
                        {
                            MessageBox.Show("ccc");
                            textBox5.Focus();
                        }
                        else
                        {
                            grantotal = total - pago;
                            textBox6.Text = grantotal.ToString();


                            propietarios cPropietarios = new propietarios();
                            cPropietarios.sNombre = txtNombreCompletoPropietario.Text;
                            cPropietarios.sDireccion = txtDireccionCompletaPropietario.Text;
                            cPropietarios.sCorreo = txtCorreoPropietario.Text;
                            cPropietarios.sTelefono = txtTelefonoPropietario.Text;
                            cPropietarios.iIfe = txtIFEPropietario.Text;
                            cPropietarios.sFoto = textBox1.Text;
                            cPropietarios.Cliente_pkCliente = Convert.ToInt32(cmbClienteForaneo.SelectedValue);
                            cPropietarios.guardar(cPropietarios);

                            autos cautos = new autos();
                            cautos.sMarca = txtModeloAuto.Text;
                            cautos.iAnio = Convert.ToInt32(txtAnioAuto.Text);

                            cautos.iPrecio = Convert.ToInt32(txtPrecioAuto.Text);
                            cautos.sColor = txtColorAuto.Text;
                            cautos.sNacionalidad = cmbNacionalidadAuto.Text;

                            cautos.foto1 = txtNumeroSerieAuto.Text + "foto1.jpg";
                            cautos.foto2 = txtNumeroSerieAuto.Text + "foto2.jpg"; ;
                            cautos.foto3 = txtNumeroSerieAuto.Text + "foto3.jpg"; ;
                            string ruta = Path.Combine(@"C:\foto\", cautos.foto1);
                            string ruta1 = Path.Combine(@"C:\foto\", cautos.foto2);
                            string ruta2 = Path.Combine(@"C:\foto\", cautos.foto3);
                            ptbFotoAuto1.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
                            ptbFotoAuto2.Image.Save(ruta1, System.Drawing.Imaging.ImageFormat.Jpeg);
                            ptbFotoAuto3.Image.Save(ruta2, System.Drawing.Imaging.ImageFormat.Jpeg);
                            cautos.iSerie = Convert.ToInt32(txtNumeroSerieAuto.Text);
                            cautos.Propietario_pkPropietario = Convert.ToInt32(cmbPropietarioForaneo.SelectedValue);
                            cautos.guardar(cautos);

                            ventas objventas = new ventas();
                            objventas.auto_pkAuto = cautos.pkAuto;
                            objventas.cliente_pkCliente = cPropietarios.Cliente_pkCliente;
                            objventas.dCantidad = 200;
                            objventas.sConcepto = "Regsitro";
                            objventas.guardar(objventas);

                        }
                    }
                    MessageBox.Show("Registro Existoso");
                    this.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Introdusca cantidad");
            }
        }
        private void txtMarcaAuto_TextChanged(object sender, EventArgs e)
        {

        }

        WebCam webcam;


        /// <summary>
        /// permite encender la camara para caputurar la fotografia 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarCamara_Click_1(object sender, EventArgs e)
        {
            webcam.Start();

        }

        /// <summary>
        /// Boton que permite capturar una imagen y apagar la camara
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCapturarPropietario_Click_1(object sender, EventArgs e)
        {
            pcbTomaFoto.Image = pcbTomaFoto.Image;

            webcam.Stop();
        }

        private void FrmAgregarPropietarioAuto_Load_1(object sender, EventArgs e)
        {

            webcam = new WebCam();
            webcam.InitializeWebCam(ref pcbTomaFoto);

            cmbClienteForaneo.DataSource = clientes.getAll();
            cmbClienteForaneo.DisplayMember = "sNombre";
            cmbClienteForaneo.ValueMember = "pkCliente";
            cmbClienteForaneo.SelectedIndex = indexrol;


            cmbPropietarioForaneo.DataSource = propietarios.getAll(true);
            cmbPropietarioForaneo.DisplayMember = "sNombre";
            cmbPropietarioForaneo.ValueMember = "pkPropietario";
            cmbPropietarioForaneo.SelectedIndex = indx;

            txtNombreCompletoPropietario.Text = this.sNombre;
            txtDireccionCompletaPropietario.Text = this.sDireccion;
            txtCorreoPropietario.Text = this.sCorreo;
            txtTelefonoPropietario.Text = this.sTelefono;
            txtIFEPropietario.Text = this.iIfe;
            cmbClienteForaneo.Text = this.Cliente_pkCliente;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmCatalogoAutos f = new FrmCatalogoAutos();

            f.ShowDialog();
            txtModeloAuto.Text = this.modelo1;
            txtAnioAuto.Text = this.anio;
            txtNumeroSerieAuto.Text = this.serie1;
            txtPrecioAuto.Text = this.precio1;
            cmbNacionalidadAuto.Text = this.nacionalidad1;
            txtColorAuto.Text = this.color;

            cmbPropietarioForaneo.Text = this.pkPropietario.ToString();
        }

        private void btnGuardarFotoPropietario_Click(object sender, EventArgs e)
        {
            //webcam.Stop();
            foto = txtNombreCompletoPropietario.Text + "foto" + ".png";
            string ruta = Path.Combine(@"C:\foto\", foto);
            textBox1.Text = foto;
            pcbTomaFoto.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Png);


        }

        private void button2_Click(object sender, EventArgs e)//boten agregar calisa
        {

        }

        //private void txtPrecioAuto_TextChanged(object sender, EventArgs e)
        //{
        //    lblPrecTotL.Text = txtPrecioAuto.Text;
        //}

        private void txtModeloAuto_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in autos.BuscarPorMarca(txtModeloAuto.Text))
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

        private void ptbFotoAuto1_Click(object sender, EventArgs e)
        {

        }

        private void ptbFotoAuto1_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo de imagen|*.jpg| archivo png |*.png| todos los archivos|*.*";
            DialogResult resultado = openFileDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ptbFotoAuto1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void ptbFotoAuto2_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Archivo de imagen|*.jpg| archivo png |*.png| todos los archivos|*.*";
            DialogResult resultado = openFileDialog2.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ptbFotoAuto2.Image = Image.FromFile(openFileDialog2.FileName);
            }
        }

        private void ptbFotoAuto3_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog3.Filter = "Archivo de imagen|*.jpg| archivo png |*.png| todos los archivos|*.*";
            DialogResult resultado = openFileDialog3.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ptbFotoAuto3.Image = Image.FromFile(openFileDialog3.FileName);
            }
        }

        public void guardarlosdatos1()
        {
            propietarios cPropietarios = new propietarios();
            cPropietarios.sNombre = txtNombreCompletoPropietario.Text;
            cPropietarios.sDireccion = txtDireccionCompletaPropietario.Text;
            cPropietarios.sCorreo = txtCorreoPropietario.Text;
            cPropietarios.sTelefono = txtTelefonoPropietario.Text;
            cPropietarios.iIfe = txtIFEPropietario.Text;
            cPropietarios.sFoto = textBox1.Text;
            cPropietarios.Cliente_pkCliente = Convert.ToInt32(cmbClienteForaneo.SelectedValue);
            cPropietarios.guardar(cPropietarios);

            //sPropietario.cargardatos();
            //MessageBox.Show("se agrego con exito");
            // this.Close();


            //autos cautos = new autos();
            //cautos.sMarca = txtModeloAuto.Text;
            //cautos.iAnio = Convert.ToInt32(txtAnioAuto.Text);
            //cautos.sPlaca = txtplacadelauto.Text;
            //cautos.iPrecio = Convert.ToInt32(txtPrecioAuto.Text);
            //cautos.sColor = txtColorAuto.Text;
            //cautos.sNacionalidad = cmbNacionalidadAuto.Text;
            //cautos.iSerie = Convert.ToInt32(txtNumeroSerieAuto.Text);

            //cautos.Propietario_pkPropietario = Convert.ToInt32(cmbPropietarioForaneo.SelectedValue.ToString());

            //autos au = new autos();
            //au.guardar(cautos);
            //this.Close();

        }

        //public void guardarlosdatos2()
        //{

        //    autos cautos = new autos();
        //    cautos.sMarca = txtModeloAuto.Text;
        //    cautos.iAnio = Convert.ToInt32(txtAnioAuto.Text);

        //    cautos.iPrecio = Convert.ToInt32(txtPrecioAuto.Text);
        //    cautos.sColor = txtColorAuto.Text;
        //    cautos.sNacionalidad = cmbNacionalidadAuto.Text;

        //    cautos.foto1 = textBox2.Text;
        //    cautos.foto2 = textBox4.Text;
        //    cautos.foto3 = textBox3.Text;
        //    string ruta = Path.Combine(@"C:\foto\", cautos.foto1);
        //    string ruta1 = Path.Combine(@"C:\foto\", cautos.foto2);
        //    string ruta2 = Path.Combine(@"C:\foto\", cautos.foto3);
        //    ptbFotoAuto1.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    ptbFotoAuto2.Image.Save(ruta1, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    ptbFotoAuto3.Image.Save(ruta2, System.Drawing.Imaging.ImageFormat.Jpeg);
        //    cautos.iSerie = Convert.ToInt32(txtNumeroSerieAuto.Text);
        //    cautos.Propietario_pkPropietario = Convert.ToInt32(cmbPropietarioForaneo.SelectedValue);

        //    cautos.guardar(cautos);
        //    this.Close();

        //}
        public void calculartotal()
        {

        }
        private static FrmAgregarPropietarioAuto _Form1 = null;

        public static FrmAgregarPropietarioAuto DefInstance
        {
            get
            {
                if (_Form1 == null || _Form1.IsDisposed)
                    _Form1 = new FrmAgregarPropietarioAuto();
                else
                    _Form1.BringToFront();
                return _Form1;
            }
            set
            {
                _Form1 = value;
            }
        }

    }
}