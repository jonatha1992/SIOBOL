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
    public class MPPUnidad : IGestor<BEUnidad>
    {
        Conexion conexion = new Conexion();

        public bool Actualizar(BEUnidad Object)
        {
            throw new NotImplementedException();
        }

        public BEUnidad Agregar(BEUnidad Object)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(BEUnidad Object)
        {
            throw new NotImplementedException();
        }

        public BEUnidad ListarObjeto(BEUnidad Punidad)
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM listar_unidades(@p_id)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter> { new NpgsqlParameter("p_id", Punidad.Id) };

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            if (Tabla.Rows.Count > 0)
            {
                DataRow fila = Tabla.Rows[0];
                Punidad.Id = Convert.ToInt32(fila["id"]);
                Punidad.Nombre = fila["nombre"].ToString();
                Punidad.Cod = fila["cod"].ToString();
                Punidad.Ursa = new BEUrsa(Convert.ToInt32(fila["idursa"]), fila["ursanombre"].ToString());
            }
            else
            {
                Punidad = null;
            }
            return Punidad;

        }

        public List<BEUnidad> ListarTodo()
        {
            DataTable Tabla;

            // Ejecutar el procedimiento almacenado
            Tabla = conexion.Listar("SELECT * FROM listar_unidades(NULL)", null);

            List<BEUnidad> ListaUnidades = new List<BEUnidad>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEUnidad bEUnidad = new BEUnidad();
                    bEUnidad.Id = Convert.ToInt32(fila["id"]);
                    bEUnidad.Nombre = fila["nombre"].ToString();
                    bEUnidad.Cod = fila["cod"].ToString();
                    bEUnidad.Ursa = new BEUrsa(Convert.ToInt32(fila["idursa"]), fila["ursanombre"].ToString());
                    ListaUnidades.Add(bEUnidad);
                }
            }
            else
            {
                ListaUnidades = null;
            }
            return ListaUnidades;
        }
    }
}
