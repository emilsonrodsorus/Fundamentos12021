﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesFundamentos
{
    class Program
    {
        public enum Dias
        {
            Domingo = 1,
            Lunes,
            Martes,
            Miercoles,
            Jueves,
            Viernes,
            Sabado
        }
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

            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int numero3 = Convert.ToInt32(Console.ReadLine());

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
            //if (numero1 > numero2 && numero1 > numero3)
            //{
            //    if (numero2 > numero3)
            //    {
            //        Console.WriteLine("El mayor es el numero 1, el del medio es el numero 2 y el menor el numero 3");
            //    }
            //    if (numero3 > numero2)
            //    {
            //        Console.WriteLine("El mayor es el numero 1, el del medio es el numero 3 y el menor el numero 2");
            //    }
            //}
            //if (numero2 > numero1 && numero2 > numero3)
            //{
            //    if (numero1 > numero3)
            //    {
            //        Console.WriteLine("El mayor es el numero 2, el del medio es el numero 1 y el menor el numero 3");
            //    }
            //    if (numero3 > numero1)
            //    {
            //        Console.WriteLine("El mayor es el numero 2, el del medio es el numero 3 y el menor el numero 1");
            //    }
            //}
            //if (numero3 > numero1 && numero3 > numero2)
            //{
            //    if (numero1 > numero2)
            //    {
            //        Console.WriteLine("El mayor es el numero 3, el del medio es el numero 1 y el menor el numero 2");
            //    }
            //    if (numero2 > numero1)
            //    {
            //        Console.WriteLine("El mayor es el numero 3, el del medio es el numero 2 y el menor el numero 1");
            //    }
            //}

            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int numero3 = Convert.ToInt32(Console.ReadLine());

            //if (numero1 > numero2 && numero1 > numero3)
            //{
            //    if (numero2 > numero3)
            //    {
            //        Console.WriteLine("El mayor es el numero 1, el del medio es el numero 2 y el menor el numero 3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El mayor es el numero 1, el del medio es el numero 3 y el menor el numero 2");
            //    }
            //}
            //else if (numero2 > numero1 && numero2 > numero3)
            //{
            //    if (numero1 > numero3)
            //    {
            //        Console.WriteLine("El mayor es el numero 2, el del medio es el numero 1 y el menor el numero 3");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El mayor es el numero 2, el del medio es el numero 3 y el menor el numero 1");
            //    }
            //}
            //else
            //{
            //    if (numero1 > numero2)
            //    {
            //        Console.WriteLine("El mayor es el numero 3, el del medio es el numero 1 y el menor el numero 2");
            //    }
            //    if (numero2 > numero1)
            //    {
            //        Console.WriteLine("El mayor es el numero 3, el del medio es el numero 2 y el menor el numero 1");
            //    }
            //}
            //int lado1 = Convert.ToInt32(Console.ReadLine());
            //int lado2 = Convert.ToInt32(Console.ReadLine());
            //int lado3 = Convert.ToInt32(Console.ReadLine());

            //if (lado1 == lado2 && lado1 == lado3 && lado2 == lado3)
            //{
            //    Console.WriteLine("Es un triangulo Equilatero");
            //}
            //else if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
            //{
            //    Console.WriteLine("Es un triangulo Escaleno");
            //}
            //else 
            //{
            //    Console.WriteLine("Es un triangulo Isosceles");
            //}

            //int angulo1 = Convert.ToInt32(Console.ReadLine());
            //int angulo2 = Convert.ToInt32(Console.ReadLine());
            //int angulo3 = Convert.ToInt32(Console.ReadLine());

            //if (angulo1 + angulo2 + angulo3 == 180)
            //{
            //    if (angulo1 == 90 || angulo2 == 90 || angulo3 == 90)
            //    {
            //        Console.WriteLine("Es un triangulo rectangulo");
            //    }
            //    else if (angulo1 > 90 || angulo2 > 90 || angulo3 > 90)
            //    {
            //        Console.WriteLine("Es un triangulo obtusangulo");
            //    }
            //    else 
            //    {
            //        Console.WriteLine("Es un triangulo acutangulo");
            //    }
            //}
            //else 
            //{
            //    Console.WriteLine("Los angulos internos no representan un triangulo");
            //}

            //int cantidad = Convert.ToInt32(Console.ReadLine());
            //double costoUnidad = Convert.ToDouble(Console.ReadLine());
            //double costoTotal = cantidad * costoUnidad;
            //double descuento = 0;
            //if (cantidad > 10 && cantidad <= 25)
            //{
            //    descuento = 0.03;
            //}
            //else if (cantidad > 25 && cantidad < 50)
            //{
            //    descuento = 0.05;
            //}
            //else if (cantidad >= 50) 
            //{
            //    descuento = 0.07;
            //}
            //Console.WriteLine("El costo total es de {0} y el costo con descuento es de {1} se aplica un descuento de {2}",
            //    costoTotal, costoTotal - (costoTotal*descuento), descuento * 100);

            //char operador = Console.ReadLine()[0];
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //int result = 0;
            //switch (operador)
            //{
            //    case '+':
            //        Console.WriteLine("Estamos trabajando con una suma");
            //        result = numero1 + numero2;
            //        break;
            //    case '-':
            //        Console.WriteLine("Estamos trabajando con una resta");
            //        result = numero1 - numero2;
            //        break;
            //    case '*':
            //        Console.WriteLine("Estamos trabajando con una multiplicacion");
            //        result = numero1 * numero2;
            //        break;
            //    case '%':
            //        Console.WriteLine("Estamos trabajando con un modulo");
            //        result = numero1 % numero2;
            //        break;
            //    case '/':
            //        Console.WriteLine("Estamos trabajando con una division entera");
            //        result = numero1 / numero2;
            //        break;
            //    default:
            //        Console.WriteLine("No es un operador valido");
            //        return;
            //}
            //Console.WriteLine("El resultado del operador es {0}", result);

            //int dia = Convert.ToInt32(Console.ReadLine());
            //switch (dia) 
            //{
            //    case (int)Dias.Domingo:
            //        Console.WriteLine("Es dia Domingo");
            //        break;
            //    case (int)Dias.Lunes:
            //        Console.WriteLine("Es dia Lunes");
            //        break;
            //    case (int)Dias.Martes:
            //        Console.WriteLine("Es dia Martes");
            //        break;
            //    case (int)Dias.Miercoles:
            //        Console.WriteLine("Es dia Miercoles");
            //        break;
            //    case (int)Dias.Jueves:
            //        Console.WriteLine("Es dia Jueves");
            //        break;
            //    case (int)Dias.Viernes:
            //        Console.WriteLine("Es dia Viernes");
            //        break;
            //    case (int)Dias.Sabado:
            //        Console.WriteLine("Es dia Sabado");
            //        break;
            //    default:
            //        Console.WriteLine("No es un dia de la semana");
            //        return;
            //}

            // matrices o listas son arreglos estaticos o sea que necesitan un tamaño 
            // int[] listaNumeros = new int[10];
            //listaNumeros[3] = 25;
            // int[] listaNumeros2 = new int[] { 5, 7, 9, 10, 13, 11 };
            //int[] listaNumeros3 = { 10, 11, 25, 5, 3, 6, 8, 9 };
            //Console.WriteLine(listaNumeros[3]);
            //Console.WriteLine(listaNumeros3.Length);
            //// los string tambien son arreglos de caracteres
            //string texto = "Hello Mundo de la programacion!!!";
            //Console.WriteLine(texto.Length);
            //Console.WriteLine(texto[8]);
            //Console.WriteLine(texto[texto.Length - 1]);

            //string texto = Console.ReadLine();
            //int midIndex = texto.Length / 2;
            //Console.WriteLine("La primera letra del texto es {0}", texto[0]);
            //Console.WriteLine("La ultima letra del texto es {0}", texto[texto.Length - 1]);
            //Console.WriteLine("La letra del medio del texto es {0}", texto[midIndex]);

            //Console.WriteLine("El primer numero de la lista es {0}", listaNumeros2[0]);
            //Console.WriteLine("El ultimo numero de la lista es {0}", listaNumeros2[listaNumeros2.Length - 1]);
            //Console.WriteLine("El numero del medio de la lista es {0}", listaNumeros2[listaNumeros2.Length / 2]);


            // si intentamos acceder con un indice que no corresponde lanzara un error de prorgamacion
            // Console.WriteLine(texto[texto.Length]);

            //// 0 0 0 0 0
            //// 0 0 0 0 0
            //// 0 0 0 0 0

            // int[,] listaNumerosBid = new int[3,5];
            //listaNumerosBid[1, 3] = 254;
            ////5,10,35
            ////8,25,123
            //int[,] listaNumerosBid2 = { { 5,10,35 } , { 8,25,123} };

            //int[][] listaJaggedNumeros = new int[5][];
            //listaJaggedNumeros[0] = new int[20];
            //listaJaggedNumeros[3] = new int[]{ 2,6,12,11,13 };

            //int[] listaNotas = { 90, 85, 100, 100, 95, 90, 98 };

            //int count = 0;
            //while (count <= 5) 
            //{
            //    Console.WriteLine(count);
            //    count++;// count = count + 1
            //}

            //int index = 0;
            //while (index < listaNotas.Length)
            //{
            //    Console.WriteLine(listaNotas[index]);
            //    index++;// index = index + 1
            //}
            //int[] listaNotas = { 95, 100, 85, 95, 90, 100, 98, 99, 97, 100 }; 


            //int[] listaNotas = new int[10];
            //int index = 0;

            //while (index < listaNotas.Length)
            //{
            //    listaNotas[index] = Convert.ToInt32(Console.ReadLine());
            //    index++;
            //}

            //index = 0;
            //int sumatoria = 0;
            //while (index < listaNotas.Length)
            //{
            //    sumatoria = sumatoria + listaNotas[index];
            //    index++;
            //}

            //Console.WriteLine("La sumatoria total es {0} y el promedio de notas es {1}",
            //    sumatoria , sumatoria / listaNotas.Length);

            //checkando que sean pares o multiplos de 2
            //int limite = Convert.ToInt32(Console.ReadLine());
            //int count = 1;
            //while (count <= limite)
            //{
            //    if (count % 2 == 0)
            //    {
            //        Console.WriteLine(count);
            //    }
            //    count++;
            //}
            //int limite = Convert.ToInt32(Console.ReadLine());
            //int count = 2;
            //while (count <= limite)
            //{
            //    Console.WriteLine(count);
            //    count = count + 2;
            //}

            //int limite = Convert.ToInt32(Console.ReadLine());
            //int count = 1;
            //int multiplo = Convert.ToInt32(Console.ReadLine());
            //while (count <= limite)
            //{
            //    if (count % multiplo == 0)
            //    {
            //        Console.WriteLine(count);
            //    }
            //    count++;
            //}

            // quiero mostrar todos los digitos d eun numero
            // 8523
            //2
            //5
            //8
            //int numero = Convert.ToInt32(Console.ReadLine());
            //while (numero > 0)
            //{
            //    Console.WriteLine(numero % 10);
            //    numero = numero / 10;
            //}

            //int numero = Convert.ToInt32(Console.ReadLine());
            //int resto;
            //while (numero > 0)
            //{
            //    resto = numero % 10;
            //    numero = numero * 10 + resto;
            //    numero /= 10;
            //}
            //Console.WriteLine(numero);

            //int numero = Convert.ToInt32(Console.ReadLine());
            //int numeroOr = numero;
            //int invertido = 0;
            //while (numero > 0)
            //{
            //    invertido = invertido * 10 + numero % 10;
            //    numero = numero / 10;
            //}

            //// int numeroPar = numero % 2 == 0 ? numero : numero + 1;

            //Console.WriteLine("El numero {0} y su invertido {1} {2}",
            //    numeroOr, invertido, numeroOr == invertido ? "es palindromo" : "no es palindromo");

            // split parte de las cadenas
            // programa que me permita ver las palabras de una frase

            //string frase = Console.ReadLine();
            //string[] listaPalabras = frase.Split(' ');
            //int index = 0;
            //while (index < listaPalabras.Length)
            //{
            //    Console.WriteLine(listaPalabras[index]);
            //    index++;
            //}

            //string numeros = Console.ReadLine();
            //char separador = Console.ReadLine()[0];
            //string[] listaNumeros = numeros.Split(separador);
            //int index = 0;
            //while (index < listaNumeros.Length)
            //{
            //    Console.WriteLine(listaNumeros[index]);
            //    index++;
            //}

            //int numero = Convert.ToInt32(Console.ReadLine());
            //int numOriginal = numero;
            //int factorial = 1;
            //while (numero > 0)
            //{
            //    factorial = factorial * numero;
            //    numero--; // numero = numero - 1
            //}

            //Console.WriteLine("El factorial de {0} es {1}", numOriginal, factorial);

            //int numeroBase = Convert.ToInt32(Console.ReadLine());
            //int exponente = Convert.ToInt32(Console.ReadLine());
            //int exponenteOr = exponente;
            //int resultado = 1;
            //while (exponente > 0)
            //{
            //    resultado = resultado * numeroBase;
            //    exponente--;
            //}
            //Console.WriteLine("El numero {0} elevado al {1} es {2}", numeroBase, exponenteOr, resultado);

            //string texto;
            //do
            //{
            //    texto = Console.ReadLine();
            //    Console.WriteLine("El nuevo texto es {0}", texto);
            //} while (!texto.Equals("salir"));

            //string texto = Console.ReadLine();
            //for (int index = 0; index < texto.Length ; index++)
            //{
            //    Console.WriteLine(texto[index]);
            //}

            //int tamanioMat = 3;
            //int[,] matrizBi = new int[tamanioMat, tamanioMat];
            //// leer datos para la matriz
            //int seed = Environment.TickCount;
            //Random random = new Random(seed);
            //for (int fila = 0; fila < tamanioMat; fila++)
            //{
            //    for (int columna = 0; columna < tamanioMat; columna++)
            //    {
            //        int value = random.Next(0, 9);
            //        Console.WriteLine(value);
            //        //matrizBi[fila, columna] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //// mostrar matriz

            //for (int fila = 0; fila < tamanioMat; fila++)
            //{
            //    for (int columna = 0; columna < tamanioMat; columna++)
            //    {
            //        //Console.Write(matrizBi[fila, columna]);

            //    }

            //    Console.WriteLine();
            //}

            //Console.WriteLine("Ingrese el tamaño de la matriz");
            //int tamanioMat = Convert.ToInt32(Console.ReadLine());
            //int[,] matrizBi = new int[tamanioMat, tamanioMat];
            //// crear datos para la matriz
            //int seed = Environment.TickCount;
            //Random random = new Random(seed);
            //for (int fila = 0; fila < tamanioMat; fila++)
            //{
            //    for (int columna = 0; columna < tamanioMat; columna++)
            //    {
            //        matrizBi[fila, columna] = random.Next(0, 9);
            //    }
            //}

            //// Seleccion de que matriz ver
            //int tipoMatriz = 0;
            //do
            //{
            //    Console.WriteLine("Ingrese que tipo de matriz quiere ver");
            //    Console.WriteLine("1 matriz completa");
            //    Console.WriteLine("2 Diagonales de la matriz");
            //    Console.WriteLine("3 Contorno de la matriz");
            //    Console.WriteLine("4 salir");
            //    tipoMatriz = Convert.ToInt32(Console.ReadLine());
            //    switch (tipoMatriz) 
            //    {
            //        case 1:
            //            for (int fila = 0; fila < tamanioMat; fila++)
            //            {
            //                for (int columna = 0; columna < tamanioMat; columna++)
            //                {
            //                    Console.Write("{0} ", matrizBi[fila, columna]);
            //                }

            //                Console.WriteLine();
            //            }
            //            break;
            //        case 2:
            //            for (int fila = 0; fila < tamanioMat; fila++)
            //            {
            //                for (int columna = 0; columna < tamanioMat; columna++)
            //                {
            //                    //if (fila == columna || tamanioMat - columna - 1 == fila)
            //                    //{
            //                    //    Console.Write("{0} ", matrizBi[fila, columna]);
            //                    //}
            //                    //else 
            //                    //{
            //                    //    Console.Write("  ");
            //                    //}

            //                    // con operadores ternarios
            //                    string textoMostrar = fila == columna || tamanioMat - columna - 1 == fila
            //                        ? string.Format("{0} ", matrizBi[fila, columna])
            //                        : "  ";
            //                    Console.Write(textoMostrar);
            //                }
            //                Console.WriteLine();
            //            }
            //            break;
            //        case 3:
            //            for (int fila = 0; fila < tamanioMat; fila++)
            //            {
            //                for (int columna = 0; columna < tamanioMat; columna++)
            //                {
            //                    //if (fila == 0 || columna == 0 ||
            //                    //    fila == tamanioMat - 1 || columna == tamanioMat - 1)
            //                    //{
            //                    //    Console.Write("{0} ", matrizBi[fila, columna]);
            //                    //}
            //                    //else 
            //                    //{
            //                    //    Console.Write("  ");
            //                    //}

            //                    // se puede cambiar la anterior logica por...
            //                    string textoMostrar = fila == 0 || columna == 0 ||
            //                        fila == tamanioMat - 1 || columna == tamanioMat - 1 
            //                        ? string.Format("{0} ", matrizBi[fila, columna]) : "  ";
            //                    Console.Write(textoMostrar);
            //                }

            //                Console.WriteLine();
            //            }
            //            break;
            //    }
            //} while (tipoMatriz != 4);

            //int[] listaNumeros = { 1, 2, 9, 10, 25, 23, 10, 11 };
            //int suma = 0;
            //// tipo de dato,  nombre de variable,    in,     la lista que quiero recorrer
            //foreach (int numero in listaNumeros)
            //{
            //    // numero = numero + 2; esta sintaxis no es posible
            //    suma = suma + numero;
            //}
            //Console.WriteLine("La sumatoria de los numeros da {0} y el promedio de los numeros es {1}",
            //    suma, suma / listaNumeros.Length);

            // Criba

            // esta parte genera la criba
            //int limite = Convert.ToInt32(Console.ReadLine());
            //int[] criba = new int[limite - 1];
            //for (int index = 0; index < criba.Length; index++)
            //{
            //    criba[index] = index + 2;
            //}

            //// recorrer con pibot e indice
            //for (int pibot = 0; pibot < criba.Length; pibot++)
            //{
            //    if (criba[pibot] != 0)
            //    {
            //        for (int index = pibot + 1; index < criba.Length; index++)
            //        {
            //            if (criba[index] != 0 && criba[index] % criba[pibot] == 0)
            //            {
            //                criba[index] = 0;
            //            }
            //        }
            //    }
            //}

            ////mostrar el resultado
            //foreach (int primo in criba)
            //{
            //    if (primo != 0)
            //    {
            //        Console.WriteLine(primo);
            //    }
            //}

            //fibonacci en un indice requerido

            //int index = Convert.ToInt32(Console.ReadLine());
            //int n1 = 0;
            //int n2 = 1;
            //int currentIndex = 2;
            //while (currentIndex < index)
            //{
            //    int aux = n2;
            //    n2 = n2 + n1;
            //    n1 = aux;
            //    currentIndex++;
            //}

            //Console.WriteLine(n2);
            //int num1 = 50;
            //int num2 = 25;
            //while (num1 > num2)
            //{
            //    num1++;
            //}

            //do
            //{

            //} while (num2 < num1);

            //int index = 0; // su variable de control se puede declarar fuera del for
            //for (; index < num1; index = index + 2)// la regla de cambio de la variable de control puede ser cualquier cambio que necesitemos
            //{

            //}

            //int[] listaNumeros = { 5, 10, 12, 1, 13, 14, 15 };
            //foreach (int numero in listaNumeros)
            //{

            //}

            // paso uno ya podemos extraer cada palabra del texto
            //string texto = Console.ReadLine();
            //string aproxBusqueda = Console.ReadLine();
            //string[] listaPalabras = texto.Split(' ');
            //foreach (string palabra in listaPalabras)
            //{
            //    for (int index = 0; index < palabra.Length; index++) // index++ similar  index = index + 1
            //    {
            //        if (palabra[index].Equals(aproxBusqueda[0]) &&
            //            palabra.Length - index >= aproxBusqueda.Length)
            //        {
            //            //substring
            //            string subCadena = palabra.Substring(index, aproxBusqueda.Length);
            //            if (subCadena.Equals(aproxBusqueda))
            //            {
            //                Console.WriteLine(palabra);
            //            }
            //        }
            //    }
            //}

            // Logica usando concatenacion de cadenas
            //int altura = Convert.ToInt32(Console.ReadLine());
            //string caracter = "*";
            //for (int count = 1; count <= altura; count++)
            //{
            //    Console.WriteLine(caracter);
            //    caracter = caracter + "*";
            //}

            // Logica para dibujar triangulo rectangulo

            //int altura = Convert.ToInt32(Console.ReadLine());
            //for (int fila = 1; fila <= altura; fila++)
            //{
            //    for (int columna = 1; columna <= fila; columna++)
            //    {
            //        Console.Write('*');
            //    }
            //    Console.WriteLine();
            //}

            //Logica usando filas y columnas para el triangulo equilatero
            //int altura = Convert.ToInt32(Console.ReadLine());
            //string simbolo = "$";
            //for (int fila = 1; fila <= altura; fila++)
            //{
            //    for (int espBlanco = 1; espBlanco <= altura - fila; espBlanco++)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int columna = 1; columna <= (2 *fila) - 1; columna++)
            //    {
            //        Console.Write(simbolo);
            //    }
            //    Console.WriteLine();
            //}

            // Logica por filas y columnas para dibujar un rombo
            //int altura = Convert.ToInt32(Console.ReadLine());
            //string simbolo = "#";
            //for (int fila = 1; fila <= altura; fila++)
            //{
            //    for (int espBlanco = 1; espBlanco <= altura - fila; espBlanco++)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int columna = 1; columna <= (2 * fila) - 1; columna++)
            //    {
            //        Console.Write(simbolo);
            //    }
            //    Console.WriteLine();
            //}
            //for (int fila = altura - 1; fila > 0 ; fila--)
            //{
            //    for (int espBlanco = 1; espBlanco <= altura - fila; espBlanco++)
            //    {
            //        Console.Write(' ');
            //    }
            //    for (int columna = 1; columna <= (2 * fila) - 1; columna++)
            //    {
            //        Console.Write(simbolo);
            //    }
            //    Console.WriteLine();
            //}

            // ordenamiento por fuerza bruta
            //int[] listaNUmeros = { 5, 9, 3, 12, 10, 100, 5, 7, 8, 9, 4, 10, 12, 13 };
            //// {3, 4, 5, 5, 8, 9, 9, 10, 7, 12, 100, 10, 12, 13 }
            //for (int pibot = 0; pibot < listaNUmeros.Length; pibot++)
            //{
            //    for (int index = pibot + 1; index < listaNUmeros.Length; index++)
            //    {
            //        if (listaNUmeros[index] < listaNUmeros[pibot])
            //        {
            //            int aux = listaNUmeros[pibot];
            //            listaNUmeros[pibot] = listaNUmeros[index];
            //            listaNUmeros[index] = aux;
            //        }
            //    }
            //}

            //foreach (int numero in listaNUmeros)
            //{
            //    Console.WriteLine(numero);
            //}

            // algoritmo de burbuja
            //int[] listaNUmeros = { 5, 9, 3, 12, 10, 100, 5, 7, 8, 9, 4, 10, 12, 13 };
            //int iteracion = 0;
            //bool permuta = true;
            //int indexActual;

            //while (permuta)
            //{
            //    permuta = false;
            //    iteracion++;

            //    for (indexActual = 0; indexActual < listaNUmeros.Length - iteracion; indexActual++)
            //    {
            //        if (listaNUmeros[indexActual] > listaNUmeros[indexActual + 1])
            //        {
            //            permuta = true;
            //            int aux = listaNUmeros[indexActual];
            //            listaNUmeros[indexActual] = listaNUmeros[indexActual + 1];
            //            listaNUmeros[indexActual + 1] = aux;
            //        }
            //    }
            //}

            int[] listaNUmeros = { 5, 9, 3, 12, 10, 100, 5, 7, 8, 9, 4, 10, 12, 13 };
            bool permuta;
            int fin = listaNUmeros.Length - 1;
            int inicio = 1;
            int indexAcutal = 0;
            int direccion = 1;
            do
            {
                permuta = false;

                while ((direccion == 1 && indexAcutal < fin) || (direccion == -1 && indexAcutal > inicio))
                {
                    indexAcutal = indexAcutal + direccion;
                    if (listaNUmeros[indexAcutal] < listaNUmeros[indexAcutal - 1])
                    {
                        int aux = listaNUmeros[indexAcutal];
                        listaNUmeros[indexAcutal] = listaNUmeros[indexAcutal - 1];
                        listaNUmeros[indexAcutal - 1] = aux;
                        permuta = true;
                    }
                }

                if (direccion == 1)
                {
                    fin--;
                }
                else 
                {
                    inicio++;
                }
                direccion = -direccion;
            } while (permuta);
        }
    }
}
