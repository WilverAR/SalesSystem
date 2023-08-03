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
    public partial class Form_Main : Form
    {
        CE_User obj_user = new CE_User();
        CB_User user_x = new CB_User();
        DataTable data = new DataTable();
        MenuPrincipal menu_op = new MenuPrincipal();
        //Fr_Media_P w_media = new Fr_Media_P();

        public Form_Main()
        {
            InitializeComponent();
        }

        public void DataBase()
        {
            obj_user.Number = usuario.Text;
            obj_user.Nombre = usuario.Text;
            obj_user.Clave = password.Text;
            data = user_x.SP_User_PWD_UID_X(obj_user);
        }

        private void Check_PWD_UID()
        {
            if (data.Rows.Count > 0)
            {
                obj_user.Number = data.Rows[0][0].ToString();
                obj_user.Nombre = data.Rows[0][1].ToString();
                obj_user.Clave = data.Rows[0][2].ToString();
                MessageBox.Show("Bienvenido", "Message", MessageBoxButtons.OK);
                menu_op.ShowDialog();
                //w_media.ShowDialog();
            }
            else
            {
                MessageBox.Show("El Usuario o Password que ingresaste es Incorrecto.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase();
            Check_PWD_UID();
        }
        bool enter_u = false, enter_p = false;

        private void usuario_TextChanged(object sender, EventArgs e)
        {
            label_usuario.Visible = false;
            if (usuario.Text == "")
            {
                label_usuario.Visible = true;
                enter_u = false;
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            label_password.Visible = false;
            if (password.Text == "")
            {
                label_password.Visible = true;
                enter_p = false;
            }
        }

        private void label_usuario_MouseClick(object sender, MouseEventArgs e)
        {
            label_usuario.Visible = false; usuario.Focus();
        }

        private void label_password_MouseClick(object sender, MouseEventArgs e)
        {
            label_password.Visible = false; password.Focus();
        }

        private void usuario_MouseClick(object sender, MouseEventArgs e)
        {
            label_usuario.Visible = false;
            enter_u = true;
        }

        private void password_MouseClick(object sender, MouseEventArgs e)
        {
            label_password.Visible = false;
            enter_p = true;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (enter_p)
            {
                label_password.Visible = false;
            }
            if (enter_u)
            {
                label_usuario.Visible = false;
            }
        }
    }
}
