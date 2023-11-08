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
    public class MPPInstructor : IGestor<BEInstructor>
    {
        Conexion conexion = new Conexion();



        public BEInstructor Agregar(BEInstructor pinstructor)
        {
            string consulta = "SELECT agregar_instructor(@p_nombrecompleto, @p_dni, @p_legajo, @p_id_jerarquia)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                     {
                        new NpgsqlParameter("p_nombrecompleto", pinstructor.NombreCompleto),
                        new NpgsqlParameter("p_dni", pinstructor.DNI),
                        new NpgsqlParameter("p_legajo", pinstructor.Legajo),
                        new NpgsqlParameter("p_id_jerarquia", pinstructor.Jerarquia.Id)
                    };

            // Llamar al método Agregar para ejecutar el procedimiento almacenado
            int? nuevoId = conexion.Agregar(consulta, parametros);

            if (nuevoId != null)
            {
                pinstructor.Id = (int)nuevoId;
            }

            return pinstructor;
        }



        public bool Actualizar(BEInstructor pinstructor)
        {
            string consulta = "actualizar_instructor";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                    new NpgsqlParameter("p_id", pinstructor.Id),
                    new NpgsqlParameter("p_legajo", pinstructor.Legajo),
                    new NpgsqlParameter("p_id_jerarquia", pinstructor.Jerarquia.Id),
                    };
            return conexion.Actualizar(consulta, parametros);

        }
        public bool Eliminar(BEInstructor Object)
        {
               string consulta = "eliminar_persona";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                  new NpgsqlParameter("p_id",  Object.Id )
            };
            return conexion.Eliminar(consulta, parametros);
        }

        public List<BEInstructor> ListarTodo()
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_instructores(NULL)";

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, null);

            List<BEInstructor> lista = new List<BEInstructor>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEInstructor instructor = new BEInstructor
                    {
                        Id = Convert.ToInt32(fila["Id"]),
                        NombreCompleto = fila["NombreCompleto"].ToString(),
                        DNI = fila["DNI"].ToString(),
                        Telefono = fila["Telefono"].ToString(),
                        Ocupacion = fila["Ocupacion"].ToString(),
                        Domicilio = fila["Domicilio"].ToString(),
                        Legajo = Convert.ToInt32(fila["Legajo"]),
                        Jerarquia = new BEJerarquia(Convert.ToInt32(fila["IdJerarquia"]), fila["NombreJerarquia"].ToString())
                    };

                    lista.Add(instructor);
                }
            }
            else
            {
                lista = null;
            }

            return lista;
        }


        public BEInstructor ListarObjeto(BEInstructor instructor)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_instructores(@p_id)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter> { new NpgsqlParameter("p_id", instructor.Id),
                        };

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            if (Tabla.Rows.Count == 1)
            {
                DataRow fila = Tabla.Rows[0];
                instructor = new BEInstructor
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    NombreCompleto = fila["NombreCompleto"].ToString(),
                    DNI = fila["DNI"].ToString(),
                    Telefono = fila["Telefono"].ToString(),
                    Ocupacion = fila["Ocupacion"].ToString(),
                    Domicilio = fila["Domicilio"].ToString(),
                    Legajo = Convert.ToInt32(fila["Legajo"]),
                    Jerarquia = new BEJerarquia(Convert.ToInt32(fila["IdJerarquia"]), fila["NombreJerarquia"].ToString())
                };
            }
            else
            {
                instructor = null;
            }
            return instructor;
        }
    }
}
