public class Ejer3
{
    public static void Ejecutar()
    {
        //¿Qué diferencias existen entre las conversiones de tipo implícitas y explícitas?
        

        //conversiones de tipo implícitas 

            // De un tipo más chico a uno más grande: conversión implícita (automática)
            //son automaticas (las hace el compilador)
            //no se pierde informacion
            //son seguras

            // Ejemplo implícita: (recordar que in es mas grande que byte  ----> int (32bits) y byte (8 bits) )
            //byte b = 10;
            //int x = b;



        //conversiones de tipo explícitas

            // De un tipo más grande a uno más chico: conversión explícita (requiere cast)
            //las hace el progrmador
            //se puede perder informacion de una convercion a otra
            //no son seguras

            // Ejemplo explícita:  (recordar que in es mas grande que byte  ----> int (32bits) y byte (8 bits) )
            //int y = 300;
            //byte c = (byte)y;
            

    }
}