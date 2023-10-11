using metodologia_programacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion_clase_1
{
    public interface estrategia
    {
        bool sosIgual(Alumno a, Alumno b);
        bool sosMayor(Alumno a, Alumno b);
        bool sosMenor(Alumno a, Alumno b);
    }
}
