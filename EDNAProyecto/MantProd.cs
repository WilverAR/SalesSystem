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
    public partial class MantProd : Form
    {
        CB_Producto obj_product = new CB_Producto();
        CE_Product obj_x = new CE_Product();
        public MantProd()
        {
            InitializeComponent();
        }

        private void MantProd_Load(object sender, EventArgs e)
        {
            data_product.DataSource = obj_product.SP_Listar_Product_X();
        }

        private void Clear_All()
        {
            t_id.Text = "";
            t_nombre.Text = "";
            t_stock_inicial.Text = "";
            c_categoria.Text = "";
            t_code.Text = "";
            t_nombre.Focus();

            data_product.DataSource = obj_product.SP_Listar_Product_X();
        }

        private bool Check_Spaces()
        {
            return t_nombre.Text != "" && t_stock_inicial.Text != "" && c_categoria.Text != "";
        }

        private String X_Mantenimiento(string accion)
        {
            obj_x.Nombre = t_nombre.Text;
            obj_x.Stock_Inicial = Convert.ToInt32(t_stock_inicial.Text);
            obj_x.Stock_Actual = Convert.ToInt32(t_stock_inicial.Text);
            obj_x.Categoria = c_categoria.Text;
            obj_x.Codigo = Convert.ToInt32(t_code.Text);

            if (accion != "1")
            {
                obj_x.Id_Producto = Convert.ToInt32(t_id.Text);
            }
            return obj_product.SP_Mantenimiento_Product_X(obj_x, accion);
        }

        private void data_product_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (data_product.Columns[e.ColumnIndex].Name == "EDIT")
            {
                t_id.Text = data_product.Rows[index].Cells["ID"].Value.ToString();
                t_nombre.Text = data_product.Rows[index].Cells["Nombre"].Value.ToString();
                t_stock_inicial.Text = data_product.Rows[index].Cells["Stock"].Value.ToString();
                t_stock_actual.Text = data_product.Rows[index].Cells["Stock"].Value.ToString();
                c_categoria.Text = data_product.Rows[index].Cells["Categoria"].Value.ToString();
                t_code.Text = data_product.Rows[index].Cells["Codigo"].Value.ToString();
            }
        }

        private void t_stock_inicial_TextChanged(object sender, EventArgs e)
        {
            if (!t_stock_inicial.Text.All(char.IsDigit))
            {
                t_stock_inicial.Text = "";
            }
            else
            {
                t_stock_actual.Text = t_stock_inicial.Text;
            }
        }

        private void t_buscar_TextChanged(object sender, EventArgs e)
        {
            data_product.DataSource = obj_product.SP_Search_Products_X(t_buscar.Text);
        }

        private void data_product_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {

                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.check20.Width;
                var h = Properties.Resources.check20.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.check20, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_id.Text != "")
            {
                return;
            }

            if (Check_Spaces())
            {
                string message = X_Mantenimiento("1");
                message += (". Codigo generado → " + obj_product.SP_Listar_Product_X().Rows[0][0].ToString());
                MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                Clear_All();
            }
            else
            {
                MessageBox.Show("No se puede continuar. Faltan celdas por rellenar..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (t_id.Text == "")
            {
                return;
            }
            if (Check_Spaces())
            {
                string message = X_Mantenimiento("2");
                MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                Clear_All();
            }
            else
            {
                MessageBox.Show("No se puede continuar. Faltan celdas por rellenar..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Check_Spaces())
            {
                if (!validarUso())
                {
                    return;
                }

                if (MessageBox.Show("Esta seguro de eliminar los datos seleccionados..??", "ADEVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string message = X_Mantenimiento("3");
                    MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                    Clear_All();
                }
            }
            else
            {
                MessageBox.Show("No puede continuar. Faltan datos por seleccionar..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarUso()
        {
            if (obj_product.SP_Producto_Verificar_Uso(int.Parse(t_id.Text)).Rows.Count > 0)
            {
                MessageBox.Show("El producto no puede eliminarse, ya fue utilizado en un movimiento.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            r_producto.BackColor = Color.FromArgb(0, 62, 62);
        }

        private void r_producto_MouseLeave(object sender, EventArgs e)
        {
            r_producto.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void a_producto_MouseMove(object sender, MouseEventArgs e)
        {
            a_producto.BackColor = Color.FromArgb(55, 150, 150);
        }

        private void a_producto_MouseLeave(object sender, EventArgs e)
        {
            a_producto.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void e_producto_MouseMove(object sender, MouseEventArgs e)
        {
            e_producto.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void e_producto_MouseLeave(object sender, EventArgs e)
        {
            e_producto.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            t_id.Text = "";
            t_nombre.Text = "";
            t_stock_inicial.Text = "";
            t_stock_actual.Text = "0";
            t_code.Text = "";
            c_categoria.Text = "";
        }
    }
}
