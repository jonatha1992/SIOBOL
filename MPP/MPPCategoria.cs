using Abstraccion;
using BE;
using DAL;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace MPP
{
    public class MPPCategoria : IGestor<BECategoria>
    {
        Conexion conexion = new Conexion();
        public bool Actualizar(BECategoria Object)
        {

            string consulta = "actualizar_categoria";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                        new NpgsqlParameter("p_nombre", Object.Nombre)
                     };

            return conexion.Actualizar(consulta, parametros);
        }

        public BECategoria Agregar(BECategoria Object)
        {

            // Preparar la consulta y los parámetros 
            string consulta = "select agregar_categoria(@nombre)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                 new NpgsqlParameter("nombre", Object.Nombre),
            };

            // Llamar al método Eliminar para ejecutar el procedimiento almacenado
            int? nuevoId = conexion.Agregar(consulta, parametros);

            if (nuevoId != null)
            {
                Object.Id = (int)nuevoId;
            }
            else
            {
                // Manejar el caso en que la inserción no fue exitosa
                throw new Exception("Error al agregar el artículo.");
            }
            return Object;
        }

        public bool Eliminar(BECategoria Object)
        {
          
            string consulta = "eliminar_articulo";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                  new NpgsqlParameter("p_id",  Object.Id )
            };
            return conexion.Eliminar(consulta, parametros);
        }

        public BECategoria ListarObjeto(BECategoria bCategoria)
        {
            DataTable Tabla;
            MPPArticulo mPPArticulo = new MPPArticulo();
            var articulos = mPPArticulo.ListarTodo();
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter> { new NpgsqlParameter("p_id", bCategoria.Id) };

            Tabla = conexion.Listar("SELECT * FROM  listar_categorias(@p_id)", parametros);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    bCategoria.Nombre = fila["Nombre"].ToString();
                }
            }
            bCategoria.Articulos = articulos.FindAll(x => x.Categoria.Id == bCategoria.Id);
            return bCategoria;
        }
        public List<BECategoria> ListarTodo()
        {

            DataTable Tabla;

            Tabla = conexion.Listar("SELECT * FROM listar_categorias(NULL)", null);
            List<BECategoria> ListaCategorias= new List<BECategoria>();

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BECategoria bECategoria = new BECategoria();
                    bECategoria.Id = Convert.ToInt32(fila["Id"]);
                    bECategoria.Nombre = fila["Nombre"].ToString();
                    ListaCategorias.Add(bECategoria);
                }
            }
            else
            {
                ListaCategorias = null;
            }
            return ListaCategorias;

        }
    }

}
