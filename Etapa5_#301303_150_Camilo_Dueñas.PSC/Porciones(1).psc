Algoritmo Porciones
	Escribir '******************'
	Escribir 'Pizzeria Donatello'
	Escribir '******************'
	N <- 5
	tamaño <- 6
	Dimension arreglo[6]
	Escribir 'Seleccione que paquete de porciones va a querer'
	Escribir '-----------------------------------'
	Escribir 'Porciones'
	Repetir
		Escribir '1. 2 porciones'
		Escribir '2. 4 porciones'
		Escribir '3. 6 porciones'
		Escribir '4. 8 porciones'
		Escribir '5. 12 porciones'
		Escribir '6. SALIR'
		
		Leer n
		salir <- Falso
		Segun n Hacer
			1:
				Escribir 'Has seleccionado 2 porciones o lo equivalente a una pizza pequeña Tipo 1'
			2:
				Escribir 'Has seleccionado 4 porciones o lo equivalente a una pizza Mediana Tipo 2'
			3:
				Escribir 'Has seleccionado 6 porciones o lo equivalente a una pizza Larga Tipo 3'
			4:
				Escribir 'Has seleccionado 8 porciones o lo equivalente a una pizza Familiar Tipo 4'
			5:
				Escribir 'Has seleccionado 12 porciones o lo equivalente a una pizza Extra Familiar Tipo 5'
			6:
				Escribir 'Gracias por su visita vuelva pronto'
			De Otro Modo:
				Escribir 'Escribir una opcion entre 1 y 6'
		FinSegun
	Hasta Que no salir
FinAlgoritmo
