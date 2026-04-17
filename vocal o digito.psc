Algoritmo sin_titulo
	Definir a Como Caracter
	escribir "DEFINIR SI ES VOCAL O DIGITO"
	escribir "ESCRIBA ALGÚN CARACTER"
	LEER a
	Segun a Hacer
		"a", "e", "i", "o", "u", "A", "E", "I", "O", "U":
			ESCRIBIR "ES UNA VOCAL..."
		"0", "1", "2", "3", "4", "5", "6", "7", "8", "9":
			ESCRIBIR "ES UN DIGITO..."
		De Otro Modo:
			ESCRIBIR "EL VALOR COLOCADO NO ES VALIDO!!!"
	Fin Segun
	
	
FinAlgoritmo
