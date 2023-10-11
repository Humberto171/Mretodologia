using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion_clase_1
{
    //respuesta 1
    public class porPromedio:estrategia
    {
        public bool sosMayor(Alumno a, Alumno b)
        {
            return a.getPromedio() > b.getPromedio();
        }
        public bool sosMenor(Alumno a, Alumno b)
        {
            return a.getPromedio() < b.getPromedio();
        }
        public bool sosIgual(Alumno a, Alumno b)
        {
            return a.getPromedio() == b.getPromedio();
        }
    }
}
