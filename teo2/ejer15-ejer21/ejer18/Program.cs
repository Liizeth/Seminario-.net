//Escribir una función (método int Fac(int n)) que calcule el factorial de un número n pasado al
//programa como parámetro por la línea de comando
    //a) Definiendo una función no recursiva
    //b) Definiendo una función recursiva
    //c) idem a b) pero con expression-bodied methods (Tip: utilizar el operador condicional ternario)


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

Console.WriteLine($"El factorial de {nro} es: {Factorial.NoRecursiva(nro)} (no recursivo)");

Console.WriteLine($"El factorial de {nro} es: {Factorial.Recursiva(nro)} (recursivo)");

Console.WriteLine($"El factorial de {nro} es: {Factorial.ExpressionBodied(nro)} (expression-bodied)");