namespace NuevoLoteDeAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;
    using System.Data.Entity;

    [Table("loteautos.roles")]
    public partial class roles
    {
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public roles()
        {
            this.bStatus = true;
            permisosnegadosrol = new HashSet<permisosnegadosrol>();
            usuarios = new HashSet<usuarios>();

            
        }
        
        [Key]
        public int pkRol { get; set; }

        [Required]
        [StringLength(100)]
        public string sNombre { get; set; }

        public bool bStatus { get; set; }

        [StringLength(1073741823)]
        public string sDescripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<permisosnegadosrol> permisosnegadosrol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuarios> usuarios { get; set; }

        public static List<roles> getAll(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.Where(r => r.bStatus == status).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static roles BuscarGrupoPorID(int pkGrupo)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.Where(r => r.pkRol == pkGrupo).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void guardar(roles nroles)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nroles.pkRol > 0)
                    {
                        ctx.Entry(nroles).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nroles).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<roles> BuscarPorNombreRo(string letra, Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.Where(r => r.sNombre.Contains(letra) && r.bStatus == status).ToList();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void eliminar(int pkRol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    roles user = ctx.roles.Single(r => r.pkRol == pkRol);
                    ctx.Entry(user).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<roles> BuscarPorNombreRol(string ValorABuscar)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.Where(r => r.sNombre.Contains(ValorABuscar)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void modificar(roles nrol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.roles.Attach(nrol);
                    ctx.Entry(nrol).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static roles Getallrol(int pkrol)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.Where(r => r.pkRol == pkrol).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
