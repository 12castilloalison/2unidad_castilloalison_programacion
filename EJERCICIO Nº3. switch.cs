using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        Console.WriteLine("OPCIONES DE UN PEDIDO");
        Console.WriteLine("1.HAMBURGUESA");
        Console.WriteLine("2.PIZZA");
        Console.WriteLine("3.POLLO FRITO");
        Console.WriteLine("4.ENSALADA");
        Console.WriteLine("ELIGE TU PEDIDO DEL NO.1 AL NO.4");
        a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1:
                Console.WriteLine("HAMBURGUESA");
                break;
            case 2:
                Console.WriteLine("PIZZA");
                break;
            case 3:
                Console.WriteLine("POLLO FRITO");
                break;
            case 4:
                Console.WriteLine("ENSALADA");
                break;
            default:
                Console.WriteLine(" ¡EL NUMERO QUE INGRESO NO ES VALIDO!!!");
                break;







        }
    }
}