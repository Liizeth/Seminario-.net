
public class Ejer13
{
    //public static void Ejecutar(string [] args) //para que compile y desde el programa principal deberia de pasarle pasametros
    public static void Ejecutar()
    {
        //¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos?
        
        string[] args = new string[0]; //lo inicie aca para no modificar el programa principal

        Console.WriteLine(args == null);    // imprime false
        Console.WriteLine(args.Length);     // imprime 0
    }
}