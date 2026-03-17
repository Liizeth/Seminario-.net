public class Ejer13
{
    public static void Ejecutar()
    {
        
        
        //--------------------------- ejer 13
        //Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente
        //expresión. Tip: observar qué pasa cuando b = 0.

        int b = 0;
        int a = 30;
        
        

        if ((b != 0) & (a/b > 5)) // si b es cero tira error no se puede div 
        {
            Console.WriteLine(a/b);    
        }
        Console.WriteLine("nada");
        

    }
}