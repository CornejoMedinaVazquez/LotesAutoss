namespace NuevoLoteDeAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.Entity;
    using System.Linq;

    [Table("loteautos.ventas")]
    public partial class ventas
    {
        [Key]
        public int pkVenta { get; set; }

        [Required]
        [StringLength(150)]
        public string sConcepto { get; set; }

        public double dCantidad { get; set; }

        public int? auto_pkAuto { get; set; }

        public int? cliente_pkCliente { get; set; }

        public virtual autos autos { get; set; }

        public virtual clientes clientes { get; set; }

        public void guardar(ventas nVentas, int pkVentas = 0)//Agregamos primero la funcion para guardar un nuevo cliente
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    autos nautos = new autos();
                    clientes nclientes = new clientes();
                    if (nVentas.pkVenta > 0)
                    {
                        ctx.Entry(nVentas).State = EntityState.Modified;

                    }
                    else
                    {
                        ctx.Entry(nVentas).State = EntityState.Added;
                    }
                    ctx.SaveChanges();



                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<ventas> BuscarPorConcepto(String valorBuscar)//funcion para buscar por apellido en nuestro catalogo de clientes
        {
            {
                try
                {
                    using (var ctx = new DataModel())
                    {
                        return ctx.ventas.Where(r => r.sConcepto.Contains(valorBuscar)).ToList();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
    }
}