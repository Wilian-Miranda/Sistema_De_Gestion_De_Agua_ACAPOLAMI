
namespace ACAPOLAMI.VISTA
{
    partial class FrmPagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblTotalPagoBase = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalCancelado = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblTotalPendiente = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblTotalImpuesto = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregadoRapido = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtgPagos = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cbBuscarConsumidor = new System.Windows.Forms.ComboBox();
            this.btnBuscarConsumidor = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.btnModificarPago = new System.Windows.Forms.Button();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 97);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Controls.Add(this.panel8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1024, 97);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.lblTotalPagoBase);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(8, 8);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(3);
            this.panel6.Size = new System.Drawing.Size(232, 83);
            this.panel6.TabIndex = 5;
            // 
            // lblTotalPagoBase
            // 
            this.lblTotalPagoBase.AutoSize = true;
            this.lblTotalPagoBase.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagoBase.ForeColor = System.Drawing.Color.Black;
            this.lblTotalPagoBase.Location = new System.Drawing.Point(113, 42);
            this.lblTotalPagoBase.Name = "lblTotalPagoBase";
            this.lblTotalPagoBase.Size = new System.Drawing.Size(96, 27);
            this.lblTotalPagoBase.TabIndex = 6;
            this.lblTotalPagoBase.Text = "$0.0000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 75);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(113, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Pago Base";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalCancelado);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(246, 8);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(232, 83);
            this.panel2.TabIndex = 6;
            // 
            // lblTotalCancelado
            // 
            this.lblTotalCancelado.AutoSize = true;
            this.lblTotalCancelado.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCancelado.ForeColor = System.Drawing.Color.LightGreen;
            this.lblTotalCancelado.Location = new System.Drawing.Point(113, 42);
            this.lblTotalCancelado.Name = "lblTotalCancelado";
            this.lblTotalCancelado.Size = new System.Drawing.Size(96, 27);
            this.lblTotalCancelado.TabIndex = 6;
            this.lblTotalCancelado.Text = "$0.0000";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 75);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(113, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cancelado";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.lblTotalPendiente);
            this.panel7.Controls.Add(this.pictureBox3);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(484, 8);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(3);
            this.panel7.Size = new System.Drawing.Size(232, 83);
            this.panel7.TabIndex = 7;
            // 
            // lblTotalPendiente
            // 
            this.lblTotalPendiente.AutoSize = true;
            this.lblTotalPendiente.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPendiente.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTotalPendiente.Location = new System.Drawing.Point(113, 42);
            this.lblTotalPendiente.Name = "lblTotalPendiente";
            this.lblTotalPendiente.Size = new System.Drawing.Size(96, 27);
            this.lblTotalPendiente.TabIndex = 6;
            this.lblTotalPendiente.Text = "$0.0000";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 75);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(113, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pendiente";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.lblTotalImpuesto);
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(722, 8);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(3);
            this.panel8.Size = new System.Drawing.Size(232, 83);
            this.panel8.TabIndex = 8;
            // 
            // lblTotalImpuesto
            // 
            this.lblTotalImpuesto.AutoSize = true;
            this.lblTotalImpuesto.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalImpuesto.ForeColor = System.Drawing.Color.IndianRed;
            this.lblTotalImpuesto.Location = new System.Drawing.Point(113, 42);
            this.lblTotalImpuesto.Name = "lblTotalImpuesto";
            this.lblTotalImpuesto.Size = new System.Drawing.Size(96, 27);
            this.lblTotalImpuesto.TabIndex = 6;
            this.lblTotalImpuesto.Text = "$0.0000";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Location = new System.Drawing.Point(3, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 75);
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(113, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Impuesto";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel3.Controls.Add(this.btnAgregadoRapido);
            this.panel3.Location = new System.Drawing.Point(20, 589);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1024, 43);
            this.panel3.TabIndex = 2;
            // 
            // btnAgregadoRapido
            // 
            this.btnAgregadoRapido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregadoRapido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregadoRapido.ForeColor = System.Drawing.Color.Black;
            this.btnAgregadoRapido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregadoRapido.Location = new System.Drawing.Point(789, 3);
            this.btnAgregadoRapido.Name = "btnAgregadoRapido";
            this.btnAgregadoRapido.Size = new System.Drawing.Size(230, 37);
            this.btnAgregadoRapido.TabIndex = 3;
            this.btnAgregadoRapido.Text = "Agregado Optimizado";
            this.btnAgregadoRapido.UseVisualStyleBackColor = true;
            this.btnAgregadoRapido.Click += new System.EventHandler(this.btnAgregadoRapido_Click);
            this.btnAgregadoRapido.MouseLeave += new System.EventHandler(this.btnAgregadoRapido_MouseLeave);
            this.btnAgregadoRapido.MouseHover += new System.EventHandler(this.btnAgregadoRapido_MouseHover);
            this.btnAgregadoRapido.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnAgregadoRapido_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.dtgPagos);
            this.panel4.Location = new System.Drawing.Point(20, 211);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(5);
            this.panel4.Size = new System.Drawing.Size(1024, 372);
            this.panel4.TabIndex = 3;
            // 
            // dtgPagos
            // 
            this.dtgPagos.AllowUserToAddRows = false;
            this.dtgPagos.AllowUserToDeleteRows = false;
            this.dtgPagos.AllowUserToResizeRows = false;
            this.dtgPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPagos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dtgPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgPagos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgPagos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPagos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPagos.EnableHeadersVisualStyles = false;
            this.dtgPagos.GridColor = System.Drawing.Color.Gainsboro;
            this.dtgPagos.Location = new System.Drawing.Point(5, 5);
            this.dtgPagos.MultiSelect = false;
            this.dtgPagos.Name = "dtgPagos";
            this.dtgPagos.ReadOnly = true;
            this.dtgPagos.RowHeadersVisible = false;
            this.dtgPagos.RowHeadersWidth = 51;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dtgPagos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPagos.ShowEditingIcon = false;
            this.dtgPagos.Size = new System.Drawing.Size(1014, 362);
            this.dtgPagos.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txtFilter);
            this.panel5.Controls.Add(this.cbBuscarConsumidor);
            this.panel5.Controls.Add(this.btnBuscarConsumidor);
            this.panel5.Controls.Add(this.btnRegistrarPago);
            this.panel5.Controls.Add(this.btnModificarPago);
            this.panel5.Controls.Add(this.btnEliminarPago);
            this.panel5.Location = new System.Drawing.Point(20, 124);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(5, 8, 5, 5);
            this.panel5.Size = new System.Drawing.Size(1024, 81);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar: ";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(127, 11);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(455, 30);
            this.txtFilter.TabIndex = 6;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cbBuscarConsumidor
            // 
            this.cbBuscarConsumidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuscarConsumidor.FormattingEnabled = true;
            this.cbBuscarConsumidor.Location = new System.Drawing.Point(127, 40);
            this.cbBuscarConsumidor.Name = "cbBuscarConsumidor";
            this.cbBuscarConsumidor.Size = new System.Drawing.Size(455, 32);
            this.cbBuscarConsumidor.TabIndex = 5;
            this.cbBuscarConsumidor.TextChanged += new System.EventHandler(this.cbBuscarConsumidor_TextChanged);
            this.cbBuscarConsumidor.Enter += new System.EventHandler(this.cbBuscarConsumidor_Enter);
            this.cbBuscarConsumidor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBuscarConsumidor_KeyPress);
            // 
            // btnBuscarConsumidor
            // 
            this.btnBuscarConsumidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarConsumidor.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarConsumidor.Image = global::ACAPOLAMI.Properties.Resources.lupa;
            this.btnBuscarConsumidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarConsumidor.Location = new System.Drawing.Point(9, 38);
            this.btnBuscarConsumidor.Name = "btnBuscarConsumidor";
            this.btnBuscarConsumidor.Size = new System.Drawing.Size(112, 35);
            this.btnBuscarConsumidor.TabIndex = 4;
            this.btnBuscarConsumidor.Text = "Filtrar:";
            this.btnBuscarConsumidor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarConsumidor.UseVisualStyleBackColor = true;
            this.btnBuscarConsumidor.Click += new System.EventHandler(this.btnBuscarConsumidor_Click);
            this.btnBuscarConsumidor.MouseLeave += new System.EventHandler(this.btnBuscarConsumidor_MouseLeave);
            this.btnBuscarConsumidor.MouseHover += new System.EventHandler(this.btnBuscarConsumidor_MouseHover);
            this.btnBuscarConsumidor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBuscarConsumidor_MouseMove);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPago.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarPago.Image = global::ACAPOLAMI.Properties.Resources.agregar_archivo;
            this.btnRegistrarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarPago.Location = new System.Drawing.Point(588, 11);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(144, 60);
            this.btnRegistrarPago.TabIndex = 2;
            this.btnRegistrarPago.Text = "     Registrar";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            this.btnRegistrarPago.MouseLeave += new System.EventHandler(this.btnRegistrarPago_MouseLeave);
            this.btnRegistrarPago.MouseHover += new System.EventHandler(this.btnRegistrarPago_MouseHover);
            this.btnRegistrarPago.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnRegistrarPago_MouseMove);
            // 
            // btnModificarPago
            // 
            this.btnModificarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarPago.ForeColor = System.Drawing.Color.Black;
            this.btnModificarPago.Image = global::ACAPOLAMI.Properties.Resources.editar;
            this.btnModificarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarPago.Location = new System.Drawing.Point(732, 11);
            this.btnModificarPago.Name = "btnModificarPago";
            this.btnModificarPago.Size = new System.Drawing.Size(144, 60);
            this.btnModificarPago.TabIndex = 1;
            this.btnModificarPago.Text = "     Modificar";
            this.btnModificarPago.UseVisualStyleBackColor = true;
            this.btnModificarPago.Click += new System.EventHandler(this.btnModificarPago_Click);
            this.btnModificarPago.MouseLeave += new System.EventHandler(this.btnModificarPago_MouseLeave);
            this.btnModificarPago.MouseHover += new System.EventHandler(this.btnModificarPago_MouseHover);
            this.btnModificarPago.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnModificarPago_MouseMove);
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarPago.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarPago.Image = global::ACAPOLAMI.Properties.Resources.basura;
            this.btnEliminarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPago.Location = new System.Drawing.Point(876, 11);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(144, 60);
            this.btnEliminarPago.TabIndex = 0;
            this.btnEliminarPago.Text = "     Eliminar";
            this.btnEliminarPago.UseVisualStyleBackColor = true;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            this.btnEliminarPago.MouseLeave += new System.EventHandler(this.btnEliminarPago_MouseLeave);
            this.btnEliminarPago.MouseHover += new System.EventHandler(this.btnEliminarPago_MouseHover);
            this.btnEliminarPago.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEliminarPago_MouseMove);
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1064, 652);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmPagos";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FrmPagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagos)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgPagos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.Button btnModificarPago;
        private System.Windows.Forms.Button btnEliminarPago;
        public System.Windows.Forms.ComboBox cbBuscarConsumidor;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnAgregadoRapido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblTotalPagoBase;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalCancelado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblTotalPendiente;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblTotalImpuesto;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button btnBuscarConsumidor;
    }
}