using BE;
using Negocio;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Font = System.Drawing.Font;
using ComponentFactory.Krypton.Toolkit;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Threading.Tasks;

namespace Presentacion_UI
{
    public partial class Form_Hallazgo : KryptonForm
    {
        public Form_Hallazgo()
        {

            InitializeComponent();

            bLLElemento = new BLLElemento();
            bLLcategorias = new BLLCategoria();
            bLLArticulos = new BLLArticulo();
            bLLHallazgo = new BLLHallazgo();
            bLLEstado_elementos = new BLLEstado_Elemento();
            bLLBitacora = new BLLBitacora();

            Usuario = (BEUsuario)Form_Contenedor.usuario.Clone();
            listaCategorias = bLLcategorias.ListarTodo();
            listaArticulos = bLLArticulos.ListarTodo();
            ListabEEstadoElementos = bLLEstado_elementos.ListarEstadoHallazgo();
        }


        void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCombo();
                Habilitar();
                HabilitarElemento();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        #region "Propiedades"

        BEUsuario Usuario;
        BEUnidad bEUnidadH;
        BEUrsa bEUrsa;

        BEHallazgo bEHallazgoSeleccionado;
        BEElemento bEElementoSeleccionado;
        List<BECategoria> listaCategorias;
        List<BEArticulo> listaArticulos;
        List<BEEstado_Elemento> ListabEEstadoElementos;
        List<BEElemento> ListaDeElementosSeleccionados;
        List<BEHallazgo> listadosHallazgos;



        BLLHallazgo bLLHallazgo;
        BLLElemento bLLElemento;
        BLLCategoria bLLcategorias;
        BLLArticulo bLLArticulos;
        BLLEstado_Elemento bLLEstado_elementos;
        BLLBitacora bLLBitacora;


        int PaginaActual = 1;
        int TamanoPagina = 30;
        int Totalpaginas = 0;
        bool SeleccionHallazgo = false;
        bool ModoCreacion = false;

        #endregion

        #region "Metodos"

        #region "MetodosElementos"

        void CargarCombo()
        {
            if (Usuario.Destino is BEUnidad)//destino unidad
            {
                bEUnidadH = Usuario.Destino as BEUnidad;
                bEUrsa = bEUnidadH.Ursa;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUnidadHallazgo.SelectedItem = bEUnidadH;
                comboBoxUnidadHallazgo.Text = bEUnidadH.Nombre;
                comboBoxUrsa.Enabled = false;
                comboBoxUnidadHallazgo.Enabled = false;
            }
            if (Usuario.Destino is BEUrsa) //destino region
            {
                bEUrsa = Usuario.Destino as BEUrsa;
                bEUnidadH = bEUrsa.Unidades.First();
                comboBoxUnidadHallazgo.DataSource = bEUrsa.Unidades;
                comboBoxUrsa.Text = bEUrsa.Nombre;
                comboBoxUrsa.Enabled = false;
            }
            comboBoxArticulo.DataSource = listaArticulos;
            comboBoxCategoria.DataSource = listaCategorias;
            comboBoxEstado.DataSource = ListabEEstadoElementos;
            comboBoxArticulo = Utilidades.SetAutoCompleteCombo(comboBoxArticulo, listaArticulos, articulo => articulo.Nombre);

        }
        bool VerificarCamposElementos()
        {
            if (comboBoxCategoria.Text == "SELECCIONE" || !listaCategorias.Exists(x => x.Nombre == comboBoxCategoria.Text))
            {
                MessageBox.Show("Seleccione la Categoría de elemento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (comboBoxArticulo.Text == "SELECCIONE" || !listaArticulos.Exists(x => x.Nombre == comboBoxArticulo.Text))
            {
                MessageBox.Show("Seleccione el Articulo", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (textBoxDescripcion.Text == "")
            {
                MessageBox.Show("Complete la descripción del elemento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (NUPCantidad.Text == "0")
            {
                MessageBox.Show("Ingrese una cantidad válida", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (comboBoxEstado.Text == "SELECCIONE")
            {
                MessageBox.Show("Seleccione el estado del elemento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        void HabilitarElemento()
        {


            if (ListaDeElementosSeleccionados?.Count > 0) // modo creacion
            {
                bEElementoSeleccionado = ListaDeElementosSeleccionados.First();

                if (bEElementoSeleccionado != null)
                {
                    comboBoxCategoria.Text = listaCategorias.Find(x => x.Id == bEElementoSeleccionado.Articulo.Categoria.Id).Nombre;
                    comboBoxArticulo.Text = bEElementoSeleccionado.Articulo.Nombre;
                    comboBoxEstado.Text = bEElementoSeleccionado.Estado.Nombre;
                    NUPCantidad.Text = bEElementoSeleccionado.Cantidad.ToString();
                    textBoxDescripcion.Text = bEElementoSeleccionado.Descripcion;
                }

                btnAgregarElemento.Visible = false;
                btnModificarElemento.Visible = true;
                btnEliminarElemento.Visible = true;
            }
            else
            {
                comboBoxCategoria.Text = "SELECCIONE";
                comboBoxArticulo.Text = "SELECCIONE";
                comboBoxEstado.Text = "SELECCIONE";
                textBoxDescripcion.Text = "";
                NUPCantidad.Text = "1";

                btnAgregarElemento.Visible = true;
                btnModificarElemento.Visible = false;
                btnEliminarElemento.Visible = false;
                bEElementoSeleccionado = null;
            }
        }
        void CargarGrillaElementos()
        {
            try
            {
                DgvElementos.DataSource = null;
                DgvElementos.Columns["Sel"].Visible = false;

                if (SeleccionHallazgo)
                {
                    if (ModoCreacion)
                    {
                        DgvElementos.DataSource = bLLHallazgo.ListarHallazgoElementos(bEHallazgoSeleccionado).listaElementos;
                        this.DgvElementos.Columns["Sel"].Visible = true;
                        this.DgvElementos.Columns["Sel"].Width = 30;
                    }
                    else
                    {
                        DgvElementos.DataSource = bEHallazgoSeleccionado.listaElementos;
                        this.DgvElementos.Columns["Sel"].Visible = false;
                    }


                    if (DgvElementos.DataSource != null || bEHallazgoSeleccionado.listaElementos.Count > 0)
                    {
                        this.DgvElementos.Columns["Id"].Width = 35;
                        this.DgvElementos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                        this.DgvElementos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                        this.DgvElementos.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 11F, FontStyle.Bold);

                    }
                    if (DgvElementos.DataSource == null || DgvElementos.Rows.Count == 0)
                    {
                        DgvElementos.ColumnHeadersVisible = false;
                    }
                    else
                    {
                        DgvElementos.ColumnHeadersVisible = true;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}"); ;
            }
        }

        void SeleccionarHallazgo()  // lo que hace la funcion es recorrer el dgv y seleccioonar el hallazgo
        {
            foreach (DataGridViewRow item in dgvHallazgos.Rows)
            {
                if (item.Cells["NroActa"].Value.ToString() == bEHallazgoSeleccionado.NroActa)
                {
                    item.Cells["Seleccion"].Value = true;
                    item.Selected = true;
                }
            }
        }
        BEElemento CrearElemento()
        {
            if (bEElementoSeleccionado == null)
            {
                bEElementoSeleccionado = new BEElemento();
            }

            bEElementoSeleccionado.Articulo = comboBoxArticulo.SelectedItem as BEArticulo;
            bEElementoSeleccionado.Estado = comboBoxEstado.SelectedItem as BEEstado_Elemento;
            bEElementoSeleccionado.Cantidad = double.Parse(NUPCantidad.Text);
            bEElementoSeleccionado.Descripcion = textBoxDescripcion.Text;

            return bEElementoSeleccionado;
        }
        #endregion

        #region "MetodosHallazgo"
        void limpiarCamposHallazgos()
        {
            textBoxLugar.Text = "";
            textBoxObservacion.Text = "";
            dateTimePickerFechaHallazgo.Value = DateTime.Now;
            SeleccionHallazgo = false;
            bEHallazgoSeleccionado = null;
            ModoCreacion = false;
            ColocarNumero();
        }
        void ColocarNumero()
        {
            if (!SeleccionHallazgo)
            {
                numericUpDownNroHallazgo.Value = 0;
                numericUpDownNroHallazgo.Value = bLLHallazgo.ObtenerNroActa(bEUnidadH, dateTimePickerFechaHallazgo.Value.Year);
            }
        }
        void ComboBox()
        {
            if (SeleccionHallazgo) // si esta en modo creacion
            {
                comboBoxUnidadHallazgo.Text = bEHallazgoSeleccionado.Unidad.Nombre;
                comboBoxUnidadHallazgo.Enabled = false;
            }
            else
            {
                comboBoxUnidadHallazgo.Enabled = true;
                comboBoxCategoria.Text = "SELECCIONE";
                comboBoxArticulo.Text = "SELECCIONE";
                comboBoxEstado.Text = "SELECCIONE";
                textBoxDescripcion.Text = "";
                NUPCantidad.Text = "1";

            }
        }
        bool VerificarCantidadPersonas()
        {
            bool cumple = false;

            if (bEHallazgoSeleccionado.listaPersonas != null)
            {
                if (bEHallazgoSeleccionado.listaPersonas?.Count == 4)
                {
                    cumple = true;
                }
                if (bEHallazgoSeleccionado.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Testigo") && bEHallazgoSeleccionado.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Descubridor") && bEHallazgoSeleccionado.listaPersonas.Exists(x => x.EstadoPersona.Nombre == "Instructor"))
                {
                    cumple = true;
                }

            }
            return cumple;
        }
        void Botones()
        {
            if (SeleccionHallazgo)
            {
                if (ModoCreacion)
                {
                    // Modo de creación
                    button_Agregar.Visible = false;
                    buttonEliminar.Visible = true;
                    button_Modificar.Visible = true;
                    buttonFinalizarHallazgo.Visible = true;
                    groupBoxDatosElementos.Enabled = true;
                    buttonCargarPersonas.Visible = true;
                }
                else
                {
                    // Modo de visualización
                    groupBoxDatosElementos.Enabled = false;
                    groupBoxDatosHallazgo.Enabled = false;
                    buttonImprimir.Visible = false;
                    button_Modificar.Visible = false;
                    buttonEliminar.Visible = false;
                    buttonFinalizarHallazgo.Visible = false;
                }

                if (VerificarCantidadPersonas())
                {
                    buttonCargarPersonas.BackColor = Color.Green;

                    if (bEHallazgoSeleccionado.listaElementos?.Count > 0)
                    {
                        buttonImprimir.Visible = true;
                    }
                }
                else
                {
                    buttonCargarPersonas.BackColor = Color.Red;
                }
            }
            else // vuelve a estado inicial
            {
                button_Agregar.Visible = true;
                groupBoxDatosHallazgo.Enabled = true;
                groupBoxDatosElementos.Enabled = false;
                button_Modificar.Visible = false;
                buttonEliminar.Visible = false;
                buttonCargarPersonas.Visible = false;
                buttonImprimir.Visible = false;
                buttonFinalizarHallazgo.Visible = false;
                btnEliminarElemento.Visible = false;
                btnModificarElemento.Visible = false;
            }
        }

        void Dgv()
        {
            if (ModoCreacion)
            {
                dgvHallazgos.Enabled = false;
                DgvElementos.Enabled = true;
            }
            else
            {
                dgvHallazgos.Enabled = true;
            }
        }

        void Habilitar()
        {
            Botones();
            ComboBox();
            Dgv();
        }


        int CalcularTotalPaginas()
        {
            // Calcular el número total de páginas
            int totalPaginas = (int)Math.Ceiling((double)listadosHallazgos?.Count / TamanoPagina);
            return totalPaginas;
        }
        void btnNext_Click(object sender, EventArgs e)
        {
            if (PaginaActual < Totalpaginas)
            {
                PaginaActual++;
                CargarGrillaHallazgos();
            }
        }
        void btnPrevious_Click(object sender, EventArgs e)
        {
            if (PaginaActual > 1)
            {
                PaginaActual--;
                CargarGrillaHallazgos();
            }
        }
        void CargarGrillaHallazgos()
        {
            this.dgvHallazgos.DataSource = null;

            List<BEHallazgo> Lista = listadosHallazgos.Skip((PaginaActual - 1) * TamanoPagina).Take(TamanoPagina).ToList(); 

            if (Lista != null && Lista.Count > 0)
            {

                //if (listadosHallazgos != null && listadosHallazgos.Count > 0)
                //{
                this.dgvHallazgos.DataSource = Lista;
                this.dgvHallazgos.Columns["NroActa"].HeaderText = "Nro Hallazgo";
                this.dgvHallazgos.Columns["FechaHallazgo"].HeaderText = "Fecha Hallazgo";
                this.dgvHallazgos.Columns["LugarHallazgo"].HeaderText = "Lugar";
                this.dgvHallazgos.Columns["Anio"].HeaderText = "Año";
                this.dgvHallazgos.Columns["Unidad"].Visible = false;
                this.dgvHallazgos.Columns["FechaActa"].Visible = false;
                this.dgvHallazgos.Columns["Id"].Visible = false;
                this.dgvHallazgos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
                this.dgvHallazgos.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
                this.dgvHallazgos.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 10F, FontStyle.Bold);
                this.dgvHallazgos.Columns["Seleccion"].Visible = true;
                this.dgvHallazgos.ColumnHeadersVisible = true;

                this.dgvHallazgos.ClearSelection();

                labelPaginas.Visible = true;
                labelTotalSemanal.Visible = true;
                ButtonAnterior.Visible = true;
                ButtonSiguiente.Visible = true;
                labelPaginas.Text = "Paginá: " + PaginaActual.ToString() + " de " + Totalpaginas;
                labelTotalSemanal.Text = "Total semanal:"+ listadosHallazgos.Count;
            }
            else
            {
                this.dgvHallazgos.ColumnHeadersVisible = false;
                labelPaginas.Visible = false;
                ButtonAnterior.Visible = false;
                ButtonSiguiente.Visible = false;
                labelTotalSemanal.Visible = false;

            }
        }

        void DeseleccionarTodasLasFilas()
        {
            foreach (DataGridViewRow row in dgvHallazgos.Rows)
            {
                // Establece el valor de la columna "Seleccion" a false para cada fila
                row.Cells["Seleccion"].Value = false;
            }
        }

        bool VerficarCamposHallazgo()
        {
            if (comboBoxUnidadHallazgo.Text == ""
                || comboBoxUrsa.Text == ""
                || dateTimePickerFechaHallazgo.Text == ""
                || textBoxLugar.Text == ""
                || numericUpDownNroHallazgo.Value == 0
                || (bEUrsa.Unidades != null && !bEUrsa.Unidades.Exists(x => x.Nombre == comboBoxUnidadHallazgo.Text)))
            {
                MessageBox.Show("Complete todos los campos correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Validar.VerificarNroActa(labelNroHallazgo.Text, bEUnidadH.Cod))
            {
                MessageBox.Show("Verifique el numero de Hallazgo\n\nEj. 1EZE/2020", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        BEHallazgo CrearHallazgo()
        {
            if (!SeleccionHallazgo)// agregar
            {
                bEHallazgoSeleccionado = new BEHallazgo();
            }
            bEHallazgoSeleccionado.FechaHallazgo = dateTimePickerFechaHallazgo.Value;
            bEHallazgoSeleccionado.FechaActa = DateTime.Now;
            bEHallazgoSeleccionado.NroActa = labelNroHallazgo.Text;
            bEHallazgoSeleccionado.Unidad = bEUnidadH;
            bEHallazgoSeleccionado.Anio = dateTimePickerFechaHallazgo.Value.Year;
            bEHallazgoSeleccionado.LugarHallazgo = textBoxLugar.Text;
            bEHallazgoSeleccionado.Observacion = textBoxObservacion.Text;

            return bEHallazgoSeleccionado;
        }
        #endregion

        #endregion
        #region "Botones"

        #region "Hallazgo"
        async void button_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerficarCamposHallazgo())
                {
                    await MostrarCircularProgressBar();
                    bEHallazgoSeleccionado = bLLHallazgo.Agregar(CrearHallazgo());

                    if (bEHallazgoSeleccionado != null)
                    {
                        bLLBitacora.RegistrarEvento(Usuario, $"Genero el Nro. Acta de Hallazgo  {bEHallazgoSeleccionado.NroActa}");
                        ModoCreacion = true;
                        SeleccionHallazgo = true;
                        ListaDeElementosSeleccionados = new List<BEElemento>();

                        Habilitar();
                        BuscarHallazgos();
                        CargarGrillaHallazgos();
                        SeleccionarHallazgo();
                        OcultarCircularProgressBar();
                        MessageBox.Show($"El Hallazgo {labelNroHallazgo.Text} se creo correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ColocarNumero();
            }
        }
        async void button_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerficarCamposHallazgo())
                {
                    await MostrarCircularProgressBar();
                    if (bLLHallazgo.Actualizar(CrearHallazgo()))
                    {
                        Habilitar();
                        BuscarHallazgos();
                        CargarGrillaHallazgos();
                        SeleccionarHallazgo();
                        OcultarCircularProgressBar();
                        MessageBox.Show("¡El Hallazgo se modifico correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        async void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                await MostrarCircularProgressBar();

                if (bLLHallazgo.Eliminar(bEHallazgoSeleccionado))
                {
                    bLLBitacora.RegistrarEvento(Usuario, $"Se elimino el nro Acta  de Hallazgo {bEHallazgoSeleccionado.NroActa}");
                    limpiarCamposHallazgos();
                    BuscarHallazgos();
                    CargarGrillaHallazgos();
                    CargarGrillaElementos();
                    Habilitar();
                    OcultarCircularProgressBar();
                    MessageBox.Show("El Hallazgo se elimino correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region "Elemento"
        void btnAgregarElemento_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificarCamposElementos())
                {
                    CrearElemento();
                    if (bLLElemento.AgregarElementoHallazgo(bEHallazgoSeleccionado, bEElementoSeleccionado))
                    {
                        CargarGrillaElementos();
                        HabilitarElemento();
                        Habilitar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        void btnModificarElemento_Click(object sender, EventArgs e)
        {
            try
            {

                if (VerificarCamposElementos())
                {
                    CrearElemento();
                    if (bLLElemento.Actualizar(bEElementoSeleccionado))
                    {
                        ListaDeElementosSeleccionados.RemoveAll(x => x.Id == bEElementoSeleccionado.Id);
                        CargarGrillaElementos();
                        HabilitarElemento();
                        VerificarElementosSeleccionados();
                        Habilitar();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void btnEliminarElemento_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in ListaDeElementosSeleccionados)
                {
                    bLLElemento.Eliminar(item);
                }
                ListaDeElementosSeleccionados.Clear();
                CargarGrillaElementos();
                HabilitarElemento();
                Habilitar();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion
        void buttonImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                if (bEHallazgoSeleccionado.listaPersonas?.Count >= 3 && bEHallazgoSeleccionado.listaElementos?.Count > 0)
                {
                    Form_Impresion form_Impresion = new Form_Impresion(bEHallazgoSeleccionado);
                    form_Impresion.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"No posee la cantidad de intervinientes para imprimir el acta", "Requisitos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonCargarPersonas_Click(object sender, EventArgs e)
        {
            try
            {
                Form_Persona formPersonas;
                formPersonas = new Form_Persona(bEHallazgoSeleccionado);
                formPersonas.ShowDialog();

                bEHallazgoSeleccionado = (BEHallazgo)formPersonas.BePAdreHallazgo;

                Habilitar();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        void buttonFinalizarHallazgo_Click(object sender, EventArgs e)
        {
            try
            {
                if (bEHallazgoSeleccionado.listaElementos == null || bEHallazgoSeleccionado.listaElementos.Count == 0)
                {
                    var result = MessageBox.Show("El Hallazgo no contiene elementos.\n\n¿Desea finalizar la carga?\n\nSi decide finalizar, ¡se borrará el Hallazgo creado!", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bLLHallazgo.Eliminar(bEHallazgoSeleccionado);
                        FinalizarCarga();
                    }
                }
                else if (bEHallazgoSeleccionado.listaPersonas == null || bEHallazgoSeleccionado.listaPersonas.Count == 0)
                {
                    var result = MessageBox.Show("El Hallazgo no contiene el mínimo de intervinientes para imprimir el Acta.\n\n¿Desea finalizar la carga?\n\nSi decide finalizar, ¡No podrá imprimir el Hallazgo!", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FinalizarCarga();
                    }
                }
                else
                {
                    var result = MessageBox.Show("¿Desea finalizar el Hallazgo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        FinalizarCarga();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void FinalizarCarga()
        {
            ModoCreacion = false;
            bEHallazgoSeleccionado = null;
            bEElementoSeleccionado = null;
            SeleccionHallazgo = false;
            ListaDeElementosSeleccionados = null;
            Habilitar();
            CargarGrillaHallazgos();
            CargarGrillaElementos();
            limpiarCamposHallazgos();

        }

        #endregion
        #region "Combobox Funciones"

        #region "Elemento"

        void dataGridViewElementos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ModoCreacion) // Verifica si estamos en modo de creación
            {
                // Verifica si se hizo clic en la columna "Sel"
                if (e.ColumnIndex == this.DgvElementos.Columns["Sel"].Index)
                {

                    // Obtiene el valor actual de la celda "Sel"
                    var valorCelda = DgvElementos.Rows[e.RowIndex].Cells["Sel"].Value;
                    var Valor = valorCelda as bool? ?? false; // Asigna false si el valor es null

                    // Obtiene el índice de la fila actual
                    var Index = DgvElementos.CurrentRow.Index;

                    // Invierte el valor de la celda "Sel"
                    if (!Valor)
                    {
                        DgvElementos.Rows[Index].Cells["Sel"].Value = true;
                        bEElementoSeleccionado = (BEElemento)DgvElementos.Rows[Index].DataBoundItem;
                        ListaDeElementosSeleccionados.Add(bEElementoSeleccionado);

                    }
                    else
                    {
                        DgvElementos.Rows[Index].Cells["Sel"].Value = false;

                        // Eliminar el elemento de la lista
                        bEElementoSeleccionado = (BEElemento)DgvElementos.Rows[Index].DataBoundItem;
                        ListaDeElementosSeleccionados.RemoveAll(elemento => elemento.Id == bEElementoSeleccionado.Id);

                    }
                    HabilitarElemento();
                }
            }
        }
        void VerificarElementosSeleccionados()
        {
            if (ListaDeElementosSeleccionados?.Count > 0)
            {
                foreach (DataGridViewRow row in DgvElementos.Rows)
                {
                    var valorID = (int)row.Cells["Id"].Value;
                    var valor = row.Cells["Sel"].Value as bool? ?? false;
                    if (ListaDeElementosSeleccionados.Exists(x => x.Id == valorID))
                    {
                        row.Cells["Sel"].Value = true;
                    }
                }
            }
        }

        #endregion

        #region "Hallazgo"

        private async Task MostrarCircularProgressBar()
        {
            dgvHallazgos.Visible = false;
            circularProgressBar1.Visible = true;
            await Task.Delay(1000);
        }
       
        private void OcultarCircularProgressBar()
        {
            circularProgressBar1.Visible = false;
            dgvHallazgos.Visible = true;

        }



        async void dateTimePickerFechaHallazgo_ValueChanged(object sender, EventArgs e)
        {

            if (!ModoCreacion && !SeleccionHallazgo) // SI NO ESTA EN MODO CREACION 
            {
                await MostrarCircularProgressBar();
                await Task.Run(() =>
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        BuscarHallazgos();
                        ColocarNumero();
                        CargarGrillaHallazgos();
                    });

                });

                OcultarCircularProgressBar();
            }

        }

        void BuscarHallazgos()
        {
            listadosHallazgos = bLLHallazgo.ListarTodo(bEUnidadH, dateTimePickerFechaHallazgo.Value);
            Totalpaginas = CalcularTotalPaginas();
            PaginaActual = 1;
        }

        #endregion

        #endregion

        #region "Datagridview funciones"

        void dgvHallazgos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SeleccionHallazgo = false;

                if (!ModoCreacion) //sin modo creacion
                {
                    // Verifica si se hizo clic en la columna "Seleccion"
                    if (e.ColumnIndex == this.dgvHallazgos.Columns["Seleccion"].Index)
                    {
                        // Obtiene el valor actual de la celda "Seleccion"
                        var valorCelda = dgvHallazgos.Rows[e.RowIndex].Cells["Seleccion"].Value;
                        var valor = valorCelda as bool? ?? false; // Asigna false si el valor es null
                        DeseleccionarTodasLasFilas();

                        if (!valor) // Si se seleccionó con el tilde
                        {
                            SeleccionHallazgo = true;

                            var index = dgvHallazgos.CurrentRow.Index;
                            var hallazgo = dgvHallazgos.CurrentRow.DataBoundItem as BEHallazgo;
                            dgvHallazgos.Rows[index].Cells["Seleccion"].Value = true;
                            bEHallazgoSeleccionado = bLLHallazgo.ListarObjeto(hallazgo);
                            CargarGrillaElementos();
                            Habilitar();
                        }
                        else  // Si se quiere deseleccionar
                        {
                            dgvHallazgos.Rows[e.RowIndex].Cells["Seleccion"].Value = false;
                            bEHallazgoSeleccionado = null;
                            CargarGrillaElementos();
                            Habilitar();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region "Texto box funciones"

        void textBoxLugar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NoSaltosDelinea(e);
        }

        #endregion

        void Form_Hallazgo_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (ModoCreacion)
                {
                    if (bEHallazgoSeleccionado.listaElementos == null || bEHallazgoSeleccionado.listaElementos?.Count == 0)
                    {
                        var result = MessageBox.Show("El Hallazgo no contiene elementos \n¿Desea finalizar la carga? \n Si decide salir se borrara el Hallazgo", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ModoCreacion = false;
                            bLLHallazgo.Eliminar(bEHallazgoSeleccionado);
                            this.Close();
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                    else
                    {
                        var result = MessageBox.Show("¿Desea salir de la carga de Hallazgo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ModoCreacion = false;
                            this.Close();
                        }
                        else
                        {
                            e.Cancel = true;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha surgido un error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxCategoria.SelectedItem is BECategoria selectedCategoria)
                {
                    // Filtrar los artículos por la categoría seleccionada
                    var articulosFiltrados = listaArticulos.Where(a => a.Categoria.Id == selectedCategoria.Id).ToList();
                    // Configurar el DataSource del ComboBox de artículos con los artículos filtrados
                    comboBoxArticulo.DataSource = articulosFiltrados;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void RealizarBusqueda(string sugerencia)
        {
            try
            {
                if (listaArticulos.Exists(x => x.Nombre == sugerencia))
                {
                    BECategoria categoriaDelArticulo = listaArticulos.FirstOrDefault(c => c.Nombre == sugerencia).Categoria;

                    if (categoriaDelArticulo != null)
                    {
                        //Establecer la categoría en el ComboBox de categorías
                        comboBoxCategoria.SelectedItem = categoriaDelArticulo;
                        comboBoxCategoria.Text = categoriaDelArticulo.Nombre;
                        comboBoxArticulo.Text = sugerencia;

                    }
                }
            }
            catch (Exception e)
            {

                throw new Exception("Ocurrió una excepción: " + e.Message, e);
            }

        }

        void comboBoxArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Obtener la sugerencia seleccionada en el ComboBox de artículos
                string sugerenciaSeleccionada = comboBoxArticulo.Text;

                // Realizar las acciones necesarias cuando se selecciona una sugerencia
                RealizarBusqueda(sugerenciaSeleccionada);
            }
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelNroHallazgo.Text = numericUpDownNroHallazgo.Value + bEUnidadH.Cod + "/" + dateTimePickerFechaHallazgo.Value.Year;
        }

        private void numericUpDownHallazgo_Leave(object sender, EventArgs e)
        {
            // Verificar si el valor está vacío o si es menor al valor mínimo permitido.
            if (string.IsNullOrWhiteSpace(numericUpDownNroHallazgo.Text) || numericUpDownNroHallazgo.Value < numericUpDownNroHallazgo.Minimum)
            {
                numericUpDownNroHallazgo.Value = numericUpDownNroHallazgo.Minimum;
            }
        }

        private void comboBoxUnidadHallazgo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bEUnidadH = (BEUnidad)this.comboBoxUnidadHallazgo.SelectedItem;
            limpiarCamposHallazgos();
            Habilitar();
        }

        private void comboBoxArticulo_TextChanged(object sender, EventArgs e)
        {
            // Obtener el texto actual del ComboBox
            string textoActual = comboBoxArticulo.Text;

            // Convertir el texto a mayúsculas y establecerlo nuevamente en el ComboBox
            comboBoxArticulo.Text = textoActual.ToUpper();
        }
    }
}