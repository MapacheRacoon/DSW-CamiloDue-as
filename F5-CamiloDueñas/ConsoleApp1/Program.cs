using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDeClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Directorio direc1 = new Directorio();
            direc1.AgregarDatos();
            Console.Write(" Digite Enter para continuar ");
            Console.ReadKey();
            direc1.OrdenarDatos();
            direc1.ImprimirDatos();


            int v1 = 0, v2 = 0, v3 = 0, registrados = 0, votado =0;

            double total, ov1, ov2, ov3;

            

            {

                Console.WriteLine("Cuantos usuarios han votado?");
                votado = int.Parse(Console.ReadLine());
                for (int i = 1; i <= votado; i++)
                {

                    Console.WriteLine("Digite el voto registrado en el directorio de cada votante");
                    registrados = int.Parse(Console.ReadLine());
                    for (int x = 0; x<=votado; x++)
                        if 
                         (registrados ==1)
                        {
                            v1 = v1 + 1;
                        }
                        else if (registrados ==2)
                        {
                            v2 = v2 + 1;
                        }
                        else if (registrados ==3)
                        {
                            v3 = v3 + 1;
                        }
                            {



                                total = v1 + v2 + v3;
                                ov1 = (v1 / total) * 100;
                                ov2 = (v2 / total) * 100;
                                ov3 = (v3 / total) * 100;
                                Console.WriteLine("El candidato 1 tiene el {0}% de la totalidad de los votos", ov1);
                        Console.WriteLine("El candidato 2 tiene el {0}% de la totalidad de los votos", ov2);
                        Console.WriteLine("El candidato 3 tiene el {0}% de la totalidad de los votos", ov3);









                        }


                            }
                    
                    

                }
                Console.WriteLine(" Felicitaciones al Ganador Final Presione Enter 2 veces para salir ");
                Console.ReadLine();
                
                Console.ReadKey();

            }
            

        }
        
        }

