using metodologia_programacion;
using metodologia_programacion_clase_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mretodologia
{
    //respuesta 4
    //respuesta 5
    //respuesta 6
    public class Diccionario:coleccionable,Iterable
    {
        private List<ClaveValor> lista;
        public Diccionario() 
        {
           lista = new List<ClaveValor>();
        }
        public void AgregarElemento(ClaveValor c)
        {
            bool flag=false;
            foreach (ClaveValor x in lista)
            {
                if(x.Clave.SosIgual(c.Clave))
                {
                    flag = true;
                }
            }
            if(flag==false)
            {
                lista.Add(c);
            }
        }
        
        public comparable ValorDe(comparable clave)
        {
            foreach(ClaveValor x in lista)
            {
                if(x.Clave.SosIgual(clave))
                {
                    return x.Clave;
                }
            }
            return null;
        }
        public comparable maximo()
        {
            comparable max = lista[0].Valor;
            foreach (ClaveValor c in lista)
            {
                if(c.Valor.SosMayor(max))
                {
                    max = c.Valor;
                }
            }
            return max;
        }
        public comparable minimo()
        {
            comparable min = lista[0].Valor;
            foreach (ClaveValor c in lista)
            {
                if (c.Valor.SosMenor(min))
                {
                    min = c.Valor;
                }
            }
            return min;
        }
        public bool contiene(comparable c)
        {
            foreach (ClaveValor x in lista)
            {
                if (x.Valor.SosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }
        public int cuantos()
        {
            return lista.Count;
        }
        public void agregar(comparable c)
        {
            Random rdn1 = new Random();
            comparable n = new numero(rdn1.Next(100000000));
            ClaveValor x = new ClaveValor(n, c);
            if(this.contiene(x.Clave))
            {
                lista.Add(x);
            }

        }
        public Iterador crearIterador()
        {
            return new IteradorDeDiccionario(lista);
        }
    }
}


































































//ttps://la.spankbang.com/8w88h/video/beautiful+japanese+couple+fuck+2+uncensored
