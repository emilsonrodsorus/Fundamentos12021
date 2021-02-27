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
        private string nombreCompleto;
        private string codigoEstudiante;
        private int escolaridad;

        // constructores los parametros de estos constructores no son lo mismo que los atributos de clase
        public Estudiante(string nombreCompleto, string codigoEst, int escolaridad)
        {
            this.nombreCompleto = nombreCompleto;
            codigoEstudiante = codigoEst;
            this.escolaridad = escolaridad;
        }

        public Estudiante(int escolaridad)
        {
            this.escolaridad = escolaridad;
            nombreCompleto = "no definido";
            codigoEstudiante = "no definido";
        }

        public Estudiante(string nombreCompleto)//nivel acceso + nombre + string parameter
        {
            this.escolaridad = 1;
            this.nombreCompleto = nombreCompleto;
            codigoEstudiante = "no definido";
        }

        // no se puede realizar esta sobrecarga de funcion
        //public Estudiante(string codigoEst)//nivel acceso + nombre + string parameter
        //{
        //    this.escolaridad = 1;
        //    this.nombreCompleto = "no definido";
        //    this.codigoEstudiante = codigoEst;
        //}
    }
}
