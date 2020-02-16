using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArreglosASP.Funtions
{
    public class FuntionMM
    {
        public static int Mayor(int[] Numero)
        {
            int Mayor = Numero[0];
            for (int i=0; i<Numero.Length; i++)
            {
                if (Numero[i]> Mayor)
                {
                    Mayor = Numero[i];
                }
            }
            return Mayor ;
        }
        public static int Menor(int[] Numero)
        {
            int Menor = Numero[0];

            for (int i = 0; i < Numero.Length; i++)
            {
                if (Numero[i] < Menor)
                {
                    Menor = Numero[i];
                }
            }
            return Menor;
        }
    }
}
