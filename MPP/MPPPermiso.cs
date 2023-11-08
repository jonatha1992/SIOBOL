using BE;
using DAL;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{

    public class MPPPermiso
    {

        Conexion conexion;

        public MPPPermiso()
        {
            conexion = new Conexion();
        }


        public BEComponente CrearComponente(BEComponente oComp, bool esrol)
        {

            string consulta = "SELECT crear_componente(@p_nombre, @p_espermiso)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
             new NpgsqlParameter("@p_nombre", oComp.Nombre),
             new NpgsqlParameter("@p_espermiso", esrol)
            };


            int? nuevoId = conexion.Agregar(consulta, parametros);

            if (nuevoId != null)
            {
                oComp.Id = (int)nuevoId;
            }

            return oComp;
        }

        public bool GuardarRol(BERol oBErol)
        {
            try
            {
                string consulta = "ActualizarPermisosRol";
                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                        new NpgsqlParameter("@p_id_rol", oBErol.Id),
                    };
                if (oBErol.Hijos != null || oBErol.Hijos.Count > 0) 
                {
                    parametros.Add(new NpgsqlParameter("@p_permisos", DBNull.Value));
                }
                else
                {
                    List<int> permisos = oBErol.Hijos.Select(hijo => hijo.Id).ToList();
                    parametros.Add(new NpgsqlParameter("@p_permisos",permisos.ToArray()));
                }
                   return conexion.Actualizar(consulta, parametros);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<BEPermiso> Listarpermisos()
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_permisos(NULL)";

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, null);

            List<BEPermiso> listaPermisos = new List<BEPermiso>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEPermiso permiso = new BEPermiso
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Nombre = fila["Nombre"].ToString(),
                    Descripcion = fila["Descripcion"].ToString(),
                };
                listaPermisos.Add(permiso);
            }

            return listaPermisos;
        }


        public List<BERol> ListarRoles()
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_roles(NULL)";

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, null);

            List<BERol> listaRoles = new List<BERol>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BERol rol = new BERol
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Nombre = fila["Nombre"].ToString(),
                };
                listaRoles.Add(rol);
            }

            return listaRoles;
        }

        public List<BEComponente> ObternerPermisosRol(BERol rol)
        {
            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM public.listar_permisos_rol(@IdRol)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>()
            {
                 new NpgsqlParameter("IdRol", rol.Id )
            };

            // Ejecutar la consulta
            DataTable Tabla = conexion.Listar(consulta, parametros);

            List<BEComponente> permisosLista = new List<BEComponente>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEComponente componente = new BEPermiso
                {
                    Id = Convert.ToInt32(fila["IdPermiso"]),
                    Nombre = fila["NombrePermiso"].ToString(),
                    Descripcion = fila["DescripcionPermiso"].ToString()
                };

                permisosLista.Add(componente);
            }

            return permisosLista;
        }

        public BEUsuario ObternerRolesUsuario(BEUsuario user)
        {
            DataTable tabla;
            string consulta = "SELECT * FROM listar_roles_usuario(@p_id_user)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                 new NpgsqlParameter("p_id_user", user.Id)
                };

            // Ejecutar la consulta
            tabla = conexion.Listar(consulta, parametros);

            // Limpiar la lista de permisos del usuario
            user.Permisos.Clear();

            foreach (DataRow fila in tabla.Rows)
            {
                BEComponente rol = new BERol
                {
                    Id = Convert.ToInt32(fila["IdRol"]),
                    Nombre = fila["NombreRol"].ToString(),
                };

                var permisos = ObternerPermisosRol(rol as BERol);

                foreach (var p in permisos)
                {
                    rol.AgregarHijo(p);
                }

                user.Permisos.Add(rol);
            }


            return user;
        }


        public bool EliminarRol(BERol bERol)
        {
            string consulta = "eliminar_rol";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                  new NpgsqlParameter("p_id",  bERol.Id )
            };
            return conexion.Eliminar(consulta, parametros);

        }
    }

}
