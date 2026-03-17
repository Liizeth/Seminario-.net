public class Ejer10
{
    public static void Ejecutar()
    {
        //10) Escribir un programa que imprima en la consola todos los múltiplos de 17 o de 29 comprendidos entre 1 y 1000.
 
        Console.WriteLine("multiplos de 17 y 29 entre 1 y 1000");   

        int multiplos(int a, int b)
        {
            int num = a * b;

            if ( num <= 1000 )
            {
                Console.WriteLine("multiplos de  "+a+"  X  "+b +" =   :  "+ num);   
                return num;
            }
            else
            {
                return 999999;
            }
            
        }



        int max17 =0;
        int max29 =0;


        int i =1;
        while ( max17 <= 1000 || max29 <= 1000)
        {
            
            
            if (max17 <= 1000)
            {
                max17 = multiplos (17 ,i);
            }
        
            if (max29 <= 1000)
            {
                max29 = multiplos (29 ,i);
            }

            i = i+1;
        }

    }
}