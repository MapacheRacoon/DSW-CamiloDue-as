Algoritmo PizzeriaDonatello
	Definir Npi,pizza,p,total,acumulador Como Entero
	
	Escribir "******************"
	Escribir "Pizzeria Donatello"
	Escribir "******************"
	Escribir "Cuantas pizzas desea"
	Leer Npi
	acumulador=0
	total=0
	p=0
	
	Para i<-1 Hasta Npi Con Paso 1 Hacer
		Escribir "Seleccione de 1 a 5 que pizza desea"
		Escribir "-----------------------------------"
		Escribir "Tipo	             Pizza	        Precio"
		Escribir "_________________________________________"
		Escribir "1	Pequeña        (2 porciones)	  10000"
		Escribir "2	Mediana        (4 porciones)	  15000" 
		Escribir "3	Larga          (6 porciones)	  20000"
		Escribir "4	Familiar       (8 porciones)	  25000"
		Escribir "5	Extra familiar (12 porciones) 35000"
		leer acumulador
	
	

		si acumulador=1 Entonces
			total=total+10000
			p=p+2
			Escribir "Usted acaba de adquirir una unidad de pizza tipo Pequeña"
		FinSi
		si acumulador=2 Entonces
			total=total+15000
			p=p+4
			Escribir "Usted acaba de adquirir una unidad de pizza tipo Mediana"
		FinSi
		si acumulador=3 Entonces
			total=total+20000
			p=p+6
			Escribir "Usted acaba de adquirir una unidad de pizza tipo Larga"
		FinSi
		si acumulador=4 Entonces
			total=total+25000
			p=p+8
			Escribir "Usted acaba de adquirir una unidad de pizza tipo Familiar"
		FinSi
		si acumulador=5 Entonces
			total=total+35000
			p=p+12
			Escribir "Usted acaba de adquirir una unidad de pizza tipo Extra familiar"
		FinSi
		si acumulador<=0 Entonces
			
			Escribir "Valor No valido FACTURA ANULADA Facor reiniciar el proceso"
			
		FinSi
		si acumulador>=6 Entonces
			Escribir "Valor No valido FACTURA ANULADA Favor reiniciar el proceso"
					FinSi

				Fin Para
	
	Escribir "|||||||||||||||||||||||||||||||||||||||||||||||||||||||||"
	
	Escribir "Usted acaba de aquirir un total de " Npi, " Pizzas"
		Escribir "Precio total de las pizzas: $" total;
		Escribir "Dando un total de " ,p " porciones vendidas"
	
	
FinAlgoritmo
