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
    public class MPPArticulo : IGestor<BEArticulo>
    {
        Conexion conexion = new Conexion();

        public BEArticulo Agregar(BEArticulo Object)
        {
            // Preparar la consulta y los parámetros 
            string consulta = "select agregar_articulo(@nombre,@idcategoria)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                 new NpgsqlParameter("nombre", Object.Nombre),
                 new NpgsqlParameter("idcategoria", Object.Categoria.Id)
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
        public bool Eliminar(BEArticulo Object)
        {
            string consulta = "eliminar_articulo";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                  new NpgsqlParameter("p_id",  Object.Id )
            };
            return conexion.Eliminar(consulta, parametros);
        }

        public bool Actualizar(BEArticulo Object)
        {
            string consulta = "actualizar_articulo";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                        new NpgsqlParameter("p_id", Object.Id),
                        new NpgsqlParameter("p_nombre", Object.Nombre),
                        new NpgsqlParameter("p_idcategoria", Object.Categoria.Id)
                     };

            return conexion.Actualizar(consulta, parametros);
        }


        public BEArticulo ListarObjeto(BEArticulo pArticulo)
        {
            DataTable Tabla;
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter> { new NpgsqlParameter("p_id", pArticulo.Id) };

            Tabla = conexion.Listar("SELECT * FROM  listar_articulos(@p_id)", parametros);

            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {

                    pArticulo.Nombre = fila["Nombre"].ToString();
                    pArticulo.Categoria = new BECategoria(Convert.ToInt32(fila["IdCategoria"]), fila["CategoriaNombre"].ToString());

                }

            }
            return pArticulo;
        }

        public List<BEArticulo> ListarTodo()
        {
            DataTable Tabla;

            Tabla = conexion.Listar("SELECT * FROM listar_articulos(NULL)", null);
            List<BEArticulo> ListaArticulos = new List<BEArticulo>();


            //var ListaArticulos2 = Tabla.AsEnumerable().Select(fila => new BEArticulo
            //{
            //    Id = fila.Field<int>("id"),
            //    Nombre = fila.Field<string>("Nombre"),
            //    Categoria = new BECategoria(fila.Field<int>("idcategoria"), fila.Field<string>("categorianombre"))

            //}).ToList();


            if (Tabla.Rows.Count > 0)
            {
                foreach (DataRow fila in Tabla.Rows)
                {
                    BEArticulo bEArticulo = new BEArticulo();
                    bEArticulo.Id = Convert.ToInt32(fila["Id"]);
                    bEArticulo.Nombre = fila["Nombre"].ToString();
                    bEArticulo.Categoria = new BECategoria(Convert.ToInt32(fila["IdCategoria"]), fila["CategoriaNombre"].ToString());
                    ListaArticulos.Add(bEArticulo);
                }
            }

            else
            {
                ListaArticulos = null;
            }
            return ListaArticulos;
        }
    }
}
