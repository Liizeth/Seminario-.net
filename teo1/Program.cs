// //using System;

// // See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Hello, World!");

double r1 = 17 / 3; //entero
double r2 = 17 / 3.0; //con decimal
Console.WriteLine(r1);
Console.WriteLine(r2);


{
int i=1;
Console.WriteLine(i);
}
//Console.WriteLine(i); la var i solo existe dentro del bloque {}


    
    Console.WriteLine("Opciones del 1 al 16 ");
    
   
    Console.Write("Número de ejercicio: ");
    var num = Console.ReadLine();

    var nombreClase = "Ejer" + num; //arma el nombre

    //var tipo = Type.GetType("teo1." + nombreClase);

    var tipo = Type.GetType(nombreClase);  //Busca una clase con ese nombre en el programa
                                            //Devuelve el tipo (la clase) si ees que la encuentra
    

    if (tipo != null)
    {
        var metodo = tipo.GetMethod("Ejecutar"); //busca el metodo 

        metodo?.Invoke(null, null); 
        //metodo? --->  si es <> null 
        //Invoke ---> ejecuta el metodo encontrado
        // (null,null) ---> el 1er null porque el metodo es static  (no recibe objetos)
        //             ---> el 2do null porque no recibe parametros  
    } 
    else
    {
        Console.WriteLine("No existe ese ejercicio");
    }



