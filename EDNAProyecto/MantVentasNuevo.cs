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
    public partial class MantVentasNuevo : Form
    {
        CB_Cliente obj_client = new CB_Cliente();
        CB_Producto obj_product = new CB_Producto();

        CE_Venta obj_v = new CE_Venta();
        CB_Venta obj_vent = new CB_Venta();

        CE_Detalle_Venta obj_dv = new CE_Detalle_Venta();
        CB_Detalle_Venta obj_detalleventa = new CB_Detalle_Venta();

        public MantVentasNuevo()
        {
            InitializeComponent();
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

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
                dtp_fecha.Value.ToShortDateString(),
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
            t_cantidad.Text = "";
            t_precio.Text = "";
            t_total.Text = "";
            dtp_fecha.Value = DateTime.Now;
        }

        private void MantVentasNuevo_Load(object sender, EventArgs e)
        {
            ToList_Product();
            ToList_Client();

            c_cliente.SelectedIndex = -1;
            c_producto.SelectedIndex = -1;
        }

        private void ToList_Client()
        {
            c_cliente.DataSource = obj_client.SP_ToList_Columna_Client_X();
            c_cliente.DisplayMember = "Nombre";
            c_cliente.ValueMember = "Id_Cliente";
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

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (!ValidarGuardado())
            {
                return;
            }

            obj_v.Id_Cliente = Convert.ToInt32(c_cliente.SelectedValue);
            obj_v.Tipo_Comprobante = c_tipo_comprobante.Text;
            obj_v.Zona_Venta = c_zona_venta.Text;

            int Id_Venta = int.Parse(obj_vent.SP_Crear_Venta_DT(obj_v).Rows[0][0].ToString());

            for (int i = 0; i < Detalle.Rows.Count; i++)
            {
                obj_dv.Id_Producto = Convert.ToInt32(Detalle.Rows[i].Cells[0].Value.ToString());
                obj_dv.Fecha = Convert.ToDateTime(Detalle.Rows[i].Cells[2].Value.ToString());
                obj_dv.Cantidad = Convert.ToInt32(Detalle.Rows[i].Cells[3].Value.ToString());
                obj_dv.Precio = Convert.ToDecimal(Detalle.Rows[i].Cells[4].Value.ToString());
                obj_dv.Total = Convert.ToDecimal(Detalle.Rows[i].Cells[5].Value.ToString());
                obj_dv.Id_Venta = Id_Venta;

                obj_detalleventa.SP_Mantenimiento_Venta_X(obj_dv, "1");

                CB_Update_Stock update = new CB_Update_Stock();
                update.SP_Update_S_X(Detalle.Rows[i].Cells[1].Value.ToString(), obj_dv.Cantidad);
            }

            string message = (". Codigo generado → " + Id_Venta.ToString());
            MessageBox.Show(message, "Message", MessageBoxButtons.OK);

            this.DialogResult = DialogResult.OK;
        }

        private bool ValidarGuardado()
        {
            if (c_cliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar el cliente", "Validación", MessageBoxButtons.OK);
                return false;
            }

            if (c_tipo_comprobante.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar el tipo de comprobante", "Validación", MessageBoxButtons.OK);
                return false;
            }

            if (c_zona_venta.Text.Trim() == "")
            {
                MessageBox.Show("Debe seleccionar la zona", "Validación", MessageBoxButtons.OK);
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
