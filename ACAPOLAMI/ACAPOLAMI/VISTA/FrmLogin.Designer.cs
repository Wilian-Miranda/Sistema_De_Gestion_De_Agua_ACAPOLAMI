﻿
namespace ACAPOLAMI.VISTA
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistroUsuario = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizarAplicacion = new System.Windows.Forms.Button();
            this.btnCerrarAplicacion = new System.Windows.Forms.Button();
            this.chkPass = new System.Windows.Forms.CheckBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(507, 111);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(541, 30);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(501, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(501, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(507, 194);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(541, 30);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.Location = new System.Drawing.Point(507, 299);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(543, 53);
            this.btnIniciarSesion.TabIndex = 4;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            this.btnIniciarSesion.MouseLeave += new System.EventHandler(this.btnIniciarSesion_MouseLeave);
            this.btnIniciarSesion.MouseHover += new System.EventHandler(this.btnIniciarSesion_MouseHover);
            this.btnIniciarSesion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnIniciarSesion_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(724, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "LOGIN";
            // 
            // btnRegistroUsuario
            // 
            this.btnRegistroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.btnRegistroUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistroUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroUsuario.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistroUsuario.Location = new System.Drawing.Point(507, 359);
            this.btnRegistroUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistroUsuario.Name = "btnRegistroUsuario";
            this.btnRegistroUsuario.Size = new System.Drawing.Size(543, 53);
            this.btnRegistroUsuario.TabIndex = 16;
            this.btnRegistroUsuario.Text = "¿No tienes una cuenta? Registrate";
            this.btnRegistroUsuario.UseVisualStyleBackColor = false;
            this.btnRegistroUsuario.Click += new System.EventHandler(this.button1_Click);
            this.btnRegistroUsuario.MouseLeave += new System.EventHandler(this.btnRegistroUsuario_MouseLeave);
            this.btnRegistroUsuario.MouseHover += new System.EventHandler(this.btnRegistroUsuario_MouseHover);
            this.btnRegistroUsuario.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRegistroUsuario_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(194)))), ((int)(((byte)(243)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(419, 428);
            this.panel4.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ACAPOLAMI.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 428);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(419, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 33);
            this.panel3.TabIndex = 18;
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMinimizarAplicacion);
            this.panel1.Controls.Add(this.btnCerrarAplicacion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(633, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 33);
            this.panel1.TabIndex = 13;
            // 
            // btnMinimizarAplicacion
            // 
            this.btnMinimizarAplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnMinimizarAplicacion.BackgroundImage = global::ACAPOLAMI.Properties.Resources.minimize_118918;
            this.btnMinimizarAplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimizarAplicacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizarAplicacion.FlatAppearance.BorderSize = 0;
            this.btnMinimizarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarAplicacion.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinimizarAplicacion.Location = new System.Drawing.Point(9, 0);
            this.btnMinimizarAplicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMinimizarAplicacion.Name = "btnMinimizarAplicacion";
            this.btnMinimizarAplicacion.Size = new System.Drawing.Size(35, 33);
            this.btnMinimizarAplicacion.TabIndex = 2;
            this.btnMinimizarAplicacion.UseVisualStyleBackColor = false;
            this.btnMinimizarAplicacion.Click += new System.EventHandler(this.btnMinimizarVentana);
            this.btnMinimizarAplicacion.MouseLeave += new System.EventHandler(this.btnMinimizarAplicacion_MouseLeave);
            this.btnMinimizarAplicacion.MouseHover += new System.EventHandler(this.btnMinimizarAplicacion_MouseHover);
            this.btnMinimizarAplicacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnMinimizarAplicacion_MouseMove);
            // 
            // btnCerrarAplicacion
            // 
            this.btnCerrarAplicacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnCerrarAplicacion.BackgroundImage = global::ACAPOLAMI.Properties.Resources.window_close_icon_135015__1_;
            this.btnCerrarAplicacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarAplicacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrarAplicacion.FlatAppearance.BorderSize = 0;
            this.btnCerrarAplicacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarAplicacion.Image = global::ACAPOLAMI.Properties.Resources.CERRAR;
            this.btnCerrarAplicacion.Location = new System.Drawing.Point(44, 0);
            this.btnCerrarAplicacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarAplicacion.Name = "btnCerrarAplicacion";
            this.btnCerrarAplicacion.Size = new System.Drawing.Size(35, 33);
            this.btnCerrarAplicacion.TabIndex = 0;
            this.btnCerrarAplicacion.UseVisualStyleBackColor = false;
            this.btnCerrarAplicacion.Click += new System.EventHandler(this.btnCerrarVentana);
            this.btnCerrarAplicacion.MouseLeave += new System.EventHandler(this.btnCerrarAplicacion_MouseLeave);
            this.btnCerrarAplicacion.MouseHover += new System.EventHandler(this.btnCerrarAplicacion_MouseHover);
            this.btnCerrarAplicacion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCerrarAplicacion_MouseMove);
            // 
            // chkPass
            // 
            this.chkPass.AutoSize = true;
            this.chkPass.BackColor = System.Drawing.Color.Transparent;
            this.chkPass.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPass.ForeColor = System.Drawing.Color.MidnightBlue;
            this.chkPass.Location = new System.Drawing.Point(507, 235);
            this.chkPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(185, 23);
            this.chkPass.TabIndex = 3;
            this.chkPass.Text = "Mostrar contraseña";
            this.chkPass.UseVisualStyleBackColor = false;
            this.chkPass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(133)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1131, 428);
            this.ControlBox = false;
            this.Controls.Add(this.chkPass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnRegistroUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLogin";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "ACAPOLAMI - Login";
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegistroUsuario;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimizarAplicacion;
        private System.Windows.Forms.Button btnCerrarAplicacion;
        private System.Windows.Forms.CheckBox chkPass;
        public System.Windows.Forms.TextBox txtUsuario;
    }
}

