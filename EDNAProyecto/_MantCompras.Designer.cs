namespace EDNAProyecto
{
    partial class _MantCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_MantCompras));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_compra = new System.Windows.Forms.DataGridView();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_buscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.e_compra = new System.Windows.Forms.Button();
            this.r_compra = new System.Windows.Forms.Button();
            this.t_precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.c_id_comp = new System.Windows.Forms.ComboBox();
            this.t_talla = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.t_marca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.c_proveedor = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.t_total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_cantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Timer_Check = new System.Windows.Forms.Timer(this.components);
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_compra)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.data_compra);
            this.groupBox3.Location = new System.Drawing.Point(11, 84);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(682, 657);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "▀ LISTA DE COMPRAS";
            // 
            // data_compra
            // 
            this.data_compra.AllowUserToAddRows = false;
            this.data_compra.AllowUserToDeleteRows = false;
            this.data_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_compra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDIT});
            this.data_compra.Location = new System.Drawing.Point(12, 33);
            this.data_compra.Margin = new System.Windows.Forms.Padding(2);
            this.data_compra.Name = "data_compra";
            this.data_compra.ReadOnly = true;
            this.data_compra.RowHeadersWidth = 51;
            this.data_compra.RowTemplate.Height = 24;
            this.data_compra.Size = new System.Drawing.Size(656, 259);
            this.data_compra.TabIndex = 0;
            this.data_compra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_compra_CellContentClick);
            this.data_compra.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.data_compra_CellPainting);
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
            this.groupBox2.Location = new System.Drawing.Point(11, 12);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(682, 55);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "▀ BUSCAR COMPRA";
            // 
            // t_buscar
            // 
            this.t_buscar.Location = new System.Drawing.Point(98, 26);
            this.t_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.t_buscar.Name = "t_buscar";
            this.t_buscar.Size = new System.Drawing.Size(570, 20);
            this.t_buscar.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.e_compra);
            this.groupBox1.Controls.Add(this.r_compra);
            this.groupBox1.Controls.Add(this.t_precio);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.c_id_comp);
            this.groupBox1.Controls.Add(this.t_talla);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.t_marca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtp_fecha);
            this.groupBox1.Controls.Add(this.c_proveedor);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.t_total);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.t_cantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label100);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(250, 436);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "▀ DATOS DE COMPRA";
            // 
            // e_compra
            // 
            this.e_compra.BackColor = System.Drawing.Color.Black;
            this.e_compra.ForeColor = System.Drawing.Color.White;
            this.e_compra.Location = new System.Drawing.Point(45, 388);
            this.e_compra.Name = "e_compra";
            this.e_compra.Size = new System.Drawing.Size(156, 36);
            this.e_compra.TabIndex = 26;
            this.e_compra.Text = "─ Eliminar Venta ─";
            this.e_compra.UseVisualStyleBackColor = false;
            this.e_compra.Click += new System.EventHandler(this.e_compra_Click);
            this.e_compra.MouseLeave += new System.EventHandler(this.e_compra_MouseLeave);
            this.e_compra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.e_compra_MouseMove);
            // 
            // r_compra
            // 
            this.r_compra.BackColor = System.Drawing.Color.Black;
            this.r_compra.ForeColor = System.Drawing.Color.White;
            this.r_compra.Location = new System.Drawing.Point(45, 346);
            this.r_compra.Name = "r_compra";
            this.r_compra.Size = new System.Drawing.Size(156, 36);
            this.r_compra.TabIndex = 25;
            this.r_compra.Text = "─ Registrar Venta ─";
            this.r_compra.UseVisualStyleBackColor = false;
            this.r_compra.Click += new System.EventHandler(this.r_compra_Click);
            this.r_compra.MouseLeave += new System.EventHandler(this.r_compra_MouseLeave);
            this.r_compra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.r_compra_MouseMove);
            // 
            // t_precio
            // 
            this.t_precio.Location = new System.Drawing.Point(97, 223);
            this.t_precio.Margin = new System.Windows.Forms.Padding(2);
            this.t_precio.Name = "t_precio";
            this.t_precio.ReadOnly = true;
            this.t_precio.Size = new System.Drawing.Size(138, 20);
            this.t_precio.TabIndex = 24;
            this.t_precio.TextChanged += new System.EventHandler(this.t_precio_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Precio";
            // 
            // c_id_comp
            // 
            this.c_id_comp.Enabled = false;
            this.c_id_comp.FormattingEnabled = true;
            this.c_id_comp.Location = new System.Drawing.Point(97, 38);
            this.c_id_comp.Name = "c_id_comp";
            this.c_id_comp.Size = new System.Drawing.Size(138, 21);
            this.c_id_comp.TabIndex = 22;
            // 
            // t_talla
            // 
            this.t_talla.Location = new System.Drawing.Point(97, 150);
            this.t_talla.Margin = new System.Windows.Forms.Padding(2);
            this.t_talla.Name = "t_talla";
            this.t_talla.Size = new System.Drawing.Size(138, 20);
            this.t_talla.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Talla";
            // 
            // t_marca
            // 
            this.t_marca.Location = new System.Drawing.Point(97, 112);
            this.t_marca.Margin = new System.Windows.Forms.Padding(2);
            this.t_marca.Name = "t_marca";
            this.t_marca.Size = new System.Drawing.Size(138, 20);
            this.t_marca.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Marca";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha.Location = new System.Drawing.Point(97, 299);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(138, 20);
            this.dtp_fecha.TabIndex = 13;
            // 
            // c_proveedor
            // 
            this.c_proveedor.FormattingEnabled = true;
            this.c_proveedor.Location = new System.Drawing.Point(97, 74);
            this.c_proveedor.Name = "c_proveedor";
            this.c_proveedor.Size = new System.Drawing.Size(138, 21);
            this.c_proveedor.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Fecha";
            // 
            // t_total
            // 
            this.t_total.Location = new System.Drawing.Point(97, 261);
            this.t_total.Margin = new System.Windows.Forms.Padding(2);
            this.t_total.Name = "t_total";
            this.t_total.ReadOnly = true;
            this.t_total.Size = new System.Drawing.Size(138, 20);
            this.t_total.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 261);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // t_cantidad
            // 
            this.t_cantidad.Location = new System.Drawing.Point(97, 187);
            this.t_cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.t_cantidad.Name = "t_cantidad";
            this.t_cantidad.Size = new System.Drawing.Size(138, 20);
            this.t_cantidad.TabIndex = 5;
            this.t_cantidad.TextChanged += new System.EventHandler(this.t_cantidad_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedor";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(10, 38);
            this.label100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(74, 17);
            this.label100.TabIndex = 0;
            this.label100.Text = "ID Compra";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(278, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 466);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 466);
            this.panel2.TabIndex = 23;
            // 
            // Timer_Check
            // 
            this.Timer_Check.Enabled = true;
            this.Timer_Check.Tick += new System.EventHandler(this.Timer_Check_Tick);
            // 
            // MantCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(984, 466);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "■ COMPRA";
            this.Load += new System.EventHandler(this.MantCompras_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_compra)).EndInit();
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
        private System.Windows.Forms.DataGridView data_compra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_buscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox t_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.TextBox t_talla;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox t_marca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.ComboBox c_proveedor;
        private System.Windows.Forms.ComboBox c_id_comp;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.TextBox t_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button e_compra;
        private System.Windows.Forms.Button r_compra;
        private System.Windows.Forms.Timer Timer_Check;
    }
}