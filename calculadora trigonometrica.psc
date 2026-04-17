Algoritmo sin_titulo
	definir angulo, rad Como real
	definir a como entero
	Escribir "**************************************************"
	escribir " CALCULADORA DE FUNCIONES TRIGONOMETRICAS BASICAS"
	Escribir "**************************************************"
	escribir "1.seno"
	Escribir "2.Coseno"
	escribir "3.Tangente"
	Escribir "Ingrese el angulo en grados: "
	Leer angulo
	Escribir "ELIJA UNA OPCION: "
	Leer a
	rad =angulo * PI / 180
	Segun a Hacer
		1:
			Escribir "EL SENO ES DE: ", sen(rad)
		2:
			ESCRIBIR "EL COSENO ES DE: ", cos(rad)
		3:
			ESCRIBIR "LA TANGENTE ES DE: ",tan(rad)
		De Otro Modo:
			escribir "LA OPCION ELEGIDA ES INVALIDA!!!"
	Fin Segun
	
FinAlgoritmo
