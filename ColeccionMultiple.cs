using metodologia_programacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion_clase_1
{
    public class ColeccionMultiple:coleccionable
    {
        private pila p;
        private cola c;
        public ColeccionMultiple(pila p, cola c)
        {
            this.p = p;
            this.c = c;
        }
        public int cuantos()
        {
            int cantidad;
            cantidad = (p.cuantos()+c.cuantos());
            return cantidad;
        }
        public comparable minimo()
        {
            comparable n;
            if((p.minimo()).SosMenor(c.minimo()))
            {
                return p.minimo();
            }
            else
            {
                return c.minimo();
            }
        }
        public comparable maximo()
        {
            comparable n;
            if ((p.maximo()).SosMayor(c.maximo()))
            {
                return p.maximo();
            }
            else
            {
                return c.maximo();
            }
        }
        public void agregar(comparable t){}
        public bool contiene(comparable t)
        {
            if((p.contiene(t))||(c.contiene(t)))
            {
               return true;
            }
            else { return false; }
        }
    }
}
