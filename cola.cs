using metodologia_programacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion_clase_1
{
    //respuesta 5
    public class cola:coleccionable,Iterable
    {
        private List<comparable> elementos;
        public cola()
        {
            elementos = new List<comparable>();
        }
        public void push(comparable c)
        {
            elementos.Add(c);
        }
        public comparable pop()
        {
            comparable c = elementos[0];
            elementos.Remove(c);
            return c;
        }
        public int cuantos()
        {
            return elementos.Count;
        }
        public void agregar(comparable c)
        {
            push(c);
        }

        public comparable minimo()
        {
            comparable min = elementos[0];
            foreach (comparable c in elementos)
            {
                if (c.SosMenor(min))
                {
                    min = c;
                }
            }
            return min;
        }
        public comparable maximo()
        {
            comparable max = elementos[0];
            foreach (comparable c in elementos)
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
            foreach (comparable i in elementos)
            {
                if (i.SosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
        public Iterador crearIterador()
        {
            return new IteradordeLista(elementos);
        }
    }
}
