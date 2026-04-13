class Calculadora
{
    public bool EsPrimo(int nro)
    {
        bool resultado = true;
        int rango = 2;

        while (resultado && rango <= Math.Sqrt(nro))
        {
            if (nro % rango == 0)
            {
                resultado = false;
            }
            rango++;
        }

        return resultado;
    }
}