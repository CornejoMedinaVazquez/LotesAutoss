namespace NuevoLoteDeAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("loteautos.propietarios")]
    public partial class propietarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public propietarios()
        {
            autos = new HashSet<autos>();
            this.bStatus = true;
        }

        [Key]
        public int pkPropietario { get; set; }

        [Required]
        [StringLength(150)]
        public string sNombre { get; set; }

        [StringLength(240)]
        public string sDireccion { get; set; }

        [StringLength(240)]
        public string sTelefono { get; set; }

        [StringLength(240)]
        public string sCorreo { get; set; }

        [StringLength(20)]
        public string iIfe { get; set; }

        [StringLength(240)]
        public string sFoto { get; set; }

        public bool bStatus { get; set; }

        public int? Cliente_pkCliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<autos> autos { get; set; }

        public virtual clientes clientes { get; set; }


        public static List<propietarios> BuscarPorNombreUsuario(string letra, Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.Where(r => r.sNombre.Contains(letra) && r.bStatus == status).ToList(); 
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<propietarios> getAll(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.Where(r => r.bStatus == status).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<propietarios> BuscarPorNoPropietario(string ValorABuscar)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.Where(r => r.sNombre.Contains(ValorABuscar)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void eliminar(int pkPropietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    propietarios user = ctx.propietarios.Single(r => r.pkPropietario == pkPropietario);
                    ctx.Entry(user).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void guardar(propietarios nPropietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nPropietario.pkPropietario > 0)
                    {
                        ctx.Entry(nPropietario).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nPropietario).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void modificar(propietarios propietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.propietarios.Attach(propietario);
                    ctx.Entry(propietario).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static propietarios Getallprpo(int pkPropietario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.propietarios.Where(r => r.pkPropietario == pkPropietario).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
