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
    public partial class FrmClientesVentas : Form
    {
        autos objautos = new autos();
        string nombre, direccion, ciudad;
        int pkCliente;
        int pkAuto;

        public FrmClientesVentas(string nombrequerecibe, string direccionquerecibe, double grantotalquerecibe, int pkClientequerecibe, int pkAutoquerecibe)//recibimos variables para manipularlas estas vienen del agregar clientes
        {
            InitializeComponent();
            nombre = nombrequerecibe;
            direccion = direccionquerecibe;
            txtTotalVentaVentaCliente.Text = grantotalquerecibe.ToString();
            pkCliente = pkClientequerecibe;
            pkAuto = pkAutoquerecibe;

        }

        public FrmClientesVentas()
        {
        }

        double total, pago, cambio; //variables para utilizar en nuestra operacion

        private void FrmClientesVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarVentaVentaCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarVentaVentaCliente_Click(object sender, EventArgs e)
        {
            try
            {


                string conceptop = "Venta de vehiculo";

                ventas objventas = new ventas();
                clientes objcliente = new clientes();
                total = Convert.ToDouble(txtTotalVentaVentaCliente.Text); //total del auto
                pago = Convert.ToDouble(txtPrecioVentaVentaClientes.Text); //total con el que paga cliente

                if (total > pago)
                {
                    MessageBox.Show("Favor de ingresar la cantidad correcta");
                    txtPrecioVentaVentaClientes.Text = "";
                    txtPrecioVentaVentaClientes.Focus();
                }

                else
                {
                    cambio = total - pago;//resultado
                    txtCambioVentaVentaCliente.Text = cambio.ToString();//resultado a mostrar en cambio
                    if (pkCliente == 0)
                    {
                        autos nAutos = autos.Getallautos(pkAuto);
                        objcliente.sNombre = nombre;//guardamos variables en objetos
                        objcliente.sDireccion = direccion;
                        objcliente.guardar(objcliente);
                        objventas.cliente_pkCliente = objcliente.pkCliente;
                        objventas.dCantidad = cambio;
                        objventas.sConcepto = conceptop;
                        objventas.auto_pkAuto = pkAuto;
                        objventas.guardar(objventas);
                        nAutos.bStatus = false;
                        objautos.guardar(nAutos);

                    }
                    else
                    {
                        autos nAutos = autos.Getallautos(pkAuto);
                        objventas.cliente_pkCliente = pkCliente;
                        objventas.dCantidad = cambio;
                        objventas.sConcepto = conceptop;
                        objventas.auto_pkAuto = pkAuto;
                        objventas.guardar(objventas);
                        nAutos.bStatus = false;
                        objautos.guardar(nAutos);

                    }

                    MessageBox.Show("Venta realizada exitosamente");
                    this.Close();
                    FrmAgregarCliente.DefInstance.Close();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos por llenar");
                this.Close();

            }
        }
    }
}