using System;

namespace Presentacion_UI
{
    partial class Form_GestionEntrega
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_GestionEntrega));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.DgvElementos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvPersonas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.comboBoxUnidad = new System.Windows.Forms.ComboBox();
            this.dgvEntregas = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxUrsa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.button_Modificar = new Seguridad.RJButton();
            this.buttonEliminar = new Seguridad.RJButton();
            this.numericUpDownNroEntrega = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNroEntrega = new System.Windows.Forms.Label();
            this.buttonLimpiar = new Seguridad.RJButton();
            this.buttonBuscar = new Seguridad.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTitleIntervinientes = new System.Windows.Forms.Label();
            this.labelTitleElementos = new System.Windows.Forms.Label();
            this.labelTitleEntregas = new System.Windows.Forms.Label();
            this.labelTotalSemanal = new System.Windows.Forms.Label();
            this.ButtonAnteriorEntrega = new Krypton.Toolkit.KryptonButton();
            this.ButtonSiguienteEntrega = new Krypton.Toolkit.KryptonButton();
            this.labelPaginasEntrega = new System.Windows.Forms.Label();
            this.circularProgressBar2 = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.DgvElementos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNroEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label32
            // 
            this.label32.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.label32, "label32");
            this.label32.Name = "label32";
            // 
            // DgvElementos
            // 
            this.DgvElementos.AllowUserToAddRows = false;
            this.DgvElementos.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.DgvElementos, "DgvElementos");
            this.DgvElementos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvElementos.BackgroundColor = System.Drawing.Color.Black;
            this.DgvElementos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvElementos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvElementos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvElementos.EnableHeadersVisualStyles = false;
            this.DgvElementos.MultiSelect = false;
            this.DgvElementos.Name = "DgvElementos";
            this.DgvElementos.ReadOnly = true;
            this.DgvElementos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvElementos.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DgvElementos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvElementos.RowTemplate.Height = 32;
            this.DgvElementos.RowTemplate.ReadOnly = true;
            this.DgvElementos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // DgvPersonas
            // 
            this.DgvPersonas.AllowUserToAddRows = false;
            this.DgvPersonas.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.DgvPersonas, "DgvPersonas");
            this.DgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPersonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvPersonas.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvPersonas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DgvPersonas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvPersonas.EnableHeadersVisualStyles = false;
            this.DgvPersonas.MultiSelect = false;
            this.DgvPersonas.Name = "DgvPersonas";
            this.DgvPersonas.ReadOnly = true;
            this.DgvPersonas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvPersonas.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.DgvPersonas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvPersonas.RowTemplate.Height = 60;
            this.DgvPersonas.RowTemplate.ReadOnly = true;
            this.DgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // dateTimePickerFechaEntrega
            // 
            resources.ApplyResources(this.dateTimePickerFechaEntrega, "dateTimePickerFechaEntrega");
            this.dateTimePickerFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaEntrega.MaxDate = DateTime.Now;
            this.dateTimePickerFechaEntrega.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaEntrega.Name = "dateTimePickerFechaEntrega";
            this.dateTimePickerFechaEntrega.Value =  DateTime.Now;
            this.dateTimePickerFechaEntrega.ValueChanged += new System.EventHandler(this.dateTimePickerFechaHallazgo_ValueChanged);
            // 
            // comboBoxUnidad
            // 
            this.comboBoxUnidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUnidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxUnidad, "comboBoxUnidad");
            this.comboBoxUnidad.FormattingEnabled = true;
            this.comboBoxUnidad.Name = "comboBoxUnidad";
            this.comboBoxUnidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnidad_SelectedIndexChanged);
            // 
            // dgvEntregas
            // 
            this.dgvEntregas.AllowUserToAddRows = false;
            this.dgvEntregas.AllowUserToDeleteRows = false;
            this.dgvEntregas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntregas.BackgroundColor = System.Drawing.Color.Black;
            this.dgvEntregas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntregas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEntregas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            resources.ApplyResources(this.dgvEntregas, "dgvEntregas");
            this.dgvEntregas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEntregas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregas.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvEntregas.EnableHeadersVisualStyles = false;
            this.dgvEntregas.MultiSelect = false;
            this.dgvEntregas.Name = "dgvEntregas";
            this.dgvEntregas.ReadOnly = true;
            this.dgvEntregas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntregas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvEntregas.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            this.dgvEntregas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvEntregas.RowTemplate.Height = 32;
            this.dgvEntregas.RowTemplate.ReadOnly = true;
            this.dgvEntregas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvEntregas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHallazgos_CellContentClick);
            // 
            // Seleccion
            // 
            this.Seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seleccion.FillWeight = 30F;
            resources.ApplyResources(this.Seleccion, "Seleccion");
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.ReadOnly = true;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // comboBoxUrsa
            // 
            this.comboBoxUrsa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUrsa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxUrsa, "comboBoxUrsa");
            this.comboBoxUrsa.FormattingEnabled = true;
            this.comboBoxUrsa.Name = "comboBoxUrsa";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.Snow;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBoxObservacion, "textBoxObservacion");
            this.textBoxObservacion.Name = "textBoxObservacion";
            // 
            // button_Modificar
            // 
            this.button_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button_Modificar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.button_Modificar.BorderColor = System.Drawing.Color.White;
            this.button_Modificar.BorderRadius = 15;
            this.button_Modificar.BorderSize = 1;
            this.button_Modificar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Modificar, "button_Modificar");
            this.button_Modificar.ForeColor = System.Drawing.Color.Black;
            this.button_Modificar.Image = global::Presentacion_UI.Properties.Resources.boton_editar;
            this.button_Modificar.Name = "button_Modificar";
            this.button_Modificar.TextColor = System.Drawing.Color.Black;
            this.button_Modificar.UseVisualStyleBackColor = false;
            this.button_Modificar.Click += new System.EventHandler(this.button_Modificar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonEliminar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonEliminar.BorderColor = System.Drawing.Color.White;
            this.buttonEliminar.BorderRadius = 15;
            this.buttonEliminar.BorderSize = 1;
            this.buttonEliminar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonEliminar, "buttonEliminar");
            this.buttonEliminar.ForeColor = System.Drawing.Color.White;
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.TextColor = System.Drawing.Color.White;
            this.buttonEliminar.UseVisualStyleBackColor = false;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // numericUpDownNroEntrega
            // 
            resources.ApplyResources(this.numericUpDownNroEntrega, "numericUpDownNroEntrega");
            this.numericUpDownNroEntrega.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownNroEntrega.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNroEntrega.Name = "numericUpDownNroEntrega";
            this.numericUpDownNroEntrega.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNroEntrega.ValueChanged += new System.EventHandler(this.numericUpDownNroEntrega_ValueChanged);
            this.numericUpDownNroEntrega.Leave += new System.EventHandler(this.numericUpDownNroEntrega_Leave);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Name = "label6";
            // 
            // labelNroEntrega
            // 
            resources.ApplyResources(this.labelNroEntrega, "labelNroEntrega");
            this.labelNroEntrega.ForeColor = System.Drawing.Color.White;
            this.labelNroEntrega.Name = "labelNroEntrega";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonLimpiar.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonLimpiar.BorderRadius = 15;
            this.buttonLimpiar.BorderSize = 1;
            this.buttonLimpiar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonLimpiar, "buttonLimpiar");
            this.buttonLimpiar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.TextColor = System.Drawing.Color.White;
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonBuscar.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonBuscar.BorderRadius = 15;
            this.buttonBuscar.BorderSize = 1;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonBuscar, "buttonBuscar");
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Image = global::Presentacion_UI.Properties.Resources.lupa;
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.TextColor = System.Drawing.Color.White;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // labelTitleIntervinientes
            // 
            resources.ApplyResources(this.labelTitleIntervinientes, "labelTitleIntervinientes");
            this.labelTitleIntervinientes.ForeColor = System.Drawing.Color.White;
            this.labelTitleIntervinientes.Name = "labelTitleIntervinientes";
            // 
            // labelTitleElementos
            // 
            resources.ApplyResources(this.labelTitleElementos, "labelTitleElementos");
            this.labelTitleElementos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitleElementos.Name = "labelTitleElementos";
            // 
            // labelTitleEntregas
            // 
            resources.ApplyResources(this.labelTitleEntregas, "labelTitleEntregas");
            this.labelTitleEntregas.ForeColor = System.Drawing.Color.Snow;
            this.labelTitleEntregas.Name = "labelTitleEntregas";
            // 
            // labelTotalSemanal
            // 
            resources.ApplyResources(this.labelTotalSemanal, "labelTotalSemanal");
            this.labelTotalSemanal.ForeColor = System.Drawing.Color.White;
            this.labelTotalSemanal.Name = "labelTotalSemanal";
            // 
            // ButtonAnteriorEntrega
            // 
            resources.ApplyResources(this.ButtonAnteriorEntrega, "ButtonAnteriorEntrega");
            this.ButtonAnteriorEntrega.CornerRoundingRadius = -1F;
            this.ButtonAnteriorEntrega.Name = "ButtonAnteriorEntrega";
            this.ButtonAnteriorEntrega.PaletteMode = Krypton.Toolkit.PaletteMode.Office365SilverDarkMode;
            this.ButtonAnteriorEntrega.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonAnteriorEntrega.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonAnteriorEntrega.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.ButtonAnteriorEntrega.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAnteriorEntrega.StateCommon.Back.Image")));
            this.ButtonAnteriorEntrega.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonAnteriorEntrega.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonAnteriorEntrega.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonAnteriorEntrega.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonAnteriorEntrega.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonAnteriorEntrega.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this.ButtonAnteriorEntrega.StateNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAnteriorEntrega.StateNormal.Back.Image")));
            this.ButtonAnteriorEntrega.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonAnteriorEntrega.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonAnteriorEntrega.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.ButtonAnteriorEntrega.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.ButtonAnteriorEntrega.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonAnteriorEntrega.StateNormal.Border.Rounding = 20F;
            this.ButtonAnteriorEntrega.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ButtonAnteriorEntrega.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ButtonAnteriorEntrega.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ButtonAnteriorEntrega.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonAnteriorEntrega.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonAnteriorEntrega.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.ButtonAnteriorEntrega.StatePressed.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAnteriorEntrega.StatePressed.Back.Image")));
            this.ButtonAnteriorEntrega.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonAnteriorEntrega.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonAnteriorEntrega.Values.Text = resources.GetString("ButtonAnteriorEntrega.Values.Text");
            this.ButtonAnteriorEntrega.Click += new System.EventHandler(this.btnPreviousEntrega_Click);
            // 
            // ButtonSiguienteEntrega
            // 
            resources.ApplyResources(this.ButtonSiguienteEntrega, "ButtonSiguienteEntrega");
            this.ButtonSiguienteEntrega.CornerRoundingRadius = -1F;
            this.ButtonSiguienteEntrega.Name = "ButtonSiguienteEntrega";
            this.ButtonSiguienteEntrega.PaletteMode = Krypton.Toolkit.PaletteMode.Office365SilverDarkMode;
            this.ButtonSiguienteEntrega.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonSiguienteEntrega.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonSiguienteEntrega.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSiguienteEntrega.StateCommon.Back.Image")));
            this.ButtonSiguienteEntrega.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonSiguienteEntrega.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonSiguienteEntrega.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonSiguienteEntrega.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonSiguienteEntrega.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonSiguienteEntrega.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this.ButtonSiguienteEntrega.StateNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSiguienteEntrega.StateNormal.Back.Image")));
            this.ButtonSiguienteEntrega.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonSiguienteEntrega.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonSiguienteEntrega.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.ButtonSiguienteEntrega.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.ButtonSiguienteEntrega.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonSiguienteEntrega.StateNormal.Border.Rounding = 20F;
            this.ButtonSiguienteEntrega.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ButtonSiguienteEntrega.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ButtonSiguienteEntrega.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ButtonSiguienteEntrega.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonSiguienteEntrega.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonSiguienteEntrega.StatePressed.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSiguienteEntrega.StatePressed.Back.Image")));
            this.ButtonSiguienteEntrega.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonSiguienteEntrega.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonSiguienteEntrega.Values.Text = resources.GetString("ButtonSiguienteEntrega.Values.Text");
            this.ButtonSiguienteEntrega.Click += new System.EventHandler(this.btnNextEntrega_Click);
            // 
            // labelPaginasEntrega
            // 
            resources.ApplyResources(this.labelPaginasEntrega, "labelPaginasEntrega");
            this.labelPaginasEntrega.ForeColor = System.Drawing.Color.White;
            this.labelPaginasEntrega.Name = "labelPaginasEntrega";
            // 
            // circularProgressBar2
            // 
            resources.ApplyResources(this.circularProgressBar2, "circularProgressBar2");
            this.circularProgressBar2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.QuinticEaseOut;
            this.circularProgressBar2.AnimationSpeed = 1500;
            this.circularProgressBar2.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar2.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar2.InnerColor = System.Drawing.Color.Black;
            this.circularProgressBar2.InnerMargin = 2;
            this.circularProgressBar2.InnerWidth = -1;
            this.circularProgressBar2.MarqueeAnimationSpeed = 1500;
            this.circularProgressBar2.Name = "circularProgressBar2";
            this.circularProgressBar2.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar2.OuterMargin = -25;
            this.circularProgressBar2.OuterWidth = 26;
            this.circularProgressBar2.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.circularProgressBar2.ProgressWidth = 10;
            this.circularProgressBar2.SecondaryFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar2.StartAngle = 30;
            this.circularProgressBar2.Step = 5;
            this.circularProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar2.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.circularProgressBar2.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar2.SubscriptText = "";
            this.circularProgressBar2.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar2.SuperscriptText = "";
            this.circularProgressBar2.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar2.Value = 30;
            // 
            // Form_GestionEntrega
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.circularProgressBar2);
            this.Controls.Add(this.labelTotalSemanal);
            this.Controls.Add(this.ButtonAnteriorEntrega);
            this.Controls.Add(this.ButtonSiguienteEntrega);
            this.Controls.Add(this.labelPaginasEntrega);
            this.Controls.Add(this.labelTitleIntervinientes);
            this.Controls.Add(this.labelTitleElementos);
            this.Controls.Add(this.labelTitleEntregas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgvElementos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DgvPersonas);
            this.Controls.Add(this.numericUpDownNroEntrega);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerFechaEntrega);
            this.Controls.Add(this.labelNroEntrega);
            this.Controls.Add(this.comboBoxUnidad);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.comboBoxUrsa);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxObservacion);
            this.Controls.Add(this.button_Modificar);
            this.Controls.Add(this.dgvEntregas);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_GestionEntrega";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.Black;
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Header.Border.Color2 = System.Drawing.Color.Black;
            this.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvElementos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntregas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNroEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.DataGridView DgvElementos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvPersonas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaEntrega;
        private System.Windows.Forms.ComboBox comboBoxUnidad;
        private System.Windows.Forms.DataGridView dgvEntregas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxUrsa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private Seguridad.RJButton button_Modificar;
        private Seguridad.RJButton buttonEliminar;
        private Seguridad.RJButton buttonBuscar;
        private Seguridad.RJButton buttonLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNroEntrega;
        private System.Windows.Forms.NumericUpDown numericUpDownNroEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTitleIntervinientes;
        private System.Windows.Forms.Label labelTitleElementos;
        private System.Windows.Forms.Label labelTitleEntregas;
        private System.Windows.Forms.Label labelTotalSemanal;
        private Krypton.Toolkit.KryptonButton ButtonAnteriorEntrega;
        private Krypton.Toolkit.KryptonButton ButtonSiguienteEntrega;
        private System.Windows.Forms.Label labelPaginasEntrega;
        public CircularProgressBar.CircularProgressBar circularProgressBar2;
    }
}

