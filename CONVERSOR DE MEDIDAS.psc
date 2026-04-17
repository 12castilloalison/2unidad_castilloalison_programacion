Algoritmo sin_titulo
	ESCRIBIR "CONVERSOR DE MEDIDAS"
	DEFINIR a,b como entero
	definir v,r Como Real
	escribir "INGRESE ALGÚN VALOR";
	leer v
	escribir "SELECCIONE UNA UNIDAD DESTINO"
	ESCRIBIR "1.METROS"
	ESCRIBIR "2.PIES"
	ESCRIBIR "3.CENTIMETROS"
	ESCRIBIR "4.PULGADAS"
	LEER a
	Segun a Hacer
		1:
			r=v
		2:
			r=v*3.28084
		3:
			r=v*100
		4:
			r=v*39.3701
		De Otro Modo:
			escribir "OPCION INVALIDA"
	Fin Segun
	Escribir "RESULTADO: " r;
FinAlgoritmo
