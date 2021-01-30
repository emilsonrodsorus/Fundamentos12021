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
            Console.WriteLine("Hola Mundo");
            int numero1 = 2000000;
            double numeroGrande = numero1; // cuando no necesita un tipo en el casting es un Conversión implicita
            double numeroG2 = double.Parse("45000000000");// cuando si necesita un tipo en el casting es un Conversión explicita
            numeroG2 = Convert.ToDouble("85000000000");
            //numero1 = (int)numeroG2; esta forma de cambio de tipo de dato no es recomendable
            //numero1 = Convert.ToInt32(numeroG2); //es mejor usar el convert para controlar o conocer errores
            //numero1 = int.Parse(numeroG2); la funcion Parse funciona mejor con cadenas
            int numero2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
