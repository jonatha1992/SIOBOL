using BE;
using MPP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Negocio
{
    public class BLLReporte
    {

        MPPReporte mPPReporte;

        public BLLReporte()
        {
            mPPReporte = new MPPReporte();
        }


        public BEReporte ReporteGenerico()
        {
            return mPPReporte.ReporteGenerico();
        }


        public Chart Reporte_Anual_Hallazgos(BEUnidad bEUnidad, Chart chart, DateTime fecha)
        {
            DataTable tabla = mPPReporte.Reporte_Anual_Hallazgos(bEUnidad, fecha);

            Series serieHallazgos = chart.Series.FirstOrDefault();
            serieHallazgos.Points.Clear();
            CultureInfo cultureInfo = new CultureInfo("es-ES");

            var datosOrdenados = tabla.AsEnumerable()
                .OrderBy(row => DateTime.ParseExact(row.Field<string>("Mes"), "MMM", CultureInfo.InvariantCulture).Month)
                .ToList();
            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in datosOrdenados)
            {
                string mesIngles = row["Mes"].ToString(); // Asegúrate de usar el nombre de la columna correcto
                int cantidad = Convert.ToInt32(row["Cantidad"]); // Asegúrate de usar el nombre de la columna correcto
                string mesEspanol = cultureInfo.DateTimeFormat.GetMonthName(DateTime.ParseExact(mesIngles, "MMM", CultureInfo.InvariantCulture).Month).Substring(0, 3);
                serieHallazgos.Points.AddXY(mesEspanol, cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? "Reporte Anual de Hallazgos" : "No existen Hallazgos en la fecha seleccionada";
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;

            return chart;
        }


        public Chart Reporte_Anual_Enntregas(BEUnidad bEUnidad, Chart chart, DateTime fecha)
        {
            DataTable tabla = mPPReporte.Reporte_Anual_Entregas(bEUnidad, fecha);

            Series serieHallazgos = chart.Series.FirstOrDefault();
            serieHallazgos.Points.Clear();
            CultureInfo cultureInfo = new CultureInfo("es-ES");

            var datosOrdenados = tabla.AsEnumerable()
                .OrderBy(row => DateTime.ParseExact(row.Field<string>("Mes"), "MMM", CultureInfo.InvariantCulture).Month)
                .ToList();
            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in datosOrdenados)
            {
                string mesIngles = row["Mes"].ToString(); // Asegúrate de usar el nombre de la columna correcto
                int cantidad = Convert.ToInt32(row["Cantidad"]); // Asegúrate de usar el nombre de la columna correcto
                string mesEspanol = cultureInfo.DateTimeFormat.GetMonthName(DateTime.ParseExact(mesIngles, "MMM", CultureInfo.InvariantCulture).Month).Substring(0, 3);
                serieHallazgos.Points.AddXY(mesEspanol, cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? "Reporte Anual de Entregas" : "No existen Entregas en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;

            return chart;
        }

        public Chart Reporte_Anual_Categoria(BEUnidad bEUnidad, Chart chart, DateTime fecha, BEEstado_Elemento bEEstado)
        {
            DataTable tabla = mPPReporte.Reporte_Anual_Categoria(bEUnidad, fecha, bEEstado);

            Series serie = chart.Series.FirstOrDefault();
            serie.Points.Clear();


            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in tabla.Rows)
            {
                string categoria = row["categoria"].ToString(); // Asegúrate de usar el nombre de la columna correcto
                int cantidad = Convert.ToInt32(row["cantidad_elementos"]); // Asegúrate de usar el nombre de la columna correcto
                serie.Points.AddXY(categoria, cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? $"Reporte Anual de elementos {bEEstado.Nombre.ToLower()} por Categoria" : $"No existen elementos {bEEstado.Nombre.ToLower()} en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;

            return chart;
        }


        public Chart Reporte_Semestral_Entregas(BEUnidad bEUnidad, Chart chart, DateTime fecha)
        {
            DataTable tabla = mPPReporte.Reporte_Semestral_Entregas(bEUnidad, fecha);

            Series serieHallazgos = chart.Series.FirstOrDefault();
            serieHallazgos.Points.Clear();


            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in tabla.Rows)
            {
                string semestre = row[0].ToString() == "1" ? "1er Semestre" : "2do Semestre";
                int cantidad = Convert.ToInt32(row["Cantidad"]); // Asegúrate de usar el nombre de la columna correcto
                serieHallazgos.Points.AddXY(semestre, cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? "Reporte Semestral de Entregas" : "No existen Entregas en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            return chart;
        }

        public Chart Reporte_Semestral_hallazgos(BEUnidad bEUnidad, Chart chart, DateTime fecha)
        {
            DataTable tabla = mPPReporte.Reporte_Semestral_Hallazgos(bEUnidad, fecha);

            Series serieHallazgos = chart.Series.FirstOrDefault();
            serieHallazgos.Points.Clear();


            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in tabla.Rows)
            {
                string semestre = row[0].ToString() == "1" ? "1er Semestre" : "2do Semestre";
                int cantidad = Convert.ToInt32(row["Cantidad"]); // Asegúrate de usar el nombre de la columna correcto
                serieHallazgos.Points.AddXY(semestre, cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? $"Reporte Semestral de Hallazgos" : $"No existen Hallazgos en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            return chart;


        }


        public Chart Reporte_Semestral_Categoria(BEUnidad bEUnidad, Chart chart, DateTime fecha, BEEstado_Elemento bEEstado)
        {
            DataTable tabla = mPPReporte.Reporte_Semestral_Categoria(bEUnidad, fecha, bEEstado);

            Series serie = chart.Series.FirstOrDefault();
            serie.Points.Clear();


            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in tabla.Rows)
            {
                string categoria = row["categoria"].ToString(); // Asegúrate de usar el nombre de la columna correcto
                int cantidad = Convert.ToInt32(row["cantidad_elementos"]); // Asegúrate de usar el nombre de la columna correcto
                serie.Points.AddXY(categoria, cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? $"Reporte Semestral de elementos {bEEstado.Nombre.ToLower()} por Categoria" : "No existen elementos en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;

            return chart;
        }
        public Chart Reporte_Trimestral_hallazgos(BEUnidad bEUnidad, Chart chart, DateTime fecha)
        {
            DataTable tabla = mPPReporte.Reporte_Trimestral_Hallazgos(bEUnidad, fecha);

            Series serieHallazgos = chart.Series.FirstOrDefault();
            serieHallazgos.Points.Clear();


            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in tabla.Rows)
            {
                string semestre = row[0].ToString() + " Trimestre";
                int cantidad = Convert.ToInt32(row["Cantidad"]); // Asegúrate de usar el nombre de la columna correcto
                serieHallazgos.Points.AddXY(semestre, cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? "Reporte Trimestre de Hallazgos" : "No existen Entregas en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;

            return chart;
        }

        public Chart Reporte_Trimestral_entregas(BEUnidad bEUnidad, Chart chart, DateTime fecha)
        {
            DataTable tabla = mPPReporte.Reporte_Trimestral_Entregas(bEUnidad, fecha);

            Series serieHallazgos = chart.Series.FirstOrDefault();
            serieHallazgos.Points.Clear();


            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in tabla.Rows)
            {
                string semestre = row[0].ToString() + " Trimestre";
                int cantidad = Convert.ToInt32(row["Cantidad"]); // Asegúrate de usar el nombre de la columna correcto
                serieHallazgos.Points.AddXY(semestre, cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? "Reporte Trimestre de Entregas" : "No existen Entregas en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            return chart;
        }

        public Chart Reporte_Trimestral_Categoria(BEUnidad bEUnidad, Chart chart, DateTime fecha, BEEstado_Elemento bEEstado)
        {
            DataTable tabla = mPPReporte.Reporte_Trimestral_Categoria(bEUnidad, fecha, bEEstado);

            Series serie = chart.Series.FirstOrDefault();
            serie.Points.Clear();


            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in tabla.Rows)
            {
                string categoria = row["categoria"].ToString(); // Asegúrate de usar el nombre de la columna correcto
                int cantidad = Convert.ToInt32(row["cantidad_elementos"]); // Asegúrate de usar el nombre de la columna correcto
                serie.Points.AddXY(categoria, cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? $"Reporte Trimestral de elementos {bEEstado.Nombre.ToLower()} por Categoria" : "No existen elementos en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;

            return chart;
        }
        public Chart Reporte_Mensual_hallazgos(BEUnidad bEUnidad, Chart chart, DateTime fecha)
        {
            DataTable tabla = mPPReporte.Reporte_Mensual_Hallazgos(bEUnidad, fecha);

            Series serieHallazgos = chart.Series.FirstOrDefault();
            serieHallazgos.Points.Clear();


            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in tabla.Rows)
            {
                int cantidad = Convert.ToInt32(row["Cantidad"]); // Asegúrate de usar el nombre de la columna correcto
                serieHallazgos.Points.AddXY(row[0], cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? "Reporte Mensual de Hallazgos" : "No existen Entregas en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;
            return chart;
        }


        public Chart Reporte_Mensual_Entregas(BEUnidad bEUnidad, Chart chart, DateTime fecha)
        {
            DataTable tabla = mPPReporte.Reporte_Mensual_Entregas(bEUnidad, fecha);

            Series serieHallazgos = chart.Series.FirstOrDefault();
            serieHallazgos.Points.Clear();


            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in tabla.Rows)
            {
                int cantidad = Convert.ToInt32(row["Cantidad"]); // Asegúrate de usar el nombre de la columna correcto
                serieHallazgos.Points.AddXY(row[0], cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? "Reporte Mensual de Entregas" : "No existen Entregas en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = -90;


            return chart;
        }

        public Chart Reporte_Mensual_Categoria(BEUnidad bEUnidad, Chart chart, DateTime fecha, BEEstado_Elemento bEEstado)
        {
            DataTable tabla = mPPReporte.Reporte_Mensual_Categoria(bEUnidad, fecha, bEEstado);

            Series serie = chart.Series.FirstOrDefault();
            serie.Points.Clear();


            // Recorre las filas del DataTable y agrega los valores al gráfico
            foreach (DataRow row in tabla.Rows)
            {
                string categoria = row["categoria"].ToString(); // Asegúrate de usar el nombre de la columna correcto
                int cantidad = Convert.ToInt32(row["cantidad_elementos"]); // Asegúrate de usar el nombre de la columna correcto
                serie.Points.AddXY(categoria, cantidad);
            }

            chart.Titles[0].Text = tabla.Rows.Count > 0 ? $"Reporte Mensual de elementos {bEEstado.Nombre.ToLower()} por Categoria" : "No existen elementos en la fecha seleccionada";

            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;

            return chart;
        }

        public DataSet GenerarReporteExcel(BEUsuario usuario, DateTime fecha)
        {

            DataSet dataSet = new DataSet();
            DataTable table;


            if (usuario.Destino is BEUnidad unidad)
            {
                table = mPPReporte.Reporte_Excel_Anual_Unidad(unidad, fecha);
            }
            else if (usuario.Destino is BEUrsa ursa)
            {
                table = mPPReporte.Reporte_Excel_Anual_Ursa(ursa, fecha);
            }
            else // si es ceac 
            {
                table = mPPReporte.Reporte_Excel_Anual_Ceac(fecha);
            }

            table.TableName = "Elementos";
            dataSet.Tables.Add(table);


            return dataSet;

        }


    }
}
