

using System.Diagnostics; // para usar Stopwatch

public class Ejer9
{
    public static void Ejecutar()
    {
        //Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos
        //implementados en el ejercicio anterior.

        //DateTime se puede tener fecha y hora actual 


        DateTime ahoraActual = DateTime.Now;
        Console.WriteLine(ahoraActual);

        //medir el tiempo de ejecucion ------------

        
        DateTime tiempoInicio = DateTime.Now;

        //** el for es para que haga algo
        for (int i = 0; i < 1000000; i++)
        {
            int x = i * i;
        }

        DateTime tiempoFin = DateTime.Now;

        TimeSpan tiempo = tiempoFin - tiempoInicio;

        //TimeSpan-> intervalo de tiempo. se obtiene de l diferencia de dos DateTime

        Console.WriteLine("Tiempo: " + tiempo.TotalMilliseconds + " ms");

        //tiempo.TotalMilliseconds  // milisegundos
        //tiempo.TotalSeconds       // segundos
        //tiempo.TotalMinutes       // minutos


        //-------------------------------------------------------------------------------------------------

        //busque algo que haga lo mismo que un cronometro (para darle inicio y fin, asi no hacer la diferencia entre dos variables)
        
        

        Stopwatch cromometro = new Stopwatch();

        cromometro.Start();

        // código a medir
        for (int i = 0; i < 1000000; i++)
        {
            int x = i * i;
        }

        cromometro.Stop();

        Console.WriteLine("Tiempo: " + cromometro.ElapsedMilliseconds + " ms");


    }
}