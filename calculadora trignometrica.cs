internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        Double angulo, rad;
        double pi = Math.PI;
        Console.WriteLine("**************************************************");
        Console.WriteLine("CALCULADORA DE FUNCIONES TRIGONOMETRICAS BASICAS");
        Console.WriteLine("**************************************************");
        Console.WriteLine("1.SENO");
        Console.WriteLine("2.COSENO");
        Console.WriteLine("3.TANGENTE");
        Console.WriteLine("Ingrese el angulo en grados");
        angulo = double.Parse(Console.ReadLine());
        Console.WriteLine("ELIJA UNA OPCION");
        a = int.Parse(Console.ReadLine());
        rad = angulo * pi / 180;
        switch (a)
        {
            case 1:
                Console.WriteLine("EL SENO ES DE: "+ Math.Sin(rad));
                break;
            case 2:
                Console.WriteLine("EL COSENO ES DE: " + Math.Cos(rad));
                break;
            case 3:
                Console.WriteLine("LA TANGENTE ES DE: " + Math.Tan(rad));
                break;
            default:
                Console.WriteLine("LA OPCION ELEGIDA NO ES VALIDA!!!");
                break;


        }

    }
}