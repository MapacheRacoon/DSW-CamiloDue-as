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
    public partial class Escenario2 : Form
    {
        private Font font;
        public Escenario2()
        {
            InitializeComponent();
            font = new Font("Arial", 10);
            this.MouseMove += Escenario1_MouseMove;
        }
        private void Escenario1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lobby formulario = new lobby();
            {

                formulario.Show();
                Hide();

            }
        }

        private void escenario2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Escenario1_Load(object sender, EventArgs e)
        {

        }

        private void escenario2ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Graphics Preorden;
            Preorden = CreateGraphics();
            Preorden.DrawString("PreOrden: ", font, Brushes.DarkCyan, 30, 412);
            Preorden.DrawString("26", font, Brushes.DarkCyan, 117, 412);
            Pen NodoPreorden1 = new Pen(Color.LightCoral, 2);
            Preorden.DrawEllipse(NodoPreorden1, 100, 395, 50, 50);

            Preorden.DrawString("20", font, Brushes.DarkCyan, 177, 412);
            Pen NodoPreorden2 = new Pen(Color.LightCoral, 2);
            Preorden.DrawEllipse(NodoPreorden2, 160, 395, 50, 50);

            Preorden.DrawString("17", font, Brushes.DarkCyan, 237, 412);
            Pen NodoPreorden3 = new Pen(Color.LightCoral, 2);
            Preorden.DrawEllipse(NodoPreorden3, 220, 395, 50, 50);

            Preorden.DrawString("25", font, Brushes.DarkCyan, 300, 412);
            Pen NodoPreorden4 = new Pen(Color.LightCoral, 2);
            Preorden.DrawEllipse(NodoPreorden4, 280, 395, 50, 50);

            Preorden.DrawString("24", font, Brushes.DarkCyan, 357, 412);
            Pen NodoPreorden5 = new Pen(Color.LightCoral, 2);
            Preorden.DrawEllipse(NodoPreorden5, 340, 395, 50, 50);

            Preorden.DrawString("31", font, Brushes.DarkCyan, 417, 412);
            Pen NodoPreorden6 = new Pen(Color.LightCoral, 2);
            Preorden.DrawEllipse(NodoPreorden6, 400, 395, 50, 50);

            Preorden.DrawString("28", font, Brushes.DarkCyan, 477, 412);
            Pen NodoPreorden7 = new Pen(Color.LightCoral, 2);
            Preorden.DrawEllipse(NodoPreorden7, 460, 395, 50, 50);

            Preorden.DrawString("55", font, Brushes.DarkCyan, 537, 412);
            Pen NodoPreorden8 = new Pen(Color.LightCoral, 2);
            Preorden.DrawEllipse(NodoPreorden8, 520, 395, 50, 50);

            Preorden.DrawString("37", font, Brushes.DarkCyan, 597, 412);
            Pen NodoPreorden9 = new Pen(Color.LightCoral, 2);
            Preorden.DrawEllipse(NodoPreorden8, 580, 395, 50, 50);


            {
                Graphics InOrden;
                InOrden = CreateGraphics();

                InOrden.DrawString("InOrden: ", font, Brushes.DarkCyan, 30, 467);
                InOrden.DrawString("17", font, Brushes.DarkCyan, 120, 467);
                Pen Nodoinorden1 = new Pen(Color.LightCoral, 2);
                InOrden.DrawEllipse(Nodoinorden1, 100, 450, 50, 50);

                InOrden.DrawString("20", font, Brushes.DarkCyan, 177, 467);
                Pen Nodoinorden2 = new Pen(Color.LightCoral, 2);
                InOrden.DrawEllipse(Nodoinorden2, 160, 450, 50, 50);

                InOrden.DrawString("24", font, Brushes.DarkCyan, 237, 467);
                Pen Nodoinorden3 = new Pen(Color.LightCoral, 2);
                InOrden.DrawEllipse(Nodoinorden3, 220, 450, 50, 50);

                InOrden.DrawString("25", font, Brushes.DarkCyan, 300, 467);
                Pen Nodoinorden4 = new Pen(Color.LightCoral, 2);
                InOrden.DrawEllipse(Nodoinorden4, 280, 450, 50, 50);

                InOrden.DrawString("26", font, Brushes.DarkCyan, 357, 467);
                Pen Nodoinorden5 = new Pen(Color.LightCoral, 2);
                InOrden.DrawEllipse(Nodoinorden5, 340, 450, 50, 50);

                InOrden.DrawString("28", font, Brushes.DarkCyan, 417, 467);
                Pen Nodoinorden6 = new Pen(Color.LightCoral, 2);
                InOrden.DrawEllipse(Nodoinorden6, 400, 450, 50, 50);

                InOrden.DrawString("31", font, Brushes.DarkCyan, 477, 467);
                Pen Nodoinorden7 = new Pen(Color.LightCoral, 2);
                InOrden.DrawEllipse(Nodoinorden7, 460, 450, 50, 50);

                InOrden.DrawString("37", font, Brushes.DarkCyan, 537, 467);
                Pen Nodoinorden8 = new Pen(Color.LightCoral, 2);
                InOrden.DrawEllipse(Nodoinorden8, 520, 450, 50, 50);

                InOrden.DrawString("55", font, Brushes.DarkCyan, 597, 467);
                Pen Nodoinorden9 = new Pen(Color.LightCoral, 2);
                InOrden.DrawEllipse(Nodoinorden9, 580, 450, 50, 50);


                {
                    Graphics posOrden;
                    posOrden = CreateGraphics();

                    posOrden.DrawString("PostOrden: ", font, Brushes.DarkCyan, 30, 522);

                    posOrden.DrawString("17", font, Brushes.DarkCyan, 120, 522);
                    Pen Nodoorden1 = new Pen(Color.LightCoral, 2);
                    posOrden.DrawEllipse(Nodoorden1, 100, 505, 50, 50);

                    posOrden.DrawString("24", font, Brushes.DarkCyan, 177, 522);
                    Pen Nodoorden2 = new Pen(Color.LightCoral, 2);
                    posOrden.DrawEllipse(Nodoorden2, 160, 505, 50, 50);

                    posOrden.DrawString("25", font, Brushes.DarkCyan, 237, 522);
                    Pen Nodoorden3 = new Pen(Color.LightCoral, 2);
                    posOrden.DrawEllipse(Nodoorden3, 220, 505, 50, 50);

                    posOrden.DrawString("20", font, Brushes.DarkCyan, 300, 522);
                    Pen Nodoorden4 = new Pen(Color.LightCoral, 2);
                    posOrden.DrawEllipse(Nodoorden4, 280, 505, 50, 50);

                    posOrden.DrawString("28", font, Brushes.DarkCyan, 357, 522);
                    Pen Nodoorden5 = new Pen(Color.LightCoral, 2);
                    posOrden.DrawEllipse(Nodoorden5, 340, 505, 50, 50);

                    posOrden.DrawString("37", font, Brushes.DarkCyan, 417, 522);
                    Pen Nodoorden6 = new Pen(Color.LightCoral, 2);
                    posOrden.DrawEllipse(Nodoorden6, 400, 505, 50, 50);

                    posOrden.DrawString("55", font, Brushes.DarkCyan, 477, 522);
                    Pen Nodoorden7 = new Pen(Color.LightCoral, 2);
                    posOrden.DrawEllipse(Nodoorden7, 460, 505, 50, 50);

                    posOrden.DrawString("31", font, Brushes.DarkCyan, 537, 522);
                    Pen Nodoorden8 = new Pen(Color.LightCoral, 2);
                    posOrden.DrawEllipse(Nodoorden8, 520, 505, 50, 50);

                    posOrden.DrawString("26", font, Brushes.DarkCyan, 597, 522);
                    Pen Nodoorden9 = new Pen(Color.LightCoral, 2);
                    posOrden.DrawEllipse(Nodoorden9, 580, 505, 50, 50);


                }
            }
        }

        private void escenario1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics Nodo;
            Nodo = CreateGraphics();
            Nodo.FillEllipse(Brushes.Red, 375, 56, 50, 50);
            Nodo.DrawString("26", font, Brushes.Black, 392, 73);
            Pen bordenodoraiz = new Pen(Color.White, 3);
            Nodo.DrawEllipse(bordenodoraiz, 375, 56, 50, 50);
            //sub1
            Nodo = CreateGraphics();
            Nodo.FillEllipse(Brushes.Red, 245, 146, 50, 50);
            Nodo.DrawString("20", font, Brushes.Black, 262, 163);
            Pen subn1izq = new Pen(Color.White, 3);
            Nodo.DrawEllipse(subn1izq, 245, 146, 50, 50);
            //sub2
            Nodo = CreateGraphics();
            Nodo.FillEllipse(Brushes.Red, 142, 230, 50, 50);
            Nodo.DrawString("17", font, Brushes.Black, 159, 247);
            Pen subn2izq = new Pen(Color.White, 3);
            Nodo.DrawEllipse(subn2izq, 142, 230, 50, 50);
            //sub3
            Nodo = CreateGraphics();
            Nodo.FillEllipse(Brushes.Red, 341, 230, 50, 50);
            Nodo.DrawString("25", font, Brushes.Black, 358, 247);
            Pen subn3izq = new Pen(Color.White, 3);
            Nodo.DrawEllipse(subn3izq, 341, 230, 50, 50);
           

            //sub6
            Nodo = CreateGraphics();
            Nodo.FillEllipse(Brushes.Red, 295, 330, 50, 50);
            Nodo.DrawString("24", font, Brushes.Black, 312, 347);
            Pen subn6izq = new Pen(Color.White, 3);
            Nodo.DrawEllipse(subn6izq, 295, 330, 50, 50);
            //sub1
            Nodo = CreateGraphics();
            Nodo.FillEllipse(Brushes.Red, 515, 146, 50, 50);
            Nodo.DrawString("31", font, Brushes.Black, 532, 163);
            Pen subn1der = new Pen(Color.White, 3);
            Nodo.DrawEllipse(subn1der, 515, 146, 50, 50);
            //sub2
            Nodo = CreateGraphics();
            Nodo.FillEllipse(Brushes.Red, 427, 230, 50, 50);
            Nodo.DrawString("28", font, Brushes.Black, 444, 247);
            Pen subn2der = new Pen(Color.White, 3);
            Nodo.DrawEllipse(subn2der, 427, 230, 50, 50);
            //sub3
            Nodo = CreateGraphics();
            Nodo.FillEllipse(Brushes.Red, 624, 230, 50, 50);
            Nodo.DrawString("55", font, Brushes.Black, 641, 247);
            Pen subn3der = new Pen(Color.White, 3);
            Nodo.DrawEllipse(subn3der, 624, 230, 50, 50);
            //sub4
            Nodo = CreateGraphics();
            Nodo.FillEllipse(Brushes.Red, 548, 330, 50, 50);
            Nodo.DrawString("37", font, Brushes.Black, 565, 347);
            Pen subn4der = new Pen(Color.White, 3);
            Nodo.DrawEllipse(subn4der, 548, 330, 50, 50);
           

            //lineas
            Pen líneanodoizq1 = new Pen(Color.DarkGoldenrod, 3);
            Nodo.DrawLine(líneanodoizq1, 291, 156, 378, 95);
            //2
            Pen líneanodoizq2 = new Pen(Color.DarkGoldenrod, 3);
            Nodo.DrawLine(líneanodoizq2, 250, 190, 186, 239);
            //3
            Pen líneanodoizq3 = new Pen(Color.DarkGoldenrod, 3);
            Nodo.DrawLine(líneanodoizq3, 290, 189, 347, 235);
            
            //line anti-copy this code is create for student:1052415703                                                                                                             camilo andres dueñas diaz
            //6
            Pen líneanodoizq6 = new Pen(Color.DarkGoldenrod, 3);
            Nodo.DrawLine(líneanodoizq6, 354, 278, 329, 331);
            //der1
            Pen líneanododer1 = new Pen(Color.DarkGoldenrod, 3);
            Nodo.DrawLine(líneanododer1, 423, 93, 519, 155);
            //der2
            Pen líneanododer2 = new Pen(Color.DarkGoldenrod, 3);
            Nodo.DrawLine(líneanododer2, 522, 188, 465, 234);
            //der3
            Pen líneanododer3 = new Pen(Color.DarkGoldenrod, 3);
            Nodo.DrawLine(líneanododer3, 560, 191, 629, 238);
            //der4
            Pen líneanododer4 = new Pen(Color.DarkGoldenrod, 3);
            Nodo.DrawLine(líneanododer4, 632, 274, 587, 333);
            //der5
      

        }

        
        
    }



}
