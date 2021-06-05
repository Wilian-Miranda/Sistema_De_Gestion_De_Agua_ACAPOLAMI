
namespace ACAPOLAMI.VISTA
{
    partial class FrmGPagosPorAnio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.cbxAnio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cddGPagosPorAnio = new ACAPOLAMI.CDD.cddGPagosPorAnio();
            this.gPagosAnioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gPagosAnioTableAdapter = new ACAPOLAMI.CDD.cddGPagosPorAnioTableAdapters.GPagosAnioTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cddGPagosPorAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPagosAnioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(1015, 12);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(165, 41);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // cbxAnio
            // 
            this.cbxAnio.FormattingEnabled = true;
            this.cbxAnio.Location = new System.Drawing.Point(607, 25);
            this.cbxAnio.Name = "cbxAnio";
            this.cbxAnio.Size = new System.Drawing.Size(337, 28);
            this.cbxAnio.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Año";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.reportViewer1);
            this.panel1.Location = new System.Drawing.Point(13, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1319, 571);
            this.panel1.TabIndex = 3;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.gPagosAnioBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ACAPOLAMI.REPORTES.GPagosPorAnio.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1319, 571);
            this.reportViewer1.TabIndex = 0;
            // 
            // cddGPagosPorAnio
            // 
            this.cddGPagosPorAnio.DataSetName = "cddGPagosPorAnio";
            this.cddGPagosPorAnio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gPagosAnioBindingSource
            // 
            this.gPagosAnioBindingSource.DataMember = "GPagosAnio";
            this.gPagosAnioBindingSource.DataSource = this.cddGPagosPorAnio;
            // 
            // gPagosAnioTableAdapter
            // 
            this.gPagosAnioTableAdapter.ClearBeforeFill = true;
            // 
            // FrmGPagosPorAnio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1344, 657);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxAnio);
            this.Controls.Add(this.btnGenerar);
            this.Name = "FrmGPagosPorAnio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGPagosPorAnio";
            this.Load += new System.EventHandler(this.FrmGPagosPorAnio_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cddGPagosPorAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gPagosAnioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.ComboBox cbxAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource gPagosAnioBindingSource;
        private CDD.cddGPagosPorAnio cddGPagosPorAnio;
        private CDD.cddGPagosPorAnioTableAdapters.GPagosAnioTableAdapter gPagosAnioTableAdapter;
    }
}