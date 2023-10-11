using metodologia_programacion;
using metodologia_programacion_clase_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mretodologia
{
    public class IteradorDeDiccionario:Iterador
    {

        private List<ClaveValor> lista;
        private int indice;
        public IteradorDeDiccionario(List<ClaveValor> p)
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
            return lista[indice].Clave;
        }
    }
}
