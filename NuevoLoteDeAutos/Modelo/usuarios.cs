namespace NuevoLoteDeAutos.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("loteautos.usuarios")]
    public partial class usuarios
    {
        public usuarios()
        {
            this.bStatus = true;
        }
            
        [Key]
        public int pkUsuario { get; set; }

        [Required]
        [StringLength(100)]
        public string sEmail { get; set; }

        [StringLength(140)]
        public string sPassword { get; set; }

        public bool bStatus { get; set; }

        public int? rol_pkRol { get; set; }

        public virtual roles roles { get; set; }

        /// <summary>
        ///funion que permite buscar 
        /// </summary>
        /// <param name="letra"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public static List<usuarios> BuscarPorNombreUsuario(string letra, Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Where(r => r.sEmail.Contains(letra) && r.bStatus == status).ToList();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
      
        public static List<usuarios> BuscarPorNombreUsuari(string ValorABuscar)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Where(r => r.sEmail.Contains(ValorABuscar)).ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static List<usuarios> getAll(Boolean status)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Where(r => r.bStatus == status).ToList();
                }
            }
            catch (Exception)
            {


                throw;
            }
        }

        public void guardar(usuarios nusuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    if (nusuario.pkUsuario > 0)
                    {
                        ctx.Entry(nusuario).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(nusuario).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// funcion que te permite buscar un usuario por su primeri key
        /// </summary>
        /// <param name="pkusuario"></param>
        /// <returns></returns>
        public static usuarios GetallUsuarios(int pkusuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    return ctx.usuarios.Where(r => r.pkUsuario == pkusuario).FirstOrDefault();
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
        public void eliminar(int pkUsuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    usuarios user = ctx.usuarios.Single(r => r.pkUsuario == pkUsuario);
                    ctx.Entry(user).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void modificar(usuarios nusuario)
        {
            try
            {
                using (var ctx = new DataModel())
                {
                    ctx.usuarios.Attach(nusuario);
                    ctx.Entry(nusuario).State = EntityState.Modified;
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
