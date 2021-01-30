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

            //Console.WriteLine("Ingrese el nombre del hermano 1");
            //string nombre1 = Console.ReadLine();
            //Console.WriteLine("Ingrese la edad del hermano 1");
            //int edad1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese el nombre del hermano 2");
            //string nombre2 = Console.ReadLine();
            //Console.WriteLine("Ingrese la edad del hermano 2");
            //int edad2 = Convert.ToInt32(Console.ReadLine());
            //string result = "El hermano 1 se llama {0} y su edad es {1} el hermano 2 se llama {2} y su edad es {3} y la sumatoria de sus edades es {4} ";
            //Console.WriteLine(result, nombre1, edad1, nombre2, edad2, edad1 + edad2);

            //int numero1 = 2500;
            //int numero2 = numero1;
            //Console.WriteLine(numero1);
            //Console.WriteLine(numero2);
            //numero2 = numero2 + 50;
            //Console.WriteLine(numero1);
            //Console.WriteLine(numero2);
            //string texto1 = "Holla Mundo!!";
            //string texto2 = texto1;
            //Console.WriteLine(texto1);
            //Console.WriteLine(texto2);
            //texto2 = texto2 + " y Hola a Todos en fundamentos!!!";
            //Console.WriteLine(texto1);
            //Console.WriteLine(texto2);

            //StringBuilder strB1 = new StringBuilder("Hola Mundo!!!");
            //StringBuilder strB2 = strB1;
            //Console.WriteLine(strB1);
            //Console.WriteLine(strB2);
            //strB2.Append(" Y hola a todos en fundamentos!!!!");
            //Console.WriteLine(strB1);
            //Console.WriteLine(strB2);

            //bool valorVerdad = 2 > 5;

            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //if (numero1 > numero2) 
            //{
            //    Console.WriteLine("el numero {0} es el mayor", numero1);
            //}
            //if (numero2 > numero1)
            //{
            //    Console.WriteLine("el numero {0} es el mayor", numero2);
            //}

            //Console.WriteLine("Ingrese la edad del primer hermano");
            //int edad1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese la edad del segundo hermano");
            //int edad2 = Convert.ToInt32(Console.ReadLine());
            //int diferencia = 0;
            //string texto = "el mayor es {0} con {1} y el menor es {2} con {3} y la diferencia de sus edades es de {4} años";

            //if (edad1 > edad2)
            //{
            //    diferencia = edad1 - edad2;
            //    Console.WriteLine(texto, "primer hermano", edad1, "segundo hermnao", edad2, diferencia);
            //}
            //if (edad2 > edad1)
            //{
            //    diferencia = edad2 - edad1;
            //    Console.WriteLine(texto, "segundo hermano", edad2, "primer hermnao", edad1, diferencia);
            //}
            // 10/3 = 3           10%3=1    4%2=0
            //int numero1 = 55;
            //int numero2 = 10;

            //if (numero1 > numero2)
            //{
            //    if (numero1 % numero2 == 0)
            //    {
            //        Console.WriteLine("El numero1 es mayor y es multiplo del numero2");
            //    }
            //}

            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            int numero3 = Convert.ToInt32(Console.ReadLine());

            //if (numero1 > numero2) 
            //{
            //    if (numero1 > numero3)
            //    {
            //        if (numero2 > numero3)
            //        {
            //            Console.WriteLine("El mayor es el numero 1, el del medio es el numero 2 y el menor el numero 3");
            //        }
            //        if (numero3 > numero2)
            //        {
            //            Console.WriteLine("El mayor es el numero 1, el del medio es el numero 3 y el menor el numero 2");
            //        }
            //    }
            //}
            //if (numero2 > numero1)
            //{
            //    if (numero2> numero3)
            //    {
            //        if (numero1 > numero3)
            //        {
            //            Console.WriteLine("El mayor es el numero 1, el del medio es el numero 2 y el menor el numero 3");
            //        }
            //        if (numero3 > numero1)
            //        {
            //            Console.WriteLine("El mayor es el numero 1, el del medio es el numero 3 y el menor el numero 2");
            //        }
            //    }
            //}
            //if (numero3 > numero1)
            //{
            //    if (numero3 > numero2)
            //    {
            //        if (numero2 > numero1)
            //        {
            //            Console.WriteLine("El mayor es el numero 1, el del medio es el numero 2 y el menor el numero 3");
            //        }
            //        if (numero3 > numero2)
            //        {
            //            Console.WriteLine("El mayor es el numero 1, el del medio es el numero 3 y el menor el numero 2");
            //        }
            //    }
            //}

            //operadores logicos && (y logico) || (o logico)
            if (numero1 > numero2 && numero1 > numero3)
            {
                if (numero2 > numero3)
                {
                    Console.WriteLine("El mayor es el numero 1, el del medio es el numero 2 y el menor el numero 3");
                }
                if (numero3 > numero2)
                {
                    Console.WriteLine("El mayor es el numero 1, el del medio es el numero 3 y el menor el numero 2");
                }
            }
            if (numero2 > numero1 && numero2 > numero3)
            {
                if (numero1 > numero3)
                {
                    Console.WriteLine("El mayor es el numero 2, el del medio es el numero 1 y el menor el numero 3");
                }
                if (numero3 > numero1)
                {
                    Console.WriteLine("El mayor es el numero 2, el del medio es el numero 3 y el menor el numero 1");
                }
            }
            if (numero3 > numero1 && numero3 > numero2)
            {
                if (numero1 > numero2)
                {
                    Console.WriteLine("El mayor es el numero 3, el del medio es el numero 1 y el menor el numero 2");
                }
                if (numero2 > numero1)
                {
                    Console.WriteLine("El mayor es el numero 3, el del medio es el numero 2 y el menor el numero 1");
                }
            }

        }
    }
}
