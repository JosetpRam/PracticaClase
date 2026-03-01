using PracticaClase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase.Interface
{
    public interface IClasesRepository
    {
        List<Asignaturas> GetAll();
    }
}
