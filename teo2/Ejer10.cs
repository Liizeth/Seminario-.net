
using System.Text;
public class Ejer10
{
    public static void Ejecutar()
    {
        //Comprobar el funcionamiento del siguiente programa y dibujar el estado de la pila y la memoria
        //heap cuando la ejecución alcanza los puntos indicados (comentarios en el código)


        
        object[] v = new object[10]; 

        v[0] = new StringBuilder("Net");

        for (int i = 1; i < 10; i++)
        {
        v[i] = v[i - 1]; 
        }// cada pos del vector apunta al contenido de  v[0]  -->".net"

        (v[5] as StringBuilder).Insert(0, "Framework .");
        //recordar que el vector se creo con object
        //v[5] as StringBuilder-->   toma la pos del vector  y lo trata como StringBuilder 
        //inserta en la por 0 (del string "Framework .")

        

        foreach (StringBuilder s in v) 
        {
            Console.WriteLine(s);    
        }
        

        //dibujar el estado de la pila y la mem. heap
        //en este punto de la ejecución

        v[5] = new StringBuilder("CSharp"); // se le asigna nuevo contenido a v[5]

        Console.WriteLine("------------------------------");

        foreach (StringBuilder s in v)
        {
            Console.WriteLine(s);    
        }
        
        //dibujar el estado de la pila y la mem. heap
        //en este punto de la ejecución

    }
}