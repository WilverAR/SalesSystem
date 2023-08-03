namespace EDNAProyecto
{
    partial class MantProv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantProv));
            this.c_distrito = new System.Windows.Forms.ComboBox();
            this.t_name = new System.Windows.Forms.TextBox();
            this.t_telefono = new System.Windows.Forms.TextBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_buscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_Proveedor = new System.Windows.Forms.DataGridView();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.e_proveedor = new System.Windows.Forms.Button();
            this.a_proveedor = new System.Windows.Forms.Button();
            this.r_proveedor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_Proveedor)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // c_distrito
            // 
            this.c_distrito.FormattingEnabled = true;
            this.c_distrito.Items.AddRange(new object[] {
            "Miraflores",
            "San Isidro",
            "Surco"});
            this.c_distrito.Location = new System.Drawing.Point(98, 201);
            this.c_distrito.Name = "c_distrito";
            this.c_distrito.Size = new System.Drawing.Size(119, 21);
            this.c_distrito.TabIndex = 3;
            // 
            // t_name
            // 
            this.t_name.Location = new System.Drawing.Point(96, 102);
            this.t_name.Margin = new System.Windows.Forms.Padding(2);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(119, 20);
            this.t_name.TabIndex = 1;
            // 
            // t_telefono
            // 
            this.t_telefono.Location = new System.Drawing.Point(96, 154);
            this.t_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.t_telefono.Name = "t_telefono";
            this.t_telefono.Size = new System.Drawing.Size(121, 20);
            this.t_telefono.TabIndex = 2;
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(125, 50);
            this.t_id.Margin = new System.Windows.Forms.Padding(2);
            this.t_id.Name = "t_id";
            this.t_id.ReadOnly = true;
            this.t_id.Size = new System.Drawing.Size(90, 20);
            this.t_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teléfono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distrito";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Proveedor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.t_buscar);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(13, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(687, 55);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "▀ BUSCAR PROVEEDOR";
            // 
            // t_buscar
            // 
            this.t_buscar.Location = new System.Drawing.Point(110, 28);
            this.t_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.t_buscar.Name = "t_buscar";
            this.t_buscar.Size = new System.Drawing.Size(562, 20);
            this.t_buscar.TabIndex = 4;
            this.t_buscar.TextChanged += new System.EventHandler(this.t_buscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.data_Proveedor);
            this.groupBox3.Location = new System.Drawing.Point(13, 90);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(687, 358);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "▀ LISTA DE PROVEEDORES";
            // 
            // data_Proveedor
            // 
            this.data_Proveedor.AllowUserToAddRows = false;
            this.data_Proveedor.AllowUserToDeleteRows = false;
            this.data_Proveedor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_Proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Proveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDIT});
            this.data_Proveedor.Location = new System.Drawing.Point(7, 38);
            this.data_Proveedor.Margin = new System.Windows.Forms.Padding(2);
            this.data_Proveedor.Name = "data_Proveedor";
            this.data_Proveedor.ReadOnly = true;
            this.data_Proveedor.RowHeadersWidth = 51;
            this.data_Proveedor.RowTemplate.Height = 24;
            this.data_Proveedor.Size = new System.Drawing.Size(665, 306);
            this.data_Proveedor.TabIndex = 0;
            this.data_Proveedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Proveedor_CellContentClick);
            this.data_Proveedor.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.data_Proveedor_CellPainting);
            // 
            // EDIT
            // 
            this.EDIT.HeaderText = "";
            this.EDIT.Name = "EDIT";
            this.EDIT.ReadOnly = true;
            this.EDIT.Text = "";
            this.EDIT.Width = 40;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.e_proveedor);
            this.groupBox1.Controls.Add(this.a_proveedor);
            this.groupBox1.Controls.Add(this.r_proveedor);
            this.groupBox1.Controls.Add(this.c_distrito);
            this.groupBox1.Controls.Add(this.t_name);
            this.groupBox1.Controls.Add(this.t_telefono);
            this.groupBox1.Controls.Add(this.t_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(238, 433);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "▀ DATOS DEL PROVEEDOR";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(43, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 8;
            this.button1.Text = "─ Nuevo Proveedor ─";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // e_proveedor
            // 
            this.e_proveedor.BackColor = System.Drawing.Color.Black;
            this.e_proveedor.ForeColor = System.Drawing.Color.White;
            this.e_proveedor.Location = new System.Drawing.Point(43, 380);
            this.e_proveedor.Name = "e_proveedor";
            this.e_proveedor.Size = new System.Drawing.Size(156, 35);
            this.e_proveedor.TabIndex = 7;
            this.e_proveedor.Text = "─ Eliminar Proveedor ─";
            this.e_proveedor.UseVisualStyleBackColor = false;
            this.e_proveedor.Click += new System.EventHandler(this.button3_Click);
            this.e_proveedor.MouseLeave += new System.EventHandler(this.e_proveedor_MouseLeave);
            this.e_proveedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.e_proveedor_MouseMove);
            // 
            // a_proveedor
            // 
            this.a_proveedor.BackColor = System.Drawing.Color.Black;
            this.a_proveedor.ForeColor = System.Drawing.Color.White;
            this.a_proveedor.Location = new System.Drawing.Point(43, 339);
            this.a_proveedor.Name = "a_proveedor";
            this.a_proveedor.Size = new System.Drawing.Size(156, 35);
            this.a_proveedor.TabIndex = 6;
            this.a_proveedor.Text = "─ Actualizar Proveedor ─";
            this.a_proveedor.UseVisualStyleBackColor = false;
            this.a_proveedor.Click += new System.EventHandler(this.button2_Click);
            this.a_proveedor.MouseLeave += new System.EventHandler(this.a_proveedor_MouseLeave);
            this.a_proveedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.a_proveedor_MouseMove);
            // 
            // r_proveedor
            // 
            this.r_proveedor.BackColor = System.Drawing.Color.Black;
            this.r_proveedor.ForeColor = System.Drawing.Color.White;
            this.r_proveedor.Location = new System.Drawing.Point(43, 298);
            this.r_proveedor.Name = "r_proveedor";
            this.r_proveedor.Size = new System.Drawing.Size(156, 35);
            this.r_proveedor.TabIndex = 5;
            this.r_proveedor.Text = "─ Registrar Proveedor ─";
            this.r_proveedor.UseVisualStyleBackColor = false;
            this.r_proveedor.Click += new System.EventHandler(this.button1_Click);
            this.r_proveedor.MouseLeave += new System.EventHandler(this.r_proveedor_MouseLeave);
            this.r_proveedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.r_proveedor_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 461);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(271, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(713, 461);
            this.panel2.TabIndex = 11;
            // 
            // MantProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantProv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "■ PROVEEDOR";
            this.Load += new System.EventHandler(this.MantProv_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_Proveedor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.TextBox t_telefono;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_buscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView data_Proveedor;
        private System.Windows.Forms.ComboBox c_distrito;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button e_proveedor;
        private System.Windows.Forms.Button a_proveedor;
        private System.Windows.Forms.Button r_proveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}