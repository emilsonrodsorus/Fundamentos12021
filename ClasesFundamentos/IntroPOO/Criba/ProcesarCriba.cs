using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO.Criba
{
    public class ProcesarCriba
    {
        public void Procesar(CribaEr criba)
        {
            for (int pibot = 0; pibot < criba.ListaCriba.Length; pibot++)
            {
                if (criba.ListaCriba[pibot] != 0)
                {
                    for (int index = pibot + 1; index < criba.ListaCriba.Length; index++)
                    {
                        if (criba.ListaCriba[index] != 0 && criba.ListaCriba[index] % criba.ListaCriba[pibot] == 0)
                        {
                            criba.ListaCriba[index] = 0;
                        }
                    }
                }
            }
        }
    }
}
