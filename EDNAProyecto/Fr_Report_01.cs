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
    public partial class Fr_Report_01 : Form
    {
        CB_Report_01 obj_r = new CB_Report_01();
        DataTable data = new DataTable();
        
        public Fr_Report_01()
        {
            InitializeComponent();
        }

        private void Fr_Report01_Load(object sender, EventArgs e)
        {
            data_venta_x_zona.DataSource = obj_r.SP_ToList_Ventas_D_X();
        }

        private void c_zona_MouseMove(object sender, MouseEventArgs e)
        {
            c_zona.BackColor = Color.FromArgb(0, 62, 62);
            c_cant_v.BackColor = Color.FromArgb(0, 62, 62);
        }

        private void c_zona_MouseLeave(object sender, EventArgs e)
        {
            c_zona.BackColor = Color.FromArgb(0, 0, 0);
            c_cant_v.BackColor = Color.FromArgb(0, 0, 0);
        }
        bool enter = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (enter == false)
            {
                data_venta_x_zona.DataSource = obj_r.SP_Cantidad_Ventas_Zona_X(c_zona.Text);
                enter = true;
            }
        }

        private void timer_CantV_Tick(object sender, EventArgs e)
        {
            if (data_venta_x_zona.Rows.Count > 1 && enter == true) 
            {
                data = obj_r.SP_Cantidad_Ventas_Zona_X(c_zona.Text);
                c_cant_v.Text = data.Rows[0][0].ToString();
                enter = false;
            }
            if (data_venta_x_zona.Rows.Count <= 1 && enter == true)
            {
                c_cant_v.Text = "";
                enter = false;
            }
        }

        private void b_search_MouseMove(object sender, MouseEventArgs e)
        {
            b_search.BackColor = Color.FromArgb(120, 120, 120);
        }

        private void b_search_MouseLeave(object sender, EventArgs e)
        {
            b_search.BackColor = Color.FromArgb(255, 255, 255);
        }
    }
}
