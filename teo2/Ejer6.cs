public class Ejer6
{
    public static void Ejecutar()
    {
        //Supongamos que Program.cs sólo tiene las siguientes dos líneas:
        
        int i = 1; //lo puse par que compile y no tire error
        
        //int i; //esto es del enunciado
        

        // intente arreglarlo con un string? para despues pacearlo pero el int? no se puede ...  se rompe 
        // string? i = Console.ReadLine(); //aca no le ingreso vacio (vacio no espacio -.-)
        // int? s = int.Parse(i); //al hacer int de vacio se rompe
        // Console.WriteLine(s);
        // capaz deberia de controlar si esta vacio le pongo cero pero eso ya es otra cosa 

        Console.WriteLine(i);
        
        //¿Por qué no compila?
        
        //porque la var i no fue inicializada,
        // 
        //  no se asigna valor por defecto (por ahora)

    }
}