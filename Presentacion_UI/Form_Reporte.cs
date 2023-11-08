using BE;
using ClosedXML.Excel;
using ComponentFactory.Krypton.Toolkit;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_Reporte : KryptonForm
    {
        public Form_Reporte()
        {
            InitializeComponent();
            bUsuario = (BEUsuario)Form_Contenedor.usuario.Clone();
            bLLReporte = new BLLReporte();
            bLLEstado_Elemento = new BLLEstado_Elemento();
            bLLBitacora = new BLLBitacora();
        }

        BEReporte Reporte;
        BEUrsa bEUrsa;
        BEUnidad bEUnidad;
        BEUsuario bUsuario;
        BLLReporte bLLReporte;
        BLLBitacora bLLBitacora;
        BLLEstado_Elemento bLLEstado_Elemento;

        private void Form_Reporte_Load(object sender, EventArgs e)
        {

            Reporte = bLLReporte.ReporteGenerico();

            CargarCombo();
            SucripcionEventos();

            labelTotalHallazgos.Text = Reporte.Hallazgos.ToString();
            labelTotalEntregas.Text = Reporte.Entregas.ToString();
            labelElementosEntregados.Text = Reporte.Cant_Elementos_Entregado.ToString();
            labelElementosResguardados.Text = Reporte.Cant_Elementos_Resguardo.ToString();


            RadiocButtonClick(null, null);
        }

        void CargarCombo()
        {
            comboBoxUnidad.DataSource = null;
            if (bUsuario.Destino is BEUrsa)
            {
                bEUrsa = bUsuario.Destino as BEUrsa;
                bEUnidad = bEUrsa.Unidades.First();
                comboBoxUnidad.DataSource = bEUrsa.Unidades;
            }

            if (bUsuario.Destino is BEUnidad)
            {
                bEUnidad = bUsuario.Destino as BEUnidad;
                bEUrsa = bEUnidad.Ursa;
                comboBoxUnidad.DataSource = new List<BEUnidad> { bEUnidad };
                comboBoxUnidad.Text = bEUnidad.Nombre;
            }
            comboBoxEstado.DataSource = bLLEstado_Elemento.ListarTodo();
        }

        public void SucripcionEventos()
        {
            RadioButtonAnual.Click += RadiocButtonClick;
            RadioButtonMensual.Click += RadiocButtonClick;
            RadioButtonSemestral.Click += RadiocButtonClick;
            RadioButtonTrimestral.Click += RadiocButtonClick;
            comboBoxUnidad.SelectedIndexChanged += RadiocButtonClick;
            comboBoxEstado.SelectedIndexChanged += RadiocButtonClick;
            //dateTimePickerFecha.ValueChanged += RadiocButtonClick;

        }
        void RadiocButtonClick(object sender, EventArgs e)
        {
            try
            {
                bEUnidad = comboBoxUnidad.SelectedItem as BEUnidad;
                ActualizarGraficos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarGraficos()
        {
            try
            {
                if (RadioButtonAnual.Checked)
                {
                    chartHallazgos = bLLReporte.Reporte_Anual_Hallazgos(bEUnidad, chartHallazgos, dateTimePickerFecha.Value);
                    chartEntregas = bLLReporte.Reporte_Anual_Enntregas(bEUnidad, chartEntregas, dateTimePickerFecha.Value);
                    chartCategoria = bLLReporte.Reporte_Anual_Categoria(bEUnidad, chartCategoria, dateTimePickerFecha.Value, comboBoxEstado.SelectedItem as BEEstado_Elemento);
                }
                else if (RadioButtonSemestral.Checked)
                {
                    chartHallazgos = bLLReporte.Reporte_Semestral_hallazgos(bEUnidad, chartHallazgos, dateTimePickerFecha.Value);
                    chartEntregas = bLLReporte.Reporte_Semestral_Entregas(bEUnidad, chartEntregas, dateTimePickerFecha.Value);
                    chartCategoria = bLLReporte.Reporte_Semestral_Categoria(bEUnidad, chartCategoria, dateTimePickerFecha.Value, comboBoxEstado.SelectedItem as BEEstado_Elemento);

                }
                else if (RadioButtonTrimestral.Checked)
                {
                    chartHallazgos = bLLReporte.Reporte_Trimestral_hallazgos(bEUnidad, chartHallazgos, dateTimePickerFecha.Value);
                    chartEntregas = bLLReporte.Reporte_Trimestral_entregas(bEUnidad, chartEntregas, dateTimePickerFecha.Value);
                    chartCategoria = bLLReporte.Reporte_Trimestral_Categoria(bEUnidad, chartCategoria, dateTimePickerFecha.Value, comboBoxEstado.SelectedItem as BEEstado_Elemento);


                }
                else if (RadioButtonMensual.Checked)
                {
                    chartHallazgos = bLLReporte.Reporte_Mensual_hallazgos(bEUnidad, chartHallazgos, dateTimePickerFecha.Value);
                    chartEntregas = bLLReporte.Reporte_Mensual_Entregas(bEUnidad, chartEntregas, dateTimePickerFecha.Value);
                    chartCategoria = bLLReporte.Reporte_Mensual_Categoria(bEUnidad, chartCategoria, dateTimePickerFecha.Value, comboBoxEstado.SelectedItem as BEEstado_Elemento);
                }
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrió una excepción: " + e.Message, e);
            }
        }

        private void buttonReporteExcel_Click(object sender, EventArgs e)
        {
            try
            {
                XLWorkbook wb = new XLWorkbook();
                string esc = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                SaveFileDialog file = new SaveFileDialog();

                wb.AddWorksheet(bLLReporte.GenerarReporteExcel(bUsuario, dateTimePickerFecha.Value));

                //DataSet dataSet = bLLReporte.GenerarReporteExcel(bUsuario, dateTimePickerFecha.Value);
                //var ws = wb.Worksheets.Add(dataSet.Tables[0], "Elementos");
                file.Filter = "Excel Files | *.xlsx";
                file.FileName = $"Reporte {DateTime.Today.Day + DateTime.Today.ToString("MMMM").ToUpper() + DateTime.Now.Year.ToString()}";

                wb.Worksheet("Elementos").Columns().AdjustToContents();
                //wb.Worksheet("Hallazgos - Actores").Columns().AdjustToContents();
                //wb.Worksheet("Entrega - Actores").Columns().AdjustToContents();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    wb.SaveAs(file.FileName);
                    Process.Start(file.FileName);
                    bLLBitacora.RegistrarEvento(bUsuario, $"El usuario {bUsuario.NombreUsuario} generó un reporte");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Now.Month != dateTimePickerFecha.Value.Month || DateTime.Now.Year != dateTimePickerFecha.Value.Year)
                {

                    bEUnidad = comboBoxUnidad.SelectedItem as BEUnidad;
                    ActualizarGraficos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
