using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO.Criba
{
    public class CribaEr
    {
        public CribaEr(int[] listaGenerada)
        {
            ListaCriba = listaGenerada;
        }
        public int[] ListaCriba { get; set; }


        //metodo
        public void MostrarCriba()
        {
            foreach (int numero in ListaCriba)
            {
                if (numero != 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
