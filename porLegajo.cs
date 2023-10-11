using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion_clase_1
{
    public class porLegajo:estrategia
    {
        //respuesta 1
        public bool sosMayor(Alumno a, Alumno b)
        {
            return a.getLegajo() > b.getLegajo();
        }
        public bool sosMenor(Alumno a, Alumno b)
        {
            return a.getLegajo() < b.getLegajo();
        }
        public bool sosIgual(Alumno a, Alumno b)
        {
            return a.getLegajo() == b.getLegajo();
        }

    }
}
