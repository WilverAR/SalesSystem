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
    public partial class _MantCompras : Form
    {
        CB_Proveedor obj_prov = new CB_Proveedor();
        CB_Detalle_Compra obj_buy = new CB_Detalle_Compra();
        CE_Detalle_Compra obj_x = new CE_Detalle_Compra();
        CB_Producto obj_product = new CB_Producto();
        CE_Variables var_x = new CE_Variables();

        public _MantCompras()
        {
            InitializeComponent();
        }

        private void MantCompras_Load(object sender, EventArgs e)
        {
            ToList_Proveedor();
            ToList_Compra();
            data_compra.DataSource = obj_buy.SP_ToList_Compra_X();
        }

        private void ToList_Proveedor()
        {
            c_proveedor.DataSource = obj_prov.SP_ToList_Columna_Proveedor_X();
            c_proveedor.DisplayMember = "Nombre";
            c_proveedor.ValueMember = "Id_Proveedor";
        }

        private void ToList_Compra()
        {
            c_id_comp.DataSource = obj_buy.SP_ToList_Columna_Compra_X();
            c_id_comp.DisplayMember = "Num_Comp";
            c_id_comp.ValueMember = "Id_Compra";
        }

        private void Clear_All()
        {
            t_cantidad.Text = "";
            c_proveedor.Text = "";
            t_marca.Text = "";
            t_talla.Text = "";
            t_precio.Text = "";
            t_total.Text = "";
            dtp_fecha.Text = "";
            t_buscar.Focus();

            data_compra.DataSource = obj_buy.SP_ToList_Compra_X();
        }

        private bool Check_Spaces()
        {
            return t_cantidad.Text != "" && c_proveedor.Text != "" && t_marca.Text != "" && t_talla.Text != "" && t_total.Text != "" && t_precio.Text != "";
        }

        private String X_Mantenimiento(string accion)
        {
            obj_x.Id_Proveedor = Convert.ToInt32(c_proveedor.SelectedValue);
            obj_x.Id_Compra = Convert.ToInt32(c_id_comp.SelectedValue);
            obj_x.Cantidad = Convert.ToInt32(t_cantidad.Text);
            obj_x.Marca = t_marca.Text;
            obj_x.Talla = t_talla.Text;
            obj_x.Total = Convert.ToDecimal(t_total.Text);
            obj_x.Fecha = dtp_fecha.Value;
            obj_x.Id_Product = Convert.ToInt32(obj_product.SP_Listar_Product_X().Rows[0][0].ToString());

            return obj_buy.SP_Registrar_Compra_X(obj_x, accion);
        }

        private void data_compra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (data_compra.Columns[e.ColumnIndex].Name == "EDIT")
            {
                c_proveedor.Text = data_compra.Rows[index].Cells["Proveedor"].Value.ToString();
                t_cantidad.Text = data_compra.Rows[index].Cells["Cantidad"].Value.ToString();
                t_marca.Text = data_compra.Rows[index].Cells["Marca"].Value.ToString();
                t_talla.Text = data_compra.Rows[index].Cells["Talla"].Value.ToString();
                t_total.Text = data_compra.Rows[index].Cells["Total"].Value.ToString();
                dtp_fecha.Text = data_compra.Rows[index].Cells["Fecha"].Value.ToString();
                enter = true;
            }
        }

        private void data_compra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void t_precio_TextChanged(object sender, EventArgs e)
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
        private void r_compra_Click(object sender, EventArgs e)
        {
            if (Check_Spaces())
            {
                string message = X_Mantenimiento("1");
                message += (". Codigo generado → " + obj_buy.SP_ToList_Compra_X().Rows[0][0].ToString());
                MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                Clear_All();
            }
            else
            {
                MessageBox.Show("No se puede continuar. Faltan celdas por rellenar..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void e_compra_Click(object sender, EventArgs e)
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

        private void r_compra_MouseMove(object sender, MouseEventArgs e)
        {
            r_compra.BackColor = Color.FromArgb(0, 62, 62);
        }

        private void r_compra_MouseLeave(object sender, EventArgs e)
        {
            r_compra.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void e_compra_MouseMove(object sender, MouseEventArgs e)
        {
            e_compra.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void e_compra_MouseLeave(object sender, EventArgs e)
        {
            e_compra.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void Timer_Check_Tick(object sender, EventArgs e)
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
