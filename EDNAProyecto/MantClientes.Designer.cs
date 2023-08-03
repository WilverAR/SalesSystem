namespace EDNAProyecto
{
    partial class MantClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MantClientes));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.data_clients = new System.Windows.Forms.DataGridView();
            this.EDIT = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.t_buscar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.e_cliente = new System.Windows.Forms.Button();
            this.a_cliente = new System.Windows.Forms.Button();
            this.r_cliente = new System.Windows.Forms.Button();
            this.t_telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_direccion = new System.Windows.Forms.TextBox();
            this.t_nombre = new System.Windows.Forms.TextBox();
            this.t_dni = new System.Windows.Forms.TextBox();
            this.t_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_clients)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.data_clients);
            this.groupBox3.Location = new System.Drawing.Point(14, 93);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(708, 373);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "▀ LISTA DE CLIENTES";
            // 
            // data_clients
            // 
            this.data_clients.AllowUserToAddRows = false;
            this.data_clients.AllowUserToDeleteRows = false;
            this.data_clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDIT});
            this.data_clients.Location = new System.Drawing.Point(9, 38);
            this.data_clients.Margin = new System.Windows.Forms.Padding(2);
            this.data_clients.Name = "data_clients";
            this.data_clients.ReadOnly = true;
            this.data_clients.RowHeadersWidth = 51;
            this.data_clients.RowTemplate.Height = 24;
            this.data_clients.Size = new System.Drawing.Size(686, 319);
            this.data_clients.TabIndex = 0;
            this.data_clients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_clients_CellContentClick);
            this.data_clients.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.data_clients_CellPainting);
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
            this.groupBox2.Location = new System.Drawing.Point(14, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(708, 55);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "▀ BUSCAR CLIENTE";
            // 
            // t_buscar
            // 
            this.t_buscar.Location = new System.Drawing.Point(94, 26);
            this.t_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.t_buscar.Name = "t_buscar";
            this.t_buscar.Size = new System.Drawing.Size(601, 20);
            this.t_buscar.TabIndex = 5;
            this.t_buscar.TextChanged += new System.EventHandler(this.t_buscar_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Buscar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.e_cliente);
            this.groupBox1.Controls.Add(this.a_cliente);
            this.groupBox1.Controls.Add(this.r_cliente);
            this.groupBox1.Controls.Add(this.t_telefono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.t_direccion);
            this.groupBox1.Controls.Add(this.t_nombre);
            this.groupBox1.Controls.Add(this.t_dni);
            this.groupBox1.Controls.Add(this.t_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(218, 443);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "▀ DATOS DE CLIENTE";
            // 
            // e_cliente
            // 
            this.e_cliente.BackColor = System.Drawing.Color.Black;
            this.e_cliente.ForeColor = System.Drawing.Color.White;
            this.e_cliente.Location = new System.Drawing.Point(32, 392);
            this.e_cliente.Name = "e_cliente";
            this.e_cliente.Size = new System.Drawing.Size(156, 35);
            this.e_cliente.TabIndex = 29;
            this.e_cliente.Text = "─ Eliminar Cliente ─";
            this.e_cliente.UseVisualStyleBackColor = false;
            this.e_cliente.Click += new System.EventHandler(this.button3_Click);
            this.e_cliente.MouseLeave += new System.EventHandler(this.e_cliente_MouseLeave);
            this.e_cliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.e_cliente_MouseMove);
            // 
            // a_cliente
            // 
            this.a_cliente.BackColor = System.Drawing.Color.Black;
            this.a_cliente.ForeColor = System.Drawing.Color.White;
            this.a_cliente.Location = new System.Drawing.Point(32, 351);
            this.a_cliente.Name = "a_cliente";
            this.a_cliente.Size = new System.Drawing.Size(156, 35);
            this.a_cliente.TabIndex = 28;
            this.a_cliente.Text = "─ Actualizar Cliente ─";
            this.a_cliente.UseVisualStyleBackColor = false;
            this.a_cliente.Click += new System.EventHandler(this.button2_Click);
            this.a_cliente.MouseLeave += new System.EventHandler(this.a_cliente_MouseLeave);
            this.a_cliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.a_cliente_MouseMove);
            // 
            // r_cliente
            // 
            this.r_cliente.BackColor = System.Drawing.Color.Black;
            this.r_cliente.ForeColor = System.Drawing.Color.White;
            this.r_cliente.Location = new System.Drawing.Point(32, 310);
            this.r_cliente.Name = "r_cliente";
            this.r_cliente.Size = new System.Drawing.Size(156, 35);
            this.r_cliente.TabIndex = 27;
            this.r_cliente.Text = "─ Registrar Cliente ─";
            this.r_cliente.UseVisualStyleBackColor = false;
            this.r_cliente.Click += new System.EventHandler(this.button1_Click);
            this.r_cliente.MouseLeave += new System.EventHandler(this.r_cliente_MouseLeave);
            this.r_cliente.MouseMove += new System.Windows.Forms.MouseEventHandler(this.r_cliente_MouseMove);
            // 
            // t_telefono
            // 
            this.t_telefono.Location = new System.Drawing.Point(103, 136);
            this.t_telefono.Margin = new System.Windows.Forms.Padding(2);
            this.t_telefono.Name = "t_telefono";
            this.t_telefono.Size = new System.Drawing.Size(94, 20);
            this.t_telefono.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Teléfono";
            // 
            // t_direccion
            // 
            this.t_direccion.Location = new System.Drawing.Point(103, 233);
            this.t_direccion.Margin = new System.Windows.Forms.Padding(2);
            this.t_direccion.Name = "t_direccion";
            this.t_direccion.Size = new System.Drawing.Size(94, 20);
            this.t_direccion.TabIndex = 3;
            // 
            // t_nombre
            // 
            this.t_nombre.Location = new System.Drawing.Point(103, 185);
            this.t_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.t_nombre.Name = "t_nombre";
            this.t_nombre.Size = new System.Drawing.Size(94, 20);
            this.t_nombre.TabIndex = 1;
            // 
            // t_dni
            // 
            this.t_dni.Location = new System.Drawing.Point(103, 87);
            this.t_dni.Margin = new System.Windows.Forms.Padding(2);
            this.t_dni.Name = "t_dni";
            this.t_dni.Size = new System.Drawing.Size(94, 20);
            this.t_dni.TabIndex = 2;
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(103, 42);
            this.t_id.Margin = new System.Windows.Forms.Padding(2);
            this.t_id.Name = "t_id";
            this.t_id.ReadOnly = true;
            this.t_id.Size = new System.Drawing.Size(94, 20);
            this.t_id.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 233);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cliente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 479);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(249, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 479);
            this.panel2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(32, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 30;
            this.button1.Text = "─ Nuevo Cliente ─";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MantClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(984, 479);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MantClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "■ CLIENTE";
            this.Load += new System.EventHandler(this.MantClientes_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_clients)).EndInit();
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
        private System.Windows.Forms.DataGridView data_clients;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox t_buscar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox t_telefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_direccion;
        private System.Windows.Forms.TextBox t_nombre;
        private System.Windows.Forms.TextBox t_dni;
        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn EDIT;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button e_cliente;
        private System.Windows.Forms.Button a_cliente;
        private System.Windows.Forms.Button r_cliente;
        private System.Windows.Forms.Button button1;
    }
}