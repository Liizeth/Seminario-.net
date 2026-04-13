public class Ejer11
{
    public static void Ejecutar()
    {
        //¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas las
        //palabras (una por línea) de una frase ingresada por consola por el usuario.
        


        //método Split de la clase string

        //divide una cadena de texto (string) en un arreglo (array) de subcadenas más pequeñas,
        //utilizando un delimitador específico, como una coma, espacio o expresión regular.


        //modo de uso

        //ingrese una frase
        Console.WriteLine("ingrese una frase");
        string frase = Console.ReadLine();

        //gianni  

        Console.WriteLine();
        //
        //object[] v = new object[10];
        string [] vector = frase.Split(' ');

        Console.WriteLine("vector de  palabras");

        foreach (string s in vector) 
        {
            Console.WriteLine(s);    
        }
        


    }
}