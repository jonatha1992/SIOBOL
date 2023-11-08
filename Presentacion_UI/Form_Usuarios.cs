using BE;
using ClosedXML.Report.Utils;
using ComponentFactory.Krypton.Toolkit;
using DocumentFormat.OpenXml.Bibliography;
using Negocio;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Presentacion_UI
{
    public partial class Form_Usuarios : KryptonForm
    {
        public Form_Usuarios()
        {
            InitializeComponent();
        }

        #region "campos"
        BLLUsuario oBLLUsu;
        BLLPermiso oBLLPermiso;
        BLLUnidad bLLUnidad;
        BLLUrsa bLLUrsa;
        BEUsuario seleccion;
        List<BEUnidad> Unidades { get; set; }
        List<BEUrsa> Ursas { get; set; }
        #endregion

        #region "Metodos"



        void MostrarPermisos(BEUsuario u)
        {
            this.treeViewPermisos.Nodes.Clear();

            foreach (var item in u.Permisos)
            {
                TreeNode nodo = new TreeNode();

                if (item is BERol)
                {
                    nodo.Text = (item as BERol).Nombre;

                    foreach (var x in item.Hijos)
                    {
                        TreeNode hijo = new TreeNode();
                        hijo.Text = (x as BEPermiso).Descripcion;
                        hijo.Tag = x;
                        nodo.Nodes.Add(hijo);
                    }
                }
                nodo.Tag = item;

                this.treeViewPermisos.Nodes.Add(nodo);
            }
            this.treeViewPermisos.ExpandAll();

        }
        void DeshabilitarCarga()
        {
            //groupBoxDatosUsuario.Visible = false;
            ButtonEliminarUsuario.Visible = false;
        }

        void HabilitarCargaConfig()
        {
            //groupBoxDatosUsuario.Visible = true;
            ButtonEliminarUsuario.Visible = true;
            errorProvider1.Clear();

        }
        void HabilitarCargaNuevo()
        {
            //groupBoxDatosUsuario.Visible = true;
            ButtonEliminarUsuario.Visible = false;
        }
        void LimpiarFormulario()
        {
            seleccion = null;
            textBoxNombre.Text = "";
            textBoxDNI.Text = "";
            textBoxUsuario.Text = "";
            textBoxPassword1.Texto = "";
            textBoxPassword2.Texto = "";
            labelDestino.Text = "";
            treeViewPermisos.Nodes.Clear();

        }

        bool VerficarCamposUsuario()
        {

            Control[] controles = { textBoxUsuario, textBoxNombre,  textBoxDNI };

            foreach (Control control in controles)
            {
                if (control.Text.IsNullOrWhiteSpace())
                {
                    Validar.control_vacio(control, errorProvider1); return false;
                }
            } 

            if (textBoxPassword1.Texto != textBoxPassword2.Texto)
            {
                errorProvider1.SetError(textBoxPassword1, "Las contraseñas no coinciden");
                return false;
            }
            if (seleccion.Permisos.Count == 0)
            {
                errorProvider1.SetError(comboBoxRoles, "El usuario no tiene un rol asignado");
                return false;
            }


            if (!Validar.VerificarNroDocumento(textBoxDNI.Text))
            {
                errorProvider1.SetError(textBoxDNI, "Complete bien el Nro de documento");
                return false;
            }

            seleccion.NombreUsuario = textBoxUsuario.Text;
            seleccion.NombreCompleto = textBoxNombre.Text;
            seleccion.Password = Encriptacion.Encriptar(textBoxPassword1.Texto);
            seleccion.DNI = textBoxDNI.Text;
            errorProvider1.Clear();
            return true;

        }




        #endregion



        #region "Eventos"
        void FormPermisos_Load(object sender, EventArgs e)
        {
            oBLLUsu = new BLLUsuario();
            oBLLPermiso = new BLLPermiso();
            bLLUnidad = new BLLUnidad();
            bLLUrsa = new BLLUrsa();

            Unidades = bLLUnidad.ListarTodo();
            Ursas = bLLUrsa.ListarTodo();
            comboBoxUsuarios.DataSource = oBLLUsu.ListarTodo();
            comboBoxRoles.DataSource = oBLLPermiso.ListaRoles();
            comboBoxDestino.DataSource = Ursas;

        }
        void rbtnUrsa_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDestino.DataSource = null;
            comboBoxDestino.DataSource = Ursas;
        }
        void rbtnUnidad_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxDestino.DataSource = null;
            comboBoxDestino.DataSource = Unidades;
        }
        void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seleccion != null)
            {
                if (oBLLUsu.UsuarioTieneRolInstructorOsupervisor(seleccion))
                {
                    groupBoxDestino.Visible = true;

                    if (seleccion.Destino is BEUrsa)
                    {
                        radiobuttonUrsa.Checked = true;
                    }
                    else
                    {
                        RadioButtonUnidad.Checked = true;
                    }
                    comboBoxDestino.SelectedItem = seleccion.Destino;
                }
                else
                {
                    groupBoxDestino.Visible = false;

                }
            }

        }

        #endregion


        #region "Botones"
        private void ButtonConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                HabilitarCargaConfig();
                seleccion = (BEUsuario)comboBoxUsuarios.SelectedItem;
                seleccion = oBLLUsu.ListarObjeto(seleccion);
                labelDestino.Text = seleccion.Destino != null ? seleccion.Destino.ToString() : "No tiene asginada";

                textBoxNombre.Text = seleccion.NombreCompleto;
                textBoxDNI.Text = seleccion.DNI;
                textBoxUsuario.Text = seleccion.NombreUsuario;
                textBoxPassword1.Texto = Encriptacion.Desinciptar(seleccion.Password);
                textBoxPassword2.Texto = Encriptacion.Desinciptar(seleccion.Password);


                if (seleccion.Permisos.Count > 0)
                {
                    MostrarPermisos(seleccion);

                    var rol = seleccion.Permisos.First();

                    foreach (BEComponente item in comboBoxRoles.Items)
                    {
                        if (item.Id == rol.Id)
                        {
                            comboBoxRoles.SelectedItem = item;
                            break;
                        }
                    }
                    comboBoxRoles_SelectedIndexChanged(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ButtonGenerarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                LimpiarFormulario();
                HabilitarCargaNuevo();
                seleccion = new BEUsuario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonDesagsinarRol_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener todos los permisos de un treeview
                var roles = new List<BERol>();

                // Recorrer todos los nodos del TreeView
                foreach (TreeNode nodo in treeViewPermisos.Nodes)
                {
                    if (nodo.Tag is BERol rol && nodo.Checked == true)
                    {
                        roles.Add(rol);
                        seleccion.Permisos.RemoveAll(x => x.Id == rol.Id);
                    }
                }



                if (roles.Count > 0)
                {
                    MessageBox.Show("Los roles se desasignaron exitosamente.", "Desasignación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MostrarPermisos(seleccion);

                }
                else
                {
                    MessageBox.Show("Seleccione los permisos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        void buttonEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (oBLLUsu.Eliminar(seleccion))
                {
                    LimpiarFormulario();
                    DeshabilitarCarga();

                    comboBoxUsuarios.DataSource = oBLLUsu.ListarTodo();
                    MessageBox.Show($"El Usuario  se ha eliminado de la base de datos", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonAsignarRol_Click(object sender, EventArgs e)
        {
            try
            {
                var existe = seleccion.Permisos.Exists(x => x.Id == (comboBoxRoles.SelectedItem as BERol).Id);
                if (!existe)
                {
                    if (seleccion.NombreUsuario == "" || seleccion.NombreUsuario == null)
                    {
                        seleccion.NombreUsuario = textBoxUsuario.Text;
                    }
                    seleccion.Permisos.Add(comboBoxRoles.SelectedItem as BERol);
                    MostrarPermisos(seleccion);
                    comboBoxRoles_SelectedIndexChanged(null, null);
                }
                else
                {
                    MessageBox.Show("El usuario ya posee es rol", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonAsignarDestino_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxDestino.DataSource != null)
                {
                    if (radiobuttonUrsa.Checked)
                    {
                        seleccion.Destino = comboBoxDestino.SelectedItem as BEUrsa;
                    }
                    else
                    {
                        seleccion.Destino = comboBoxDestino.SelectedItem as BEUnidad;
                    }
                    labelDestino.Text = seleccion.Destino?.ToString();
                    MessageBox.Show($"Al usuario {seleccion.NombreUsuario} tiene como destino {comboBoxDestino.Text} ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonDesagniarDestino_Click(object sender, EventArgs e)
        {
            try
            {
                seleccion.Destino = null;
                labelDestino.Text = "No tiene asignada";
                MessageBox.Show("El usuario ya NO posee destino asignado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerficarCamposUsuario())
                {
                    if (oBLLUsu.GuardarUsuario(seleccion))
                    {
                        LimpiarFormulario();
                        DeshabilitarCarga();
                        comboBoxUsuarios.DataSource = oBLLUsu.ListarTodo();
                        MessageBox.Show("Se ha guardado los cambios con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El usuario no tiene asignado ningun destino", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Declarar una variable booleana para evitar bucles infinitos
        private bool changingCheckState = false;

        private void treeViewPermisos_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (!changingCheckState)
                {
                    changingCheckState = true;
                    if (e.Node.Tag is BERol)
                    {
                        // Colocar el estado de los nodos hijos
                        foreach (TreeNode nodoHijo in e.Node.Nodes)
                        {
                            nodoHijo.Checked = e.Node.Checked;
                        }
                    }
                    else
                    {
                        // El nodo es un permiso, por lo tanto, marca al nodo padre

                        TreeNode parentNode = e.Node.Parent;

                        if (parentNode != null)
                        {
                            parentNode.Checked = e.Node.Checked;
                            foreach (TreeNode nodoHijo in parentNode.Nodes)
                            {
                                nodoHijo.Checked = parentNode.Checked;
                            }

                        }
                    }
                    changingCheckState = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}
