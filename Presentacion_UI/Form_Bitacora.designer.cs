﻿namespace Presentacion_UI
{
    partial class Form_Bitacora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Bitacora));
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxCriterio = new System.Windows.Forms.TextBox();
            this.DgvRegistros = new System.Windows.Forms.DataGridView();
            this.Sel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonLimpiar = new Seguridad.RJButton();
            this.buttonBuscar = new Seguridad.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(11, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Criterio";
            // 
            // textBoxCriterio
            // 
            this.textBoxCriterio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxCriterio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxCriterio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCriterio.Location = new System.Drawing.Point(12, 89);
            this.textBoxCriterio.MaxLength = 100;
            this.textBoxCriterio.Name = "textBoxCriterio";
            this.textBoxCriterio.Size = new System.Drawing.Size(182, 24);
            this.textBoxCriterio.TabIndex = 77;
            // 
            // DgvRegistros
            // 
            this.DgvRegistros.AllowUserToAddRows = false;
            this.DgvRegistros.AllowUserToDeleteRows = false;
            this.DgvRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvRegistros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgvRegistros.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sel});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvRegistros.Location = new System.Drawing.Point(217, 50);
            this.DgvRegistros.Margin = new System.Windows.Forms.Padding(2);
            this.DgvRegistros.MultiSelect = false;
            this.DgvRegistros.Name = "DgvRegistros";
            this.DgvRegistros.ReadOnly = true;
            this.DgvRegistros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvRegistros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DgvRegistros.RowHeadersVisible = false;
            this.DgvRegistros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DgvRegistros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DgvRegistros.RowTemplate.Height = 60;
            this.DgvRegistros.RowTemplate.ReadOnly = true;
            this.DgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvRegistros.Size = new System.Drawing.Size(633, 296);
            this.DgvRegistros.TabIndex = 87;
            // 
            // Sel
            // 
            this.Sel.FalseValue = "";
            this.Sel.HeaderText = "Sel";
            this.Sel.IndeterminateValue = "";
            this.Sel.Name = "Sel";
            this.Sel.ReadOnly = true;
            this.Sel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Sel.TrueValue = "";
            this.Sel.Visible = false;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonLimpiar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonLimpiar.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonLimpiar.BorderRadius = 15;
            this.buttonLimpiar.BorderSize = 1;
            this.buttonLimpiar.FlatAppearance.BorderSize = 0;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.ForeColor = System.Drawing.Color.White;
            this.buttonLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("buttonLimpiar.Image")));
            this.buttonLimpiar.Location = new System.Drawing.Point(116, 125);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(78, 40);
            this.buttonLimpiar.TabIndex = 92;
            this.buttonLimpiar.TextColor = System.Drawing.Color.White;
            this.buttonLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.buttonBuscar.BorderColor = System.Drawing.SystemColors.Control;
            this.buttonBuscar.BorderRadius = 15;
            this.buttonBuscar.BorderSize = 1;
            this.buttonBuscar.FlatAppearance.BorderSize = 0;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.White;
            this.buttonBuscar.Image = global::Presentacion_UI.Properties.Resources.lupa;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.Location = new System.Drawing.Point(12, 125);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(98, 40);
            this.buttonBuscar.TabIndex = 91;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextColor = System.Drawing.Color.White;
            this.buttonBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(510, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Registros";
            // 
            // Form_Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(862, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.DgvRegistros);
            this.Controls.Add(this.textBoxCriterio);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Bitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Form_Bitacora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxCriterio;
        private System.Windows.Forms.DataGridView DgvRegistros;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sel;
        private Seguridad.RJButton buttonLimpiar;
        private Seguridad.RJButton buttonBuscar;
        private System.Windows.Forms.Label label1;
    }
}