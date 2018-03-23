using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coladeraDeEratostenes
{
    class Coladera
    {
       public static string Buscar(int valor)
        {
            int[] vec = new int[valor];
            int longitud = valor -1;
            string resultado = "1";

            for(int i = 1; i <= longitud; i++)
            {
                vec[i] = 1;
            }

            for (int i = 2; i <= longitud; i++)
            {
                for (int j = 3; j <= longitud; j++)
                {
                    if (j % i == 0)
                        vec[j] = 0;
                    else
                        vec[j] = 1;
                }
            }

            for (int i = 1; i <= longitud; i++)
            {
                if (vec[i] == 1)
                    resultado += "," + i;
            }

            return resultado;
        } 
    }
}
