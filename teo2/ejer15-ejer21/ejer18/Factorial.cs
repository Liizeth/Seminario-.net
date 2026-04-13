class Factorial
{

//notar que se puso static en cada metodo para poder invocarlos sin necesidad de crear una instancia de la clase Factorial

    public static int NoRecursiva(int n)
    {
        int resultado = 1;
        for (int i = 1; i <= n; i++)
        {
            resultado *= i;
        }
        return resultado;
    }

    public static int Recursiva(int n)
    {
        if (n == 0 || n == 1) //por definicion el factorial de cero es 1 y el factorial de 1 es 1
            return 1;
        else
            return n * Recursiva(n - 1);
    }

    public static int ExpressionBodied(int n) => (n == 0 || n == 1) ? 1 : n * ExpressionBodied(n - 1);
}