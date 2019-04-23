using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, password;
            usuario = txtLogin.Text.TrimEnd();
            password = txtPassword.Text.TrimEnd();
            if((usuario== "Utec")&&(password == "Programacion1"))
                {

                    MessageBox.Show("Bienvenidos al sistema");
                }
            else
            {
                MessageBox.Show("Verifique usuario y password");

            }
        }
    }
}
