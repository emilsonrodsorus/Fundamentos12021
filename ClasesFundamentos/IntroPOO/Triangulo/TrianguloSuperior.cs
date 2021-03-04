using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO.Triangulo
{
    public class TrianguloSuperior
    {
        public TrianguloSuperior(int altura, char caracter)
        {
            Altura = altura;
            Caracter = caracter;
        }


        // properties
        public int Altura { get; set; }
        public char Caracter { get; set; }

        public void DibujarTrainguloSuperior()
        {
            for (int fila = 1; fila <= Altura; fila++)
            {
                for (int columnaBlanco = 1; columnaBlanco <= Altura - fila; columnaBlanco++)
                {
                    Console.Write(' ');
                }
                for (int columnaCaracter = 1; columnaCaracter <= (2 * fila) - 1; columnaCaracter++)
                {
                    Console.Write(Caracter);
                }
                Console.WriteLine();
            }
        }
    }
}
