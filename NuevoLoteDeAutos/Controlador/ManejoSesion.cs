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
        ADMINUSTRADOR_PROPIETARIOAUTO = 1,
        ADMINUSTRADOR_COMPRADOR = 2,
        ADMINUSTRADOR_VENDEDOR = 3,
        //================================
        VENDEDOR_PROPIETARIOAUTO = 4,
        VENDEDOR_COMPRADOR = 5,
        VENDEDOR_VENDEDOR = 6,
        //===========================
        GERENTE_PROPIETARIOAUTO = 7,
        GERENTE_COMPRADOR = 8,
        GERENTE_VENDEDOR = 9
    }
}

