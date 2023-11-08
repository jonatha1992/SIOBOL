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

    public class MPPHallazgo : IGestor<BEHallazgo>
    {
        Conexion conexion = new Conexion();
        public MPPHallazgo() { }


        public BEHallazgo Agregar(BEHallazgo pHallazgo)
        {
            // Preparar la consulta y los parámetros 
            string consulta = "SELECT agregar_hallazgo(@p_id_unidad, @p_FechaHallazgo, @p_LugarHallazgo, @p_FechaActa,@p_Observacion, @p_NroActa)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
                new NpgsqlParameter("p_id_unidad", pHallazgo.Unidad.Id),
                new NpgsqlParameter("p_FechaHallazgo", pHallazgo.FechaHallazgo),
                new NpgsqlParameter("p_FechaActa", pHallazgo.FechaActa),
                new NpgsqlParameter("p_NroActa", pHallazgo.NroActa),
                new NpgsqlParameter("p_LugarHallazgo", pHallazgo.LugarHallazgo),
                new NpgsqlParameter("p_Observacion", pHallazgo.Observacion)
            };

            // Llamar al método Agregar para ejecutar el procedimiento almacenado
            int? nuevoId = conexion.Agregar(consulta, parametros);

            if (nuevoId != null)
            {
                pHallazgo.Id = (int)nuevoId;
            }


            return pHallazgo;
        }
        public bool Eliminar(BEHallazgo pHallazgo)
        {

            string consulta = "eliminar_hallazgo";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
            {
                  new NpgsqlParameter("p_id",  pHallazgo.Id )
            };
            return conexion.Eliminar(consulta, parametros);

        }


        public bool Actualizar(BEHallazgo pHallazgo)
        {
            string consulta = "actualizar_hallazgo";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                    {
                    new NpgsqlParameter("p_id", pHallazgo.Id),
                    new NpgsqlParameter("p_id_unidad", pHallazgo.Unidad.Id),
                    new NpgsqlParameter("p_fechahallazgo", pHallazgo.FechaHallazgo),
                    new NpgsqlParameter("p_lugarhallazgo", pHallazgo.LugarHallazgo),
                    new NpgsqlParameter("p_fechaacta", pHallazgo.FechaActa),
                    new NpgsqlParameter("p_nroacta", pHallazgo.NroActa),
                    new NpgsqlParameter("p_observacion", pHallazgo.Observacion)

                    };

            return conexion.Actualizar(consulta, parametros);
        }

        public string ObtenerNroActa(BEUnidad bEUnidad, int anio)
        {
            try
            {
                DataTable Tabla;

                // Preparar la consulta
                string consulta = "SELECT * FROM obtener_nro_hallazgo(@p_id_unidad, @p_anio)";
                List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_id_unidad", bEUnidad.Id),
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
            catch (Exception e)
            {
                throw new Exception("Ocurrió una excepción: " + e.Message, e);
            }
        }
        public List<BEHallazgo> ListarTodo()
        {
            DataTable Tabla;

            // Preparar la consulta
            string consulta = "SELECT * FROM public.listarHallazgos(NULL, NULL, NULL)";


            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, null);

            List<BEHallazgo> listaHallazgos = new List<BEHallazgo>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEHallazgo hallazgo = new BEHallazgo
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Unidad = new BEUnidad(Convert.ToInt32(fila["IdUnidad"]), fila["NombreUnidad"].ToString()),
                    NroActa = fila["NroActa"].ToString(),
                    LugarHallazgo = fila["LugarHallazgo"].ToString(),
                    Observacion = fila["Observacion"].ToString(),
                    FechaActa = fila["FechaActa"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["FechaActa"]),
                    FechaHallazgo = Convert.ToDateTime(fila["FechaHallazgo"]),
                };
                listaHallazgos.Add(hallazgo);
            }

            return listaHallazgos;
        }

        public List<BEHallazgo> ListarTodo(BEUnidad bEUnidad)
        {
            DataTable Tabla;

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
                new NpgsqlParameter("pd_id_unidad", bEUnidad.Id),
              };

            string consulta = "SELECT * FROM public.listarHallazgos(NULL,@pd_id_unidad,NULL)";
            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            List<BEHallazgo> listahallazgos = new List<BEHallazgo>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEHallazgo hallazgo = new BEHallazgo
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Unidad = new BEUnidad(Convert.ToInt32(fila["IdUnidad"]), fila["NombreUnidad"].ToString()),
                    NroActa = fila["NroActa"].ToString(),
                    Observacion = fila["Observacion"].ToString(),
                    FechaHallazgo = Convert.ToDateTime(fila["FechaHallazgo"]),
                    LugarHallazgo = fila["LugarHallazgo"].ToString(),
                    FechaActa = fila["FechaActa"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["FechaActa"]),
                };
                hallazgo.Unidad = bEUnidad;
                listahallazgos.Add(hallazgo);
            }

            return listahallazgos;
        }

        public List<BEHallazgo> ListarTodo(BEUnidad bEUnidad, DateTime fecha)
        {
            DataTable Tabla;

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
                new NpgsqlParameter("pd_id_unidad", bEUnidad.Id),
                new NpgsqlParameter("pd_fecha", fecha)
              };

            string consulta = "SELECT * FROM public.listarHallazgos(NULL,@pd_id_unidad, @pd_fecha)";
            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, parametros);

            List<BEHallazgo> listaHallazgos = new List<BEHallazgo>();
            foreach (DataRow fila in Tabla.Rows)
            {
                BEHallazgo hallazgo = new BEHallazgo
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Unidad = new BEUnidad(Convert.ToInt32(fila["IdUnidad"]), fila["NombreUnidad"].ToString()),
                    NroActa = fila["NroActa"].ToString(),
                    LugarHallazgo = fila["LugarHallazgo"].ToString(),
                    Observacion = fila["Observacion"].ToString(),
                    FechaActa = fila["FechaActa"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["FechaActa"]),
                    FechaHallazgo = Convert.ToDateTime(fila["FechaHallazgo"]),
                };
                hallazgo.Unidad = bEUnidad;
                listaHallazgos.Add(hallazgo);
            }

            return listaHallazgos;
        }


        public BEHallazgo ListarObjeto(BEHallazgo bEHallazgo)
        {
            DataTable tabla;
            string consulta = "SELECT * FROM public.listarHallazgos(@p_id, NULL,NULL)";
            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
                new NpgsqlParameter("p_id", bEHallazgo.Id)
              };

            tabla = conexion.Listar(consulta, parametros);

            if (tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                bEHallazgo = new BEHallazgo
                {
                    Id = Convert.ToInt32(fila["Id"]),
                    Unidad = new BEUnidad(Convert.ToInt32(fila["IdUnidad"]), fila["NombreUnidad"].ToString()),
                    NroActa = fila["NroActa"].ToString(),
                    LugarHallazgo = fila["LugarHallazgo"].ToString(),
                    Observacion = fila["Observacion"].ToString(),
                    FechaActa = fila["FechaActa"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(fila["FechaActa"]),
                    FechaHallazgo = Convert.ToDateTime(fila["FechaHallazgo"]),
                };
            }
            return bEHallazgo;
        }


        public BEHallazgo ListarHallazgoPersonas(BEHallazgo bEHallazgo)
        {
            DataTable tabla;
            string consulta = "SELECT * FROM listarPersonaPorHallazgo(@p_id_hallazgo)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
             {
                     new NpgsqlParameter("p_id_hallazgo", bEHallazgo.Id)
                };

            tabla = conexion.Listar(consulta, parametros);

            bEHallazgo.listaPersonas = new List<BEPersona>();

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

                    bEHallazgo.listaPersonas.Add(persona);
                }
            }

            return bEHallazgo;
        }

        public BEHallazgo ListarHallazgoElementos(BEHallazgo bEHallazgo)
        {
            DataTable tabla;
            string consulta = "SELECT * FROM listarElementosPorHallazgo(@p_id_hallazgo)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_id_hallazgo", bEHallazgo.Id)
                };

            tabla = conexion.Listar(consulta, parametros);

            bEHallazgo.listaElementos = new List<BEElemento>();

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
                    };                          // Verificar si la columna IdEntrega está vacía o es nula
                    if (!row.IsNull("IdEntrega"))
                    {
                        elemento.Entrega = new BEEntrega(Convert.ToInt32(row["IdEntrega"]), Convert.ToString(row["NroActaEntrega"]));
                    }


                    bEHallazgo.listaElementos.Add(elemento);
                }
            }

            return bEHallazgo;
        }

    }
}
