namespace EDNAProyecto
{
    partial class MantCompras
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
            this.e_venta = new System.Windows.Forms.Button();
            this.r_venta = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detalle_compra = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_compra = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_compra)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_compra)).BeginInit();
            this.SuspendLayout();
            // 
            // e_venta
            // 
            this.e_venta.BackColor = System.Drawing.Color.Black;
            this.e_venta.ForeColor = System.Drawing.Color.White;
            this.e_venta.Location = new System.Drawing.Point(193, 549);
            this.e_venta.Name = "e_venta";
            this.e_venta.Size = new System.Drawing.Size(156, 36);
            this.e_venta.TabIndex = 27;
            this.e_venta.Text = "─ Eliminar Compra ─";
            this.e_venta.UseVisualStyleBackColor = false;
            this.e_venta.Click += new System.EventHandler(this.e_venta_Click);
            // 
            // r_venta
            // 
            this.r_venta.BackColor = System.Drawing.Color.Black;
            this.r_venta.ForeColor = System.Drawing.Color.White;
            this.r_venta.Location = new System.Drawing.Point(31, 549);
            this.r_venta.Name = "r_venta";
            this.r_venta.Size = new System.Drawing.Size(156, 36);
            this.r_venta.TabIndex = 26;
            this.r_venta.Text = "─ Registrar Compra ─";
            this.r_venta.UseVisualStyleBackColor = false;
            this.r_venta.Click += new System.EventHandler(this.r_venta_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.detalle_compra);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 278);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLE";
            // 
            // detalle_compra
            // 
            this.detalle_compra.AllowUserToAddRows = false;
            this.detalle_compra.AllowUserToDeleteRows = false;
            this.detalle_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalle_compra.Location = new System.Drawing.Point(19, 29);
            this.detalle_compra.MultiSelect = false;
            this.detalle_compra.Name = "detalle_compra";
            this.detalle_compra.ReadOnly = true;
            this.detalle_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detalle_compra.Size = new System.Drawing.Size(658, 230);
            this.detalle_compra.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_compra);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 236);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPRA";
            // 
            // data_compra
            // 
            this.data_compra.AllowUserToAddRows = false;
            this.data_compra.AllowUserToDeleteRows = false;
            this.data_compra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_compra.Location = new System.Drawing.Point(19, 32);
            this.data_compra.Margin = new System.Windows.Forms.Padding(2);
            this.data_compra.MultiSelect = false;
            this.data_compra.Name = "data_compra";
            this.data_compra.ReadOnly = true;
            this.data_compra.RowHeadersWidth = 51;
            this.data_compra.RowTemplate.Height = 24;
            this.data_compra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_compra.Size = new System.Drawing.Size(658, 180);
            this.data_compra.TabIndex = 1;
            this.data_compra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_compra_CellClick);
            // 
            // MantCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 599);
            this.Controls.Add(this.e_venta);
            this.Controls.Add(this.r_venta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MantCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantCompras";
            this.Load += new System.EventHandler(this.MantCompras_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalle_compra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_compra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button e_venta;
        private System.Windows.Forms.Button r_venta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView detalle_compra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView data_compra;
    }
}