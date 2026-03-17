public class Ejer16
{
    public static void Ejecutar()
    {
        
        
        //--------------------------- ejer 16

        int i = 1;
        if (--i == 0) //pre decremento ---- primero decremente y luego pregunta si es cero
        {
            Console.WriteLine("cero");
        }
        if (i++ == 0) // pos incremente ---- primero pregunta si es cero y luego inc
        {
            Console.WriteLine("cero");
        }
        Console.WriteLine(i); //quedo igual
        
        
        

    }
}


