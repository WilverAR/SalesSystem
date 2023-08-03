namespace EDNAProyecto
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.b_proveedor = new System.Windows.Forms.Button();
            this.b_clientes = new System.Windows.Forms.Button();
            this.b_venta = new System.Windows.Forms.Button();
            this.b_productos = new System.Windows.Forms.Button();
            this.b_compra = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEPORTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.report_two = new System.Windows.Forms.ToolStripMenuItem();
            this.report3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_proveedor
            // 
            this.b_proveedor.BackColor = System.Drawing.Color.Gray;
            this.b_proveedor.Location = new System.Drawing.Point(106, 118);
            this.b_proveedor.Name = "b_proveedor";
            this.b_proveedor.Size = new System.Drawing.Size(221, 68);
            this.b_proveedor.TabIndex = 1;
            this.b_proveedor.Text = "─ PROVEEDORES ─";
            this.b_proveedor.UseVisualStyleBackColor = false;
            this.b_proveedor.Click += new System.EventHandler(this.button1_Click);
            this.b_proveedor.MouseLeave += new System.EventHandler(this.b_proveedor_MouseLeave);
            this.b_proveedor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_proveedor_MouseMove);
            // 
            // b_clientes
            // 
            this.b_clientes.BackColor = System.Drawing.Color.Gray;
            this.b_clientes.Location = new System.Drawing.Point(254, 233);
            this.b_clientes.Name = "b_clientes";
            this.b_clientes.Size = new System.Drawing.Size(221, 68);
            this.b_clientes.TabIndex = 2;
            this.b_clientes.Text = "─ CLIENTES ─";
            this.b_clientes.UseVisualStyleBackColor = false;
            this.b_clientes.Click += new System.EventHandler(this.button2_Click);
            this.b_clientes.MouseLeave += new System.EventHandler(this.b_clientes_MouseLeave);
            this.b_clientes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_clientes_MouseMove);
            // 
            // b_venta
            // 
            this.b_venta.BackColor = System.Drawing.Color.Gray;
            this.b_venta.Location = new System.Drawing.Point(106, 352);
            this.b_venta.Name = "b_venta";
            this.b_venta.Size = new System.Drawing.Size(221, 68);
            this.b_venta.TabIndex = 4;
            this.b_venta.Text = "─ VENTA ─";
            this.b_venta.UseVisualStyleBackColor = false;
            this.b_venta.Click += new System.EventHandler(this.button3_Click);
            this.b_venta.MouseLeave += new System.EventHandler(this.b_venta_MouseLeave);
            this.b_venta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_venta_MouseMove);
            // 
            // b_productos
            // 
            this.b_productos.BackColor = System.Drawing.Color.Gray;
            this.b_productos.Location = new System.Drawing.Point(410, 118);
            this.b_productos.Name = "b_productos";
            this.b_productos.Size = new System.Drawing.Size(221, 68);
            this.b_productos.TabIndex = 3;
            this.b_productos.Text = "─ PRODUCTOS ─";
            this.b_productos.UseVisualStyleBackColor = false;
            this.b_productos.Click += new System.EventHandler(this.button4_Click);
            this.b_productos.MouseLeave += new System.EventHandler(this.b_productos_MouseLeave);
            this.b_productos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_productos_MouseMove);
            // 
            // b_compra
            // 
            this.b_compra.BackColor = System.Drawing.Color.Gray;
            this.b_compra.Location = new System.Drawing.Point(410, 352);
            this.b_compra.Name = "b_compra";
            this.b_compra.Size = new System.Drawing.Size(221, 68);
            this.b_compra.TabIndex = 5;
            this.b_compra.Text = "─ COMPRA ─";
            this.b_compra.UseVisualStyleBackColor = false;
            this.b_compra.Click += new System.EventHandler(this.button5_Click);
            this.b_compra.MouseLeave += new System.EventHandler(this.b_compra_MouseLeave);
            this.b_compra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_compra_MouseMove);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEPORTESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(734, 57);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEPORTESToolStripMenuItem
            // 
            this.rEPORTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.report1ToolStripMenuItem,
            this.report_two,
            this.report3ToolStripMenuItem});
            this.rEPORTESToolStripMenuItem.Image = global::EDNAProyecto.Properties.Resources.report;
            this.rEPORTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rEPORTESToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rEPORTESToolStripMenuItem.Name = "rEPORTESToolStripMenuItem";
            this.rEPORTESToolStripMenuItem.Size = new System.Drawing.Size(142, 53);
            this.rEPORTESToolStripMenuItem.Text = "■ REPORTES";
            // 
            // report1ToolStripMenuItem
            // 
            this.report1ToolStripMenuItem.Name = "report1ToolStripMenuItem";
            this.report1ToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.report1ToolStripMenuItem.Text = "▀ Cantidad de Ventas ─ Zona.";
            this.report1ToolStripMenuItem.Click += new System.EventHandler(this.report1ToolStripMenuItem_Click);
            // 
            // report_two
            // 
            this.report_two.Name = "report_two";
            this.report_two.Size = new System.Drawing.Size(274, 22);
            this.report_two.Text = "▀ Lista de ropas ─  Categoria - Stock.";
            this.report_two.Click += new System.EventHandler(this.report_two_Click);
            // 
            // report3ToolStripMenuItem
            // 
            this.report3ToolStripMenuItem.Name = "report3ToolStripMenuItem";
            this.report3ToolStripMenuItem.Size = new System.Drawing.Size(274, 22);
            this.report3ToolStripMenuItem.Text = "▀ Producto mas vendido ─ Categoria.";
            this.report3ToolStripMenuItem.Click += new System.EventHandler(this.report3ToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.b_compra);
            this.Controls.Add(this.b_venta);
            this.Controls.Add(this.b_productos);
            this.Controls.Add(this.b_clientes);
            this.Controls.Add(this.b_proveedor);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "■ MENU PRINCIPAL";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button b_proveedor;
        private System.Windows.Forms.Button b_clientes;
        private System.Windows.Forms.Button b_venta;
        private System.Windows.Forms.Button b_productos;
        private System.Windows.Forms.Button b_compra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEPORTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem report_two;
        private System.Windows.Forms.ToolStripMenuItem report3ToolStripMenuItem;
    }
}