
namespace EDNAProyecto
{
    partial class Fr_Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Venta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c_zona_venta = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.venta_next = new System.Windows.Forms.Button();
            this.c_cliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.c_tipo_comprobante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c_zona_venta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.venta_next);
            this.groupBox1.Controls.Add(this.c_cliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.c_tipo_comprobante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(537, 239);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "▀ DATOS DE VENTA";
            // 
            // c_zona_venta
            // 
            this.c_zona_venta.FormattingEnabled = true;
            this.c_zona_venta.Items.AddRange(new object[] {
            "Miraflores",
            "San Isidro",
            "San Miguel",
            "Surco",
            "La molina"});
            this.c_zona_venta.Location = new System.Drawing.Point(141, 174);
            this.c_zona_venta.Name = "c_zona_venta";
            this.c_zona_venta.Size = new System.Drawing.Size(138, 21);
            this.c_zona_venta.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "■ Zona";
            // 
            // venta_next
            // 
            this.venta_next.BackColor = System.Drawing.Color.Black;
            this.venta_next.ForeColor = System.Drawing.Color.White;
            this.venta_next.Location = new System.Drawing.Point(387, 83);
            this.venta_next.Name = "venta_next";
            this.venta_next.Size = new System.Drawing.Size(130, 70);
            this.venta_next.TabIndex = 18;
            this.venta_next.Text = "─ NEXT ─ ";
            this.venta_next.UseVisualStyleBackColor = false;
            this.venta_next.Click += new System.EventHandler(this.button1_Click);
            this.venta_next.MouseLeave += new System.EventHandler(this.venta_next_MouseLeave);
            this.venta_next.MouseMove += new System.Windows.Forms.MouseEventHandler(this.venta_next_MouseMove);
            // 
            // c_cliente
            // 
            this.c_cliente.FormattingEnabled = true;
            this.c_cliente.Location = new System.Drawing.Point(141, 42);
            this.c_cliente.Name = "c_cliente";
            this.c_cliente.Size = new System.Drawing.Size(138, 21);
            this.c_cliente.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "■ Cliente";
            // 
            // c_tipo_comprobante
            // 
            this.c_tipo_comprobante.FormattingEnabled = true;
            this.c_tipo_comprobante.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.c_tipo_comprobante.Location = new System.Drawing.Point(196, 108);
            this.c_tipo_comprobante.Name = "c_tipo_comprobante";
            this.c_tipo_comprobante.Size = new System.Drawing.Size(138, 21);
            this.c_tipo_comprobante.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "■ Tipo Comprobante";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 261);
            this.panel1.TabIndex = 21;
            // 
            // Fr_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(559, 261);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fr_Venta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "■ VENTA";
            this.Load += new System.EventHandler(this.Form_Venta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox c_zona_venta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button venta_next;
        private System.Windows.Forms.ComboBox c_cliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox c_tipo_comprobante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}