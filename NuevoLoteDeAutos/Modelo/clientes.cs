using System.Data.Entity;

namespace NuevoLoteDeAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("loteautos.clientes")]
    public partial class clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clientes()
        {
            propietarios = new HashSet<propietarios>();
            ventas = new HashSet<ventas>();
        }

        [Key]
        public int pkCliente { get; set; }

        [Required]
        [StringLength(150)]
        public string sNombre { get; set; }

        [Required]
        [StringLength(150)]
        public string sDireccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<propietarios> propietarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventas> ventas { get; set; }

        public void guardar(clientes nCliente, int pkGrupo = 0)//Agregamos primero la funcion para guardar un nuevo cliente
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nCliente.pkCliente > 0)
                    {
                        ctx.Entry(nCliente).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nCliente).State = EntityState.Added;
                    }
                    ctx.SaveChanges();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static List<clientes> getAll()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.clientes.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<clientes> BuscarPorApellidos(String valorBuscar)//funcion para buscar por apellido en nuestro catalogo de clientes
        {
            {
                try
                {
                    using (var ctx = new DataModel())
                    {
                        return ctx.clientes.Where(r => r.sNombre.Contains(valorBuscar)).ToList();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

        }
        public static clientes Getallclientes(int pkcliente)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.clientes.Where(r => r.pkCliente == pkcliente).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        /// <summary>
        /// eliminar un registro de la base de datos 
        /// </summary>
        /// <param name="pkusuario"></param>
        public void eliminar(int pkCliente)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    clientes user = ctx.clientes.Single(r => r.pkCliente == pkCliente);
                    ctx.Entry(user).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
    public enum TipoOperacion
    {
        NUEVO,
        ACTUALIZACION
    }

}

