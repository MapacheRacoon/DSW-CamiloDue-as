using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F4_Construccion_de_Arboles_Binarios
{
    public partial class Contraseña : Form
    {
        public Contraseña()
        {
            InitializeComponent();
        }

        private void Contraseña_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lobby formulario = new lobby();
            {
                string pass;
                pass = textBox1.Text;

                if (pass == "123")
                {
                    label1.Text = "Contraseña Correcta";
                    formulario.Show();
                    Hide();
                }
                else
                    label1.Text = "Contraseña Incorrecta";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

