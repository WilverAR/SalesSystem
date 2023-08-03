namespace EDNAProyecto
{
    partial class MantVentas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.data_venta = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.detalle_venta = new System.Windows.Forms.DataGridView();
            this.r_venta = new System.Windows.Forms.Button();
            this.e_venta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_venta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_venta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.data_venta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VENTA";
            // 
            // data_venta
            // 
            this.data_venta.AllowUserToAddRows = false;
            this.data_venta.AllowUserToDeleteRows = false;
            this.data_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_venta.Location = new System.Drawing.Point(19, 32);
            this.data_venta.Margin = new System.Windows.Forms.Padding(2);
            this.data_venta.MultiSelect = false;
            this.data_venta.Name = "data_venta";
            this.data_venta.ReadOnly = true;
            this.data_venta.RowHeadersWidth = 51;
            this.data_venta.RowTemplate.Height = 24;
            this.data_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_venta.Size = new System.Drawing.Size(658, 180);
            this.data_venta.TabIndex = 1;
            this.data_venta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_venta_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.detalle_venta);
            this.groupBox2.Location = new System.Drawing.Point(12, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLE";
            // 
            // detalle_venta
            // 
            this.detalle_venta.AllowUserToAddRows = false;
            this.detalle_venta.AllowUserToDeleteRows = false;
            this.detalle_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalle_venta.Location = new System.Drawing.Point(19, 29);
            this.detalle_venta.MultiSelect = false;
            this.detalle_venta.Name = "detalle_venta";
            this.detalle_venta.ReadOnly = true;
            this.detalle_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detalle_venta.Size = new System.Drawing.Size(658, 230);
            this.detalle_venta.TabIndex = 1;
            // 
            // r_venta
            // 
            this.r_venta.BackColor = System.Drawing.Color.Black;
            this.r_venta.ForeColor = System.Drawing.Color.White;
            this.r_venta.Location = new System.Drawing.Point(31, 549);
            this.r_venta.Name = "r_venta";
            this.r_venta.Size = new System.Drawing.Size(156, 36);
            this.r_venta.TabIndex = 22;
            this.r_venta.Text = "─ Registrar Venta ─";
            this.r_venta.UseVisualStyleBackColor = false;
            this.r_venta.Click += new System.EventHandler(this.r_venta_Click);
            // 
            // e_venta
            // 
            this.e_venta.BackColor = System.Drawing.Color.Black;
            this.e_venta.ForeColor = System.Drawing.Color.White;
            this.e_venta.Location = new System.Drawing.Point(193, 549);
            this.e_venta.Name = "e_venta";
            this.e_venta.Size = new System.Drawing.Size(156, 36);
            this.e_venta.TabIndex = 23;
            this.e_venta.Text = "─ Eliminar Venta ─";
            this.e_venta.UseVisualStyleBackColor = false;
            this.e_venta.Click += new System.EventHandler(this.e_venta_Click);
            // 
            // MantVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 599);
            this.Controls.Add(this.e_venta);
            this.Controls.Add(this.r_venta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MantVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MantVentas";
            this.Load += new System.EventHandler(this.MantVentas_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_venta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalle_venta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView detalle_venta;
        private System.Windows.Forms.Button r_venta;
        private System.Windows.Forms.DataGridView data_venta;
        private System.Windows.Forms.Button e_venta;
    }
}