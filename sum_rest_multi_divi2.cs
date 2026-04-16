using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
       
        int num1, num2, opcion;

        Console.WriteLine("DIGITE DOS NUMEROS QUE SERAN SUMADOS, RESTADOS, MULTIPLICADOS O DIVIDIDOS SEGUN LA OPCION QUE ELIJA");
        Console.WriteLine("OPCIONES DEL 1 AL 4");
        Console.WriteLine("1. SUMAR");
        Console.WriteLine("2. RESTAR");
        Console.WriteLine("3. MULTIPLICAR");
        Console.WriteLine("4. DIVIDIR");

        Console.Write("Digite el primer numero: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite el segundo numero: ");
        num2 = int.Parse(Console.ReadLine());

        Console.Write("QUE OPCION DESEA QUE SE LLEVE A CABO: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                int result1 = num1 + num2;
                Console.WriteLine("El resultado de la suma es: " + result1);
                break;
            case 2:
                int result2 = num1 - num2;
                Console.WriteLine("El resultado de la resta es: " + result2);
                break;
            case 3:
                int result3 = num1 * num2;
                Console.WriteLine("El resultado de la multiplicacion es: " + result3);
                break;
            case 4:
                int result4 = num1 / num2;
                Console.WriteLine("El resultado de la division es: " + result4);
                break;
            default:
                Console.WriteLine("LA OPCION QUE INGRESO NO ES VALIDA!!!");
                break;
        }





    }
}