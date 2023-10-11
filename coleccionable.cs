using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion
{
    public interface coleccionable
    {
        int cuantos();
        comparable maximo();
        comparable minimo();
        void agregar(comparable c);
        bool contiene(comparable c);
    }
}
