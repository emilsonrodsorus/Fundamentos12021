using IntroPOO.Clases;
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

            Curso curso1 = new Curso(3);
            curso1.AgregarEstudiante("Carlos Fernandez", "123456ASD", 1);
            curso1.AgregarEspacio(1);
            curso1.AgregarEstudiante("Carlos Fernandez", "123456ASD", 1);
            curso1.AgregarEspacio(1);
        }
    }
}
