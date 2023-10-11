using metodologia_programacion;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion_clase_1
{
    //respuesta 3
    //respuesta 5
    //respuesta 6
    public class conjunto:coleccionable,Iterable
    {
        private List<comparable> com;
        public conjunto()
        {
            com = new List<comparable>();
        }
        public int cuantos()
        {
            return com.Count;
        }
        public comparable maximo()
        {
            comparable min = com[0];
            foreach (comparable c in com)
            {
                if (c.SosMenor(min))
                {
                    min = c;
                }
            }
            return min;
        }
        public comparable minimo()
        {
            comparable max = com[0];
            foreach (comparable c in com)
            {
                if (c.SosMayor(max))
                {
                    max = c;
                }
            }
            return max;
        }
        public bool contiene(comparable c)
        {
            foreach (comparable x in com)
            {
                if (x.SosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
        public bool pertenece(comparable c)
        {
           return this.contiene(c);
        }
        public void agregar(comparable c)
        {
            if (!this.contiene(c))
            {
                com.Add(c);
            }
        }
        public Iterador crearIterador()
        {
            return new IteradordeLista(com);
        }
    }
}
