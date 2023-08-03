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
    public partial class MantClientes : Form
    {
        CB_Cliente obj_client = new CB_Cliente();
        CE_Client obj_x = new CE_Client();
        public MantClientes()
        {
            InitializeComponent();
        }

        private void MantClientes_Load(object sender, EventArgs e)
        {
            data_clients.DataSource = obj_client.SP_Listar_Client_X();
        }

        private void Clear_All()
        {
            t_id.Text = "";
            t_nombre.Text = "";
            t_dni.Text = "";
            t_direccion.Text = "";
            t_telefono.Text = "";
            t_buscar.Text = "";
            t_nombre.Focus();

            data_clients.DataSource = obj_client.SP_Listar_Client_X();
        }

        private bool Check_Spaces()
        {
            return t_nombre.Text != "" && t_dni.Text != "" && t_direccion.Text != "" && t_telefono.Text != ""; 
        }

        private String X_Mantenimiento(string accion)
        {
            obj_x.Nombre = t_nombre.Text;
            obj_x.Dni = t_dni.Text;
            obj_x.Direccion = t_direccion.Text;
            obj_x.Telefono = t_telefono.Text;

            if (accion != "1")
            {
                obj_x.Id_Cliente = Convert.ToInt32(t_id.Text);
            }
            return obj_client.SP_Mantenimiento_Client_X(obj_x, accion);
        }

        private void data_clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (data_clients.Columns[e.ColumnIndex].Name == "EDIT")
            {
                t_id.Text = data_clients.Rows[index].Cells["ID"].Value.ToString();
                t_nombre.Text = data_clients.Rows[index].Cells["Nombre"].Value.ToString();
                t_dni.Text = data_clients.Rows[index].Cells["Numero_Dni"].Value.ToString();
                t_direccion.Text = data_clients.Rows[index].Cells["Direccion"].Value.ToString();
                t_telefono.Text = data_clients.Rows[index].Cells["Telefono"].Value.ToString();
            }
        }

        private void t_buscar_TextChanged(object sender, EventArgs e)
        {
            data_clients.DataSource = obj_client.SP_Search_Client_X(t_buscar.Text);
        }

        private void data_clients_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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
                message += (". Codigo generado → " + obj_client.SP_Listar_Client_X().Rows[0][0].ToString());
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
            if (obj_client.SP_Cliente_Verificar_Uso(int.Parse(t_id.Text)).Rows.Count > 0)
            {
                MessageBox.Show("El cliente no puede eliminarse, ya fue utilizado en una venta.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void r_cliente_MouseMove(object sender, MouseEventArgs e)
        {
            r_cliente.BackColor = Color.FromArgb(0, 62, 62);
        }

        private void r_cliente_MouseLeave(object sender, EventArgs e)
        {
            r_cliente.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void a_cliente_MouseMove(object sender, MouseEventArgs e)
        {
            a_cliente.BackColor = Color.FromArgb(55, 150, 150);
        }

        private void a_cliente_MouseLeave(object sender, EventArgs e)
        {
            a_cliente.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void e_cliente_MouseMove(object sender, MouseEventArgs e)
        {
            e_cliente.BackColor = Color.FromArgb(192, 0, 0);
        }

        private void e_cliente_MouseLeave(object sender, EventArgs e)
        {
            e_cliente.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            t_id.Text = "";
            t_dni.Text = "";
            t_telefono.Text = "";
            t_nombre.Text = "";
            t_direccion.Text = "";
        }
    }
}
