public class Ejer9
{
    public static void Ejecutar()
    {
        //---------- palabras simetricas 

        Console.WriteLine("ingrese una palabra");
        string p1 = Console.ReadLine();

        int cant =p1.Length ;
        
        int num = 1;

        while (cant != num && (p1[num-1] == p1[cant -1]))
        {
            Console.WriteLine("compara  "+ p1[num-1] +" y "+  p1[cant-1]);


            cant = --cant;
            num = ++num;

            // Console.WriteLine(" dentro del while  cant y num ");
            // Console.WriteLine(cant);
            // Console.WriteLine(num);
        }


        if (cant == num) 
        {
            Console.WriteLine("las palabras SON simetricas");    
        }
        else
        {
            Console.WriteLine("las palabras NO SON simetricas");
        }

    }
}