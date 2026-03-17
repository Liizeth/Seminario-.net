public class Ejer6
{
    public static void Ejecutar()
    {
        Console.WriteLine("ingrese una palabra ");
        string x = Console.ReadLine();
        //recordar que vacio no es lo mismo que espacio en blanco


        while(x != "")
        {
            Console.WriteLine("");

           Console.WriteLine("cant de caracteres de  "+ x+ "  es  "+ x.Length);

           Console.WriteLine("");
           Console.WriteLine("vuelva a ingresar una palabra ");
           x = Console.ReadLine();
        }
    }
}