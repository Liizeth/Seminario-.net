public class Ejer12
{
    public static void Ejecutar()
    {
        //------------------ ejer 12 

        //Escribir un programa que imprima todos los divisores de un número entero ingresado desde la
        //consola. Para obtener el entero desde un string st utilizar int.Parse(st).
        

        Console.WriteLine("ingrese un nro");

        string c = Console.ReadLine();

        int num = int.Parse(c);

        int w = num;

        Console.WriteLine("divisores de   "+ num);
        while (w >0)
        {
            if (num % w ==0) // % pregunta si el resto de la div fue cero
            {
                Console.WriteLine(w);
            }

            w = w-1;
        }


    }
}