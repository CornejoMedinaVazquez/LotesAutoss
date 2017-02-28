using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuevoLoteDeAutos.Modelo;

namespace NuevoLoteDeAutos.Controlador
{
    public class ManejoSesion
    {
        public static SessiononHelper Login(string User, string Password)
        {
            SessiononHelper objSession = new SessiononHelper();
            try
            {
                using (var ctx = new DataModel())
                {
                    usuarios user = ctx.usuarios.Include("roles")
                        .Include("roles.permisosnegadosrol")
                        .Where(r => r.sEmail == User && r.bStatus == true).FirstOrDefault();

                    if (user != null)
                    {
                        if (user.sPassword == Password)
                        {
                            objSession.isValid = true;
                            objSession.usuario = user;
                        }

                    }
                }
                return objSession;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public class SessiononHelper
        {
            public Boolean isValid { get; set; }
            public usuarios usuario { get; set; }
            public string msgError { get; set; }

            public Boolean tienepermiso(int validarpermiso)
            {
                Boolean tiene = false;

                if (isValid)
                {
                    try
                    {
                        using (var ctx = new DataModel())
                        {
                            permisosnegadosrol pNegado =
                                usuario.roles.permisosnegadosrol.Where(r => r.permiso_pkPermiso == validarpermiso)
                                    .FirstOrDefault();
                            if (pNegado == null) tiene = true;

                        }
                        return tiene;
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                else
                {
                    return tiene;
                }
            }

            public SessiononHelper()
            {
                this.isValid = false;
                this.usuario = null;
                this.msgError = "Datos incorrectos favor de intentar de nuevo";
            }
        }
    }

    public enum enumPermisosActivos
    {
        PROPIETARIOYAUTO = 1,
        CLIENTE = 2,
        USUARIO = 3,
        CATALOGOVENTAS = 4,
        PERMISOSPORROL = 5,
        ROL = 6,

        btnEliminarAuto = 7
      
        
    }
}

