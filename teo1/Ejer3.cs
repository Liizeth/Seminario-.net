public class Ejer3
{
    public static void Ejecutar()
    {
        //----------- desactiva secuencias de escape 

        //El carácter @ delante de un string desactiva los códigos de escape.

        string dir = @"c:\windows\system";
        Console.WriteLine(dir);
    }
}