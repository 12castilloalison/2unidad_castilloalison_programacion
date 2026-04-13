internal class Program
{
    private static void Main(string[] args)
    {
        char letra;
        Console.WriteLine("CLASIFICACION DE LETRAS POR RANGO");
        Console.Write("dame una letra:  ");
        letra = Convert.ToChar(Console.ReadLine());
        switch(letra)
            {
            case 'A':
                Console.WriteLine("EXCELENTE");
                break;
            case 'B':
                Console.WriteLine("BUENO");
                break;
            case 'C':
                Console.WriteLine("REULAR");
                break;
            case 'D':
                Console.WriteLine("DEFICIENTE");
                break;
            case 'F':
                Console.WriteLine("REPROBADO");
                break;
            default:
                Console.WriteLine(" LETRA NO VALIDA!!");
                break;
        }



    }
}