using Abstraccion;
using BE;
using DAL;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace MPP
{
    public class MPPElemento : IGestor<BEElemento>
    {
        Conexion conexion = new Conexion();

        public BEElemento Agregar(BEElemento pElemento)
        {
            throw new NotImplementedException();
        }

        public bool Agregar_Elemento_Hallazgo(BEHallazgo hallazgo, BEElemento elemento)
        {

            string consulta = "SELECT agregar_elemento(@p_id_hallazgo, @p_id_entrega, @p_id_articulo, @p_id_estado,@p_cantidad, @p_descripcion)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
                new NpgsqlParameter("p_id_hallazgo", hallazgo.Id),
                new NpgsqlParameter("p_id_entrega",  DBNull.Value ),
                new NpgsqlParameter("p_id_articulo", elemento.Articulo.Id),
                new NpgsqlParameter("p_id_estado", elemento.Estado.Id),
                new NpgsqlParameter("p_cantidad", elemento.Cantidad),
                new NpgsqlParameter("p_descripcion", elemento.Descripcion)
            };

            // Llamar al método Agregar para ejecutar el procedimiento almacenado
            int? nuevoId = conexion.Agregar(consulta, parametros);

            if (nuevoId != null)
            {
                elemento.Id = (int)nuevoId;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Agregar_Elemento_Entrega(BEEntrega entrega, BEElemento elemento)
        {
            string consulta = "agregar_elemento_entrega";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                        new NpgsqlParameter("p_id", elemento.Id),
                        new NpgsqlParameter("p_id_entrega", entrega.Id),
                        new NpgsqlParameter("p_id_estado", elemento.Estado.Id)
                    };
            return conexion.Actualizar(consulta, parametros);
        }



        public bool Eliminar_Elemento_Entrega(BEElemento elemento)
        {
            string consulta = "eliminar_elemento_entrega";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                        new NpgsqlParameter("p_id", elemento.Id),
                        new NpgsqlParameter("p_id_estado", elemento.Estado.Id)
                    };

            return conexion.Actualizar(consulta, parametros);

        }
       

        public bool Actualizar(BEElemento pElemento)
        {
            string consulta = "actualizar_elemento";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                        new NpgsqlParameter("p_id", pElemento.Id),
                        new NpgsqlParameter("p_id_articulo", pElemento.Articulo.Id),
                        new NpgsqlParameter("p_id_estado", pElemento.Estado.Id),
                        new NpgsqlParameter("p_cantidad", pElemento.Cantidad),
                        new NpgsqlParameter("p_descripcion", pElemento.Descripcion)
                    };

            return conexion.Actualizar(consulta, parametros);

        }
        public bool Eliminar(BEElemento pElemento)
        {
            string consulta = "eliminar_elemento";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                  new NpgsqlParameter("p_id",  pElemento.Id )
            };
            return conexion.Eliminar(consulta, parametros);

        }

        public string ObtenerNroHallazgo(BEElemento bEElemento)
        {

            return bEElemento.Hallazgo.NroActa;
        }
        public string ObtenerNroEntrega(BEElemento bEElemento)
        {
            // Obtener el XElement que corresponde al Elemento
            return bEElemento.Entrega.NroActa;
        }


        public List<BEElemento> ListarTodo()
        {

            DataTable tabla;
            string consulta = "SELECT * FROM listarElementosPorId(NULL)";

            tabla = conexion.Listar(consulta, null);

            List<BEElemento> bEElementos = new List<BEElemento>();
            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    BEElemento elemento = new BEElemento();

                    elemento.Id = Convert.ToInt32(row["Id"]);
                    elemento.Descripcion = Convert.ToString(row["Descripcion"]);
                    elemento.Cantidad = Convert.ToDouble(row["Cantidad"]);
                    elemento.Estado = new BEEstado_Elemento(Convert.ToInt32(row["IdEstadoElemento"]), Convert.ToString(row["NombreEstado"]));
                    elemento.Articulo = new BEArticulo(Convert.ToInt32(row["IdArticulo"]), Convert.ToString(row["NombreArticulo"]));
                    elemento.Articulo.Categoria = new BECategoria(Convert.ToInt32(row["IdCategoria"]), Convert.ToString(row["NombreCategoria"]));
                    elemento.Hallazgo = new BEHallazgo(Convert.ToInt32(row["IdHallazgo"]), Convert.ToString(row["NroActaHallazgo"]));
                    if (!row.IsNull("IdEntrega"))
                    {
                        elemento.Entrega = new BEEntrega(Convert.ToInt32(row["IdEntrega"]), Convert.ToString(row["NroActaEntrega"]));
                    }

                    bEElementos.Add(elemento);
                }
            }
            return bEElementos;
        }


        public BEElemento ListarObjeto(BEElemento bElemento)
        {
            DataTable tabla;
            string consulta = "SELECT * FROM listarElementosPorId(@p_id_elemento)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_id_elemento", bElemento.Id)
                };

            tabla = conexion.Listar(consulta, parametros);

            if (tabla.Rows.Count > 0)
            {
                DataRow row = tabla.Rows[0];

                bElemento.Descripcion = Convert.ToString(row["Descripcion"]);
                bElemento.Cantidad = Convert.ToDouble(row["Cantidad"]);
                bElemento.Estado = new BEEstado_Elemento(Convert.ToInt32(row["IdEstadoElemento"]), Convert.ToString(row["NombreEstado"]));
                bElemento.Articulo = new BEArticulo(Convert.ToInt32(row["IdArticulo"]), Convert.ToString(row["NombreArticulo"]));
                bElemento.Articulo.Categoria = new BECategoria(Convert.ToInt32(row["IdCategoria"]), Convert.ToString(row["NombreCategoria"]));
                bElemento.Hallazgo = new BEHallazgo(Convert.ToInt32(row["IdHallazgo"]), Convert.ToString(row["NroActaHallazgo"]));
                if (!row.IsNull("IdEntrega"))
                {
                    bElemento.Entrega = new BEEntrega(Convert.ToInt32(row["IdEntrega"]), Convert.ToString(row["NroActaEntrega"]));
                }
            }
            else
            {
                bElemento = null;
            }

            return bElemento;
        }

        public List<ElementoBusqueda> BusquedaElementosHallazgo(string nroActa)
        {
            List<ElementoBusqueda> lista = new List<ElementoBusqueda>();
            MPPHallazgo mPPHallazgo = new MPPHallazgo();


            var Hallazgo = mPPHallazgo.ListarTodo().Find(x => x.NroActa == nroActa);

            Hallazgo = mPPHallazgo.ListarHallazgoElementos(Hallazgo);



            if (Hallazgo != null)
            {
                foreach (BEElemento elemento in Hallazgo.listaElementos)
                {
                    ElementoBusqueda bElemento = new ElementoBusqueda();
                    bElemento.Id = elemento.Id;
                    bElemento.Cantidad = elemento.Cantidad.ToString();
                    bElemento.Descripcion = elemento.Descripcion;
                    bElemento.Articulo = elemento.Articulo.Nombre;
                    bElemento.Estado = elemento.Estado.Nombre;
                    bElemento.Hallazgo = Hallazgo.NroActa;
                    bElemento.Lugar = Hallazgo.LugarHallazgo;
                    bElemento.Fecha_hallazgo = Hallazgo.FechaHallazgo.ToString();
                    bElemento.Entrega = ObtenerNroEntrega(new BEElemento(bElemento.Id));

                    lista.Add(bElemento);
                }
            }

            return lista;
        }

        public async Task<List<ElementoBusqueda>> BusquedaElementos(DateTime? desde, DateTime? hasta, BECategoria bECategoria, BEArticulo bEArticulo, string lugar, string descripcion, BEUnidad unidad, string nroHallazgo)
        {
            DataTable tabla;
            string consulta = "SELECT * FROM busqueda_elementos(@p_desde, @p_hasta, @p_categoria_id, @p_articulo_id, @p_lugar, @p_descripcion, @p_unidad_id, @p_nro_hallazgo)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("@p_desde", desde != null ? (object)desde : DBNull.Value),
                    new NpgsqlParameter("@p_hasta", hasta != null ? (object)hasta : DBNull.Value),
                    new NpgsqlParameter("@p_categoria_id", bECategoria != null ? (object)bECategoria.Id: DBNull.Value),
                    new NpgsqlParameter("@p_articulo_id", bEArticulo != null ? (object)bEArticulo.Id: DBNull.Value),
                    new NpgsqlParameter("@p_lugar", lugar),
                    new NpgsqlParameter("@p_descripcion", descripcion),
                    new NpgsqlParameter("@p_unidad_id", unidad.Id),
                    new NpgsqlParameter("@p_nro_hallazgo", nroHallazgo)
                };

            //tabla = conexion.Listar(consulta, parametros);
            tabla = await Task.Run(() => conexion.Listar(consulta, parametros));

            List<ElementoBusqueda> lista = new List<ElementoBusqueda>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    ElementoBusqueda elemento = new ElementoBusqueda
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Fecha_hallazgo = DateTime.Parse(row["fecha_hallazgo"].ToString()).ToString("dd/MM/yyyy HH:mm"),
                        Hallazgo = row["hallazgo"].ToString(),
                        Lugar = row["lugar_hallazgo"].ToString(),
                        Articulo = row["articulo"].ToString(),
                        Cantidad = row["cantidad"].ToString(),
                        Descripcion = row["descripcion"].ToString(),
                        Estado = row["estado"].ToString(),
                        Entrega = row["entrega"].ToString()
                    };

                    lista.Add(elemento);
                }
            }

            return lista;
        }
    }
}
