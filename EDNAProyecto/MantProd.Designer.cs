namespace EDNAProyecto
{
    partial class MantProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantProd));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_product = new System.Windows.Forms.DataGridView();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_buscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.e_producto = new System.Windows.Forms.Button();
            this.a_producto = new System.Windows.Forms.Button();
            this.r_producto = new System.Windows.Forms.Button();
            this.t_code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.c_categoria = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_stock_actual = new System.Windows.Forms.TextBox();
            this.t_nombre = new System.Windows.Forms.TextBox();
            this.t_stock_inicial = new System.Windows.Forms.TextBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_product)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.data_product);
            this.groupBox3.Location = new System.Drawing.Point(9, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(686, 372);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "▀ LISTA DE PRODUCTOS";
            // 
            // data_product
            // 
            this.data_product.AllowUserToAddRows = false;
            this.data_product.AllowUserToDeleteRows = false;
            this.data_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDIT});
            this.data_product.Location = new System.Drawing.Point(18, 28);
            this.data_product.Margin = new System.Windows.Forms.Padding(2);
            this.data_product.Name = "data_product";
            this.data_product.ReadOnly = true;
            this.data_product.RowHeadersWidth = 51;
            this.data_product.RowTemplate.Height = 24;
            this.data_product.Size = new System.Drawing.Size(654, 326);
            this.data_product.TabIndex = 0;
            this.data_product.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_product_CellContentClick);
            this.data_product.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.data_product_CellPainting);
            // 
            // EDIT
            // 
            this.EDIT.HeaderText = "";
            this.EDIT.Name = "EDIT";
            this.EDIT.ReadOnly = true;
            this.EDIT.Width = 40;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.t_buscar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(9, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(686, 55);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "▀ BUSCAR PRODUCTO";
            // 
            // t_buscar
            // 
            this.t_buscar.Location = new System.Drawing.Point(101, 26);
            this.t_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.t_buscar.Name = "t_buscar";
            this.t_buscar.Size = new System.Drawing.Size(571, 20);
            this.t_buscar.TabIndex = 4;
            this.t_buscar.TextChanged += new System.EventHandler(this.t_buscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.e_producto);
            this.groupBox1.Controls.Add(this.a_producto);
            this.groupBox1.Controls.Add(this.r_producto);
            this.groupBox1.Controls.Add(this.t_code);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.c_categoria);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.t_stock_actual);
            this.groupBox1.Controls.Add(this.t_nombre);
            this.groupBox1.Controls.Add(this.t_stock_inicial);
            this.groupBox1.Controls.Add(this.t_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(244, 450);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "▀ DATOS DEL PRODUCTO";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "─ Nuevo Producto ─";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // e_producto
            // 
            this.e_producto.BackColor = System.Drawing.Color.Black;
            this.e_producto.ForeColor = System.Drawing.Color.White;
            this.e_producto.Location = new System.Drawing.Point(43, 397);
            this.e_producto.Name = "e_producto";
            this.e_producto.Size = new System.Drawing.Size(156, 35);
            this.e_producto.TabIndex = 26;
            this.e_producto.Text = "─ Eliminar Producto ─";
            this.e_producto.UseVisualStyleBackColor = false;
            this.e_producto.Click += new System.EventHandler(this.button3_Click);
            this.e_producto.MouseLeave += new System.EventHandler(this.e_producto_MouseLeave);
            this.e_producto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.e_producto_MouseMove);
            // 
            // a_producto
            // 
            this.a_producto.BackColor = System.Drawing.Color.Black;
            this.a_producto.ForeColor = System.Drawing.Color.White;
            this.a_producto.Location = new System.Drawing.Point(43, 356);
            this.a_producto.Name = "a_producto";
            this.a_producto.Size = new System.Drawing.Size(156, 35);
            this.a_producto.TabIndex = 25;
            this.a_producto.Text = "─ Actualizar Producto ─";
            this.a_producto.UseVisualStyleBackColor = false;
            this.a_producto.Click += new System.EventHandler(this.button2_Click);
            this.a_producto.MouseLeave += new System.EventHandler(this.a_producto_MouseLeave);
            this.a_producto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.a_producto_MouseMove);
            // 
            // r_producto
            // 
            this.r_producto.BackColor = System.Drawing.Color.Black;
            this.r_producto.ForeColor = System.Drawing.Color.White;
            this.r_producto.Location = new System.Drawing.Point(43, 315);
            this.r_producto.Name = "r_producto";
            this.r_producto.Size = new System.Drawing.Size(156, 35);
            this.r_producto.TabIndex = 24;
            this.r_producto.Text = "─ Registrar Producto ─";
            this.r_producto.UseVisualStyleBackColor = false;
            this.r_producto.Click += new System.EventHandler(this.button1_Click);
            this.r_producto.MouseLeave += new System.EventHandler(this.r_producto_MouseLeave);
            this.r_producto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // t_code
            // 
            this.t_code.Location = new System.Drawing.Point(104, 196);
            this.t_code.Margin = new System.Windows.Forms.Padding(2);
            this.t_code.Name = "t_code";
            this.t_code.Size = new System.Drawing.Size(121, 20);
            this.t_code.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Codigo";
            // 
            // c_categoria
            // 
            this.c_categoria.FormattingEnabled = true;
            this.c_categoria.Items.AddRange(new object[] {
            "Polos",
            "Pantalones",
            "Zapatillas"});
            this.c_categoria.Location = new System.Drawing.Point(104, 237);
            this.c_categoria.Name = "c_categoria";
            this.c_categoria.Size = new System.Drawing.Size(121, 21);
            this.c_categoria.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoria";
            // 
            // t_stock_actual
            // 
            this.t_stock_actual.Location = new System.Drawing.Point(104, 155);
            this.t_stock_actual.Margin = new System.Windows.Forms.Padding(2);
            this.t_stock_actual.Name = "t_stock_actual";
            this.t_stock_actual.ReadOnly = true;
            this.t_stock_actual.Size = new System.Drawing.Size(121, 20);
            this.t_stock_actual.TabIndex = 7;
            this.t_stock_actual.Text = "0";
            // 
            // t_nombre
            // 
            this.t_nombre.Location = new System.Drawing.Point(104, 75);
            this.t_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.t_nombre.Name = "t_nombre";
            this.t_nombre.Size = new System.Drawing.Size(121, 20);
            this.t_nombre.TabIndex = 1;
            // 
            // t_stock_inicial
            // 
            this.t_stock_inicial.Location = new System.Drawing.Point(104, 116);
            this.t_stock_inicial.Margin = new System.Windows.Forms.Padding(2);
            this.t_stock_inicial.Name = "t_stock_inicial";
            this.t_stock_inicial.Size = new System.Drawing.Size(121, 20);
            this.t_stock_inicial.TabIndex = 2;
            this.t_stock_inicial.TextChanged += new System.EventHandler(this.t_stock_inicial_TextChanged);
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(104, 35);
            this.t_id.Margin = new System.Windows.Forms.Padding(2);
            this.t_id.Name = "t_id";
            this.t_id.ReadOnly = true;
            this.t_id.Size = new System.Drawing.Size(121, 20);
            this.t_id.TabIndex = 4;
            this.t_id.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 116);
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
            this.label2.Location = new System.Drawing.Point(18, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Producto";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 479);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(276, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(708, 479);
            this.panel2.TabIndex = 15;
            // 
            // MantProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "■ PRODUCTO";
            this.Load += new System.EventHandler(this.MantProd_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_product)).EndInit();
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
        private System.Windows.Forms.DataGridView data_product;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_buscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_stock_actual;
        private System.Windows.Forms.TextBox t_nombre;
        private System.Windows.Forms.TextBox t_stock_inicial;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox c_categoria;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.TextBox t_code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button e_producto;
        private System.Windows.Forms.Button a_producto;
        private System.Windows.Forms.Button r_producto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}