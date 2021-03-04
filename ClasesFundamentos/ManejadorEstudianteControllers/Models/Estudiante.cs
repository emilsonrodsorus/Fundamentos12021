using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorEstudianteControllers.Models
{
    public class Estudiante
    {
        // Object es la parte mas primitiva de donde parten todas las clases y objetos en c#
        //atributos
        internal string ciudad;

        //Constructor
        public Estudiante(string nombre, string codigo)
        {
            NombreEstuciante = nombre;
            CodigoEstuciante = codigo;
        }

        // properties
        public string NombreEstuciante { get; set; }
        public string CodigoEstuciante { get; set; }

        //metodo
        internal void AgregarCiudad(string ciudad)
        {
            this.ciudad = ciudad;
        }

        // otra caracteristica de las funciones es la sobreescritura
        // basicamente permite cambiar la funcionalidad de una funcion predefinida
        public override string ToString()
        {
            return string.Format("{0} -> {1}", NombreEstuciante, CodigoEstuciante);
        }
    }
}
