// ConsoleApplication1.cpp : Este archivo contiene la función "main". La ejecución del programa comienza y termina ahí.
//

#include <iostream>

using namespace std;

int main()
{
	int n,f,N,g,i,R,D;
	float nota;
	i = 0;
	g = 0;
	cout << "Ingrese el numero de estudiantes:";
	cin >> n;
	while (f<n) 
	{
		f = f+1;
		cout << "Ingrese nota del estudiante "<<f<<":" ;
		cin >> nota;
		if(nota>5 || nota<0){
		cout << "La nota es del estudiante "<< f << " es incorrecta"<< endl;
		cout << "Por favor Ingrese de nuevo nota del estudiante " << f;
		cin >> nota;
        }
		if(nota>=4.8 && nota<=5){
		   cout << "El estudiante "<<f<< " es excelente "<< endl;
		    g=g+1;
        }if(4.0 <= nota && nota <= 4.7){
		   cout << "El estudiante " << f << " es Bueno "<< endl;
		    i=i+1;
		}if (3.0 <= nota && nota <= 3.9) {
			cout << "El estudiante " << f << " es Regular " << endl;
			R=R+1;
		}if (nota<= 2.9) {
			cout << "El estudiante " << f << " es Descuidado" << endl;
			D=D+1;
		}
	}
	cout << "El numero de estudiantes Excelentes es: " << g  << endl;
	cout << "El numero de estudiantes Buenos  es: " << i  << endl;
	cout << "El numero de estudiantes Regulares es: " << R  << endl;
	cout << "El numero de estudiantes Descuidados es: " << D  << endl;
	
	

    return 0;
}