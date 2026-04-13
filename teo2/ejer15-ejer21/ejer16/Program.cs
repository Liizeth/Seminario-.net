//Escribir un programa que reciba una lista de nombres como parámetro por la línea de comandos e
//imprima por consola un saludo personalizado para cada uno de ellos.
    //a) Utilizando la sentencia for
    //b) Utilizando la sentencia foreachConsole.WriteLine("Hello, World!");


// primero recordar que impricitamente se está utilizando el método Main 


// con un parámetro de tipo string[] llamado args, que es un array de cadenas que contiene 
// los argumentos pasados por la línea de comandos al ejecutar el programa.
// class Program
// {
// static void Main(string[] args)
// {
// Console.WriteLine("Ok");
// }
// }

//agarramos lo argumentos y saludamos usando un bucle for

for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine("¡Hola {0}!", args[i]);
}


//ahora utilizo el bucle foreach
// itera sobre la coleccion, no hace falta usar un indice
foreach (string arg in args)
{
    Console.WriteLine("¡Hola {0}!", arg);
}
