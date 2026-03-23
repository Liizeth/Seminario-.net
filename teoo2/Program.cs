// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 1_000_000_321; 
float f = i; //los _ son ignorados, facilitan la lectura del nro 


object obj = 7.3; // obj apunta a un valor de tipo double
Console.WriteLine(obj.GetType());

object liz = "saturada";
Console.WriteLine(liz);
liz = 5;
Console.WriteLine((int)liz + 1);

liz = 1+ 'A'; // 1 + 65 ---> toma el valor ascii A = 65 
Console.WriteLine(liz);
liz = "CAS" + 'A'; // aca si lo toma como un  caracter 
Console.WriteLine(liz);

//"Área" + 5 + 1    ---->  "Área51"     notar que a los nros los toma como string
//5 + 1 + "Área"    ---->  "6Área"      aca primero lSos suma y el resultado lo toma como string





Console.WriteLine("");

 Console.WriteLine("Opciones del 1 al 21 ");
    
   
    Console.Write("Número de ejercicio: ");
    var num = Console.ReadLine();

    var nombreClase = "Ejer" + num; //arma el nombre

    //var tipo = Type.GetType("teo2." + nombreClase);

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
















