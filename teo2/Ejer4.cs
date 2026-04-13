public class Ejer4
{
    public static void Ejecutar()
    {
        //Resolver los errores de compilación en el siguiente fragmento de código. Utilizar el operador as
        //cuando sea posible.

        //as es lo mismo que --->  E is T ? (T)(E) : null

        //De chico → grande: automático (no se pierde informacion)
        // De grande → chico: necesitás cast se hace explicitamente (se puede perder informacion)


        object o = "Hola Mundo!";
        
        //string st = o;
        string? st = (string)o;

        int i = 12;
        //byte b = i ;  //(recordar que in es mas grande que byte  ----> int (32 bits) y byte (8 bits) )
        byte b = (byte) i ; //lo convierto explicitamente 
        
        double d = i;
        //float f =  d; //recordar que double es mams grande que float ----> double(64 bits) y float (32 bits)
        float f = (float) d; //lo convierto explicitamente 
        
        // Notar que int y float tienen el mismo tamaño (32 bits)
        // La conversión de int a float es implícita porque no hay pérdida de información significativa
        // La conversión de float a int es explícita porque se pierden los decimales
        // No depende del tamaño, sino de si hay pérdida de información

        o = i;
    
        //i = o + 1;
        i = (int)o + 1;
    }
}