using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase.Model
{
    public class Asignaturas
    {
        public string Asignatura { get; set; }
        public string Descripcion { get; set; }
        public string Carreras { get; set; }

        public Asignaturas(string a, string d, string c)
        {
            Asignatura = a;
            Descripcion = d;
            Carreras = c;
        }
    }
}
