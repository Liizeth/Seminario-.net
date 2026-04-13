//Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros cuando
//se invoca desde la línea de comandos.


Console.WriteLine("¡Hola {0}!", args[0]);


//sin pasarle parametro el programa lanzará una excepción del tipo IndexOutOfRangeException
// ya que se está intentando acceder a un índice que no existe en el array de argumentos (args[0])
//Esto ocurre porque el programa espera al menos un argumento para poder imprimir el mensaje de saludo
//pero si no se proporciona ninguno, el array estará vacío y no habrá ningún elemento en la posición 0.
