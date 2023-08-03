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
    public partial class Fr_Report_03 : Form
    {
        CB_Report_03 obj_report = new CB_Report_03();
        
        public Fr_Report_03()
        {
            InitializeComponent();
        }

        private void Fr_Report_03_Load(object sender, EventArgs e)
        {
            data_report_03.DataSource = obj_report.N_ListarProductosmasVendidosDelMesConCategoria();
        }
    }
}
