

public class Ejer1
{
    public static void Ejecutar()
    {
        
        int n = 10;
        string st = (n < 0) ? "ejec si la conducion se cumple" : "ejec si la consdicion es falsa";
        Console.WriteLine(st);
        
        //Console.WriteLine(); //con salto de linea
        //Console.Write(); //sin salto de linea
        
        //Console.ReadKey();	//Lee UNA SOLA tecla
        //Console.ReadLine();	//Lee toda una línea de texto HASTA que el usuario presiona ENTER
        
        //asigno lo que lei a una var
        Console.WriteLine("ingrese algo");
        string leer = Console.ReadLine(); //string	no debería ser null
        
        string? leer2 = Console.ReadLine(); //string?	puede ser null
    }
}














