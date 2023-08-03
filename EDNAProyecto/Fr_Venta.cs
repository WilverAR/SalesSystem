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
    public partial class Fr_Venta : Form
    {
        CB_Cliente obj_client = new CB_Cliente();
        CE_Venta obj_x = new CE_Venta();
        CB_Venta obj_vent = new CB_Venta();

        public Fr_Venta()
        {
            InitializeComponent();
        }

        private bool Check_Spaces()
        {
            return c_cliente.Text != "" && c_tipo_comprobante.Text != "" && c_zona_venta.Text != "";
        }

        private bool Check_Client()
        {
            return c_cliente.Items.Count > 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Check_Client())
            {
                MessageBox.Show("No puede continuar. No hay ningun cliente registrado..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (!Check_Spaces())
            {
                MessageBox.Show("No puede continuar. Faltan datos por seleccionar..!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Check_Spaces() && Check_Client())
            {
                obj_x.Id_Cliente = Convert.ToInt32(c_cliente.SelectedValue);
                obj_x.Tipo_Comprobante = c_tipo_comprobante.Text;
                obj_x.Zona_Venta = c_zona_venta.Text;
                obj_vent.SP_Create_Venta_X(obj_x);
                _MantVentas fr = new _MantVentas();
                fr.ShowDialog();
            }
        }

        private void Form_Venta_Load(object sender, EventArgs e)
        {
            ToList_Client();
        }

        private void ToList_Client()
        {
            c_cliente.DataSource = obj_client.SP_ToList_Columna_Client_X();
            c_cliente.DisplayMember = "Nombre";
            c_cliente.ValueMember = "Id_Cliente";
        }

        private void venta_next_MouseMove(object sender, MouseEventArgs e)
        {
            venta_next.BackColor = Color.FromArgb(0, 62, 62);
        }

        private void venta_next_MouseLeave(object sender, EventArgs e)
        {
            venta_next.BackColor = Color.FromArgb(0, 0, 0);
        }
    }
}
