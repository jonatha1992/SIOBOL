using Abstraccion;
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
    public class MPPPersona : IGestor<BEPersona>
    {
        Conexion conexion = new Conexion();
        public BEPersona Agregar(BEPersona bEPersona)
        {
            string consulta = "SELECT agregar_persona(@p_nombrecompleto, @p_dni, @p_domicilio, @p_ocupacion, @p_telefono)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                 {
                new NpgsqlParameter("p_nombrecompleto", bEPersona.NombreCompleto),
                new NpgsqlParameter("p_dni", bEPersona.DNI),
                new NpgsqlParameter("p_domicilio", string.IsNullOrEmpty(bEPersona.Domicilio) ? DBNull.Value : (object)bEPersona.Domicilio ),
                new NpgsqlParameter("p_ocupacion", string.IsNullOrEmpty(bEPersona.Ocupacion) ? DBNull.Value : (object)bEPersona.Ocupacion ),
                new NpgsqlParameter("p_telefono", string.IsNullOrEmpty(bEPersona.Telefono) ? DBNull.Value : (object)bEPersona.Telefono )
                };

            // Llamar al método Agregar para ejecutar el procedimiento almacenado
            int? nuevoId = conexion.Agregar(consulta, parametros);

            if (nuevoId != null)
            {
                bEPersona.Id = (int)nuevoId;
            }

            return bEPersona;
        }


        public bool Actualizar(BEPersona pPersona)
        {
            string consulta = "actualizar_persona";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                    new NpgsqlParameter("p_id", pPersona.Id),
                    new NpgsqlParameter("p_nombrecompleto", pPersona.NombreCompleto),
                    new NpgsqlParameter("p_dni", pPersona.DNI),
                    new NpgsqlParameter("p_domicilio", string.IsNullOrEmpty(pPersona.Domicilio) ? DBNull.Value : (object)pPersona.Domicilio ),
                    new NpgsqlParameter("p_ocupacion", string.IsNullOrEmpty(pPersona.Ocupacion) ? DBNull.Value : (object)pPersona.Ocupacion ),
                    new NpgsqlParameter("p_telefono", string.IsNullOrEmpty(pPersona.Telefono) ? DBNull.Value : (object)pPersona.Telefono )
                    };
            return conexion.Actualizar(consulta, parametros);
        }

        public bool Eliminar(BEPersona pPersona)
        {
               string consulta = "eliminar_persona";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                  new NpgsqlParameter("p_id",  pPersona.Id )
            };
            return conexion.Eliminar(consulta, parametros);
        }

        public List<BEPersona> ListarTodo()
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_personas(NULL)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>(); // No hay parámetros en este caso

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            List<BEPersona> ListaPersonas = new List<BEPersona>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEPersona persona = new BEPersona();
                    persona.Id = Convert.ToInt32(fila["Id"]);
                    persona.NombreCompleto = fila["NombreCompleto"].ToString();
                    persona.DNI = fila["DNI"].ToString();
                    persona.Telefono = fila["Telefono"].ToString();
                    persona.Domicilio = fila["Domicilio"].ToString();
                    persona.Ocupacion = fila["Ocupacion"].ToString();
                    ListaPersonas.Add(persona);
                }
            }
            else
            {
                ListaPersonas = null;
            }

            return ListaPersonas;
        }


        public BEPersona ListarObjeto(BEPersona pPersona)
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_personas(@p_id)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter> { new NpgsqlParameter("p_id", pPersona.Id) };

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            if (Tabla.Rows.Count > 0)
            {
                DataRow fila = Tabla.Rows[0];
                pPersona.Id = Convert.ToInt32(fila["Id"]);
                pPersona.NombreCompleto = fila["NombreCompleto"].ToString();
                pPersona.DNI = fila["DNI"].ToString();
                pPersona.Telefono = fila["Telefono"].ToString();
                pPersona.Domicilio = fila["Domicilio"].ToString();
                pPersona.Ocupacion = fila["Ocupacion"].ToString();
            }
            else
            {
                pPersona = null;
            }
            return pPersona;
        }


        public bool AgregarPersonaHallazgo(BEHallazgo hallazgo, BEPersona ePersona)
        {

            string consulta = "AgregarPersonaHallazgo";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                new NpgsqlParameter("@p_id_hallazgo", hallazgo.Id),
                new NpgsqlParameter("@p_id_persona", ePersona.Id),
                new NpgsqlParameter("@p_id_estado", ePersona.EstadoPersona.Id)
                    };

            // Llamar al método Agregar para ejecutar el procedimiento almacenado
            bool resultado = conexion.Actualizar(consulta, parametros);

            return resultado;
        }


        public bool AgregarPersonaEntrega(BEEntrega entrega, BEPersona ePersona)
        {

            string consulta = " AgregarPersonaEntrega";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                new NpgsqlParameter("@p_id_entrega", entrega.Id),
                new NpgsqlParameter("@p_id_persona", ePersona.Id),
                new NpgsqlParameter("@p_id_estado", ePersona.EstadoPersona.Id)
                    };

            // Llamar al método Agregar para ejecutar el procedimiento almacenado
            bool resultado = conexion.Actualizar(consulta, parametros);

            return resultado;

        }


        public bool EliminarPersonaHallazgo(BEHallazgo hallazgo, BEPersona persona)
        {
            string consulta = " eliminar_persona_hallazgo";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                        new NpgsqlParameter("@p_id_persona", persona.Id),
                        new NpgsqlParameter("@p_id_hallazgo", hallazgo.Id)
                    };
                            // Llamar al método Agregar para ejecutar el procedimiento almacenado
            bool resultado = conexion.Eliminar(consulta, parametros);

            return resultado;

        }

        public bool EliminarPersonaEntrega(BEEntrega entrega, BEPersona persona)
        {
            string consulta = " eliminar_persona_entrega";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                    new NpgsqlParameter("@p_id_persona", persona.Id),
                    new NpgsqlParameter("@p_id_entrega", entrega.Id)
                    };

            // Llamar al método Eliminar para ejecutar el procedimiento almacenado
            bool resultado = conexion.Eliminar(consulta, parametros);

            return resultado;

        }

    }
}
