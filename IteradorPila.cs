using metodologia_programacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion_clase_1
{
    //Paso 2: Implementar iterador concreto
    public class IteradordeLista:Iterador
    {
        private List<comparable> lista;
        private int indice;
        public IteradordeLista(List<comparable> p)
        {
            lista = p;
            indice = 0;
        }
        public void primero()
        {
            indice = 0;
        }
        public void siguiente()
        {
            indice++;
        }
        public bool fin()
        {
            return indice == lista.Count;
        }
        public comparable actual()
        {
            return lista[indice];
        }
    }
}
