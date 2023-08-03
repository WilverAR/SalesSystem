namespace EDNAProyecto
{
    partial class _MantVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_MantVentas));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_venta = new System.Windows.Forms.DataGridView();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_buscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.t_precio = new System.Windows.Forms.TextBox();
            this.e_venta = new System.Windows.Forms.Button();
            this.r_venta = new System.Windows.Forms.Button();
            this.c_id_venta = new System.Windows.Forms.ComboBox();
            this.t_cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.c_producto = new System.Windows.Forms.ComboBox();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.t_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timerVentaP = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_venta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.data_venta);
            this.groupBox3.Location = new System.Drawing.Point(14, 95);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(692, 355);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "▀ LISTA DE VENTAS";
            // 
            // data_venta
            // 
            this.data_venta.AllowUserToAddRows = false;
            this.data_venta.AllowUserToDeleteRows = false;
            this.data_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_venta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDIT});
            this.data_venta.Location = new System.Drawing.Point(18, 34);
            this.data_venta.Margin = new System.Windows.Forms.Padding(2);
            this.data_venta.Name = "data_venta";
            this.data_venta.ReadOnly = true;
            this.data_venta.RowHeadersWidth = 51;
            this.data_venta.RowTemplate.Height = 24;
            this.data_venta.Size = new System.Drawing.Size(659, 307);
            this.data_venta.TabIndex = 0;
            this.data_venta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_venta_CellContentClick);
            this.data_venta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.data_venta_CellPainting);
            // 
            // EDIT
            // 
            this.EDIT.HeaderText = "";
            this.EDIT.Name = "EDIT";
            this.EDIT.ReadOnly = true;
            this.EDIT.Width = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.t_buscar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(14, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(692, 61);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "▀ BUSCAR VENTA";
            // 
            // t_buscar
            // 
            this.t_buscar.Location = new System.Drawing.Point(91, 29);
            this.t_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.t_buscar.Name = "t_buscar";
            this.t_buscar.Size = new System.Drawing.Size(586, 20);
            this.t_buscar.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(35, 29);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.t_precio);
            this.groupBox1.Controls.Add(this.e_venta);
            this.groupBox1.Controls.Add(this.r_venta);
            this.groupBox1.Controls.Add(this.c_id_venta);
            this.groupBox1.Controls.Add(this.t_cantidad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.c_producto);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.t_total);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(233, 431);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "▀ DATOS DE VENTA";
            // 
            // t_precio
            // 
            this.t_precio.Location = new System.Drawing.Point(100, 160);
            this.t_precio.Name = "t_precio";
            this.t_precio.ReadOnly = true;
            this.t_precio.Size = new System.Drawing.Size(120, 20);
            this.t_precio.TabIndex = 23;
            this.t_precio.TextChanged += new System.EventHandler(this.t_precio_TextChanged_1);
            // 
            // e_venta
            // 
            this.e_venta.BackColor = System.Drawing.Color.Black;
            this.e_venta.ForeColor = System.Drawing.Color.White;
            this.e_venta.Location = new System.Drawing.Point(39, 373);
            this.e_venta.Name = "e_venta";
            this.e_venta.Size = new System.Drawing.Size(156, 36);
            this.e_venta.TabIndex = 22;
            this.e_venta.Text = "─ Eliminar Venta ─";
            this.e_venta.UseVisualStyleBackColor = false;
            this.e_venta.Click += new System.EventHandler(this.button2_Click);
            this.e_venta.MouseLeave += new System.EventHandler(this.e_venta_MouseLeave);
            this.e_venta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.e_venta_MouseMove);
            // 
            // r_venta
            // 
            this.r_venta.BackColor = System.Drawing.Color.Black;
            this.r_venta.ForeColor = System.Drawing.Color.White;
            this.r_venta.Location = new System.Drawing.Point(39, 331);
            this.r_venta.Name = "r_venta";
            this.r_venta.Size = new System.Drawing.Size(156, 36);
            this.r_venta.TabIndex = 21;
            this.r_venta.Text = "─ Registrar Venta ─";
            this.r_venta.UseVisualStyleBackColor = false;
            this.r_venta.Click += new System.EventHandler(this.button1_Click);
            this.r_venta.MouseLeave += new System.EventHandler(this.r_venta_MouseLeave);
            this.r_venta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.r_venta_MouseMove);
            // 
            // c_id_venta
            // 
            this.c_id_venta.Enabled = false;
            this.c_id_venta.FormattingEnabled = true;
            this.c_id_venta.Location = new System.Drawing.Point(100, 44);
            this.c_id_venta.Name = "c_id_venta";
            this.c_id_venta.Size = new System.Drawing.Size(120, 21);
            this.c_id_venta.TabIndex = 20;
            // 
            // t_cantidad
            // 
            this.t_cantidad.Location = new System.Drawing.Point(100, 121);
            this.t_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.t_cantidad.Name = "t_cantidad";
            this.t_cantidad.Size = new System.Drawing.Size(120, 20);
            this.t_cantidad.TabIndex = 19;
            this.t_cantidad.TextChanged += new System.EventHandler(this.t_cantidad_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 121);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Precio";
            // 
            // c_producto
            // 
            this.c_producto.FormattingEnabled = true;
            this.c_producto.Location = new System.Drawing.Point(100, 82);
            this.c_producto.Name = "c_producto";
            this.c_producto.Size = new System.Drawing.Size(120, 21);
            this.c_producto.TabIndex = 14;
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(99, 241);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(121, 20);
            this.dtp_fecha.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha";
            // 
            // t_total
            // 
            this.t_total.Location = new System.Drawing.Point(100, 202);
            this.t_total.Margin = new System.Windows.Forms.Padding(2);
            this.t_total.Name = "t_total";
            this.t_total.ReadOnly = true;
            this.t_total.Size = new System.Drawing.Size(120, 20);
            this.t_total.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 82);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Venta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 461);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(265, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 461);
            this.panel2.TabIndex = 5;
            // 
            // timerVentaP
            // 
            this.timerVentaP.Enabled = true;
            this.timerVentaP.Interval = 10;
            this.timerVentaP.Tick += new System.EventHandler(this.timerVentaP_Tick);
            // 
            // MantVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ■ VENTA";
            this.Load += new System.EventHandler(this.MantVentas_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_venta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView data_venta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_buscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_cantidad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox c_producto;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox c_id_venta;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button e_venta;
        private System.Windows.Forms.Button r_venta;
        private System.Windows.Forms.TextBox t_precio;
        private System.Windows.Forms.Timer timerVentaP;
    }
}