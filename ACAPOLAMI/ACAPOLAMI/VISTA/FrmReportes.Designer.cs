
namespace ACAPOLAMI.VISTA
{
    partial class FrmReportes
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
            this.pnlBorde = new System.Windows.Forms.Panel();
            this.pnlContenedorReportes = new System.Windows.Forms.Panel();
            this.pnlActividad = new System.Windows.Forms.Panel();
            this.btnReporteActividad = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlPagos = new System.Windows.Forms.Panel();
            this.btnReportePagos = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlConsumidor = new System.Windows.Forms.Panel();
            this.btnReporteConsumidor = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlEncabezado = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBorde.SuspendLayout();
            this.pnlContenedorReportes.SuspendLayout();
            this.pnlActividad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnlPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlConsumidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnlEncabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBorde
            // 
            this.pnlBorde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlBorde.Controls.Add(this.pnlContenedorReportes);
            this.pnlBorde.Controls.Add(this.pnlEncabezado);
            this.pnlBorde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBorde.Location = new System.Drawing.Point(150, 80);
            this.pnlBorde.Name = "pnlBorde";
            this.pnlBorde.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlBorde.Size = new System.Drawing.Size(764, 492);
            this.pnlBorde.TabIndex = 0;
            // 
            // pnlContenedorReportes
            // 
            this.pnlContenedorReportes.BackColor = System.Drawing.Color.White;
            this.pnlContenedorReportes.Controls.Add(this.pnlActividad);
            this.pnlContenedorReportes.Controls.Add(this.pnlPagos);
            this.pnlContenedorReportes.Controls.Add(this.pnlConsumidor);
            this.pnlContenedorReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorReportes.Location = new System.Drawing.Point(3, 60);
            this.pnlContenedorReportes.Name = "pnlContenedorReportes";
            this.pnlContenedorReportes.Padding = new System.Windows.Forms.Padding(20, 23, 20, 20);
            this.pnlContenedorReportes.Size = new System.Drawing.Size(758, 429);
            this.pnlContenedorReportes.TabIndex = 1;
            // 
            // pnlActividad
            // 
            this.pnlActividad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActividad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActividad.Controls.Add(this.btnReporteActividad);
            this.pnlActividad.Controls.Add(this.pictureBox4);
            this.pnlActividad.ForeColor = System.Drawing.Color.Black;
            this.pnlActividad.Location = new System.Drawing.Point(19, 278);
            this.pnlActividad.Name = "pnlActividad";
            this.pnlActividad.Size = new System.Drawing.Size(718, 123);
            this.pnlActividad.TabIndex = 2;
            // 
            // btnReporteActividad
            // 
            this.btnReporteActividad.BackColor = System.Drawing.Color.AliceBlue;
            this.btnReporteActividad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReporteActividad.FlatAppearance.BorderSize = 0;
            this.btnReporteActividad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteActividad.ForeColor = System.Drawing.Color.Black;
            this.btnReporteActividad.Location = new System.Drawing.Point(250, 0);
            this.btnReporteActividad.Name = "btnReporteActividad";
            this.btnReporteActividad.Size = new System.Drawing.Size(466, 121);
            this.btnReporteActividad.TabIndex = 1;
            this.btnReporteActividad.Text = "REPORTE DE ACTIVIDAD";
            this.btnReporteActividad.UseVisualStyleBackColor = false;
            this.btnReporteActividad.MouseLeave += new System.EventHandler(this.btnReporteActividad_MouseLeave);
            this.btnReporteActividad.MouseHover += new System.EventHandler(this.btnReporteActividad_MouseHover);
            this.btnReporteActividad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReporteActividad_MouseMove);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Image = global::ACAPOLAMI.Properties.Resources._3;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(250, 121);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pnlPagos
            // 
            this.pnlPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPagos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPagos.Controls.Add(this.btnReportePagos);
            this.pnlPagos.Controls.Add(this.pictureBox3);
            this.pnlPagos.ForeColor = System.Drawing.Color.Black;
            this.pnlPagos.Location = new System.Drawing.Point(20, 149);
            this.pnlPagos.Name = "pnlPagos";
            this.pnlPagos.Size = new System.Drawing.Size(718, 123);
            this.pnlPagos.TabIndex = 1;
            // 
            // btnReportePagos
            // 
            this.btnReportePagos.BackColor = System.Drawing.Color.Linen;
            this.btnReportePagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReportePagos.FlatAppearance.BorderSize = 0;
            this.btnReportePagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportePagos.ForeColor = System.Drawing.Color.Black;
            this.btnReportePagos.Location = new System.Drawing.Point(250, 0);
            this.btnReportePagos.Name = "btnReportePagos";
            this.btnReportePagos.Size = new System.Drawing.Size(466, 121);
            this.btnReportePagos.TabIndex = 1;
            this.btnReportePagos.Text = "REPORTE DE PAGOS";
            this.btnReportePagos.UseVisualStyleBackColor = false;
            this.btnReportePagos.MouseLeave += new System.EventHandler(this.btnReportePagos_MouseLeave);
            this.btnReportePagos.MouseHover += new System.EventHandler(this.btnReportePagos_MouseHover);
            this.btnReportePagos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReportePagos_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Image = global::ACAPOLAMI.Properties.Resources._2;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(250, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnlConsumidor
            // 
            this.pnlConsumidor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConsumidor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConsumidor.Controls.Add(this.btnReporteConsumidor);
            this.pnlConsumidor.Controls.Add(this.pictureBox2);
            this.pnlConsumidor.ForeColor = System.Drawing.Color.Gray;
            this.pnlConsumidor.Location = new System.Drawing.Point(20, 20);
            this.pnlConsumidor.Name = "pnlConsumidor";
            this.pnlConsumidor.Size = new System.Drawing.Size(718, 123);
            this.pnlConsumidor.TabIndex = 0;
            // 
            // btnReporteConsumidor
            // 
            this.btnReporteConsumidor.BackColor = System.Drawing.Color.GhostWhite;
            this.btnReporteConsumidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReporteConsumidor.FlatAppearance.BorderSize = 0;
            this.btnReporteConsumidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporteConsumidor.ForeColor = System.Drawing.Color.Black;
            this.btnReporteConsumidor.Location = new System.Drawing.Point(250, 0);
            this.btnReporteConsumidor.Name = "btnReporteConsumidor";
            this.btnReporteConsumidor.Size = new System.Drawing.Size(466, 121);
            this.btnReporteConsumidor.TabIndex = 1;
            this.btnReporteConsumidor.Text = "REPORTE DE CLIENTES";
            this.btnReporteConsumidor.UseVisualStyleBackColor = false;
            this.btnReporteConsumidor.MouseLeave += new System.EventHandler(this.btnReporteConsumidor_MouseLeave);
            this.btnReporteConsumidor.MouseHover += new System.EventHandler(this.btnReporteConsumidor_MouseHover);
            this.btnReporteConsumidor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnReporteConsumidor_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Image = global::ACAPOLAMI.Properties.Resources._1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnlEncabezado
            // 
            this.pnlEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.pnlEncabezado.Controls.Add(this.pictureBox1);
            this.pnlEncabezado.Controls.Add(this.label1);
            this.pnlEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEncabezado.Location = new System.Drawing.Point(3, 0);
            this.pnlEncabezado.Name = "pnlEncabezado";
            this.pnlEncabezado.Size = new System.Drawing.Size(758, 60);
            this.pnlEncabezado.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::ACAPOLAMI.Properties.Resources.reportes;
            this.pictureBox1.Location = new System.Drawing.Point(190, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "GENERAR REPORTES";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 652);
            this.Controls.Add(this.pnlBorde);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmReportes";
            this.Padding = new System.Windows.Forms.Padding(150, 80, 150, 80);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportes";
            this.pnlBorde.ResumeLayout(false);
            this.pnlContenedorReportes.ResumeLayout(false);
            this.pnlActividad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnlPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlConsumidor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnlEncabezado.ResumeLayout(false);
            this.pnlEncabezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBorde;
        private System.Windows.Forms.Panel pnlEncabezado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContenedorReportes;
        private System.Windows.Forms.Panel pnlConsumidor;
        private System.Windows.Forms.Button btnReporteConsumidor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlPagos;
        private System.Windows.Forms.Button btnReportePagos;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlActividad;
        private System.Windows.Forms.Button btnReporteActividad;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}