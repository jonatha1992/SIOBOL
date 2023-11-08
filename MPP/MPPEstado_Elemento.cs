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
    public class MPPEstado_Elemento : IGestor<BEEstado_Elemento>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }
        public BEEstado_Elemento Agregar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEEstado_Elemento Object)
        {
            throw new NotImplementedException();
        }

        public BEEstado_Elemento ListarObjeto(BEEstado_Elemento BEntidad)
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_estado_elementos(@p_id)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                 {
                    new NpgsqlParameter("p_id", BEntidad.Id)
                };

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            if (Tabla.Rows.Count == 0) return null;

            DataRow fila = Tabla.Rows[0];
            BEEstado_Elemento estadoElemento = new BEEstado_Elemento
            {
                Id = Convert.ToInt32(fila["Id"]),
                Nombre = fila["Nombre"].ToString(),
            };

            return estadoElemento;
        }

        public List<BEEstado_Elemento> ListarTodo()
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_estado_elementos(NULL)";

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, null);

            List<BEEstado_Elemento> lista = new List<BEEstado_Elemento>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEEstado_Elemento estadoElemento = new BEEstado_Elemento
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Nombre = fila["Nombre"].ToString(),
                };
                lista.Add(estadoElemento);
            }

            return lista;
        } 
        

    }
}
