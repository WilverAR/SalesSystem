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
    public partial class Fr_Report_02 : Form
    {
        CB_Report_02 obj_r = new CB_Report_02();
        DataTable data = new DataTable();

        public Fr_Report_02()
        {
            InitializeComponent();
        }
        bool enter = false;
        private void b_search_Click(object sender, EventArgs e)
        {
            if (enter == false)
            {
                data_categ_stock.DataSource = obj_r.SP_Report_ToList_Stock_X(c_categoria.Text);
                enter = true;
            }
        }

        private void timer_CategStock_Tick(object sender, EventArgs e)
        {
            if (data_categ_stock.Rows.Count > 1 && enter == true)
            {
                data = obj_r.SP_Report_ToList_Stock_X(c_categoria.Text);
                c_categ_stock.Text = data.Rows[0][2].ToString();
                enter = false;
            }
            if (data_categ_stock.Rows.Count <= 1 && enter == true)
            {
                c_categ_stock.Text = "";
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

        private void c_categoria_MouseMove(object sender, MouseEventArgs e)
        {
            c_categoria.BackColor = Color.FromArgb(0, 62, 62);
            c_categ_stock.BackColor = Color.FromArgb(0, 62, 62);
        }

        private void c_categoria_MouseLeave(object sender, EventArgs e)
        {
            c_categoria.BackColor = Color.FromArgb(0, 0, 0);
            c_categ_stock.BackColor = Color.FromArgb(0, 0, 0);
        }
    }
}
