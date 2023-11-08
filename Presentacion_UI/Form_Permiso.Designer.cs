namespace Presentacion_UI
{
    partial class Form_Permiso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Permiso));
            this.treeRol = new System.Windows.Forms.TreeView();
            this.labelRol = new System.Windows.Forms.Label();
            this.txtNombreRol = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPermisos = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboRol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.ButtonEliminarRol = new Seguridad.RJButton();
            this.ButtonGuardarRol = new Seguridad.RJButton();
            this.ButtonAgregarPermiso = new Seguridad.RJButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonCreaRol = new Seguridad.RJButton();
            this.ButtonConfiguracion = new Seguridad.RJButton();
            this.groupBoxConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeRol
            // 
            this.treeRol.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.treeRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeRol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeRol.ForeColor = System.Drawing.Color.White;
            this.treeRol.Location = new System.Drawing.Point(266, 37);
            this.treeRol.Margin = new System.Windows.Forms.Padding(2);
            this.treeRol.Name = "treeRol";
            this.treeRol.Size = new System.Drawing.Size(253, 193);
            this.treeRol.TabIndex = 0;
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRol.Location = new System.Drawing.Point(433, 19);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(0, 16);
            this.labelRol.TabIndex = 11;
            // 
            // txtNombreRol
            // 
            this.txtNombreRol.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreRol.Location = new System.Drawing.Point(7, 154);
            this.txtNombreRol.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreRol.Name = "txtNombreRol";
            this.txtNombreRol.Size = new System.Drawing.Size(182, 23);
            this.txtNombreRol.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Nombre del Rol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Permisos de: ";
            // 
            // cboPermisos
            // 
            this.cboPermisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPermisos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPermisos.FormattingEnabled = true;
            this.cboPermisos.Location = new System.Drawing.Point(16, 52);
            this.cboPermisos.Margin = new System.Windows.Forms.Padding(2);
            this.cboPermisos.Name = "cboPermisos";
            this.cboPermisos.Size = new System.Drawing.Size(234, 24);
            this.cboPermisos.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Permisos";
            // 
            // cboRol
            // 
            this.cboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRol.FormattingEnabled = true;
            this.cboRol.Location = new System.Drawing.Point(7, 41);
            this.cboRol.Margin = new System.Windows.Forms.Padding(2);
            this.cboRol.Name = "cboRol";
            this.cboRol.Size = new System.Drawing.Size(182, 24);
            this.cboRol.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Roles";
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.treeRol);
            this.groupBoxConfig.Controls.Add(this.cboPermisos);
            this.groupBoxConfig.Controls.Add(this.ButtonEliminarRol);
            this.groupBoxConfig.Controls.Add(this.label1);
            this.groupBoxConfig.Controls.Add(this.label2);
            this.groupBoxConfig.Controls.Add(this.ButtonGuardarRol);
            this.groupBoxConfig.Controls.Add(this.labelRol);
            this.groupBoxConfig.Controls.Add(this.ButtonAgregarPermiso);
            this.groupBoxConfig.Enabled = false;
            this.groupBoxConfig.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConfig.ForeColor = System.Drawing.Color.White;
            this.groupBoxConfig.Location = new System.Drawing.Point(242, 13);
            this.groupBoxConfig.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxConfig.Size = new System.Drawing.Size(534, 241);
            this.groupBoxConfig.TabIndex = 45;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Configuración";
            // 
            // ButtonEliminarRol
            // 
            this.ButtonEliminarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ButtonEliminarRol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ButtonEliminarRol.BorderColor = System.Drawing.Color.White;
            this.ButtonEliminarRol.BorderRadius = 15;
            this.ButtonEliminarRol.BorderSize = 1;
            this.ButtonEliminarRol.FlatAppearance.BorderSize = 0;
            this.ButtonEliminarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEliminarRol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEliminarRol.ForeColor = System.Drawing.Color.White;
            this.ButtonEliminarRol.Image = ((System.Drawing.Image)(resources.GetObject("ButtonEliminarRol.Image")));
            this.ButtonEliminarRol.Location = new System.Drawing.Point(137, 91);
            this.ButtonEliminarRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonEliminarRol.Name = "ButtonEliminarRol";
            this.ButtonEliminarRol.Size = new System.Drawing.Size(113, 35);
            this.ButtonEliminarRol.TabIndex = 44;
            this.ButtonEliminarRol.Text = "Quitar";
            this.ButtonEliminarRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonEliminarRol.TextColor = System.Drawing.Color.White;
            this.ButtonEliminarRol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonEliminarRol.UseVisualStyleBackColor = false;
            this.ButtonEliminarRol.Click += new System.EventHandler(this.buttonEliminarPermiso_Click);
            // 
            // ButtonGuardarRol
            // 
            this.ButtonGuardarRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ButtonGuardarRol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ButtonGuardarRol.BorderColor = System.Drawing.Color.White;
            this.ButtonGuardarRol.BorderRadius = 15;
            this.ButtonGuardarRol.BorderSize = 1;
            this.ButtonGuardarRol.FlatAppearance.BorderSize = 0;
            this.ButtonGuardarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGuardarRol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGuardarRol.ForeColor = System.Drawing.Color.White;
            this.ButtonGuardarRol.Location = new System.Drawing.Point(27, 192);
            this.ButtonGuardarRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonGuardarRol.Name = "ButtonGuardarRol";
            this.ButtonGuardarRol.Size = new System.Drawing.Size(207, 38);
            this.ButtonGuardarRol.TabIndex = 41;
            this.ButtonGuardarRol.Text = "Guardar Rol";
            this.ButtonGuardarRol.TextColor = System.Drawing.Color.White;
            this.ButtonGuardarRol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonGuardarRol.UseVisualStyleBackColor = false;
            this.ButtonGuardarRol.Click += new System.EventHandler(this.btnGuardarRol_Click);
            // 
            // ButtonAgregarPermiso
            // 
            this.ButtonAgregarPermiso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(114)))), ((int)(((byte)(1)))));
            this.ButtonAgregarPermiso.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(114)))), ((int)(((byte)(1)))));
            this.ButtonAgregarPermiso.BorderColor = System.Drawing.Color.White;
            this.ButtonAgregarPermiso.BorderRadius = 15;
            this.ButtonAgregarPermiso.BorderSize = 1;
            this.ButtonAgregarPermiso.FlatAppearance.BorderSize = 0;
            this.ButtonAgregarPermiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAgregarPermiso.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAgregarPermiso.ForeColor = System.Drawing.Color.White;
            this.ButtonAgregarPermiso.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAgregarPermiso.Image")));
            this.ButtonAgregarPermiso.Location = new System.Drawing.Point(16, 91);
            this.ButtonAgregarPermiso.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonAgregarPermiso.Name = "ButtonAgregarPermiso";
            this.ButtonAgregarPermiso.Size = new System.Drawing.Size(105, 35);
            this.ButtonAgregarPermiso.TabIndex = 44;
            this.ButtonAgregarPermiso.Text = "Asignar ";
            this.ButtonAgregarPermiso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonAgregarPermiso.TextColor = System.Drawing.Color.White;
            this.ButtonAgregarPermiso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonAgregarPermiso.UseVisualStyleBackColor = false;
            this.ButtonAgregarPermiso.Click += new System.EventHandler(this.btnAgregarPermiso_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ButtonCreaRol);
            this.groupBox2.Controls.Add(this.txtNombreRol);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboRol);
            this.groupBox2.Controls.Add(this.ButtonConfiguracion);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(221, 241);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rol";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(490, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 11;
            // 
            // ButtonCreaRol
            // 
            this.ButtonCreaRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(114)))), ((int)(((byte)(1)))));
            this.ButtonCreaRol.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(114)))), ((int)(((byte)(1)))));
            this.ButtonCreaRol.BorderColor = System.Drawing.Color.White;
            this.ButtonCreaRol.BorderRadius = 15;
            this.ButtonCreaRol.BorderSize = 1;
            this.ButtonCreaRol.FlatAppearance.BorderSize = 0;
            this.ButtonCreaRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCreaRol.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCreaRol.ForeColor = System.Drawing.Color.White;
            this.ButtonCreaRol.Image = ((System.Drawing.Image)(resources.GetObject("ButtonCreaRol.Image")));
            this.ButtonCreaRol.Location = new System.Drawing.Point(7, 183);
            this.ButtonCreaRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonCreaRol.Name = "ButtonCreaRol";
            this.ButtonCreaRol.Size = new System.Drawing.Size(101, 35);
            this.ButtonCreaRol.TabIndex = 43;
            this.ButtonCreaRol.Text = " Crear";
            this.ButtonCreaRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonCreaRol.TextColor = System.Drawing.Color.White;
            this.ButtonCreaRol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonCreaRol.UseVisualStyleBackColor = false;
            this.ButtonCreaRol.Click += new System.EventHandler(this.buttonCrearRol_Click);
            // 
            // ButtonConfiguracion
            // 
            this.ButtonConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ButtonConfiguracion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ButtonConfiguracion.BorderColor = System.Drawing.Color.White;
            this.ButtonConfiguracion.BorderRadius = 15;
            this.ButtonConfiguracion.BorderSize = 1;
            this.ButtonConfiguracion.FlatAppearance.BorderSize = 0;
            this.ButtonConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonConfiguracion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfiguracion.ForeColor = System.Drawing.Color.White;
            this.ButtonConfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("ButtonConfiguracion.Image")));
            this.ButtonConfiguracion.Location = new System.Drawing.Point(7, 71);
            this.ButtonConfiguracion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonConfiguracion.Name = "ButtonConfiguracion";
            this.ButtonConfiguracion.Size = new System.Drawing.Size(120, 35);
            this.ButtonConfiguracion.TabIndex = 38;
            this.ButtonConfiguracion.Text = "Configurar";
            this.ButtonConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonConfiguracion.TextColor = System.Drawing.Color.White;
            this.ButtonConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonConfiguracion.UseVisualStyleBackColor = false;
            this.ButtonConfiguracion.Click += new System.EventHandler(this.btnSeleccionarRol_Click);
            // 
            // Form_Permiso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(788, 264);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxConfig);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Permiso";
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
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 8.75F, System.Drawing.FontStyle.Bold);
            this.Text = "Gestión Permisos";
            this.Load += new System.EventHandler(this.FormPermisos_Load);
            this.groupBoxConfig.ResumeLayout(false);
            this.groupBoxConfig.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView treeRol;
        private System.Windows.Forms.TextBox txtNombreRol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboPermisos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRol;
        private Seguridad.RJButton ButtonConfiguracion;
        private Seguridad.RJButton ButtonEliminarRol;
        private Seguridad.RJButton ButtonAgregarPermiso;
        private Seguridad.RJButton ButtonGuardarRol;
        private Seguridad.RJButton ButtonCreaRol;
        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
    }
}