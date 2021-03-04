using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroPOO.Clases
{
    public class Profesor
    {
        private string nombreCompleto;

        public Profesor(string nombreCompleto, string materia)
        {
            if(materia.Length < 150)
            {
                Materia = materia;
            }
            this.nombreCompleto = nombreCompleto;
        }

        // Properties son los metodos que permiten leer y escribir los atributos de clase
        // pero ademasa nos permiten englobar los atributos de clase en su deficion
        // en general las propiedades son publicas

        // este propertie nos permite leer y escribir el attibuto nombre completo
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set 
            {
                if (value.Length < 150)
                {
                    nombreCompleto = value;
                }
            }
        }

        // este propertie permite ademas \englobar el attributo materia
        public string Materia { get; set; }

    }
}
