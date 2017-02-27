namespace NuevoLoteDeAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("loteautos.permisosnegadosrol")]
    public partial class permisosnegadosrol
    {
        public permisosnegadosrol()
        {
            this.bStatus = true;
        }
        [Key]
        public int pkPermisoNegadoRol { get; set; }

        public bool bStatus { get; set; }

        public int? permiso_pkPermiso { get; set; }

        public int? rol_pkRol { get; set; }

        public virtual permisos permisos { get; set; }

        public virtual roles roles { get; set; }

        public static List<permisos> getAll(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.permisos.ToList();
                }
            }
            catch (Exception)
            {


                throw;
            }
        }
        public static List<roles> getAll2(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.roles.ToList();
                }
            }
            catch (Exception)
            {


                throw;
            }
        }

        public void guardar(permisosnegadosrol nrp)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nrp.pkPermisoNegadoRol > 0)
                    {
                        ctx.Entry(nrp).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nrp).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<permisosnegadosrol> datos()
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.permisosnegadosrol.ToList();
                }
            }
            catch (Exception)
            {


                throw;
            }
        }
        public void eliminar(int pkUsupkPermisoNegadoRolario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    permisosnegadosrol user = ctx.permisosnegadosrol.Single(r => r.pkPermisoNegadoRol == pkUsupkPermisoNegadoRolario);
                    ctx.Entry(user).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void modificar(permisosnegadosrol npe)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.permisosnegadosrol.Attach(npe);
                    ctx.Entry(npe).State = EntityState.Modified;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
