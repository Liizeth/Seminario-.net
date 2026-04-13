 using System.Text;

public class Ejer8
{
    public static void Ejecutar()
    {
        //Investigar acerca de la clase StringBuilder del espacio de nombre System.Text 
        // ¿En qué circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? 
        // Implementar un caso de ejemplo en el que el rendimiento sea claramente superior utilizando StringBuilder en lugar
        //de string y otro en el que no.


        //recordar los string son inmutables, por lo que cada modificación genera un nuevo objeto en memoria.

        // clase StringBuilder
        // crear y modificar texto
        // permite trabajar con cadenas de texto que pueden cambiar.
        // no genera un nuevo objeto en memoria

        //ejemplo de uso
        //using System.Text;

        StringBuilder sb = new StringBuilder();
        
        sb.Append("Hola");
        sb.Append(" mundo");
        
        Console.WriteLine(sb.ToString());

        //metodos
        
        //Append() Agrega texto al final
        //AppendLine() Agrega texto + salto de línea
            //sb.Insert(0, "Inicio ");
        //Insert() Inserta texto en una posición
            //sb.Insert(0, "Inicio ");
        //Remove() Elimina parte del texto
            //sb.Remove(0, 5);
        //ToString() Convierte a string normal
            //string resultado = sb.ToString();
            
    }
}