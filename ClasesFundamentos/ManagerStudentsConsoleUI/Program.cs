using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManejadorEstudianteControllers.Models;
using ManejadorEstudianteControllers.Managers;

namespace ManagerStudentsConsoleUI
{
    class Program
    {
        static EstudianteManager manager = new EstudianteManager();

        static void Main(string[] args)
        {
            //Estudiante estudiante1 = new Estudiante("Mateo Fernandez", "123ASD");
            while (true)
            {
                Console.WriteLine("Elija una funcion");
                Console.WriteLine("1 .- Agregar Estudiante");
                Console.WriteLine("2 .- MostrarLista Estudiantes");
                int select = Convert.ToInt32(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        AgregarEstudianteUI();
                        break;
                    case 2:
                        MostrarEstudiantes();
                        break;
                }
            }
        }

        public static void AgregarEstudianteUI()
        {
            Console.WriteLine("Ingresar nombre completo estudiante");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingresar codigo completo estudiante");
            string codigo = Console.ReadLine();
            manager.AgregarEstudiante(nombre, codigo);
        }

        public static void MostrarEstudiantes()
        {
            foreach (Estudiante estudiante in manager.ListaEstudiantes)
            {
                Console.WriteLine(estudiante.NombreEstuciante);
            }
        }
    }
}
