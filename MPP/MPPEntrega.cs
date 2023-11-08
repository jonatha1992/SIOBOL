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
    public class MPPEntrega : IGestor<BEEntrega>
    {
        Conexion conexion = new Conexion();
        


        public MPPEntrega() { }

        public BEEntrega Agregar(BEEntrega entrega)
        {
           // Preparar la consulta y los parámetros 
            string consulta = "SELECT agregar_entrega(@p_id_unidad, @p_FechaEntrega, @p_Observacion, @p_NroActa)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
                new NpgsqlParameter("p_id_unidad", entrega.Unidad.Id),
                new NpgsqlParameter("p_FechaEntrega", entrega.FechaEntrega),
                new NpgsqlParameter("p_Observacion", entrega.Observacion),
                new NpgsqlParameter("p_NroActa", entrega.NroActa),
            };

            // Llamar al método Agregar para ejecutar el procedimiento almacenado
            int? nuevoId = conexion.Agregar(consulta, parametros);

            if (nuevoId != null)
            {
                entrega.Id = (int)nuevoId;
            }

            return entrega;
        }


        public bool Actualizar(BEEntrega entrega)
        {
         //verificar el tipo de 
            string consulta = "actualizar_entrega";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                new NpgsqlParameter("p_id", entrega.Id),
                new NpgsqlParameter("p_id_unidad", entrega.Unidad.Id),
                new NpgsqlParameter("p_fechaentrega", entrega.FechaEntrega),
                new NpgsqlParameter("p_observacion", entrega.Observacion),
                new NpgsqlParameter("p_nroacta", entrega.NroActa),

                };

            return conexion.Actualizar(consulta, parametros);

        }

        public bool Eliminar(BEEntrega pEntrega)
        {

            string consulta = "eliminar_entrega";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                  new NpgsqlParameter("p_id",  pEntrega.Id )
            };
            return conexion.Eliminar(consulta, parametros);
        }

        public BEEntrega ListarObjeto(BEEntrega pEntrega)
        {
            // Prepare the query
            string consulta = "SELECT * FROM public.listarEntregas(@p_id,NULL)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                 {
                  new NpgsqlParameter("p_id", pEntrega.Id)
                   };

            // Execute the query
            DataTable tabla = conexion.Listar(consulta, parametros);
            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                pEntrega = new BEEntrega
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Unidad = new BEUnidad(Convert.ToInt32(fila["IdUnidad"]), fila["NombreUnidad"].ToString()),
                    NroActa = fila["NroActa"].ToString(),
                    Observacion = fila["Observacion"].ToString(),
                    FechaEntrega = Convert.ToDateTime(fila["FechaEntrega"])
                };
            }
            return pEntrega;
        }

        public BEEntrega ListarEntregaPersonas(BEEntrega pEntrega)
        {
            DataTable tabla;
            string consulta = "SELECT * FROM listarPersonaPorEntrega(@p_id_entrega)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                new NpgsqlParameter("p_id_entrega", pEntrega.Id)
                };

            tabla = conexion.Listar(consulta, parametros);

            pEntrega.listaPersonas = new List<BEPersona>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    int idEstado = Convert.ToInt32(row["IdEstado"]);

                    BEPersona persona;

                    if (idEstado == 1)
                    {
                        persona = new BEInstructor();
                        ((BEInstructor)persona).Legajo = Convert.ToInt32(row["Legajo"]);
                        ((BEInstructor)persona).Jerarquia = new BEJerarquia(Convert.ToInt32(row["IdJerarquia"]), Convert.ToString(row["NombreJerarquia"]));
                    }
                    else
                    {
                        persona = new BEPersona();
                    }

                    persona.Id = Convert.ToInt32(row["IdPersona"]);
                    persona.NombreCompleto = Convert.ToString(row["NombreCompleto"]);
                    persona.DNI = Convert.ToString(row["DNI"]);
                    persona.Domicilio = Convert.ToString(row["Domicilio"]);
                    persona.Ocupacion = Convert.ToString(row["Ocupacion"]);
                    persona.Telefono = Convert.ToString(row["Telefono"]);
                    persona.EstadoPersona = new BEEstado_Persona(idEstado, Convert.ToString(row["NombreEstado"]));

                    pEntrega.listaPersonas.Add(persona);
                }
            }

            return pEntrega;
        }


        public BEEntrega ListarEntregaElementos(BEEntrega pEntrega)
        {
            DataTable tabla;
            string consulta = "SELECT * FROM listarElementosPorEntrega(@p_id_entrega)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                        new NpgsqlParameter("p_id_entrega", pEntrega.Id)
                    };

            tabla = conexion.Listar(consulta, parametros);

            pEntrega.listaElementos = new List<BEElemento>();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow row in tabla.Rows)
                {
                    BEElemento elemento = new BEElemento
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Descripcion = Convert.ToString(row["Descripcion"]),
                        Cantidad = Convert.ToDouble(row["Cantidad"]),
                        Estado = new BEEstado_Elemento(Convert.ToInt32(row["IdEstadoElemento"]), Convert.ToString(row["NombreEstado"])),
                        Articulo = new BEArticulo
                        {
                            Id = Convert.ToInt32(row["IdArticulo"]),
                            Nombre = Convert.ToString(row["NombreArticulo"]),
                            Categoria = new BECategoria
                            {
                                Id = Convert.ToInt32(row["IdCategoria"]),
                                Nombre = Convert.ToString(row["NombreCategoria"])
                            }
                        },
                        Hallazgo = new BEHallazgo(Convert.ToInt32(row["IdHallazgo"]), Convert.ToString(row["NroActaHallazgo"])),
                        Entrega = new BEEntrega(Convert.ToInt32(row["IdEntrega"]), Convert.ToString(row["NroActaEntrega"]))
                    };

                    pEntrega.listaElementos.Add(elemento);
                }
            }
            return pEntrega;
        }

        public List<BEEntrega> ListarTodo()
        {
            DataTable Tabla;

            // Preparar la consulta
            string consulta = "SELECT * FROM public.listarEntregas(NULL, NULL, NULL)";

            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, null);

            List<BEEntrega> listaEntregas = new List<BEEntrega>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEEntrega entrega = new BEEntrega
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Unidad = new BEUnidad(Convert.ToInt32(fila["IdUnidad"]), fila["NombreUnidad"].ToString()),
                    NroActa = fila["NroActa"].ToString(),
                    Observacion = fila["Observacion"].ToString(),
                    FechaEntrega = Convert.ToDateTime(fila["FechaEntrega"])
                };
                listaEntregas.Add(entrega);
            }

            return listaEntregas;
        }

        public List<BEEntrega> ListarTodo(BEUnidad bEUnidad)
        {
            DataTable Tabla;

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
                new NpgsqlParameter("pd_id_unidad", bEUnidad.Id),
              };

            string consulta = "SELECT * FROM public.listarEntregas(NULL,@pd_id_unidad,NULL)";
            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            List<BEEntrega> listaEntregas = new List<BEEntrega>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEEntrega entrega = new BEEntrega
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Unidad = new BEUnidad(Convert.ToInt32(fila["IdUnidad"]), fila["NombreUnidad"].ToString()),
                    NroActa = fila["NroActa"].ToString(),
                    Observacion = fila["Observacion"].ToString(),
                    FechaEntrega = Convert.ToDateTime(fila["FechaEntrega"]),
                };
                entrega.Unidad = bEUnidad;
                listaEntregas.Add(entrega);
            }

            return listaEntregas;
        }


        public List<BEEntrega> ListarTodo(BEUnidad bEUnidad, DateTime fecha)
        {
            DataTable Tabla;

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
                new NpgsqlParameter("pd_id_unidad", bEUnidad.Id),
                new NpgsqlParameter("pd_fecha", fecha)
              };

            string consulta = "SELECT * FROM public.listarEntregas(NULL,@pd_id_unidad, @pd_fecha)";
            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            List<BEEntrega> listaEntregas = new List<BEEntrega>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEEntrega entrega = new BEEntrega
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Unidad = new BEUnidad(Convert.ToInt32(fila["IdUnidad"]), fila["NombreUnidad"].ToString()),
                    NroActa = fila["NroActa"].ToString(),
                    Observacion = fila["Observacion"].ToString(),
                    FechaEntrega = Convert.ToDateTime(fila["FechaEntrega"]),
                };
                entrega.Unidad = bEUnidad;
                listaEntregas.Add(entrega);
            }

            return listaEntregas;
        }

        public string ObtenerNroActa(BEUnidad unidad, int anio)
        {

            DataTable Tabla;

            // Preparar la consulta
            string consulta = "SELECT * FROM obtener_nro_Entrega(@p_id_unidad, @p_anio)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
                new NpgsqlParameter("p_id_unidad", unidad.Id),
                new NpgsqlParameter("p_anio", anio)
              };
            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            if (Tabla.Rows.Count > 0)
            {
                return Tabla.Rows[0][0].ToString();
            }

            // Si no hay resultados, devuelve null o una cadena vacía (según lo que prefieras)
            return null;
        }
    }
}
