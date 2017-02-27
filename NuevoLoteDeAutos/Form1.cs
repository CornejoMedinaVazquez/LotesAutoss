using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NuevoLoteDeAutos.Controlador;//agrego

namespace NuevoLoteDeAutos
{
    public partial class FrmMenu : Form
    {
        public static ManejoSesion.SessiononHelper SessionActiva;

        public void ProcesarPermisos()
        {
            int permisos = 0;

            foreach (var obj in this.groupBox1.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permisos = Convert.ToInt32(btn.Tag);
                    btn.Enabled = SessionActiva.tienepermiso(permisos);
                }
            }
        }

        public FrmMenu()
        {
            SessionActiva = new ManejoSesion.SessiononHelper();
            InitializeComponent();
        }

        private void FrmMenu_Load_1(object sender, EventArgs e)
        {
            if (!FrmMenu.SessionActiva.isValid)
            {
                FrmLogin nVentana = new FrmLogin();
                nVentana.ShowDialog();
                int x = 0;
            }
        }
        private void FrmMenu_Activated_1(object sender, EventArgs e)
        {
            ProcesarPermisos();
        }

        /// <summary>
        /// boton que te lleva a la ventana de catalogo del usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnUsuario_Click_1(object sender, EventArgs e)
        {
            FrmCatalogoUsuario f = new FrmCatalogoUsuario();
            f.ShowDialog();
        }
        /// <summary>
        /// boten para llevar al form de agregar propietario y auto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPropietarioAutos_Click_1(object sender, EventArgs e)
        {
            FrmAgregarPropietarioAuto.DefInstance.Show();
        }
        /// <summary>
        /// boton para abrir al form clientes 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCliente_Click_1(object sender, EventArgs e)
        {
            FrmAgregarCliente.DefInstance.Show();

        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            FrmAgregaroRol f = new FrmAgregaroRol();
            f.ShowDialog();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmCatalogoVentas f = new FrmCatalogoVentas();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmPermisosNegadosPorRol f = new FrmPermisosNegadosPorRol();
            f.ShowDialog();
        }
    }
}
