public class Ejer5
{
    public static void Ejecutar()
    {
        //Qué líneas del siguiente código provocan conversiones boxing y unboxing.


        //------------ mismo ejer que el ejer 2

        //boxing:   Cuando una variable de algún tipo de valor se asigna a una de tipo de referencia,

        //unboxing: Cuando una variable de algún tipo de referencia se asigna a una de tipo de valor


        char c1 = 'A';
        string st1 = "A";
        object o1 = c1;             //boxing
        object o2 = st1;            //recordar que los string sond e tipo referencia
        char c2 = (char)o1;         //unboxing
        string st2 = (string)o2;    //recordar que los string sond e tipo referencia


    }
}