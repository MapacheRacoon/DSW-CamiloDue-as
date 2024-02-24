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
    public partial class lobby : Form
    {
        
        public lobby()
        {
            InitializeComponent();
            
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)

        { 
                    Application.Exit();
            }
        
        private void button4_Click(object sender, EventArgs e)
        {
            Contraseña formulario = new Contraseña();
            {

                formulario.Show();
                Hide();

            }


        }

        private void escenario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escenario1 formulario = new Escenario1();
            {

                formulario.Show();
                Hide();
            }
        }

        private void escenario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escenario2 formulario = new Escenario2();
            {

                formulario.Show();
                Hide();
            }
        }

        private void lobby_Load(object sender, EventArgs e)
        {

        }
    }
}

