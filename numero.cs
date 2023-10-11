using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion
{
    public class numero : comparable
    {
        private int valor;
        public numero(int v)
        {
            valor = v;
        }
        public int getValor() {return valor; }
        public override string ToString()
        {
            return this.getValor().ToString();
        }
        //implementacion de los metodos de comparable
        public bool SosIgual(comparable c)
        {
            return valor == ((numero)c).getValor();
        }
        public bool SosMenor(comparable c)
        {
            return valor < ((numero)c).getValor();
        }
        public bool SosMayor(comparable c)
        {
            return valor > ((numero)c).getValor();
        }

    }
}
