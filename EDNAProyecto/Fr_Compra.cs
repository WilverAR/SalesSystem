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
    public partial class Fr_Compra : Form
    {
        CB_Producto obj_product = new CB_Producto();
        CE_Compra obj_x = new CE_Compra();
        CB_Compra obj_buy = new CB_Compra();

        public Fr_Compra()
        {
            InitializeComponent();
        }

        private void Fr_Compra_Load(object sender, EventArgs e)
        {
            ToList_Product();
        }

        private void ToList_Product()
        {
            c_producto.DataSource = obj_product.SP_ToList_Column_Product_X();
            c_producto.DisplayMember = "Nombre";
            c_producto.ValueMember = "Id_Producto";
        }

        private bool Check_Spaces()
        {
            return c_producto.Text != "" && c_tipo_comprobante.Text != "";
        }

        private bool Check_Product()
        {
            return c_producto.Items.Count > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Check_Product())
            {
                MessageBox.Show("No puede continuar. No hay ningun producto registrado..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!Check_Spaces())
            {
                MessageBox.Show("No puede continuar. Faltan datos por seleccionar..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Check_Spaces() && Check_Product())
            {
                obj_x.Tipo_Comprobante = c_tipo_comprobante.Text;
                obj_buy.SP_Crear_Compra_X(obj_x);
                //this.Hide();
                _MantCompras fr = new _MantCompras();
                fr.ShowDialog();
            }
        }

        private void compra_next_MouseMove(object sender, MouseEventArgs e)
        {
            compra_next.BackColor = Color.FromArgb(0, 62, 62);
        }

        private void compra_next_MouseLeave(object sender, EventArgs e)
        {
            compra_next.BackColor = Color.FromArgb(0, 0, 0);
        }
    }
}
