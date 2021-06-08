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
            this.sucesosTableAdapter = new ACAPOLAMI.CDD.cddActividadTableAdapters.SucesosTableAdapter();
            this.cddActividad = new ACAPOLAMI.CDD.cddActividad();
            this.sucesosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cddActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucesosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sucesosTableAdapter
            // 
            this.sucesosTableAdapter.ClearBeforeFill = true;
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
            // FrmActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 471);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmActividad";
            this.Text = "FrmActividad";
            this.Load += new System.EventHandler(this.FrmActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cddActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sucesosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CDD.cddActividadTableAdapters.SucesosTableAdapter sucesosTableAdapter;
        private CDD.cddActividad cddActividad;
        private System.Windows.Forms.BindingSource sucesosBindingSource;
    }
}