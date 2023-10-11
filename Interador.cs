using metodologia_programacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion_clase_1
{
    //Paso 1: crear interface iterador
    public interface Iterador
    {
        void primero();
        void siguiente();
        bool fin();
        comparable actual();
    }
    //Paso 1: crear interface iterador
    //Paso 2: Implementar iterador concreto
    //Paso 3: crear la interfaz iterable, que tiene la funcion de crear un iterador
    //Paso 4: hacer que los agregados implementen iterable
    //Paso 5: usar dichos iteradores
}
