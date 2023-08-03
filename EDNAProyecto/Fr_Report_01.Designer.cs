
namespace EDNAProyecto
{
    partial class Fr_Report_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fr_Report_01));
            this.label4 = new System.Windows.Forms.Label();
            this.c_zona = new System.Windows.Forms.ComboBox();
            this.c_cant_v = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_venta_x_zona = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer_CantV = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.data_venta_x_zona)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "▀ ZONA";
            // 
            // c_zona
            // 
            this.c_zona.BackColor = System.Drawing.Color.Black;
            this.c_zona.ForeColor = System.Drawing.Color.White;
            this.c_zona.FormattingEnabled = true;
            this.c_zona.Items.AddRange(new object[] {
            "Miraflores",
            "San Isidro",
            "San Miguel",
            "Surco",
            "La molina"});
            this.c_zona.Location = new System.Drawing.Point(97, 31);
            this.c_zona.Name = "c_zona";
            this.c_zona.Size = new System.Drawing.Size(121, 21);
            this.c_zona.TabIndex = 6;
            this.c_zona.MouseLeave += new System.EventHandler(this.c_zona_MouseLeave);
            this.c_zona.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c_zona_MouseMove);
            // 
            // c_cant_v
            // 
            this.c_cant_v.BackColor = System.Drawing.Color.Black;
            this.c_cant_v.ForeColor = System.Drawing.Color.White;
            this.c_cant_v.Location = new System.Drawing.Point(715, 31);
            this.c_cant_v.Name = "c_cant_v";
            this.c_cant_v.ReadOnly = true;
            this.c_cant_v.Size = new System.Drawing.Size(176, 20);
            this.c_cant_v.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(260, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "▀ BUSCAR";
            // 
            // data_venta_x_zona
            // 
            this.data_venta_x_zona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_venta_x_zona.Location = new System.Drawing.Point(16, 89);
            this.data_venta_x_zona.Name = "data_venta_x_zona";
            this.data_venta_x_zona.Size = new System.Drawing.Size(927, 333);
            this.data_venta_x_zona.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.data_venta_x_zona);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 437);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.b_search);
            this.groupBox2.Controls.Add(this.c_zona);
            this.groupBox2.Controls.Add(this.c_cant_v);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(927, 64);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "▀ VENTAS";
            // 
            // b_search
            // 
            this.b_search.BackColor = System.Drawing.Color.White;
            this.b_search.BackgroundImage = global::EDNAProyecto.Properties.Resources.search;
            this.b_search.ForeColor = System.Drawing.Color.White;
            this.b_search.Location = new System.Drawing.Point(344, 24);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(33, 33);
            this.b_search.TabIndex = 12;
            this.b_search.UseVisualStyleBackColor = false;
            this.b_search.Click += new System.EventHandler(this.button1_Click);
            this.b_search.MouseLeave += new System.EventHandler(this.b_search_MouseLeave);
            this.b_search.MouseMove += new System.Windows.Forms.MouseEventHandler(this.b_search_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 461);
            this.panel1.TabIndex = 11;
            // 
            // timer_CantV
            // 
            this.timer_CantV.Enabled = true;
            this.timer_CantV.Tick += new System.EventHandler(this.timer_CantV_Tick);
            // 
            // Fr_Report_01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fr_Report_01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "■ CANTIDAD DE VENTAS ─ ZONA";
            this.Load += new System.EventHandler(this.Fr_Report01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_venta_x_zona)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox c_zona;
        private System.Windows.Forms.TextBox c_cant_v;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_venta_x_zona;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_CantV;
    }
}