using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_quero_ser
{
    internal class MenorDistancia
    {
        public static string CalcularMenorDistancia()
        {
            int[] array1 = { -1, 9 };
            int[] array2 = { 26, 6 };

            int resultado = 0;
            string menorDistancia = "";

            int qtd = array1.Length + array2.Length;
            int[] array = new int[qtd];

            //Ordernar Arrays
            array1.CopyTo(array, 0);
            array2.CopyTo(array, array1.Length);
            Array.Sort(array);


            for (int i = 0; i < qtd - 1; i++)
            {
                int distancia = Math.Abs(array[i] - array[i + 1]);
                if (distancia < resultado || resultado == 0)
                {
                    menorDistancia = array[i].ToString() + " | " + array[i + 1].ToString();
                    resultado = distancia;
                }
            }

            
            return string.Format("Menor distancia entre {0} seria: {1}", menorDistancia, resultado);
        }
    }
}
