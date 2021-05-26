
namespace WilianMiranda01.VISTA
{
    partial class FrmRegistroUsuario
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
            this.btnCancelarRegistro = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pnlCabeceraRegistroUsuario = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarAplicacion = new System.Windows.Forms.Button();
            this.txtConfirmar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlCabeceraRegistroUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnCancelarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRegistro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnCancelarRegistro.Location = new System.Drawing.Point(312, 469);
            this.btnCancelarRegistro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(250, 66);
            this.btnCancelarRegistro.TabIndex = 25;
            this.btnCancelarRegistro.Text = "Cancelar Registro";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnRegistroUsuario_Click);
            this.btnCancelarRegistro.MouseLeave += new System.EventHandler(this.btnCancelarRegistro_MouseLeave);
            this.btnCancelarRegistro.MouseHover += new System.EventHandler(this.btnCancelarRegistro_MouseHover);
            this.btnCancelarRegistro.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCancelarRegistro_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(213, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 37);
            this.label4.TabIndex = 24;
            this.label4.Text = "REGISTRO";
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnRegistrarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(46, 469);
            this.btnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(250, 66);
            this.btnRegistrarUsuario.TabIndex = 21;
            this.btnRegistrarUsuario.Text = "Registrarse";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            this.btnRegistrarUsuario.MouseLeave += new System.EventHandler(this.btnRegistrarUsuario_MouseLeave);
            this.btnRegistrarUsuario.MouseHover += new System.EventHandler(this.btnRegistrarUsuario_MouseHover);
            this.btnRegistrarUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRegistrarUsuario_MouseMove);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(48, 282);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(512, 35);
            this.txtPassword.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(42, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(46, 177);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(514, 35);
            this.txtUsuario.TabIndex = 17;
            // 
            // pnlCabeceraRegistroUsuario
            // 
            this.pnlCabeceraRegistroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlCabeceraRegistroUsuario.Controls.Add(this.panel1);
            this.pnlCabeceraRegistroUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabeceraRegistroUsuario.Location = new System.Drawing.Point(0, 0);
            this.pnlCabeceraRegistroUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCabeceraRegistroUsuario.Name = "pnlCabeceraRegistroUsuario";
            this.pnlCabeceraRegistroUsuario.Size = new System.Drawing.Size(604, 46);
            this.pnlCabeceraRegistroUsuario.TabIndex = 26;
            this.pnlCabeceraRegistroUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlCabeceraRegistroUsuario_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrarAplicacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(554, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 46);
            this.panel1.TabIndex = 13;
            // 
            // btnCerrarAplicacion
            // 
            this.btnCerrarAplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnCerrarAplicacion.BackgroundImage = global::ACAPOLAMI.Properties.Resources.window_close_icon_135015__1_;
            this.btnCerrarAplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarAplicacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarAplicacion.FlatAppearance.BorderSize = 0;
            this.btnCerrarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAplicacion.Location = new System.Drawing.Point(11, 0);
            this.btnCerrarAplicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            this.btnCerrarAplicacion.Size = new System.Drawing.Size(39, 46);
            this.btnCerrarAplicacion.TabIndex = 0;
            this.btnCerrarAplicacion.UseVisualStyleBackColor = false;
            this.btnCerrarAplicacion.Click += new System.EventHandler(this.btnCerrarAplicacion_Click);
            this.btnCerrarAplicacion.MouseLeave += new System.EventHandler(this.btnCerrarAplicacion_MouseLeave);
            this.btnCerrarAplicacion.MouseHover += new System.EventHandler(this.btnCerrarAplicacion_MouseHover);
            this.btnCerrarAplicacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrarAplicacion_MouseMove);
            // 
            // txtConfirmar
            // 
            this.txtConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.txtConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtConfirmar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmar.ForeColor = System.Drawing.Color.White;
            this.txtConfirmar.Location = new System.Drawing.Point(46, 383);
            this.txtConfirmar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.PasswordChar = '*';
            this.txtConfirmar.Size = new System.Drawing.Size(512, 35);
            this.txtConfirmar.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 349);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "Confirmar contraseña:";
            // 
            // FrmRegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(604, 589);
            this.ControlBox = false;
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlCabeceraRegistroUsuario);
            this.Controls.Add(this.btnCancelarRegistro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRegistroUsuario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmRegistroUsuario_Load);
            this.pnlCabeceraRegistroUsuario.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Panel pnlCabeceraRegistroUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrarAplicacion;
        private System.Windows.Forms.TextBox txtConfirmar;
        private System.Windows.Forms.Label label5;
    }
}