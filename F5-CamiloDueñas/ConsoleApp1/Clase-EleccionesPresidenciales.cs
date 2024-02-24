using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArregloDeClases
{
    class Directorio
    {
        public Persona[] datos;
        public int registrados;
        public int cantidad;
        public Directorio()
        {
            registrados = 0;
            cantidad = 50;
            datos = new Persona[cantidad];
        }
        public void AgregarDatos()
        {
            int i, j;
            bool encontrado = false;
            string linea;
            Console.WriteLine("Cuantos asociados vais a votar ");
            linea = Console.ReadLine();
            registrados = int.Parse(linea);
            for (i = 0; i < registrados; i++)
            {
                datos[i] = new Persona();
                datos[i].iden = 0;
            }
            Persona persona = new Persona();
            for (i = 0; i < registrados; i++)
            {
                encontrado = false;
                persona.IngresarIdentificacion();
                for (j = 0; j < registrados; j++)
                {
                    if (persona.iden == datos[j].iden)
                    {
                        encontrado = true; ;
                        i--;
                        break;
                    }
                }
                if (encontrado == true)
                {
                    Console.WriteLine(" Este asociado ya ha votado ");
                }
                else
                {
                    persona.ingresarDatos();
                    datos[i].iden = persona.iden;
                    datos[i].nombre = persona.nombre;
                    datos[i].candidato = persona.candidato;
                    Console.WriteLine(" Datos registrados correctamente, ");
                }
            }
            Console.ReadKey();
        }
        public void ImprimirDatos()
        {
            int i;
            Console.WriteLine(" IMPRESION DE DIRECTORIO\n ");
            for (i = 0; i < registrados; i++)
            {
                Console.WriteLine(datos[i].iden + "  " + datos[i].nombre + "   " + datos[i].candidato);
            }
            
        }
        public void OrdenarDatos()
        {
            int a, b, tempIden, tempCandidatos;
            string tempNom;
            Console.WriteLine("[Identificación][Nombre][N°De Candidato] ");
            for (a = 1; a < registrados; a++)
            {
                for (b = registrados - 1; b >= a; b--)
                {
                    if (datos[b - 1].iden > datos[b].iden)
                    {
                        tempIden = datos[b - 1].iden;
                        tempNom = datos[b - 1].nombre;
                        tempCandidatos = datos[b - 1].candidato;
                        datos[b - 1].iden = datos[b].iden;
                        datos[b - 1].nombre = datos[b].nombre;
                        datos[b - 1].candidato = datos[b].candidato;
                        datos[b].iden = tempIden;
                        datos[b].nombre = tempNom;
                        datos[b].candidato = tempCandidatos;
                    }
                }
                Console.WriteLine(" Digite Enter para continuar ");
                
            }


        }
    }
}
