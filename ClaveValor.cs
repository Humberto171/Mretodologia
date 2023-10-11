using metodologia_programacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mretodologia
{
    public class ClaveValor
    {
        private comparable clave;
        private comparable valor;
        public ClaveValor(comparable clave, comparable valor)
        {
            this.clave = clave;
            this.valor = valor;
        }
        public comparable Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public comparable Valor
        {
            get { return valor; }
            set { valor = value; }
        }

    }
}
