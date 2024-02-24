

#include<iostream>
using namespace std;

int main() {
	int a;
	int alq;
	int auto;
	int c;
	int dias;
	int k;
	int resultado;
	a = 20000;
	c = 30000;
	k = 40000;
	dias = 0;
	auto = 0;
	alq = 0;
	do {
		cout << "***********************************" << endl;
		cout << "Bienvenid@ que auto desea alquilar?" << endl;
		cout << "***********************************" << endl;
		cout << "Digite 1 si desea un automovil" << endl;
		cout << "Digite 2 si desea un campero" << endl;
		cout << "Digite 3 si desea una camioneta" << endl;
		cin >> auto;
		if (auto<1) {
			cout << "Auto no valido" << endl;
		}
		if (auto>3) {
			cout << "Auto no valido" << endl;
		}
		cout << "Cuantos dias va alquilar el auto" << endl;
		cin >> dias;
		if (dias<1) {
			cout << "Dia no valido" << endl;
		}
		if (auto==1) {
			resultado = a*dias;
			cout << "El valor total de alquiler del automovil es de $" << resultado << endl;
		}
		if (auto==2) {
			resultado = c*dias;
			cout << "El valor total de alquiler del campero es de $" << resultado << endl;
		}
		if (auto==3) {
			resultado = k*dias;
			cout << "El valor total de alquiler de la camioneta es de $" << resultado << endl;
		}
		cout << "***********************************" << endl;
		cout << "___________________________________" << endl;
		cout << "Desea realizar otro alquiler?" << endl;
		cout << "Presione del 0 al numero para 4 SI" << endl;
		cout << "Presione del 4 al 9 para NO " << endl;
		cin >> alq;
	} while (alq<4);
	return 0;
}

