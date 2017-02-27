using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NuevoLoteDeAutos.Modelo;

namespace NuevoLoteDeAutos
{
    public partial class FrmModificarPropietario : Form
    {
        private string foto;
        int indexrol;
        FrmCatalogoPropietario M;
        public FrmModificarPropietario(FrmCatalogoPropietario N)
        {
            InitializeComponent();
            M = N;
            N.cargardatos();
        }
        private void FrmModificarPropietario_Load(object sender, EventArgs e)
        {
            webcam = new WebCam();
            webcam.InitializeWebCam(ref ptbFotoModificarPropietario);
            // llenar combo
            cmbClienteModificarForaneo.DataSource = clientes.getAll();
            cmbClienteModificarForaneo.DisplayMember = "sNombre";
            cmbClienteModificarForaneo.ValueMember = "pkCliente";

            cmbClienteModificarForaneo.SelectedIndex = indexrol;

            propietarios pprop = propietarios.Getallprpo(FrmCatalogoPropietario.propf);
            txtNombreCompletoModificarPropietario.Text = pprop.sNombre;
            txtDireccionCompletaModificarPropietario.Text = pprop.sDireccion;
            txtCorreoModificarPropietario.Text = pprop.sCorreo;
            txtTelefonoModificarPropietario.Text = pprop.sTelefono;
            txtIFEModificarPropietario.Text = pprop.iIfe;
            textBox1.Text = pprop.sFoto;
            cmbClienteModificarForaneo.SelectedValue = pprop.Cliente_pkCliente;
        }
        private void btnAgregarModificarPropietario_Click(object sender, EventArgs e)
        {
            propietarios propietario = new Modelo.propietarios();
            propietario.pkPropietario = FrmCatalogoPropietario.propf;
            propietario.sNombre = txtNombreCompletoModificarPropietario.Text;
            propietario.sDireccion = txtDireccionCompletaModificarPropietario.Text;
            propietario.sCorreo = txtCorreoModificarPropietario.Text;
            propietario.sTelefono = txtTelefonoModificarPropietario.Text;
            propietario.iIfe = txtIFEModificarPropietario.Text;
            propietario.sFoto = textBox1.Text;
            propietario.Cliente_pkCliente = Convert.ToInt32(cmbClienteModificarForaneo.SelectedValue);
            
            propietario.modificar(propietario);
            M.cargardatos();
            
            this.Close();
        }

        private void btnCancelarModificarPropietario_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Cerar la ventana?", "Aviso...!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        WebCam webcam;
        private void btnIniciarCamara_Click(object sender, EventArgs e)
        {
            webcam.Start();
        }

        private void btnCapturarModificarPropietario_Click(object sender, EventArgs e)
        {
            ptbFotoModificarPropietario.Image = ptbFotoModificarPropietario.Image;

            webcam.Stop();
        }

        private void btnExaminarModificarPropietario_Click(object sender, EventArgs e)
        {
            //webcam.Stop();
            foto = textBox1.Text + "foto" + ".png";
            string ruta = Path.Combine(@"C:\foto\", foto);
            textBox1.Text = foto;
            ptbFotoModificarPropietario.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Png);

        }
    }
}
