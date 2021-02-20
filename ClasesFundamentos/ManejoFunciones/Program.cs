using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoFunciones
{
    class Program
    {
        // aca se declaran las variables globales
        static int limiteSuperior = 250;

        static void Main(string[] args)
        {
            // Console.ReadLine();
            // Console.WriteLine("Bienvenidos al proyecto de Funciones!!!!");
            //ImprimirSaludo();
            //ImprimirSaludo("Emilson Rodriguez");
            //ImprimirSaludo(new string[]{ "Emilson Rodrigues", "Juan Antezana", "Carla Aranda" });

            //Ejemplo de la criba de Eratostenes con funciones
            //int limite = Convert.ToInt32(Console.ReadLine());
            //int[] criba = GenerarCriba(limite);
            //Console.WriteLine("Criba inicial");
            //MostrarCriba(criba);
            //criba = ProcesarMultiplos(criba);
            //Console.WriteLine("Criba Sin multiplos solo Primos");
            //MostrarCriba(criba);

            //MostrarNumero(1, 3500);
            // int resultFac = Factorial(5);
            // Console.WriteLine(resultFac);
            //int numeroBase = 5;
            //int exponente = 10;
            //int result = Potencia(numeroBase, exponente);
            //Console.WriteLine(result);
            //int numeroInv = InvertirNumero(1548, 0);
            //Console.WriteLine("El numero invertido es {0}", numeroInv);
            //int numFibonacci = Fibonacci(1,1,2,8);
            int numFibonacci = Fibonacci(8);
            Console.WriteLine(numFibonacci);
        }

        /// <summary>
        /// Funcion para saludar
        /// La firma de una funcion contiene 
        /// 1.- nivel de acceso -> public (es como el nombre de una persona al cual se puede acceder) or 
        /// private (es como el pin de su tarjeta que solo lo usan internamente)
        /// 2.- Funciones static trabajan siempre con otras funciones static,
        /// quiere decir que mantengo la palabra reservada static
        /// 3.- Tipo de dato de retorno (si el resultado es vacio la palabra es void, 
        /// sino retorna el tipo de dato que trabaja la funcion)
        /// 4.- Nombre de la funcion, sera como llamemos o identifiquemos a la funcion, debe tratar de describir
        /// lo que esperamos de esa funcion
        /// 5.- Paramtros de la funcion, en genral van dentro los parentesis definidos una funcion puede no tener
        /// parametros
        /// </summary>
        //private static void ImprimirSaludo()
        //{
        //    Console.WriteLine("Hola Clase de Fundamentos!!!!");
        //}

        /// <summary>
        /// La sobrecarga de funciones permite usar una firma de funcion similar pero que la distingue y que maneja
        /// una funcionalidad diferente
        /// </summary>
        //private static void ImprimirSaludo(string nombreSaludar)
        //{
        //    Console.WriteLine("Hola {0}!!!", nombreSaludar);
        //}

        // funcion con una lista de parametros
        //private static void ImprimirSaludo(string[] listaNombres)
        //{
        //    limiteSuperior = 100;
        //    foreach (string nombre in listaNombres)
        //    {
        //        Console.WriteLine("Hola {0}!!!", nombre);
        //    }
        //}

        //private static void ImprimirSaludo(string[] listaNombres, int cantidad)
        //{
        //    foreach (string nombre in listaNombres)
        //    {
        //        ImprimirSaludo(nombre);
        //    }
        //}

        //private static int[] GenerarCriba(int limite)
        //{
        //    int[] result = new int[limite - 1];
        //    for (int index = 0; index < result.Length; index++)
        //    {
        //        result[index] = index + 2;
        //    }

        //    return result;
        //}

        //private static int[] ProcesarMultiplos(int[] listaCriba)
        //{
        //    int aux = 1000;
        //    for (int pibot = 0; pibot < listaCriba.Length; pibot++)
        //    {
        //        if (listaCriba[pibot] != 0)
        //        { 
        //            for (int index = pibot + 1; index < listaCriba.Length; index++)
        //            {
        //                if (listaCriba[index] != 0 && listaCriba[index] % listaCriba[pibot] == 0)
        //                {
        //                    listaCriba[index] = 0;
        //                }
        //            }
        //        }
        //    }

        //    return listaCriba;
        //}

        //private static void MostrarCriba(int[] listaCriba)
        //{
        //    limiteSuperior = 500;
        //    foreach (int item in listaCriba)
        //    {
        //        if (item != 0)
        //        {
        //            Console.WriteLine(item);
        //        }
        //    }
        //}

        //private static void MostrarNumero(int numero, int limite)
        //{
        //    if (numero <= limite)
        //    {
        //        Console.WriteLine(numero);
        //        MostrarNumero(numero + 1, limite);
        //    }
        //}

        //private static int Factorial(int numero)
        //{
        //    if (numero == 1 || numero == 0)
        //    {
        //        return 1;
        //    }
        //    else 
        //    {
        //        return numero * Factorial(numero - 1);
        //    }
        //}

        //private static int Potencia(int numeroBase, int exponente)
        //{
        //    if (exponente == 1)
        //    {
        //        return numeroBase;
        //    }
        //    else if (exponente == 0)
        //    {
        //        return 1;
        //    }
        //    else 
        //    {
        //        return numeroBase * Potencia(numeroBase, exponente - 1);
        //    }
        //}

        // Invertir un numero de forma recursiva
        //private static int InvertirNumero(int numeroOrigianl, int numeroInvertido)
        //{
        //    if (numeroOrigianl == 0)
        //    {
        //        return numeroInvertido;
        //    }
        //    else 
        //    {
        //        int aux = numeroOrigianl % 10;
        //        numeroInvertido = numeroInvertido * 10 + aux;
        //        return InvertirNumero(numeroOrigianl / 10, numeroInvertido);
        //    }
        //}

        // Fibonacci lineal
        //private static int Fibonacci(int numero1, int numero2, int indiceActual, int indiceLimite)
        //{
        //    if (indiceActual >= indiceLimite)
        //    {
        //        return numero2;
        //    }
        //    else
        //    {
        //        return Fibonacci(numero2, numero1 + numero2, indiceActual + 1, indiceLimite);
        //    }
        //}

        // Fibonacci por back track
        //private static int Fibonacci(int index)
        //{
        //    if (index == 1 || index == 2)
        //    {
        //        return 1;
        //    }
        //    else 
        //    {
        //        return Fibonacci(index - 1) + Fibonacci(index - 2);
        //    }
        //}
    }
}
