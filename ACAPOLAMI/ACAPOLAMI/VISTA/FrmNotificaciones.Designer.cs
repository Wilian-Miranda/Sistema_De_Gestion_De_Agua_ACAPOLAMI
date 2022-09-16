
namespace ACAPOLAMI.VISTA
{
    partial class FrmNotificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotificaciones));
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lbntitulo = new System.Windows.Forms.Label();
            this.Temporizador = new System.Windows.Forms.Timer(this.components);
            this.Mostrando = new System.Windows.Forms.Timer(this.components);
            this.Cerrando = new System.Windows.Forms.Timer(this.components);
            this.iconoNotificacion = new System.Windows.Forms.NotifyIcon(this.components);
            this.pcbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensaje.ForeColor = System.Drawing.Color.White;
            this.txtMensaje.Location = new System.Drawing.Point(116, 38);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.ReadOnly = true;
            this.txtMensaje.Size = new System.Drawing.Size(423, 57);
            this.txtMensaje.TabIndex = 19;
            this.txtMensaje.Text = "Mensaje";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::ACAPOLAMI.Properties.Resources.window_close_icon_135015__1_;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(507, -5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(55, 39);
            this.btnCerrar.TabIndex = 18;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbntitulo
            // 
            this.lbntitulo.AutoSize = true;
            this.lbntitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbntitulo.ForeColor = System.Drawing.Color.White;
            this.lbntitulo.Location = new System.Drawing.Point(111, 9);
            this.lbntitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbntitulo.Name = "lbntitulo";
            this.lbntitulo.Size = new System.Drawing.Size(62, 28);
            this.lbntitulo.TabIndex = 16;
            this.lbntitulo.Text = "Titulo";
            // 
            // Temporizador
            // 
            this.Temporizador.Enabled = true;
            this.Temporizador.Interval = 1000;
            this.Temporizador.Tick += new System.EventHandler(this.Temporizador_Tick);
            // 
            // Mostrando
            // 
            this.Mostrando.Tick += new System.EventHandler(this.Mostrando_Tick);
            // 
            // Cerrando
            // 
            this.Cerrando.Tick += new System.EventHandler(this.Cerrando_Tick);
            // 
            // iconoNotificacion
            // 
            this.iconoNotificacion.Text = "notifyIcon1";
            this.iconoNotificacion.Visible = true;
            // 
            // pcbImagen
            // 
            this.pcbImagen.Image = global::ACAPOLAMI.Properties.Resources.WarnigWhite;
            this.pcbImagen.Location = new System.Drawing.Point(8, 12);
            this.pcbImagen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pcbImagen.Name = "pcbImagen";
            this.pcbImagen.Size = new System.Drawing.Size(95, 82);
            this.pcbImagen.TabIndex = 17;
            this.pcbImagen.TabStop = false;
            // 
            // FrmNotificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(548, 116);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pcbImagen);
            this.Controls.Add(this.lbntitulo);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmNotificaciones";
            this.Opacity = 0D;
            this.Text = "Notificacion";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmNotificaciones_Load);
            this.MouseLeave += new System.EventHandler(this.FrmNotificaciones_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmNotificaciones_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pcbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pcbImagen;
        private System.Windows.Forms.Label lbntitulo;
        private System.Windows.Forms.Timer Temporizador;
        private System.Windows.Forms.Timer Mostrando;
        private System.Windows.Forms.Timer Cerrando;
        private System.Windows.Forms.NotifyIcon iconoNotificacion;
    }
}