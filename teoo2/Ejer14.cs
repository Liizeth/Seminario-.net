public class Ejer14
{
    public static void Ejecutar()
    {
        //¿Qué hace la instrucción? ¿Asigna a la variable vector el valor null?
            
            int[]? vector = new int[0]; //crea un vecto de enteros con cero elementos, Length cero no llega a poner null
            //Console.WriteLine(vector[0]); //rompe el programa



            int[]? vec = new int[5]; // int es de tipo valor y se iniciaaliza por defecto con cero
            foreach (int num in vec) 
            {
                 Console.WriteLine(num); //implime cero 
            }

            Console.WriteLine("--------------");

            string[]? v = new string [2]; //recordar que string es de tipo object, "imprime" null pero en consola no se ve, asi que imprime vacio

            foreach (string item in v)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("fin del programa");
    }
}