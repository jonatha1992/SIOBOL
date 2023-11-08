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
    public class MPPEstado_Persona : IGestor<BEEstado_Persona>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BEEstado_Persona Object)
        {
            throw new NotImplementedException();
        }

        public BEEstado_Persona Agregar(BEEstado_Persona Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEEstado_Persona Object)
        {
            throw new NotImplementedException();
        }


        //public BEEstado_Persona ListarObjeto(BEEstado_Persona pEstadoPersona)
        //{
        //    throw new NotImplementedException();
        //    //string Nodo = "Estado_Personas";
        //    //var Consulta = conexion.LeerTodos(Nodo).Descendants("Estado_Persona");

        //    //if (Consulta.Count() > 0)
        //    //{
        //    //    pEstadoPersona = (from x in Consulta
        //    //                      where Convert.ToInt32(x.Element("Id")?.Value) > 0
        //    //                      select new BEEstado_Persona
        //    //                      {
        //    //                          Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
        //    //                          Nombre = Convert.ToString(x.Element("Nombre")?.Value),
        //    //                      }).FirstOrDefault();

        //    //}
        //    //else
        //    //{ pEstadoPersona = null; }
        //    //return pEstadoPersona;
        //}
        //public List<BEEstado_Persona> ListarTodo()
        //{
        //    throw new NotImplementedException();
        //    //string Nodo = "Estado_Personas";
        //    //var Consulta = conexion.LeerTodos(Nodo).Descendants("Estado_Persona");


        //    //List<BEEstado_Persona> lista = new List<BEEstado_Persona>();

        //    //if (Consulta.Count() > 0)
        //    //{
        //    //    lista = (from x in Consulta
        //    //             where Convert.ToInt32(x.Element("Id")?.Value) > 0
        //    //             select new BEEstado_Persona
        //    //             {
        //    //                 Id = Convert.ToInt32(Convert.ToString(x.Element("Id")?.Value)),
        //    //                 Nombre = Convert.ToString(x.Element("Nombre")?.Value),
        //    //             }).ToList<BEEstado_Persona>(); ;
        //    //}
        //    //else
        //    //{
        //    //    lista = null;
        //    //}

        //    //return lista;
        //}

        public BEEstado_Persona ListarObjeto(BEEstado_Persona pEstadoPersona)
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_estado_personas(@p_id)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
        new NpgsqlParameter("p_id", pEstadoPersona.Id)
            };

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            if (Tabla.Rows.Count == 0) return null;

            DataRow fila = Tabla.Rows[0];
            BEEstado_Persona estadoPersona = new BEEstado_Persona
            {
                Id = Convert.ToInt32(fila["Id"]),
                Nombre = fila["Nombre"].ToString(),
            };

            return estadoPersona;
        }

        public List<BEEstado_Persona> ListarTodo()
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_estado_personas(NULL)";

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, null);

            List<BEEstado_Persona> lista = new List<BEEstado_Persona>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEEstado_Persona estadoPersona = new BEEstado_Persona
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Nombre = fila["Nombre"].ToString(),
                };
                lista.Add(estadoPersona);
            }

            return lista;
        }

    }
}
