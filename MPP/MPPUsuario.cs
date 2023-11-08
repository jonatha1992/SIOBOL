using BE;
using DAL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;

namespace MPP
{
    public class MPPUsuario
    {
        Conexion conexion = new Conexion();


        public BEUsuario Agregar(BEUsuario NuevoUser)
        {
            string consulta = "SELECT agregar_usuario(@p_nombrecompleto, @p_nombreusuario, @p_id_unidad, @p_id_ursa, @p_dni, @p_password)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_nombrecompleto", NuevoUser.NombreCompleto),
                    new NpgsqlParameter("p_nombreusuario", NuevoUser.NombreUsuario),
                    new NpgsqlParameter("p_dni", NuevoUser.DNI),
                    new NpgsqlParameter("p_password", NuevoUser.Password),
                };


            if (NuevoUser.Destino is BEUnidad)
            {
                parametros.Add(new NpgsqlParameter("p_id_unidad", NuevoUser.Destino.Id));
                parametros.Add(new NpgsqlParameter("p_id_ursa", DBNull.Value));
            }
            if (NuevoUser.Destino is BEUrsa)
            {
                parametros.Add(new NpgsqlParameter("p_id_unidad", DBNull.Value));
                parametros.Add(new NpgsqlParameter("p_id_ursa", NuevoUser.Destino.Id));
            }


            int? nuevoId = conexion.Agregar(consulta, parametros);

            if (nuevoId != null)
            {
                NuevoUser.Id = (int)nuevoId;
            }

            return NuevoUser;
        }


        public bool Actualizar(BEUsuario pUsuario)
        {
            try
            {
                //BEUnidad unidad = null;
                //BEUrsa ursa = null;

                //if (pUsuario.Destino is BEUnidad)
                //{
                //    unidad = (BEUnidad)pUsuario.Destino;
                //}
                //else
                //{
                //    ursa= (BEUrsa)pUsuario.Destino;
                //}


                string consulta = "public.actualizar_usuario";


                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                    new NpgsqlParameter("p_id", pUsuario.Id),
                    new NpgsqlParameter("p_nombrecompleto", pUsuario.NombreCompleto),
                    new NpgsqlParameter("p_nombreusuario", pUsuario.NombreUsuario),
                    new NpgsqlParameter("p_dni", pUsuario.DNI),
                    new NpgsqlParameter("p_password", pUsuario.Password),
                    };

                if (pUsuario.Destino is BEUnidad)
                {
                    parametros.Add(new NpgsqlParameter("p_id_unidad", pUsuario.Destino.Id));
                    parametros.Add(new NpgsqlParameter("p_id_ursa", DBNull.Value));

                }
                if (pUsuario.Destino is BEUrsa)
                {
                    parametros.Add(new NpgsqlParameter("p_id_unidad", DBNull.Value));
                    parametros.Add(new NpgsqlParameter("p_id_ursa", pUsuario.Destino.Id));
                }
                return conexion.Actualizar(consulta, parametros);


            }
            catch (Exception ex)
            {
                throw new Exception($"{ex.Message}");
            }
        }
        public bool Eliminar(BEUsuario user)
        {
            string consulta = "eliminar_usuario";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                  new NpgsqlParameter("p_id",  user.Id )
            };
            return conexion.Eliminar(consulta, parametros);
        }

        public bool GuardarPermisosUsuario(BEUsuario oBEUsu)
        {
            string consulta = "agregar_rol_usuario";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_idusuario", oBEUsu.Id),
                    new NpgsqlParameter("@p_idroles",oBEUsu.Permisos.Select(hijo => hijo.Id).ToArray())
                };
            conexion.Actualizar(consulta, parametros);

            return true;
        }

        public List<BEUsuario> ListarTodo()
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_usuarios(NULL)";

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, null);

            List<BEUsuario> listaUsuarios = new List<BEUsuario>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEUsuario usuario = new BEUsuario
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    NombreUsuario = fila["NombreUsuario"].ToString(),
                    NombreCompleto = fila["NombreCompleto"].ToString(),
                    Password = fila["Password"].ToString(),
                    DNI = fila["DNI"].ToString(),
                    Destino = ObtenerDestino(fila) // Asegúrate de que este método esté implementado correctamente
                };
                listaUsuarios.Add(usuario);
            }

            return listaUsuarios;
        }

        private BEDestino ObtenerDestino(DataRow fila)
        {
            // Asumiendo que BEDestino es una clase base y BEUrsa y BEUnidad son clases derivadas
            // y que tienes campos llamados IdUrsa e IdUnidad en tu tabla de base de datos.

            if (fila["IdUrsa"] != DBNull.Value)
            {
                return new BEUrsa(Convert.ToInt32(fila["IdUrsa"]));
            }
            else if (fila["IdUnidad"] != DBNull.Value)
            {
                return new BEUnidad(Convert.ToInt32(fila["IdUnidad"]));
            }
            else
            {
                return null;
            }
        }



        public BEUsuario ListarObjeto(BEUsuario usuario)
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_usuarios(@p_id)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                new NpgsqlParameter("p_id", usuario.Id)
            };

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            if (Tabla.Rows.Count == 0) return null;

            DataRow fila = Tabla.Rows[0];
            BEUsuario beUsuario = new BEUsuario
            {
                Id = Convert.ToInt32(fila["Id"]),
                NombreUsuario = fila["NombreUsuario"].ToString(),
                NombreCompleto = fila["NombreCompleto"].ToString(),
                Password = fila["Password"].ToString(),
                DNI = fila["DNI"].ToString(),
                Destino = ObtenerDestino(fila)
            };
            return beUsuario;
        }

    }
}
