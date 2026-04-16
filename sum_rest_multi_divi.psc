//Pide dos números y una opción: 1 ? Sumar, 2 ? Restar, 3 ? Multiplicar, 4 ? Dividir 
Algoritmo sin_titulo
	definir num1,num2, a Como Entero
	escribir " DIGITE DOS NUMEROS QUE SERAN SUMADOS, RESTADOS, MULTIPLICADOS O DIVIDIDOS SEGUN LA OPCION QUE ELIJA"
	escribir "OPCIONES DEL 1 AL 4"
	escribir" 1.SUMAR"
	escribir" 1.RESTAR"
	escribir" 1.MULTIPLICAR"
	escribir" 1.DIVIDIR"
	Escribir "digite el primer numero: "
	leer num1
	escribir "digite el segundo numero: "
	leer num2
	Escribir "QUE OPCION DESEA QUE SE LLEVE A CABO"
	leer a
	Segun a Hacer
		1:
			suma=num1+num2;
			escribir "El resultado de la suma es de: " suma;
		2:
			resta= num1-num2;
			escribir "El resultado de la resta es de: " resta;
		3:
			multiplicacion= num1*num2;
			escribir "El resultado de la multiplicacion es de: " multiplicacion;
		4:
			division= num1*num2;
			escribir " El resultado de la division es de: " division;
		De Otro Modo:
			escribir "LA OPCION NO ES VALIDA!!!"
	Fin Segun
FinAlgoritmo
