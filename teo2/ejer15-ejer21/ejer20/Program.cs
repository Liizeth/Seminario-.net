//Codificar el método Swap que recibe 2 parámetros enteros e intercambia sus valores. El cambio
//debe apreciarse en el método invocador.

public class Program
{
    public static void Main(string[] args)
    {
        int a = 5;
        int b = 10;

        Console.WriteLine($"Antes del swap: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"Después del swap: a = {a}, b = {b}");
    }

    public static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
}
