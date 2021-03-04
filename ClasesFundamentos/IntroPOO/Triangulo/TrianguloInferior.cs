using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO.Triangulo
{
    public class TrianguloInferior
    {
        public TrianguloInferior(int altura, char caracter)
        {
            Altura = altura;
            Caracter = caracter;
        }


        // properties
        public int Altura { get; set; }
        public char Caracter { get; set; }

        public void DibujarTrainguloInferior()
        {
            for (int fila = Altura - 1; fila > 0; fila--)
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
            //Console console1 = new Console();
        }

        public static void ImprimirNombre()
        {
            Console.WriteLine("Es un triangulo Inferior");
        }
    }
}
