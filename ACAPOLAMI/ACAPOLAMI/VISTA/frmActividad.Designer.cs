namespace ACAPOLAMI.VISTA
{
    partial class FrmActividad
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cddActividad = new ACAPOLAMI.CDD.cddActividad();
            this.sucesosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sucesosTableAdapter = new ACAPOLAMI.CDD.cddActividadTableAdapters.SucesosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cddActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucesosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sucesosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ACAPOLAMI.REPORTES.Actividad.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1308, 724);
            this.reportViewer1.TabIndex = 0;
            // 
            // cddActividad
            // 
            this.cddActividad.DataSetName = "cddActividad";
            this.cddActividad.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sucesosBindingSource
            // 
            this.sucesosBindingSource.DataMember = "Sucesos";
            this.sucesosBindingSource.DataSource = this.cddActividad;
            // 
            // sucesosTableAdapter
            // 
            this.sucesosTableAdapter.ClearBeforeFill = true;
            // 
            // FrmActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 724);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmActividad";
            this.Text = "FrmActividad";
            this.Load += new System.EventHandler(this.FrmActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cddActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucesosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private CDD.cddActividad cddActividad;
        private System.Windows.Forms.BindingSource sucesosBindingSource;
        private CDD.cddActividadTableAdapters.SucesosTableAdapter sucesosTableAdapter;
    }
}