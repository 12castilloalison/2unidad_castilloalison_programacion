Algoritmo sin_titulo
	escribir " ESTADIO DOROTEO GUAMUCH FLORES"
	definir a, b Como Entero
	definir c, d Como Real
	escribir "SECTORES:"
	ESCRIBIR "1.PALCO (Q300)"
	ESCRIBIR "2.TRIBUNA (Q100-Q125)"
	ESCRIBIR "3.PREFERENCIA (Q50-Q75)"
	Escribir "4. GENERALES (Q30-Q50)"
	Escribir "SELECCIONE UN SECTOR";
	LEER a
	Segun a Hacer
		1:
			c=300
		2:
			c=100
		3:
			c=50
		4:
			c=30
		De Otro Modo:
			escribir "INVALIDO!!"
	Fin Segun
	escribir "CANTIDAD DE ENTRADAS: "
	Leer b
	d=c*b
	ESCRIBIR " TOTAL A PAGAR: " d
FinAlgoritmo
