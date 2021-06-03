
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
            this.pnlBorde = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEstablecerPagoBase = new System.Windows.Forms.Button();
            this.txtPagoBase = new System.Windows.Forms.TextBox();
            this.lblPagoBase = new System.Windows.Forms.Label();
            this.lblOtrosAjustes = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnGuardarUsuario = new System.Windows.Forms.Button();
            this.txtPassAntigua = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblControUsuarios = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnEliminarEstado = new System.Windows.Forms.Button();
            this.btnGuardarEstado = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEstadosPagos = new System.Windows.Forms.Label();
            this.pnlComunidades = new System.Windows.Forms.Panel();
            this.btnGuardarComunidad = new System.Windows.Forms.Button();
            this.lblComunidad = new System.Windows.Forms.Label();
            this.btnEliminarComunidad = new System.Windows.Forms.Button();
            this.txtComunidad = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblControlComunidades = new System.Windows.Forms.Label();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.ptbIconoAjustes = new System.Windows.Forms.PictureBox();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.controlValidaciones = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlBorde.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnlComunidades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIconoAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlValidaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlBorde.Controls.Add(this.panel1);
            this.pnlBorde.Controls.Add(this.pnlEncabezado);
            this.pnlBorde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorde.Location = new System.Drawing.Point(20, 20);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlBorde.Size = new System.Drawing.Size(1024, 612);
            this.pnlBorde.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlComunidades);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 60);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 40, 20, 20);
            this.panel1.Size = new System.Drawing.Size(1018, 549);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnEstablecerPagoBase);
            this.panel4.Controls.Add(this.txtPagoBase);
            this.panel4.Controls.Add(this.lblPagoBase);
            this.panel4.Controls.Add(this.lblOtrosAjustes);
            this.panel4.Location = new System.Drawing.Point(746, 271);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 255);
            this.panel4.TabIndex = 2;
            // 
            // btnEstablecerPagoBase
            // 
            this.btnEstablecerPagoBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnEstablecerPagoBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstablecerPagoBase.ForeColor = System.Drawing.Color.White;
            this.btnEstablecerPagoBase.Location = new System.Drawing.Point(17, 99);
            this.btnEstablecerPagoBase.Name = "btnEstablecerPagoBase";
            this.btnEstablecerPagoBase.Size = new System.Drawing.Size(213, 30);
            this.btnEstablecerPagoBase.TabIndex = 10;
            this.btnEstablecerPagoBase.Text = "Guardar";
            this.btnEstablecerPagoBase.UseVisualStyleBackColor = false;
            this.btnEstablecerPagoBase.Click += new System.EventHandler(this.btnEstablecerPagoBase_Click);
            this.btnEstablecerPagoBase.MouseLeave += new System.EventHandler(this.btnEstablecerPagoBase_MouseLeave);
            this.btnEstablecerPagoBase.MouseHover += new System.EventHandler(this.btnEstablecerPagoBase_MouseHover);
            this.btnEstablecerPagoBase.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEstablecerPagoBase_MouseMove);
            // 
            // txtPagoBase
            // 
            this.txtPagoBase.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPagoBase.Location = new System.Drawing.Point(17, 67);
            this.txtPagoBase.Name = "txtPagoBase";
            this.txtPagoBase.Size = new System.Drawing.Size(213, 26);
            this.txtPagoBase.TabIndex = 8;
            this.txtPagoBase.Text = "0.0000";
            this.txtPagoBase.Enter += new System.EventHandler(this.txtPagoBase_Enter);
            this.txtPagoBase.Leave += new System.EventHandler(this.txtPagoBase_Leave);
            // 
            // lblPagoBase
            // 
            this.lblPagoBase.AutoSize = true;
            this.lblPagoBase.Location = new System.Drawing.Point(13, 45);
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
            this.lblOtrosAjustes.Location = new System.Drawing.Point(0, 0);
            this.lblOtrosAjustes.Name = "lblOtrosAjustes";
            this.lblOtrosAjustes.Size = new System.Drawing.Size(129, 23);
            this.lblOtrosAjustes.TabIndex = 1;
            this.lblOtrosAjustes.Text = "Otros Ajustes";
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblCorreo);
            this.panel3.Controls.Add(this.btnEliminarUsuario);
            this.panel3.Controls.Add(this.btnGuardarUsuario);
            this.panel3.Controls.Add(this.txtPassAntigua);
            this.panel3.Controls.Add(this.txtPass);
            this.panel3.Controls.Add(this.txtUsuario);
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Controls.Add(this.lblControUsuarios);
            this.panel3.Location = new System.Drawing.Point(23, 271);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(717, 255);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(354, 45);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(75, 19);
            this.lblCorreo.TabIndex = 7;
            this.lblCorreo.Text = "Usuario:";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(534, 185);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(154, 30);
            this.btnEliminarUsuario.TabIndex = 7;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.MouseLeave += new System.EventHandler(this.btnEliminarUsuario_MouseLeave);
            this.btnEliminarUsuario.MouseHover += new System.EventHandler(this.btnEliminarUsuario_MouseHover);
            this.btnEliminarUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminarUsuario_MouseMove);
            // 
            // btnGuardarUsuario
            // 
            this.btnGuardarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnGuardarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnGuardarUsuario.Location = new System.Drawing.Point(358, 185);
            this.btnGuardarUsuario.Name = "btnGuardarUsuario";
            this.btnGuardarUsuario.Size = new System.Drawing.Size(154, 30);
            this.btnGuardarUsuario.TabIndex = 6;
            this.btnGuardarUsuario.Text = "Guardar";
            this.btnGuardarUsuario.UseVisualStyleBackColor = false;
            this.btnGuardarUsuario.Click += new System.EventHandler(this.btnGuardarUsuario_Click);
            this.btnGuardarUsuario.MouseLeave += new System.EventHandler(this.btnGuardarUsuario_MouseLeave);
            this.btnGuardarUsuario.MouseHover += new System.EventHandler(this.btnGuardarUsuario_MouseHover);
            this.btnGuardarUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardarUsuario_MouseMove);
            // 
            // txtPassAntigua
            // 
            this.txtPassAntigua.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassAntigua.Location = new System.Drawing.Point(534, 130);
            this.txtPassAntigua.Name = "txtPassAntigua";
            this.txtPassAntigua.Size = new System.Drawing.Size(154, 26);
            this.txtPassAntigua.TabIndex = 5;
            this.txtPassAntigua.Text = "@antigua";
            this.txtPassAntigua.Enter += new System.EventHandler(this.txtPassAntigua_Enter);
            this.txtPassAntigua.Leave += new System.EventHandler(this.txtPassAntigua_Leave);
            // 
            // txtPass
            // 
            this.txtPass.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPass.Location = new System.Drawing.Point(358, 130);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(154, 26);
            this.txtPass.TabIndex = 4;
            this.txtPass.Text = "@nueva";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            this.txtPass.Leave += new System.EventHandler(this.txtPass_Leave);
            // 
            // txtUsuario
            // 
            this.txtUsuario.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUsuario.Location = new System.Drawing.Point(358, 67);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(330, 26);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "ejemplo@gmail.com";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView3.Location = new System.Drawing.Point(4, 26);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(327, 226);
            this.dataGridView3.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de usuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // lblControUsuarios
            // 
            this.lblControUsuarios.AutoSize = true;
            this.lblControUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblControUsuarios.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControUsuarios.Location = new System.Drawing.Point(0, 0);
            this.lblControUsuarios.Name = "lblControUsuarios";
            this.lblControUsuarios.Size = new System.Drawing.Size(182, 23);
            this.lblControUsuarios.TabIndex = 1;
            this.lblControUsuarios.Text = "Control de usuarios";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblEstado);
            this.panel2.Controls.Add(this.btnEliminarEstado);
            this.panel2.Controls.Add(this.btnGuardarEstado);
            this.panel2.Controls.Add(this.txtEstado);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.lblEstadosPagos);
            this.panel2.Location = new System.Drawing.Point(515, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(480, 190);
            this.panel2.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(286, 42);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(69, 19);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado:";
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEstado.Location = new System.Drawing.Point(377, 96);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.Size = new System.Drawing.Size(84, 30);
            this.btnEliminarEstado.TabIndex = 5;
            this.btnEliminarEstado.Text = "Eliminar";
            this.btnEliminarEstado.UseVisualStyleBackColor = true;
            this.btnEliminarEstado.MouseLeave += new System.EventHandler(this.btnEliminarEstado_MouseLeave);
            this.btnEliminarEstado.MouseHover += new System.EventHandler(this.btnEliminarEstado_MouseHover);
            this.btnEliminarEstado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminarEstado_MouseMove);
            // 
            // btnGuardarEstado
            // 
            this.btnGuardarEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnGuardarEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarEstado.ForeColor = System.Drawing.Color.White;
            this.btnGuardarEstado.Location = new System.Drawing.Point(290, 97);
            this.btnGuardarEstado.Name = "btnGuardarEstado";
            this.btnGuardarEstado.Size = new System.Drawing.Size(81, 30);
            this.btnGuardarEstado.TabIndex = 4;
            this.btnGuardarEstado.Text = "Guardar";
            this.btnGuardarEstado.UseVisualStyleBackColor = false;
            this.btnGuardarEstado.Click += new System.EventHandler(this.btnGuardarEstado_Click);
            this.btnGuardarEstado.MouseLeave += new System.EventHandler(this.btnGuardarEstado_MouseLeave);
            this.btnGuardarEstado.MouseHover += new System.EventHandler(this.btnGuardarEstado_MouseHover);
            this.btnGuardarEstado.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardarEstado_MouseMove);
            // 
            // txtEstado
            // 
            this.txtEstado.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEstado.Location = new System.Drawing.Point(290, 64);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(171, 26);
            this.txtEstado.TabIndex = 3;
            this.txtEstado.Text = "@nombre estado";
            this.txtEstado.Enter += new System.EventHandler(this.txtEstado_Enter);
            this.txtEstado.Leave += new System.EventHandler(this.txtEstado_Leave);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3});
            this.dataGridView2.Location = new System.Drawing.Point(4, 26);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(260, 150);
            this.dataGridView2.TabIndex = 2;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 80F;
            this.Column2.HeaderText = "Código";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // lblEstadosPagos
            // 
            this.lblEstadosPagos.AutoSize = true;
            this.lblEstadosPagos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEstadosPagos.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadosPagos.Location = new System.Drawing.Point(0, 0);
            this.lblEstadosPagos.Name = "lblEstadosPagos";
            this.lblEstadosPagos.Size = new System.Drawing.Size(264, 23);
            this.lblEstadosPagos.TabIndex = 1;
            this.lblEstadosPagos.Text = "Control de Estados de pagos";
            // 
            // pnlComunidades
            // 
            this.pnlComunidades.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlComunidades.BackColor = System.Drawing.Color.White;
            this.pnlComunidades.Controls.Add(this.btnGuardarComunidad);
            this.pnlComunidades.Controls.Add(this.lblComunidad);
            this.pnlComunidades.Controls.Add(this.btnEliminarComunidad);
            this.pnlComunidades.Controls.Add(this.txtComunidad);
            this.pnlComunidades.Controls.Add(this.dataGridView1);
            this.pnlComunidades.Controls.Add(this.lblControlComunidades);
            this.pnlComunidades.Location = new System.Drawing.Point(23, 43);
            this.pnlComunidades.Name = "pnlComunidades";
            this.pnlComunidades.Size = new System.Drawing.Size(486, 190);
            this.pnlComunidades.TabIndex = 0;
            // 
            // btnGuardarComunidad
            // 
            this.btnGuardarComunidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnGuardarComunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarComunidad.ForeColor = System.Drawing.Color.White;
            this.btnGuardarComunidad.Location = new System.Drawing.Point(286, 96);
            this.btnGuardarComunidad.Name = "btnGuardarComunidad";
            this.btnGuardarComunidad.Size = new System.Drawing.Size(81, 30);
            this.btnGuardarComunidad.TabIndex = 7;
            this.btnGuardarComunidad.Text = "Guardar";
            this.btnGuardarComunidad.UseVisualStyleBackColor = false;
            this.btnGuardarComunidad.Click += new System.EventHandler(this.btnGuardarComunidad_Click);
            this.btnGuardarComunidad.MouseLeave += new System.EventHandler(this.btnGuardarComunidad_MouseLeave);
            this.btnGuardarComunidad.MouseHover += new System.EventHandler(this.btnGuardarComunidad_MouseHover);
            this.btnGuardarComunidad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnGuardarComunidad_MouseMove);
            // 
            // lblComunidad
            // 
            this.lblComunidad.AutoSize = true;
            this.lblComunidad.Location = new System.Drawing.Point(283, 41);
            this.lblComunidad.Name = "lblComunidad";
            this.lblComunidad.Size = new System.Drawing.Size(104, 19);
            this.lblComunidad.TabIndex = 5;
            this.lblComunidad.Text = "Comunidad:";
            // 
            // btnEliminarComunidad
            // 
            this.btnEliminarComunidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarComunidad.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarComunidad.Location = new System.Drawing.Point(373, 96);
            this.btnEliminarComunidad.Name = "btnEliminarComunidad";
            this.btnEliminarComunidad.Size = new System.Drawing.Size(85, 30);
            this.btnEliminarComunidad.TabIndex = 4;
            this.btnEliminarComunidad.Text = "Eliminar";
            this.btnEliminarComunidad.UseVisualStyleBackColor = true;
            this.btnEliminarComunidad.MouseLeave += new System.EventHandler(this.btnEliminarComunidad_MouseLeave);
            this.btnEliminarComunidad.MouseHover += new System.EventHandler(this.btnEliminarComunidad_MouseHover);
            this.btnEliminarComunidad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminarComunidad_MouseMove);
            // 
            // txtComunidad
            // 
            this.txtComunidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComunidad.ForeColor = System.Drawing.Color.DarkGray;
            this.txtComunidad.Location = new System.Drawing.Point(287, 63);
            this.txtComunidad.Name = "txtComunidad";
            this.txtComunidad.Size = new System.Drawing.Size(171, 26);
            this.txtComunidad.TabIndex = 2;
            this.txtComunidad.Text = "@nombre comunidad";
            this.txtComunidad.Enter += new System.EventHandler(this.txtComunidad_Enter);
            this.txtComunidad.Leave += new System.EventHandler(this.txtComunidad_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(4, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(260, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Código";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 159.3909F;
            this.Column5.HeaderText = "Nombre";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // lblControlComunidades
            // 
            this.lblControlComunidades.AutoSize = true;
            this.lblControlComunidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblControlComunidades.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControlComunidades.Location = new System.Drawing.Point(0, 0);
            this.lblControlComunidades.Name = "lblControlComunidades";
            this.lblControlComunidades.Size = new System.Drawing.Size(226, 23);
            this.lblControlComunidades.TabIndex = 0;
            this.lblControlComunidades.Text = "Control de Comunidades";
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlEncabezado.Controls.Add(this.ptbIconoAjustes);
            this.pnlEncabezado.Controls.Add(this.lblEncabezado);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(3, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(1018, 60);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // ptbIconoAjustes
            // 
            this.ptbIconoAjustes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbIconoAjustes.Image = global::ACAPOLAMI.Properties.Resources.ajustes;
            this.ptbIconoAjustes.Location = new System.Drawing.Point(316, 3);
            this.ptbIconoAjustes.Name = "ptbIconoAjustes";
            this.ptbIconoAjustes.Size = new System.Drawing.Size(80, 51);
            this.ptbIconoAjustes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbIconoAjustes.TabIndex = 1;
            this.ptbIconoAjustes.TabStop = false;
            this.ptbIconoAjustes.Click += new System.EventHandler(this.ptbIconoAjustes_Click);
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(402, 18);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(220, 23);
            this.lblEncabezado.TabIndex = 0;
            this.lblEncabezado.Text = "AJUSTES DEL SISTEMA";
            // 
            // controlValidaciones
            // 
            this.controlValidaciones.ContainerControl = this;
            // 
            // FrmAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 652);
            this.Controls.Add(this.pnlBorde);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmAjustes";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAjustes";
            this.Load += new System.EventHandler(this.FrmAjustes_Load);
            this.pnlBorde.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnlComunidades.ResumeLayout(false);
            this.pnlComunidades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbIconoAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlValidaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorde;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.PictureBox ptbIconoAjustes;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Panel pnlComunidades;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOtrosAjustes;
        private System.Windows.Forms.Label lblControUsuarios;
        private System.Windows.Forms.Label lblEstadosPagos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblControlComunidades;
        private System.Windows.Forms.TextBox txtPagoBase;
        private System.Windows.Forms.Label lblPagoBase;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnGuardarUsuario;
        private System.Windows.Forms.TextBox txtPassAntigua;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnEliminarEstado;
        private System.Windows.Forms.Button btnGuardarEstado;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnEliminarComunidad;
        private System.Windows.Forms.TextBox txtComunidad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblComunidad;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEstablecerPagoBase;
        private System.Windows.Forms.Button btnGuardarComunidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ErrorProvider controlValidaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}