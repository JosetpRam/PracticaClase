using PracticaClase.Interface;
using PracticaClase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase.Repository
{
    public class AsignaturaRepository : IClasesRepository
    {
        public List<Asignaturas> Asignaturas = new List<Asignaturas>();
        public List<Asignaturas> GetAll()
        {
            Asignaturas.Add(new Asignaturas("Matematicas", "Clase General", "Ing.Computacion"));
            Asignaturas.Add(new Asignaturas("Español", "Clase General", "Ing.Computacion"));
            Asignaturas.Add(new Asignaturas("Entornos", "Clase General", "Ing.Computacion"));
            Asignaturas.Add(new Asignaturas("Ingles", "Clase General", "Ing.Computacion"));
            Asignaturas.Add(new Asignaturas("Sociologia", "Clase General", "Ing.Computacion"));
            Asignaturas.Add(new Asignaturas("Quimica", "Clase General", "Ing.Computacion"));

            return Asignaturas;

        }

    }
}
