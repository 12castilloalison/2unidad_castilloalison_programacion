Algoritmo sin_titulo
	DEFINIR a, c Como Entero
	definir p, i, pii Como Real
	definir tsd,d, md, tp Como Real
	p=650
	i=0.12
	escribir "CANTIDAD DE IMPRESORAS:"
	leer c
	pii= p+(p*i)
	Escribir "FORMA DE PAGO: "
	ESCRIBIR "1. EFECTIVO (10%)"
	ESCRIBIR "2.TARJETA (5%)"
	ESCRIBIR "3. VALE (15%)"
	leer a
	Segun a Hacer
		1:
			d=0.10
		2: 
			d=0.05
		3::
			d=0.15
		De Otro Modo:
			ESCRIBIR "OPCION INVALIDA!!!"
	Fin Segun
	tsd= pii*c
	md=tsd*d
	tp=tsd-md
	Escribir "cantidad: " c
	escribir "Precio sin IVA: Q" pii
	escribir "Total sin descuento Q" tsd
	escribir "Total a pagar: Q" tp
FinAlgoritmo
