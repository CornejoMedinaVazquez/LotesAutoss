using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NuevoLoteDeAutos.Modelo;

namespace NuevoLoteDeAutos
{

    public partial class FrmModificarAuto : Form
    {
        public string foto1, foto2, foto3;
        FrmCatalogoAutos mAuto;//modificar
        int indexrol;
        public FrmModificarAuto(FrmCatalogoAutos mauto)
        {
            InitializeComponent();
            mAuto = mauto;
            mAuto.cargardatos();
        }

        private void ptbFotoAuto1Modificar_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Archivo de imagen |*.jpg| Archivo PNG |*.png| Todos los archivos |*.*";
            DialogResult resultado = openFileDialog1.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ptbFotoAuto1Modificar.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        string pkauto;
        private void btnAgregarModificarAuto_Click(object sender, EventArgs e)
        {
            autos nautos = autos.Getallautos(FrmCatalogoAutos.autoforaneo);
            autos objetoautos = new autos();
            objetoautos.foto1 = txtNumeroModificarSerieAuto.Text + "foto1.jpg";
            objetoautos.foto2 = txtNumeroModificarSerieAuto.Text + "foto2.jpg";
            objetoautos.foto3 = txtNumeroModificarSerieAuto.Text + "foto3.jpg";
            string ruta = Path.Combine(@"C:\foto\", objetoautos.foto1);
            string ruta1 = Path.Combine(@"C:\foto\", objetoautos.foto2);
            string ruta2 = Path.Combine(@"C:\foto\", objetoautos.foto3);
            ptbFotoAuto1Modificar.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
            ptbFotoAuto2Modificar.Image.Save(ruta1, System.Drawing.Imaging.ImageFormat.Jpeg);
            ptbFotoAuto3Modificar.Image.Save(ruta2, System.Drawing.Imaging.ImageFormat.Jpeg);



            objetoautos.pkAuto = FrmCatalogoAutos.autoforaneo;
            objetoautos.sMarca = txtModeloModificarAuto.Text;
            objetoautos.iAnio = Convert.ToInt32(txtAnioModificarAuto.Text);
            objetoautos.sPlaca = txtPlaca.Text;
            objetoautos.iSerie = Convert.ToInt32(txtNumeroModificarSerieAuto.Text);
            objetoautos.iPrecio = Convert.ToInt32(txtPrecioModificarAuto.Text);
            objetoautos.sNacionalidad = cmbNacionalidadModificarAuto.Text;
            objetoautos.sColor = txtColorModificarAuto.Text;
            objetoautos.bStatus = true;
            objetoautos.Propietario_pkPropietario = Convert.ToInt32(cmbPropietarioModificarForaneo.SelectedValue);


            objetoautos.guardar(objetoautos);



            mAuto.cargardatos();
            mAuto.Show();
            this.Close();
        }

        private void ptbFotoAuto1Modificar_Click(object sender, EventArgs e)
        {

        }

        private void ptbFotoAuto2Modificar_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Archivo de imagen |*.jpg| Archivo PNG |*.png| Todos los archivos |*.*";
            DialogResult resultado = openFileDialog2.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ptbFotoAuto2Modificar.Image = Image.FromFile(openFileDialog2.FileName);
            }
        }

        private void ptbFotoAuto3Modificar_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog3.Filter = "Archivo de imagen |*.jpg| Archivo PNG |*.png| Todos los archivos |*.*";
            DialogResult resultado = openFileDialog3.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                ptbFotoAuto3Modificar.Image = Image.FromFile(openFileDialog3.FileName);
            }
        }

        private void FrmModificarAuto_Load(object sender, EventArgs e)
        {
            autos nAutos = autos.Getallautos(FrmCatalogoAutos.autoforaneo);
            txtModeloModificarAuto.Text = nAutos.sMarca;
            txtAnioModificarAuto.Text = nAutos.iAnio.ToString();
            txtPlaca.Text = nAutos.sPlaca;
            txtNumeroModificarSerieAuto.Text = nAutos.iSerie.ToString();
            txtPrecioModificarAuto.Text = nAutos.iPrecio.ToString();
            cmbNacionalidadModificarAuto.SelectedText = nAutos.sNacionalidad;
            txtColorModificarAuto.Text = nAutos.sColor;

            cmbPropietarioModificarForaneo.DataSource = propietarios.getAll(true);
            cmbPropietarioModificarForaneo.DisplayMember = "sNombre";
            cmbPropietarioModificarForaneo.ValueMember = "pkPropietario";
            cmbPropietarioModificarForaneo.DisplayMember = indexrol.ToString();

            if (File.Exists("c://foto//" + nAutos.foto1 + ""))
            {
                ptbFotoAuto1Modificar.Image = new Bitmap("c://foto//" + nAutos.foto1 + "");

            }

            if (File.Exists("c://foto//" + nAutos.foto2 + ""))
            {

                ptbFotoAuto2Modificar.Image = new Bitmap("c://foto//" + nAutos.foto2 + "");
            }

            if (File.Exists("c://foto//" + nAutos.foto3 + ""))
            {

                ptbFotoAuto3Modificar.Image = new Bitmap("c://foto//" + nAutos.foto3 + "");
            }
        }

        private void btnSalirModificarAuto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}