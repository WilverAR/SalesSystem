using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Business;
using Capa_Entity;

namespace EDNAProyecto
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MantProv fr = new MantProv();
            fr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MantProd fr = new MantProd();
            fr.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MantClientes fr = new MantClientes();
            fr.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CB_Cliente check_c = new CB_Cliente();
            CB_Producto check_p = new CB_Producto();
            if (check_c.SP_Listar_Client_X().Rows.Count > 0 && check_p.SP_Listar_Product_X().Rows.Count > 0)
            {
                MantVentas fr = new MantVentas();
                fr.ShowDialog();
            }
            if (check_c.SP_Listar_Client_X().Rows.Count <= 0)
            {
                MessageBox.Show("No puede continuar. No existe ningun cliente..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (check_p.SP_Listar_Product_X().Rows.Count <= 0)
            {
                MessageBox.Show("No puede continuar. No existe ningun producto..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }   

        private void button5_Click(object sender, EventArgs e)
        {
            CB_Proveedor check_prov = new CB_Proveedor();
            CB_Producto check_prod = new CB_Producto();
            if (check_prov.SP_Listar_Proveedor_X().Rows.Count > 0 && check_prod.SP_Listar_Product_X().Rows.Count > 0) 
            {
                MantCompras fr = new MantCompras();
                fr.ShowDialog();
            }
            if(check_prov.SP_Listar_Proveedor_X().Rows.Count <= 0)
            {
                MessageBox.Show("No puede continuar. No existe ningun proveedor..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(check_prod.SP_Listar_Product_X().Rows.Count <= 0)
            {
                MessageBox.Show("No puede continuar. No existe ningun producto..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void b_proveedor_MouseLeave(object sender, EventArgs e)
        {
            b_proveedor.BackColor = Color.Gray;
        }

        private void b_proveedor_MouseMove(object sender, MouseEventArgs e)
        {
            b_proveedor.BackColor = Color.Olive;
        }

        private void b_productos_MouseMove(object sender, MouseEventArgs e)
        {
            b_productos.BackColor = Color.Olive;
        }

        private void b_productos_MouseLeave(object sender, EventArgs e)
        {
            b_productos.BackColor = Color.Gray;
        }

        private void b_clientes_MouseMove(object sender, MouseEventArgs e)
        {
            b_clientes.BackColor = Color.Olive;
        }

        private void b_clientes_MouseLeave(object sender, EventArgs e)
        {
            b_clientes.BackColor = Color.Gray;
        }

        private void b_venta_MouseMove(object sender, MouseEventArgs e)
        {
            b_venta.BackColor = Color.Olive;
        }

        private void b_venta_MouseLeave(object sender, EventArgs e)
        {
            b_venta.BackColor = Color.Gray;
        }

        private void b_compra_MouseMove(object sender, MouseEventArgs e)
        {
            b_compra.BackColor = Color.Olive;
        }

        private void b_compra_MouseLeave(object sender, EventArgs e)
        {
            b_compra.BackColor = Color.Gray;
        }

        private void report1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_Report_01 fr = new Fr_Report_01();
            fr.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void report_two_Click(object sender, EventArgs e)
        {
            Fr_Report_02 fr = new Fr_Report_02();
            fr.ShowDialog();
        }

        private void report3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fr_Report_03 fr = new Fr_Report_03();
            fr.ShowDialog();
        }
    }
}
