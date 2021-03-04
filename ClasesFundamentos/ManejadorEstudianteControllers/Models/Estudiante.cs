using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorEstudianteControllers.Models
{
    public class Estudiante
    {
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
    }
}
