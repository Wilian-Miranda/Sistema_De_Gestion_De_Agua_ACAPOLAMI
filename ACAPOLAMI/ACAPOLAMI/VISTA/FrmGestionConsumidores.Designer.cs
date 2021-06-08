
namespace ACAPOLAMI.VISTA
{
    partial class FrmGestionConsumidores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionConsumidores));
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.btnCerrarGestionConsumidores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlBorde = new System.Windows.Forms.Panel();
            this.pnlContenedorPrincipal = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.pnlDatosConsumidor = new System.Windows.Forms.Panel();
            this.txtDUI = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.cbComunidad = new System.Windows.Forms.ComboBox();
            this.lblComunidad = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDUI = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ControlValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBorde.SuspendLayout();
            this.pnlContenedorPrincipal.SuspendLayout();
            this.pnlDatosConsumidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Controls.Add(this.btnCerrarGestionConsumidores);
            this.pnlEncabezado.Controls.Add(this.pictureBox1);
            this.pnlEncabezado.Controls.Add(this.panel3);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(650, 60);
            this.pnlEncabezado.TabIndex = 1;
            this.pnlEncabezado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlEncabezado_MouseMove);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(181, 12);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(304, 33);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "NUEVO CONSUMIDOR";
            // 
            // btnCerrarGestionConsumidores
            // 
            this.btnCerrarGestionConsumidores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarGestionConsumidores.BackgroundImage = global::ACAPOLAMI.Properties.Resources.window_close_icon_135015__1_;
            this.btnCerrarGestionConsumidores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarGestionConsumidores.FlatAppearance.BorderSize = 0;
            this.btnCerrarGestionConsumidores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarGestionConsumidores.Location = new System.Drawing.Point(595, 12);
            this.btnCerrarGestionConsumidores.Name = "btnCerrarGestionConsumidores";
            this.btnCerrarGestionConsumidores.Size = new System.Drawing.Size(43, 39);
            this.btnCerrarGestionConsumidores.TabIndex = 0;
            this.btnCerrarGestionConsumidores.UseVisualStyleBackColor = true;
            this.btnCerrarGestionConsumidores.Click += new System.EventHandler(this.button1_Click);
            this.btnCerrarGestionConsumidores.MouseLeave += new System.EventHandler(this.btnCerrarGestionConsumidores_MouseLeave);
            this.btnCerrarGestionConsumidores.MouseHover += new System.EventHandler(this.btnCerrarGestionConsumidores_MouseHover);
            this.btnCerrarGestionConsumidores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrarGestionConsumidores_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(88, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlBorde.Controls.Add(this.pnlContenedorPrincipal);
            this.pnlBorde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorde.Location = new System.Drawing.Point(0, 60);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlBorde.Size = new System.Drawing.Size(650, 418);
            this.pnlBorde.TabIndex = 1;
            // 
            // pnlContenedorPrincipal
            // 
            this.pnlContenedorPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlContenedorPrincipal.Controls.Add(this.btnCancelar);
            this.pnlContenedorPrincipal.Controls.Add(this.btnEjecutar);
            this.pnlContenedorPrincipal.Controls.Add(this.pnlDatosConsumidor);
            this.pnlContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorPrincipal.Location = new System.Drawing.Point(3, 0);
            this.pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            this.pnlContenedorPrincipal.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlContenedorPrincipal.Size = new System.Drawing.Size(644, 415);
            this.pnlContenedorPrincipal.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(357, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(250, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            this.btnCancelar.MouseLeave += new System.EventHandler(this.btnCancelar_MouseLeave);
            this.btnCancelar.MouseHover += new System.EventHandler(this.btnCancelar_MouseHover);
            this.btnCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelar_MouseMove);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.Location = new System.Drawing.Point(37, 349);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(250, 36);
            this.btnEjecutar.TabIndex = 10;
            this.btnEjecutar.Text = "Ejecutar acción";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            this.btnEjecutar.MouseLeave += new System.EventHandler(this.btnEjecutar_MouseLeave);
            this.btnEjecutar.MouseHover += new System.EventHandler(this.btnEjecutar_MouseHover);
            this.btnEjecutar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEjecutar_MouseMove);
            // 
            // pnlDatosConsumidor
            // 
            this.pnlDatosConsumidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosConsumidor.Controls.Add(this.txtDUI);
            this.pnlDatosConsumidor.Controls.Add(this.txtTelefono);
            this.pnlDatosConsumidor.Controls.Add(this.cbComunidad);
            this.pnlDatosConsumidor.Controls.Add(this.lblComunidad);
            this.pnlDatosConsumidor.Controls.Add(this.txtCorreo);
            this.pnlDatosConsumidor.Controls.Add(this.lblCorreo);
            this.pnlDatosConsumidor.Controls.Add(this.lblTelefono);
            this.pnlDatosConsumidor.Controls.Add(this.txtApellidos);
            this.pnlDatosConsumidor.Controls.Add(this.label4);
            this.pnlDatosConsumidor.Controls.Add(this.lblDUI);
            this.pnlDatosConsumidor.Controls.Add(this.txtNombres);
            this.pnlDatosConsumidor.Controls.Add(this.lblNombres);
            this.pnlDatosConsumidor.Controls.Add(this.txtCodigo);
            this.pnlDatosConsumidor.Controls.Add(this.lblId);
            this.pnlDatosConsumidor.Controls.Add(this.label1);
            this.pnlDatosConsumidor.Location = new System.Drawing.Point(9, 23);
            this.pnlDatosConsumidor.Name = "pnlDatosConsumidor";
            this.pnlDatosConsumidor.Size = new System.Drawing.Size(626, 289);
            this.pnlDatosConsumidor.TabIndex = 1;
            // 
            // txtDUI
            // 
            this.txtDUI.ForeColor = System.Drawing.Color.Gray;
            this.txtDUI.Location = new System.Drawing.Point(27, 161);
            this.txtDUI.Mask = "00000000-0";
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(248, 26);
            this.txtDUI.TabIndex = 3;
            this.txtDUI.Click += new System.EventHandler(this.txtDUI_Click);
            this.txtDUI.Enter += new System.EventHandler(this.TxtDUI_Enter_1);
            this.txtDUI.Leave += new System.EventHandler(this.TxtDUI_Leave_1);
            // 
            // txtTelefono
            // 
            this.txtTelefono.ForeColor = System.Drawing.Color.Gray;
            this.txtTelefono.Location = new System.Drawing.Point(347, 161);
            this.txtTelefono.Mask = "0000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(250, 26);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.Click += new System.EventHandler(this.txtTelefono_Click);
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter_1);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave_1);
            // 
            // cbComunidad
            // 
            this.cbComunidad.BackColor = System.Drawing.Color.White;
            this.cbComunidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbComunidad.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbComunidad.FormattingEnabled = true;
            this.cbComunidad.Location = new System.Drawing.Point(347, 233);
            this.cbComunidad.Name = "cbComunidad";
            this.cbComunidad.Size = new System.Drawing.Size(250, 27);
            this.cbComunidad.TabIndex = 6;
            this.cbComunidad.SelectedIndexChanged += new System.EventHandler(this.cbComunidad_SelectedIndexChanged);
            // 
            // lblComunidad
            // 
            this.lblComunidad.AutoSize = true;
            this.lblComunidad.Location = new System.Drawing.Point(343, 211);
            this.lblComunidad.Name = "lblComunidad";
            this.lblComunidad.Size = new System.Drawing.Size(104, 19);
            this.lblComunidad.TabIndex = 15;
            this.lblComunidad.Text = "Comunidad:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreo.BackColor = System.Drawing.Color.White;
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorreo.ForeColor = System.Drawing.Color.Gray;
            this.txtCorreo.Location = new System.Drawing.Point(27, 233);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ShortcutsEnabled = false;
            this.txtCorreo.Size = new System.Drawing.Size(250, 26);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.Text = "ejemplo@correo.com";
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(23, 211);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(153, 19);
            this.lblCorreo.TabIndex = 13;
            this.lblCorreo.Text = "Correo Electrónico";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(343, 139);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(81, 19);
            this.lblTelefono.TabIndex = 11;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.ForeColor = System.Drawing.Color.Gray;
            this.txtApellidos.Location = new System.Drawing.Point(347, 89);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ShortcutsEnabled = false;
            this.txtApellidos.Size = new System.Drawing.Size(250, 26);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.Tag = "";
            this.txtApellidos.Text = "Primero Segundo";
            this.txtApellidos.Enter += new System.EventHandler(this.txtApellidos_Enter);
            this.txtApellidos.Leave += new System.EventHandler(this.txtApellidos_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellidos:";
            // 
            // lblDUI
            // 
            this.lblDUI.AutoSize = true;
            this.lblDUI.Location = new System.Drawing.Point(23, 139);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.Size = new System.Drawing.Size(192, 19);
            this.lblDUI.TabIndex = 7;
            this.lblDUI.Text = "Número de Documento:";
            // 
            // txtNombres
            // 
            this.txtNombres.AccessibleDescription = "";
            this.txtNombres.AccessibleName = "";
            this.txtNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.ForeColor = System.Drawing.Color.Gray;
            this.txtNombres.Location = new System.Drawing.Point(27, 89);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ShortcutsEnabled = false;
            this.txtNombres.Size = new System.Drawing.Size(250, 26);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.Text = "Primero Segundo";
            this.txtNombres.Enter += new System.EventHandler(this.txtNombres_Enter);
            this.txtNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombres_KeyPress);
            this.txtNombres.Leave += new System.EventHandler(this.txtNombres_Leave);
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(23, 67);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(85, 19);
            this.lblNombres.TabIndex = 5;
            this.lblNombres.Text = "Nombres:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.ForeColor = System.Drawing.Color.Gray;
            this.txtCodigo.Location = new System.Drawing.Point(401, 15);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.ShortcutsEnabled = false;
            this.txtCodigo.Size = new System.Drawing.Size(196, 26);
            this.txtCodigo.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(363, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 19);
            this.lblId.TabIndex = 3;
            this.lblId.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos del consumidor:";
            // 
            // ControlValidacion
            // 
            this.ControlValidacion.ContainerControl = this;
            // 
            // FrmGestionConsumidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 478);
            this.Controls.Add(this.pnlBorde);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmGestionConsumidores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Consumidores";
            this.Load += new System.EventHandler(this.FrmGestionConsumidores_Load);
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBorde.ResumeLayout(false);
            this.pnlContenedorPrincipal.ResumeLayout(false);
            this.pnlDatosConsumidor.ResumeLayout(false);
            this.pnlDatosConsumidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlValidacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlBorde;
        private System.Windows.Forms.Panel pnlContenedorPrincipal;
        private System.Windows.Forms.Button btnCerrarGestionConsumidores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComunidad;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDUI;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.ComboBox cbComunidad;
        private System.Windows.Forms.ErrorProvider ControlValidacion;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label lblId;
        public System.Windows.Forms.Button btnEjecutar;
        public System.Windows.Forms.Label lblEncabezado;
        public System.Windows.Forms.TextBox txtCorreo;
        public System.Windows.Forms.TextBox txtApellidos;
        public System.Windows.Forms.TextBox txtNombres;
        public System.Windows.Forms.Panel pnlDatosConsumidor;
        public System.Windows.Forms.MaskedTextBox txtTelefono;
        public System.Windows.Forms.MaskedTextBox txtDUI;
    }
}