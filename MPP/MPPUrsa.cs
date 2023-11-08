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
    public class MPPUrsa : IGestor<BEUrsa>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BEUrsa Object)
        {
            throw new NotImplementedException();
        }

        public BEUrsa Agregar(BEUrsa Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEUrsa Object)
        {
            throw new NotImplementedException();
        }


        public BEUrsa ListarObjeto(BEUrsa pursa)
        {
            DataTable Tabla;
            MPPUnidad mPPUnidad = new MPPUnidad();
            var unidadades = mPPUnidad.ListarTodo();
            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_ursas(@p_id)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter> {new NpgsqlParameter("p_id", pursa.Id) };

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            if (Tabla.Rows.Count == 0) return null;
            DataRow fila = Tabla.Rows[0];
            pursa.Nombre = fila["Nombre"].ToString();

            pursa.Unidades = unidadades.FindAll(x => x.Ursa.Id == pursa.Id);

            return pursa;

        }
        public List<BEUrsa> ListarTodo()
        {
            DataTable Tabla;
            
            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_ursas(NULL)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>();

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            List<BEUrsa> lista = new List<BEUrsa>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEUrsa ursa = new BEUrsa
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Nombre = fila["Nombre"].ToString(),
                };
                lista.Add(ursa);
            }

            return lista;
        }
    }
}
