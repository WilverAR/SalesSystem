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
    public partial class _MantVentas : Form
    {
        CB_Producto obj_product = new CB_Producto();
        CB_Detalle_Venta obj_venta = new CB_Detalle_Venta();
        CE_Detalle_Venta obj_x = new CE_Detalle_Venta();
        CB_Venta obj_v = new CB_Venta();
        CE_Variables var_x = new CE_Variables();

        public _MantVentas()
        {
            InitializeComponent();
        }

        private void MantVentas_Load(object sender, EventArgs e)
        {
            ToList_Product();
            ToList_ID();
            data_venta.DataSource = obj_venta.SP_ToList_Venta_X();
        }

        private void ToList_Product()
        {
            c_producto.DataSource = obj_product.SP_ToList_Column_Product_X();
            c_producto.DisplayMember = "Nombre";
            c_producto.ValueMember = "Id_Producto";
        }

        private void ToList_ID()
        {
            c_id_venta.DataSource = obj_v.SP_ToList_Columna_Venta_X();
            c_id_venta.DisplayMember = "Id_Venta";
            c_id_venta.ValueMember = "Id_Venta";
        }

        private void Clear_All()
        {
            c_id_venta.Text = "";
            t_precio.Text = "";
            t_cantidad.Text = "";
            t_total.Text = "";
            dtp_fecha.Text = "";
            t_buscar.Focus();

            data_venta.DataSource = obj_venta.SP_ToList_Venta_X();
        }

        private bool Check_Spaces()
        {
            return t_total.Text != "" && t_precio.Text != "" && t_cantidad.Text != "" && c_producto.Text != "";
        }

        private String X_Mantenimiento(string accion)
        {
            obj_x.Id_Producto = Convert.ToInt32(c_producto.SelectedValue);
            obj_x.Precio = Convert.ToDecimal(t_precio.Text);
            obj_x.Cantidad = Convert.ToInt32(t_cantidad.Text);
            obj_x.Total = Convert.ToDecimal(t_total.Text);
            obj_x.Fecha = dtp_fecha.Value;
            obj_x.Id_Venta = Convert.ToInt32(c_id_venta.SelectedValue);

            if (accion != "1")
            {
                obj_x.Id_Venta = Convert.ToInt32(c_id_venta.Text);
            }
            return obj_venta.SP_Mantenimiento_Venta_X(obj_x, accion);
        }
        
        private void data_venta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (data_venta.Columns[e.ColumnIndex].Name == "EDIT")
            {
                t_cantidad.Text = data_venta.Rows[index].Cells["Cantidad"].Value.ToString();
                t_total.Text = data_venta.Rows[index].Cells["Total"].Value.ToString();
                dtp_fecha.Text = data_venta.Rows[index].Cells["Fecha"].Value.ToString();
                enter = true;
            }
        }

        private void data_venta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void t_cantidad_TextChanged(object sender, EventArgs e)
        {
            if (!t_cantidad.Text.All(char.IsDigit))
            {
                t_cantidad.Text = "";
            }
            else
            {
                t_precio.ReadOnly = false;
                if (t_cantidad.Text == "")
                {
                    t_precio.ReadOnly = true;
                }
            }
        }

        private void t_precio_TextChanged_1(object sender, EventArgs e)
        {
            if (!t_precio.Text.All(char.IsDigit))
            {
                t_precio.Text = "";
            }
            else
            {
                if (t_precio.ReadOnly == false && t_precio.Text != "") 
                {
                    t_total.Text = Convert.ToString(Convert.ToInt32(t_cantidad.Text) * Convert.ToInt32(t_precio.Text));
                }
            }
        }
        bool enter = false;
        private void button1_Click(object sender, EventArgs e)
        {
            CB_Update_Stock update = new CB_Update_Stock();
            if (Check_Spaces())
            {
                string message = X_Mantenimiento("1");
                message += (". Codigo generado → " + obj_venta.SP_ToList_Venta_X().Rows[0][0].ToString());
                MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                update.SP_Update_S_X(c_producto.Text, Convert.ToInt32(t_cantidad.Text));
                Clear_All();
            }
            else
            {
                MessageBox.Show("No se puede continuar. Faltan celdas por rellenar..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Check_Spaces())
            {
                if (MessageBox.Show("Esta seguro de eliminar los datos seleccionados..??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("No puede continuar. El ID Se encuentra relacionado..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_All();
                }
            }
            else
            {
                MessageBox.Show("No puede continuar. Faltan datos por seleccionar..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void r_venta_MouseMove(object sender, MouseEventArgs e)
        {
            r_venta.BackColor = Color.FromArgb(0, 62, 62); r_venta.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void r_venta_MouseLeave(object sender, EventArgs e)
        {
            r_venta.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void e_venta_MouseMove(object sender, MouseEventArgs e)
        {
            e_venta.BackColor= Color.FromArgb(192, 0, 0); e_venta.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void e_venta_MouseLeave(object sender, EventArgs e)
        {
            e_venta.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void timerVentaP_Tick(object sender, EventArgs e)
        {
            if (enter)
            {
                var_x.cant = Convert.ToInt32(t_cantidad.Text);
                var_x.total = Convert.ToDecimal(t_total.Text);
                var_x.result = var_x.total / var_x.cant;
                t_precio.Text = t_cantidad.Text;
                enter = false;
            }
        }
    }
}
