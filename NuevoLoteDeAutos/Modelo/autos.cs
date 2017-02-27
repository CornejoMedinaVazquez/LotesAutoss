using System.Data.Entity;

namespace NuevoLoteDeAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Data.Entity;

    using System.Linq;

    [Table("loteautos.autos")]
    public partial class autos
    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public autos()
        {
            ventas = new HashSet<ventas>();
            this.bStatus = true;
        }

        [Key]
        public int pkAuto { get; set; }

        [Required]
        [StringLength(150)]
        public string sMarca { get; set; }

        public int iAnio { get; set; }

        [StringLength(150)]
        public string sPlaca { get; set; }

        public int iPrecio { get; set; }

        [StringLength(150)]
        public string sColor { get; set; }

        [StringLength(150)]
        public string sNacionalidad { get; set; }

        public int iSerie { get; set; }

        [StringLength(150)]
        public string foto1 { get; set; }

        [StringLength(150)]
        public string foto2 { get; set; }

        [StringLength(150)]
        public string foto3 { get; set; }

        public bool bStatus { get; set; }

        public int? Propietario_pkPropietario { get; set; }

        public virtual propietarios propietarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventas> ventas { get; set; }


        public void guardar(autos nAuto, int pkAuto = 0)//Agregamos primero la funcion para guardar un nuevo cliente
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nAuto.pkAuto > 0)
                    {
                        ctx.Entry(nAuto).State = EntityState.Modified;
                    }
                    else
                    {
                        nAuto.bStatus = true;
                        ctx.Entry(nAuto).State = EntityState.Added;

                    }
                    ctx.SaveChanges();


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<autos> BuscarPorMarcayalta(String valorBuscar, Boolean status)//funcion para buscar por marca en nuestro catalogo de autos
        {
            {
                try
                {
                    using (var ctx = new DataModel())
                    {
                        return ctx.autos.Where(r => r.sMarca.Contains(valorBuscar) && r.bStatus == status).ToList();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
        public static autos Getallautos(int pkautos)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.autos.Where(r => r.pkAuto == pkautos).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void eliminar(int pkAuto)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    autos user = ctx.autos.Single(r => r.pkAuto == pkAuto);
                    ctx.Entry(user).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<autos> BuscarPorSerie(string valorBuscar)//funcion para buscar por marca en nuestro catalogo de autos
        {
            {
                try
                {
                    using (var ctx = new DataModel())
                    {
                        return ctx.autos.Where(r => r.iSerie.ToString().Contains(valorBuscar)).ToList();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
        public static List<autos> BuscarPorMarca(String valorBuscar)//funcion para buscar por marca en nuestro catalogo de autos
        {
            {
                try
                {
                    using (var ctx = new DataModel())
                    {
                        return ctx.autos.Where(r => r.sMarca.Contains(valorBuscar)).ToList();
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