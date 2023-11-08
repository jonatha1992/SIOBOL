namespace Presentacion_UI
{
    partial class Form_Contenedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Contenedor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Hallazgo = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearHallazgo = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionHallazgo = new System.Windows.Forms.ToolStripMenuItem();
            this.Entrega = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionEntrega = new System.Windows.Forms.ToolStripMenuItem();
            this.Administracion = new System.Windows.Forms.ToolStripMenuItem();
            this.Reporte = new System.Windows.Forms.ToolStripMenuItem();
            this.BackUp = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.GestionPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.Bitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.Login = new System.Windows.Forms.ToolStripMenuItem();
            this.CambiarContrasena = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Hallazgo,
            this.Entrega,
            this.Administracion,
            this.Login,
            this.CambiarContrasena});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1532, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Hallazgo
            // 
            this.Hallazgo.BackColor = System.Drawing.Color.SteelBlue;
            this.Hallazgo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearHallazgo,
            this.GestionHallazgo});
            this.Hallazgo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hallazgo.ForeColor = System.Drawing.Color.White;
            this.Hallazgo.Name = "Hallazgo";
            this.Hallazgo.Size = new System.Drawing.Size(93, 28);
            this.Hallazgo.Text = "Hallazgos";
            // 
            // CrearHallazgo
            // 
            this.CrearHallazgo.Name = "CrearHallazgo";
            this.CrearHallazgo.Size = new System.Drawing.Size(146, 26);
            this.CrearHallazgo.Text = "Crear";
            this.CrearHallazgo.Click += new System.EventHandler(this.CrearHallazgo_Click);
            // 
            // GestionHallazgo
            // 
            this.GestionHallazgo.Name = "GestionHallazgo";
            this.GestionHallazgo.Size = new System.Drawing.Size(146, 26);
            this.GestionHallazgo.Text = "Gestión";
            this.GestionHallazgo.Click += new System.EventHandler(this.GestionHallazgo_Click);
            // 
            // Entrega
            // 
            this.Entrega.BackColor = System.Drawing.Color.SteelBlue;
            this.Entrega.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearEntrega,
            this.GestionEntrega});
            this.Entrega.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrega.ForeColor = System.Drawing.Color.White;
            this.Entrega.Name = "Entrega";
            this.Entrega.Size = new System.Drawing.Size(84, 28);
            this.Entrega.Text = "Entregas";
            // 
            // CrearEntrega
            // 
            this.CrearEntrega.Name = "CrearEntrega";
            this.CrearEntrega.Size = new System.Drawing.Size(146, 26);
            this.CrearEntrega.Text = "Crear";
            this.CrearEntrega.Click += new System.EventHandler(this.CrearEntrega_Click);
            // 
            // GestionEntrega
            // 
            this.GestionEntrega.Name = "GestionEntrega";
            this.GestionEntrega.Size = new System.Drawing.Size(146, 26);
            this.GestionEntrega.Text = "Gestión";
            this.GestionEntrega.Click += new System.EventHandler(this.GestionEntrega_Click);
            // 
            // Administracion
            // 
            this.Administracion.BackColor = System.Drawing.Color.SteelBlue;
            this.Administracion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Reporte,
            this.BackUp,
            this.GestionUsuarios,
            this.GestionPermisos,
            this.Bitacora});
            this.Administracion.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administracion.ForeColor = System.Drawing.Color.White;
            this.Administracion.Name = "Administracion";
            this.Administracion.Size = new System.Drawing.Size(132, 28);
            this.Administracion.Text = "Administración";
            // 
            // Reporte
            // 
            this.Reporte.Name = "Reporte";
            this.Reporte.Size = new System.Drawing.Size(213, 26);
            this.Reporte.Text = "Reporte";
            this.Reporte.Click += new System.EventHandler(this.Reporte_Click);
            // 
            // BackUp
            // 
            this.BackUp.Name = "BackUp";
            this.BackUp.Size = new System.Drawing.Size(213, 26);
            this.BackUp.Text = "Back Up";
            this.BackUp.Click += new System.EventHandler(this.BackUp_Click);
            // 
            // GestionUsuarios
            // 
            this.GestionUsuarios.Name = "GestionUsuarios";
            this.GestionUsuarios.Size = new System.Drawing.Size(213, 26);
            this.GestionUsuarios.Text = "Gestion Usuarios";
            this.GestionUsuarios.Click += new System.EventHandler(this.GestionUsuarios_Click);
            // 
            // GestionPermisos
            // 
            this.GestionPermisos.Name = "GestionPermisos";
            this.GestionPermisos.Size = new System.Drawing.Size(213, 26);
            this.GestionPermisos.Text = "Gestion Permisos";
            this.GestionPermisos.Click += new System.EventHandler(this.GestionPermisos_Click);
            // 
            // Bitacora
            // 
            this.Bitacora.Name = "Bitacora";
            this.Bitacora.Size = new System.Drawing.Size(213, 26);
            this.Bitacora.Text = "Bitacora";
            this.Bitacora.Click += new System.EventHandler(this.bitacora_Click);
            // 
            // Login
            // 
            this.Login.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Login.BackColor = System.Drawing.Color.SteelBlue;
            this.Login.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.White;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(117, 28);
            this.Login.Text = "Cierra sesión";
            this.Login.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.Login.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // CambiarContrasena
            // 
            this.CambiarContrasena.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CambiarContrasena.BackColor = System.Drawing.Color.SteelBlue;
            this.CambiarContrasena.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambiarContrasena.ForeColor = System.Drawing.Color.White;
            this.CambiarContrasena.Name = "CambiarContrasena";
            this.CambiarContrasena.Size = new System.Drawing.Size(176, 28);
            this.CambiarContrasena.Text = "Cambiar Contraseña";
            this.CambiarContrasena.Click += new System.EventHandler(this.CambiarContrasena_Click);
            // 
            // Form_Contenedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1532, 778);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Contenedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 15;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.Black;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.SteelBlue;
            this.StateCommon.Header.Border.Color2 = System.Drawing.Color.SteelBlue;
            this.StateCommon.Header.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(15, -1, -1, -1);
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "SIOBOL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Contenedor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Hallazgo;
        private System.Windows.Forms.ToolStripMenuItem Entrega;
        private System.Windows.Forms.ToolStripMenuItem Login;
        private System.Windows.Forms.ToolStripMenuItem CrearHallazgo;
        private System.Windows.Forms.ToolStripMenuItem GestionHallazgo;
        private System.Windows.Forms.ToolStripMenuItem CrearEntrega;
        private System.Windows.Forms.ToolStripMenuItem GestionEntrega;
        private System.Windows.Forms.ToolStripMenuItem Administracion;
        private System.Windows.Forms.ToolStripMenuItem Reporte;
        private System.Windows.Forms.ToolStripMenuItem BackUp;
        private System.Windows.Forms.ToolStripMenuItem GestionUsuarios;
        private System.Windows.Forms.ToolStripMenuItem GestionPermisos;
        private System.Windows.Forms.ToolStripMenuItem CambiarContrasena;
        private System.Windows.Forms.ToolStripMenuItem Bitacora;
    }

    
}

