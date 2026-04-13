public class Ejer12
{

    enum Meses
        {
            enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, noviembre, diciembre
        }
    public static void Ejecutar()
    {
        //Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
            
            //a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso (diciembre,
            //noviembre, octubre ..., enero)
            //b) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al nombre de
            //un mes

        //Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses


        //enum -->internamente es un nro, se comporta como tal pero se muestra como string 
        //


        
        //a)

        for (Meses m = Meses.diciembre; m >= Meses.enero; m--)
        {
            Console.WriteLine(m); //internamente hace m.ToString() 
        }

        Console.WriteLine ();
        Console.WriteLine ("-------------------------");
        Console.WriteLine ();

        //b)

        Console.WriteLine ("ingrese un mes");
        string mes = Console.ReadLine();

        
        Boolean encontre =false;

        for(Meses d = Meses.enero; d <= Meses.diciembre; d++)
        {
            //d.ToString() --> pasa de enum a string

            //if( d.ToString()  == mes) //sensible a mayusculas
            if (d.ToString().ToLower() == mes.ToLower()) //pasa ambas variables a minusculas 
            {
                Console.WriteLine("el mes existe");
                encontre = true;
                break;
            }
        }

        if (!encontre)
        {
            Console.WriteLine("el mes NO existe");
            
        }




    }
}