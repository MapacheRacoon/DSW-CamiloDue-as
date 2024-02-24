
using System;

namespace Productos {
	class productos {

		static void Main(string[] args) {
			int clase;
			int n;
			bool salir;
			int total;
			Console.WriteLine("******************");
			Console.WriteLine("Venta De Productos");
			Console.WriteLine("******************");
			clase = 0;
			total = 0;
			Console.WriteLine("Seleccione de 1 a 3 que clase de producto va a llevar?");
			Console.WriteLine("------------------------------------------------------");
			do {
				Console.WriteLine("1. Producto de clase A=5.000 c/u");
				Console.WriteLine("2. Producto de clase B=10.000 c/u");
				Console.WriteLine("3. Producto de clase C=20.000 c/u");
				Console.WriteLine("4. SALIR");
				n = int.Parse(Console.ReadLine());
				salir = false;
				switch (n) {
				case 1:
					Console.WriteLine("Cuantos Productos de clase A va a llevar?");
					break;
				case 2:
					Console.WriteLine("Cuantos Productos de clase B va a llevar?");
					break;
				case 3:
					Console.WriteLine("Cuantos Productos de clase C va a llevar?");
					break;
				case 4:
					Console.WriteLine("Gracias por su visita vuelva pronto");
					break;
				default:
					Console.WriteLine("Porfavor digite un caracter valido");
					break;
				}
			} while (!(!salir));
			if (n>=1 && n<=3) {
				clase = int.Parse(Console.ReadLine());
				if (n==1) {
					total = 5000*clase;
				}
				if (n==2) {
					total = 10000*clase;
				}
				if (n==3) {
					total = 20000*clase;
				}
				Console.WriteLine("Precio total de sus productos es de:$"+total+" pesos colombianos");
				Console.WriteLine("****************************************");
				Console.WriteLine("Algoritmo hecho por Camilo Andres Dueñas");
				Console.WriteLine("****************************************");
			}
		}

	}

}

