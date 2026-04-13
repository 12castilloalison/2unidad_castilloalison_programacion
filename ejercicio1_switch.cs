using System;

internal class Program
{
    // un programa que solicite un numero del 1 al 7
    //mostrar en pantalla los dias de la semana segun el numero ingresado
    private static void Main(string[] args)
    {
        Console.WriteLine("*********************");
        Console.WriteLine("  DIAS DE LA SEMANA  ");
        Console.WriteLine("*********************");
        int dia;
        Console.WriteLine("Digite un valor entero del 1 al 7");
        dia = Convert.ToInt32(Console.ReadLine());

        switch(dia)
            {
            case 1:
                Console.WriteLine("LUNES");
                break;
            case 2:
                Console.WriteLine("MARTES");
                break;
            case 3:
                Console.WriteLine("MIERCOLES");
                break;
            case 4:
                Console.WriteLine("JUEVES");
                break;
            case 5:
                Console.WriteLine("VIERNES");
                break;
            case 6:
                Console.WriteLine("SABADO");
                break;
            case 7:
                Console.WriteLine("DOMINGO");
                break;
            default:
                Console.WriteLine("ESCRIBE UN VALOR VALIDO DEL1 AL 7");
                break;
        }
    }
}