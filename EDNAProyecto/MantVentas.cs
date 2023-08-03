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
    public partial class MantVentas : Form
    {
        CB_Venta obj_v = new CB_Venta();
        CB_Detalle_Venta obj_venta = new CB_Detalle_Venta();

        public MantVentas()
        {
            InitializeComponent();
        }

        private void MantVentas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            Limpiar();

            data_venta.DataSource = obj_v.SP_ToList_Venta();
            data_venta.ClearSelection();
        }

        private void Limpiar()
        {
            data_venta.DataSource = null;
            detalle_venta.DataSource = null;
        }

        private void e_venta_Click(object sender, EventArgs e)
        {
            if (detalle_venta.CurrentRow == null)
            {
                return;
            }

            int Id_Venta = int.Parse(data_venta.Rows[data_venta.CurrentRow.Index].Cells["ID"].Value.ToString());

            if (MessageBox.Show("Esta seguro de eliminar los datos seleccionados..??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string message = obj_v.SP_Delete_Venta_DT(Id_Venta);
                MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                Listar();
            }
        }
        private void data_venta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            detalle_venta.DataSource = obj_venta.SP_ToList_Detalle_Venta_ID(int.Parse(data_venta.Rows[index].Cells["ID"].Value.ToString()));
        }

        private void r_venta_Click(object sender, EventArgs e)
        {
            using (MantVentasNuevo frm = new MantVentasNuevo())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Listar();
                }
            }
        }
    }
}
