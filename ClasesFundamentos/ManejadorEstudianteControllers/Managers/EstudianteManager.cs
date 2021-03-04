using ManejadorEstudianteControllers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorEstudianteControllers.Managers
{
    public class EstudianteManager
    {
        //ejemplo del uso del campo internal
        //public void EstudianteCheck()
        //{
        //    Estudiante est1 = new Estudiante("Carlos Arispe", "456ERT");
        //    est1.ciudad = "Cochabamba";
        //}

        // atributos
        List<Estudiante> listaEstudiantes;

        // COnstructor
        public EstudianteManager()
        {
            listaEstudiantes = new List<Estudiante>();
        }

        //Properties
        public List<Estudiante> ListaEstudiantes { get { return listaEstudiantes; } }

        //metodo

        public void AgregarEstudiante(string nombre, string codigo)
        {
            Estudiante newEstudiante = new Estudiante(nombre, codigo);
            listaEstudiantes.Add(newEstudiante);
        }

    }
}
