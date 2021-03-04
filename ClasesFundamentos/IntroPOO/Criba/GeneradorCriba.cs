using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO.Criba
{
    public class GeneradorCriba
    {
        public int[] GenerarCriba(int limite)
        {
            int[] criba = new int[limite - 1];
            for (int index = 0; index < criba.Length; index++)
            {
                criba[index] = index + 2;
            }

            return criba;
        }
    }
}
