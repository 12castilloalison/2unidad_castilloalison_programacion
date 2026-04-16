internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        Console.WriteLine("**************************************");
        Console.WriteLine("DIGITE UN NUMERO  Y SE MOSTRARA EL MES");
        Console.WriteLine("**************************************");
        a = Convert.ToInt32(Console.ReadLine());

        switch (a)
        {
            case 1:
                Console.WriteLine("ENERO\n posee 31 dias");
                break;
            case 2:
                Console.WriteLine("FEBRERO\n posee 28 dias y 29 dias en año bisiesto");
                break;
            case 3:
                Console.WriteLine("MARZO\n posee 31 dias");
                break;
            case 4:
                Console.WriteLine("ABRIL\n posee 30 dias");
                break;
            case 5:
                Console.WriteLine("MAYO\n posee 31 dias");
                break;
            case 6:
                Console.WriteLine("JUNIO\n posee 30 dias");
                break;
            case 7:
                Console.WriteLine("JULIO\n posee 31 dias");
                break;
            case 8:
                Console.WriteLine("AGOSTO\n posee 31 dias");
                break;
            case 9:
                Console.WriteLine("SEPTIEMBRE\n posee 30 dias");
                break;
            case 10:
                Console.WriteLine("OCTUBRE\n posee 31 dias");
                break;
            case 11:
                Console.WriteLine("NOVIEMBRE\n posee 30 dias");
                break;
            case 12:
                Console.WriteLine("DICIEMBRE\n posee 31 dias");
                break;
            default:
                Console.WriteLine("NUMERO DE MES NO VALIDO!!!!");
                break;


        }

    }
}