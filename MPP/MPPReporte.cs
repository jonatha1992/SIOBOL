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
    public class MPPReporte
    {
        Conexion conexion = new Conexion();


        public BEReporte ReporteGenerico()
        {
            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Generico()";

            BEReporte bereporte = new BEReporte();
            // Ejecutar la consulta
            Tabla = conexion.Listar(consulta, null);

            if (Tabla.Rows.Count == 0) return null;



            bereporte.Hallazgos = Tabla.AsEnumerable()
                                        .Where(row => row.Field<string>(0) == "Hallazgos")
                                        .Select(row => Convert.ToInt32(row.Field<Int64>(1)))
                                        .FirstOrDefault();

            bereporte.Entregas = Tabla.AsEnumerable()
                                        .Where(row => row.Field<string>(0) == "Entregas")
                                        .Select(row => Convert.ToInt32(row.Field<Int64>(1)))
                                        .FirstOrDefault();

            bereporte.Cant_Elementos_Resguardo = Tabla.AsEnumerable()
                                      .Where(row => row.Field<string>(0) == "Resguardos")
                                      .Select(row => Convert.ToInt32(row.Field<Int64>(1)))
                                      .FirstOrDefault();
            bereporte.Cant_Elementos_Entregado = Tabla.AsEnumerable()
                                        .Where(row => row.Field<string>(0) == "Entregados")
                                        .Select(row => Convert.ToInt32(row.Field<Int64>(1)))
                                        .FirstOrDefault();


            return bereporte;
        }

        public DataTable Reporte_Anual_Hallazgos(BEUnidad unidad, DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Anual_Hallazgos(@p_unidad_id,@p_fecha)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha)
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);

        }

        public DataTable Reporte_Anual_Entregas(BEUnidad unidad, DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Anual_Entregas(@p_unidad_id,@p_fecha)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha)
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);

        }
        public DataTable Reporte_Semestral_Entregas(BEUnidad unidad, DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Semestral_Entregas(@p_unidad_id,@p_fecha)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha)
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);

        }

        public DataTable Reporte_Semestral_Hallazgos(BEUnidad unidad, DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Semestral_Hallazgos(@p_unidad_id,@p_fecha)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha)
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);

        }

        public DataTable Reporte_Trimestral_Hallazgos(BEUnidad unidad, DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Trimestral_Hallazgos(@p_unidad_id,@p_fecha)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha)
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);

        }

        public DataTable Reporte_Trimestral_Entregas(BEUnidad unidad, DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Trimestral_Entregas(@p_unidad_id,@p_fecha)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha)
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);

        }
        public DataTable Reporte_Mensual_Entregas(BEUnidad unidad, DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Mensual_Entregas(@p_unidad_id,@p_fecha)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha)
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);
        }

        public DataTable Reporte_Mensual_Hallazgos(BEUnidad unidad, DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Mensual_Hallazgos(@p_unidad_id,@p_fecha)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha)
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);
        }



        public DataTable Reporte_Mensual_Categoria(BEUnidad unidad, DateTime fecha, BEEstado_Elemento estado)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Mensual_Categoria(@p_unidad_id,@p_fecha ,@p_estado_id)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha),
                    new NpgsqlParameter("p_estado_id", estado.Id),
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);
        }


        public DataTable Reporte_Trimestral_Categoria(BEUnidad unidad, DateTime fecha, BEEstado_Elemento estado)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Trimestral_Categoria(@p_unidad_id,@p_fecha ,@p_estado_id)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha),
                    new NpgsqlParameter("p_estado_id", estado.Id),
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);
        }

        public DataTable Reporte_Semestral_Categoria(BEUnidad unidad, DateTime fecha, BEEstado_Elemento estado)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Semestral_Categoria(@p_unidad_id,@p_fecha ,@p_estado_id)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha),
                    new NpgsqlParameter("p_estado_id", estado.Id),
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);
        }

        public DataTable Reporte_Anual_Categoria(BEUnidad unidad, DateTime fecha, BEEstado_Elemento estado)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Anual_Categoria(@p_unidad_id,@p_fecha ,@p_estado_id)";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha),
                    new NpgsqlParameter("p_estado_id", estado.Id),
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);
        }

        public DataTable Reporte_Excel_Anual_Unidad(BEUnidad unidad, DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Excel_Anual_Unidad(@p_unidad_id,@p_fecha )";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_unidad_id", unidad.Id),
                    new NpgsqlParameter("p_fecha", fecha),
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);
        }
        public DataTable Reporte_Excel_Anual_Ursa(BEUrsa ursa, DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Excel_Anual_Ursa(@p_ursa_id,@p_fecha )";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_ursa_id", ursa.Id),
                    new NpgsqlParameter("p_fecha", fecha),
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);
        }
        public DataTable Reporte_Excel_Anual_Ceac( DateTime fecha)
        {

            DataTable Tabla;

            // Preparar la consulta y los parámetros 
            string consulta = "SELECT * FROM Reporte_Excel_Anual_Ceac(@p_fecha )";

            List<NpgsqlParameter> parametros = new List<NpgsqlParameter>
                {
                    new NpgsqlParameter("p_fecha", fecha),
                };
            // Ejecutar la consulta
            return Tabla = conexion.Listar(consulta, parametros);
        }
    }
}
