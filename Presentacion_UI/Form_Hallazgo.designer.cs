﻿using System;

namespace Presentacion_UI
{
    partial class Form_Hallazgo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Hallazgo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHallazgos = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEstado = new System.Windows.Forms.Label();
            this.groupBoxDatosHallazgo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxUnidadHallazgo = new System.Windows.Forms.ComboBox();
            this.labelNroHallazgo = new System.Windows.Forms.Label();
            this.numericUpDownNroHallazgo = new System.Windows.Forms.NumericUpDown();
            this.buttonFinalizarHallazgo = new Seguridad.RJButton();
            this.buttonEliminar = new Seguridad.RJButton();
            this.button_Modificar = new Seguridad.RJButton();
            this.button_Agregar = new Seguridad.RJButton();
            this.textBoxObservacion = new System.Windows.Forms.TextBox();
            this.comboBoxUrsa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaHallazgo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxLugar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxDatosElementos = new System.Windows.Forms.GroupBox();
            this.btnEliminarElemento = new Seguridad.RJButton();
            this.btnModificarElemento = new Seguridad.RJButton();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregarElemento = new Seguridad.RJButton();
            this.NUPCantidad = new System.Windows.Forms.NumericUpDown();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxArticulo = new System.Windows.Forms.ComboBox();
            this.DgvElementos = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonCargarPersonas = new Seguridad.RJButton();
            this.buttonImprimir = new Seguridad.RJButton();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.labelPaginas = new System.Windows.Forms.Label();
            this.ButtonSiguiente = new Krypton.Toolkit.KryptonButton();
            this.ButtonAnterior = new Krypton.Toolkit.KryptonButton();
            this.labelTotalSemanal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallazgos)).BeginInit();
            this.groupBoxDatosHallazgo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNroHallazgo)).BeginInit();
            this.groupBoxDatosElementos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHallazgos
            // 
            this.dgvHallazgos.AllowUserToAddRows = false;
            this.dgvHallazgos.AllowUserToDeleteRows = false;
            resources.ApplyResources(this.dgvHallazgos, "dgvHallazgos");
            this.dgvHallazgos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHallazgos.BackgroundColor = System.Drawing.Color.Black;
            this.dgvHallazgos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHallazgos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvHallazgos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHallazgos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHallazgos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHallazgos.EnableHeadersVisualStyles = false;
            this.dgvHallazgos.MultiSelect = false;
            this.dgvHallazgos.Name = "dgvHallazgos";
            this.dgvHallazgos.ReadOnly = true;
            this.dgvHallazgos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHallazgos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHallazgos.RowHeadersVisible = false;
            this.dgvHallazgos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvHallazgos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHallazgos.RowTemplate.Height = 32;
            this.dgvHallazgos.RowTemplate.ReadOnly = true;
            this.dgvHallazgos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvHallazgos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHallazgos_CellContentClick);
            // 
            // Seleccion
            // 
            this.Seleccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Seleccion.FillWeight = 30F;
            resources.ApplyResources(this.Seleccion, "Seleccion");
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.ReadOnly = true;
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // labelEstado
            // 
            resources.ApplyResources(this.labelEstado, "labelEstado");
            this.labelEstado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEstado.Name = "labelEstado";
            // 
            // groupBoxDatosHallazgo
            // 
            this.groupBoxDatosHallazgo.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDatosHallazgo.Controls.Add(this.label1);
            this.groupBoxDatosHallazgo.Controls.Add(this.comboBoxUnidadHallazgo);
            this.groupBoxDatosHallazgo.Controls.Add(this.labelNroHallazgo);
            this.groupBoxDatosHallazgo.Controls.Add(this.numericUpDownNroHallazgo);
            this.groupBoxDatosHallazgo.Controls.Add(this.buttonFinalizarHallazgo);
            this.groupBoxDatosHallazgo.Controls.Add(this.buttonEliminar);
            this.groupBoxDatosHallazgo.Controls.Add(this.button_Modificar);
            this.groupBoxDatosHallazgo.Controls.Add(this.button_Agregar);
            this.groupBoxDatosHallazgo.Controls.Add(this.textBoxObservacion);
            this.groupBoxDatosHallazgo.Controls.Add(this.comboBoxUrsa);
            this.groupBoxDatosHallazgo.Controls.Add(this.label5);
            this.groupBoxDatosHallazgo.Controls.Add(this.label13);
            this.groupBoxDatosHallazgo.Controls.Add(this.dateTimePickerFechaHallazgo);
            this.groupBoxDatosHallazgo.Controls.Add(this.label4);
            this.groupBoxDatosHallazgo.Controls.Add(this.label17);
            this.groupBoxDatosHallazgo.Controls.Add(this.textBoxLugar);
            this.groupBoxDatosHallazgo.Controls.Add(this.label3);
            resources.ApplyResources(this.groupBoxDatosHallazgo, "groupBoxDatosHallazgo");
            this.groupBoxDatosHallazgo.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatosHallazgo.Name = "groupBoxDatosHallazgo";
            this.groupBoxDatosHallazgo.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // comboBoxUnidadHallazgo
            // 
            this.comboBoxUnidadHallazgo.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxUnidadHallazgo, "comboBoxUnidadHallazgo");
            this.comboBoxUnidadHallazgo.Name = "comboBoxUnidadHallazgo";
            this.comboBoxUnidadHallazgo.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnidadHallazgo_SelectedIndexChanged_1);
            // 
            // labelNroHallazgo
            // 
            this.labelNroHallazgo.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.labelNroHallazgo, "labelNroHallazgo");
            this.labelNroHallazgo.Name = "labelNroHallazgo";
            // 
            // numericUpDownNroHallazgo
            // 
            resources.ApplyResources(this.numericUpDownNroHallazgo, "numericUpDownNroHallazgo");
            this.numericUpDownNroHallazgo.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownNroHallazgo.Name = "numericUpDownNroHallazgo";
            this.numericUpDownNroHallazgo.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDownNroHallazgo.Leave += new System.EventHandler(this.numericUpDownHallazgo_Leave);
            // 
            // buttonFinalizarHallazgo
            // 
            this.buttonFinalizarHallazgo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFinalizarHallazgo.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonFinalizarHallazgo.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonFinalizarHallazgo.BorderRadius = 15;
            this.buttonFinalizarHallazgo.BorderSize = 2;
            this.buttonFinalizarHallazgo.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonFinalizarHallazgo, "buttonFinalizarHallazgo");
            this.buttonFinalizarHallazgo.ForeColor = System.Drawing.Color.White;
            this.buttonFinalizarHallazgo.Name = "buttonFinalizarHallazgo";
            this.buttonFinalizarHallazgo.TextColor = System.Drawing.Color.White;
            this.buttonFinalizarHallazgo.UseVisualStyleBackColor = false;
            this.buttonFinalizarHallazgo.Click += new System.EventHandler(this.buttonFinalizarHallazgo_Click);
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
            // button_Agregar
            // 
            this.button_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(114)))), ((int)(((byte)(1)))));
            this.button_Agregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(114)))), ((int)(((byte)(1)))));
            this.button_Agregar.BorderColor = System.Drawing.Color.White;
            this.button_Agregar.BorderRadius = 15;
            this.button_Agregar.BorderSize = 1;
            this.button_Agregar.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button_Agregar, "button_Agregar");
            this.button_Agregar.ForeColor = System.Drawing.Color.White;
            this.button_Agregar.Name = "button_Agregar";
            this.button_Agregar.TextColor = System.Drawing.Color.White;
            this.button_Agregar.UseVisualStyleBackColor = false;
            this.button_Agregar.Click += new System.EventHandler(this.button_Agregar_Click);
            // 
            // textBoxObservacion
            // 
            this.textBoxObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBoxObservacion, "textBoxObservacion");
            this.textBoxObservacion.Name = "textBoxObservacion";
            // 
            // comboBoxUrsa
            // 
            this.comboBoxUrsa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxUrsa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxUrsa, "comboBoxUrsa");
            this.comboBoxUrsa.FormattingEnabled = true;
            this.comboBoxUrsa.Name = "comboBoxUrsa";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Name = "label5";
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Name = "label13";
            // 
            // dateTimePickerFechaHallazgo
            // 
            resources.ApplyResources(this.dateTimePickerFechaHallazgo, "dateTimePickerFechaHallazgo");
            this.dateTimePickerFechaHallazgo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFechaHallazgo.MaxDate = DateTime.Now;
            this.dateTimePickerFechaHallazgo.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFechaHallazgo.Name = "dateTimePickerFechaHallazgo";
            this.dateTimePickerFechaHallazgo.Value =  DateTime.Now;
            this.dateTimePickerFechaHallazgo.ValueChanged += new System.EventHandler(this.dateTimePickerFechaHallazgo_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Name = "label17";
            // 
            // textBoxLugar
            // 
            this.textBoxLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBoxLugar, "textBoxLugar");
            this.textBoxLugar.Name = "textBoxLugar";
            this.textBoxLugar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLugar_KeyPress);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // groupBoxDatosElementos
            // 
            resources.ApplyResources(this.groupBoxDatosElementos, "groupBoxDatosElementos");
            this.groupBoxDatosElementos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxDatosElementos.Controls.Add(this.btnEliminarElemento);
            this.groupBoxDatosElementos.Controls.Add(this.btnModificarElemento);
            this.groupBoxDatosElementos.Controls.Add(this.label6);
            this.groupBoxDatosElementos.Controls.Add(this.btnAgregarElemento);
            this.groupBoxDatosElementos.Controls.Add(this.NUPCantidad);
            this.groupBoxDatosElementos.Controls.Add(this.comboBoxEstado);
            this.groupBoxDatosElementos.Controls.Add(this.label11);
            this.groupBoxDatosElementos.Controls.Add(this.textBoxDescripcion);
            this.groupBoxDatosElementos.Controls.Add(this.label10);
            this.groupBoxDatosElementos.Controls.Add(this.comboBoxCategoria);
            this.groupBoxDatosElementos.Controls.Add(this.label2);
            this.groupBoxDatosElementos.Controls.Add(this.label9);
            this.groupBoxDatosElementos.Controls.Add(this.label8);
            this.groupBoxDatosElementos.Controls.Add(this.comboBoxArticulo);
            this.groupBoxDatosElementos.ForeColor = System.Drawing.Color.White;
            this.groupBoxDatosElementos.Name = "groupBoxDatosElementos";
            this.groupBoxDatosElementos.TabStop = false;
            // 
            // btnEliminarElemento
            // 
            this.btnEliminarElemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEliminarElemento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnEliminarElemento.BorderColor = System.Drawing.Color.White;
            this.btnEliminarElemento.BorderRadius = 15;
            this.btnEliminarElemento.BorderSize = 1;
            this.btnEliminarElemento.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnEliminarElemento, "btnEliminarElemento");
            this.btnEliminarElemento.ForeColor = System.Drawing.Color.White;
            this.btnEliminarElemento.Name = "btnEliminarElemento";
            this.btnEliminarElemento.TextColor = System.Drawing.Color.White;
            this.btnEliminarElemento.UseVisualStyleBackColor = false;
            this.btnEliminarElemento.Click += new System.EventHandler(this.btnEliminarElemento_Click);
            // 
            // btnModificarElemento
            // 
            this.btnModificarElemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnModificarElemento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnModificarElemento.BorderColor = System.Drawing.Color.White;
            this.btnModificarElemento.BorderRadius = 15;
            this.btnModificarElemento.BorderSize = 1;
            this.btnModificarElemento.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnModificarElemento, "btnModificarElemento");
            this.btnModificarElemento.ForeColor = System.Drawing.Color.Black;
            this.btnModificarElemento.Image = global::Presentacion_UI.Properties.Resources.boton_editar;
            this.btnModificarElemento.Name = "btnModificarElemento";
            this.btnModificarElemento.TextColor = System.Drawing.Color.Black;
            this.btnModificarElemento.UseVisualStyleBackColor = false;
            this.btnModificarElemento.Click += new System.EventHandler(this.btnModificarElemento_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnAgregarElemento
            // 
            this.btnAgregarElemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(114)))), ((int)(((byte)(1)))));
            this.btnAgregarElemento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(114)))), ((int)(((byte)(1)))));
            this.btnAgregarElemento.BorderColor = System.Drawing.Color.White;
            this.btnAgregarElemento.BorderRadius = 15;
            this.btnAgregarElemento.BorderSize = 1;
            this.btnAgregarElemento.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnAgregarElemento, "btnAgregarElemento");
            this.btnAgregarElemento.ForeColor = System.Drawing.Color.White;
            this.btnAgregarElemento.Name = "btnAgregarElemento";
            this.btnAgregarElemento.TextColor = System.Drawing.Color.White;
            this.btnAgregarElemento.UseVisualStyleBackColor = false;
            this.btnAgregarElemento.Click += new System.EventHandler(this.btnAgregarElemento_Click);
            // 
            // NUPCantidad
            // 
            this.NUPCantidad.DecimalPlaces = 2;
            resources.ApplyResources(this.NUPCantidad, "NUPCantidad");
            this.NUPCantidad.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.NUPCantidad.Name = "NUPCantidad";
            this.NUPCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboBoxEstado, "comboBoxEstado");
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Name = "comboBoxEstado";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            resources.ApplyResources(this.textBoxDescripcion, "textBoxDescripcion");
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxCategoria.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxCategoria, "comboBoxCategoria");
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // comboBoxArticulo
            // 
            this.comboBoxArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            resources.ApplyResources(this.comboBoxArticulo, "comboBoxArticulo");
            this.comboBoxArticulo.FormattingEnabled = true;
            this.comboBoxArticulo.Name = "comboBoxArticulo";
            this.comboBoxArticulo.TextChanged += new System.EventHandler(this.comboBoxArticulo_TextChanged);
            this.comboBoxArticulo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxArticulo_KeyDown);
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DgvElementos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DgvElementos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.DefaultCellStyle = dataGridViewCellStyle6;
            this.DgvElementos.EnableHeadersVisualStyles = false;
            this.DgvElementos.MultiSelect = false;
            this.DgvElementos.Name = "DgvElementos";
            this.DgvElementos.ReadOnly = true;
            this.DgvElementos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvElementos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DgvElementos.RowHeadersVisible = false;
            this.DgvElementos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.DgvElementos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DgvElementos.RowTemplate.Height = 32;
            this.DgvElementos.RowTemplate.ReadOnly = true;
            this.DgvElementos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DgvElementos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewElementos_CellContentClick);
            // 
            // Sel
            // 
            this.Sel.FalseValue = "";
            resources.ApplyResources(this.Sel, "Sel");
            this.Sel.IndeterminateValue = "";
            this.Sel.Name = "Sel";
            this.Sel.ReadOnly = true;
            this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sel.TrueValue = "";
            // 
            // buttonCargarPersonas
            // 
            this.buttonCargarPersonas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonCargarPersonas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.buttonCargarPersonas.BorderColor = System.Drawing.Color.White;
            this.buttonCargarPersonas.BorderRadius = 15;
            this.buttonCargarPersonas.BorderSize = 1;
            this.buttonCargarPersonas.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonCargarPersonas, "buttonCargarPersonas");
            this.buttonCargarPersonas.ForeColor = System.Drawing.Color.White;
            this.buttonCargarPersonas.Name = "buttonCargarPersonas";
            this.buttonCargarPersonas.TextColor = System.Drawing.Color.White;
            this.buttonCargarPersonas.UseVisualStyleBackColor = false;
            this.buttonCargarPersonas.Click += new System.EventHandler(this.buttonCargarPersonas_Click);
            // 
            // buttonImprimir
            // 
            this.buttonImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonImprimir.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonImprimir.BorderColor = System.Drawing.Color.White;
            this.buttonImprimir.BorderRadius = 15;
            this.buttonImprimir.BorderSize = 1;
            this.buttonImprimir.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonImprimir, "buttonImprimir");
            this.buttonImprimir.ForeColor = System.Drawing.Color.White;
            this.buttonImprimir.Image = global::Presentacion_UI.Properties.Resources.impresora__2_;
            this.buttonImprimir.Name = "buttonImprimir";
            this.buttonImprimir.TextColor = System.Drawing.Color.White;
            this.buttonImprimir.UseVisualStyleBackColor = false;
            this.buttonImprimir.Click += new System.EventHandler(this.buttonImprimir_Click);
            // 
            // circularProgressBar1
            // 
            resources.ApplyResources(this.circularProgressBar1, "circularProgressBar1");
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.CubicEaseIn;
            this.circularProgressBar1.AnimationSpeed = 700;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.ForeColor = System.Drawing.Color.White;
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Black;
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Gray;
            this.circularProgressBar1.OuterMargin = -20;
            this.circularProgressBar1.OuterWidth = 20;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.circularProgressBar1.ProgressWidth = 20;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.StartAngle = 30;
            this.circularProgressBar1.Step = 5;
            this.circularProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.Black;
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(0);
            this.circularProgressBar1.Value = 25;
            // 
            // labelPaginas
            // 
            resources.ApplyResources(this.labelPaginas, "labelPaginas");
            this.labelPaginas.ForeColor = System.Drawing.Color.White;
            this.labelPaginas.Name = "labelPaginas";
            // 
            // ButtonSiguiente
            // 
            resources.ApplyResources(this.ButtonSiguiente, "ButtonSiguiente");
            this.ButtonSiguiente.CornerRoundingRadius = -1F;
            this.ButtonSiguiente.Name = "ButtonSiguiente";
            this.ButtonSiguiente.PaletteMode = Krypton.Toolkit.PaletteMode.Office365SilverDarkMode;
            this.ButtonSiguiente.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonSiguiente.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonSiguiente.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSiguiente.StateCommon.Back.Image")));
            this.ButtonSiguiente.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonSiguiente.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonSiguiente.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonSiguiente.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonSiguiente.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonSiguiente.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this.ButtonSiguiente.StateNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSiguiente.StateNormal.Back.Image")));
            this.ButtonSiguiente.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonSiguiente.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonSiguiente.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.ButtonSiguiente.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.ButtonSiguiente.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonSiguiente.StateNormal.Border.Rounding = 20F;
            this.ButtonSiguiente.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ButtonSiguiente.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ButtonSiguiente.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ButtonSiguiente.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonSiguiente.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonSiguiente.StatePressed.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonSiguiente.StatePressed.Back.Image")));
            this.ButtonSiguiente.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonSiguiente.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonSiguiente.Values.Text = resources.GetString("ButtonSiguiente.Values.Text");
            this.ButtonSiguiente.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ButtonAnterior
            // 
            resources.ApplyResources(this.ButtonAnterior, "ButtonAnterior");
            this.ButtonAnterior.CornerRoundingRadius = -1F;
            this.ButtonAnterior.Name = "ButtonAnterior";
            this.ButtonAnterior.PaletteMode = Krypton.Toolkit.PaletteMode.Office365SilverDarkMode;
            this.ButtonAnterior.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonAnterior.StateCommon.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonAnterior.StateCommon.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.ButtonAnterior.StateCommon.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAnterior.StateCommon.Back.Image")));
            this.ButtonAnterior.StateCommon.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonAnterior.StateCommon.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonAnterior.StateCommon.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ButtonAnterior.StateNormal.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonAnterior.StateNormal.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonAnterior.StateNormal.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.SolidInside;
            this.ButtonAnterior.StateNormal.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAnterior.StateNormal.Back.Image")));
            this.ButtonAnterior.StateNormal.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonAnterior.StateNormal.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonAnterior.StateNormal.Border.Color1 = System.Drawing.Color.Transparent;
            this.ButtonAnterior.StateNormal.Border.Color2 = System.Drawing.Color.Transparent;
            this.ButtonAnterior.StateNormal.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonAnterior.StateNormal.Border.Rounding = 20F;
            this.ButtonAnterior.StateNormal.Content.Image.ImageH = Krypton.Toolkit.PaletteRelativeAlign.Center;
            this.ButtonAnterior.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ButtonAnterior.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ButtonAnterior.StatePressed.Back.Color1 = System.Drawing.Color.Black;
            this.ButtonAnterior.StatePressed.Back.Color2 = System.Drawing.Color.Black;
            this.ButtonAnterior.StatePressed.Back.ColorStyle = Krypton.Toolkit.PaletteColorStyle.Solid;
            this.ButtonAnterior.StatePressed.Back.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAnterior.StatePressed.Back.Image")));
            this.ButtonAnterior.StatePressed.Back.ImageAlign = Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.ButtonAnterior.StatePressed.Back.ImageStyle = Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.ButtonAnterior.Values.Text = resources.GetString("ButtonAnterior.Values.Text");
            this.ButtonAnterior.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // labelTotalSemanal
            // 
            resources.ApplyResources(this.labelTotalSemanal, "labelTotalSemanal");
            this.labelTotalSemanal.ForeColor = System.Drawing.Color.White;
            this.labelTotalSemanal.Name = "labelTotalSemanal";
            // 
            // Form_Hallazgo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.labelTotalSemanal);
            this.Controls.Add(this.ButtonAnterior);
            this.Controls.Add(this.circularProgressBar1);
            this.Controls.Add(this.ButtonSiguiente);
            this.Controls.Add(this.buttonImprimir);
            this.Controls.Add(this.labelPaginas);
            this.Controls.Add(this.buttonCargarPersonas);
            this.Controls.Add(this.DgvElementos);
            this.Controls.Add(this.groupBoxDatosElementos);
            this.Controls.Add(this.groupBoxDatosHallazgo);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.dgvHallazgos);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundCustom1;
            this.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.InputControlCustom1;
            this.Name = "Form_Hallazgo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StateCommon.Back.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.StateCommon.Back.ColorAngle = -10F;
            this.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.Black;
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(10, -2, -2, -2);
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Hallazgo_FormClosing);
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHallazgos)).EndInit();
            this.groupBoxDatosHallazgo.ResumeLayout(false);
            this.groupBoxDatosHallazgo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNroHallazgo)).EndInit();
            this.groupBoxDatosElementos.ResumeLayout(false);
            this.groupBoxDatosElementos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUPCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvElementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHallazgos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.GroupBox groupBoxDatosHallazgo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaHallazgo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxLugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBoxDatosElementos;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxArticulo;
        private System.Windows.Forms.DataGridView DgvElementos;
        private System.Windows.Forms.NumericUpDown NUPCantidad;
        private System.Windows.Forms.TextBox textBoxObservacion;
        private System.Windows.Forms.ComboBox comboBoxUrsa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private Seguridad.RJButton buttonEliminar;
        private Seguridad.RJButton button_Modificar;
        private Seguridad.RJButton button_Agregar;
        private Seguridad.RJButton buttonFinalizarHallazgo;
        private Seguridad.RJButton btnEliminarElemento;
        private Seguridad.RJButton btnModificarElemento;
        private Seguridad.RJButton btnAgregarElemento;
        private Seguridad.RJButton buttonCargarPersonas;
        private Seguridad.RJButton buttonImprimir;
        private System.Windows.Forms.NumericUpDown numericUpDownNroHallazgo;
        private System.Windows.Forms.Label labelNroHallazgo;
        private System.Windows.Forms.ComboBox comboBoxUnidadHallazgo;
        private System.Windows.Forms.Label label1;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Label labelPaginas;
        private Krypton.Toolkit.KryptonButton ButtonSiguiente;
        private Krypton.Toolkit.KryptonButton ButtonAnterior;
        private System.Windows.Forms.Label labelTotalSemanal;
    }
}

