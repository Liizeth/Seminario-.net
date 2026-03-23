public class Ejer7
{
    public static void Ejecutar()
    {
        //¿Cuál es la salida por consola del siguiente fragmento de código? ¿Por qué la tercera y sexta línea
        //producen resultados diferentes?

        char c1 = 'A';
        char c2 = 'A';
        Console.WriteLine(c1 == c2); //imprime true porque ambas contiene lo mismo
        object o1 = c1;
        object o2 = c2;
        Console.WriteLine(o1 == o2); //imprime false porque no son iguales apuntan a distintas direcciones 
    }
}