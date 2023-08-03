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
    public partial class MantCompras : Form
    {
        CB_Compra obj_c = new CB_Compra();
        CB_Detalle_Compra obj_compra = new CB_Detalle_Compra();

        public MantCompras()
        {
            InitializeComponent();
        }

        private void MantCompras_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            Limpiar();

            data_compra.DataSource = obj_c.SP_ToList_Compra_N();
            data_compra.ClearSelection();
        }

        private void Limpiar()
        {
            data_compra.DataSource = null;
            detalle_compra.DataSource = null;
        }

        private void e_venta_Click(object sender, EventArgs e)
        {
            if (detalle_compra.CurrentRow == null)
            {
                return;
            }

            int Id_Compra = int.Parse(data_compra.Rows[data_compra.CurrentRow.Index].Cells["ID"].Value.ToString());

            if (MessageBox.Show("Esta seguro de eliminar los datos seleccionados..??", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string message = obj_c.SP_Delete_Compra_DT(Id_Compra);
                MessageBox.Show(message, "Message", MessageBoxButtons.OK);
                Listar();
            }
        }

        private void data_compra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            detalle_compra.DataSource = obj_compra.SP_ToList_Detalle_Compra_ID(int.Parse(data_compra.Rows[index].Cells["ID"].Value.ToString()));
        }

        private void r_venta_Click(object sender, EventArgs e)
        {
            using (MantComprasNuevo frm = new MantComprasNuevo())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    Listar();
                }
            }
        }
    }
}
