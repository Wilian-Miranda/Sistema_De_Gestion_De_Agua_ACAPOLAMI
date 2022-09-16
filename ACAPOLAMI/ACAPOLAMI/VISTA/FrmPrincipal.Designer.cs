
namespace ACAPOLAMI.VISTA
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombreUSuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAjustes = new System.Windows.Forms.Button();
            this.btnNotificaciones = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnPrincipal = new System.Windows.Forms.Button();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bntMinimizarMenu = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.PictureBox();
            this.pnlCabezaPrincipal = new System.Windows.Forms.Panel();
            this.btnMinimizarAplicacion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.Button();
            this.btnCerrarAplicacion = new System.Windows.Forms.Button();
            this.panelPadre = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlLogo.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).BeginInit();
            this.pnlCabezaPrincipal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelPadre.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.btnAjustes);
            this.pnlMenu.Controls.Add(this.btnNotificaciones);
            this.pnlMenu.Controls.Add(this.btnClientes);
            this.pnlMenu.Controls.Add(this.btnPagos);
            this.pnlMenu.Controls.Add(this.btnReporte);
            this.pnlMenu.Controls.Add(this.btnPrincipal);
            this.pnlMenu.Controls.Add(this.btnCerrarSesión);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 681);
            this.pnlMenu.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.lblNombreUSuario);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(0, 547);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 87);
            this.panel2.TabIndex = 15;
            // 
            // lblNombreUSuario
            // 
            this.lblNombreUSuario.AutoSize = true;
            this.lblNombreUSuario.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
            this.lblNombreUSuario.Location = new System.Drawing.Point(46, 71);
            this.lblNombreUSuario.Name = "lblNombreUSuario";
            this.lblNombreUSuario.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.lblNombreUSuario.Size = new System.Drawing.Size(98, 24);
            this.lblNombreUSuario.TabIndex = 1;
            this.lblNombreUSuario.Text = "Usuario";
            this.lblNombreUSuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ACAPOLAMI.Properties.Resources.usuario;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(55, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 61);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btnAjustes
            // 
            this.btnAjustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjustes.FlatAppearance.BorderSize = 0;
            this.btnAjustes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjustes.Image = global::ACAPOLAMI.Properties.Resources.ajustes;
            this.btnAjustes.Location = new System.Drawing.Point(0, 487);
            this.btnAjustes.Name = "btnAjustes";
            this.btnAjustes.Size = new System.Drawing.Size(200, 60);
            this.btnAjustes.TabIndex = 14;
            this.btnAjustes.Text = "   Ajustes";
            this.btnAjustes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjustes.UseVisualStyleBackColor = true;
            this.btnAjustes.Click += new System.EventHandler(this.btnAjustes_Click_1);
            // 
            // btnNotificaciones
            // 
            this.btnNotificaciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotificaciones.FlatAppearance.BorderSize = 0;
            this.btnNotificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotificaciones.Image = global::ACAPOLAMI.Properties.Resources.notificacion;
            this.btnNotificaciones.Location = new System.Drawing.Point(0, 427);
            this.btnNotificaciones.Name = "btnNotificaciones";
            this.btnNotificaciones.Size = new System.Drawing.Size(200, 60);
            this.btnNotificaciones.TabIndex = 13;
            this.btnNotificaciones.Text = "   Actividad";
            this.btnNotificaciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNotificaciones.UseVisualStyleBackColor = true;
            this.btnNotificaciones.Visible = false;
            this.btnNotificaciones.Click += new System.EventHandler(this.btnNotificaciones_Click_1);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Image = global::ACAPOLAMI.Properties.Resources.agenda;
            this.btnClientes.Location = new System.Drawing.Point(0, 367);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(200, 60);
            this.btnClientes.TabIndex = 12;
            this.btnClientes.Text = "  Consumidores";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click_1);
            // 
            // btnPagos
            // 
            this.btnPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPagos.FlatAppearance.BorderSize = 0;
            this.btnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagos.Image = global::ACAPOLAMI.Properties.Resources.rupia;
            this.btnPagos.Location = new System.Drawing.Point(0, 307);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(200, 60);
            this.btnPagos.TabIndex = 11;
            this.btnPagos.Text = "   Pagos";
            this.btnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporte.FlatAppearance.BorderSize = 0;
            this.btnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporte.Image = global::ACAPOLAMI.Properties.Resources.reportes;
            this.btnReporte.Location = new System.Drawing.Point(0, 247);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(200, 60);
            this.btnReporte.TabIndex = 10;
            this.btnReporte.Text = "   Reportes";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click_1);
            // 
            // btnPrincipal
            // 
            this.btnPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrincipal.FlatAppearance.BorderSize = 0;
            this.btnPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipal.Image = global::ACAPOLAMI.Properties.Resources.casa;
            this.btnPrincipal.Location = new System.Drawing.Point(0, 187);
            this.btnPrincipal.Name = "btnPrincipal";
            this.btnPrincipal.Size = new System.Drawing.Size(200, 60);
            this.btnPrincipal.TabIndex = 9;
            this.btnPrincipal.Text = "   Dashboard";
            this.btnPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrincipal.UseVisualStyleBackColor = true;
            this.btnPrincipal.Click += new System.EventHandler(this.btnPrincipal_Click_1);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnCerrarSesión.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCerrarSesión.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Image = global::ACAPOLAMI.Properties.Resources.salida__1_;
            this.btnCerrarSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesión.Location = new System.Drawing.Point(0, 640);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Size = new System.Drawing.Size(200, 41);
            this.btnCerrarSesión.TabIndex = 8;
            this.btnCerrarSesión.Text = "     Cerrar Sesión";
            this.btnCerrarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesión.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrarSesión.UseVisualStyleBackColor = false;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            this.btnCerrarSesión.MouseLeave += new System.EventHandler(this.btnCerrarSesión_MouseLeave);
            this.btnCerrarSesión.MouseHover += new System.EventHandler(this.btnCerrarSesión_MouseHover);
            this.btnCerrarSesión.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrarSesión_MouseMove);
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.panel4);
            this.pnlLogo.Controls.Add(this.btnInicio);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(200, 187);
            this.pnlLogo.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.panel4.Controls.Add(this.bntMinimizarMenu);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 30);
            this.panel4.TabIndex = 2;
            // 
            // bntMinimizarMenu
            // 
            this.bntMinimizarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.bntMinimizarMenu.BackgroundImage = global::ACAPOLAMI.Properties.Resources.mas;
            this.bntMinimizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntMinimizarMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntMinimizarMenu.FlatAppearance.BorderSize = 0;
            this.bntMinimizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimizarMenu.Location = new System.Drawing.Point(150, 0);
            this.bntMinimizarMenu.Name = "bntMinimizarMenu";
            this.bntMinimizarMenu.Size = new System.Drawing.Size(50, 30);
            this.bntMinimizarMenu.TabIndex = 1;
            this.bntMinimizarMenu.UseVisualStyleBackColor = false;
            this.bntMinimizarMenu.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnInicio.Image = global::ACAPOLAMI.Properties.Resources.gif2;
            this.btnInicio.Location = new System.Drawing.Point(0, 29);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(200, 158);
            this.btnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInicio.TabIndex = 0;
            this.btnInicio.TabStop = false;
            this.btnInicio.Click += new System.EventHandler(this.ptrLogo_Click);
            // 
            // pnlCabezaPrincipal
            // 
            this.pnlCabezaPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlCabezaPrincipal.Controls.Add(this.btnMinimizarAplicacion);
            this.pnlCabezaPrincipal.Controls.Add(this.panel3);
            this.pnlCabezaPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabezaPrincipal.Location = new System.Drawing.Point(200, 0);
            this.pnlCabezaPrincipal.Name = "pnlCabezaPrincipal";
            this.pnlCabezaPrincipal.Size = new System.Drawing.Size(872, 30);
            this.pnlCabezaPrincipal.TabIndex = 56;
            this.pnlCabezaPrincipal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCabezaPrincipal_MouseMove);
            // 
            // btnMinimizarAplicacion
            // 
            this.btnMinimizarAplicacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizarAplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnMinimizarAplicacion.BackgroundImage = global::ACAPOLAMI.Properties.Resources.minimize_118918;
            this.btnMinimizarAplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizarAplicacion.FlatAppearance.BorderSize = 0;
            this.btnMinimizarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarAplicacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizarAplicacion.Location = new System.Drawing.Point(784, 0);
            this.btnMinimizarAplicacion.Name = "btnMinimizarAplicacion";
            this.btnMinimizarAplicacion.Size = new System.Drawing.Size(26, 30);
            this.btnMinimizarAplicacion.TabIndex = 2;
            this.btnMinimizarAplicacion.UseVisualStyleBackColor = false;
            this.btnMinimizarAplicacion.Click += new System.EventHandler(this.btnMinimizarAplicacion_Click);
            this.btnMinimizarAplicacion.MouseLeave += new System.EventHandler(this.btnMinimizarAplicacion_MouseLeave);
            this.btnMinimizarAplicacion.MouseHover += new System.EventHandler(this.btnMinimizarAplicacion_MouseHover);
            this.btnMinimizarAplicacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMinimizarAplicacion_MouseMove);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnMaximizar);
            this.panel3.Controls.Add(this.btnCerrarAplicacion);
            this.panel3.Location = new System.Drawing.Point(813, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(59, 30);
            this.panel3.TabIndex = 14;
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnMaximizar.BackgroundImage = global::ACAPOLAMI.Properties.Resources.MAXIMIZAR;
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaximizar.FlatAppearance.BorderSize = 0;
            this.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizar.Location = new System.Drawing.Point(3, -6);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(26, 36);
            this.btnMaximizar.TabIndex = 15;
            this.btnMaximizar.UseVisualStyleBackColor = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrarAplicacion
            // 
            this.btnCerrarAplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnCerrarAplicacion.BackgroundImage = global::ACAPOLAMI.Properties.Resources.window_close_icon_135015__1_;
            this.btnCerrarAplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarAplicacion.FlatAppearance.BorderSize = 0;
            this.btnCerrarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAplicacion.Location = new System.Drawing.Point(29, 0);
            this.btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            this.btnCerrarAplicacion.Size = new System.Drawing.Size(30, 30);
            this.btnCerrarAplicacion.TabIndex = 0;
            this.btnCerrarAplicacion.UseVisualStyleBackColor = false;
            this.btnCerrarAplicacion.Click += new System.EventHandler(this.btnCerrarAplicacion_Click);
            this.btnCerrarAplicacion.MouseLeave += new System.EventHandler(this.btnCerrarAplicacion_MouseLeave);
            this.btnCerrarAplicacion.MouseHover += new System.EventHandler(this.btnCerrarAplicacion_MouseHover);
            this.btnCerrarAplicacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrarAplicacion_MouseMove);
            // 
            // panelPadre
            // 
            this.panelPadre.BackColor = System.Drawing.Color.White;
            this.panelPadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelPadre.Controls.Add(this.panelContenedor);
            this.panelPadre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPadre.Location = new System.Drawing.Point(200, 30);
            this.panelPadre.Name = "panelPadre";
            this.panelPadre.Size = new System.Drawing.Size(872, 651);
            this.panelPadre.TabIndex = 55;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(872, 651);
            this.panelContenedor.TabIndex = 4;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1072, 681);
            this.ControlBox = false;
            this.Controls.Add(this.panelPadre);
            this.Controls.Add(this.pnlCabezaPrincipal);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(736, 681);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACAPOLAMI";
            this.pnlMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlLogo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicio)).EndInit();
            this.pnlCabezaPrincipal.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelPadre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        public System.Windows.Forms.PictureBox btnInicio;
        private System.Windows.Forms.Panel pnlCabezaPrincipal;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMinimizarAplicacion;
        private System.Windows.Forms.Button btnCerrarAplicacion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bntMinimizarMenu;
        private System.Windows.Forms.Panel panelPadre;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Button btnPrincipal;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnNotificaciones;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAjustes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label lblNombreUSuario;
        private System.Windows.Forms.Button btnMaximizar;
        private System.Windows.Forms.Panel panelContenedor;
    }
}