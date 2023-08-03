
namespace EDNAProyecto
{
    partial class Fr_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Compra));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.c_producto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.compra_next = new System.Windows.Forms.Button();
            this.c_tipo_comprobante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c_producto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.compra_next);
            this.groupBox1.Controls.Add(this.c_tipo_comprobante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(537, 239);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "▀ DATOS DE COMPRA";
            // 
            // c_producto
            // 
            this.c_producto.FormattingEnabled = true;
            this.c_producto.Location = new System.Drawing.Point(170, 57);
            this.c_producto.Name = "c_producto";
            this.c_producto.Size = new System.Drawing.Size(138, 21);
            this.c_producto.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "■ Producto";
            // 
            // compra_next
            // 
            this.compra_next.BackColor = System.Drawing.Color.Black;
            this.compra_next.ForeColor = System.Drawing.Color.White;
            this.compra_next.Location = new System.Drawing.Point(385, 89);
            this.compra_next.Name = "compra_next";
            this.compra_next.Size = new System.Drawing.Size(130, 70);
            this.compra_next.TabIndex = 18;
            this.compra_next.Text = "─ NEXT ─";
            this.compra_next.UseVisualStyleBackColor = false;
            this.compra_next.Click += new System.EventHandler(this.button1_Click);
            this.compra_next.MouseLeave += new System.EventHandler(this.compra_next_MouseLeave);
            this.compra_next.MouseMove += new System.Windows.Forms.MouseEventHandler(this.compra_next_MouseMove);
            // 
            // c_tipo_comprobante
            // 
            this.c_tipo_comprobante.FormattingEnabled = true;
            this.c_tipo_comprobante.Items.AddRange(new object[] {
            "Boleta",
            "Factura"});
            this.c_tipo_comprobante.Location = new System.Drawing.Point(170, 165);
            this.c_tipo_comprobante.Name = "c_tipo_comprobante";
            this.c_tipo_comprobante.Size = new System.Drawing.Size(138, 21);
            this.c_tipo_comprobante.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "■ Comprobante";
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
            this.panel1.TabIndex = 22;
            // 
            // Fr_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 261);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fr_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "■ COMPRA";
            this.Load += new System.EventHandler(this.Fr_Compra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button compra_next;
        private System.Windows.Forms.ComboBox c_tipo_comprobante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox c_producto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}