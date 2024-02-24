using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDeClases
{
    class Persona
    {
        public int iden;
        public string nombre;
        public int candidato;
        public Persona()
        {
            iden = 0;
            nombre = "";
            candidato = 0;
        }
        public void IngresarIdentificacion()
        {
            string linea;
            Console.Write(" Digite su numero de Identificacion: ");
            linea = Console.ReadLine();
            iden = int.Parse(linea);
        }
        public void ingresarDatos()
        {
            Console.Write(" Escriba su nombre:  ");
            nombre = Console.ReadLine();
            Console.Write("Escriba 1 si desea votar por el candidato#1");
            Console.Write(" +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.Write(" Escriba 2 si desea votar por el candidato#2");
            Console.Write(" +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.Write(" Escriba 3 si desea votar por el candidato#3                       ");
            candidato = int.Parse(Console.ReadLine());
            while (candidato < 0)
            {
                Console.WriteLine(" Candidato no valido ");
                Console.Write(" Digite nuevamente su candidato ");
            }
        }
    }
}
