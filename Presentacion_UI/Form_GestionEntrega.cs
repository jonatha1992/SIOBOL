using BE;
using CircularProgressBar;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.VisualBasic;
using Negocio;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Font = System.Drawing.Font;

namespace Presentacion_UI
{
    public partial class Form_GestionEntrega : KryptonForm
    {
        public Form_GestionEntrega()
        {

            InitializeComponent();

            bLLEntrega = new BLLEntrega();
            bLLBitacora = new BLLBitacora();

            Usuario = (BEUsuario)Form_Contenedor.usuario.Clone();
        }


        void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
                Habilitar();
                ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE, dateTimePickerFechaEntrega.Value);
                listaEntreegaSeleccionado = new List<BEEntrega>();
                CargarGrillaEntregas();
                numericUpDownNroEntrega_ValueChanged(null, null);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #region "Campos"

        BEUsuario Usuario;
        BEUnidad bEUnidadGE;
        BEUrsa bEUrsa;

        BEEntrega BEEntregaSeleccionado;
        List<BEEntrega> ListaEntregasBase;
        List<BEEntrega> listaEntreegaSeleccionado;


        BLLEntrega bLLEntrega;
        BLLBitacora bLLBitacora;



        private int PaginaActual = 1;
        private int TamanoPagina = 30;
        private int Totalpaginas = 0;
        #endregion
        #region "Metodos"

        #region "MetodosElementos"

        void CargarCombo()
        {
            if (Usuario.Destino is BEUnidad)//destino unidad
            {
                bEUnidadGE = Usuario.Destino as BEUnidad;
                bEUrsa = bEUnidadGE.Ursa;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUnidad.SelectedItem = bEUnidadGE;
                comboBoxUnidad.Text = bEUnidadGE.Nombre;
                comboBoxUrsa.Enabled = false;
                comboBoxUnidad.Enabled = false;
            }
            if (Usuario.Destino is BEUrsa) //destino region
            {
                bEUrsa = Usuario.Destino as BEUrsa;
                bEUnidadGE = bEUrsa.Unidades.First();
                comboBoxUnidad.DataSource = bEUrsa.Unidades;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUrsa.Enabled = false;
            }
        }

        void CargarGrillaElementos()
        {
            try
            {
                DgvElementos.DataSource = null;

                if (BEEntregaSeleccionado != null)
                {

                    DgvElementos.DataSource = bLLEntrega.ListarEntregaElementos(BEEntregaSeleccionado).listaElementos;

                    if (DgvElementos.DataSource != null || BEEntregaSeleccionado.listaElementos.Count > 0)
                    {
                        this.DgvElementos.Columns["Id"].Width = 35;
                        this.DgvElementos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                        this.DgvElementos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                        this.DgvElementos.ClearSelection();

                    }
                    if (DgvElementos.DataSource == null || DgvElementos.Rows.Count == 0)// si no hay nada
                    {
                        DgvElementos.ColumnHeadersVisible = false;
                        labelTitleElementos.Visible = false;

                    }
                    else
                    {
                        DgvElementos.ColumnHeadersVisible = true;
                        labelTitleElementos.Visible = true;

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}"); ;
            }
        }

        void CargarGrillaPersonas()
        {
            DgvPersonas.DataSource = null;

            if (BEEntregaSeleccionado != null)
            {
                BEEntregaSeleccionado.listaPersonas = bLLEntrega.ListarEntregaPersonas(BEEntregaSeleccionado).listaPersonas;
                DgvPersonas.DataSource = BEEntregaSeleccionado.listaPersonas;

                if (BEEntregaSeleccionado.listaPersonas != null || BEEntregaSeleccionado.listaPersonas?.Count > 0)
                {

                    this.DgvPersonas.Columns["Id"].Visible = false;
                    this.DgvPersonas.Columns["Telefono"].Visible = false;
                    this.DgvPersonas.Columns["Ocupacion"].Visible = false;
                    this.DgvPersonas.Columns["Domicilio"].Visible = false;
                    this.DgvPersonas.Columns["NombreCompleto"].HeaderText = "Apellido y Nombre";
                    this.DgvPersonas.Columns["EstadoPersona"].HeaderText = "Estado";
                    this.DgvPersonas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    this.DgvPersonas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                    this.DgvPersonas.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                    this.DgvPersonas.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);

                }
            }

            if (DgvPersonas.DataSource == null || DgvPersonas.Rows.Count == 0)
            {
                DgvPersonas.ColumnHeadersVisible = false;
                labelTitleIntervinientes.Visible = false;
            }
            else
            {
                DgvPersonas.ColumnHeadersVisible = true;
                labelTitleIntervinientes.Visible = true;
            }


        }
        void SeleccionarEntrega()  // lo que hace la funcion es recorrer el dgv y seleccioonar el hallazgo
        {
            foreach (DataGridViewRow item in dgvEntregas.Rows)
            {
                if (item.Cells["NroActa"].Value.ToString() == BEEntregaSeleccionado.NroActa)
                {
                    item.Cells["Seleccion"].Value = true;
                    item.Selected = true;
                }
            }
        }

        #endregion

        #region "Metodos"
        void limpiarCamposEntrega()
        {
            dateTimePickerFechaEntrega.Value = DateTime.Now;
            numericUpDownNroEntrega.Value = 1;
            textBoxObservacion.Text = "";
            BEEntregaSeleccionado = null;
        }
        void ComboBox()
        {
            if (BEEntregaSeleccionado != null) // si esta en modo creacion
            {
                comboBoxUnidad.Text = BEEntregaSeleccionado.Unidad.Nombre;

                if (Usuario.Destino is BEUrsa)
                    comboBoxUnidad.Enabled = false;
            }
            else
            {
                if (Usuario.Destino is BEUrsa)
                    comboBoxUnidad.Enabled = true;

            }
        }
        void Botones()
        {
            if (BEEntregaSeleccionado != null)
            {
                buttonEliminar.Visible = true;
                button_Modificar.Visible = true;
            }
            else
            {
                button_Modificar.Visible = false;
                buttonEliminar.Visible = false;
            }

        }
        void Habilitar()
        {
            Botones();
            ComboBox();
        }
        void CargarGrillaEntregas()
        {
            this.dgvEntregas.DataSource = null;

            var lista = ListaEntregasBase.Skip((PaginaActual- 1) * TamanoPagina).Take(TamanoPagina).ToList();

            if (lista != null && lista.Count > 0)
            {
                this.dgvEntregas.DataSource = lista;
                this.dgvEntregas.Columns["NroActa"].HeaderText = "Nro Entrega";
                this.dgvEntregas.Columns["FechaEntrega"].HeaderText = "Fecha Entrega";
                this.dgvEntregas.Columns["Anio"].HeaderText = "Año";
                this.dgvEntregas.Columns["Unidad"].Visible = false;
                this.dgvEntregas.Columns["FechaActa"].Visible = false;
                this.dgvEntregas.Columns["Id"].Visible = false;
                this.dgvEntregas.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                this.dgvEntregas.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                this.dgvEntregas.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                this.dgvEntregas.Columns["Seleccion"].Visible = true;

                this.dgvEntregas.ClearSelection();
                Totalpaginas = CalcularTotalPaginas();
                labelTitleEntregas.Visible = true;
                labelPaginasEntrega.Visible = true;
                labelTotalSemanal.Visible = true;
                ButtonAnteriorEntrega.Visible = true;
                ButtonSiguienteEntrega.Visible = true;
                labelPaginasEntrega.Text = "Paginá: " + PaginaActual.ToString() + " de " + Totalpaginas;
                labelTotalSemanal.Text = "Total semanal: " + ListaEntregasBase.Count;
            }
            else
            {
                this.dgvEntregas.Columns["Seleccion"].Visible = false;
                labelTitleEntregas.Visible = false;
                labelPaginasEntrega.Visible = false;
                ButtonAnteriorEntrega.Visible = false;
                ButtonSiguienteEntrega.Visible = false;
                labelTotalSemanal.Visible = false;
            }
        }

        void HabilitarEntrega()
        {
            if (listaEntreegaSeleccionado?.Count > 0) // modo creacion
            {
                BEEntregaSeleccionado = listaEntreegaSeleccionado.First();

                if (BEEntregaSeleccionado != null) // SI YA ESTA SELECCIONADO
                {
                    numericUpDownNroEntrega.Value = bLLEntrega.ExtraerNro(BEEntregaSeleccionado.NroActa, bEUnidadGE);
                    labelNroEntrega.Text = BEEntregaSeleccionado.NroActa;

                    dateTimePickerFechaEntrega.Value = BEEntregaSeleccionado.FechaEntrega;
                    if (!string.IsNullOrEmpty(BEEntregaSeleccionado.Observacion))
                    {
                        textBoxObservacion.Text = BEEntregaSeleccionado.Observacion;
                    }
                }
                CargarGrillaElementos();
                CargarGrillaPersonas();
            }
            else
            {
                limpiarCamposEntrega();
                CargarGrillaEntregas();
                CargarGrillaElementos();
                CargarGrillaPersonas();
            }
            Habilitar();
        }


        bool VerficarCampos()
        {
            if (comboBoxUnidad.Text == ""
                || comboBoxUrsa.Text == ""
                || dateTimePickerFechaEntrega.Text == ""
                || numericUpDownNroEntrega.Value == 0
                || (bEUrsa.Unidades != null && !bEUrsa.Unidades.Exists(x => x.Nombre == comboBoxUnidad.Text)))
            {
                MessageBox.Show("Complete todos los campos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validar.VerificarNroActa(labelNroEntrega.Text, bEUnidadGE.Cod))
            {
                MessageBox.Show("Verifique el numero de Entrega\n\nEj. 1EZE/2020", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        int CalcularTotalPaginas()
        {
            // Calcular el número total de páginas
            int totalPaginas = (int)Math.Ceiling((double)ListaEntregasBase?.Count / TamanoPagina);
            return totalPaginas;
        }

        void btnNextEntrega_Click(object sender, EventArgs e)
        {
            if (PaginaActual < Totalpaginas)
            {
                PaginaActual++;
                CargarGrillaEntregas();
            }
        }
        void btnPreviousEntrega_Click(object sender, EventArgs e)
        {
            if (PaginaActual > 1)
            {
                PaginaActual--;
                CargarGrillaEntregas();
            }
        }


        private async Task MostrarCircularProgressBar()
        {
            dgvEntregas.Visible = false;
            circularProgressBar2.Visible = true;
            await Task.Delay(500);
        }
        private void OcultarCircularProgressBar()
        {

            circularProgressBar2.Visible = false;
            dgvEntregas.Visible = true;
        }
        BEEntrega CrearHallazgo()
        {

            BEEntregaSeleccionado.FechaEntrega = dateTimePickerFechaEntrega.Value;
            BEEntregaSeleccionado.NroActa = labelNroEntrega.Text;
            BEEntregaSeleccionado.Unidad = bEUnidadGE;
            BEEntregaSeleccionado.Anio = dateTimePickerFechaEntrega.Value.Year;
            BEEntregaSeleccionado.Observacion = textBoxObservacion.Text;

            return BEEntregaSeleccionado;
        }
        #endregion

        #endregion
        #region "Botones"

        void button_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show($"Desea Modificar la Entrega {BEEntregaSeleccionado.NroActa}", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    if (VerficarCampos())
                    {
                        if (bLLEntrega.Actualizar(CrearHallazgo()))
                        {
                            bLLBitacora.RegistrarEvento(Usuario, $"Se modifico el nro Acta de Entrega {BEEntregaSeleccionado.NroActa}");
                            Habilitar();
                            CargarGrillaEntregas();
                            SeleccionarEntrega();
                            MessageBox.Show("La Entrega se modificó correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Construir la lista de elementos para mostrar en el MessageBox
                string elementosAEliminar = string.Join(Environment.NewLine, listaEntreegaSeleccionado.Select(h => h.NroActa));
                var result = MessageBox.Show($"Desea eliminar el/los siguientes Entrega: {Environment.NewLine}{elementosAEliminar}", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {

                    foreach (var item in listaEntreegaSeleccionado)
                    {
                        bLLEntrega.Eliminar(item);
                        bLLBitacora.RegistrarEvento(Usuario, $"eliminó el nro Acta de Entrega {item.NroActa}");
                    }

                    listaEntreegaSeleccionado.Clear();
                    limpiarCamposEntrega();
                    ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE, dateTimePickerFechaEntrega.Value);
                    CargarGrillaEntregas();
                    CargarGrillaElementos();
                    CargarGrillaPersonas();
                    Habilitar();
                    MessageBox.Show("Las entregas se eliminaron correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion



        #region "Entrega"

        void comboBoxUnidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            bEUnidadGE = (BEUnidad)comboBoxUnidad.SelectedItem;
            BEEntregaSeleccionado = null;
            limpiarCamposEntrega();
            //ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE, dateTimePickerFechaEntrega.Value);
            //CargarGrillaEntregas();
            Habilitar();

        }
        async void dateTimePickerFechaHallazgo_ValueChanged(object sender, EventArgs e)
        {
            if (BEEntregaSeleccionado == null) // SI NO ESTA EN MODO CREACION 
            {
                await MostrarCircularProgressBar();
                await Task.Run(() =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE, dateTimePickerFechaEntrega.Value);

                        CargarGrillaEntregas();
                    });

                });

                OcultarCircularProgressBar();
            }

        }

        #endregion


        #region "Datagridview funciones"

        void dgvHallazgos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica si se hizo clic en la columna "Seleccion"
                if (e.ColumnIndex == this.dgvEntregas.Columns["Seleccion"].Index)
                {
                    // Obtiene el valor actual de la celda "Seleccion"
                    var valorCelda = dgvEntregas.Rows[e.RowIndex].Cells["Seleccion"].Value;
                    var valor = valorCelda as bool? ?? false; // Asigna false si el valor es null
                    var index = dgvEntregas.CurrentRow.Index;

                    if (!valor) // Si se seleccionó con el tilde
                    {
                        dgvEntregas.Rows[index].Cells["Seleccion"].Value = true;
                        var EntregaSeleccionada = (BEEntrega)dgvEntregas.Rows[index].DataBoundItem;
                        listaEntreegaSeleccionado.Add(EntregaSeleccionada);
                    }
                    else  // Si se quiere deseleccionar
                    {
                        dgvEntregas.Rows[e.RowIndex].Cells["Seleccion"].Value = false;
                        var EntregaSeleccionada = (BEEntrega)dgvEntregas.Rows[index].DataBoundItem;
                        listaEntreegaSeleccionado.RemoveAll(elemento => elemento.Id == EntregaSeleccionada.Id);

                    }
                    HabilitarEntrega();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Texto box funciones"
        void textBoxNroActa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloEnterossSinEspacios(e);
        }
        void textBoxLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NoSaltosDelinea(e);
        }

        #endregion

        private async void buttonBuscar_Click(object sender, EventArgs e)
        {

            try
            {
               await  MostrarCircularProgressBar();

                string nro = labelNroEntrega.Text;
                if (!string.IsNullOrEmpty(nro))
                {
                    await Task.Run(() =>
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            ListaEntregasBase = bLLEntrega.ListarTodo(bEUnidadGE).FindAll(x => x.NroActa == nro);
                        });

                    });

                    if (ListaEntregasBase.Count == 0)
                        MessageBox.Show("No se encontro ese numero de Entrega", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        CargarGrillaEntregas();

                }
                OcultarCircularProgressBar();

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                limpiarCamposEntrega();
                CargarGrillaEntregas();
                CargarGrillaElementos();
                CargarGrillaPersonas();
                Habilitar();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void numericUpDownNroEntrega_ValueChanged(object sender, EventArgs e)
        {
            labelNroEntrega.Text = numericUpDownNroEntrega.Value + bEUnidadGE.Cod + "/" + dateTimePickerFechaEntrega.Value.Year;
        }

        private void numericUpDownNroEntrega_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numericUpDownNroEntrega.Text) || numericUpDownNroEntrega.Value < numericUpDownNroEntrega.Minimum)
            {
                numericUpDownNroEntrega.Value = numericUpDownNroEntrega.Minimum;
            }

            labelNroEntrega.Text = numericUpDownNroEntrega.Value + bEUnidadGE.Cod + "/" + dateTimePickerFechaEntrega.Value.Year;

        }


    }
}