using metodologia_programacion_clase_1;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion
{
    //respuesta 5
    //Paso 4: hacer que los agregados implementen iterable
    public class pila:coleccionable,Iterable
    {
        private List<comparable> elementos;
        public pila()
        {
            elementos = new List<comparable>();
        }
        public void push(comparable c)
        {
            elementos.Add(c);
        }
        public comparable pop() 
        {
            comparable c = elementos[elementos.Count - 1];
            elementos.Remove(c);
            return c;
        }
        public comparable mostrar()
        {
            return elementos[elementos.Count - 1];
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
                if(c.SosMayor(max))
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
