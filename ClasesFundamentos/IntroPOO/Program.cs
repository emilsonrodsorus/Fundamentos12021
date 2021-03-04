using IntroPOO.Clases;
using IntroPOO.Criba;
using IntroPOO.Triangulo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operaciones operador1 = new Operaciones();
            //int numero1 = Convert.ToInt32(Console.ReadLine());
            //int numero2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(operador1.Suma(numero1, numero2));
            //Console.WriteLine(operador1.Resta(numero1, numero2));
            //Console.WriteLine(operador1.Multiplicacion(numero1, numero2));
            //Console.WriteLine(operador1.Modulo(numero1, numero2));
            //Console.WriteLine(operador1.Division(numero1, numero2));

            //Estudiante est1 = new Estudiante("Carlos Fernandez", "123456ASD", 3);
            //Estudiante est2 = new Estudiante(2);

            //Curso curso1 = new Curso(30, 1);
            //curso1.AgregarProfesor("Juan Antezana", "progra1");
            //curso1.AgregarEstudiante("Carlos Fernandez", "123456ASD");
            //curso1.AgregarEspacio();

            //Curso curso2 = new Curso(30, 2);

            //int limite = Convert.ToInt32(Console.ReadLine());
            //GeneradorCriba generador = new GeneradorCriba();
            //CribaEr criba = new CribaEr(generador.GenerarCriba(limite));
            //ProcesarCriba procesador = new ProcesarCriba();
            //procesador.Procesar(criba);
            //criba.MostrarCriba();

            int altura = Convert.ToInt32(Console.ReadLine());
            char caracter = Console.ReadLine()[0];
            //TrianguloSuperior trianguloSuperior = new TrianguloSuperior(altura, caracter);
            TrianguloInferior trianguloInferior = new TrianguloInferior(altura, caracter);
            //trianguloSuperior.DibujarTrainguloSuperior();
            trianguloInferior.DibujarTrainguloInferior();
            TrianguloInferior.ImprimirNombre();
            //int x = 10;
            //int y = ++x; // y = (x + 1)
            //int z = y++; // z = y ;  y = y+1;

            //int i = 1;
            //i +=1;
            //int[] listaNumeros = { 15, 10, 3, 1, 18, 17, 2, 5, 14 };
            //for (int pibot = 0; pibot < listaNumeros.Length; pibot++)
            //{
            //    for (int index = pibot+1; index < listaNumeros.Length; index++)
            //    {
            //        if (listaNumeros[index] < listaNumeros[pibot])
            //        {
            //            int aux = listaNumeros[index];
            //            listaNumeros[index] = listaNumeros[pibot];
            //            listaNumeros[pibot] = aux;
            //        }
            //    }
            //}

            // Regal de incremento agregar un incremento por teclado
            // y la regla general puede ser 2 count + incremento
            //int incremento = Convert.ToInt32(Console.ReadLine());
            //for (int count = 1; count < 100; count++)
            //{
            //    Console.WriteLine((count * 2) + incremento);
            //}

            //string palabra = Console.ReadLine();
            //MostrarVocales(palabra, 0);
            //string texto = Console.ReadLine();
            //char buscar = Console.ReadLine()[0];
            //char charReplace = Console.ReadLine()[0];
            //string replaceResult = ReplaceFunction(texto, buscar, charReplace);
        }

        //public static string ReplaceFunction(string texto, char buscar, char charReplace)
        //{
        //    string result = string.Empty;
        //    for (int index = 0; index < texto.Length; index++)
        //    {
        //        result = texto[index].Equals(buscar) ? result + charReplace : result + texto[index];
        //    }
        //    return result;
        //}

        //public static void MostrarVocales(string palabra, int index)
        //{
        //    //en caso de switch
        //    //switch (palabra[index])
        //    //{
        //    //    case 'a':
        //    //        Console.WriteLine();
        //    //}
        //    if (index < palabra.Length)
        //    {
        //        if (palabra[index].Equals('a') || palabra[index].Equals('e') ||
        //            palabra[index].Equals('i') || palabra[index].Equals('o') ||
        //            palabra[index].Equals('u')) 
        //        {
        //            Console.WriteLine(palabra[index]);
        //        }
        //        MostrarVocales(palabra, index + 1);
        //    }
        //}
    }
}
