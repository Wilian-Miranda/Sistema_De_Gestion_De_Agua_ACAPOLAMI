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
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnHistorial = new FontAwesome.Sharp.IconButton();
            this.btnActualizar = new FontAwesome.Sharp.IconButton();
            this.lstActividades = new Zeroit.Framework.ListView.ZeroitListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.lblTexto);
            this.panel4.Controls.Add(this.btnHistorial);
            this.panel4.Controls.Add(this.btnActualizar);
            this.panel4.Controls.Add(this.lstActividades);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(24, 98);
            this.panel4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(33, 29, 33, 29);
            this.panel4.Size = new System.Drawing.Size(1018, 530);
            this.panel4.TabIndex = 12;
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTexto.AutoSize = true;
            this.lblTexto.BackColor = System.Drawing.Color.White;
            this.lblTexto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.ForeColor = System.Drawing.Color.Black;
            this.lblTexto.Location = new System.Drawing.Point(30, 456);
            this.lblTexto.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(158, 19);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Ultimos 20 sucesos";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistorial.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.IconChar = FontAwesome.Sharp.IconChar.ListUl;
            this.btnHistorial.IconColor = System.Drawing.Color.White;
            this.btnHistorial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHistorial.IconSize = 35;
            this.btnHistorial.Location = new System.Drawing.Point(853, 456);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(127, 41);
            this.btnHistorial.TabIndex = 16;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.IconChar = FontAwesome.Sharp.IconChar.ListOl;
            this.btnActualizar.IconColor = System.Drawing.Color.White;
            this.btnActualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizar.IconSize = 40;
            this.btnActualizar.Location = new System.Drawing.Point(716, 456);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(127, 41);
            this.btnActualizar.TabIndex = 15;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // lstActividades
            // 
            this.lstActividades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstActividades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstActividades.CellBorderFocused = new Zeroit.Framework.ListView.Editors.PenPainter.PenPainter(System.Drawing.Color.White, 1F, System.Drawing.Drawing2D.DashStyle.Solid);
            this.lstActividades.CellBorderUnFocused = new Zeroit.Framework.ListView.Editors.PenPainter.PenPainter(System.Drawing.Color.White, 1F, System.Drawing.Drawing2D.DashStyle.Solid);
            this.lstActividades.ColumnHeader = new Zeroit.Framework.ListView.Editors.Brushes.BrushPainter(System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(124)))), ((int)(((byte)(173))))));
            this.lstActividades.DrawMode = Zeroit.Framework.ListView.ZeroitListView.drawMode.Stylish;
            this.lstActividades.FillFocused = new Zeroit.Framework.ListView.Editors.Brushes.BrushPainter();
            this.lstActividades.FillUnfocused = new Zeroit.Framework.ListView.Editors.Brushes.BrushPainter(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))));
            this.lstActividades.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActividades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstActividades.HeaderAlignment = Zeroit.Framework.ListView.ZeroitListView.headerAlignment.Center;
            this.lstActividades.HeaderBorder = new Zeroit.Framework.ListView.Editors.PenPainter.PenPainter(System.Drawing.Color.White, 1F, System.Drawing.Drawing2D.DashStyle.Solid);
            this.lstActividades.HeaderColor = System.Drawing.Color.White;
            this.lstActividades.HeaderFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActividades.HideHeader = false;
            this.lstActividades.HideSelection = false;
            this.lstActividades.LineColor = System.Drawing.Color.White;
            this.lstActividades.LineHeight = 1;
            this.lstActividades.Location = new System.Drawing.Point(16, 20);
            this.lstActividades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.NumberStyles = ((System.Globalization.NumberStyles)((((((((System.Globalization.NumberStyles.AllowLeadingWhite | System.Globalization.NumberStyles.AllowTrailingWhite) 
            | System.Globalization.NumberStyles.AllowLeadingSign) 
            | System.Globalization.NumberStyles.AllowTrailingSign) 
            | System.Globalization.NumberStyles.AllowParentheses) 
            | System.Globalization.NumberStyles.AllowDecimalPoint) 
            | System.Globalization.NumberStyles.AllowThousands) 
            | System.Globalization.NumberStyles.AllowCurrencySymbol)));
            this.lstActividades.OwnerDraw = true;
            this.lstActividades.Radius = 15F;
            this.lstActividades.Rounding = false;
            this.lstActividades.ShowBorder = false;
            this.lstActividades.ShowCellBorder = false;
            this.lstActividades.ShowHeaderLine = false;
            this.lstActividades.Size = new System.Drawing.Size(985, 421);
            this.lstActividades.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.lstActividades.SubTextColor = System.Drawing.Color.Red;
            this.lstActividades.SurrondBorder = false;
            this.lstActividades.TabIndex = 13;
            this.lstActividades.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.lstActividades.UseCompatibleStateImageBehavior = false;
            this.lstActividades.View = System.Windows.Forms.View.Details;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(988, 501);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(24, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1018, 89);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1018, 50);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(400, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE ACTIVIDAD";
            // 
            // FrmActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 652);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmActividad";
            this.Padding = new System.Windows.Forms.Padding(33, 29, 33, 29);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmActividad";
            this.Load += new System.EventHandler(this.FrmActividad_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTexto;
        private FontAwesome.Sharp.IconButton btnHistorial;
        private FontAwesome.Sharp.IconButton btnActualizar;
        private Zeroit.Framework.ListView.ZeroitListView lstActividades;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}