using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion
{
    public interface comparable
    {
        bool SosIgual(comparable c);
        bool SosMenor(comparable c);
        bool SosMayor(comparable c);
    }

}

