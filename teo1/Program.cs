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


    
    Console.WriteLine("Opciones");
    Console.WriteLine("1: ejer 1");
    Console.WriteLine("2: ejer 2");
    Console.WriteLine("3: ejer 3");
    Console.WriteLine("4: ejer 4");
    Console.WriteLine("5: ejer 5");
    Console.WriteLine("6: ejer 6");
    Console.WriteLine("7: ejer 7");
    Console.WriteLine("8: ejer 8");
    Console.WriteLine("9: ejer 9");
    Console.WriteLine("10: ejer 10");
    Console.WriteLine("11: ejer 11");
    Console.WriteLine("12: ejer 12");
    Console.WriteLine("13: ejer 13");
    Console.WriteLine("14: ejer 14");
    Console.WriteLine("15: ejer 15");
    Console.WriteLine("16: ejer 16");

    Console.WriteLine("Ingrese el ejecicio a ejecutar");
    string ejer = Console.ReadLine();

    Console.WriteLine("");

    Console.WriteLine("ejecutando el ejercicio  " + ejer);

    Console.WriteLine("");
    
    switch (ejer)
    {

    case "1":
        Ejer1.Ejecutar();//ejecuta el ejer 1        
    break;

    case "2":
        Ejer2.Ejecutar();//ejecuta el ejer 2
    break;
        
    case "3":
        Ejer3.Ejecutar();
    break;

    case "4":
        Ejer4.Ejecutar();
    break;

    case "5":
        Ejer5.Ejecutar();
    break;

    case "6":
        Ejer6.Ejecutar();
    break;

    case "7":
        Ejer7.Ejecutar();
    break;

    case "8":
        Ejer8.Ejecutar();
    break;

    case "9":
        Ejer9.Ejecutar();
    break;

    case "10":
        Ejer10.Ejecutar();
    break;

    case "11":
        Ejer11.Ejecutar();
    break;

    case "12":
        Ejer12.Ejecutar();
    break;

    case "13":
        Ejer13.Ejecutar();
    break;

    case "14":
        Ejer14.Ejecutar();
    break;

    case "15":
        Ejer15.Ejecutar();
    break;

    case "16":
        Ejer16.Ejecutar();
    break;
    

    default :
    Console.WriteLine("ejer del 1 al 16 ");
    break;

    }



