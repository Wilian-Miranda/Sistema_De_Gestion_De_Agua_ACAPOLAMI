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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlContenedorFiltros = new System.Windows.Forms.Panel();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.cbConsumidores = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoReporte = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtBuscador = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlContenedorFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.txtBuscador);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pnlContenedorFiltros);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbTipoReporte);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 136);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(398, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Buscar:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::ACAPOLAMI.Properties.Resources.lupa;
            this.button1.Location = new System.Drawing.Point(808, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 40);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnlContenedorFiltros
            // 
            this.pnlContenedorFiltros.Controls.Add(this.txtFecha);
            this.pnlContenedorFiltros.Controls.Add(this.btnEjecutar);
            this.pnlContenedorFiltros.Controls.Add(this.lblFechaInicio);
            this.pnlContenedorFiltros.Controls.Add(this.cbConsumidores);
            this.pnlContenedorFiltros.Controls.Add(this.label7);
            this.pnlContenedorFiltros.Controls.Add(this.btnLimpiar);
            this.pnlContenedorFiltros.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContenedorFiltros.Location = new System.Drawing.Point(0, 77);
            this.pnlContenedorFiltros.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlContenedorFiltros.Name = "pnlContenedorFiltros";
            this.pnlContenedorFiltros.Size = new System.Drawing.Size(872, 59);
            this.pnlContenedorFiltros.TabIndex = 8;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173)))));
            this.btnEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjecutar.ForeColor = System.Drawing.Color.White;
            this.btnEjecutar.Location = new System.Drawing.Point(650, 8);
            this.btnEjecutar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(148, 39);
            this.btnEjecutar.TabIndex = 21;
            this.btnEjecutar.Text = "Generar";
            this.btnEjecutar.UseVisualStyleBackColor = false;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.ForeColor = System.Drawing.Color.Black;
            this.lblFechaInicio.Location = new System.Drawing.Point(406, 0);
            this.lblFechaInicio.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(62, 19);
            this.lblFechaInicio.TabIndex = 17;
            this.lblFechaInicio.Tag = "";
            this.lblFechaInicio.Text = "Fecha:";
            // 
            // cbConsumidores
            // 
            this.cbConsumidores.BackColor = System.Drawing.Color.White;
            this.cbConsumidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsumidores.Enabled = false;
            this.cbConsumidores.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsumidores.ForeColor = System.Drawing.Color.Black;
            this.cbConsumidores.FormattingEnabled = true;
            this.cbConsumidores.Location = new System.Drawing.Point(72, 23);
            this.cbConsumidores.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbConsumidores.Name = "cbConsumidores";
            this.cbConsumidores.Size = new System.Drawing.Size(323, 24);
            this.cbConsumidores.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(72, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Consumidor:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Image = global::ACAPOLAMI.Properties.Resources.escoba;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 0);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(62, 47);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione el tipo de reporte:";
            // 
            // cbTipoReporte
            // 
            this.cbTipoReporte.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipoReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoReporte.FormattingEnabled = true;
            this.cbTipoReporte.Items.AddRange(new object[] {
            "Consumidores",
            "Pagos por persona en un año",
            "Reporte general de pagos",
            "Reporte global"});
            this.cbTipoReporte.Location = new System.Drawing.Point(25, 37);
            this.cbTipoReporte.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbTipoReporte.Name = "cbTipoReporte";
            this.cbTipoReporte.Size = new System.Drawing.Size(370, 24);
            this.cbTipoReporte.TabIndex = 0;
            this.cbTipoReporte.SelectedIndexChanged += new System.EventHandler(this.cbTipoReporte_SelectedIndexChanged);
            // 
            // crystalReportViewer
            // 
            this.crystalReportViewer.ActiveViewIndex = -1;
            this.crystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer.Location = new System.Drawing.Point(0, 136);
            this.crystalReportViewer.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.crystalReportViewer.Name = "crystalReportViewer";
            this.crystalReportViewer.Size = new System.Drawing.Size(872, 515);
            this.crystalReportViewer.TabIndex = 2;
            this.crystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer.ToolPanelWidth = 333;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(410, 21);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(232, 26);
            this.txtFecha.TabIndex = 13;
            // 
            // txtBuscador
            // 
            this.txtBuscador.Location = new System.Drawing.Point(410, 35);
            this.txtBuscador.Name = "txtBuscador";
            this.txtBuscador.Size = new System.Drawing.Size(388, 26);
            this.txtBuscador.TabIndex = 13;
            this.txtBuscador.TextChanged += new System.EventHandler(this.txtBuscador_TextChanged);
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 651);
            this.Controls.Add(this.crystalReportViewer);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmReportes";
            this.Text = "FrmReportes";
            this.Load += new System.EventHandler(this.FrmReportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlContenedorFiltros.ResumeLayout(false);
            this.pnlContenedorFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTipoReporte;
        private System.Windows.Forms.Panel pnlContenedorFiltros;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.ComboBox cbConsumidores;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.TextBox txtBuscador;
        private System.Windows.Forms.TextBox txtFecha;
    }
}