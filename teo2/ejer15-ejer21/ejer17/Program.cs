// Implementar un programa que muestre todos los números primos entre 1 y un número natural dado
// (pasado al programa como argumento por la línea de comandos). Definir el método bool
// EsPrimo(int n) que devuelve true sólo si n es primo. Esta función debe comprobar si n es
// divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota: Math.Sqrt(d) devuelve la
// raíz cuadrada de d)

//int nro = int.Parse(args[0]); // Convertir el primer argumento a un número entero


if (args.Length == 0)
{
    Console.WriteLine("Por favor ingresá un número. Ejemplo: dotnet run 20");
    return;// para que corte la ejecucion
}

if (!int.TryParse(args[0], out int nro)) 
//aca ya tengo el numero convertido a entero, si no se pudo convertir, nro va a ser 0
{
    Console.WriteLine("El argumento ingresado no es un número válido.");
    return;
}



Calculadora calc = new Calculadora(); 
//creo una instancia de la clase Calculadora para poder usar el método EsPrimo

int i= 1;

while (i <= nro)
{
    if (calc.EsPrimo(i))
    {
        Console.WriteLine(i);
    }
    i++;
}
