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
    public partial class MantComprasNuevo : Form
    {

        CB_Producto obj_product = new CB_Producto();
        CB_Proveedor obj_prov = new CB_Proveedor();

        CE_Compra obj_c = new CE_Compra();
        CB_Compra obj_comp = new CB_Compra();

        CE_Detalle_Compra obj_dc = new CE_Detalle_Compra();
        CB_Detalle_Compra obj_detallecompra = new CB_Detalle_Compra();

        public MantComprasNuevo()
        {
            InitializeComponent();
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void MantComprasNuevo_Load(object sender, EventArgs e)
        {
            ToList_Proveedor();
            ToList_Product();

            c_proveedor.SelectedIndex = -1;
            c_producto.SelectedIndex = -1;
        }

        private void ToList_Proveedor()
        {
            c_proveedor.DataSource = obj_prov.SP_ToList_Columna_Proveedor_X();
            c_proveedor.DisplayMember = "Nombre";
            c_proveedor.ValueMember = "Id_Proveedor";
        }

        private void ToList_Product()
        {
            c_producto.DataSource = obj_product.SP_ToList_Column_Product_X();
            c_producto.DisplayMember = "Nombre";
            c_producto.ValueMember = "Id_Producto";
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (Detalle.CurrentRow != null)
            {
                Detalle.Rows.Remove(Detalle.CurrentRow);
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (!validarAgregar())
            {
                return;
            }
            Detalle.Rows.Add(
                c_producto.SelectedValue.ToString(),
                c_producto.Text,
                c_proveedor.SelectedValue.ToString(),
                c_proveedor.Text,
                dtp_fecha.Value.ToShortDateString(),
                t_marca.Text,
                t_talla.Text,
                t_cantidad.Text,
                t_precio.Text,
                t_total.Text
                );
            limpiar();
        }

        private bool validarAgregar()
        {
            if (c_producto.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar el producto", "Validación", MessageBoxButtons.OK);
                return false;
            }

            if (c_proveedor.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar el proveedor", "Validación", MessageBoxButtons.OK);
                return false;
            }

            if (t_marca.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la marca", "Validación", MessageBoxButtons.OK);
                return false;
            }

            if (t_talla.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la talla", "Validación", MessageBoxButtons.OK);
                return false;
            }

            if (t_cantidad.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la cantidad", "Validación", MessageBoxButtons.OK);
                return false;
            }

            if (t_precio.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio", "Validación", MessageBoxButtons.OK);
                return false;
            }

            if (t_total.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el total", "Validación", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void limpiar()
        {
            c_producto.SelectedIndex = -1;
            c_proveedor.SelectedIndex = -1;
            t_marca.Text = "";
            t_talla.Text = "";
            t_cantidad.Text = "";
            t_precio.Text = "";
            t_total.Text = "";
            dtp_fecha.Value = DateTime.Now;
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (!ValidarGuardado())
            {
                return;
            }

            obj_c.Tipo_Comprobante = c_tipo_comprobante.Text;

            int Id_Compra = int.Parse(obj_comp.SP_Create_Compra_DT(obj_c).Rows[0][0].ToString());

            for (int i = 0; i < Detalle.Rows.Count; i++)
            {
                obj_dc.Id_Product = Convert.ToInt32(Detalle.Rows[i].Cells[0].Value.ToString());
                obj_dc.Id_Proveedor = Convert.ToInt32(Detalle.Rows[i].Cells[2].Value.ToString());
                obj_dc.Fecha = Convert.ToDateTime(Detalle.Rows[i].Cells[4].Value.ToString());
                obj_dc.Marca = Detalle.Rows[i].Cells[5].Value.ToString();
                obj_dc.Talla = Detalle.Rows[i].Cells[6].Value.ToString();
                obj_dc.Cantidad = Convert.ToInt32(Detalle.Rows[i].Cells[7].Value.ToString());
                obj_dc.Total = Convert.ToDecimal(Detalle.Rows[i].Cells[9].Value.ToString());
                obj_dc.Id_Compra = Id_Compra;

                obj_detallecompra.SP_Registrar_Compra_X(obj_dc, "1");
            }
            string message = (". Codigo generado → " + Id_Compra.ToString());
            MessageBox.Show(message, "Message", MessageBoxButtons.OK);

            this.DialogResult = DialogResult.OK;
        }

        private bool ValidarGuardado()
        {
            if (c_tipo_comprobante.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar el tipo de comprobante", "Validación", MessageBoxButtons.OK);
                return false;
            }

            if (Detalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar el detalle", "Validación", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }
    }
}
