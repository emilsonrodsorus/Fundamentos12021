using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFundamentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola Mundo");
            //int numero1 = 2000000;
            //double numeroGrande = numero1; // cuando no necesita un tipo en el casting es un Conversión implicita
            //double numeroG2 = double.Parse("45000000000");// cuando si necesita un tipo en el casting es un Conversión explicita
            //numeroG2 = Convert.ToDouble("85000000000");
            //numero1 = (int)numeroG2; esta forma de cambio de tipo de dato no es recomendable
            //numero1 = Convert.ToInt32(numeroG2); //es mejor usar el convert para controlar o conocer errores
            //numero1 = int.Parse(numeroG2); la funcion Parse funciona mejor con cadenas
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese el primer numero");
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese el segundo numero");
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int sumatoria = numero1 + numero2;
            //int multiplicacion = numero1 * numero2;
            //Console.WriteLine("La suma de {0} + {1} = {2} y la multiplicacion es {3} * {4} = {5}",
            //    numero1, numero2, sumatoria, numero1, numero2, multiplicacion );

            Console.WriteLine("Ingrese el nombre del hermano 1");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del hermano 1");
            int edad1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del hermano 2");
            string nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese la edad del hermano 2");
            int edad2 = Convert.ToInt32(Console.ReadLine());
            string result = "El hermano 1 se llama {0} y su edad es {1} el hermano 2 se llama {2} y su edad es {3} y la sumatoria de sus edades es {4} ";
            Console.WriteLine(result, nombre1, edad1, nombre2, edad2, edad1 + edad2);
        }
    }
}
