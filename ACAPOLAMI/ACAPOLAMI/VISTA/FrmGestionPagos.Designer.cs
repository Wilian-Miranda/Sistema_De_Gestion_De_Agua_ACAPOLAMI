
namespace ACAPOLAMI.VISTA
{
    partial class FrmGestionPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionPagos));
            this.pnlBorde = new System.Windows.Forms.Panel();
            this.pnlContenedorPrincipal = new System.Windows.Forms.Panel();
            this.pnlDatosConsumidor = new System.Windows.Forms.Panel();
            this.txtIdConsumidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.pnlDatosPagos = new System.Windows.Forms.Panel();
            this.txtIdRegistro = new System.Windows.Forms.TextBox();
            this.lblIdRegistro = new System.Windows.Forms.Label();
            this.dtpFechaPago = new System.Windows.Forms.DateTimePicker();
            this.txtPendiente = new System.Windows.Forms.TextBox();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblDeudaAcumulada = new System.Windows.Forms.Label();
            this.txtImpuesto = new System.Windows.Forms.TextBox();
            this.lblImpuesto = new System.Windows.Forms.Label();
            this.txtCancelado = new System.Windows.Forms.TextBox();
            this.lblCancelado = new System.Windows.Forms.Label();
            this.txtMontoBase = new System.Windows.Forms.TextBox();
            this.lblMontoBase = new System.Windows.Forms.Label();
            this.pnlBuscador = new System.Windows.Forms.Panel();
            this.cbConsumidor = new System.Windows.Forms.ComboBox();
            this.btnBuscarConsumidor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.btnCerrarGestionConsumidores = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ControlValidacion = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBorde.SuspendLayout();
            this.pnlContenedorPrincipal.SuspendLayout();
            this.pnlDatosConsumidor.SuspendLayout();
            this.pnlDatosPagos.SuspendLayout();
            this.pnlBuscador.SuspendLayout();
            this.pnlEncabezado.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlValidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlBorde.Controls.Add(this.pnlContenedorPrincipal);
            this.pnlBorde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorde.Location = new System.Drawing.Point(0, 60);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlBorde.Size = new System.Drawing.Size(650, 644);
            this.pnlBorde.TabIndex = 2;
            // 
            // pnlContenedorPrincipal
            // 
            this.pnlContenedorPrincipal.BackColor = System.Drawing.Color.White;
            this.pnlContenedorPrincipal.Controls.Add(this.pnlDatosConsumidor);
            this.pnlContenedorPrincipal.Controls.Add(this.btnCancelar);
            this.pnlContenedorPrincipal.Controls.Add(this.btnEjecutar);
            this.pnlContenedorPrincipal.Controls.Add(this.pnlDatosPagos);
            this.pnlContenedorPrincipal.Controls.Add(this.pnlBuscador);
            this.pnlContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorPrincipal.Location = new System.Drawing.Point(3, 0);
            this.pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            this.pnlContenedorPrincipal.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlContenedorPrincipal.Size = new System.Drawing.Size(644, 641);
            this.pnlContenedorPrincipal.TabIndex = 1;
            // 
            // pnlDatosConsumidor
            // 
            this.pnlDatosConsumidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosConsumidor.Controls.Add(this.txtIdConsumidor);
            this.pnlDatosConsumidor.Controls.Add(this.label1);
            this.pnlDatosConsumidor.Controls.Add(this.txtApellidos);
            this.pnlDatosConsumidor.Controls.Add(this.label4);
            this.pnlDatosConsumidor.Controls.Add(this.txtNombres);
            this.pnlDatosConsumidor.Controls.Add(this.lblNombres);
            this.pnlDatosConsumidor.Controls.Add(this.lblId);
            this.pnlDatosConsumidor.Location = new System.Drawing.Point(9, 107);
            this.pnlDatosConsumidor.Name = "pnlDatosConsumidor";
            this.pnlDatosConsumidor.Size = new System.Drawing.Size(625, 119);
            this.pnlDatosConsumidor.TabIndex = 12;
            // 
            // txtIdConsumidor
            // 
            this.txtIdConsumidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdConsumidor.BackColor = System.Drawing.Color.White;
            this.txtIdConsumidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdConsumidor.ForeColor = System.Drawing.Color.Gray;
            this.txtIdConsumidor.Location = new System.Drawing.Point(347, 8);
            this.txtIdConsumidor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtIdConsumidor.Name = "txtIdConsumidor";
            this.txtIdConsumidor.ReadOnly = true;
            this.txtIdConsumidor.ShortcutsEnabled = false;
            this.txtIdConsumidor.Size = new System.Drawing.Size(250, 26);
            this.txtIdConsumidor.TabIndex = 1;
            this.txtIdConsumidor.Tag = "";
            this.txtIdConsumidor.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(25, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Datos del consumidor:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellidos.BackColor = System.Drawing.Color.White;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.ForeColor = System.Drawing.Color.Gray;
            this.txtApellidos.Location = new System.Drawing.Point(347, 75);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.ReadOnly = true;
            this.txtApellidos.ShortcutsEnabled = false;
            this.txtApellidos.Size = new System.Drawing.Size(250, 26);
            this.txtApellidos.TabIndex = 15;
            this.txtApellidos.Tag = "";
            this.txtApellidos.Text = "Primero Segundo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(345, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Apellidos:";
            // 
            // txtNombres
            // 
            this.txtNombres.AccessibleDescription = "";
            this.txtNombres.AccessibleName = "";
            this.txtNombres.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombres.BackColor = System.Drawing.Color.White;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.ForeColor = System.Drawing.Color.Gray;
            this.txtNombres.Location = new System.Drawing.Point(27, 75);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.ShortcutsEnabled = false;
            this.txtNombres.Size = new System.Drawing.Size(250, 26);
            this.txtNombres.TabIndex = 15;
            this.txtNombres.Text = "Primero Segundo";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(25, 53);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(85, 19);
            this.lblNombres.TabIndex = 15;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(310, 8);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 19);
            this.lblId.TabIndex = 15;
            this.lblId.Text = "ID:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(359, 588);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(250, 36);
            this.btnCancelar.TabIndex = 6;
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
            this.btnEjecutar.Location = new System.Drawing.Point(39, 588);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(250, 36);
            this.btnEjecutar.TabIndex = 5;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            this.btnEjecutar.MouseLeave += new System.EventHandler(this.btnEjecutar_MouseLeave);
            this.btnEjecutar.MouseHover += new System.EventHandler(this.btnEjecutar_MouseHover);
            this.btnEjecutar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEjecutar_MouseMove);
            // 
            // pnlDatosPagos
            // 
            this.pnlDatosPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosPagos.Controls.Add(this.txtIdRegistro);
            this.pnlDatosPagos.Controls.Add(this.lblIdRegistro);
            this.pnlDatosPagos.Controls.Add(this.dtpFechaPago);
            this.pnlDatosPagos.Controls.Add(this.txtPendiente);
            this.pnlDatosPagos.Controls.Add(this.lblPendiente);
            this.pnlDatosPagos.Controls.Add(this.lblFecha);
            this.pnlDatosPagos.Controls.Add(this.btnLimpiar);
            this.pnlDatosPagos.Controls.Add(this.cbEstado);
            this.pnlDatosPagos.Controls.Add(this.lblEstado);
            this.pnlDatosPagos.Controls.Add(this.txtTotal);
            this.pnlDatosPagos.Controls.Add(this.lblDeudaAcumulada);
            this.pnlDatosPagos.Controls.Add(this.txtImpuesto);
            this.pnlDatosPagos.Controls.Add(this.lblImpuesto);
            this.pnlDatosPagos.Controls.Add(this.txtCancelado);
            this.pnlDatosPagos.Controls.Add(this.lblCancelado);
            this.pnlDatosPagos.Controls.Add(this.txtMontoBase);
            this.pnlDatosPagos.Controls.Add(this.lblMontoBase);
            this.pnlDatosPagos.Location = new System.Drawing.Point(8, 236);
            this.pnlDatosPagos.Name = "pnlDatosPagos";
            this.pnlDatosPagos.Size = new System.Drawing.Size(626, 337);
            this.pnlDatosPagos.TabIndex = 1;
            // 
            // txtIdRegistro
            // 
            this.txtIdRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdRegistro.BackColor = System.Drawing.Color.White;
            this.txtIdRegistro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdRegistro.ForeColor = System.Drawing.Color.Gray;
            this.txtIdRegistro.Location = new System.Drawing.Point(30, 35);
            this.txtIdRegistro.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtIdRegistro.Name = "txtIdRegistro";
            this.txtIdRegistro.ShortcutsEnabled = false;
            this.txtIdRegistro.Size = new System.Drawing.Size(250, 26);
            this.txtIdRegistro.TabIndex = 24;
            this.txtIdRegistro.Text = "0";
            // 
            // lblIdRegistro
            // 
            this.lblIdRegistro.AutoSize = true;
            this.lblIdRegistro.Location = new System.Drawing.Point(26, 13);
            this.lblIdRegistro.Name = "lblIdRegistro";
            this.lblIdRegistro.Size = new System.Drawing.Size(94, 19);
            this.lblIdRegistro.TabIndex = 25;
            this.lblIdRegistro.Text = "ID registro:";
            // 
            // dtpFechaPago
            // 
            this.dtpFechaPago.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpFechaPago.CustomFormat = "dd/MM/yyyyy";
            this.dtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaPago.Location = new System.Drawing.Point(348, 225);
            this.dtpFechaPago.Name = "dtpFechaPago";
            this.dtpFechaPago.Size = new System.Drawing.Size(250, 26);
            this.dtpFechaPago.TabIndex = 23;
            // 
            // txtPendiente
            // 
            this.txtPendiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPendiente.BackColor = System.Drawing.Color.White;
            this.txtPendiente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPendiente.ForeColor = System.Drawing.Color.Gray;
            this.txtPendiente.Location = new System.Drawing.Point(28, 225);
            this.txtPendiente.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtPendiente.Name = "txtPendiente";
            this.txtPendiente.ReadOnly = true;
            this.txtPendiente.ShortcutsEnabled = false;
            this.txtPendiente.Size = new System.Drawing.Size(250, 26);
            this.txtPendiente.TabIndex = 21;
            this.txtPendiente.Text = "0.0000";
            // 
            // lblPendiente
            // 
            this.lblPendiente.AutoSize = true;
            this.lblPendiente.Location = new System.Drawing.Point(24, 203);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(92, 19);
            this.lblPendiente.TabIndex = 22;
            this.lblPendiente.Text = "Pendiente:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(346, 203);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(128, 19);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fecha de pago:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Image = global::ACAPOLAMI.Properties.Resources.escoba;
            this.btnLimpiar.Location = new System.Drawing.Point(470, 278);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(128, 43);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.MouseLeave += new System.EventHandler(this.btnLimpiar_MouseLeave);
            this.btnLimpiar.MouseHover += new System.EventHandler(this.btnLimpiar_MouseHover);
            this.btnLimpiar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLimpiar_MouseMove);
            // 
            // cbEstado
            // 
            this.cbEstado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEstado.ForeColor = System.Drawing.Color.Gray;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(28, 287);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(250, 27);
            this.cbEstado.TabIndex = 4;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(26, 265);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(69, 19);
            this.lblEstado.TabIndex = 18;
            this.lblEstado.Text = "Estado:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.ForeColor = System.Drawing.Color.Gray;
            this.txtTotal.Location = new System.Drawing.Point(348, 166);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.ShortcutsEnabled = false;
            this.txtTotal.Size = new System.Drawing.Size(250, 26);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Text = "0.0000";
            // 
            // lblDeudaAcumulada
            // 
            this.lblDeudaAcumulada.AutoSize = true;
            this.lblDeudaAcumulada.Location = new System.Drawing.Point(344, 144);
            this.lblDeudaAcumulada.Name = "lblDeudaAcumulada";
            this.lblDeudaAcumulada.Size = new System.Drawing.Size(154, 19);
            this.lblDeudaAcumulada.TabIndex = 15;
            this.lblDeudaAcumulada.Text = "Deuda Acumulada:";
            // 
            // txtImpuesto
            // 
            this.txtImpuesto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImpuesto.BackColor = System.Drawing.Color.White;
            this.txtImpuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImpuesto.ForeColor = System.Drawing.Color.Gray;
            this.txtImpuesto.Location = new System.Drawing.Point(28, 166);
            this.txtImpuesto.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtImpuesto.Name = "txtImpuesto";
            this.txtImpuesto.ShortcutsEnabled = false;
            this.txtImpuesto.Size = new System.Drawing.Size(250, 26);
            this.txtImpuesto.TabIndex = 3;
            this.txtImpuesto.Text = "0.0000";
            this.txtImpuesto.Enter += new System.EventHandler(this.txtImpuesto_Enter);
            this.txtImpuesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImpuesto_KeyPress);
            this.txtImpuesto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtImpuesto_KeyUp);
            this.txtImpuesto.Leave += new System.EventHandler(this.txtImpuesto_Leave);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.Location = new System.Drawing.Point(24, 144);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(86, 19);
            this.lblImpuesto.TabIndex = 13;
            this.lblImpuesto.Text = "Impuesto:";
            // 
            // txtCancelado
            // 
            this.txtCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCancelado.BackColor = System.Drawing.Color.White;
            this.txtCancelado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCancelado.ForeColor = System.Drawing.Color.Gray;
            this.txtCancelado.Location = new System.Drawing.Point(348, 103);
            this.txtCancelado.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtCancelado.Name = "txtCancelado";
            this.txtCancelado.ShortcutsEnabled = false;
            this.txtCancelado.Size = new System.Drawing.Size(250, 26);
            this.txtCancelado.TabIndex = 2;
            this.txtCancelado.Text = "0.0000";
            this.txtCancelado.Enter += new System.EventHandler(this.txtCancelado_Enter);
            this.txtCancelado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCancelado_KeyDown);
            this.txtCancelado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCancelado_KeyPress);
            this.txtCancelado.Leave += new System.EventHandler(this.txtCancelado_Leave);
            // 
            // lblCancelado
            // 
            this.lblCancelado.AutoSize = true;
            this.lblCancelado.Location = new System.Drawing.Point(344, 81);
            this.lblCancelado.Name = "lblCancelado";
            this.lblCancelado.Size = new System.Drawing.Size(97, 19);
            this.lblCancelado.TabIndex = 11;
            this.lblCancelado.Text = "Cancelado:";
            // 
            // txtMontoBase
            // 
            this.txtMontoBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMontoBase.BackColor = System.Drawing.Color.White;
            this.txtMontoBase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoBase.Enabled = false;
            this.txtMontoBase.ForeColor = System.Drawing.Color.Gray;
            this.txtMontoBase.Location = new System.Drawing.Point(28, 103);
            this.txtMontoBase.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.txtMontoBase.Name = "txtMontoBase";
            this.txtMontoBase.ReadOnly = true;
            this.txtMontoBase.ShortcutsEnabled = false;
            this.txtMontoBase.Size = new System.Drawing.Size(250, 26);
            this.txtMontoBase.TabIndex = 10;
            this.txtMontoBase.Text = "0.0000";
            this.txtMontoBase.Enter += new System.EventHandler(this.txtMontoBase_Enter);
            this.txtMontoBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoBase_KeyPress);
            this.txtMontoBase.Leave += new System.EventHandler(this.txtMontoBase_Leave);
            // 
            // lblMontoBase
            // 
            this.lblMontoBase.AutoSize = true;
            this.lblMontoBase.Location = new System.Drawing.Point(24, 81);
            this.lblMontoBase.Name = "lblMontoBase";
            this.lblMontoBase.Size = new System.Drawing.Size(104, 19);
            this.lblMontoBase.TabIndex = 7;
            this.lblMontoBase.Text = "Monto base:";
            // 
            // pnlBuscador
            // 
            this.pnlBuscador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBuscador.Controls.Add(this.cbConsumidor);
            this.pnlBuscador.Controls.Add(this.btnBuscarConsumidor);
            this.pnlBuscador.Controls.Add(this.label2);
            this.pnlBuscador.Location = new System.Drawing.Point(9, 23);
            this.pnlBuscador.Name = "pnlBuscador";
            this.pnlBuscador.Size = new System.Drawing.Size(625, 66);
            this.pnlBuscador.TabIndex = 13;
            // 
            // cbConsumidor
            // 
            this.cbConsumidor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cbConsumidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbConsumidor.FormattingEnabled = true;
            this.cbConsumidor.Location = new System.Drawing.Point(130, 12);
            this.cbConsumidor.Name = "cbConsumidor";
            this.cbConsumidor.Size = new System.Drawing.Size(425, 27);
            this.cbConsumidor.Sorted = true;
            this.cbConsumidor.TabIndex = 1;
            this.cbConsumidor.SelectedIndexChanged += new System.EventHandler(this.cbConsumidor_SelectedIndexChanged);
            this.cbConsumidor.Enter += new System.EventHandler(this.cbConsumidor_Enter);
            this.cbConsumidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbConsumidor_KeyPress);
            // 
            // btnBuscarConsumidor
            // 
            this.btnBuscarConsumidor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarConsumidor.FlatAppearance.BorderSize = 0;
            this.btnBuscarConsumidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarConsumidor.Image = global::ACAPOLAMI.Properties.Resources.lupa;
            this.btnBuscarConsumidor.Location = new System.Drawing.Point(562, 12);
            this.btnBuscarConsumidor.Name = "btnBuscarConsumidor";
            this.btnBuscarConsumidor.Size = new System.Drawing.Size(35, 35);
            this.btnBuscarConsumidor.TabIndex = 19;
            this.btnBuscarConsumidor.UseVisualStyleBackColor = true;
            this.btnBuscarConsumidor.Click += new System.EventHandler(this.btnBuscarConsumidor_Click);
            this.btnBuscarConsumidor.MouseLeave += new System.EventHandler(this.btnBuscarConsumidor_MouseLeave);
            this.btnBuscarConsumidor.MouseHover += new System.EventHandler(this.btnBuscarConsumidor_MouseHover);
            this.btnBuscarConsumidor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBuscarConsumidor_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Consumidor:";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlEncabezado.Controls.Add(this.panel4);
            this.pnlEncabezado.Controls.Add(this.btnCerrarGestionConsumidores);
            this.pnlEncabezado.Controls.Add(this.pictureBox1);
            this.pnlEncabezado.Controls.Add(this.panel3);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(0, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.pnlEncabezado.Size = new System.Drawing.Size(650, 60);
            this.pnlEncabezado.TabIndex = 3;
            this.pnlEncabezado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlEncabezado_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblEncabezado);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(56, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(100, 13, 0, 0);
            this.panel4.Size = new System.Drawing.Size(533, 60);
            this.panel4.TabIndex = 2;
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblEncabezado.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(100, 13);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(347, 33);
            this.lblEncabezado.TabIndex = 1;
            this.lblEncabezado.Text = "NUEVO RECIBO DE PAGO";
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
            this.btnCerrarGestionConsumidores.Click += new System.EventHandler(this.btnCerrarGestionConsumidores_Click);
            this.btnCerrarGestionConsumidores.MouseLeave += new System.EventHandler(this.btnCerrarGestionConsumidores_MouseLeave);
            this.btnCerrarGestionConsumidores.MouseHover += new System.EventHandler(this.btnCerrarGestionConsumidores_MouseHover);
            this.btnCerrarGestionConsumidores.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrarGestionConsumidores_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 60);
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
            // ControlValidacion
            // 
            this.ControlValidacion.ContainerControl = this;
            this.ControlValidacion.RightToLeftChanged += new System.EventHandler(this.txtCancelado_Leave);
            // 
            // FrmGestionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 704);
            this.Controls.Add(this.pnlBorde);
            this.Controls.Add(this.pnlEncabezado);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmGestionPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmGestioPagos";
            this.Load += new System.EventHandler(this.FrmGestioPagos_Load);
            this.pnlBorde.ResumeLayout(false);
            this.pnlContenedorPrincipal.ResumeLayout(false);
            this.pnlDatosConsumidor.ResumeLayout(false);
            this.pnlDatosConsumidor.PerformLayout();
            this.pnlDatosPagos.ResumeLayout(false);
            this.pnlDatosPagos.PerformLayout();
            this.pnlBuscador.ResumeLayout(false);
            this.pnlBuscador.PerformLayout();
            this.pnlEncabezado.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ControlValidacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorde;
        private System.Windows.Forms.Panel pnlContenedorPrincipal;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label lblDeudaAcumulada;
        public System.Windows.Forms.TextBox txtImpuesto;
        private System.Windows.Forms.Label lblImpuesto;
        public System.Windows.Forms.TextBox txtCancelado;
        private System.Windows.Forms.Label lblCancelado;
        public System.Windows.Forms.TextBox txtMontoBase;
        private System.Windows.Forms.Label lblMontoBase;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.Button btnCerrarGestionConsumidores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label lblNombres;
        public System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblEstado;
        public System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.TextBox txtIdConsumidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider ControlValidacion;
        public System.Windows.Forms.Button btnBuscarConsumidor;
        private System.Windows.Forms.Label lblFecha;
        public System.Windows.Forms.TextBox txtPendiente;
        private System.Windows.Forms.Label lblPendiente;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lblEncabezado;
        public System.Windows.Forms.Panel pnlDatosPagos;
        public System.Windows.Forms.Panel pnlDatosConsumidor;
        public System.Windows.Forms.Panel pnlBuscador;
        private System.Windows.Forms.ComboBox cbConsumidor;
        public System.Windows.Forms.DateTimePicker dtpFechaPago;
        public System.Windows.Forms.TextBox txtIdRegistro;
        private System.Windows.Forms.Label lblIdRegistro;
    }
}