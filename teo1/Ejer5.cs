public class Ejer5
{
    public static void Ejecutar()
    {

        Console.WriteLine("Ingrese un nombre  (if)");
        string nom = Console.ReadLine();


        Console.WriteLine("");
        //Console.WriteLine("resultado del if");
        
        if (nom == "liz")
        {
            Console.WriteLine("Hola liz!!");
        }
        else
        {
            Console.WriteLine("mmm vos no sos Liz");
        }
        
        Console.WriteLine("");


        Console.WriteLine("Ingrese un nombre  (switch)");
        string nombre = Console.ReadLine();
        // si te ingresa espacios lo toma como  nombre 

        //Console.WriteLine("resultado del switch");

        switch (nombre)
        {
            case "Juan":
                 Console.WriteLine("¡Hola amigo!");
            break;

            case "Maria":
                Console.WriteLine("Buen Dia señora");
            break;

            case "Alberto":
                Console.WriteLine("¡Hola  Alberto! ");
            break;

            case "":
                Console.WriteLine("¡Buen Dia mundo !  ");
            break;

            default :
                Console.WriteLine("Buen Dia  "+ nombre);
            break;

        }
    }
}