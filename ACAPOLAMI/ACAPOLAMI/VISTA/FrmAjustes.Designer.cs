
namespace ACAPOLAMI.VISTA
{
    partial class FrmAjustes
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
            this.controlValidaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelControles = new System.Windows.Forms.Panel();
            this.panelOtrosAjustes = new System.Windows.Forms.Panel();
            this.btnEstablecerPagoBase = new System.Windows.Forms.Button();
            this.txtPagoBase = new System.Windows.Forms.TextBox();
            this.lblPagoBase = new System.Windows.Forms.Label();
            this.lblOtrosAjustes = new System.Windows.Forms.Label();
            this.panelControlUsuario = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.txtPassAntigua = new System.Windows.Forms.TextBox();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.dtgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblControUsuarios = new System.Windows.Forms.Label();
            this.panelEstadoPagos = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnEliminarEstado = new System.Windows.Forms.Button();
            this.btnGuardarEstado = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dtgvEstadosPago = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstadosPagos = new System.Windows.Forms.Label();
            this.pnlComunidades = new System.Windows.Forms.Panel();
            this.btnGuardarComunidad = new System.Windows.Forms.Button();
            this.lblComunidad = new System.Windows.Forms.Label();
            this.txtComunidad = new System.Windows.Forms.TextBox();
            this.dtgvComunidades = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblControlComunidades = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.controlValidaciones)).BeginInit();
            this.panelSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.panelOtrosAjustes.SuspendLayout();
            this.panelControlUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).BeginInit();
            this.panelEstadoPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstadosPago)).BeginInit();
            this.pnlComunidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvComunidades)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlValidaciones
            // 
            this.controlValidaciones.ContainerControl = this;
            // 
            // panelSuperior
            // 
            this.panelSuperior.AutoSize = true;
            this.panelSuperior.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelSuperior.Controls.Add(this.panel2);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(20, 20);
            this.panelSuperior.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panelSuperior.Size = new System.Drawing.Size(832, 86);
            this.panelSuperior.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 66);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(307, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "AJUSTES DEL SISTEMA";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.panelControles);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(20, 20);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(832, 611);
            this.panelContenedor.TabIndex = 11;
            // 
            // panelControles
            // 
            this.panelControles.AutoScroll = true;
            this.panelControles.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelControles.Controls.Add(this.panel1);
            this.panelControles.Controls.Add(this.panel3);
            this.panelControles.Controls.Add(this.panel4);
            this.panelControles.Controls.Add(this.panel5);
            this.panelControles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControles.Location = new System.Drawing.Point(0, 103);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(832, 508);
            this.panelControles.TabIndex = 0;
            // 
            // panelOtrosAjustes
            // 
            this.panelOtrosAjustes.AutoSize = true;
            this.panelOtrosAjustes.BackColor = System.Drawing.Color.White;
            this.panelOtrosAjustes.Controls.Add(this.btnEstablecerPagoBase);
            this.panelOtrosAjustes.Controls.Add(this.txtPagoBase);
            this.panelOtrosAjustes.Controls.Add(this.lblPagoBase);
            this.panelOtrosAjustes.Controls.Add(this.lblOtrosAjustes);
            this.panelOtrosAjustes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOtrosAjustes.Location = new System.Drawing.Point(3, 3);
            this.panelOtrosAjustes.Name = "panelOtrosAjustes";
            this.panelOtrosAjustes.Size = new System.Drawing.Size(270, 248);
            this.panelOtrosAjustes.TabIndex = 6;
            // 
            // btnEstablecerPagoBase
            // 
            this.btnEstablecerPagoBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnEstablecerPagoBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstablecerPagoBase.ForeColor = System.Drawing.Color.White;
            this.btnEstablecerPagoBase.Location = new System.Drawing.Point(4, 97);
            this.btnEstablecerPagoBase.Name = "btnEstablecerPagoBase";
            this.btnEstablecerPagoBase.Size = new System.Drawing.Size(263, 30);
            this.btnEstablecerPagoBase.TabIndex = 10;
            this.btnEstablecerPagoBase.Text = "Guardar";
            this.btnEstablecerPagoBase.UseVisualStyleBackColor = false;
            this.btnEstablecerPagoBase.Click += new System.EventHandler(this.btnEstablecerPagoBase_Click_1);
            // 
            // txtPagoBase
            // 
            this.txtPagoBase.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPagoBase.Location = new System.Drawing.Point(4, 67);
            this.txtPagoBase.Name = "txtPagoBase";
            this.txtPagoBase.Size = new System.Drawing.Size(263, 26);
            this.txtPagoBase.TabIndex = 8;
            this.txtPagoBase.Text = "0.0000";
            this.txtPagoBase.Enter += new System.EventHandler(this.txtPagoBase_Enter_1);
            this.txtPagoBase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagoBase_KeyPress);
            this.txtPagoBase.Leave += new System.EventHandler(this.txtPagoBase_Leave_1);
            // 
            // lblPagoBase
            // 
            this.lblPagoBase.AutoSize = true;
            this.lblPagoBase.Location = new System.Drawing.Point(5, 44);
            this.lblPagoBase.Name = "lblPagoBase";
            this.lblPagoBase.Size = new System.Drawing.Size(180, 19);
            this.lblPagoBase.TabIndex = 2;
            this.lblPagoBase.Text = "Establecer pago base:";
            // 
            // lblOtrosAjustes
            // 
            this.lblOtrosAjustes.AutoSize = true;
            this.lblOtrosAjustes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOtrosAjustes.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtrosAjustes.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblOtrosAjustes.Location = new System.Drawing.Point(0, 0);
            this.lblOtrosAjustes.Name = "lblOtrosAjustes";
            this.lblOtrosAjustes.Size = new System.Drawing.Size(129, 23);
            this.lblOtrosAjustes.TabIndex = 1;
            this.lblOtrosAjustes.Text = "Otros Ajustes";
            // 
            // panelControlUsuario
            // 
            this.panelControlUsuario.AutoSize = true;
            this.panelControlUsuario.BackColor = System.Drawing.Color.White;
            this.panelControlUsuario.Controls.Add(this.label2);
            this.panelControlUsuario.Controls.Add(this.label1);
            this.panelControlUsuario.Controls.Add(this.lblCorreo);
            this.panelControlUsuario.Controls.Add(this.btnEliminarUsuario);
            this.panelControlUsuario.Controls.Add(this.txtPassAntigua);
            this.panelControlUsuario.Controls.Add(this.btnGuardarUsuario);
            this.panelControlUsuario.Controls.Add(this.txtPass);
            this.panelControlUsuario.Controls.Add(this.txtUsuario);
            this.panelControlUsuario.Controls.Add(this.dtgvUsuarios);
            this.panelControlUsuario.Controls.Add(this.lblControUsuarios);
            this.panelControlUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlUsuario.Location = new System.Drawing.Point(3, 3);
            this.panelControlUsuario.Name = "panelControlUsuario";
            this.panelControlUsuario.Size = new System.Drawing.Size(535, 248);
            this.panelControlUsuario.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(236, 46);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(75, 19);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Usuario:";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(397, 186);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(112, 30);
            this.btnEliminarUsuario.TabIndex = 7;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // txtPassAntigua
            // 
            this.txtPassAntigua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassAntigua.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassAntigua.Location = new System.Drawing.Point(240, 142);
            this.txtPassAntigua.Name = "txtPassAntigua";
            this.txtPassAntigua.Size = new System.Drawing.Size(132, 26);
            this.txtPassAntigua.TabIndex = 5;
            this.txtPassAntigua.Text = "@antigua";
            this.txtPassAntigua.Enter += new System.EventHandler(this.txtPassAntigua_Enter_1);
            this.txtPassAntigua.Leave += new System.EventHandler(this.txtPassAntigua_Leave_1);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(240, 186);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(132, 30);
            this.btnGuardarUsuario.TabIndex = 6;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click_1);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.Location = new System.Drawing.Point(397, 142);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(112, 26);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "@nueva";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter_1);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave_1);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.Location = new System.Drawing.Point(240, 68);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(269, 26);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "ejemplo@correo.com";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter_1);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave_1);
            // 
            // dtgvUsuarios
            // 
            this.dtgvUsuarios.AllowUserToAddRows = false;
            this.dtgvUsuarios.AllowUserToDeleteRows = false;
            this.dtgvUsuarios.AllowUserToResizeColumns = false;
            this.dtgvUsuarios.AllowUserToResizeRows = false;
            this.dtgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dtgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column7});
            this.dtgvUsuarios.Location = new System.Drawing.Point(7, 29);
            this.dtgvUsuarios.Name = "dtgvUsuarios";
            this.dtgvUsuarios.ReadOnly = true;
            this.dtgvUsuarios.RowHeadersVisible = false;
            this.dtgvUsuarios.RowHeadersWidth = 62;
            this.dtgvUsuarios.Size = new System.Drawing.Size(211, 199);
            this.dtgvUsuarios.TabIndex = 2;
            this.dtgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvUsuarios_CellClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "IdUsuario";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de usuario";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Password";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // lblControUsuarios
            // 
            this.lblControUsuarios.AutoSize = true;
            this.lblControUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblControUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblControUsuarios.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControUsuarios.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblControUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lblControUsuarios.Name = "lblControUsuarios";
            this.lblControUsuarios.Size = new System.Drawing.Size(182, 23);
            this.lblControUsuarios.TabIndex = 1;
            this.lblControUsuarios.Text = "Control de usuarios";
            // 
            // panelEstadoPagos
            // 
            this.panelEstadoPagos.AutoSize = true;
            this.panelEstadoPagos.BackColor = System.Drawing.Color.White;
            this.panelEstadoPagos.Controls.Add(this.lblEstado);
            this.panelEstadoPagos.Controls.Add(this.btnEliminarEstado);
            this.panelEstadoPagos.Controls.Add(this.btnGuardarEstado);
            this.panelEstadoPagos.Controls.Add(this.txtEstado);
            this.panelEstadoPagos.Controls.Add(this.dtgvEstadosPago);
            this.panelEstadoPagos.Controls.Add(this.lblEstadosPagos);
            this.panelEstadoPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEstadoPagos.Location = new System.Drawing.Point(3, 3);
            this.panelEstadoPagos.Name = "panelEstadoPagos";
            this.panelEstadoPagos.Size = new System.Drawing.Size(394, 207);
            this.panelEstadoPagos.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(177, 48);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(69, 19);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstado.Location = new System.Drawing.Point(294, 120);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.Size = new System.Drawing.Size(94, 30);
            this.btnEliminarEstado.TabIndex = 5;
            this.btnEliminarEstado.Text = "Eliminar";
            this.btnEliminarEstado.UseVisualStyleBackColor = true;
            this.btnEliminarEstado.Click += new System.EventHandler(this.btnEliminarEstado_Click);
            // 
            // btnGuardarEstado
            // 
            this.btnGuardarEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnGuardarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEstado.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEstado.Location = new System.Drawing.Point(181, 120);
            this.btnGuardarEstado.Name = "btnGuardarEstado";
            this.btnGuardarEstado.Size = new System.Drawing.Size(91, 30);
            this.btnGuardarEstado.TabIndex = 4;
            this.btnGuardarEstado.Text = "Guardar";
            this.btnGuardarEstado.UseVisualStyleBackColor = false;
            this.btnGuardarEstado.Click += new System.EventHandler(this.btnGuardarEstado_Click_1);
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEstado.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEstado.Location = new System.Drawing.Point(181, 87);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(207, 26);
            this.txtEstado.TabIndex = 3;
            this.txtEstado.Text = "@nombre estado";
            this.txtEstado.Enter += new System.EventHandler(this.txtEstado_Enter_1);
            this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave_1);
            // 
            // dtgvEstadosPago
            // 
            this.dtgvEstadosPago.AllowUserToAddRows = false;
            this.dtgvEstadosPago.AllowUserToDeleteRows = false;
            this.dtgvEstadosPago.AllowUserToResizeColumns = false;
            this.dtgvEstadosPago.AllowUserToResizeRows = false;
            this.dtgvEstadosPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvEstadosPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEstadosPago.BackgroundColor = System.Drawing.Color.White;
            this.dtgvEstadosPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEstadosPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.dtgvEstadosPago.Location = new System.Drawing.Point(4, 44);
            this.dtgvEstadosPago.Name = "dtgvEstadosPago";
            this.dtgvEstadosPago.ReadOnly = true;
            this.dtgvEstadosPago.RowHeadersVisible = false;
            this.dtgvEstadosPago.RowHeadersWidth = 62;
            this.dtgvEstadosPago.Size = new System.Drawing.Size(168, 149);
            this.dtgvEstadosPago.TabIndex = 2;
            this.dtgvEstadosPago.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEstadosPago_CellClick);
            // 
            // Column2
            // 
            this.Column2.FillWeight = 38.07107F;
            this.Column2.HeaderText = "Id";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 111.9289F;
            this.Column3.HeaderText = "Nombre";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblEstadosPagos
            // 
            this.lblEstadosPagos.AutoSize = true;
            this.lblEstadosPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEstadosPagos.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadosPagos.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblEstadosPagos.Location = new System.Drawing.Point(0, 0);
            this.lblEstadosPagos.Name = "lblEstadosPagos";
            this.lblEstadosPagos.Size = new System.Drawing.Size(264, 23);
            this.lblEstadosPagos.TabIndex = 1;
            this.lblEstadosPagos.Text = "Control de Estados de pagos";
            // 
            // pnlComunidades
            // 
            this.pnlComunidades.AutoSize = true;
            this.pnlComunidades.BackColor = System.Drawing.Color.White;
            this.pnlComunidades.Controls.Add(this.btnGuardarComunidad);
            this.pnlComunidades.Controls.Add(this.lblComunidad);
            this.pnlComunidades.Controls.Add(this.txtComunidad);
            this.pnlComunidades.Controls.Add(this.dtgvComunidades);
            this.pnlComunidades.Controls.Add(this.lblControlComunidades);
            this.pnlComunidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlComunidades.Location = new System.Drawing.Point(3, 3);
            this.pnlComunidades.Name = "pnlComunidades";
            this.pnlComunidades.Size = new System.Drawing.Size(417, 207);
            this.pnlComunidades.TabIndex = 3;
            // 
            // btnGuardarComunidad
            // 
            this.btnGuardarComunidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardarComunidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnGuardarComunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarComunidad.ForeColor = System.Drawing.Color.White;
            this.btnGuardarComunidad.Location = new System.Drawing.Point(231, 119);
            this.btnGuardarComunidad.Name = "btnGuardarComunidad";
            this.btnGuardarComunidad.Size = new System.Drawing.Size(81, 30);
            this.btnGuardarComunidad.TabIndex = 7;
            this.btnGuardarComunidad.Text = "Guardar";
            this.btnGuardarComunidad.UseVisualStyleBackColor = false;
            this.btnGuardarComunidad.Click += new System.EventHandler(this.btnGuardarComunidad_Click_1);
            // 
            // lblComunidad
            // 
            this.lblComunidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComunidad.AutoSize = true;
            this.lblComunidad.Location = new System.Drawing.Point(228, 47);
            this.lblComunidad.Name = "lblComunidad";
            this.lblComunidad.Size = new System.Drawing.Size(104, 19);
            this.lblComunidad.TabIndex = 5;
            this.lblComunidad.Text = "Comunidad:";
            // 
            // txtComunidad
            // 
            this.txtComunidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComunidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComunidad.ForeColor = System.Drawing.Color.DarkGray;
            this.txtComunidad.Location = new System.Drawing.Point(232, 86);
            this.txtComunidad.Name = "txtComunidad";
            this.txtComunidad.Size = new System.Drawing.Size(174, 26);
            this.txtComunidad.TabIndex = 2;
            this.txtComunidad.Text = "@nombre comunidad";
            this.txtComunidad.Enter += new System.EventHandler(this.txtComunidad_Enter_1);
            this.txtComunidad.Leave += new System.EventHandler(this.txtComunidad_Leave_1);
            // 
            // dtgvComunidades
            // 
            this.dtgvComunidades.AllowUserToAddRows = false;
            this.dtgvComunidades.AllowUserToDeleteRows = false;
            this.dtgvComunidades.AllowUserToResizeColumns = false;
            this.dtgvComunidades.AllowUserToResizeRows = false;
            this.dtgvComunidades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtgvComunidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvComunidades.BackgroundColor = System.Drawing.Color.White;
            this.dtgvComunidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvComunidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.dtgvComunidades.Location = new System.Drawing.Point(4, 44);
            this.dtgvComunidades.Name = "dtgvComunidades";
            this.dtgvComunidades.ReadOnly = true;
            this.dtgvComunidades.RowHeadersVisible = false;
            this.dtgvComunidades.RowHeadersWidth = 62;
            this.dtgvComunidades.Size = new System.Drawing.Size(222, 150);
            this.dtgvComunidades.TabIndex = 1;
            this.dtgvComunidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvComunidades_CellClick_1);
            // 
            // Column4
            // 
            this.Column4.FillWeight = 53.1449F;
            this.Column4.HeaderText = "Id";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 156.246F;
            this.Column5.HeaderText = "Nombre";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // lblControlComunidades
            // 
            this.lblControlComunidades.AutoSize = true;
            this.lblControlComunidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblControlComunidades.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlComunidades.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblControlComunidades.Location = new System.Drawing.Point(0, 0);
            this.lblControlComunidades.Name = "lblControlComunidades";
            this.lblControlComunidades.Size = new System.Drawing.Size(226, 23);
            this.lblControlComunidades.TabIndex = 0;
            this.lblControlComunidades.Text = "Control de Comunidades";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pnlComunidades);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(423, 213);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panelEstadoPagos);
            this.panel3.Location = new System.Drawing.Point(429, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(400, 213);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.panelControlUsuario);
            this.panel4.Location = new System.Drawing.Point(3, 246);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3);
            this.panel4.Size = new System.Drawing.Size(541, 254);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.panelOtrosAjustes);
            this.panel5.Location = new System.Drawing.Point(550, 246);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3);
            this.panel5.Size = new System.Drawing.Size(276, 254);
            this.panel5.TabIndex = 9;
            // 
            // FrmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(872, 651);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.panelContenedor);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmAjustes";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAjustes";
            this.Load += new System.EventHandler(this.FrmAjustes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.controlValidaciones)).EndInit();
            this.panelSuperior.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelContenedor.ResumeLayout(false);
            this.panelControles.ResumeLayout(false);
            this.panelOtrosAjustes.ResumeLayout(false);
            this.panelOtrosAjustes.PerformLayout();
            this.panelControlUsuario.ResumeLayout(false);
            this.panelControlUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUsuarios)).EndInit();
            this.panelEstadoPagos.ResumeLayout(false);
            this.panelEstadoPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEstadosPago)).EndInit();
            this.pnlComunidades.ResumeLayout(false);
            this.pnlComunidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvComunidades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider controlValidaciones;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Panel panelOtrosAjustes;
        private System.Windows.Forms.Button btnEstablecerPagoBase;
        private System.Windows.Forms.TextBox txtPagoBase;
        private System.Windows.Forms.Label lblPagoBase;
        private System.Windows.Forms.Label lblOtrosAjustes;
        private System.Windows.Forms.Panel panelControlUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.TextBox txtPassAntigua;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridView dtgvUsuarios;
        private System.Windows.Forms.Label lblControUsuarios;
        private System.Windows.Forms.Panel panelEstadoPagos;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnEliminarEstado;
        private System.Windows.Forms.Button btnGuardarEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dtgvEstadosPago;
        private System.Windows.Forms.Label lblEstadosPagos;
        private System.Windows.Forms.Panel pnlComunidades;
        private System.Windows.Forms.Button btnGuardarComunidad;
        private System.Windows.Forms.Label lblComunidad;
        private System.Windows.Forms.TextBox txtComunidad;
        private System.Windows.Forms.DataGridView dtgvComunidades;
        private System.Windows.Forms.Label lblControlComunidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}