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

        // contructor
        public Curso(int cantidad)
        {
            listaEstudiantes = new Estudiante[cantidad];
        }

        // metodos
        public void AgregarEstudiante(string nombreCompleto, string codigoEst, int escolaridad)
        {
            Estudiante est1 = new Estudiante(nombreCompleto, codigoEst, escolaridad);
            listaEstudiantes[ObtenerIndiceEspacio()] = est1;
        }

        public void AgregarEspacio(int escolaridad)
        {
            try
            {
                Estudiante est1 = new Estudiante(escolaridad);
                listaEstudiantes[ObtenerIndiceEspacio()] = est1;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("El curso no tiene mas cupos");
            }
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
