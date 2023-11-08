using BE;
using DAL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Xml.Linq;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace MPP
{
    public class MPPBitacora
    {
        Conexion conexion;

        public MPPBitacora()
        {
            conexion = new Conexion();
        }

        public List<BEEvento> ListarTodo()
        {

            DataTable Tabla;
            Tabla = conexion.Listar("SELECT * FROM listar_eventos(NULL)", null);
            List<BEEvento> ListaEventos = new List<BEEvento>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEEvento bEEvento = new BEEvento();
                    bEEvento.Id = Convert.ToInt32(fila["Id"]);
                    bEEvento.Fecha = Convert.ToDateTime(fila["Fecha"]);
                    bEEvento.Usuario = fila["Usuario"].ToString();
                    bEEvento.Mensaje = fila["Mensaje"].ToString();
                    ListaEventos.Add(bEEvento);
                }
            }
            else
            {
                ListaEventos = null;
            }
            return ListaEventos;

        }

        public void RegistrarEvento(BEEvento bEEvento)
        {
            string consulta = "SELECT agregar_evento(@p_fecha,@p_mensaje, @p_usuario)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                 new NpgsqlParameter("p_fecha", bEEvento.Fecha),
                 new NpgsqlParameter("p_mensaje", bEEvento.Mensaje),
                 new NpgsqlParameter("p_usuario", bEEvento.Usuario)
            };

            // Llamar al método Eliminar para ejecutar el procedimiento almacenado
             conexion.Agregar(consulta, parametros);

        }




    }
}
