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
    public partial class MantProv : Form
    {
        CB_Proveedor obj_prov = new CB_Proveedor();
        CE_Proveedor obj_x = new CE_Proveedor();

        public MantProv()
        {
            InitializeComponent();
        }

        private void MantProv_Load(object sender, EventArgs e)
        {
            data_Proveedor.DataSource = obj_prov.SP_Listar_Proveedor_X();
        }

        private void Clear_All()
        {
            t_id.Text = "";
            t_name.Text = "";
            t_telefono.Text = "";
            c_distrito.Text = "";
            t_buscar.Text = "";
            t_name.Focus();

            data_Proveedor.DataSource = obj_prov.SP_Listar_Proveedor_X();
        }

        private bool Check_Spaces()
        {
            return t_name.Text != "" && t_telefono.Text != "" && c_distrito.Text != "";
        }

        private String X_Mantenimiento(string accion)
        {
            obj_x.Nombre = t_name.Text;
            obj_x.Telefono = t_telefono.Text;
            obj_x.Distrito = c_distrito.Text;

            if (accion != "1")
            {
                obj_x.Id_Proveedor = Convert.ToInt32(t_id.Text);
            }
            return obj_prov.SP_Mantenimiento_Proveedor_X(obj_x, accion);
        }

        private void data_Proveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (data_Proveedor.Columns[e.ColumnIndex].Name == "EDIT")
            {
                t_id.Text = data_Proveedor.Rows[index].Cells["ID Proveedor"].Value.ToString();
                t_name.Text = data_Proveedor.Rows[index].Cells["Nombre"].Value.ToString();
                t_telefono.Text = data_Proveedor.Rows[index].Cells["Telefono"].Value.ToString();
                c_distrito.Text = data_Proveedor.Rows[index].Cells["Distrito"].Value.ToString();
            }
        }

        private void t_buscar_TextChanged(object sender, EventArgs e)
        {
            data_Proveedor.DataSource = obj_prov.SP_Search_Proveedor_X(t_buscar.Text);
        }

        private void data_Proveedor_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                message += (". Codigo generado → " + obj_prov.SP_Listar_Proveedor_X().Rows[0][0].ToString());
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

                if (MessageBox.Show("Esta seguro de eliminar los datos seleccionados..??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //MessageBox.Show("No puede continuar. El ID Se encuentra relacionado..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (obj_prov.SP_Proveedor_Verificar_Uso(int.Parse(t_id.Text)).Rows.Count > 0)
            {
                MessageBox.Show("El proveedor no puede eliminarse, ya fue utilizado en una compra.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void r_proveedor_MouseMove(object sender, MouseEventArgs e)
        {
            r_proveedor.BackColor = Color.FromArgb(0, 62, 62);
        }

        private void r_proveedor_MouseLeave(object sender, EventArgs e)
        {
            r_proveedor.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void a_proveedor_MouseMove(object sender, MouseEventArgs e)
        {
            a_proveedor.BackColor = Color.FromArgb(55, 150, 150);
        }

        private void a_proveedor_MouseLeave(object sender, EventArgs e)
        {
            a_proveedor.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void e_proveedor_MouseMove(object sender, MouseEventArgs e)
        {
            e_proveedor.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void e_proveedor_MouseLeave(object sender, EventArgs e)
        {
            e_proveedor.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            t_id.Text = "";
            t_name.Text = "";
            t_telefono.Text = "";
            c_distrito.Text = "";
        }
    }
}
