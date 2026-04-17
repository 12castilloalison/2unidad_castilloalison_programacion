internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("CONVERSOR DE MEDIDAS");
        int a, b;
        double v, r;
        Console.WriteLine("INGRESE ALGUN VALOR");
        v = Double.Parse(Console.ReadLine());
        Console.WriteLine("SELECCIONE UNA UNIDAD DESTINO");
        Console.WriteLine("1.METROS");
        Console.WriteLine("2.PIES");
        Console.WriteLine("3.CENTIMETROS");
        Console.WriteLine("4.PULGADAS");
        a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 1:
                r = v;
                break;
            case 2:
                r = v * 3.28084;
                break;
            case 3:
                r = v * 100;
                break;
            case 4:
                r = v * 39.3701;
                break;
            default:
                Console.WriteLine("OPCION INVALIDA");
                return;

        }
        Console.WriteLine("RESULTADO: " + r);
    }
}