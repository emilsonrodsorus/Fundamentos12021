using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO.Clases
{
    public class Curso
    {
        // atributos de clase
        Estudiante[] listaEstudiantes;
        Profesor profesorCurso;
        //int anioEscolaridad;


        // contructor
        public Curso(int cantidad, int anioEscolaridad)
        {
            listaEstudiantes = new Estudiante[cantidad];
            AnioEscolaridad = anioEscolaridad;
        }


        //properties
        public int AnioEscolaridad { get; set; }


        // metodos
        public void AgregarEstudiante(string nombreCompleto, string codigoEst)
        {
            Estudiante est1 = new Estudiante(nombreCompleto, codigoEst, AnioEscolaridad);
            listaEstudiantes[ObtenerIndiceEspacio()] = est1;
        }

        public void AgregarEspacio()
        {
            try
            {
                Estudiante est1 = new Estudiante(AnioEscolaridad);
                listaEstudiantes[ObtenerIndiceEspacio()] = est1;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("El curso no tiene mas cupos");
            }
        }

        public void AgregarProfesor(string nombreCompleto, string materia)
        {
            profesorCurso = new Profesor(nombreCompleto, materia);
        }

        private int ObtenerIndiceEspacio()
        {
            for (int index = 0; index < listaEstudiantes.Length; index++)
            {
                if (listaEstudiantes[index] == null)
                {
                    return index;
                }
            }
            return -1;
        }
    }
}
