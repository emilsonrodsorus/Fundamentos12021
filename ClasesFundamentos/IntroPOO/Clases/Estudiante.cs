using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO.Clases
{
    public class Estudiante
    {
        // atributos de clase
        // si defino propiedades en la seccion de los properties puedo englobar en ellos mis attributos de clase
        //private string nombreCompleto;
        //private string codigoEstudiante;
        //private int escolaridad;


        // constructores los parametros de estos constructores no son lo mismo que los atributos de clase
        public Estudiante(string nombreCompleto, string codigoEst, int escolaridad)
        {
            NombreCompleto = nombreCompleto;
            CodigoEstudiante = codigoEst;
            Escolaridad = escolaridad;
        }

        public Estudiante(int escolaridad)
        {
            Escolaridad = escolaridad;
            NombreCompleto = "no definido";
            CodigoEstudiante = "no definido";
        }

        public Estudiante(string nombreCompleto)//nivel acceso + nombre + string parameter
        {
            Escolaridad = 1;
            NombreCompleto = nombreCompleto;
            CodigoEstudiante = "no definido";
        }

        // no se puede realizar esta sobrecarga de funcion
        //public Estudiante(string codigoEst)//nivel acceso + nombre + string parameter
        //{
        //    this.escolaridad = 1;
        //    this.nombreCompleto = "no definido";
        //    this.codigoEstudiante = codigoEst;
        //}



        // Properties o propiedades

        public string NombreCompleto { get; set; }
        public string CodigoEstudiante { get; set; }
        public int Escolaridad { get; set; }

    }
}
