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
    public class MPPJerarquia : IGestor<BEJerarquia>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BEJerarquia Object)
        {
            throw new NotImplementedException();
        }

        public BEJerarquia Agregar(BEJerarquia Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEJerarquia Object)
        {
            throw new NotImplementedException();
        }

        public BEJerarquia ListarObjeto(BEJerarquia jerarquia)
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_jerarquias(@p_id)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("@p_id", jerarquia.Id)
                };

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);
          ;
            // Comprobar si se encontraron resultados
            if (Tabla.Rows.Count == 1)
            {
                DataRow fila = Tabla.Rows[0];

                jerarquia.Jerarquia = fila["Nombre"].ToString();
                jerarquia.Abreviatura = fila["Abreviatura"].ToString();
            }

            return jerarquia;
        }

        public List<BEJerarquia> ListarTodo()
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_jerarquias(NULL)";

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, null);

            List<BEJerarquia> lista = new List<BEJerarquia>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEJerarquia jeraquia = new BEJerarquia
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Jerarquia = fila["Nombre"].ToString(),
                    Abreviatura = fila["Abreviatura"].ToString(),
                };
                lista.Add(jeraquia);
            }

            return lista;
        }
    }
}
