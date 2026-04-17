internal class Program
{
    private static void Main(string[] args)
    {
        int opcion, cantidad;
        Double precio = 0, total;
        Console.WriteLine(" ESTADIO DOROTEO GUAMUCH FLORES");
        Console.WriteLine("SECTORES:");
        Console.WriteLine(".PALCO (Q300)");
        Console.WriteLine("2.TRIBUNA (Q100-Q125)");
        Console.WriteLine("3.PREFERENCIA (Q50-Q75)");
        Console.WriteLine("4. GENERALES (Q30-Q50");
        Console.WriteLine("SELECCIONE UN SECTOR");
        opcion = Convert.ToInt32(Console.ReadLine());


        switch (opcion)
        {
            case 1:
                precio = 300;
                break;
            case 2:
                precio = 100;
                break;
            case 3:
                precio = 50;
                break;
            case 4:
                precio = 30;
                break;

            default:
                Console.WriteLine("INVALIDO");
                return;
        }
                Console.WriteLine("CANTIDAD DE ENTRADAS");
                cantidad = int.Parse(Console.ReadLine());
                total= precio * cantidad;
                Console.WriteLine("TOTAL A PAGAR: Q" + total);


        
    }
}