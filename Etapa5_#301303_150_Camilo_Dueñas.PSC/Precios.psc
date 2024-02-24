Algoritmo Precios
	Escribir '******************'
	Escribir 'Pizzeria Donatello'
	Escribir '******************'
	N <- 5
	tamaño <- 5
	Dimension arreglo[N]
	Escribir 'Seleccione de que valor desea su pizza'
	Escribir '-----------------------------------'
	Escribir 'Precio'
	Escribir '________'
	Repetir
		
		Escribir '1. $10000'
		Escribir '2. $15000'
		Escribir '3. $20000'
		Escribir '4. $25000'
		Escribir '5. $35000'
		Escribir '6. SALIR'
				Leer n
		salir <- Falso
		Segun n  Hacer
			1:
				Escribir 'Has seleccionado la pizza pequeña Tipo 1'
			2:
				Escribir 'Has seleccionado la pizza Mediana Tipo 2'
			3:
				Escribir 'Has seleccionado la pizza Larga Tipo 3'
			4:
				Escribir 'Has seleccionado la pizza Familiar Tipo 4'
			5:
				Escribir 'Has seleccionado la pizza Extra Familiar Tipo 5'
			6:
				Escribir 'Gracias por su visita vuelva pronto'
			De Otro Modo:
				Escribir 'Escribir una opcion entre 1 y 6'
		FinSegun
	Hasta Que no salir
FinAlgoritmo
